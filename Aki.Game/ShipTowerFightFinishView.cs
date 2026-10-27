using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029AE RID: 10670
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerFightFinishView : UiViewBase
{
	// Token: 0x0601620B RID: 90635 RVA: 0x00598AD1 File Offset: 0x00596CD1
	[NullableContext(1)]
	public ShipTowerFightFinishView(UiViewInfo ViewInfo) : base(ViewInfo)
	{
	}

	// Token: 0x0601620C RID: 90636 RVA: 0x00598ADC File Offset: 0x00596CDC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601620D RID: 90637 RVA: 0x00598C2D File Offset: 0x00596E2D
	private void InitDataParam()
	{
	}

	// Token: 0x0601620E RID: 90638 RVA: 0x00598C30 File Offset: 0x00596E30
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerFightFinishView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerFightFinishView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601620F RID: 90639 RVA: 0x00598C73 File Offset: 0x00596E73
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06016210 RID: 90640 RVA: 0x00598C7B File Offset: 0x00596E7B
	[NullableContext(1)]
	private ShipTowerFightFinishItem CreateItem()
	{
		return new ShipTowerFightFinishItem();
	}

	// Token: 0x06016211 RID: 90641 RVA: 0x00598C84 File Offset: 0x00596E84
	private void UpdateData()
	{
		ShipTowerFightFinishViewParams shipTowerFightFinishViewParams = this.OpenParam as ShipTowerFightFinishViewParams;
		GenericLayout<ShipTowerFightFinishItem, ShipTowerFightFinishItemData> areaLayout = this.AreaLayout;
		if (areaLayout != null)
		{
			areaLayout.RefreshByData(((shipTowerFightFinishViewParams != null) ? shipTowerFightFinishViewParams.AreaList : null) ?? new List<ShipTowerFightFinishItemData>(), null, false);
		}
		base.GetText(3).SetText(this.GetTotalScore().ToString(), true);
		UUITexture texture = base.GetTexture(4);
		bool flag = ((shipTowerFightFinishViewParams != null) ? shipTowerFightFinishViewParams.GradeResId : null) != null;
		texture.SetUIActive(flag);
		if (flag)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(shipTowerFightFinishViewParams.GradeResId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
		base.GetItem(2).SetUIActive(shipTowerFightFinishViewParams != null && shipTowerFightFinishViewParams.IsNewRecord);
		bool flag2 = shipTowerFightFinishViewParams != null && shipTowerFightFinishViewParams.IsEndless && this.GetTotalScore() > 0;
		ShareBtnItem shareBtnItem = this.ShareBtnItem;
		if (shareBtnItem != null)
		{
			shareBtnItem.SetUiActive(flag2);
		}
		if (flag2)
		{
			ShareBtnItem shareBtnItem2 = this.ShareBtnItem;
			if (shareBtnItem2 != null)
			{
				shareBtnItem2.SetShareActionId(EShareActionId.ChallengeRecord);
			}
		}
		this.UpdateBtn();
	}

	// Token: 0x06016212 RID: 90642 RVA: 0x00598D88 File Offset: 0x00596F88
	private int GetTotalScore()
	{
		ShipTowerFightFinishViewParams shipTowerFightFinishViewParams = this.OpenParam as ShipTowerFightFinishViewParams;
		if (shipTowerFightFinishViewParams == null)
		{
			return 0;
		}
		if (shipTowerFightFinishViewParams.TotalScore != 0)
		{
			return shipTowerFightFinishViewParams.TotalScore;
		}
		return shipTowerFightFinishViewParams.AreaList.Sum((ShipTowerFightFinishItemData x) => x.ScoreA + x.ScoreB);
	}

	// Token: 0x06016213 RID: 90643 RVA: 0x00598DE0 File Offset: 0x00596FE0
	private void OnBtnLeftClicked()
	{
		IRewardExploreConfirmButton btnLeftInfo = this.BtnLeftInfo;
		if (((btnLeftInfo != null) ? btnLeftInfo.OnClickedCallback : null) != null)
		{
			this.BtnLeftInfo.OnClickedCallback(0);
		}
		if (this.BtnLeftInfo != null && this.BtnLeftInfo.IsClickedCloseView)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06016214 RID: 90644 RVA: 0x00598E30 File Offset: 0x00597030
	private void OnBtnRightClicked()
	{
		IRewardExploreConfirmButton btnRightInfo = this.BtnRightInfo;
		if (((btnRightInfo != null) ? btnRightInfo.OnClickedCallback : null) != null)
		{
			this.BtnRightInfo.OnClickedCallback(1);
		}
		if (this.BtnRightInfo != null && this.BtnRightInfo.IsClickedCloseView)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06016215 RID: 90645 RVA: 0x00598E80 File Offset: 0x00597080
	private UniTask OnShareBtnClickedAsync()
	{
		ShipTowerFightFinishView.<OnShareBtnClickedAsync>d__18 <OnShareBtnClickedAsync>d__;
		<OnShareBtnClickedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShareBtnClickedAsync>d__.<>4__this = this;
		<OnShareBtnClickedAsync>d__.<>1__state = -1;
		<OnShareBtnClickedAsync>d__.<>t__builder.Start<ShipTowerFightFinishView.<OnShareBtnClickedAsync>d__18>(ref <OnShareBtnClickedAsync>d__);
		return <OnShareBtnClickedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016216 RID: 90646 RVA: 0x00598EC4 File Offset: 0x005970C4
	private unsafe void UpdateBtn()
	{
		UUIText text = base.GetText(7);
		<>y__InlineArray2<ButtonItem> <>y__InlineArray = default(<>y__InlineArray2<ButtonItem>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ButtonItem>, ButtonItem>(ref <>y__InlineArray, 0) = this.BtnLeft;
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ButtonItem>, ButtonItem>(ref <>y__InlineArray, 1) = this.BtnRight;
		Span<ButtonItem> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray2<ButtonItem>, ButtonItem>(ref <>y__InlineArray, 2);
		<>y__InlineArray2<UUIText> <>y__InlineArray2 = default(<>y__InlineArray2<UUIText>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<UUIText>, UUIText>(ref <>y__InlineArray2, 0) = null;
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<UUIText>, UUIText>(ref <>y__InlineArray2, 1) = text;
		Span<UUIText> span2 = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray2<UUIText>, UUIText>(ref <>y__InlineArray2, 2);
		ShipTowerFightFinishViewParams shipTowerFightFinishViewParams = this.OpenParam as ShipTowerFightFinishViewParams;
		for (int i = 0; i < span.Length; i++)
		{
			ButtonItem buttonItem = *span[i];
			IRewardExploreConfirmButton rewardExploreConfirmButton = (shipTowerFightFinishViewParams != null) ? shipTowerFightFinishViewParams.ButtonList[i] : null;
			if (rewardExploreConfirmButton != null)
			{
				if (buttonItem != null)
				{
					buttonItem.SetShowText(rewardExploreConfirmButton.ButtonTextId);
				}
				string descriptionTextId = rewardExploreConfirmButton.DescriptionTextId;
				if (descriptionTextId != null)
				{
					List<object> descriptionArgs = rewardExploreConfirmButton.DescriptionArgs;
					if (descriptionArgs != null && descriptionArgs.Count > 0)
					{
						object[] array = new object[descriptionArgs.Count];
						for (int j = 0; j < descriptionArgs.Count; j++)
						{
							array[j] = descriptionArgs[j];
						}
						LguiUtil.Instance.SetLocalTextNew(*span2[i], descriptionTextId, array);
					}
					else
					{
						LguiUtil.Instance.SetLocalTextNew(*span2[i], descriptionTextId, Array.Empty<object>());
					}
				}
				UUIText uuitext = *span2[i];
				if (uuitext != null)
				{
					uuitext.SetUIActive(descriptionTextId != null);
				}
			}
			if (buttonItem != null)
			{
				buttonItem.SetActive(rewardExploreConfirmButton != null);
			}
		}
		this.BtnLeftInfo = ((shipTowerFightFinishViewParams != null) ? shipTowerFightFinishViewParams.ButtonList.GetValueOrDefault(0) : null);
		this.BtnRightInfo = ((shipTowerFightFinishViewParams != null) ? shipTowerFightFinishViewParams.ButtonList.GetValueOrDefault(1) : null);
	}

	// Token: 0x0400A4E3 RID: 42211
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerFightFinishItem, ShipTowerFightFinishItemData> AreaLayout;

	// Token: 0x0400A4E4 RID: 42212
	private ButtonItem BtnLeft;

	// Token: 0x0400A4E5 RID: 42213
	private ButtonItem BtnRight;

	// Token: 0x0400A4E6 RID: 42214
	private ShareBtnItem ShareBtnItem;

	// Token: 0x0400A4E7 RID: 42215
	private IRewardExploreConfirmButton BtnLeftInfo;

	// Token: 0x0400A4E8 RID: 42216
	private IRewardExploreConfirmButton BtnRightInfo;

	// Token: 0x0400A4E9 RID: 42217
	private ShipTowerStageData StageData;

	// Token: 0x02008FC0 RID: 36800
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E8F6 RID: 190710
		public const int VLayoutContainer = 0;

		// Token: 0x0402E8F7 RID: 190711
		public const int ItemArea = 1;

		// Token: 0x0402E8F8 RID: 190712
		public const int ItemNewRecord = 2;

		// Token: 0x0402E8F9 RID: 190713
		public const int TextScore = 3;

		// Token: 0x0402E8FA RID: 190714
		public const int TextureGrade = 4;

		// Token: 0x0402E8FB RID: 190715
		public const int BtnRight = 5;

		// Token: 0x0402E8FC RID: 190716
		public const int BtnLeft = 6;

		// Token: 0x0402E8FD RID: 190717
		public const int TextRightBtnDesc = 7;

		// Token: 0x0402E8FE RID: 190718
		public const int ShareItem = 8;
	}
}
