using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Skin;

// Token: 0x020018E3 RID: 6371
public class TipsRoleSkinData : TipsMaterialData
{
	// Token: 0x0600BAB8 RID: 47800 RVA: 0x002A4C60 File Offset: 0x002A2E60
	[NullableContext(1)]
	public TipsRoleSkinData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.RoleSkin;
		this.Title = SkinConfig.Instance.GetRoleSkinConfig(data.ItemId).Value.TitleName;
	}
}
