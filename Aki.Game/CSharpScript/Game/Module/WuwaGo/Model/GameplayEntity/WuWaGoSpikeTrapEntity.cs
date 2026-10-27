using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004752 RID: 18258
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoSpikeTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x17007740 RID: 30528
		// (get) Token: 0x0602FB66 RID: 195430 RVA: 0x00B0DBF3 File Offset: 0x00B0BDF3
		public bool IsCompleted
		{
			get
			{
				return base.State == EGameplayEntityState.Completed;
			}
		}

		// Token: 0x17007741 RID: 30529
		// (get) Token: 0x0602FB67 RID: 195431 RVA: 0x00B0DBFE File Offset: 0x00B0BDFE
		public int CurrentStepCount
		{
			get
			{
				return this.StepCount;
			}
		}

		// Token: 0x0602FB68 RID: 195432 RVA: 0x00B0DC06 File Offset: 0x00B0BE06
		public WuWaGoSpikeTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoSpikeTrap config) : base(EWuWaGoEntityType.SpikeTrap, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x0602FB69 RID: 195433 RVA: 0x00B0DC12 File Offset: 0x00B0BE12
		public override void Destroy()
		{
			this.StepCount = 0;
			this.OccupantId = 0;
			this.PrevOccupantId = 0;
			this.IsDirty = false;
			base.Destroy();
		}

		// Token: 0x0602FB6A RID: 195434 RVA: 0x00B0DC36 File Offset: 0x00B0BE36
		public override IRollbackCapture CaptureRollback()
		{
			return new SpikeTrapRollbackCapture(this);
		}

		// Token: 0x0602FB6B RID: 195435 RVA: 0x00B0DC3E File Offset: 0x00B0BE3E
		public int PeekOccupantId()
		{
			return this.OccupantId;
		}

		// Token: 0x0602FB6C RID: 195436 RVA: 0x00B0DC46 File Offset: 0x00B0BE46
		public int PeekPrevOccupantId()
		{
			return this.PrevOccupantId;
		}

		// Token: 0x0602FB6D RID: 195437 RVA: 0x00B0DC4E File Offset: 0x00B0BE4E
		public bool PeekIsDirty()
		{
			return this.IsDirty;
		}

		// Token: 0x0602FB6E RID: 195438 RVA: 0x00B0DC56 File Offset: 0x00B0BE56
		public void RestoreOccupantTrackingForRollback(int stepCount, int occupantId, int prevOccupantId, bool isDirty)
		{
			this.StepCount = stepCount;
			this.OccupantId = occupantId;
			this.PrevOccupantId = prevOccupantId;
			this.IsDirty = isDirty;
			this.SyncPresentationForRollback();
		}

		// Token: 0x0602FB6F RID: 195439 RVA: 0x00B0DC7B File Offset: 0x00B0BE7B
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602FB70 RID: 195440 RVA: 0x00B0DC8B File Offset: 0x00B0BE8B
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x0602FB71 RID: 195441 RVA: 0x00B0DCA2 File Offset: 0x00B0BEA2
		[NullableContext(2)]
		protected override void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (nextGrid == null)
			{
				return;
			}
			nextGrid.AddOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
		}

		// Token: 0x0602FB72 RID: 195442 RVA: 0x00B0DCBA File Offset: 0x00B0BEBA
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.UpdateOccupant(currentUnitId);
		}

		// Token: 0x0602FB73 RID: 195443 RVA: 0x00B0DCC3 File Offset: 0x00B0BEC3
		private void UpdateOccupant(int unitId)
		{
			if (this.OccupantId == unitId)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.PrevOccupantId = this.OccupantId;
			this.OccupantId = unitId;
			this.IsDirty = true;
		}

		// Token: 0x0602FB74 RID: 195444 RVA: 0x00B0DCEF File Offset: 0x00B0BEEF
		public void ResetOccupantTrackingBaseline(int unitId)
		{
			this.OccupantId = unitId;
			this.PrevOccupantId = unitId;
			this.IsDirty = false;
		}

		// Token: 0x0602FB75 RID: 195445 RVA: 0x00B0DD08 File Offset: 0x00B0BF08
		public int? ConsumeEnterOccupantId()
		{
			if (!this.IsDirty)
			{
				return null;
			}
			base.MarkRollbackDirty();
			this.IsDirty = false;
			int num = (this.PrevOccupantId != 0) ? 1 : 0;
			bool flag = this.OccupantId != 0;
			if (num == 0 && flag)
			{
				return new int?(this.OccupantId);
			}
			return null;
		}

		// Token: 0x0602FB76 RID: 195446 RVA: 0x00B0DD63 File Offset: 0x00B0BF63
		public bool OnStepped()
		{
			if (base.State == EGameplayEntityState.Completed)
			{
				return true;
			}
			base.MarkRollbackDirty();
			this.StepCount++;
			if (this.StepCount == 1)
			{
				this.SetState(EGameplayEntityState.Activated);
				return false;
			}
			this.SetState(EGameplayEntityState.Completed);
			return true;
		}

		// Token: 0x0602FB77 RID: 195447 RVA: 0x00B0DDA0 File Offset: 0x00B0BFA0
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602FB78 RID: 195448 RVA: 0x00B0DDA8 File Offset: 0x00B0BFA8
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04019C0C RID: 105484
		private int StepCount;

		// Token: 0x04019C0D RID: 105485
		private int OccupantId;

		// Token: 0x04019C0E RID: 105486
		private int PrevOccupantId;

		// Token: 0x04019C0F RID: 105487
		private bool IsDirty;
	}
}
