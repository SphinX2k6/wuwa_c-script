using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003675 RID: 13941
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoBowTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x060242A7 RID: 148135 RVA: 0x00A3CB4F File Offset: 0x00A3AD4F
		public WuWaGoBowTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoBowTrap config) : base(EWuWaGoEntityType.BowTrap, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x060242A8 RID: 148136 RVA: 0x00A3CB76 File Offset: 0x00A3AD76
		public IWuWaGoBowTrap Config { get; } = config;

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x060242A9 RID: 148137 RVA: 0x00A3CB7E File Offset: 0x00A3AD7E
		public Vector Direction { get; } = WuWaGoBowTrapEntity.CalcShootDirection(rotator);

		// Token: 0x060242AA RID: 148138 RVA: 0x00A3CB88 File Offset: 0x00A3AD88
		private static Vector CalcShootDirection(Rotator rotator)
		{
			Vector vector = Vector.Create();
			rotator.Quaternion(null).RotateVector(Vector.RightVectorProxy, vector);
			vector.Set(Math.Round(vector.X), Math.Round(vector.Y), Math.Round(vector.Z));
			return vector;
		}

		// Token: 0x060242AB RID: 148139 RVA: 0x00A3CBD5 File Offset: 0x00A3ADD5
		public bool CanShootInRound(int round)
		{
			return base.State == EGameplayEntityState.Activated && this.LastShootRound != round;
		}

		// Token: 0x060242AC RID: 148140 RVA: 0x00A3CBEE File Offset: 0x00A3ADEE
		public void MarkShotInRound(int round)
		{
			if (this.LastShootRound == round)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.LastShootRound = round;
		}

		// Token: 0x060242AD RID: 148141 RVA: 0x00A3CC07 File Offset: 0x00A3AE07
		public int PeekLastShootRound()
		{
			return this.LastShootRound;
		}

		// Token: 0x060242AE RID: 148142 RVA: 0x00A3CC0F File Offset: 0x00A3AE0F
		public override void Destroy()
		{
			this.LastShootRound = -1;
			base.Destroy();
		}

		// Token: 0x060242AF RID: 148143 RVA: 0x00A3CC1E File Offset: 0x00A3AE1E
		public override IRollbackCapture CaptureRollback()
		{
			return new BowTrapRollbackCapture(this);
		}

		// Token: 0x060242B0 RID: 148144 RVA: 0x00A3CC26 File Offset: 0x00A3AE26
		public override void RestoreInitialStateForGameOver()
		{
			this.LastShootRound = -1;
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x060242B1 RID: 148145 RVA: 0x00A3CC35 File Offset: 0x00A3AE35
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04014290 RID: 82576
		private int LastShootRound = -1;
	}
}
