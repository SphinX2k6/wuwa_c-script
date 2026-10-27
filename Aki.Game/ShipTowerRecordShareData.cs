using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002993 RID: 10643
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRecordShareData
{
	// Token: 0x06016045 RID: 90181 RVA: 0x0058F0E5 File Offset: 0x0058D2E5
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRecordShareData()
	{
	}

	// Token: 0x0400A409 RID: 41993
	[RequiredMember]
	public string AreaTitle;

	// Token: 0x0400A40A RID: 41994
	[RequiredMember]
	public int TotalScore;

	// Token: 0x0400A40B RID: 41995
	[RequiredMember]
	public int TotalWave;

	// Token: 0x0400A40C RID: 41996
	[Nullable(2)]
	public string GradeResId;

	// Token: 0x0400A40D RID: 41997
	[RequiredMember]
	public List<ShipTowerRecordItemData> RecordList;

	// Token: 0x0400A40E RID: 41998
	[RequiredMember]
	public string DateText;
}
