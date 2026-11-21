using System;
using System.Runtime.CompilerServices;

// Token: 0x02002877 RID: 10359
[NullableContext(1)]
[Nullable(0)]
public class SkillAssetRecord
{
	// Token: 0x0400E6B1 RID: 59057
	public int SkillId;

	// Token: 0x0400E6B2 RID: 59058
	public string ActorBlueprint = "";

	// Token: 0x0400E6B3 RID: 59059
	public int LoadType;

	// Token: 0x0400E6B4 RID: 59060
	public bool IsCommon;

	// Token: 0x0400E6B5 RID: 59061
	public bool HasMontagePath;

	// Token: 0x0400E6B6 RID: 59062
	public AssetRecord AssetRecord = new AssetRecord();
}
