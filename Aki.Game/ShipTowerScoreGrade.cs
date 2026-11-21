using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F02 RID: 7938
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerScoreGrade
{
	// Token: 0x06013A3F RID: 80447 RVA: 0x005BA049 File Offset: 0x005B8249
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreGrade()
	{
	}

	// Token: 0x0400A7C3 RID: 42947
	[RequiredMember]
	public string ResId;

	// Token: 0x0400A7C4 RID: 42948
	[RequiredMember]
	public string BigResId;

	// Token: 0x0400A7C5 RID: 42949
	[RequiredMember]
	public int Index;
}
