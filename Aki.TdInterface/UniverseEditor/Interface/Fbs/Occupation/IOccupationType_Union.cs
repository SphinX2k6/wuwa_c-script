using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481B RID: 18459
	public enum IOccupationType_Union : byte
	{
		// Token: 0x0400CC19 RID: 52249
		NONE,
		// Token: 0x0400CC1A RID: 52250
		IOccupationType,
		// Token: 0x0400CC1B RID: 52251
		INpcOccupationData,
		// Token: 0x0400CC1C RID: 52252
		IAreaOccupationData,
		// Token: 0x0400CC1D RID: 52253
		ISilentAreaOccupationData,
		// Token: 0x0400CC1E RID: 52254
		IScreenResourceOccupationData,
		// Token: 0x0400CC1F RID: 52255
		ITimeOccupationData,
		// Token: 0x0400CC20 RID: 52256
		IClosedSegmentOccupationData,
		// Token: 0x0400CC21 RID: 52257
		ISeasonRotationOccupationData
	}
}
