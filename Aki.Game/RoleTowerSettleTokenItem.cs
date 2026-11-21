using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001CD2 RID: 7378
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerSettleTokenItem : LoopScrollMediumItemGrid<RoleTowerBuffDetailItemData>
{
	// Token: 0x06012450 RID: 74832 RVA: 0x0056304F File Offset: 0x0056124F
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012451 RID: 74833 RVA: 0x00563058 File Offset: 0x00561258
	protected override void OnRefresh(RoleTowerBuffDetailItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(data.TokenId);
		if (tokenCfg == null)
		{
			return;
		}
		RoleTowerTokenType? tokenTypeCfg = RoleTowerModel.Instance.GetTokenTypeCfg(tokenCfg.Value.TypeId);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(tokenCfg.Value.ItemId);
		string bottomTextId = (itemConfigData != null) ? itemConfigData.Name : null;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
		propMediumItemGrid.ItemConfigId = new int?(tokenCfg.Value.ItemId);
		propMediumItemGrid.LeftUpperIconPath = ((tokenTypeCfg != null) ? tokenTypeCfg.GetValueOrDefault().TagTexture : null);
		propMediumItemGrid.BottomTextId = bottomTextId;
		string rightTopValue;
		if (data.Count <= 1)
		{
			rightTopValue = null;
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("×");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
			rightTopValue = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propMediumItemGrid.RightTopValue = rightTopValue;
		propMediumItemGrid.Data = data;
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}

	// Token: 0x06012452 RID: 74834 RVA: 0x00563157 File Offset: 0x00561357
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06012453 RID: 74835 RVA: 0x0056315A File Offset: 0x0056135A
	protected override void OnExtendToggleClicked()
	{
		if (this.ItemData == null)
		{
			return;
		}
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.ItemData.TokenId);
	}

	// Token: 0x06012454 RID: 74836 RVA: 0x00563180 File Offset: 0x00561380
	public override object GetKey(RoleTowerBuffDetailItemData data, int displayIndex)
	{
		return data.TokenId;
	}

	// Token: 0x04009F84 RID: 40836
	[Nullable(2)]
	private RoleTowerBuffDetailItemData ItemData;

	// Token: 0x04009F85 RID: 40837
	[Nullable(2)]
	private Action<int> ClickCallback;
}
