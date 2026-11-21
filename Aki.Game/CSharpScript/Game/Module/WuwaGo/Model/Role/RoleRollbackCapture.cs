using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x02003671 RID: 13937
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleRollbackCapture<[Nullable(0)] TRole> : ActorWorldRollbackCapture<TRole> where TRole : WuWaGoRole
	{
		// Token: 0x0602427E RID: 148094 RVA: 0x00A3C484 File Offset: 0x00A3A684
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

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x0602427F RID: 148095 RVA: 0x00A3C50D File Offset: 0x00A3A70D
		protected TRole Role
		{
			get
			{
				return this.Unit;
			}
		}

		// Token: 0x06024280 RID: 148096 RVA: 0x00A3C518 File Offset: 0x00A3A718
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

		// Token: 0x04014281 RID: 82561
		private readonly int Hp;

		// Token: 0x04014282 RID: 82562
		private readonly int StandGridId;

		// Token: 0x04014283 RID: 82563
		private readonly Vector Coordinate;

		// Token: 0x04014284 RID: 82564
		private readonly Rotator Rotator;

		// Token: 0x04014285 RID: 82565
		private readonly bool IsClimbing;
	}
}
