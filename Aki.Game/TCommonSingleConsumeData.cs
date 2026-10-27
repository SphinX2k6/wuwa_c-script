using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001810 RID: 6160
[NullableContext(1)]
[Nullable(0)]
public class TCommonSingleConsumeData
{
	// Token: 0x17000F28 RID: 3880
	// (get) Token: 0x0600B4A3 RID: 46243 RVA: 0x0028C33B File Offset: 0x0028A53B
	// (set) Token: 0x0600B4A4 RID: 46244 RVA: 0x0028C343 File Offset: 0x0028A543
	public InventoryDefine.IGetItemData ItemData { get; set; }

	// Token: 0x17000F29 RID: 3881
	// (get) Token: 0x0600B4A5 RID: 46245 RVA: 0x0028C34C File Offset: 0x0028A54C
	// (set) Token: 0x0600B4A6 RID: 46246 RVA: 0x0028C354 File Offset: 0x0028A554
	public int Count { get; set; }
}
