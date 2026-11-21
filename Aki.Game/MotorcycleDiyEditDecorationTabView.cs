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

// Token: 0x02001782 RID: 6018
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditDecorationTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700164A RID: 5706
	// (get) Token: 0x0600E994 RID: 59796 RVA: 0x0044688A File Offset: 0x00444A8A
	// (set) Token: 0x0600E995 RID: 59797 RVA: 0x00446892 File Offset: 0x00444A92
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x1700164B RID: 5707
	// (get) Token: 0x0600E996 RID: 59798 RVA: 0x0044689B File Offset: 0x00444A9B
	// (set) Token: 0x0600E997 RID: 59799 RVA: 0x004468A3 File Offset: 0x00444AA3
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x1700164C RID: 5708
	// (get) Token: 0x0600E998 RID: 59800 RVA: 0x004468AC File Offset: 0x00444AAC
	// (set) Token: 0x0600E999 RID: 59801 RVA: 0x004468B4 File Offset: 0x00444AB4
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x1700164D RID: 5709
	// (get) Token: 0x0600E99A RID: 59802 RVA: 0x004468BD File Offset: 0x00444ABD
	// (set) Token: 0x0600E99B RID: 59803 RVA: 0x004468C5 File Offset: 0x00444AC5
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x0600E99C RID: 59804 RVA: 0x004468D0 File Offset: 0x00444AD0
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

	// Token: 0x0600E99D RID: 59805 RVA: 0x00446B54 File Offset: 0x00444D54
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditDecorationTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditDecorationTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E99E RID: 59806 RVA: 0x00446B98 File Offset: 0x00444D98
	protected override void OnBeforeShow()
	{
		this.CurrentSelectDecorationPart = (this.ExtraParams as int?).GetValueOrDefault();
		int index = (this.CurrentSelectDecorationPart > 0) ? (this.CurrentSelectDecorationPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0600E99F RID: 59807 RVA: 0x00446BE6 File Offset: 0x00444DE6
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x0600E9A0 RID: 59808 RVA: 0x00446C04 File Offset: 0x00444E04
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x0600E9A1 RID: 59809 RVA: 0x00446C22 File Offset: 0x00444E22
	[NullableContext(1)]
	private MotorcycleDiyEditPartTabItem InitDecorationTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyEditPartTabItem();
	}

	// Token: 0x0600E9A2 RID: 59810 RVA: 0x00446C2C File Offset: 0x00444E2C
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

	// Token: 0x0600E9A3 RID: 59811 RVA: 0x00446C75 File Offset: 0x00444E75
	[NullableContext(1)]
	private MotorcycleDiyEditStickerDecoItem CreateDecorationItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickDecoration)
		};
	}

	// Token: 0x0600E9A4 RID: 59812 RVA: 0x00446C8E File Offset: 0x00444E8E
	public void RefreshItemScrollView()
	{
		if (this.DecorationScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, true);
		}
	}

	// Token: 0x0600E9A5 RID: 59813 RVA: 0x00446CA8 File Offset: 0x00444EA8
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

	// Token: 0x0600E9A6 RID: 59814 RVA: 0x00446DB0 File Offset: 0x00444FB0
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

	// Token: 0x0600E9A7 RID: 59815 RVA: 0x00446EC4 File Offset: 0x004450C4
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

	// Token: 0x0600E9A8 RID: 59816 RVA: 0x00446F24 File Offset: 0x00445124
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

	// Token: 0x0600E9A9 RID: 59817 RVA: 0x00446FB4 File Offset: 0x004451B4
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

	// Token: 0x0600E9AA RID: 59818 RVA: 0x00447038 File Offset: 0x00445238
	private void OnDecorationInfoUpdate()
	{
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
	}

	// Token: 0x0600E9AB RID: 59819 RVA: 0x00447048 File Offset: 0x00445248
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

	// Token: 0x040084E2 RID: 34018
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyEditPartTabItem> PartTabComponent;

	// Token: 0x040084E3 RID: 34019
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> DecorationScrollView;

	// Token: 0x040084E4 RID: 34020
	[Nullable(1)]
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040084E5 RID: 34021
	[Nullable(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> CachedDecorationDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x040084E6 RID: 34022
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040084E7 RID: 34023
	private int CurrentSelectDecorationPart;

	// Token: 0x040084E8 RID: 34024
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x02007964 RID: 31076
	[NullableContext(0)]
	private class EMotorDecorationTabViewComponent
	{
		// Token: 0x0402755D RID: 161117
		public const int TabContent = 0;

		// Token: 0x0402755E RID: 161118
		public const int TabItem = 1;

		// Token: 0x0402755F RID: 161119
		public const int LoopScrollView = 2;

		// Token: 0x04027560 RID: 161120
		public const int SVContent = 3;

		// Token: 0x04027561 RID: 161121
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x04027562 RID: 161122
		public const int RightLayout = 5;

		// Token: 0x04027563 RID: 161123
		public const int TxtDecorationName = 6;

		// Token: 0x04027564 RID: 161124
		public const int LockItem = 7;

		// Token: 0x04027565 RID: 161125
		public const int TxtCurEquip = 8;

		// Token: 0x04027566 RID: 161126
		public const int BtnJump = 9;

		// Token: 0x04027567 RID: 161127
		public const int TipsItem = 10;

		// Token: 0x04027568 RID: 161128
		public const int TxtTipsName = 11;

		// Token: 0x04027569 RID: 161129
		public const int TitleGetItem = 12;

		// Token: 0x0402756A RID: 161130
		public const int TxtJump = 13;

		// Token: 0x0402756B RID: 161131
		public const int BtnOverview = 14;

		// Token: 0x0402756C RID: 161132
		public const int MenuItem = 15;

		// Token: 0x0402756D RID: 161133
		public const int SmallTitleItem = 16;

		// Token: 0x0402756E RID: 161134
		public const int NormalPanel = 17;

		// Token: 0x0402756F RID: 161135
		public const int EditPresetPanel = 18;
	}
}
