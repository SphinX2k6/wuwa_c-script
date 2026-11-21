using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000CC9 RID: 3273
[NullableContext(1)]
[Nullable(0)]
public class TCommonSingleConsumeData
{
	// Token: 0x17000F4B RID: 3915
	// (get) Token: 0x0600888E RID: 34958 RVA: 0x00296A5B File Offset: 0x00294C5B
	// (set) Token: 0x0600888F RID: 34959 RVA: 0x00296A63 File Offset: 0x00294C63
	public InventoryDefine.IGetItemData ItemData { get; set; }

	// Token: 0x17000F4C RID: 3916
	// (get) Token: 0x06008890 RID: 34960 RVA: 0x00296A6C File Offset: 0x00294C6C
	// (set) Token: 0x06008891 RID: 34961 RVA: 0x00296A74 File Offset: 0x00294C74
	public int Count { get; set; }
}
