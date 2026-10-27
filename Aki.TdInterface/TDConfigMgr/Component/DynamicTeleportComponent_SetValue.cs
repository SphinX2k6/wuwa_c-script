using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000067 RID: 103
	public class DynamicTeleportComponent_SetValue
	{
		// Token: 0x04000213 RID: 531
		public bool? Disabled;

		// Token: 0x04000214 RID: 532
		public bool? EdIsLocked;

		// Token: 0x04000215 RID: 533
		[Nullable(1)]
		public PosA Offset;

		// Token: 0x04000216 RID: 534
		public int PhantomSkillId;
	}
}
