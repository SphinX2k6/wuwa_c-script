using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CCB RID: 7371
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerBuffDetailItem : LoopScrollSmallItemGrid<RoleTowerBuffDetailItemData>
{
	// Token: 0x0601240A RID: 74762 RVA: 0x00561A4E File Offset: 0x0055FC4E
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0601240B RID: 74763 RVA: 0x00561A57 File Offset: 0x0055FC57
	protected override void OnRefresh(RoleTowerBuffDetailItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.UpdateTokenInfo();
		this.UpdateSelected();
	}

	// Token: 0x0601240C RID: 74764 RVA: 0x00561A6C File Offset: 0x0055FC6C
	private void UpdateTokenInfo()
	{
		RoleTowerBuffDetailItemData itemData = this.ItemData;
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(itemData.TokenId);
		if (tokenCfg == null)
		{
			return;
		}
		int tokenCount = RoleTowerModel.Instance.GetTokenCount(itemData.TokenId);
		base.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			ItemConfigId = new int?(tokenCfg.Value.ItemId),
			BottomText = ((tokenCount > 0) ? tokenCount.ToString() : string.Empty),
			Data = itemData
		});
	}

	// Token: 0x0601240D RID: 74765 RVA: 0x00561AF0 File Offset: 0x0055FCF0
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
		this.IsLastSelected = new bool?(true);
	}

	// Token: 0x0601240E RID: 74766 RVA: 0x00561B06 File Offset: 0x0055FD06
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
		this.IsLastSelected = new bool?(false);
	}

	// Token: 0x0601240F RID: 74767 RVA: 0x00561B1C File Offset: 0x0055FD1C
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (this.ItemData == null || state != EToggleState.ETT_Checked)
		{
			return;
		}
		IScrollViewDelegate<IGridProxy<RoleTowerBuffDetailItemData>, RoleTowerBuffDetailItemData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate == null)
		{
			return;
		}
		scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
	}

	// Token: 0x06012410 RID: 74768 RVA: 0x00561B48 File Offset: 0x0055FD48
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

	// Token: 0x06012411 RID: 74769 RVA: 0x00561B6E File Offset: 0x0055FD6E
	protected override bool OnCanExecuteChange()
	{
		return this.GetItemGridExtendToggle().GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x06012412 RID: 74770 RVA: 0x00561B84 File Offset: 0x0055FD84
	private void UpdateSelected()
	{
		RoleTowerBuffDetailItemData itemData = this.ItemData;
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

	// Token: 0x06012413 RID: 74771 RVA: 0x00561BD4 File Offset: 0x0055FDD4
	public override object GetKey(RoleTowerBuffDetailItemData data, int displayIndex)
	{
		return data.TokenId;
	}

	// Token: 0x04009F72 RID: 40818
	[Nullable(2)]
	private RoleTowerBuffDetailItemData ItemData;

	// Token: 0x04009F73 RID: 40819
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x04009F74 RID: 40820
	private bool? IsLastSelected;
}
