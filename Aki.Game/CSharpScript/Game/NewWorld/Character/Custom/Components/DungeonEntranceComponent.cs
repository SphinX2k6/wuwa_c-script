using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x02006309 RID: 25353
	[NullableContext(1)]
	[Nullable(0)]
	public class DungeonEntranceComponent : EntityComponent
	{
		// Token: 0x0603D537 RID: 251191 RVA: 0x011B97D4 File Offset: 0x011B79D4
		protected override bool OnStart()
		{
			this.StateComponent = base.Entity.GetComponent<SceneItemStateComponent>();
			this.RestoreCbList = new List<Action>();
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnEntityStatePrechangeInSequence));
			this.HandlePerformanceState(null);
			return true;
		}

		// Token: 0x0603D538 RID: 251192 RVA: 0x011B9851 File Offset: 0x011B7A51
		protected override void OnActivate()
		{
		}

		// Token: 0x0603D539 RID: 251193 RVA: 0x011B9854 File Offset: 0x011B7A54
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnEntityStatePrechangeInSequence));
			this.RestoreCbList = null;
			return true;
		}

		// Token: 0x0603D53A RID: 251194 RVA: 0x011B98B0 File Offset: 0x011B7AB0
		private void OnEntityStateChange(int stateId, bool isReady)
		{
			this.HandlePerformanceState(null);
		}

		// Token: 0x0603D53B RID: 251195 RVA: 0x011B98CC File Offset: 0x011B7ACC
		private void OnEntityStatePrechangeInSequence(int stateId)
		{
			this.HandlePerformanceState(new int?(stateId));
		}

		// Token: 0x0603D53C RID: 251196 RVA: 0x011B98DA File Offset: 0x011B7ADA
		public void RegisterRestoreCb(Action cb)
		{
			this.RestoreCbList.Add(cb);
		}

		// Token: 0x0603D53D RID: 251197 RVA: 0x011B98E8 File Offset: 0x011B7AE8
		public void Restore()
		{
			if (this.RestoreCbList == null || this.RestoreCbList.Count == 0)
			{
				return;
			}
			foreach (Action action in this.RestoreCbList)
			{
				action();
			}
			this.RestoreCbList.Clear();
		}

		// Token: 0x0603D53E RID: 251198 RVA: 0x011B995C File Offset: 0x011B7B5C
		private void HandlePerformanceState(int? stateId = null)
		{
			if (stateId != null)
			{
				int? num = stateId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					num = stateId;
					num2 = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"];
					if (num.GetValueOrDefault() == num2 & num != null)
					{
						this.StateComponent.ChangePerformanceState(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.激活"], false, false);
					}
					return;
				}
			}
			SceneItemStateComponent stateComponent = this.StateComponent;
			if (!(((stateComponent != null) ? new SceneItemStateComponent.ESceneItemState?(stateComponent.State) : null) != SceneItemStateComponent.ESceneItemState.Active))
			{
				this.StateComponent.ChangePerformanceState(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.激活"], false, false);
			}
		}

		// Token: 0x0603D53F RID: 251199 RVA: 0x011B9A1C File Offset: 0x011B7C1C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DungeonEntranceComponent dungeonEntranceComponent = (DungeonEntranceComponent)componentTemplate;
			if (dungeonEntranceComponent.StateComponent == null)
			{
				this.StateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComponent), "StateComponent"))
			{
				return false;
			}
			if (dungeonEntranceComponent.RestoreCbList == null)
			{
				this.RestoreCbList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RestoreCbList), "RestoreCbList"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007417 RID: 29719
		// (get) Token: 0x0603D540 RID: 251200 RVA: 0x011B9A92 File Offset: 0x011B7C92
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007418 RID: 29720
		// (get) Token: 0x0603D541 RID: 251201 RVA: 0x011B9A95 File Offset: 0x011B7C95
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007419 RID: 29721
		// (get) Token: 0x0603D542 RID: 251202 RVA: 0x011B9A98 File Offset: 0x011B7C98
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402087E RID: 133246
		[Nullable(2)]
		private SceneItemStateComponent StateComponent;

		// Token: 0x0402087F RID: 133247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Action> RestoreCbList;
	}
}
