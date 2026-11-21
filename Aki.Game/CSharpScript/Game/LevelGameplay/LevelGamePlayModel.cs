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
	// Token: 0x02005AE1 RID: 23265
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelGamePlayModel : ModelBase
	{
		// Token: 0x060393E5 RID: 234469 RVA: 0x0100769A File Offset: 0x0100589A
		private void HandleWorldDone()
		{
			this.SetWorldLoad(true);
		}

		// Token: 0x060393E6 RID: 234470 RVA: 0x010076A3 File Offset: 0x010058A3
		private void OnDisActiveBattleView()
		{
			if (this.LevelRestrictOperationBlockAll)
			{
				OperationRestrictUtils.Instance.SetInputBlockRestrict(false);
			}
		}

		// Token: 0x060393E7 RID: 234471 RVA: 0x010076B8 File Offset: 0x010058B8
		private void OnActiveBattleView()
		{
			if (this.LevelRestrictOperationBlockAll)
			{
				OperationRestrictUtils.Instance.SetInputBlockRestrict(true);
			}
		}

		// Token: 0x060393E8 RID: 234472 RVA: 0x010076D0 File Offset: 0x010058D0
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

		// Token: 0x060393E9 RID: 234473 RVA: 0x01007778 File Offset: 0x01005978
		public void AddLoadNotify(Action handle)
		{
			this.LoadHandle.Push(handle);
			this.UpdateLoadNotify();
		}

		// Token: 0x060393EA RID: 234474 RVA: 0x0100778C File Offset: 0x0100598C
		public void SetWorldLoad(bool value)
		{
			this.WorldLoad = value;
			this.UpdateLoadNotify();
		}

		// Token: 0x060393EB RID: 234475 RVA: 0x0100779B File Offset: 0x0100599B
		public void SetWorldTeleport(bool worldTeleport)
		{
			this.WorldTeleport = worldTeleport;
			this.UpdateLoadNotify();
		}

		// Token: 0x060393EC RID: 234476 RVA: 0x010077AC File Offset: 0x010059AC
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

		// Token: 0x060393ED RID: 234477 RVA: 0x010077ED File Offset: 0x010059ED
		public void ExecuteActionsNew(List<ActionInfo> actions, GeneralContext context, [Nullable(2)] Action<ELevelEventState> finishCallback = null)
		{
			LevelGeneralController.Instance.ExecuteActionsNew(actions, context, finishCallback);
		}

		// Token: 0x060393EE RID: 234478 RVA: 0x010077FC File Offset: 0x010059FC
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

		// Token: 0x060393EF RID: 234479 RVA: 0x010078A8 File Offset: 0x01005AA8
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

		// Token: 0x060393F0 RID: 234480 RVA: 0x010078E8 File Offset: 0x01005AE8
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

		// Token: 0x060393F1 RID: 234481 RVA: 0x01007924 File Offset: 0x01005B24
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

		// Token: 0x060393F2 RID: 234482 RVA: 0x010079CC File Offset: 0x01005BCC
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

		// Token: 0x17006D1A RID: 27930
		// (get) Token: 0x060393F3 RID: 234483 RVA: 0x01007A86 File Offset: 0x01005C86
		public static LevelGamePlayModel Instance
		{
			get
			{
				return LevelGamePlayModel._Instance;
			}
		}

		// Token: 0x060393F4 RID: 234484 RVA: 0x01007A8D File Offset: 0x01005C8D
		public static LevelGamePlayModel GetOrCreateInstance()
		{
			if (LevelGamePlayModel._Instance == null)
			{
				LevelGamePlayModel.CreateInstance();
			}
			return LevelGamePlayModel._Instance;
		}

		// Token: 0x060393F5 RID: 234485 RVA: 0x01007AA1 File Offset: 0x01005CA1
		public static bool CreateInstance()
		{
			if (LevelGamePlayModel._Instance != null)
			{
				return true;
			}
			LevelGamePlayModel._Instance = new LevelGamePlayModel();
			return true;
		}

		// Token: 0x060393F6 RID: 234486 RVA: 0x01007AB7 File Offset: 0x01005CB7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060393F7 RID: 234487 RVA: 0x01007AB9 File Offset: 0x01005CB9
		public static void ResetStaticDefaultValue()
		{
			LevelGamePlayModel._Instance = null;
		}

		// Token: 0x060393F8 RID: 234488 RVA: 0x01007AC1 File Offset: 0x01005CC1
		static LevelGamePlayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelGamePlayModel.CreateStaticDefaultValue), new Action(LevelGamePlayModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E23C RID: 123452
		private bool WorldLoad;

		// Token: 0x0401E23D RID: 123453
		private bool WorldTeleport;

		// Token: 0x0401E23E RID: 123454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<Action> LoadHandle;

		// Token: 0x0401E23F RID: 123455
		public bool LevelRestrictOperationBlockAll;

		// Token: 0x0401E240 RID: 123456
		[Nullable(2)]
		public IFlowerPollutionManager FlowerPollutionManager;

		// Token: 0x0401E241 RID: 123457
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public WeakMap<UPrimitiveComponent, string> PreservedCollisionProfileMap;

		// Token: 0x0401E242 RID: 123458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public WeakSet<AActor> EndPlayHookedActors;

		// Token: 0x0401E243 RID: 123459
		[Nullable(2)]
		private Dictionary<int, int> GuidePathRegistered;

		// Token: 0x0401E244 RID: 123460
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Dictionary<int, List<Action<IGuidePathVisibilityHost>>> GuidePathPending;

		// Token: 0x0401E245 RID: 123461
		[Nullable(2)]
		private static LevelGamePlayModel _Instance;
	}
}
