using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000369 RID: 873
	public class IFaceToTargetMotorInteractConstraint_SetValue
	{
		// Token: 0x04000E4A RID: 3658
		public EMotorInteractConstraintType Type;

		// Token: 0x04000E4B RID: 3659
		[Nullable(1)]
		public ITargetEntityType Target;

		// Token: 0x04000E4C RID: 3660
		public float Angle;
	}
}
