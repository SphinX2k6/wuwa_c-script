using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.Pawn.SensoryInfo;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x0200706E RID: 28782
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnSensoryComponent : EntityComponent
	{
		// Token: 0x06046154 RID: 287060 RVA: 0x0117CFD8 File Offset: 0x0117B1D8
		protected override bool OnInit()
		{
			this.LastSensoryRange = 0.0;
			this.IntervalTime = 0f;
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.SensoryInfoController = new SensoryInfoController();
			return true;
		}

		// Token: 0x06046155 RID: 287061 RVA: 0x0117D032 File Offset: 0x0117B232
		public int AddSensoryInfo(BaseSensoryInfo sensoryParam)
		{
			if (this.ActorComp == null)
			{
				this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			}
			int result = this.SensoryInfoController.AddSensoryInfo(sensoryParam);
			this.SetSensoryRange();
			return result;
		}

		// Token: 0x06046156 RID: 287062 RVA: 0x0117D05F File Offset: 0x0117B25F
		public void RemoveSensoryInfo(int key)
		{
			this.SensoryInfoController.RemoveSensoryInfo(key);
			this.SetSensoryRange();
		}

		// Token: 0x06046157 RID: 287063 RVA: 0x0117D074 File Offset: 0x0117B274
		private void SetSensoryRange()
		{
			double maxSensoryRange = this.SensoryInfoController.MaxSensoryRange;
			if (this.LastSensoryRange != maxSensoryRange)
			{
				this.LastSensoryRange = maxSensoryRange;
			}
		}

		// Token: 0x06046158 RID: 287064 RVA: 0x0117D0A0 File Offset: 0x0117B2A0
		protected override void OnTick(float delta)
		{
			if (this.ActorComp == null || this.SensoryInfoController == null || this.SensoryInfoController.SensoryInfoType == 0)
			{
				return;
			}
			this.SensoryInfoController.Tick(delta);
			this.IntervalTime += delta;
			if (this.IntervalTime < 1000f)
			{
				return;
			}
			this.IntervalTime = 0f;
			if (this.TmpHandles != null)
			{
				if (!this.LastLocation.Equals(this.ActorComp.ActorLocationProxy, 9.999999747378752E-05))
				{
					this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				}
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(this.ActorComp.ActorLocationProxy, (float)this.LastSensoryRange, EEntityTypeQuery.SceneItemOrCharacter, this.TmpHandles, true);
				this.SensoryInfoController.HandleEntities(this.TmpHandles.ToArray(), this.ActorComp.ActorLocationProxy, base.Entity.Id);
			}
		}

		// Token: 0x06046159 RID: 287065 RVA: 0x0117D194 File Offset: 0x0117B394
		protected override bool OnClear()
		{
			this.TmpHandles.Clear();
			SensoryInfoController sensoryInfoController = this.SensoryInfoController;
			if (sensoryInfoController != null)
			{
				sensoryInfoController.Clear();
			}
			return true;
		}

		// Token: 0x0604615A RID: 287066 RVA: 0x0117D1B4 File Offset: 0x0117B3B4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnSensoryComponent pawnSensoryComponent = (PawnSensoryComponent)componentTemplate;
			if (base.CanResetComponentProperty("LastSensoryRange"))
			{
				this.LastSensoryRange = pawnSensoryComponent.LastSensoryRange;
			}
			if (base.CanResetComponentProperty("SensoryInfoController"))
			{
				if (pawnSensoryComponent.SensoryInfoController == null)
				{
					this.SensoryInfoController = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SensoryInfoController>(this.SensoryInfoController), "SensoryInfoController"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IntervalTime"))
			{
				this.IntervalTime = pawnSensoryComponent.IntervalTime;
			}
			if (base.CanResetComponentProperty("TmpHandles") && pawnSensoryComponent.TmpHandles != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<EntityHandle>>(this.TmpHandles), "TmpHandles"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (pawnSensoryComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			return !base.CanResetComponentProperty("LastLocation") || pawnSensoryComponent.LastLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastLocation), "LastLocation");
		}

		// Token: 0x04024B2C RID: 150316
		private const float TICK_INTERVAL_TIME = 1000f;

		// Token: 0x04024B2D RID: 150317
		private double LastSensoryRange;

		// Token: 0x04024B2E RID: 150318
		[Nullable(2)]
		private SensoryInfoController SensoryInfoController;

		// Token: 0x04024B2F RID: 150319
		private float IntervalTime;

		// Token: 0x04024B30 RID: 150320
		private readonly List<EntityHandle> TmpHandles = new List<EntityHandle>();

		// Token: 0x04024B31 RID: 150321
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x04024B32 RID: 150322
		private readonly Vector LastLocation = Vector.Create();
	}
}
