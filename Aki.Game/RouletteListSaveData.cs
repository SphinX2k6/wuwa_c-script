using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E8C RID: 7820
[NullableContext(1)]
[Nullable(0)]
public class RouletteListSaveData : IRouletteListSaveData
{
	// Token: 0x17001D7E RID: 7550
	// (get) Token: 0x060134EA RID: 79082 RVA: 0x005A34A9 File Offset: 0x005A16A9
	// (set) Token: 0x060134EB RID: 79083 RVA: 0x005A34B1 File Offset: 0x005A16B1
	public ERouletteType RouletteType { get; set; }

	// Token: 0x17001D7F RID: 7551
	// (get) Token: 0x060134EC RID: 79084 RVA: 0x005A34BA File Offset: 0x005A16BA
	// (set) Token: 0x060134ED RID: 79085 RVA: 0x005A34C2 File Offset: 0x005A16C2
	public List<int> RouletteIdList { get; set; }

	// Token: 0x17001D80 RID: 7552
	// (get) Token: 0x060134EE RID: 79086 RVA: 0x005A34CB File Offset: 0x005A16CB
	// (set) Token: 0x060134EF RID: 79087 RVA: 0x005A34D3 File Offset: 0x005A16D3
	public int ExtraItemId { get; set; }

	// Token: 0x17001D81 RID: 7553
	// (get) Token: 0x060134F0 RID: 79088 RVA: 0x005A34DC File Offset: 0x005A16DC
	// (set) Token: 0x060134F1 RID: 79089 RVA: 0x005A34E4 File Offset: 0x005A16E4
	public int EquipExploreSkillId { get; set; }
}
