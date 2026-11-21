using System;
using System.Runtime.CompilerServices;

// Token: 0x0200287D RID: 10365
public class EntityMainAssetRecord
{
	// Token: 0x0400E6C3 RID: 59075
	public int ModelId;

	// Token: 0x0400E6C4 RID: 59076
	[Nullable(2)]
	public string ActorClassPath;

	// Token: 0x0400E6C5 RID: 59077
	[Nullable(1)]
	public AssetRecord AssetRecord = new AssetRecord();
}
