using System;
using System.Runtime.CompilerServices;

// Token: 0x020027ED RID: 10221
[NullableContext(1)]
public interface IRoleDevItemDataMap
{
	// Token: 0x17001B8B RID: 7051
	// (get) Token: 0x06014FBA RID: 85946
	// (set) Token: 0x06014FBB RID: 85947
	IMaterialItemData Material { get; set; }

	// Token: 0x17001B8C RID: 7052
	// (get) Token: 0x06014FBC RID: 85948
	// (set) Token: 0x06014FBD RID: 85949
	IDropRewardItemData Reward { get; set; }

	// Token: 0x17001B8D RID: 7053
	// (get) Token: 0x06014FBE RID: 85950
	// (set) Token: 0x06014FBF RID: 85951
	IPhantomMonsterItemData Monster { get; set; }
}
