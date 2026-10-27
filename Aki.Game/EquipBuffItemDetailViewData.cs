using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;

// Token: 0x02002A1A RID: 10778
[NullableContext(1)]
[Nullable(0)]
public class EquipBuffItemDetailViewData
{
	// Token: 0x060165FA RID: 91642 RVA: 0x005A9864 File Offset: 0x005A7A64
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

	// Token: 0x0400A681 RID: 42625
	[Nullable(2)]
	public RoleSkinData RoleSkinData;

	// Token: 0x0400A682 RID: 42626
	public string PreviewTitle = "";

	// Token: 0x0400A683 RID: 42627
	public string Description = "";

	// Token: 0x0400A684 RID: 42628
	public string TitleName = "";
}
