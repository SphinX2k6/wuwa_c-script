using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000025 RID: 37
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachTargetComponent_SetValue
	{
		// Token: 0x0400008D RID: 141
		public bool? Disabled;

		// Token: 0x0400008E RID: 142
		public bool? EdIsLocked;

		// Token: 0x0400008F RID: 143
		public IAttachTarget AttachTarget;

		// Token: 0x04000090 RID: 144
		public EAttachRuleType? PosRule;

		// Token: 0x04000091 RID: 145
		public EAttachRuleType? RotRule;

		// Token: 0x04000092 RID: 146
		public IAttachTiming AttachTiming;
	}
}
