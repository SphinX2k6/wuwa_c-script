using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D0A RID: 7434
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerTokenItem : LoopScrollMediumItemGrid<RoleTowerTokenItemData>
{
	// Token: 0x06012667 RID: 75367 RVA: 0x0056FFEB File Offset: 0x0056E1EB
	protected override void OnRefresh(RoleTowerTokenItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.UpdateTokenInfo();
		this.UpdateTokenSelected();
		if (data.IsSelected)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x06012668 RID: 75368 RVA: 0x00570010 File Offset: 0x0056E210
	public void UpdateTokenInfo()
	{
		RoleTowerTokenItemData itemData = this.ItemData;
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(itemData.TokenId);
		if (tokenCfg == null)
		{
			return;
		}
		bool flag = itemData.Mode == ERoleTowerTokenViewMode.Codex;
		RoleTowerTokenData tokenState = RoleTowerModel.Instance.GetTokenState(itemData.TokenId);
		int value = flag ? 0 : RoleTowerModel.Instance.GetTokenCount(itemData.TokenId);
		bool flag2 = flag;
		RoleTowerTokenType? tokenTypeCfg = RoleTowerModel.Instance.GetTokenTypeCfg(tokenCfg.Value.TypeId);
		string leftUpperIconPath = (tokenTypeCfg != null) ? tokenTypeCfg.GetValueOrDefault().TagTexture : null;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(tokenCfg.Value.ItemId);
		string bottomTextId = (itemConfigData != null) ? itemConfigData.Name : null;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			ItemConfigId = new int?(tokenCfg.Value.ItemId),
			BottomTextId = bottomTextId,
			Level = (flag2 ? null : new int?(value)),
			IsDisable = new bool?(!flag && !RoleTowerModel.Instance.CanEquipToken(itemData.TokenId)),
			IsRecommendVisible = new bool?(!flag && itemData.IsRecommend),
			IsNewVisible = new bool?(!flag && !itemData.IsRecommend && tokenState != null && tokenState.IsNew),
			LeftUpperIconPath = leftUpperIconPath,
			Data = itemData
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06012669 RID: 75369 RVA: 0x00570195 File Offset: 0x0056E395
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0601266A RID: 75370 RVA: 0x0057019F File Offset: 0x0056E39F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0601266B RID: 75371 RVA: 0x005701AC File Offset: 0x0056E3AC
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (this.ItemData == null)
		{
			return;
		}
		this.ItemData.IsSelected = true;
		IScrollViewDelegate<IGridProxy<RoleTowerTokenItemData>, RoleTowerTokenItemData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate != null)
		{
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
		Action<RoleTowerTokenItemData> onItemClickCallback = this.OnItemClickCallback;
		if (onItemClickCallback == null)
		{
			return;
		}
		onItemClickCallback(this.ItemData);
	}

	// Token: 0x0601266C RID: 75372 RVA: 0x00570202 File Offset: 0x0056E402
	protected override bool OnCanExecuteChange()
	{
		RoleTowerTokenItemData itemData = this.ItemData;
		return itemData == null || !itemData.IsSelected;
	}

	// Token: 0x0601266D RID: 75373 RVA: 0x00570218 File Offset: 0x0056E418
	public void UpdateTokenSelected()
	{
		RoleTowerTokenItemData itemData = this.ItemData;
		bool flag = itemData != null && itemData.IsSelected;
		bool flag2 = flag;
		bool? isLastSelected = this.IsLastSelected;
		if (flag2 == isLastSelected.GetValueOrDefault() & isLastSelected != null)
		{
			return;
		}
		this.SetSelected(flag, true);
		this.IsLastSelected = new bool?(flag);
	}

	// Token: 0x0400A052 RID: 41042
	[Nullable(2)]
	private RoleTowerTokenItemData ItemData;

	// Token: 0x0400A053 RID: 41043
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleTowerTokenItemData> OnItemClickCallback;

	// Token: 0x0400A054 RID: 41044
	private bool? IsLastSelected;
}
