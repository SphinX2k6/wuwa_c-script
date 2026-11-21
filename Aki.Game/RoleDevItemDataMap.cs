using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D69 RID: 7529
[NullableContext(1)]
[Nullable(0)]
public class RoleDevItemDataMap : IRoleDevItemDataMap
{
	// Token: 0x17001BE6 RID: 7142
	// (get) Token: 0x060129C0 RID: 76224 RVA: 0x0057C05C File Offset: 0x0057A25C
	// (set) Token: 0x060129C1 RID: 76225 RVA: 0x0057C064 File Offset: 0x0057A264
	public IMaterialItemData Material { get; set; }

	// Token: 0x17001BE7 RID: 7143
	// (get) Token: 0x060129C2 RID: 76226 RVA: 0x0057C06D File Offset: 0x0057A26D
	// (set) Token: 0x060129C3 RID: 76227 RVA: 0x0057C075 File Offset: 0x0057A275
	public IDropRewardItemData Reward { get; set; }

	// Token: 0x17001BE8 RID: 7144
	// (get) Token: 0x060129C4 RID: 76228 RVA: 0x0057C07E File Offset: 0x0057A27E
	// (set) Token: 0x060129C5 RID: 76229 RVA: 0x0057C086 File Offset: 0x0057A286
	public IPhantomMonsterItemData Monster { get; set; }
}
