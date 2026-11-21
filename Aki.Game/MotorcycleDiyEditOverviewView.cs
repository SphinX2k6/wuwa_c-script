using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200178A RID: 6026
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditOverviewView : UiViewBase
{
	// Token: 0x0600EA32 RID: 59954 RVA: 0x0044A919 File Offset: 0x00448B19
	public MotorcycleDiyEditOverviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EA33 RID: 59955 RVA: 0x0044A938 File Offset: 0x00448B38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600EA34 RID: 59956 RVA: 0x0044A9E4 File Offset: 0x00448BE4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditOverviewView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditOverviewView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA35 RID: 59957 RVA: 0x0044AA28 File Offset: 0x00448C28
	protected override void OnBeforeShow()
	{
		int index = this.CurrentSelectPart - 1;
		TabComponent<MotorcycleDiyPartTabItem> partTabComponent = this.PartTabComponent;
		if (partTabComponent == null)
		{
			return;
		}
		partTabComponent.SelectToggleByIndex(index, false, true);
	}

	// Token: 0x0600EA36 RID: 59958 RVA: 0x0044AA51 File Offset: 0x00448C51
	private MotorcycleDiyPartTabItem InitPartTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0600EA37 RID: 59959 RVA: 0x0044AA58 File Offset: 0x00448C58
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
	}

	// Token: 0x0600EA38 RID: 59960 RVA: 0x0044AA8B File Offset: 0x00448C8B
	private MotorcycleDiyEditStickerDecoItem CreateOverviewItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickOverView)
		};
	}

	// Token: 0x0600EA39 RID: 59961 RVA: 0x0044AAA4 File Offset: 0x00448CA4
	private List<MotorcycleDiyEditStickerDecoItemData> GetItemDataList(int partId)
	{
		return this.GetStickerItemDataList(partId);
	}

	// Token: 0x0600EA3A RID: 59962 RVA: 0x0044AAB0 File Offset: 0x00448CB0
	private List<MotorcycleDiyEditStickerDecoItemData> GetStickerItemDataList(int partId)
	{
		List<MotorcycleDiyEditStickerDecoItemData> list = new List<MotorcycleDiyEditStickerDecoItemData>
		{
			new MotorcycleDiyEditStickerDecoItemData
			{
				Part = partId,
				ItemId = 0,
				IsSticker = true
			}
		};
		foreach (int num in MotorcycleDiyModel.Instance.GetCanUseStickerIdsInRegion())
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
			if (motorStickerConfig != null && motorStickerConfig.Value.PartId == partId)
			{
				int stickerState = (int)MotorcycleDiyModel.Instance.GetStickerState(num);
				bool flag = MotorcycleDiyModel.Instance.HasSticker(num);
				if (stickerState != 0 && flag)
				{
					list.Add(new MotorcycleDiyEditStickerDecoItemData
					{
						Part = partId,
						ItemId = num,
						QualityId = motorStickerConfig.Value.QualityId,
						SortIndex = motorStickerConfig.Value.SortIndex,
						IsSticker = true
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0600EA3B RID: 59963 RVA: 0x0044ABC4 File Offset: 0x00448DC4
	private int SortItemFunc(MotorcycleDiyEditStickerDecoItemData dataA, MotorcycleDiyEditStickerDecoItemData dataB)
	{
		EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(dataA.ItemId);
		EOutLookState stickerState2 = MotorcycleDiyModel.Instance.GetStickerState(dataB.ItemId);
		if (stickerState != stickerState2)
		{
			return stickerState - stickerState2;
		}
		if (dataA.QualityId != dataB.QualityId)
		{
			return dataB.QualityId - dataA.QualityId;
		}
		return dataB.SortIndex - dataA.SortIndex;
	}

	// Token: 0x0600EA3C RID: 59964 RVA: 0x0044AC24 File Offset: 0x00448E24
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (this.OverviewScrollView == null)
		{
			return;
		}
		if (isNeedRefresh)
		{
			List<MotorcycleDiyEditStickerDecoItemData> dataList = this.GetItemDataList(partId);
			dataList.Sort(new Comparison<MotorcycleDiyEditStickerDecoItemData>(this.SortItemFunc));
			this.CachedDataList = dataList;
			this.OverviewScrollView.RefreshByData(dataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, dataList);
			}, false);
			return;
		}
		this.OverviewScrollView.RefreshByData(this.CachedDataList, true, null, false);
	}

	// Token: 0x0600EA3D RID: 59965 RVA: 0x0044ACBC File Offset: 0x00448EBC
	private void AutoSelectGridByDataList(int partId, List<MotorcycleDiyEditStickerDecoItemData> dataList)
	{
		if (this.OverviewScrollView == null)
		{
			return;
		}
		int gridIndex = 0;
		int selectItemId = 0;
		int selectedStickerId = MotorcycleDiyModel.Instance.GetSelectedStickerId(partId);
		if (selectedStickerId != 0)
		{
			selectItemId = selectedStickerId;
		}
		MotorcycleDiyEditStickerDecoItemData motorcycleDiyEditStickerDecoItemData = dataList.Find((MotorcycleDiyEditStickerDecoItemData data) => data.ItemId == selectItemId);
		if (motorcycleDiyEditStickerDecoItemData != null)
		{
			gridIndex = dataList.IndexOf(motorcycleDiyEditStickerDecoItemData);
		}
		if (!this.OverviewScrollView.IsGridDisplaying(gridIndex))
		{
			this.OverviewScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.OverviewScrollView.DeselectCurrentGridProxy(false);
		this.OverviewScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x0600EA3E RID: 59966 RVA: 0x0044AD4C File Offset: 0x00448F4C
	private void RefreshStickerEditRedDots()
	{
		MotorcycleDiyPresetData localPresetData = this.LocalPresetData;
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		Dictionary<int, MotorcycleDiyPartTabItem> tabItemMap = this.PartTabComponent.GetTabItemMap();
		bool arg = false;
		foreach (KeyValuePair<int, MotorcycleDiyPartTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			MotorcycleDiyPartTabItem value = keyValuePair.Value;
			int partId = this.PartTabItemDataList[key].PartId;
			if (localPresetData == null)
			{
				value.SetPresetRedDotVisible(false);
			}
			else
			{
				int num = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART, partId);
				int num2 = (num >= 0 && num < localPresetData.StickerIds.Length) ? localPresetData.StickerIds[num] : 0;
				bool flag = instance.GetSelectedStickerId(partId) != num2;
				value.SetPresetRedDotVisible(flag);
				if (flag)
				{
					arg = true;
				}
			}
		}
		Action<EOutlookType, bool> onEditPresetChanged = this.OnEditPresetChanged;
		if (onEditPresetChanged == null)
		{
			return;
		}
		onEditPresetChanged(EOutlookType.Sticker, arg);
	}

	// Token: 0x0600EA3F RID: 59967 RVA: 0x0044AE48 File Offset: 0x00449048
	private void OnClickOverView(int itemId, UUIExtendToggle toggle, UUIItem newItem)
	{
		if (MotorcycleDiyModel.Instance.GetStickerState(itemId) == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = MotorcycleDiyModel.Instance.GetBanTips(EOutlookType.Sticker, itemId);
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
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		MotorcycleDiyModel.Instance.SetSelectStickerInfo(this.CurrentSelectPart, itemId);
		this.RefreshStickerEditRedDots();
		this.RefreshScrollViewByData(this.CurrentSelectPart, false);
	}

	// Token: 0x0600EA40 RID: 59968 RVA: 0x0044AF09 File Offset: 0x00449109
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008519 RID: 34073
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400851A RID: 34074
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x0400851B RID: 34075
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> OverviewScrollView;

	// Token: 0x0400851C RID: 34076
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x0400851D RID: 34077
	private List<MotorcycleDiyEditStickerDecoItemData> CachedDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x0400851E RID: 34078
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400851F RID: 34079
	private int CurrentSelectPart;

	// Token: 0x04008520 RID: 34080
	[Nullable(2)]
	private MotorcycleDiyPresetData LocalPresetData;

	// Token: 0x04008521 RID: 34081
	[Nullable(2)]
	private Action<EOutlookType, bool> OnEditPresetChanged;

	// Token: 0x0200797F RID: 31103
	[NullableContext(0)]
	private class EMotorDiyOverviewComponent
	{
		// Token: 0x040275FE RID: 161278
		public const int CaptionItem = 0;

		// Token: 0x040275FF RID: 161279
		public const int TabScrollView = 1;

		// Token: 0x04027600 RID: 161280
		public const int TabContent = 2;

		// Token: 0x04027601 RID: 161281
		public const int TabItem = 3;

		// Token: 0x04027602 RID: 161282
		public const int OverviewScrollView = 4;

		// Token: 0x04027603 RID: 161283
		public const int OverviewItem = 5;
	}
}
