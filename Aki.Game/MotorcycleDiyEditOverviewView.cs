using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A6 RID: 8870
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditOverviewView : UiViewBase
{
	// Token: 0x0601159A RID: 71066 RVA: 0x0043DD25 File Offset: 0x0043BF25
	public MotorcycleDiyEditOverviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601159B RID: 71067 RVA: 0x0043DD44 File Offset: 0x0043BF44
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

	// Token: 0x0601159C RID: 71068 RVA: 0x0043DDF0 File Offset: 0x0043BFF0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditOverviewView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditOverviewView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601159D RID: 71069 RVA: 0x0043DE34 File Offset: 0x0043C034
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

	// Token: 0x0601159E RID: 71070 RVA: 0x0043DE5D File Offset: 0x0043C05D
	private MotorcycleDiyPartTabItem InitPartTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0601159F RID: 71071 RVA: 0x0043DE64 File Offset: 0x0043C064
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
	}

	// Token: 0x060115A0 RID: 71072 RVA: 0x0043DE97 File Offset: 0x0043C097
	private MotorcycleDiyEditStickerDecoItem CreateOverviewItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickOverView)
		};
	}

	// Token: 0x060115A1 RID: 71073 RVA: 0x0043DEB0 File Offset: 0x0043C0B0
	private List<MotorcycleDiyEditStickerDecoItemData> GetItemDataList(int partId)
	{
		return this.GetStickerItemDataList(partId);
	}

	// Token: 0x060115A2 RID: 71074 RVA: 0x0043DEBC File Offset: 0x0043C0BC
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

	// Token: 0x060115A3 RID: 71075 RVA: 0x0043DFD0 File Offset: 0x0043C1D0
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

	// Token: 0x060115A4 RID: 71076 RVA: 0x0043E030 File Offset: 0x0043C230
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

	// Token: 0x060115A5 RID: 71077 RVA: 0x0043E0C8 File Offset: 0x0043C2C8
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
		MotorcycleDiyEditStickerDecoItemData motorcycleDiyEditStickerDecoItemData = dataList.FirstOrDefault((MotorcycleDiyEditStickerDecoItemData data) => data.ItemId == selectItemId);
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

	// Token: 0x060115A6 RID: 71078 RVA: 0x0043E158 File Offset: 0x0043C358
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

	// Token: 0x060115A7 RID: 71079 RVA: 0x0043E254 File Offset: 0x0043C454
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

	// Token: 0x060115A8 RID: 71080 RVA: 0x0043E315 File Offset: 0x0043C515
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040083DB RID: 33755
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040083DC RID: 33756
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x040083DD RID: 33757
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> OverviewScrollView;

	// Token: 0x040083DE RID: 33758
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040083DF RID: 33759
	private List<MotorcycleDiyEditStickerDecoItemData> CachedDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x040083E0 RID: 33760
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083E1 RID: 33761
	private int CurrentSelectPart;

	// Token: 0x040083E2 RID: 33762
	[Nullable(2)]
	private MotorcycleDiyPresetData LocalPresetData;

	// Token: 0x040083E3 RID: 33763
	[Nullable(2)]
	private Action<EOutlookType, bool> OnEditPresetChanged;

	// Token: 0x020087F7 RID: 34807
	[NullableContext(0)]
	private class EMotorDiyOverviewComponent
	{
		// Token: 0x0402C2F4 RID: 180980
		public const int CaptionItem = 0;

		// Token: 0x0402C2F5 RID: 180981
		public const int TabScrollView = 1;

		// Token: 0x0402C2F6 RID: 180982
		public const int TabContent = 2;

		// Token: 0x0402C2F7 RID: 180983
		public const int TabItem = 3;

		// Token: 0x0402C2F8 RID: 180984
		public const int OverviewScrollView = 4;

		// Token: 0x0402C2F9 RID: 180985
		public const int OverviewItem = 5;
	}
}
