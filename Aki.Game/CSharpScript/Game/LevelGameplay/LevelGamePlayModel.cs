using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Interface;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006985 RID: 27013
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelGamePlayModel : ModelBase
	{
		// Token: 0x060433AD RID: 275373 RVA: 0x01063432 File Offset: 0x01061632
		private void HandleWorldDone()
		{
			this.SetWorldLoad(true);
		}

		// Token: 0x060433AE RID: 275374 RVA: 0x0106343B File Offset: 0x0106163B
		private void OnDisActiveBattleView()
		{
			if (this.LevelRestrictOperationBlockAll)
			{
				OperationRestrictUtils.Instance.SetInputBlockRestrict(false);
			}
		}

		// Token: 0x060433AF RID: 275375 RVA: 0x01063450 File Offset: 0x01061650
		private void OnActiveBattleView()
		{
			if (this.LevelRestrictOperationBlockAll)
			{
				OperationRestrictUtils.Instance.SetInputBlockRestrict(true);
			}
		}

		// Token: 0x060433B0 RID: 275376 RVA: 0x01063468 File Offset: 0x01061668
		protected override bool OnInit()
		{
			this.WorldLoad = false;
			this.WorldTeleport = true;
			this.LoadHandle = new Queue<Action>(4);
			this.PreservedCollisionProfileMap = new WeakMap<UPrimitiveComponent, string>();
			this.EndPlayHookedActors = new WeakSet<AActor>();
			this.GuidePathRegistered = new Dictionary<int, int>();
			this.GuidePathPending = new Dictionary<int, List<Action<IGuidePathVisibilityHost>>>();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.HandleWorldDone));
			EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			return true;
		}

		// Token: 0x060433B1 RID: 275377 RVA: 0x01063510 File Offset: 0x01061710
		public void AddLoadNotify(Action handle)
		{
			this.LoadHandle.Push(handle);
			this.UpdateLoadNotify();
		}

		// Token: 0x060433B2 RID: 275378 RVA: 0x01063524 File Offset: 0x01061724
		public void SetWorldLoad(bool value)
		{
			this.WorldLoad = value;
			this.UpdateLoadNotify();
		}

		// Token: 0x060433B3 RID: 275379 RVA: 0x01063533 File Offset: 0x01061733
		public void SetWorldTeleport(bool worldTeleport)
		{
			this.WorldTeleport = worldTeleport;
			this.UpdateLoadNotify();
		}

		// Token: 0x060433B4 RID: 275380 RVA: 0x01063544 File Offset: 0x01061744
		public void UpdateLoadNotify()
		{
			if (!this.WorldTeleport || !this.WorldLoad)
			{
				return;
			}
			while (this.LoadHandle.Size > 0)
			{
				Action action = this.LoadHandle.Pop();
				if (action != null)
				{
					action();
				}
			}
		}

		// Token: 0x060433B5 RID: 275381 RVA: 0x01063585 File Offset: 0x01061785
		public void ExecuteActionsNew(List<ActionInfo> actions, GeneralContext context, [Nullable(2)] Action<ELevelEventState> finishCallback = null)
		{
			LevelGeneralController.Instance.ExecuteActionsNew(actions, context, finishCallback);
		}

		// Token: 0x060433B6 RID: 275382 RVA: 0x01063594 File Offset: 0x01061794
		public void RegisterGuidePathHost(int pbDataId, int entityId)
		{
			if (pbDataId <= 0 || entityId <= 0)
			{
				return;
			}
			if (this.GuidePathRegistered == null || this.GuidePathPending == null)
			{
				return;
			}
			this.GuidePathRegistered[pbDataId] = entityId;
			List<Action<IGuidePathVisibilityHost>> list;
			if (!this.GuidePathPending.TryGetValue(pbDataId, out list) || list.Count == 0)
			{
				return;
			}
			this.GuidePathPending.Remove(pbDataId);
			SceneItemGuidePathComponent component = EntitySystem.Instance.GetComponent<SceneItemGuidePathComponent>(entityId);
			if (component == null)
			{
				return;
			}
			foreach (Action<IGuidePathVisibilityHost> action in list)
			{
				action(component);
			}
		}

		// Token: 0x060433B7 RID: 275383 RVA: 0x01063640 File Offset: 0x01061840
		public void UnregisterGuidePathHost(int pbDataId, int entityId)
		{
			if (pbDataId <= 0 || entityId <= 0)
			{
				return;
			}
			if (this.GuidePathRegistered == null)
			{
				return;
			}
			int num;
			if (this.GuidePathRegistered.TryGetValue(pbDataId, out num) && num == entityId)
			{
				this.GuidePathRegistered.Remove(pbDataId);
			}
		}

		// Token: 0x060433B8 RID: 275384 RVA: 0x01063680 File Offset: 0x01061880
		[NullableContext(2)]
		public IGuidePathVisibilityHost GetGuidePathHost(int pbDataId)
		{
			if (pbDataId <= 0)
			{
				return null;
			}
			int num;
			if (this.GuidePathRegistered == null || !this.GuidePathRegistered.TryGetValue(pbDataId, out num) || num <= 0)
			{
				return null;
			}
			return EntitySystem.Instance.GetComponent<SceneItemGuidePathComponent>(num);
		}

		// Token: 0x060433B9 RID: 275385 RVA: 0x010636BC File Offset: 0x010618BC
		[return: Nullable(2)]
		public Action RegisterPendingGuidePathHandler(int pbDataId, Action<IGuidePathVisibilityHost> handler)
		{
			if (pbDataId <= 0)
			{
				return null;
			}
			if (this.GuidePathRegistered == null || this.GuidePathPending == null)
			{
				return null;
			}
			IGuidePathVisibilityHost guidePathHost = this.GetGuidePathHost(pbDataId);
			if (guidePathHost != null)
			{
				handler(guidePathHost);
				return null;
			}
			List<Action<IGuidePathVisibilityHost>> list;
			if (!this.GuidePathPending.TryGetValue(pbDataId, out list))
			{
				list = new List<Action<IGuidePathVisibilityHost>>();
				this.GuidePathPending[pbDataId] = list;
			}
			list.Add(handler);
			return delegate()
			{
				List<Action<IGuidePathVisibilityHost>> list2;
				if (this.GuidePathPending == null || !this.GuidePathPending.TryGetValue(pbDataId, out list2))
				{
					return;
				}
				int num = list2.IndexOf(handler);
				if (num >= 0)
				{
					list2.RemoveAt(num);
				}
				if (list2.Count == 0)
				{
					Dictionary<int, List<Action<IGuidePathVisibilityHost>>> guidePathPending = this.GuidePathPending;
					if (guidePathPending == null)
					{
						return;
					}
					guidePathPending.Remove(pbDataId);
				}
			};
		}

		// Token: 0x060433BA RID: 275386 RVA: 0x01063764 File Offset: 0x01061964
		protected override bool OnClear()
		{
			this.WorldLoad = false;
			this.WorldTeleport = false;
			this.LoadHandle = null;
			this.PreservedCollisionProfileMap = null;
			this.EndPlayHookedActors = null;
			Dictionary<int, int> guidePathRegistered = this.GuidePathRegistered;
			if (guidePathRegistered != null)
			{
				guidePathRegistered.Clear();
			}
			this.GuidePathRegistered = null;
			Dictionary<int, List<Action<IGuidePathVisibilityHost>>> guidePathPending = this.GuidePathPending;
			if (guidePathPending != null)
			{
				guidePathPending.Clear();
			}
			this.GuidePathPending = null;
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.HandleWorldDone));
			EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			LevelEventLockMaskModule.Clear();
			return true;
		}

		// Token: 0x1700983A RID: 38970
		// (get) Token: 0x060433BB RID: 275387 RVA: 0x0106381E File Offset: 0x01061A1E
		public static LevelGamePlayModel Instance
		{
			get
			{
				return LevelGamePlayModel._Instance;
			}
		}

		// Token: 0x060433BC RID: 275388 RVA: 0x01063825 File Offset: 0x01061A25
		public static LevelGamePlayModel GetOrCreateInstance()
		{
			if (LevelGamePlayModel._Instance == null)
			{
				LevelGamePlayModel.CreateInstance();
			}
			return LevelGamePlayModel._Instance;
		}

		// Token: 0x060433BD RID: 275389 RVA: 0x01063839 File Offset: 0x01061A39
		public static bool CreateInstance()
		{
			if (LevelGamePlayModel._Instance != null)
			{
				return true;
			}
			LevelGamePlayModel._Instance = new LevelGamePlayModel();
			return true;
		}

		// Token: 0x060433BE RID: 275390 RVA: 0x0106384F File Offset: 0x01061A4F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060433BF RID: 275391 RVA: 0x01063851 File Offset: 0x01061A51
		public static void ResetStaticDefaultValue()
		{
			LevelGamePlayModel._Instance = null;
		}

		// Token: 0x060433C0 RID: 275392 RVA: 0x01063859 File Offset: 0x01061A59
		static LevelGamePlayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelGamePlayModel.CreateStaticDefaultValue), new Action(LevelGamePlayModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023052 RID: 143442
		private bool WorldLoad;

		// Token: 0x04023053 RID: 143443
		private bool WorldTeleport;

		// Token: 0x04023054 RID: 143444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<Action> LoadHandle;

		// Token: 0x04023055 RID: 143445
		public bool LevelRestrictOperationBlockAll;

		// Token: 0x04023056 RID: 143446
		[Nullable(2)]
		public IFlowerPollutionManager FlowerPollutionManager;

		// Token: 0x04023057 RID: 143447
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public WeakMap<UPrimitiveComponent, string> PreservedCollisionProfileMap;

		// Token: 0x04023058 RID: 143448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public WeakSet<AActor> EndPlayHookedActors;

		// Token: 0x04023059 RID: 143449
		[Nullable(2)]
		private Dictionary<int, int> GuidePathRegistered;

		// Token: 0x0402305A RID: 143450
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Dictionary<int, List<Action<IGuidePathVisibilityHost>>> GuidePathPending;

		// Token: 0x0402305B RID: 143451
		[Nullable(2)]
		private static LevelGamePlayModel _Instance;
	}
}
