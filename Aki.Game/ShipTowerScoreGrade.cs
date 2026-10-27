using System;
using System.Runtime.CompilerServices;

// Token: 0x02002987 RID: 10631
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerScoreGrade
{
	// Token: 0x06016039 RID: 90169 RVA: 0x0058F085 File Offset: 0x0058D285
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreGrade()
	{
	}

	// Token: 0x0400A3D9 RID: 41945
	[RequiredMember]
	public string ResId;

	// Token: 0x0400A3DA RID: 41946
	[RequiredMember]
	public string BigResId;

	// Token: 0x0400A3DB RID: 41947
	[RequiredMember]
	public int Index;
}
