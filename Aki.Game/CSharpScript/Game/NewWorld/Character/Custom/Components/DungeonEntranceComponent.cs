using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x020070AA RID: 28842
	[NullableContext(1)]
	[Nullable(0)]
	public class DungeonEntranceComponent : EntityComponent
	{
		// Token: 0x06046467 RID: 287847 RVA: 0x01197488 File Offset: 0x01195688
		protected override bool OnStart()
		{
			this.StateComponent = base.Entity.GetComponent<SceneItemStateComponent>();
			this.RestoreCbList = new List<Action>();
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnEntityStatePrechangeInSequence));
			this.HandlePerformanceState(null);
			return true;
		}

		// Token: 0x06046468 RID: 287848 RVA: 0x01197505 File Offset: 0x01195705
		protected override void OnActivate()
		{
		}

		// Token: 0x06046469 RID: 287849 RVA: 0x01197508 File Offset: 0x01195708
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnEntityStatePrechangeInSequence));
			this.RestoreCbList = null;
			return true;
		}

		// Token: 0x0604646A RID: 287850 RVA: 0x01197564 File Offset: 0x01195764
		private void OnEntityStateChange(int stateId, bool isReady)
		{
			this.HandlePerformanceState(null);
		}

		// Token: 0x0604646B RID: 287851 RVA: 0x01197580 File Offset: 0x01195780
		private void OnEntityStatePrechangeInSequence(int stateId)
		{
			this.HandlePerformanceState(new int?(stateId));
		}

		// Token: 0x0604646C RID: 287852 RVA: 0x0119758E File Offset: 0x0119578E
		public void RegisterRestoreCb(Action cb)
		{
			this.RestoreCbList.Add(cb);
		}

		// Token: 0x0604646D RID: 287853 RVA: 0x0119759C File Offset: 0x0119579C
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

		// Token: 0x0604646E RID: 287854 RVA: 0x01197610 File Offset: 0x01195810
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

		// Token: 0x0604646F RID: 287855 RVA: 0x011976D0 File Offset: 0x011958D0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DungeonEntranceComponent dungeonEntranceComponent = (DungeonEntranceComponent)componentTemplate;
			if (base.CanResetComponentProperty("StateComponent"))
			{
				if (dungeonEntranceComponent.StateComponent == null)
				{
					this.StateComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemStateComponent>(this.StateComponent), "StateComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RestoreCbList"))
			{
				if (dungeonEntranceComponent.RestoreCbList == null)
				{
					this.RestoreCbList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<Action>>(this.RestoreCbList), "RestoreCbList"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024D3A RID: 150842
		[Nullable(2)]
		private SceneItemStateComponent StateComponent;

		// Token: 0x04024D3B RID: 150843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Action> RestoreCbList;
	}
}
