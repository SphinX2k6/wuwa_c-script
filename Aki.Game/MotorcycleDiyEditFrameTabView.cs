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

// Token: 0x02001783 RID: 6019
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditFrameTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700164E RID: 5710
	// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x00447248 File Offset: 0x00445448
	// (set) Token: 0x0600E9AE RID: 59822 RVA: 0x00447250 File Offset: 0x00445450
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x1700164F RID: 5711
	// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x00447259 File Offset: 0x00445459
	// (set) Token: 0x0600E9B0 RID: 59824 RVA: 0x00447261 File Offset: 0x00445461
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x17001650 RID: 5712
	// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x0044726A File Offset: 0x0044546A
	// (set) Token: 0x0600E9B2 RID: 59826 RVA: 0x00447272 File Offset: 0x00445472
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x17001651 RID: 5713
	// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x0044727B File Offset: 0x0044547B
	// (set) Token: 0x0600E9B4 RID: 59828 RVA: 0x00447283 File Offset: 0x00445483
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x0600E9B5 RID: 59829 RVA: 0x0044728C File Offset: 0x0044548C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E9B6 RID: 59830 RVA: 0x00447468 File Offset: 0x00445668
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditFrameTabView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditFrameTabView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E9B7 RID: 59831 RVA: 0x004474AC File Offset: 0x004456AC
	protected override void OnStart()
	{
		this.FrameScrollView = new LoopScrollView<MotorcycleDiyEditFrameItem, MotorcycleDiyEditFrameItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<MotorcycleDiyEditFrameItem>(this.CreateFrameItem), true);
		base.GetButton(3).RootUIComp.Get().SetUIActive(false);
		base.GetItem(12).SetUIActive(true);
		MotorcycleDiyEditPresetPanel editPresetPanel = this.EditPresetPanel;
		if (editPresetPanel == null)
		{
			return;
		}
		editPresetPanel.SetUiActive(false);
	}

	// Token: 0x0600E9B8 RID: 59832 RVA: 0x00447522 File Offset: 0x00445722
	protected override void OnBeforeShow()
	{
		this.RefreshScrollViewByData(true);
		Action<int> onTabCameraClick = this.OnTabCameraClick;
		if (onTabCameraClick == null)
		{
			return;
		}
		onTabCameraClick(0);
	}

	// Token: 0x0600E9B9 RID: 59833 RVA: 0x0044753C File Offset: 0x0044573C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x0600E9BA RID: 59834 RVA: 0x0044755A File Offset: 0x0044575A
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x0600E9BB RID: 59835 RVA: 0x00447578 File Offset: 0x00445778
	[NullableContext(1)]
	private MotorcycleDiyEditFrameItem CreateFrameItem()
	{
		return new MotorcycleDiyEditFrameItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickFrame)
		};
	}

	// Token: 0x0600E9BC RID: 59836 RVA: 0x00447591 File Offset: 0x00445791
	public void RefreshItemScrollView()
	{
		if (this.FrameScrollView != null)
		{
			this.RefreshScrollViewByData(true);
		}
	}

	// Token: 0x0600E9BD RID: 59837 RVA: 0x004475A4 File Offset: 0x004457A4
	[NullableContext(1)]
	private List<MotorcycleDiyEditFrameItemData> GetFrameItemDataList()
	{
		List<MotorcycleDiyEditFrameItemData> list = new List<MotorcycleDiyEditFrameItemData>();
		foreach (int num in MotorcycleDiyModel.Instance.GetCanUseFrameIdsInRegion())
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(num);
			if (motorFrameConfig != null)
			{
				int frameState = (int)MotorcycleDiyModel.Instance.GetFrameState(num);
				bool flag = MotorcycleDiyModel.Instance.HasFrame(num);
				if (frameState != 0 && flag)
				{
					MotorcycleDiyEditFrameItemData item = new MotorcycleDiyEditFrameItemData
					{
						ItemId = num,
						QualityId = motorFrameConfig.Value.QualityId,
						SortIndex = motorFrameConfig.Value.SortIndex,
						IsDefault = (num == MotorcycleDiyModel.Instance.GetDefaultFrameId())
					};
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x0600E9BE RID: 59838 RVA: 0x0044768C File Offset: 0x0044588C
	[NullableContext(1)]
	private int SortFrameItemFunc(MotorcycleDiyEditFrameItemData dataA, MotorcycleDiyEditFrameItemData dataB)
	{
		int num = (!dataA.IsDefault) ? 1 : 0;
		int num2 = (!dataB.IsDefault) ? 1 : 0;
		if (num != num2)
		{
			return num - num2;
		}
		EOutLookState frameState = MotorcycleDiyModel.Instance.GetFrameState(dataA.ItemId);
		EOutLookState frameState2 = MotorcycleDiyModel.Instance.GetFrameState(dataB.ItemId);
		if (frameState != frameState2)
		{
			return frameState - frameState2;
		}
		int qualityId = dataA.QualityId;
		int qualityId2 = dataB.QualityId;
		if (qualityId != qualityId2)
		{
			return qualityId2 - qualityId;
		}
		return dataB.SortIndex - dataA.SortIndex;
	}

	// Token: 0x0600E9BF RID: 59839 RVA: 0x00447708 File Offset: 0x00445908
	private void RefreshScrollViewByData(bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			List<MotorcycleDiyEditFrameItemData> frameDataList = this.GetFrameItemDataList();
			frameDataList.Sort(new Comparison<MotorcycleDiyEditFrameItemData>(this.SortFrameItemFunc));
			this.FrameScrollView.RefreshByData(frameDataList, true, delegate
			{
				this.AutoSelectGridByDataList(frameDataList);
			}, false);
			this.CachedFrameDataList = frameDataList;
			return;
		}
		this.FrameScrollView.RefreshByData(this.CachedFrameDataList, true, null, false);
	}

	// Token: 0x0600E9C0 RID: 59840 RVA: 0x00447788 File Offset: 0x00445988
	[NullableContext(1)]
	private void AutoSelectGridByDataList(List<MotorcycleDiyEditFrameItemData> frameDataList)
	{
		int gridIndex = 0;
		int selectFrameId = 0;
		int selectedFrameId = MotorcycleDiyModel.Instance.GetSelectedFrameId();
		if (selectedFrameId != 0)
		{
			selectFrameId = selectedFrameId;
		}
		int num = frameDataList.FindIndex((MotorcycleDiyEditFrameItemData frameData) => frameData.ItemId == selectFrameId);
		if (num >= 0)
		{
			gridIndex = num;
		}
		if (!this.FrameScrollView.IsGridDisplaying(gridIndex))
		{
			this.FrameScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.FrameScrollView.DeselectCurrentGridProxy(false);
		this.FrameScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x0600E9C1 RID: 59841 RVA: 0x00447806 File Offset: 0x00445A06
	private void OnFrameInfoUpdate()
	{
		this.RefreshScrollViewByData(false);
	}

	// Token: 0x0600E9C2 RID: 59842 RVA: 0x00447810 File Offset: 0x00445A10
	[NullableContext(1)]
	private void OnClickFrame(int frameId, UUIExtendToggle toggle, UUIItem newItem)
	{
		MotorcycleDiyModel instance = MotorcycleDiyModel.Instance;
		if (instance.GetFrameState(frameId) == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = instance.GetBanTips(EOutlookType.Frame, frameId);
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
		List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
		List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(false);
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = frameId,
			StickerIds = selectedStickerIdList.ToArray(),
			DecorationIds = selectedDecorationIdList.ToArray()
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
		instance.SetSelectFrame(frameId);
		Func<MotorcycleDiyPresetData> getLocalPresetData = this.GetLocalPresetData;
		MotorcycleDiyPresetData motorcycleDiyPresetData = (getLocalPresetData != null) ? getLocalPresetData() : null;
		Action<EOutlookType, bool> onEditPresetChanged = this.OnEditPresetChanged;
		if (onEditPresetChanged != null)
		{
			onEditPresetChanged(EOutlookType.Frame, motorcycleDiyPresetData != null && frameId != motorcycleDiyPresetData.FrameId);
		}
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Frame, 0, frameId);
		}
		this.RefreshScrollViewByData(false);
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(9);
		UUIItem item3 = base.GetItem(7);
		ULGUIBehaviour button = base.GetButton(8);
		UUIText text = base.GetText(4);
		UUIText text2 = base.GetText(6);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(false);
		MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(frameId);
		if (motorFrameConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text2, motorFrameConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text, motorFrameConfig.Value.Title, Array.Empty<object>());
	}

	// Token: 0x040084ED RID: 34029
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditFrameItem, MotorcycleDiyEditFrameItemData> FrameScrollView;

	// Token: 0x040084EE RID: 34030
	[Nullable(1)]
	private List<MotorcycleDiyEditFrameItemData> CachedFrameDataList = new List<MotorcycleDiyEditFrameItemData>();

	// Token: 0x040084EF RID: 34031
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040084F0 RID: 34032
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x02007968 RID: 31080
	[NullableContext(0)]
	private class EMotorFrameTabViewComponent
	{
		// Token: 0x04027578 RID: 161144
		public const int LoopScrollView = 0;

		// Token: 0x04027579 RID: 161145
		public const int SVContent = 1;

		// Token: 0x0402757A RID: 161146
		public const int TogMotorDiyFrameItem = 2;

		// Token: 0x0402757B RID: 161147
		public const int BtnOverview = 3;

		// Token: 0x0402757C RID: 161148
		public const int TxtTitle = 4;

		// Token: 0x0402757D RID: 161149
		public const int LockItem = 5;

		// Token: 0x0402757E RID: 161150
		public const int TxtSubTitle = 6;

		// Token: 0x0402757F RID: 161151
		public const int TitleGetItem = 7;

		// Token: 0x04027580 RID: 161152
		public const int BtnJump = 8;

		// Token: 0x04027581 RID: 161153
		public const int TipsItem = 9;

		// Token: 0x04027582 RID: 161154
		public const int TxtTipsName = 10;

		// Token: 0x04027583 RID: 161155
		public const int TxtJump = 11;

		// Token: 0x04027584 RID: 161156
		public const int NormalPanel = 12;

		// Token: 0x04027585 RID: 161157
		public const int EditPresetPanel = 13;
	}
}
