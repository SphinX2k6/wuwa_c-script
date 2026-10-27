using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200639A RID: 25498
	[NullableContext(1)]
	[Nullable(0)]
	public class IMultiMotorParkourRewardViewData
	{
		// Token: 0x1700936A RID: 37738
		// (get) Token: 0x06040214 RID: 262676 RVA: 0x00F86770 File Offset: 0x00F84970
		// (set) Token: 0x06040215 RID: 262677 RVA: 0x00F86778 File Offset: 0x00F84978
		public MultiMotorData ActivityData { get; set; }

		// Token: 0x1700936B RID: 37739
		// (get) Token: 0x06040216 RID: 262678 RVA: 0x00F86781 File Offset: 0x00F84981
		// (set) Token: 0x06040217 RID: 262679 RVA: 0x00F86789 File Offset: 0x00F84989
		public MultiMotorLevelData SelectLevelData { get; set; }
	}
}
