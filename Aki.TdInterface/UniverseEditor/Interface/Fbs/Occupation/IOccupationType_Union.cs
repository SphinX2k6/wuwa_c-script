using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B9 RID: 17337
	public enum IOccupationType_Union : byte
	{
		// Token: 0x0400C1F9 RID: 49657
		NONE,
		// Token: 0x0400C1FA RID: 49658
		IOccupationType,
		// Token: 0x0400C1FB RID: 49659
		INpcOccupationData,
		// Token: 0x0400C1FC RID: 49660
		IAreaOccupationData,
		// Token: 0x0400C1FD RID: 49661
		ISilentAreaOccupationData,
		// Token: 0x0400C1FE RID: 49662
		IScreenResourceOccupationData,
		// Token: 0x0400C1FF RID: 49663
		ITimeOccupationData,
		// Token: 0x0400C200 RID: 49664
		IClosedSegmentOccupationData
	}
}
