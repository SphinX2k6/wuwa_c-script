using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AC5 RID: 6853
[RequiredMember]
public class MapAreaShowViewParams
{
	// Token: 0x0600CB2F RID: 52015 RVA: 0x002E5127 File Offset: 0x002E3327
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MapAreaShowViewParams()
	{
	}

	// Token: 0x04005D82 RID: 23938
	public int? CountryId;

	// Token: 0x04005D83 RID: 23939
	public int? AreaId;

	// Token: 0x04005D84 RID: 23940
	[Nullable(1)]
	[RequiredMember]
	public Action<int> OnClickArea;
}
