using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F84 RID: 3972
[RequiredMember]
public class MapAreaShowViewParams
{
	// Token: 0x06009F40 RID: 40768 RVA: 0x002F02AB File Offset: 0x002EE4AB
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MapAreaShowViewParams()
	{
	}

	// Token: 0x04005E51 RID: 24145
	public int? CountryId;

	// Token: 0x04005E52 RID: 24146
	public int? AreaId;

	// Token: 0x04005E53 RID: 24147
	[Nullable(1)]
	[RequiredMember]
	public Action<int> OnClickArea;
}
