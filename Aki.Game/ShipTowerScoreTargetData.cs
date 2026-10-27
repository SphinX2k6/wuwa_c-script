using System;
using System.Runtime.CompilerServices;

// Token: 0x0200297D RID: 10621
[RequiredMember]
public class ShipTowerScoreTargetData
{
	// Token: 0x06016032 RID: 90162 RVA: 0x0058F04D File Offset: 0x0058D24D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreTargetData()
	{
	}

	// Token: 0x0400A3AB RID: 41899
	[Nullable(1)]
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3AC RID: 41900
	[RequiredMember]
	public int ScoreTarget;

	// Token: 0x0400A3AD RID: 41901
	[Nullable(2)]
	public string ScoreGradeRes;

	// Token: 0x0400A3AE RID: 41902
	[RequiredMember]
	public bool IsFinish;
}
