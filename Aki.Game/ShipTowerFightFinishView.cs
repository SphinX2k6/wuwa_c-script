using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F29 RID: 7977
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerFightFinishView : UiViewBase
{
	// Token: 0x06013C11 RID: 80913 RVA: 0x005C3A49 File Offset: 0x005C1C49
	[NullableContext(1)]
	public ShipTowerFightFinishView(UiViewInfo ViewInfo) : base(ViewInfo)
	{
	}

	// Token: 0x06013C12 RID: 80914 RVA: 0x005C3A54 File Offset: 0x005C1C54
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

	// Token: 0x06013C13 RID: 80915 RVA: 0x005C3BA5 File Offset: 0x005C1DA5
	private void InitDataParam()
	{
	}

	// Token: 0x06013C14 RID: 80916 RVA: 0x005C3BA8 File Offset: 0x005C1DA8
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerFightFinishView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerFightFinishView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C15 RID: 80917 RVA: 0x005C3BEB File Offset: 0x005C1DEB
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06013C16 RID: 80918 RVA: 0x005C3BF3 File Offset: 0x005C1DF3
	[NullableContext(1)]
	private ShipTowerFightFinishItem CreateItem()
	{
		return new ShipTowerFightFinishItem();
	}

	// Token: 0x06013C17 RID: 80919 RVA: 0x005C3BFC File Offset: 0x005C1DFC
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

	// Token: 0x06013C18 RID: 80920 RVA: 0x005C3D00 File Offset: 0x005C1F00
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
		int num = 0;
		for (int i = 0; i < shipTowerFightFinishViewParams.AreaList.Count; i++)
		{
			num += shipTowerFightFinishViewParams.AreaList[i].ScoreA + shipTowerFightFinishViewParams.AreaList[i].ScoreB;
		}
		return num;
	}

	// Token: 0x06013C19 RID: 80921 RVA: 0x005C3D6C File Offset: 0x005C1F6C
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

	// Token: 0x06013C1A RID: 80922 RVA: 0x005C3DBC File Offset: 0x005C1FBC
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

	// Token: 0x06013C1B RID: 80923 RVA: 0x005C3E0C File Offset: 0x005C200C
	private UniTask OnShareBtnClickedAsync()
	{
		ShipTowerFightFinishView.<OnShareBtnClickedAsync>d__18 <OnShareBtnClickedAsync>d__;
		<OnShareBtnClickedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShareBtnClickedAsync>d__.<>4__this = this;
		<OnShareBtnClickedAsync>d__.<>1__state = -1;
		<OnShareBtnClickedAsync>d__.<>t__builder.Start<ShipTowerFightFinishView.<OnShareBtnClickedAsync>d__18>(ref <OnShareBtnClickedAsync>d__);
		return <OnShareBtnClickedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C1C RID: 80924 RVA: 0x005C3E50 File Offset: 0x005C2050
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

	// Token: 0x0400A8CD RID: 43213
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerFightFinishItem, ShipTowerFightFinishItemData> AreaLayout;

	// Token: 0x0400A8CE RID: 43214
	private ButtonItem BtnLeft;

	// Token: 0x0400A8CF RID: 43215
	private ButtonItem BtnRight;

	// Token: 0x0400A8D0 RID: 43216
	private ShareBtnItem ShareBtnItem;

	// Token: 0x0400A8D1 RID: 43217
	private IRewardExploreConfirmButton BtnLeftInfo;

	// Token: 0x0400A8D2 RID: 43218
	private IRewardExploreConfirmButton BtnRightInfo;

	// Token: 0x0400A8D3 RID: 43219
	private ShipTowerStageData StageData;

	// Token: 0x02008209 RID: 33289
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029FF5 RID: 172021
		public const int VLayoutContainer = 0;

		// Token: 0x04029FF6 RID: 172022
		public const int ItemArea = 1;

		// Token: 0x04029FF7 RID: 172023
		public const int ItemNewRecord = 2;

		// Token: 0x04029FF8 RID: 172024
		public const int TextScore = 3;

		// Token: 0x04029FF9 RID: 172025
		public const int TextureGrade = 4;

		// Token: 0x04029FFA RID: 172026
		public const int BtnRight = 5;

		// Token: 0x04029FFB RID: 172027
		public const int BtnLeft = 6;

		// Token: 0x04029FFC RID: 172028
		public const int TextRightBtnDesc = 7;

		// Token: 0x04029FFD RID: 172029
		public const int ShareItem = 8;
	}
}
