using System;
using System.Runtime.CompilerServices;

// Token: 0x020027EE RID: 10222
[NullableContext(1)]
[Nullable(0)]
public class RoleDevItemDataMap : IRoleDevItemDataMap
{
	// Token: 0x17001B8E RID: 7054
	// (get) Token: 0x06014FC0 RID: 85952 RVA: 0x005512EC File Offset: 0x0054F4EC
	// (set) Token: 0x06014FC1 RID: 85953 RVA: 0x005512F4 File Offset: 0x0054F4F4
	public IMaterialItemData Material { get; set; }

	// Token: 0x17001B8F RID: 7055
	// (get) Token: 0x06014FC2 RID: 85954 RVA: 0x005512FD File Offset: 0x0054F4FD
	// (set) Token: 0x06014FC3 RID: 85955 RVA: 0x00551305 File Offset: 0x0054F505
	public IDropRewardItemData Reward { get; set; }

	// Token: 0x17001B90 RID: 7056
	// (get) Token: 0x06014FC4 RID: 85956 RVA: 0x0055130E File Offset: 0x0054F50E
	// (set) Token: 0x06014FC5 RID: 85957 RVA: 0x00551316 File Offset: 0x0054F516
	public IPhantomMonsterItemData Monster { get; set; }
}
