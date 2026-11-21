using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006204 RID: 25092
	[NullableContext(2)]
	[Nullable(0)]
	public class DurabilityComponent : EntityComponent
	{
		// Token: 0x170071C3 RID: 29123
		// (get) Token: 0x0603C48A RID: 246922 RVA: 0x0112FC6C File Offset: 0x0112DE6C
		public bool IsDestroyed
		{
			get
			{
				DurabilityComponent.ESceneItemDestroyState? state = this.State;
				DurabilityComponent.ESceneItemDestroyState esceneItemDestroyState = DurabilityComponent.ESceneItemDestroyState.Destroying;
				return state.GetValueOrDefault() >= esceneItemDestroyState & state != null;
			}
		}

		// Token: 0x0603C48B RID: 246923 RVA: 0x0112FC98 File Offset: 0x0112DE98
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

		// Token: 0x0603C48C RID: 246924 RVA: 0x0112FD27 File Offset: 0x0112DF27
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

		// Token: 0x0603C48D RID: 246925 RVA: 0x0112FD60 File Offset: 0x0112DF60
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

		// Token: 0x0603C48E RID: 246926 RVA: 0x0112FDD8 File Offset: 0x0112DFD8
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

		// Token: 0x0603C48F RID: 246927 RVA: 0x0112FE34 File Offset: 0x0112E034
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DurabilityComponent durabilityComponent = (DurabilityComponent)componentTemplate;
			if (durabilityComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
			this.State = durabilityComponent.State;
			if (durabilityComponent.DelayTimerId == null)
			{
				this.DelayTimerId = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DelayTimerId), "DelayTimerId"))
			{
				return false;
			}
			if (durabilityComponent.OnSceneItemDurabilityChange == null)
			{
				this.OnSceneItemDurabilityChange = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnSceneItemDurabilityChange), "OnSceneItemDurabilityChange"))
			{
				return false;
			}
			if (durabilityComponent.DeadActions == null)
			{
				this.DeadActions = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeadActions), "DeadActions"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170071C4 RID: 29124
		// (get) Token: 0x0603C490 RID: 246928 RVA: 0x0112FF0C File Offset: 0x0112E10C
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071C5 RID: 29125
		// (get) Token: 0x0603C491 RID: 246929 RVA: 0x0112FF0F File Offset: 0x0112E10F
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071C6 RID: 29126
		// (get) Token: 0x0603C492 RID: 246930 RVA: 0x0112FF12 File Offset: 0x0112E112
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEB8 RID: 130744
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x0401FEB9 RID: 130745
		private DurabilityComponent.ESceneItemDestroyState? State;

		// Token: 0x0401FEBA RID: 130746
		private TimerHandle DelayTimerId;

		// Token: 0x0401FEBB RID: 130747
		private Action<int> OnSceneItemDurabilityChange;

		// Token: 0x0401FEBC RID: 130748
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> DeadActions;

		// Token: 0x0200BA2F RID: 47663
		[NullableContext(0)]
		private enum ESceneItemDestroyState
		{
			// Token: 0x040395EA RID: 234986
			Alive,
			// Token: 0x040395EB RID: 234987
			Destroying,
			// Token: 0x040395EC RID: 234988
			Destroyed
		}
	}
}
