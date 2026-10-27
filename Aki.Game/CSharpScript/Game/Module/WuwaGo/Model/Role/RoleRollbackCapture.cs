using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x02004740 RID: 18240
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleRollbackCapture<[Nullable(0)] TRole> : ActorWorldRollbackCapture<TRole> where TRole : WuWaGoRole
	{
		// Token: 0x0602FAB4 RID: 195252 RVA: 0x00B0C4B8 File Offset: 0x00B0A6B8
		public RoleRollbackCapture(TRole role) : base(role)
		{
			this.Hp = role.Hp;
			this.StandGridId = role.StandGridId;
			this.Coordinate = Vector.Create();
			this.Coordinate.DeepCopy(role.Coordinate);
			this.Rotator = Rotator.Create();
			this.Rotator.DeepCopy(role.Rotator);
			this.IsClimbing = role.IsClimbing;
		}

		// Token: 0x1700771C RID: 30492
		// (get) Token: 0x0602FAB5 RID: 195253 RVA: 0x00B0C541 File Offset: 0x00B0A741
		protected TRole Role
		{
			get
			{
				return this.Unit;
			}
		}

		// Token: 0x0602FAB6 RID: 195254 RVA: 0x00B0C54C File Offset: 0x00B0A74C
		public override void Restore()
		{
			this.Role.SetHp(this.Hp);
			this.Role.SetRotator(this.Rotator);
			this.Role.SetIsClimbing(this.IsClimbing);
			WuWaGoGrid wuWaGoGrid = (this.StandGridId == 0) ? null : WuWaGoModel.Instance.GetGridById(this.StandGridId);
			this.Role.SetStandGrid(wuWaGoGrid, null);
			if (wuWaGoGrid == null)
			{
				this.Role.SetCoordinate(this.Coordinate);
			}
			base.RestoreActorWorldTransform();
			this.Role.ClearMaterialHandles();
		}

		// Token: 0x04019BD1 RID: 105425
		private readonly int Hp;

		// Token: 0x04019BD2 RID: 105426
		private readonly int StandGridId;

		// Token: 0x04019BD3 RID: 105427
		private readonly Vector Coordinate;

		// Token: 0x04019BD4 RID: 105428
		private readonly Rotator Rotator;

		// Token: 0x04019BD5 RID: 105429
		private readonly bool IsClimbing;
	}
}
