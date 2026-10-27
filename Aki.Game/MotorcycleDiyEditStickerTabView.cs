using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A0 RID: 8864
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditStickerTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700161B RID: 5659
	// (get) Token: 0x0601152C RID: 70956 RVA: 0x0043AE28 File Offset: 0x00439028
	// (set) Token: 0x0601152D RID: 70957 RVA: 0x0043AE30 File Offset: 0x00439030
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x1700161C RID: 5660
	// (get) Token: 0x0601152E RID: 70958 RVA: 0x0043AE39 File Offset: 0x00439039
	// (set) Token: 0x0601152F RID: 70959 RVA: 0x0043AE41 File Offset: 0x00439041
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x1700161D RID: 5661
	// (get) Token: 0x06011530 RID: 70960 RVA: 0x0043AE4A File Offset: 0x0043904A
	// (set) Token: 0x06011531 RID: 70961 RVA: 0x0043AE52 File Offset: 0x00439052
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x1700161E RID: 5662
	// (get) Token: 0x06011532 RID: 70962 RVA: 0x0043AE5B File Offset: 0x0043905B
	// (set) Token: 0x06011533 RID: 70963 RVA: 0x0043AE63 File Offset: 0x00439063
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x06011534 RID: 70964 RVA: 0x0043AE6C File Offset: 0x0043906C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnBtnOverviewClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011535 RID: 70965 RVA: 0x0043B0EC File Offset: 0x004392EC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditStickerTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditStickerTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011536 RID: 70966 RVA: 0x0043B130 File Offset: 0x00439330
	protected override void OnBeforeShow()
	{
		this.CurrentSelectStickerPart = (this.ExtraParams as int?).GetValueOrDefault();
		int index = (this.CurrentSelectStickerPart > 0) ? (this.CurrentSelectStickerPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x06011537 RID: 70967 RVA: 0x0043B17E File Offset: 0x0043937E
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x06011538 RID: 70968 RVA: 0x0043B19C File Offset: 0x0043939C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x06011539 RID: 70969 RVA: 0x0043B1BA File Offset: 0x004393BA
	[NullableContext(1)]
	private MotorcycleDiyEditPartTabItem InitStickerTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyEditPartTabItem();
	}

	// Token: 0x0601153A RID: 70970 RVA: 0x0043B1C4 File Offset: 0x004393C4
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectStickerPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
		Action<int> onTabCameraClick = this.OnTabCameraClick;
		if (onTabCameraClick == null)
		{
			return;
		}
		onTabCameraClick(this.CurrentSelectStickerPart);
	}

	// Token: 0x0601153B RID: 70971 RVA: 0x0043B20D File Offset: 0x0043940D
	[NullableContext(1)]
	private MotorcycleDiyEditStickerDecoItem CreateStickerItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickSticker)
		};
	}

	// Token: 0x0601153C RID: 70972 RVA: 0x0043B226 File Offset: 0x00439426
	public void RefreshItemScrollView()
	{
		if (this.StickerScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectStickerPart, true);
		}
	}

	// Token: 0x0601153D RID: 70973 RVA: 0x0043B240 File Offset: 0x00439440
	private void RefreshStickerPreviewRedDots()
	{
		Func<MotorcycleDiyPresetData> getLocalPresetData = this.GetLocalPresetData;
		MotorcycleDiyPresetData motorcycleDiyPresetData = (getLocalPresetData != null) ? getLocalPresetData() : null;
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		Dictionary<int, MotorcycleDiyEditPartTabItem> tabItemMap = this.PartTabComponent.GetTabItemMap();
		bool arg = false;
		foreach (KeyValuePair<int, MotorcycleDiyEditPartTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			MotorcycleDiyEditPartTabItem value = keyValuePair.Value;
			int partId = this.PartTabItemDataList[key].PartId;
			if (motorcycleDiyPresetData == null)
			{
				value.SetPresetRedDotVisible(false);
			}
			else
			{
				int num = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART, partId);
				int num2 = (num >= 0 && num < motorcycleDiyPresetData.StickerIds.Length) ? motorcycleDiyPresetData.StickerIds[num] : 0;
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

	// Token: 0x0601153E RID: 70974 RVA: 0x0043B348 File Offset: 0x00439548
	[NullableContext(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> GetStickerItemDataList(int partId)
	{
		List<MotorcycleDiyEditStickerDecoItemData> list = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorcycleDiyEditStickerDecoItemData item = new MotorcycleDiyEditStickerDecoItemData
		{
			Part = partId,
			ItemId = 0,
			IsSticker = true
		};
		list.Add(item);
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

	// Token: 0x0601153F RID: 70975 RVA: 0x0043B45C File Offset: 0x0043965C
	[NullableContext(1)]
	private int SortStickerItemFunc(MotorcycleDiyEditStickerDecoItemData dataA, MotorcycleDiyEditStickerDecoItemData dataB)
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

	// Token: 0x06011540 RID: 70976 RVA: 0x0043B4BC File Offset: 0x004396BC
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			List<MotorcycleDiyEditStickerDecoItemData> stickerDataList = this.GetStickerItemDataList(partId);
			stickerDataList.Sort(new Comparison<MotorcycleDiyEditStickerDecoItemData>(this.SortStickerItemFunc));
			this.StickerScrollView.RefreshByData(stickerDataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, stickerDataList);
			}, false);
			this.CachedStickerDataList = stickerDataList;
			return;
		}
		this.StickerScrollView.RefreshByData(this.CachedStickerDataList, true, null, false);
	}

	// Token: 0x06011541 RID: 70977 RVA: 0x0043B54C File Offset: 0x0043974C
	[NullableContext(1)]
	private void AutoSelectGridByDataList(int stickerPart, List<MotorcycleDiyEditStickerDecoItemData> stickerDataList)
	{
		int gridIndex = 0;
		int selectStickerId = 0;
		int selectedStickerId = MotorcycleDiyModel.Instance.GetSelectedStickerId(stickerPart);
		if (selectedStickerId != 0)
		{
			selectStickerId = selectedStickerId;
		}
		MotorcycleDiyEditStickerDecoItemData motorcycleDiyEditStickerDecoItemData = stickerDataList.Find((MotorcycleDiyEditStickerDecoItemData data) => data.ItemId == selectStickerId);
		if (motorcycleDiyEditStickerDecoItemData != null)
		{
			gridIndex = stickerDataList.IndexOf(motorcycleDiyEditStickerDecoItemData);
		}
		if (!this.StickerScrollView.IsGridDisplaying(gridIndex))
		{
			this.StickerScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.StickerScrollView.DeselectCurrentGridProxy(false);
		this.StickerScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06011542 RID: 70978 RVA: 0x0043B5D0 File Offset: 0x004397D0
	private void OnStickerInfoUpdate()
	{
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
	}

	// Token: 0x06011543 RID: 70979 RVA: 0x0043B5E0 File Offset: 0x004397E0
	[NullableContext(1)]
	private void OnClickSticker(int stickerId, UUIExtendToggle toggle, UUIItem newItem)
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		if (instance.GetStickerState(stickerId) == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = instance.GetBanTips(EOutlookType.Sticker, stickerId);
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
		if (stickerId == 0)
		{
			MotorcycleUiModelUtil.Instance.SetEmptySticker(this.CurrentSelectStickerPart);
		}
		else
		{
			MotorcycleUiModelUtil.Instance.AddMaterialByStickerId(stickerId);
		}
		instance.SetSelectStickerInfo(this.CurrentSelectStickerPart, stickerId);
		this.RefreshStickerPreviewRedDots();
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Sticker, this.CurrentSelectStickerPart, stickerId);
		}
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
		UUIItem item = base.GetItem(7);
		UUIItem item2 = base.GetItem(10);
		UUIItem item3 = base.GetItem(12);
		ULGUIBehaviour button = base.GetButton(9);
		UUIText text = base.GetText(6);
		UUIText text2 = base.GetText(8);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(false);
		if (stickerId <= 0)
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorEmptyStickerName");
			string stringConfig2 = ConfigCommonParamById.GetStringConfig("MotorEmptyStickerType");
			text2.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text2, stringConfig2, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text, stringConfig, Array.Empty<object>());
			return;
		}
		MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(stickerId);
		if (motorStickerConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text2, motorStickerConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text, motorStickerConfig.Value.Title, Array.Empty<object>());
	}

	// Token: 0x06011544 RID: 70980 RVA: 0x0043B7D8 File Offset: 0x004399D8
	private void OnBtnOverviewClick()
	{
		MotorcycleDiyEditOverviewOpenParam motorcycleDiyEditOverviewOpenParam = new MotorcycleDiyEditOverviewOpenParam();
		motorcycleDiyEditOverviewOpenParam.PartId = this.CurrentSelectStickerPart;
		Func<MotorcycleDiyPresetData> getLocalPresetData = this.GetLocalPresetData;
		motorcycleDiyEditOverviewOpenParam.LocalPresetData = ((getLocalPresetData != null) ? getLocalPresetData() : null);
		motorcycleDiyEditOverviewOpenParam.OnEditPresetChanged = new Action<EOutlookType, bool>(this.OnOverviewEditPresetChanged);
		MotorcycleDiyEditOverviewOpenParam param = motorcycleDiyEditOverviewOpenParam;
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyEditOverviewView, param, null);
	}

	// Token: 0x06011545 RID: 70981 RVA: 0x0043B832 File Offset: 0x00439A32
	private void OnOverviewEditPresetChanged(EOutlookType outlookType, bool isModified)
	{
		this.RefreshStickerPreviewRedDots();
		Action<EOutlookType, bool> onEditPresetChanged = this.OnEditPresetChanged;
		if (onEditPresetChanged == null)
		{
			return;
		}
		onEditPresetChanged(outlookType, isModified);
	}

	// Token: 0x040083B7 RID: 33719
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyEditPartTabItem> PartTabComponent;

	// Token: 0x040083B8 RID: 33720
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x040083B9 RID: 33721
	[Nullable(1)]
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040083BA RID: 33722
	[Nullable(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> CachedStickerDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x040083BB RID: 33723
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083BC RID: 33724
	private int CurrentSelectStickerPart;

	// Token: 0x040083BD RID: 33725
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x020087E3 RID: 34787
	[NullableContext(0)]
	private class EMotorStickerTabViewComponent
	{
		// Token: 0x0402C281 RID: 180865
		public const int TabContent = 0;

		// Token: 0x0402C282 RID: 180866
		public const int TabItem = 1;

		// Token: 0x0402C283 RID: 180867
		public const int LoopScrollView = 2;

		// Token: 0x0402C284 RID: 180868
		public const int SVContent = 3;

		// Token: 0x0402C285 RID: 180869
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x0402C286 RID: 180870
		public const int RightLayout = 5;

		// Token: 0x0402C287 RID: 180871
		public const int TxtStickerName = 6;

		// Token: 0x0402C288 RID: 180872
		public const int LockItem = 7;

		// Token: 0x0402C289 RID: 180873
		public const int TxtCurEquip = 8;

		// Token: 0x0402C28A RID: 180874
		public const int BtnJump = 9;

		// Token: 0x0402C28B RID: 180875
		public const int TipsItem = 10;

		// Token: 0x0402C28C RID: 180876
		public const int TxtTipsName = 11;

		// Token: 0x0402C28D RID: 180877
		public const int TitleGetItem = 12;

		// Token: 0x0402C28E RID: 180878
		public const int TxtJump = 13;

		// Token: 0x0402C28F RID: 180879
		public const int BtnOverview = 14;

		// Token: 0x0402C290 RID: 180880
		public const int MenuItem = 15;

		// Token: 0x0402C291 RID: 180881
		public const int SmallTitleItem = 16;

		// Token: 0x0402C292 RID: 180882
		public const int NormalPanel = 17;

		// Token: 0x0402C293 RID: 180883
		public const int EditPresetPanel = 18;
	}
}
