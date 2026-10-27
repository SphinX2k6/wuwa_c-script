using System;
using System.Runtime.CompilerServices;

// Token: 0x0200298B RID: 10635
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerMonsterWordInfoItemData
{
	// Token: 0x0601603D RID: 90173 RVA: 0x0058F0A5 File Offset: 0x0058D2A5
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMonsterWordInfoItemData()
	{
	}

	// Token: 0x0400A3E7 RID: 41959
	public string Title;

	// Token: 0x0400A3E8 RID: 41960
	public string TitleColor;

	// Token: 0x0400A3E9 RID: 41961
	public string IconPath;

	// Token: 0x0400A3EA RID: 41962
	[Nullable(1)]
	[RequiredMember]
	public string Desc;
}
