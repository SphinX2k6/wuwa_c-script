using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F07 RID: 7943
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerWordItemData
{
	// Token: 0x06013A44 RID: 80452 RVA: 0x005BA071 File Offset: 0x005B8271
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerWordItemData()
	{
	}

	// Token: 0x0400A7D5 RID: 42965
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7D6 RID: 42966
	[Nullable(2)]
	public string TitleColor;

	// Token: 0x0400A7D7 RID: 42967
	[RequiredMember]
	public string IconPath;
}
