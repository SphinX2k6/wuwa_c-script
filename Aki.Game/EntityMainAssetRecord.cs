using System;
using System.Runtime.CompilerServices;

// Token: 0x0200330B RID: 13067
public class EntityMainAssetRecord
{
	// Token: 0x0400E212 RID: 57874
	public int ModelId;

	// Token: 0x0400E213 RID: 57875
	[Nullable(2)]
	public string ActorClassPath;

	// Token: 0x0400E214 RID: 57876
	[Nullable(1)]
	public AssetRecord AssetRecord = new AssetRecord();
}
