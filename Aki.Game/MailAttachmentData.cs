using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x020016B1 RID: 5809
[NullableContext(1)]
[Nullable(0)]
public class MailAttachmentData : ScrollViewDataBase
{
	// Token: 0x0600E210 RID: 57872 RVA: 0x004246C5 File Offset: 0x004228C5
	public MailAttachmentData(int id, int count, bool picked)
	{
		this.ItemId = id;
		this.Count = count;
		this.WasPicked = picked;
		this.Config = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x0600E211 RID: 57873 RVA: 0x004246F8 File Offset: 0x004228F8
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0600E212 RID: 57874 RVA: 0x00424700 File Offset: 0x00422900
	public int GetCount()
	{
		return this.Count;
	}

	// Token: 0x0600E213 RID: 57875 RVA: 0x00424708 File Offset: 0x00422908
	public bool GetPicked()
	{
		return this.WasPicked;
	}

	// Token: 0x0600E214 RID: 57876 RVA: 0x00424710 File Offset: 0x00422910
	public ItemConfig GetItemConfig()
	{
		return this.Config;
	}

	// Token: 0x04008147 RID: 33095
	private readonly int ItemId;

	// Token: 0x04008148 RID: 33096
	private readonly int Count;

	// Token: 0x04008149 RID: 33097
	private readonly bool WasPicked;

	// Token: 0x0400814A RID: 33098
	private readonly ItemConfig Config;
}
