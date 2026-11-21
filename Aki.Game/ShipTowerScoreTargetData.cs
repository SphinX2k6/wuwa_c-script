using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EF8 RID: 7928
[RequiredMember]
public class ShipTowerScoreTargetData
{
	// Token: 0x06013A38 RID: 80440 RVA: 0x005BA011 File Offset: 0x005B8211
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreTargetData()
	{
	}

	// Token: 0x0400A795 RID: 42901
	[Nullable(1)]
	[RequiredMember]
	public string Title;

	// Token: 0x0400A796 RID: 42902
	[RequiredMember]
	public int ScoreTarget;

	// Token: 0x0400A797 RID: 42903
	[Nullable(2)]
	public string ScoreGradeRes;

	// Token: 0x0400A798 RID: 42904
	[RequiredMember]
	public bool IsFinish;
}
