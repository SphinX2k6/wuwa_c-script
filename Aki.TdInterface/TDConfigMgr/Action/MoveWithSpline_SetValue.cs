using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E2 RID: 8418
	[NullableContext(2)]
	[Nullable(0)]
	public class MoveWithSpline_SetValue
	{
		// Token: 0x04006ECA RID: 28362
		[Nullable(1)]
		public ISplineMoveTargetType MoveTarget;

		// Token: 0x04006ECB RID: 28363
		public int SplineEntityId;

		// Token: 0x04006ECC RID: 28364
		public ICheckClimb CheckClimb;

		// Token: 0x04006ECD RID: 28365
		public IMoveOnWallConfig MoveOnWallConfig;

		// Token: 0x04006ECE RID: 28366
		public EMoveSpeed? MoveState;

		// Token: 0x04006ECF RID: 28367
		public int? StartPointIndex;

		// Token: 0x04006ED0 RID: 28368
		public int? EndPointIndex;

		// Token: 0x04006ED1 RID: 28369
		public bool? IsFollowStrictly;

		// Token: 0x04006ED2 RID: 28370
		public bool? IsForceToFirstPoint;

		// Token: 0x04006ED3 RID: 28371
		public bool? IsLookDir;

		// Token: 0x04006ED4 RID: 28372
		public INpcFollowConfig NpcFollow;

		// Token: 0x04006ED5 RID: 28373
		public bool? NpcCollisionEnabled;
	}
}
