using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022AC RID: 8876
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyOverviewView : UiViewBase
{
	// Token: 0x06011614 RID: 71188 RVA: 0x00440E83 File Offset: 0x0043F083
	public MotorcycleDiyOverviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011615 RID: 71189 RVA: 0x00440EA4 File Offset: 0x0043F0A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06011616 RID: 71190 RVA: 0x00440F14 File Offset: 0x0043F114
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyOverviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyOverviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011617 RID: 71191 RVA: 0x00440F58 File Offset: 0x0043F158
	protected override void OnBeforeShow()
	{
		int index = this.CurrentSelectPart - 1;
		this.PartTabComponent.SelectToggleByIndex(index, false, true);
	}

	// Token: 0x06011618 RID: 71192 RVA: 0x00440F7C File Offset: 0x0043F17C
	private MotorcycleDiyPartTabItem InitPartTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x06011619 RID: 71193 RVA: 0x00440F84 File Offset: 0x0043F184
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
	}

	// Token: 0x0601161A RID: 71194 RVA: 0x00440FB7 File Offset: 0x0043F1B7
	private MotorcycleDiyStickerDecoItem CreateOverviewItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickOverView)
		};
	}

	// Token: 0x0601161B RID: 71195 RVA: 0x00440FD0 File Offset: 0x0043F1D0
	private List<MotorcycleDiyStickerDecoItemData> GetItemDataList(int partId)
	{
		if (this.CurrentOutlookType == EOutlookType.Sticker)
		{
			return this.GetStickerItemDataList(partId);
		}
		if (this.CurrentOutlookType == EOutlookType.Decoration)
		{
			return this.GetDecorationItemDataList(partId);
		}
		return new List<MotorcycleDiyStickerDecoItemData>();
	}

	// Token: 0x0601161C RID: 71196 RVA: 0x00440FFC File Offset: 0x0043F1FC
	private List<MotorcycleDiyStickerDecoItemData> GetStickerItemDataList(int partId)
	{
		List<MotorcycleDiyStickerDecoItemData> list = new List<MotorcycleDiyStickerDecoItemData>();
		list.Add(new MotorcycleDiyStickerDecoItemData
		{
			Part = partId,
			ItemId = 0,
			IsSticker = true
		});
		int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedStickerId(partId));
		if (num != null && num.Value > 0)
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num.Value);
			list.Add(new MotorcycleDiyStickerDecoItemData
			{
				Part = partId,
				ItemId = num.Value,
				QualityId = ((motorStickerConfig != null) ? motorStickerConfig.Value.QualityId : 0),
				SortIndex = ((motorStickerConfig != null) ? motorStickerConfig.Value.SortIndex : 0),
				IsSticker = true
			});
		}
		foreach (int num2 in MotorcycleDiyModel.Instance.GetCanUseStickerIdsInRegion())
		{
			MotorSticker? motorStickerConfig2 = MotorDiyConfig.Instance.GetMotorStickerConfig(num2);
			if (motorStickerConfig2 != null && motorStickerConfig2.Value.PartId == partId)
			{
				EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(num2);
				if (stickerState != EOutLookState.IsHide && stickerState != EOutLookState.IsEquipped)
				{
					list.Add(new MotorcycleDiyStickerDecoItemData
					{
						Part = partId,
						ItemId = num2,
						QualityId = motorStickerConfig2.Value.QualityId,
						SortIndex = motorStickerConfig2.Value.SortIndex,
						IsSticker = true
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0601161D RID: 71197 RVA: 0x004411C8 File Offset: 0x0043F3C8
	private List<MotorcycleDiyStickerDecoItemData> GetDecorationItemDataList(int partId)
	{
		List<MotorcycleDiyStickerDecoItemData> list = new List<MotorcycleDiyStickerDecoItemData>();
		list.Add(new MotorcycleDiyStickerDecoItemData
		{
			Part = partId,
			ItemId = 0,
			IsSticker = false
		});
		int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedDecorationId(partId));
		if (num != null && num.Value > 0)
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num.Value);
			list.Add(new MotorcycleDiyStickerDecoItemData
			{
				Part = partId,
				ItemId = num.Value,
				QualityId = ((motorDecorationConfig != null) ? motorDecorationConfig.Value.QualityId : 0),
				SortIndex = ((motorDecorationConfig != null) ? motorDecorationConfig.Value.SortIndex : 0),
				IsSticker = false
			});
		}
		foreach (int num2 in MotorcycleDiyModel.Instance.GetCanUseDecorationsIdsInRegion())
		{
			MotorDecorations? motorDecorationConfig2 = MotorDiyConfig.Instance.GetMotorDecorationConfig(num2);
			if (motorDecorationConfig2 != null && motorDecorationConfig2.Value.PartId == partId)
			{
				EOutLookState decorationState = MotorcycleDiyModel.Instance.GetDecorationState(num2);
				if (decorationState != EOutLookState.IsHide && decorationState != EOutLookState.IsEquipped)
				{
					list.Add(new MotorcycleDiyStickerDecoItemData
					{
						Part = partId,
						ItemId = num2,
						QualityId = motorDecorationConfig2.Value.QualityId,
						SortIndex = motorDecorationConfig2.Value.SortIndex,
						IsSticker = false
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0601161E RID: 71198 RVA: 0x00441394 File Offset: 0x0043F594
	private int SortItemFunc(MotorcycleDiyStickerDecoItemData dataA, MotorcycleDiyStickerDecoItemData dataB)
	{
		EOutLookState itemState = MotorcycleDiyModel.Instance.GetItemState(this.CurrentOutlookType, dataA.ItemId);
		EOutLookState itemState2 = MotorcycleDiyModel.Instance.GetItemState(this.CurrentOutlookType, dataB.ItemId);
		if (itemState != itemState2)
		{
			return itemState - itemState2;
		}
		int num = (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(dataA.ItemId) > false) ? 1 : 0;
		int num2 = (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(dataB.ItemId) > false) ? 1 : 0;
		if (num != num2)
		{
			return num2 - num;
		}
		int qualityId = dataA.QualityId;
		int qualityId2 = dataB.QualityId;
		if (qualityId != qualityId2)
		{
			return qualityId2 - qualityId;
		}
		int sortIndex = dataA.SortIndex;
		return dataB.SortIndex - sortIndex;
	}

	// Token: 0x0601161F RID: 71199 RVA: 0x00441434 File Offset: 0x0043F634
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(this.CurrentOutlookType, new int?(partId));
			List<MotorcycleDiyStickerDecoItemData> dataList = this.GetItemDataList(partId);
			dataList.Sort(new Comparison<MotorcycleDiyStickerDecoItemData>(this.SortItemFunc));
			this.OverviewScrollView.RefreshByData(dataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, dataList);
			}, false);
			this.CachedDataList = dataList;
			return;
		}
		this.OverviewScrollView.RefreshByData(this.CachedDataList, true, null, false);
	}

	// Token: 0x06011620 RID: 71200 RVA: 0x004414DC File Offset: 0x0043F6DC
	private void AutoSelectGridByDataList(int partId, List<MotorcycleDiyStickerDecoItemData> dataList)
	{
		int gridIndex = 0;
		int selectItemId = 0;
		int selectedItemId = MotorcycleDiyModel.Instance.GetSelectedItemId(this.CurrentOutlookType, new int?(partId));
		if (selectedItemId != 0)
		{
			selectItemId = selectedItemId;
		}
		else
		{
			selectItemId = MotorcycleDiyModel.Instance.GetEquippedItemId(this.CurrentOutlookType, partId);
		}
		int num = dataList.IndexOf((MotorcycleDiyStickerDecoItemData data) => data.ItemId == selectItemId);
		if (num >= 0)
		{
			gridIndex = num;
		}
		if (!this.OverviewScrollView.IsGridDisplaying(gridIndex))
		{
			this.OverviewScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.OverviewScrollView.DeselectCurrentGridProxy(false);
		this.OverviewScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06011621 RID: 71201 RVA: 0x00441580 File Offset: 0x0043F780
	private void OnClickOverView(int itemId, UUIExtendToggle toggle, UUIItem newItem)
	{
		EOutLookState itemState = MotorcycleDiyModel.Instance.GetItemState(this.CurrentOutlookType, itemId);
		if (itemState == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = MotorcycleDiyModel.Instance.GetBanTips(this.CurrentOutlookType, itemId);
			if (banTips != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYWarning01", new object[]
				{
					banTips.Value.Item1,
					banTips.Value.Item2
				});
			}
			return;
		}
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		bool flag;
		bool flag2;
		if (this.CurrentOutlookType != EOutlookType.Sticker)
		{
			if (this.CurrentOutlookType == EOutlookType.Decoration)
			{
				MotorcycleDiyModel.Instance.SetSelectDecorationInfo(this.CurrentSelectPart, itemId);
				flag = MotorcycleDiyModel.Instance.IsEquipDefaultDecoration(this.CurrentSelectPart);
				flag2 = (itemId == 0 && !flag);
				if (itemState == EOutLookState.CanEquipped || flag2)
				{
					List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(true);
					MotorcycleDiyController.Instance.EquipMotorDecorationRequest(selectedDecorationIdList, delegate
					{
						this.RefreshScrollViewByData(this.CurrentSelectPart, false);
					});
					return;
				}
				this.RefreshScrollViewByData(this.CurrentSelectPart, false);
			}
			return;
		}
		MotorcycleDiyModel.Instance.SetSelectStickerInfo(this.CurrentSelectPart, itemId);
		flag = MotorcycleDiyModel.Instance.IsEquipDefaultSticker(this.CurrentSelectPart);
		flag2 = (itemId == 0 && !flag);
		if (itemState == EOutLookState.CanEquipped || flag2)
		{
			List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(true);
			MotorcycleDiyController.Instance.EquipMotorStickerRequest(selectedStickerIdList, delegate
			{
				this.RefreshScrollViewByData(this.CurrentSelectPart, false);
			});
			return;
		}
		this.RefreshScrollViewByData(this.CurrentSelectPart, false);
	}

	// Token: 0x06011622 RID: 71202 RVA: 0x00441713 File Offset: 0x0043F913
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008410 RID: 33808
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008411 RID: 33809
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x04008412 RID: 33810
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> OverviewScrollView;

	// Token: 0x04008413 RID: 33811
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x04008414 RID: 33812
	private List<MotorcycleDiyStickerDecoItemData> CachedDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x04008415 RID: 33813
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008416 RID: 33814
	private int CurrentSelectPart;

	// Token: 0x04008417 RID: 33815
	private EOutlookType CurrentOutlookType;

	// Token: 0x0200880F RID: 34831
	[NullableContext(0)]
	private class EMotorDiyOverviewComponent
	{
		// Token: 0x0402C37B RID: 181115
		public const int CaptionItem = 0;

		// Token: 0x0402C37C RID: 181116
		public const int TabScrollView = 1;

		// Token: 0x0402C37D RID: 181117
		public const int TabContent = 2;

		// Token: 0x0402C37E RID: 181118
		public const int TabItem = 3;

		// Token: 0x0402C37F RID: 181119
		public const int OverviewScrollView = 4;

		// Token: 0x0402C380 RID: 181120
		public const int OverviewItem = 5;
	}
}
