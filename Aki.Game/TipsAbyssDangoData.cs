using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E1 RID: 6369
public class TipsAbyssDangoData : ItemTipsData
{
	// Token: 0x0600BAB6 RID: 47798 RVA: 0x002A4BEC File Offset: 0x002A2DEC
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

	// Token: 0x040054CC RID: 21708
	public int DangoId = -1;

	// Token: 0x040054CD RID: 21709
	public int SlotIndex = -1;
}
