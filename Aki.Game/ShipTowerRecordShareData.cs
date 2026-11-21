using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F0E RID: 7950
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRecordShareData
{
	// Token: 0x06013A4B RID: 80459 RVA: 0x005BA0A9 File Offset: 0x005B82A9
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRecordShareData()
	{
	}

	// Token: 0x0400A7F3 RID: 42995
	[RequiredMember]
	public string AreaTitle;

	// Token: 0x0400A7F4 RID: 42996
	[RequiredMember]
	public int TotalScore;

	// Token: 0x0400A7F5 RID: 42997
	[RequiredMember]
	public int TotalWave;

	// Token: 0x0400A7F6 RID: 42998
	[Nullable(2)]
	public string GradeResId;

	// Token: 0x0400A7F7 RID: 42999
	[RequiredMember]
	public List<ShipTowerRecordItemData> RecordList;

	// Token: 0x0400A7F8 RID: 43000
	[RequiredMember]
	public string DateText;
}
