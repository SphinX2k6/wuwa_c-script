using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005318 RID: 21272
	[NullableContext(1)]
	[Nullable(0)]
	public class IMultiMotorParkourRewardViewData
	{
		// Token: 0x170066CC RID: 26316
		// (get) Token: 0x06034ED5 RID: 216789 RVA: 0x00ECD6E4 File Offset: 0x00ECB8E4
		// (set) Token: 0x06034ED6 RID: 216790 RVA: 0x00ECD6EC File Offset: 0x00ECB8EC
		public MultiMotorData ActivityData { get; set; }

		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x06034ED7 RID: 216791 RVA: 0x00ECD6F5 File Offset: 0x00ECB8F5
		// (set) Token: 0x06034ED8 RID: 216792 RVA: 0x00ECD6FD File Offset: 0x00ECB8FD
		public MultiMotorLevelData SelectLevelData { get; set; }
	}
}
