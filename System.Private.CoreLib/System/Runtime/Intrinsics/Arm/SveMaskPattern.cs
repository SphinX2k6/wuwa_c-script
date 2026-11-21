using System;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000551 RID: 1361
	public enum SveMaskPattern : byte
	{
		// Token: 0x040011CC RID: 4556
		LargestPowerOf2,
		// Token: 0x040011CD RID: 4557
		VectorCount1,
		// Token: 0x040011CE RID: 4558
		VectorCount2,
		// Token: 0x040011CF RID: 4559
		VectorCount3,
		// Token: 0x040011D0 RID: 4560
		VectorCount4,
		// Token: 0x040011D1 RID: 4561
		VectorCount5,
		// Token: 0x040011D2 RID: 4562
		VectorCount6,
		// Token: 0x040011D3 RID: 4563
		VectorCount7,
		// Token: 0x040011D4 RID: 4564
		VectorCount8,
		// Token: 0x040011D5 RID: 4565
		VectorCount16,
		// Token: 0x040011D6 RID: 4566
		VectorCount32,
		// Token: 0x040011D7 RID: 4567
		VectorCount64,
		// Token: 0x040011D8 RID: 4568
		VectorCount128,
		// Token: 0x040011D9 RID: 4569
		VectorCount256,
		// Token: 0x040011DA RID: 4570
		LargestMultipleOf4 = 29,
		// Token: 0x040011DB RID: 4571
		LargestMultipleOf3,
		// Token: 0x040011DC RID: 4572
		All
	}
}
