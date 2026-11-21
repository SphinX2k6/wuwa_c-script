using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;

// Token: 0x02001F95 RID: 8085
[NullableContext(1)]
[Nullable(0)]
public class EquipBuffItemDetailViewData
{
	// Token: 0x06014000 RID: 81920 RVA: 0x005D4840 File Offset: 0x005D2A40
	public void LoadFromItemId(int itemId)
	{
		ItemInfo? config = ItemConfig.Instance.GetConfig(itemId);
		if (config == null)
		{
			return;
		}
		this.TitleName = config.Value.Name;
		this.Description = config.Value.BgDescription;
	}

	// Token: 0x0400AA6A RID: 43626
	[Nullable(2)]
	public RoleSkinData RoleSkinData;

	// Token: 0x0400AA6B RID: 43627
	public string PreviewTitle = "";

	// Token: 0x0400AA6C RID: 43628
	public string Description = "";

	// Token: 0x0400AA6D RID: 43629
	public string TitleName = "";
}
