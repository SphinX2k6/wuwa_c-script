using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002343 RID: 9027
	[NullableContext(2)]
	[Nullable(0)]
	public class MoveWithSpline_SetValue
	{
		// Token: 0x040074FB RID: 29947
		[Nullable(0)]
		public ISplineMoveTargetType MoveTarget;

		// Token: 0x040074FC RID: 29948
		public int SplineEntityId;

		// Token: 0x040074FD RID: 29949
		public ICheckClimb CheckClimb;

		// Token: 0x040074FE RID: 29950
		public IMoveOnWallConfig MoveOnWallConfig;

		// Token: 0x040074FF RID: 29951
		public EMoveSpeed? MoveState;

		// Token: 0x04007500 RID: 29952
		public int? StartPointIndex;

		// Token: 0x04007501 RID: 29953
		public int? EndPointIndex;

		// Token: 0x04007502 RID: 29954
		public bool? IsFollowStrictly;

		// Token: 0x04007503 RID: 29955
		public bool? IsForceToFirstPoint;

		// Token: 0x04007504 RID: 29956
		public bool? IsLookDir;

		// Token: 0x04007505 RID: 29957
		public INpcFollowConfig NpcFollow;

		// Token: 0x04007506 RID: 29958
		public bool? NpcCollisionEnabled;
	}
}
