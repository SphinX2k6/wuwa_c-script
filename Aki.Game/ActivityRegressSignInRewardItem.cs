using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200094E RID: 2382
public class ActivityRegressSignInRewardItem : UiPanelBase
{
	// Token: 0x06006906 RID: 26886 RVA: 0x0020CCC8 File Offset: 0x0020AEC8
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

	// Token: 0x06006907 RID: 26887 RVA: 0x0020CD9D File Offset: 0x0020AF9D
	[NullableContext(1)]
	public void RegisterItemClickCallBack(Action<int> onRewardItemClick)
	{
		this.OnRewardItemClick = onRewardItemClick;
	}

	// Token: 0x06006908 RID: 26888 RVA: 0x0020CDA8 File Offset: 0x0020AFA8
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(4).GetOwner());
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClicked));
	}

	// Token: 0x06006909 RID: 26889 RVA: 0x0020CE18 File Offset: 0x0020B018
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

	// Token: 0x0600690A RID: 26890 RVA: 0x0020CF08 File Offset: 0x0020B108
	[NullableContext(1)]
	private void OnRewardItemClicked(MediumItemGridExtendCallback _)
	{
		this.OnClickRewardItem();
	}

	// Token: 0x0600690B RID: 26891 RVA: 0x0020CF10 File Offset: 0x0020B110
	private void OnClickRewardItem()
	{
		if (!ActivityRegressModel.Instance.CheckSignRewardState(this.Day, ERegressRewardState.Reached))
		{
			RegressSignReward? signRewardConfigByIndex = ActivityRegressModel.Instance.GetSignRewardConfigByIndex(this.Index);
			int? item = ActivityRegressModel.Instance.GetSignRewardPreviewReward(signRewardConfigByIndex.Value).Item1;
			if (item != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(item.Value, true, null, false);
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

	// Token: 0x040042AE RID: 17070
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x040042AF RID: 17071
	private int Index;

	// Token: 0x040042B0 RID: 17072
	private int Day;

	// Token: 0x040042B1 RID: 17073
	[Nullable(2)]
	private Action<int> OnRewardItemClick;

	// Token: 0x02006C50 RID: 27728
	private class EComponents
	{
		// Token: 0x0402397E RID: 145790
		public const int RootBtn = 0;

		// Token: 0x0402397F RID: 145791
		public const int PnlReceive = 1;

		// Token: 0x04023980 RID: 145792
		public const int PnlDone = 2;

		// Token: 0x04023981 RID: 145793
		public const int TxtNor = 3;

		// Token: 0x04023982 RID: 145794
		public const int ItemGrid = 4;

		// Token: 0x04023983 RID: 145795
		public const int TxtNum = 5;

		// Token: 0x04023984 RID: 145796
		public const int SprLight = 6;
	}
}
