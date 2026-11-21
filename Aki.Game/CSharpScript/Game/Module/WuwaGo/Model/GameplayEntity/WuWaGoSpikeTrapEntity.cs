using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003683 RID: 13955
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoSpikeTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x06024330 RID: 148272 RVA: 0x00A3DBE7 File Offset: 0x00A3BDE7
		public bool IsCompleted
		{
			get
			{
				return base.State == EGameplayEntityState.Completed;
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x06024331 RID: 148273 RVA: 0x00A3DBF2 File Offset: 0x00A3BDF2
		public int CurrentStepCount
		{
			get
			{
				return this.StepCount;
			}
		}

		// Token: 0x06024332 RID: 148274 RVA: 0x00A3DBFA File Offset: 0x00A3BDFA
		public WuWaGoSpikeTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoSpikeTrap config) : base(EWuWaGoEntityType.SpikeTrap, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x06024333 RID: 148275 RVA: 0x00A3DC06 File Offset: 0x00A3BE06
		public override void Destroy()
		{
			this.StepCount = 0;
			this.OccupantId = 0;
			this.PrevOccupantId = 0;
			this.IsDirty = false;
			base.Destroy();
		}

		// Token: 0x06024334 RID: 148276 RVA: 0x00A3DC2A File Offset: 0x00A3BE2A
		public override IRollbackCapture CaptureRollback()
		{
			return new SpikeTrapRollbackCapture(this);
		}

		// Token: 0x06024335 RID: 148277 RVA: 0x00A3DC32 File Offset: 0x00A3BE32
		public int PeekOccupantId()
		{
			return this.OccupantId;
		}

		// Token: 0x06024336 RID: 148278 RVA: 0x00A3DC3A File Offset: 0x00A3BE3A
		public int PeekPrevOccupantId()
		{
			return this.PrevOccupantId;
		}

		// Token: 0x06024337 RID: 148279 RVA: 0x00A3DC42 File Offset: 0x00A3BE42
		public bool PeekIsDirty()
		{
			return this.IsDirty;
		}

		// Token: 0x06024338 RID: 148280 RVA: 0x00A3DC4A File Offset: 0x00A3BE4A
		public void RestoreOccupantTrackingForRollback(int stepCount, int occupantId, int prevOccupantId, bool isDirty)
		{
			this.StepCount = stepCount;
			this.OccupantId = occupantId;
			this.PrevOccupantId = prevOccupantId;
			this.IsDirty = isDirty;
			this.SyncPresentationForRollback();
		}

		// Token: 0x06024339 RID: 148281 RVA: 0x00A3DC6F File Offset: 0x00A3BE6F
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602433A RID: 148282 RVA: 0x00A3DC7F File Offset: 0x00A3BE7F
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x0602433B RID: 148283 RVA: 0x00A3DC96 File Offset: 0x00A3BE96
		[NullableContext(2)]
		protected override void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (nextGrid == null)
			{
				return;
			}
			nextGrid.AddOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
		}

		// Token: 0x0602433C RID: 148284 RVA: 0x00A3DCAE File Offset: 0x00A3BEAE
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.UpdateOccupant(currentUnitId);
		}

		// Token: 0x0602433D RID: 148285 RVA: 0x00A3DCB7 File Offset: 0x00A3BEB7
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

		// Token: 0x0602433E RID: 148286 RVA: 0x00A3DCE3 File Offset: 0x00A3BEE3
		public void ResetOccupantTrackingBaseline(int unitId)
		{
			this.OccupantId = unitId;
			this.PrevOccupantId = unitId;
			this.IsDirty = false;
		}

		// Token: 0x0602433F RID: 148287 RVA: 0x00A3DCFC File Offset: 0x00A3BEFC
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

		// Token: 0x06024340 RID: 148288 RVA: 0x00A3DD57 File Offset: 0x00A3BF57
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

		// Token: 0x06024341 RID: 148289 RVA: 0x00A3DD94 File Offset: 0x00A3BF94
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x06024342 RID: 148290 RVA: 0x00A3DD9C File Offset: 0x00A3BF9C
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x040142BC RID: 82620
		private int StepCount;

		// Token: 0x040142BD RID: 82621
		private int OccupantId;

		// Token: 0x040142BE RID: 82622
		private int PrevOccupantId;

		// Token: 0x040142BF RID: 82623
		private bool IsDirty;
	}
}
