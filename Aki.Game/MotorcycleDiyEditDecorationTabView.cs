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

// Token: 0x0200229E RID: 8862
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditDecorationTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001613 RID: 5651
	// (get) Token: 0x060114FC RID: 70908 RVA: 0x00439C92 File Offset: 0x00437E92
	// (set) Token: 0x060114FD RID: 70909 RVA: 0x00439C9A File Offset: 0x00437E9A
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001614 RID: 5652
	// (get) Token: 0x060114FE RID: 70910 RVA: 0x00439CA3 File Offset: 0x00437EA3
	// (set) Token: 0x060114FF RID: 70911 RVA: 0x00439CAB File Offset: 0x00437EAB
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x17001615 RID: 5653
	// (get) Token: 0x06011500 RID: 70912 RVA: 0x00439CB4 File Offset: 0x00437EB4
	// (set) Token: 0x06011501 RID: 70913 RVA: 0x00439CBC File Offset: 0x00437EBC
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x17001616 RID: 5654
	// (get) Token: 0x06011502 RID: 70914 RVA: 0x00439CC5 File Offset: 0x00437EC5
	// (set) Token: 0x06011503 RID: 70915 RVA: 0x00439CCD File Offset: 0x00437ECD
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x06011504 RID: 70916 RVA: 0x00439CD8 File Offset: 0x00437ED8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
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
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011505 RID: 70917 RVA: 0x00439F5C File Offset: 0x0043815C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditDecorationTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditDecorationTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011506 RID: 70918 RVA: 0x00439FA0 File Offset: 0x004381A0
	protected override void OnBeforeShow()
	{
		this.CurrentSelectDecorationPart = (this.ExtraParams as int?).GetValueOrDefault();
		int index = (this.CurrentSelectDecorationPart > 0) ? (this.CurrentSelectDecorationPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x06011507 RID: 70919 RVA: 0x00439FEE File Offset: 0x004381EE
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x06011508 RID: 70920 RVA: 0x0043A00C File Offset: 0x0043820C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x06011509 RID: 70921 RVA: 0x0043A02A File Offset: 0x0043822A
	[NullableContext(1)]
	private MotorcycleDiyEditPartTabItem InitDecorationTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyEditPartTabItem();
	}

	// Token: 0x0601150A RID: 70922 RVA: 0x0043A034 File Offset: 0x00438234
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectDecorationPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
		Action<int> onTabCameraClick = this.OnTabCameraClick;
		if (onTabCameraClick == null)
		{
			return;
		}
		onTabCameraClick(this.CurrentSelectDecorationPart);
	}

	// Token: 0x0601150B RID: 70923 RVA: 0x0043A07D File Offset: 0x0043827D
	[NullableContext(1)]
	private MotorcycleDiyEditStickerDecoItem CreateDecorationItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickDecoration)
		};
	}

	// Token: 0x0601150C RID: 70924 RVA: 0x0043A096 File Offset: 0x00438296
	public void RefreshItemScrollView()
	{
		if (this.DecorationScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, true);
		}
	}

	// Token: 0x0601150D RID: 70925 RVA: 0x0043A0B0 File Offset: 0x004382B0
	private void RefreshDecorationPreviewRedDots()
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
				int num = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART, partId);
				int num2 = (num >= 0 && num < motorcycleDiyPresetData.DecorateIds.Length) ? motorcycleDiyPresetData.DecorateIds[num] : 0;
				bool flag = instance.GetSelectedDecorationId(partId) != num2;
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
		onEditPresetChanged(EOutlookType.Decoration, arg);
	}

	// Token: 0x0601150E RID: 70926 RVA: 0x0043A1B8 File Offset: 0x004383B8
	[NullableContext(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> GetDecorationItemDataList(int partId)
	{
		List<MotorcycleDiyEditStickerDecoItemData> list = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorcycleDiyEditStickerDecoItemData item = new MotorcycleDiyEditStickerDecoItemData
		{
			Part = partId,
			ItemId = 0,
			IsSticker = false
		};
		list.Add(item);
		foreach (int num in MotorcycleDiyModel.Instance.GetCanUseDecorationsIdsInRegion())
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
			if (motorDecorationConfig != null && motorDecorationConfig.Value.PartId == partId)
			{
				int decorationState = (int)MotorcycleDiyModel.Instance.GetDecorationState(num);
				bool flag = MotorcycleDiyModel.Instance.HasDecoration(num);
				if (decorationState != 0 && flag)
				{
					list.Add(new MotorcycleDiyEditStickerDecoItemData
					{
						Part = partId,
						ItemId = num,
						QualityId = motorDecorationConfig.Value.QualityId,
						SortIndex = motorDecorationConfig.Value.SortIndex,
						IsSticker = false
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0601150F RID: 70927 RVA: 0x0043A2CC File Offset: 0x004384CC
	[NullableContext(1)]
	private int SortDecorationItemFunc(MotorcycleDiyEditStickerDecoItemData dataA, MotorcycleDiyEditStickerDecoItemData dataB)
	{
		EOutLookState decorationState = MotorcycleDiyModel.Instance.GetDecorationState(dataA.ItemId);
		EOutLookState decorationState2 = MotorcycleDiyModel.Instance.GetDecorationState(dataB.ItemId);
		if (decorationState != decorationState2)
		{
			return decorationState - decorationState2;
		}
		if (dataA.QualityId != dataB.QualityId)
		{
			return dataB.QualityId - dataA.QualityId;
		}
		return dataB.SortIndex - dataA.SortIndex;
	}

	// Token: 0x06011510 RID: 70928 RVA: 0x0043A32C File Offset: 0x0043852C
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			List<MotorcycleDiyEditStickerDecoItemData> decorationDataList = this.GetDecorationItemDataList(partId);
			decorationDataList.Sort(new Comparison<MotorcycleDiyEditStickerDecoItemData>(this.SortDecorationItemFunc));
			this.CachedDecorationDataList = decorationDataList;
			this.DecorationScrollView.RefreshByData(decorationDataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, decorationDataList);
			}, false);
			return;
		}
		this.DecorationScrollView.RefreshByData(this.CachedDecorationDataList, true, null, false);
	}

	// Token: 0x06011511 RID: 70929 RVA: 0x0043A3BC File Offset: 0x004385BC
	[NullableContext(1)]
	private void AutoSelectGridByDataList(int decorationPart, List<MotorcycleDiyEditStickerDecoItemData> decorationDataList)
	{
		int gridIndex = 0;
		int selectDecorationId = 0;
		int selectedDecorationId = MotorcycleDiyModel.Instance.GetSelectedDecorationId(decorationPart);
		if (selectedDecorationId != 0)
		{
			selectDecorationId = selectedDecorationId;
		}
		MotorcycleDiyEditStickerDecoItemData motorcycleDiyEditStickerDecoItemData = decorationDataList.Find((MotorcycleDiyEditStickerDecoItemData data) => data.ItemId == selectDecorationId);
		if (motorcycleDiyEditStickerDecoItemData != null)
		{
			gridIndex = decorationDataList.IndexOf(motorcycleDiyEditStickerDecoItemData);
		}
		if (!this.DecorationScrollView.IsGridDisplaying(gridIndex))
		{
			this.DecorationScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.DecorationScrollView.DeselectCurrentGridProxy(false);
		this.DecorationScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06011512 RID: 70930 RVA: 0x0043A440 File Offset: 0x00438640
	private void OnDecorationInfoUpdate()
	{
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
	}

	// Token: 0x06011513 RID: 70931 RVA: 0x0043A450 File Offset: 0x00438650
	[NullableContext(1)]
	private void OnClickDecoration(int decorationId, UUIExtendToggle toggle, UUIItem newItem)
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		if (instance.GetDecorationState(decorationId) == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = instance.GetBanTips(EOutlookType.Decoration, decorationId);
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
		if (decorationId == 0)
		{
			MotorcycleUiModelUtil.Instance.SetEmptyDecoration(this.CurrentSelectDecorationPart);
		}
		else
		{
			MotorcycleUiModelUtil.Instance.AddDecoration(decorationId, null);
		}
		instance.SetSelectDecorationInfo(this.CurrentSelectDecorationPart, decorationId);
		this.RefreshDecorationPreviewRedDots();
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Decoration, this.CurrentSelectDecorationPart, decorationId);
		}
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
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
		if (decorationId <= 0)
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorEmptyDecorationName");
			text2.SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(text, stringConfig, Array.Empty<object>());
			return;
		}
		text2.SetUIActive(true);
		MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(decorationId);
		if (motorDecorationConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text2, motorDecorationConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text, motorDecorationConfig.Value.Title, Array.Empty<object>());
	}

	// Token: 0x040083A4 RID: 33700
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyEditPartTabItem> PartTabComponent;

	// Token: 0x040083A5 RID: 33701
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> DecorationScrollView;

	// Token: 0x040083A6 RID: 33702
	[Nullable(1)]
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040083A7 RID: 33703
	[Nullable(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> CachedDecorationDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x040083A8 RID: 33704
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083A9 RID: 33705
	private int CurrentSelectDecorationPart;

	// Token: 0x040083AA RID: 33706
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x020087DB RID: 34779
	[NullableContext(0)]
	private class EMotorDecorationTabViewComponent
	{
		// Token: 0x0402C251 RID: 180817
		public const int TabContent = 0;

		// Token: 0x0402C252 RID: 180818
		public const int TabItem = 1;

		// Token: 0x0402C253 RID: 180819
		public const int LoopScrollView = 2;

		// Token: 0x0402C254 RID: 180820
		public const int SVContent = 3;

		// Token: 0x0402C255 RID: 180821
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x0402C256 RID: 180822
		public const int RightLayout = 5;

		// Token: 0x0402C257 RID: 180823
		public const int TxtDecorationName = 6;

		// Token: 0x0402C258 RID: 180824
		public const int LockItem = 7;

		// Token: 0x0402C259 RID: 180825
		public const int TxtCurEquip = 8;

		// Token: 0x0402C25A RID: 180826
		public const int BtnJump = 9;

		// Token: 0x0402C25B RID: 180827
		public const int TipsItem = 10;

		// Token: 0x0402C25C RID: 180828
		public const int TxtTipsName = 11;

		// Token: 0x0402C25D RID: 180829
		public const int TitleGetItem = 12;

		// Token: 0x0402C25E RID: 180830
		public const int TxtJump = 13;

		// Token: 0x0402C25F RID: 180831
		public const int BtnOverview = 14;

		// Token: 0x0402C260 RID: 180832
		public const int MenuItem = 15;

		// Token: 0x0402C261 RID: 180833
		public const int SmallTitleItem = 16;

		// Token: 0x0402C262 RID: 180834
		public const int NormalPanel = 17;

		// Token: 0x0402C263 RID: 180835
		public const int EditPresetPanel = 18;
	}
}
