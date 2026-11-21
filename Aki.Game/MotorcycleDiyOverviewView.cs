using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001790 RID: 6032
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyOverviewView : UiViewBase
{
	// Token: 0x0600EAAC RID: 60076 RVA: 0x0044DA7B File Offset: 0x0044BC7B
	public MotorcycleDiyOverviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EAAD RID: 60077 RVA: 0x0044DA9C File Offset: 0x0044BC9C
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

	// Token: 0x0600EAAE RID: 60078 RVA: 0x0044DB0C File Offset: 0x0044BD0C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyOverviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyOverviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAAF RID: 60079 RVA: 0x0044DB50 File Offset: 0x0044BD50
	protected override void OnBeforeShow()
	{
		int index = this.CurrentSelectPart - 1;
		this.PartTabComponent.SelectToggleByIndex(index, false, true);
	}

	// Token: 0x0600EAB0 RID: 60080 RVA: 0x0044DB74 File Offset: 0x0044BD74
	private MotorcycleDiyPartTabItem InitPartTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0600EAB1 RID: 60081 RVA: 0x0044DB7C File Offset: 0x0044BD7C
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
	}

	// Token: 0x0600EAB2 RID: 60082 RVA: 0x0044DBAF File Offset: 0x0044BDAF
	private MotorcycleDiyStickerDecoItem CreateOverviewItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickOverView)
		};
	}

	// Token: 0x0600EAB3 RID: 60083 RVA: 0x0044DBC8 File Offset: 0x0044BDC8
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

	// Token: 0x0600EAB4 RID: 60084 RVA: 0x0044DBF4 File Offset: 0x0044BDF4
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

	// Token: 0x0600EAB5 RID: 60085 RVA: 0x0044DDC0 File Offset: 0x0044BFC0
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

	// Token: 0x0600EAB6 RID: 60086 RVA: 0x0044DF8C File Offset: 0x0044C18C
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

	// Token: 0x0600EAB7 RID: 60087 RVA: 0x0044E02C File Offset: 0x0044C22C
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

	// Token: 0x0600EAB8 RID: 60088 RVA: 0x0044E0D4 File Offset: 0x0044C2D4
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

	// Token: 0x0600EAB9 RID: 60089 RVA: 0x0044E178 File Offset: 0x0044C378
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

	// Token: 0x0600EABA RID: 60090 RVA: 0x0044E30B File Offset: 0x0044C50B
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400854E RID: 34126
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400854F RID: 34127
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x04008550 RID: 34128
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> OverviewScrollView;

	// Token: 0x04008551 RID: 34129
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x04008552 RID: 34130
	private List<MotorcycleDiyStickerDecoItemData> CachedDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x04008553 RID: 34131
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008554 RID: 34132
	private int CurrentSelectPart;

	// Token: 0x04008555 RID: 34133
	private EOutlookType CurrentOutlookType;

	// Token: 0x02007995 RID: 31125
	[NullableContext(0)]
	private class EMotorDiyOverviewComponent
	{
		// Token: 0x04027683 RID: 161411
		public const int CaptionItem = 0;

		// Token: 0x04027684 RID: 161412
		public const int TabScrollView = 1;

		// Token: 0x04027685 RID: 161413
		public const int TabContent = 2;

		// Token: 0x04027686 RID: 161414
		public const int TabItem = 3;

		// Token: 0x04027687 RID: 161415
		public const int OverviewScrollView = 4;

		// Token: 0x04027688 RID: 161416
		public const int OverviewItem = 5;
	}
}
