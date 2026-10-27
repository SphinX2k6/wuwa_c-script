using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007083 RID: 28803
	[NullableContext(2)]
	[Nullable(0)]
	public class DurabilityComponent : EntityComponent
	{
		// Token: 0x17009C1E RID: 39966
		// (get) Token: 0x06046270 RID: 287344 RVA: 0x011866AC File Offset: 0x011848AC
		public bool IsDestroyed
		{
			get
			{
				DurabilityComponent.ESceneItemDestroyState? state = this.State;
				DurabilityComponent.ESceneItemDestroyState esceneItemDestroyState = DurabilityComponent.ESceneItemDestroyState.Destroying;
				return state.GetValueOrDefault() >= esceneItemDestroyState & state != null;
			}
		}

		// Token: 0x06046271 RID: 287345 RVA: 0x011866D8 File Offset: 0x011848D8
		protected override bool OnInit()
		{
			this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
			this.State = new DurabilityComponent.ESceneItemDestroyState?(DurabilityComponent.ESceneItemDestroyState.Alive);
			this.DelayTimerId = null;
			DestructibleItem component = TdUtils.GetComponent<DestructibleItem>(this.CreatureDataComponent.GetPbEntityInitData().ComponentsData, EConfigComponent.DestructibleItem);
			IDurabilityStateConfig durabilityStateConfig = component.DurabilityStateConfig;
			if (durabilityStateConfig == null || !durabilityStateConfig.NonDestructable.GetValueOrDefault())
			{
				this.DeadActions = component.DestructionActions;
			}
			base.Entity.GetComponent<PawnSensoryInfoComponent>().SetLogicRange(ManipulateConfig.Instance.SearchRange);
			return true;
		}

		// Token: 0x06046272 RID: 287346 RVA: 0x01186767 File Offset: 0x01184967
		protected override bool OnStart()
		{
			this.OnSceneItemDurabilityChange = delegate(int durability)
			{
				this.CheckDurablePoint();
			};
			EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.OnSceneItemDurabilityChange, this.OnSceneItemDurabilityChange);
			this.CheckDurablePoint();
			return true;
		}

		// Token: 0x06046273 RID: 287347 RVA: 0x011867A0 File Offset: 0x011849A0
		protected override bool OnEnd()
		{
			if (this.OnSceneItemDurabilityChange != null)
			{
				EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.OnSceneItemDurabilityChange, this.OnSceneItemDurabilityChange);
				this.OnSceneItemDurabilityChange = null;
			}
			this.State = null;
			if (this.DelayTimerId != null && TimerSystem.Instance.Has(this.DelayTimerId))
			{
				TimerSystem.Instance.Remove(this.DelayTimerId);
			}
			this.DelayTimerId = null;
			return true;
		}

		// Token: 0x06046274 RID: 287348 RVA: 0x01186818 File Offset: 0x01184A18
		private void CheckDurablePoint()
		{
			DurabilityComponent.ESceneItemDestroyState? state = this.State;
			DurabilityComponent.ESceneItemDestroyState esceneItemDestroyState = DurabilityComponent.ESceneItemDestroyState.Alive;
			if (!(state.GetValueOrDefault() == esceneItemDestroyState & state != null))
			{
				return;
			}
			if (this.CreatureDataComponent.GetDurabilityValue() > 0)
			{
				return;
			}
			EventSystem.Instance.Emit<Entity>(EEventName.OnSceneItemDurabilityEmpty, base.Entity);
			this.State = new DurabilityComponent.ESceneItemDestroyState?(DurabilityComponent.ESceneItemDestroyState.Destroying);
		}

		// Token: 0x06046275 RID: 287349 RVA: 0x01186874 File Offset: 0x01184A74
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DurabilityComponent durabilityComponent = (DurabilityComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComponent"))
			{
				if (durabilityComponent.CreatureDataComponent == null)
				{
					this.CreatureDataComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("State"))
			{
				this.State = durabilityComponent.State;
			}
			if (base.CanResetComponentProperty("DelayTimerId"))
			{
				if (durabilityComponent.DelayTimerId == null)
				{
					this.DelayTimerId = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.DelayTimerId), "DelayTimerId"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnSceneItemDurabilityChange"))
			{
				if (durabilityComponent.OnSceneItemDurabilityChange == null)
				{
					this.OnSceneItemDurabilityChange = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<int>>(this.OnSceneItemDurabilityChange), "OnSceneItemDurabilityChange"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DeadActions"))
			{
				if (durabilityComponent.DeadActions == null)
				{
					this.DeadActions = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<ActionInfo>>(this.DeadActions), "DeadActions"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024BFD RID: 150525
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04024BFE RID: 150526
		private DurabilityComponent.ESceneItemDestroyState? State;

		// Token: 0x04024BFF RID: 150527
		private TimerHandle DelayTimerId;

		// Token: 0x04024C00 RID: 150528
		private Action<int> OnSceneItemDurabilityChange;

		// Token: 0x04024C01 RID: 150529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> DeadActions;

		// Token: 0x0200CE3E RID: 52798
		[NullableContext(0)]
		private enum ESceneItemDestroyState
		{
			// Token: 0x0403E1BF RID: 254399
			Alive,
			// Token: 0x0403E1C0 RID: 254400
			Destroying,
			// Token: 0x0403E1C1 RID: 254401
			Destroyed
		}
	}
}
