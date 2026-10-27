using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004744 RID: 18244
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoBowTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FADD RID: 195293 RVA: 0x00B0CB83 File Offset: 0x00B0AD83
		public WuWaGoBowTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoBowTrap config) : base(EWuWaGoEntityType.BowTrap, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x17007726 RID: 30502
		// (get) Token: 0x0602FADE RID: 195294 RVA: 0x00B0CBAA File Offset: 0x00B0ADAA
		public IWuWaGoBowTrap Config { get; } = config;

		// Token: 0x17007727 RID: 30503
		// (get) Token: 0x0602FADF RID: 195295 RVA: 0x00B0CBB2 File Offset: 0x00B0ADB2
		public Vector Direction { get; } = WuWaGoBowTrapEntity.CalcShootDirection(rotator);

		// Token: 0x0602FAE0 RID: 195296 RVA: 0x00B0CBBC File Offset: 0x00B0ADBC
		private static Vector CalcShootDirection(Rotator rotator)
		{
			Vector vector = Vector.Create();
			rotator.Quaternion(null).RotateVector(Vector.RightVectorProxy, vector);
			vector.Set(Math.Round(vector.X), Math.Round(vector.Y), Math.Round(vector.Z));
			return vector;
		}

		// Token: 0x0602FAE1 RID: 195297 RVA: 0x00B0CC09 File Offset: 0x00B0AE09
		public bool CanShootInRound(int round)
		{
			return base.State == EGameplayEntityState.Activated && this.LastShootRound != round;
		}

		// Token: 0x0602FAE2 RID: 195298 RVA: 0x00B0CC22 File Offset: 0x00B0AE22
		public void MarkShotInRound(int round)
		{
			if (this.LastShootRound == round)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.LastShootRound = round;
		}

		// Token: 0x0602FAE3 RID: 195299 RVA: 0x00B0CC3B File Offset: 0x00B0AE3B
		public int PeekLastShootRound()
		{
			return this.LastShootRound;
		}

		// Token: 0x0602FAE4 RID: 195300 RVA: 0x00B0CC43 File Offset: 0x00B0AE43
		public override void Destroy()
		{
			this.LastShootRound = -1;
			base.Destroy();
		}

		// Token: 0x0602FAE5 RID: 195301 RVA: 0x00B0CC52 File Offset: 0x00B0AE52
		public override IRollbackCapture CaptureRollback()
		{
			return new BowTrapRollbackCapture(this);
		}

		// Token: 0x0602FAE6 RID: 195302 RVA: 0x00B0CC5A File Offset: 0x00B0AE5A
		public override void RestoreInitialStateForGameOver()
		{
			this.LastShootRound = -1;
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602FAE7 RID: 195303 RVA: 0x00B0CC69 File Offset: 0x00B0AE69
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04019BE0 RID: 105440
		private int LastShootRound = -1;
	}
}
