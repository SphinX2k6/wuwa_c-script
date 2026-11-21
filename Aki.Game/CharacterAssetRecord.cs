using System;
using System.Runtime.CompilerServices;

// Token: 0x0200287B RID: 10363
public class CharacterAssetRecord
{
	// Token: 0x0400E6BE RID: 59070
	public int RoleId;

	// Token: 0x0400E6BF RID: 59071
	public int AiId;

	// Token: 0x0400E6C0 RID: 59072
	[Nullable(1)]
	public AssetRecord AssetRecord = new AssetRecord();
}
