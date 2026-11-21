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

// Token: 0x02001784 RID: 6020
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditStickerTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001652 RID: 5714
	// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x00447A20 File Offset: 0x00445C20
	// (set) Token: 0x0600E9C5 RID: 59845 RVA: 0x00447A28 File Offset: 0x00445C28
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001653 RID: 5715
	// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x00447A31 File Offset: 0x00445C31
	// (set) Token: 0x0600E9C7 RID: 59847 RVA: 0x00447A39 File Offset: 0x00445C39
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x17001654 RID: 5716
	// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00447A42 File Offset: 0x00445C42
	// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x00447A4A File Offset: 0x00445C4A
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x17001655 RID: 5717
	// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x00447A53 File Offset: 0x00445C53
	// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x00447A5B File Offset: 0x00445C5B
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x0600E9CC RID: 59852 RVA: 0x00447A64 File Offset: 0x00445C64
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

	// Token: 0x0600E9CD RID: 59853 RVA: 0x00447CE4 File Offset: 0x00445EE4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditStickerTabView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditStickerTabView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E9CE RID: 59854 RVA: 0x00447D28 File Offset: 0x00445F28
	protected override void OnBeforeShow()
	{
		this.CurrentSelectStickerPart = (this.ExtraParams as int?).GetValueOrDefault();
		int index = (this.CurrentSelectStickerPart > 0) ? (this.CurrentSelectStickerPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0600E9CF RID: 59855 RVA: 0x00447D76 File Offset: 0x00445F76
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x0600E9D0 RID: 59856 RVA: 0x00447D94 File Offset: 0x00445F94
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x0600E9D1 RID: 59857 RVA: 0x00447DB2 File Offset: 0x00445FB2
	[NullableContext(1)]
	private MotorcycleDiyEditPartTabItem InitStickerTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyEditPartTabItem();
	}

	// Token: 0x0600E9D2 RID: 59858 RVA: 0x00447DBC File Offset: 0x00445FBC
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

	// Token: 0x0600E9D3 RID: 59859 RVA: 0x00447E05 File Offset: 0x00446005
	[NullableContext(1)]
	private MotorcycleDiyEditStickerDecoItem CreateStickerItem()
	{
		return new MotorcycleDiyEditStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickSticker)
		};
	}

	// Token: 0x0600E9D4 RID: 59860 RVA: 0x00447E1E File Offset: 0x0044601E
	public void RefreshItemScrollView()
	{
		if (this.StickerScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectStickerPart, true);
		}
	}

	// Token: 0x0600E9D5 RID: 59861 RVA: 0x00447E38 File Offset: 0x00446038
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

	// Token: 0x0600E9D6 RID: 59862 RVA: 0x00447F40 File Offset: 0x00446140
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

	// Token: 0x0600E9D7 RID: 59863 RVA: 0x00448054 File Offset: 0x00446254
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

	// Token: 0x0600E9D8 RID: 59864 RVA: 0x004480B4 File Offset: 0x004462B4
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

	// Token: 0x0600E9D9 RID: 59865 RVA: 0x00448144 File Offset: 0x00446344
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

	// Token: 0x0600E9DA RID: 59866 RVA: 0x004481C8 File Offset: 0x004463C8
	private void OnStickerInfoUpdate()
	{
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
	}

	// Token: 0x0600E9DB RID: 59867 RVA: 0x004481D8 File Offset: 0x004463D8
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

	// Token: 0x0600E9DC RID: 59868 RVA: 0x004483D0 File Offset: 0x004465D0
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

	// Token: 0x0600E9DD RID: 59869 RVA: 0x0044842A File Offset: 0x0044662A
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

	// Token: 0x040084F5 RID: 34037
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyEditPartTabItem> PartTabComponent;

	// Token: 0x040084F6 RID: 34038
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditStickerDecoItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x040084F7 RID: 34039
	[Nullable(1)]
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040084F8 RID: 34040
	[Nullable(1)]
	private List<MotorcycleDiyEditStickerDecoItemData> CachedStickerDataList = new List<MotorcycleDiyEditStickerDecoItemData>();

	// Token: 0x040084F9 RID: 34041
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040084FA RID: 34042
	private int CurrentSelectStickerPart;

	// Token: 0x040084FB RID: 34043
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x0200796C RID: 31084
	[NullableContext(0)]
	private class EMotorStickerTabViewComponent
	{
		// Token: 0x0402758D RID: 161165
		public const int TabContent = 0;

		// Token: 0x0402758E RID: 161166
		public const int TabItem = 1;

		// Token: 0x0402758F RID: 161167
		public const int LoopScrollView = 2;

		// Token: 0x04027590 RID: 161168
		public const int SVContent = 3;

		// Token: 0x04027591 RID: 161169
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x04027592 RID: 161170
		public const int RightLayout = 5;

		// Token: 0x04027593 RID: 161171
		public const int TxtStickerName = 6;

		// Token: 0x04027594 RID: 161172
		public const int LockItem = 7;

		// Token: 0x04027595 RID: 161173
		public const int TxtCurEquip = 8;

		// Token: 0x04027596 RID: 161174
		public const int BtnJump = 9;

		// Token: 0x04027597 RID: 161175
		public const int TipsItem = 10;

		// Token: 0x04027598 RID: 161176
		public const int TxtTipsName = 11;

		// Token: 0x04027599 RID: 161177
		public const int TitleGetItem = 12;

		// Token: 0x0402759A RID: 161178
		public const int TxtJump = 13;

		// Token: 0x0402759B RID: 161179
		public const int BtnOverview = 14;

		// Token: 0x0402759C RID: 161180
		public const int MenuItem = 15;

		// Token: 0x0402759D RID: 161181
		public const int SmallTitleItem = 16;

		// Token: 0x0402759E RID: 161182
		public const int NormalPanel = 17;

		// Token: 0x0402759F RID: 161183
		public const int EditPresetPanel = 18;
	}
}
