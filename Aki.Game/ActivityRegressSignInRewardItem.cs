using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200149A RID: 5274
public class ActivityRegressSignInRewardItem : UiPanelBase
{
	// Token: 0x06009571 RID: 38257 RVA: 0x00203D60 File Offset: 0x00201F60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardItem))
		};
	}

	// Token: 0x06009572 RID: 38258 RVA: 0x00203E35 File Offset: 0x00202035
	[NullableContext(1)]
	public void RegisterItemClickCallBack(Action<int> onRewardItemClick)
	{
		this.OnRewardItemClick = onRewardItemClick;
	}

	// Token: 0x06009573 RID: 38259 RVA: 0x00203E40 File Offset: 0x00202040
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(4).GetOwner());
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClicked));
	}

	// Token: 0x06009574 RID: 38260 RVA: 0x00203EB0 File Offset: 0x002020B0
	public void RefreshByData(int index)
	{
		this.Index = index;
		int num = index + 1;
		this.Day = num;
		UUIText text = base.GetText(5);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		bool uiactive = ActivityRegressModel.Instance.CheckSignRewardState(this.Day, ERegressRewardState.Reached);
		bool uiactive2 = ActivityRegressModel.Instance.CheckSignRewardState(this.Day, ERegressRewardState.Claim);
		ERegressRewardState signRewardState = ActivityRegressModel.Instance.GetSignRewardState(num);
		string signRewardLocalTextKeyByState = ActivityRegressModel.Instance.GetSignRewardLocalTextKeyByState(signRewardState);
		UUIText text2 = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text2, signRewardLocalTextKeyByState, Array.Empty<object>());
		base.GetItem(1).SetUIActive(uiactive);
		base.GetItem(2).SetUIActive(uiactive2);
		RegressSignReward? signRewardConfigByIndex = ActivityRegressModel.Instance.GetSignRewardConfigByIndex(index);
		IRegressRewardItemInfo signRewardPreviewItemInfo = ActivityRegressModel.Instance.GetSignRewardPreviewItemInfo(signRewardConfigByIndex.Value);
		ActivityRegressHelper.RefreshItemGridByData(this.ItemGrid, signRewardPreviewItemInfo);
	}

	// Token: 0x06009575 RID: 38261 RVA: 0x00203FA0 File Offset: 0x002021A0
	[NullableContext(1)]
	private void OnRewardItemClicked(MediumItemGridExtendCallback _)
	{
		this.OnClickRewardItem();
	}

	// Token: 0x06009576 RID: 38262 RVA: 0x00203FA8 File Offset: 0x002021A8
	private void OnClickRewardItem()
	{
		if (!ActivityRegressModel.Instance.CheckSignRewardState(this.Day, ERegressRewardState.Reached))
		{
			RegressSignReward? signRewardConfigByIndex = ActivityRegressModel.Instance.GetSignRewardConfigByIndex(this.Index);
			int? item = ActivityRegressModel.Instance.GetSignRewardPreviewReward(signRewardConfigByIndex.Value).Item1;
			if (item != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(item.Value, true, null);
			}
			return;
		}
		Action<int> onRewardItemClick = this.OnRewardItemClick;
		if (onRewardItemClick == null)
		{
			return;
		}
		onRewardItemClick(this.Index);
	}

	// Token: 0x04004216 RID: 16918
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04004217 RID: 16919
	private int Index;

	// Token: 0x04004218 RID: 16920
	private int Day;

	// Token: 0x04004219 RID: 16921
	[Nullable(2)]
	private Action<int> OnRewardItemClick;

	// Token: 0x02007ACC RID: 31436
	private class EComponents
	{
		// Token: 0x04028664 RID: 165476
		public const int RootBtn = 0;

		// Token: 0x04028665 RID: 165477
		public const int PnlReceive = 1;

		// Token: 0x04028666 RID: 165478
		public const int PnlDone = 2;

		// Token: 0x04028667 RID: 165479
		public const int TxtNor = 3;

		// Token: 0x04028668 RID: 165480
		public const int ItemGrid = 4;

		// Token: 0x04028669 RID: 165481
		public const int TxtNum = 5;

		// Token: 0x0402866A RID: 165482
		public const int SprLight = 6;
	}
}
