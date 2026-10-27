using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002D45 RID: 11589
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueTokenGrid : LoopScrollMediumItemGrid<RogueWeeklyEntry>
{
	// Token: 0x170020D7 RID: 8407
	// (get) Token: 0x060185A1 RID: 99745 RVA: 0x006331C3 File Offset: 0x006313C3
	public new RogueWeeklyEntry Data
	{
		get
		{
			return this.Data as RogueWeeklyEntry;
		}
	}

	// Token: 0x060185A2 RID: 99746 RVA: 0x006331D0 File Offset: 0x006313D0
	protected override void OnStart()
	{
		base.SetUseFixedAsync(true);
	}

	// Token: 0x060185A3 RID: 99747 RVA: 0x006331DC File Offset: 0x006313DC
	[NullableContext(1)]
	protected override void OnRefresh(RogueWeeklyEntry data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(data.ConfigId);
		if (rogueWeeklyBuffPool == null)
		{
			return;
		}
		RogueWeeklyGoods rogueWeeklyGoods = data.RogueWeeklyGoods;
		if (rogueWeeklyGoods == null)
		{
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IconPath = rogueWeeklyBuffPool.Value.BuffIcon,
				QualityId = new int?(rogueWeeklyBuffPool.Value.Quality),
				QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			return;
		}
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(80100000, 0);
		bool bVisible = rogueWeeklyGoods.CurPrice != rogueWeeklyGoods.SourcePrice;
		IMediumItemPrice itemPrice = new MediumItemPrice
		{
			CurPrice = rogueWeeklyGoods.CurPrice,
			OriginalPrice = new int?(rogueWeeklyGoods.SourcePrice),
			CurrencyNotEnough = new bool?(itemCountByConfigId < rogueWeeklyGoods.CurPrice)
		};
		PropMediumItemGrid parameters2 = new PropMediumItemGrid
		{
			Data = data,
			IconPath = rogueWeeklyBuffPool.Value.BuffIcon,
			QualityId = new int?(rogueWeeklyBuffPool.Value.Quality),
			QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
			IsRogueFinish = new bool?(rogueWeeklyGoods.IsSell),
			ItemPrice = itemPrice
		};
		base.Apply<PropMediumItemGrid>(parameters2);
		ItemGridComponent component = base.RefreshComponent(typeof(WeeklyRougeShopDiscountTag), new bool?(true), rogueWeeklyGoods);
		base.SetComponentVisible(component, bVisible);
	}

	// Token: 0x060185A4 RID: 99748 RVA: 0x00633352 File Offset: 0x00631552
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.OnSelected(true);
		}
	}

	// Token: 0x060185A5 RID: 99749 RVA: 0x00633360 File Offset: 0x00631560
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
		WeeklyRogueModel.Instance.SelectEntry = this.Data;
		if (fireEvent)
		{
			EventSystem.Instance.Emit<int, RogueWeeklyEntry>(EEventName.WeeklyRogueShopSelect, base.GridIndex, this.Data);
		}
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.GetItemGridExtendToggle().RootUIComp, false, false, false);
	}

	// Token: 0x060185A6 RID: 99750 RVA: 0x006333C2 File Offset: 0x006315C2
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}
}
