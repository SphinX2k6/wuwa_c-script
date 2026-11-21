using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.Pawn.SensoryInfo;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061EF RID: 25071
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnSensoryComponent : EntityComponent
	{
		// Token: 0x0603C358 RID: 246616 RVA: 0x0112690C File Offset: 0x01124B0C
		protected override bool OnInit()
		{
			this.LastSensoryRange = 0.0;
			this.IntervalTime = 0f;
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.LastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.SensoryInfoController = new SensoryInfoController();
			return true;
		}

		// Token: 0x0603C359 RID: 246617 RVA: 0x01126966 File Offset: 0x01124B66
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

		// Token: 0x0603C35A RID: 246618 RVA: 0x01126993 File Offset: 0x01124B93
		public void RemoveSensoryInfo(int key)
		{
			this.SensoryInfoController.RemoveSensoryInfo(key);
			this.SetSensoryRange();
		}

		// Token: 0x0603C35B RID: 246619 RVA: 0x011269A8 File Offset: 0x01124BA8
		private void SetSensoryRange()
		{
			double maxSensoryRange = this.SensoryInfoController.MaxSensoryRange;
			if (this.LastSensoryRange != maxSensoryRange)
			{
				this.LastSensoryRange = maxSensoryRange;
			}
		}

		// Token: 0x0603C35C RID: 246620 RVA: 0x011269D4 File Offset: 0x01124BD4
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

		// Token: 0x0603C35D RID: 246621 RVA: 0x01126AC8 File Offset: 0x01124CC8
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

		// Token: 0x0603C35E RID: 246622 RVA: 0x01126AE8 File Offset: 0x01124CE8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnSensoryComponent pawnSensoryComponent = (PawnSensoryComponent)componentTemplate;
			this.LastSensoryRange = pawnSensoryComponent.LastSensoryRange;
			if (pawnSensoryComponent.SensoryInfoController == null)
			{
				this.SensoryInfoController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SensoryInfoController), "SensoryInfoController"))
			{
				return false;
			}
			this.IntervalTime = pawnSensoryComponent.IntervalTime;
			if (pawnSensoryComponent.TmpHandles != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpHandles), "TmpHandles"))
			{
				return false;
			}
			if (pawnSensoryComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			return pawnSensoryComponent.LastLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLocation), "LastLocation");
		}

		// Token: 0x1700719F RID: 29087
		// (get) Token: 0x0603C35F RID: 246623 RVA: 0x01126BBA File Offset: 0x01124DBA
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071A0 RID: 29088
		// (get) Token: 0x0603C360 RID: 246624 RVA: 0x01126BBD File Offset: 0x01124DBD
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071A1 RID: 29089
		// (get) Token: 0x0603C361 RID: 246625 RVA: 0x01126BC0 File Offset: 0x01124DC0
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FDE7 RID: 130535
		private const float TICK_INTERVAL_TIME = 1000f;

		// Token: 0x0401FDE8 RID: 130536
		private double LastSensoryRange;

		// Token: 0x0401FDE9 RID: 130537
		[Nullable(2)]
		private SensoryInfoController SensoryInfoController;

		// Token: 0x0401FDEA RID: 130538
		private float IntervalTime;

		// Token: 0x0401FDEB RID: 130539
		private readonly List<EntityHandle> TmpHandles = new List<EntityHandle>();

		// Token: 0x0401FDEC RID: 130540
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x0401FDED RID: 130541
		private readonly Vector LastLocation = Vector.Create();
	}
}
