using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Skin;

// Token: 0x02000D9C RID: 3484
public class TipsRoleSkinData : TipsMaterialData
{
	// Token: 0x06008EA1 RID: 36513 RVA: 0x002AF3DC File Offset: 0x002AD5DC
	[NullableContext(1)]
	public TipsRoleSkinData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.RoleSkin;
		this.Title = SkinConfig.Instance.GetRoleSkinConfig(data.ItemId).Value.TitleName;
	}
}
