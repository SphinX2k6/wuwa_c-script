using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474C RID: 18252
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoPressureTriggerEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FB3B RID: 195387 RVA: 0x00B0D89A File Offset: 0x00B0BA9A
		public WuWaGoPressureTriggerEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoPressureTrigger config) : base(EWuWaGoEntityType.PressureTrigger, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x17007737 RID: 30519
		// (get) Token: 0x0602FB3C RID: 195388 RVA: 0x00B0D8C0 File Offset: 0x00B0BAC0
		// (set) Token: 0x0602FB3D RID: 195389 RVA: 0x00B0D8C8 File Offset: 0x00B0BAC8
		public int CurrentOccupantId { get; private set; }

		// Token: 0x17007738 RID: 30520
		// (get) Token: 0x0602FB3E RID: 195390 RVA: 0x00B0D8D1 File Offset: 0x00B0BAD1
		// (set) Token: 0x0602FB3F RID: 195391 RVA: 0x00B0D8D9 File Offset: 0x00B0BAD9
		public bool Dirty { get; private set; }

		// Token: 0x17007739 RID: 30521
		// (get) Token: 0x0602FB40 RID: 195392 RVA: 0x00B0D8E2 File Offset: 0x00B0BAE2
		public bool IsOccupied
		{
			get
			{
				return this.CurrentOccupantId != 0;
			}
		}

		// Token: 0x0602FB41 RID: 195393 RVA: 0x00B0D8ED File Offset: 0x00B0BAED
		public override void Destroy()
		{
			this.CurrentOccupantId = 0;
			this.Dirty = false;
			base.Destroy();
		}

		// Token: 0x0602FB42 RID: 195394 RVA: 0x00B0D903 File Offset: 0x00B0BB03
		public override IRollbackCapture CaptureRollback()
		{
			return new PressureTriggerRollbackCapture(this);
		}

		// Token: 0x0602FB43 RID: 195395 RVA: 0x00B0D90B File Offset: 0x00B0BB0B
		public void RestoreOccupantStateForRollback(int occupantId, bool isDirty)
		{
			this.CurrentOccupantId = occupantId;
			this.Dirty = isDirty;
		}

		// Token: 0x0602FB44 RID: 195396 RVA: 0x00B0D91B File Offset: 0x00B0BB1B
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602FB45 RID: 195397 RVA: 0x00B0D92B File Offset: 0x00B0BB2B
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x0602FB46 RID: 195398 RVA: 0x00B0D942 File Offset: 0x00B0BB42
		[NullableContext(2)]
		protected override void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (nextGrid == null)
			{
				return;
			}
			nextGrid.AddOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			this.UpdateOccupant(nextGrid.OccupiedUnitId);
		}

		// Token: 0x0602FB47 RID: 195399 RVA: 0x00B0D966 File Offset: 0x00B0BB66
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.UpdateOccupant(currentUnitId);
		}

		// Token: 0x0602FB48 RID: 195400 RVA: 0x00B0D96F File Offset: 0x00B0BB6F
		private void UpdateOccupant(int unitId)
		{
			if (this.CurrentOccupantId == unitId)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.CurrentOccupantId = unitId;
			this.Dirty = true;
		}

		// Token: 0x0602FB49 RID: 195401 RVA: 0x00B0D98F File Offset: 0x00B0BB8F
		public bool ConsumeDirtyFlag()
		{
			bool dirty = this.Dirty;
			if (dirty)
			{
				base.MarkRollbackDirty();
				this.Dirty = false;
			}
			return dirty;
		}

		// Token: 0x0602FB4A RID: 195402 RVA: 0x00B0D9A7 File Offset: 0x00B0BBA7
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602FB4B RID: 195403 RVA: 0x00B0D9AF File Offset: 0x00B0BBAF
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04019C00 RID: 105472
		public readonly IReadOnlyList<ActionInfo> EnterActionList = config.EnterActionList;

		// Token: 0x04019C01 RID: 105473
		public readonly IReadOnlyList<ActionInfo> ExitActionList = config.ExitActionList;
	}
}
