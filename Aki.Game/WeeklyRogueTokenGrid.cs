using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200229F RID: 8863
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueTokenGrid : LoopScrollMediumItemGrid<RogueWeeklyEntry>
{
	// Token: 0x17002132 RID: 8498
	// (get) Token: 0x06015E43 RID: 89667 RVA: 0x006591D3 File Offset: 0x006573D3
	public new RogueWeeklyEntry Data
	{
		get
		{
			return this.Data as RogueWeeklyEntry;
		}
	}

	// Token: 0x06015E44 RID: 89668 RVA: 0x006591E0 File Offset: 0x006573E0
	protected override void OnStart()
	{
		base.SetUseFixedAsync(true);
	}

	// Token: 0x06015E45 RID: 89669 RVA: 0x006591EC File Offset: 0x006573EC
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

	// Token: 0x06015E46 RID: 89670 RVA: 0x00659362 File Offset: 0x00657562
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.OnSelected(true);
		}
	}

	// Token: 0x06015E47 RID: 89671 RVA: 0x00659370 File Offset: 0x00657570
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

	// Token: 0x06015E48 RID: 89672 RVA: 0x006593D2 File Offset: 0x006575D2
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
		WeeklyRogueModel.Instance.SelectEntry = null;
	}
}
