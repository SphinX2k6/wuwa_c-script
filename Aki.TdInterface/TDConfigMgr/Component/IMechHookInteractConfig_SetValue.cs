using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054C RID: 1356
	public class IMechHookInteractConfig_SetValue
	{
		// Token: 0x04001408 RID: 5128
		public IMechHookInteractType InteractType;

		// Token: 0x04001409 RID: 5129
		[Nullable(2)]
		public IMechHookAcceleration MechHookAcceleration;

		// Token: 0x0400140A RID: 5130
		[Nullable(2)]
		public IInteractSectorRange SectorRange;

		// Token: 0x0400140B RID: 5131
		public float? Radius;

		// Token: 0x0400140C RID: 5132
		public float? NonInteractiveInnerRadius;
	}
}
