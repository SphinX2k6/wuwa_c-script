using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000CC1 RID: 3265
[NullableContext(1)]
[Nullable(0)]
public struct TCommonMultipleConsumeData
{
	// Token: 0x17000F49 RID: 3913
	// (get) Token: 0x06008859 RID: 34905 RVA: 0x0029636F File Offset: 0x0029456F
	// (set) Token: 0x0600885A RID: 34906 RVA: 0x00296377 File Offset: 0x00294577
	public InventoryDefine.IGetItemData ItemData { readonly get; set; }

	// Token: 0x17000F4A RID: 3914
	// (get) Token: 0x0600885B RID: 34907 RVA: 0x00296380 File Offset: 0x00294580
	// (set) Token: 0x0600885C RID: 34908 RVA: 0x00296388 File Offset: 0x00294588
	public int Count { readonly get; set; }

	// Token: 0x0600885D RID: 34909 RVA: 0x00296391 File Offset: 0x00294591
	public TCommonMultipleConsumeData(InventoryDefine.IGetItemData itemData, int count)
	{
		this.ItemData = itemData;
		this.Count = count;
	}
}
