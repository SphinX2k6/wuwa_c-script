using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367D RID: 13949
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoPressureTriggerEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x06024305 RID: 148229 RVA: 0x00A3D87A File Offset: 0x00A3BA7A
		public WuWaGoPressureTriggerEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoPressureTrigger config) : base(EWuWaGoEntityType.PressureTrigger, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x06024306 RID: 148230 RVA: 0x00A3D8A0 File Offset: 0x00A3BAA0
		// (set) Token: 0x06024307 RID: 148231 RVA: 0x00A3D8A8 File Offset: 0x00A3BAA8
		public int CurrentOccupantId { get; private set; }

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x06024308 RID: 148232 RVA: 0x00A3D8B1 File Offset: 0x00A3BAB1
		// (set) Token: 0x06024309 RID: 148233 RVA: 0x00A3D8B9 File Offset: 0x00A3BAB9
		public bool Dirty { get; private set; }

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x0602430A RID: 148234 RVA: 0x00A3D8C2 File Offset: 0x00A3BAC2
		public bool IsOccupied
		{
			get
			{
				return this.CurrentOccupantId != 0;
			}
		}

		// Token: 0x0602430B RID: 148235 RVA: 0x00A3D8CD File Offset: 0x00A3BACD
		public override void Destroy()
		{
			this.CurrentOccupantId = 0;
			this.Dirty = false;
			base.Destroy();
		}

		// Token: 0x0602430C RID: 148236 RVA: 0x00A3D8E3 File Offset: 0x00A3BAE3
		public override IRollbackCapture CaptureRollback()
		{
			return new PressureTriggerRollbackCapture(this);
		}

		// Token: 0x0602430D RID: 148237 RVA: 0x00A3D8EB File Offset: 0x00A3BAEB
		public void RestoreOccupantStateForRollback(int occupantId, bool isDirty)
		{
			this.CurrentOccupantId = occupantId;
			this.Dirty = isDirty;
		}

		// Token: 0x0602430E RID: 148238 RVA: 0x00A3D8FB File Offset: 0x00A3BAFB
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602430F RID: 148239 RVA: 0x00A3D90B File Offset: 0x00A3BB0B
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x06024310 RID: 148240 RVA: 0x00A3D922 File Offset: 0x00A3BB22
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

		// Token: 0x06024311 RID: 148241 RVA: 0x00A3D946 File Offset: 0x00A3BB46
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.UpdateOccupant(currentUnitId);
		}

		// Token: 0x06024312 RID: 148242 RVA: 0x00A3D94F File Offset: 0x00A3BB4F
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

		// Token: 0x06024313 RID: 148243 RVA: 0x00A3D96F File Offset: 0x00A3BB6F
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

		// Token: 0x06024314 RID: 148244 RVA: 0x00A3D987 File Offset: 0x00A3BB87
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x06024315 RID: 148245 RVA: 0x00A3D98F File Offset: 0x00A3BB8F
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x040142B0 RID: 82608
		public readonly IReadOnlyList<ActionInfo> EnterActionList = config.EnterActionList;

		// Token: 0x040142B1 RID: 82609
		public readonly IReadOnlyList<ActionInfo> ExitActionList = config.ExitActionList;
	}
}
