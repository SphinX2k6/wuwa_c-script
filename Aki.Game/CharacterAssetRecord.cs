using System;
using System.Runtime.CompilerServices;

// Token: 0x02003309 RID: 13065
public class CharacterAssetRecord
{
	// Token: 0x0400E20D RID: 57869
	public int RoleId;

	// Token: 0x0400E20E RID: 57870
	public int AiId;

	// Token: 0x0400E20F RID: 57871
	[Nullable(1)]
	public AssetRecord AssetRecord = new AssetRecord();
}
