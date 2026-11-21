using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000025 RID: 37
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachTargetComponent_SetValue
	{
		// Token: 0x04000092 RID: 146
		public bool? Disabled;

		// Token: 0x04000093 RID: 147
		public bool? EdIsLocked;

		// Token: 0x04000094 RID: 148
		public IAttachTarget AttachTarget;

		// Token: 0x04000095 RID: 149
		public EAttachRuleType? PosRule;

		// Token: 0x04000096 RID: 150
		public EAttachRuleType? RotRule;

		// Token: 0x04000097 RID: 151
		public IAttachTiming AttachTiming;
	}
}
