using System;
using System.Runtime.CompilerServices;

// Token: 0x0200298C RID: 10636
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerWordItemData
{
	// Token: 0x0601603E RID: 90174 RVA: 0x0058F0AD File Offset: 0x0058D2AD
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerWordItemData()
	{
	}

	// Token: 0x0400A3EB RID: 41963
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3EC RID: 41964
	[Nullable(2)]
	public string TitleColor;

	// Token: 0x0400A3ED RID: 41965
	[RequiredMember]
	public string IconPath;
}
