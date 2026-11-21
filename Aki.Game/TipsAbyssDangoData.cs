using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D9A RID: 3482
public class TipsAbyssDangoData : ItemTipsData
{
	// Token: 0x06008E9F RID: 36511 RVA: 0x002AF368 File Offset: 0x002AD568
	[NullableContext(1)]
	public TipsAbyssDangoData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.AbyssDango;
		this.IsIconByType = true;
		this.IsQualityByType = true;
		if (data.ExtraParam != null)
		{
			IDangoExtraParam dangoExtraParam = data.ExtraParam as IDangoExtraParam;
			this.DangoId = dangoExtraParam.DangoId;
			this.SlotIndex = dangoExtraParam.SlotIndex;
		}
	}

	// Token: 0x04005577 RID: 21879
	public int DangoId = -1;

	// Token: 0x04005578 RID: 21880
	public int SlotIndex = -1;
}
