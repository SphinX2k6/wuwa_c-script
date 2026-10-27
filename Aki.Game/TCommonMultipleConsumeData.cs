using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001808 RID: 6152
[NullableContext(1)]
[Nullable(0)]
public struct TCommonMultipleConsumeData
{
	// Token: 0x17000F26 RID: 3878
	// (get) Token: 0x0600B46E RID: 46190 RVA: 0x0028BC4F File Offset: 0x00289E4F
	// (set) Token: 0x0600B46F RID: 46191 RVA: 0x0028BC57 File Offset: 0x00289E57
	public InventoryDefine.IGetItemData ItemData { readonly get; set; }

	// Token: 0x17000F27 RID: 3879
	// (get) Token: 0x0600B470 RID: 46192 RVA: 0x0028BC60 File Offset: 0x00289E60
	// (set) Token: 0x0600B471 RID: 46193 RVA: 0x0028BC68 File Offset: 0x00289E68
	public int Count { readonly get; set; }

	// Token: 0x0600B472 RID: 46194 RVA: 0x0028BC71 File Offset: 0x00289E71
	public TCommonMultipleConsumeData(InventoryDefine.IGetItemData itemData, int count)
	{
		this.ItemData = itemData;
		this.Count = count;
	}
}
