using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x020021CD RID: 8653
[NullableContext(1)]
[Nullable(0)]
public class MailAttachmentData : ScrollViewDataBase
{
	// Token: 0x06010D7F RID: 68991 RVA: 0x00417DE5 File Offset: 0x00415FE5
	public MailAttachmentData(int id, int count, bool picked)
	{
		this.ItemId = id;
		this.Count = count;
		this.WasPicked = picked;
		this.Config = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x06010D80 RID: 68992 RVA: 0x00417E18 File Offset: 0x00416018
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x06010D81 RID: 68993 RVA: 0x00417E20 File Offset: 0x00416020
	public int GetCount()
	{
		return this.Count;
	}

	// Token: 0x06010D82 RID: 68994 RVA: 0x00417E28 File Offset: 0x00416028
	public bool GetPicked()
	{
		return this.WasPicked;
	}

	// Token: 0x06010D83 RID: 68995 RVA: 0x00417E30 File Offset: 0x00416030
	public ItemConfig GetItemConfig()
	{
		return this.Config;
	}

	// Token: 0x04008000 RID: 32768
	private readonly int ItemId;

	// Token: 0x04008001 RID: 32769
	private readonly int Count;

	// Token: 0x04008002 RID: 32770
	private readonly bool WasPicked;

	// Token: 0x04008003 RID: 32771
	private readonly ItemConfig Config;
}
