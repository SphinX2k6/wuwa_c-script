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

// Token: 0x0200229F RID: 8863
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditFrameTabView : UiTabViewBase, IMotorcycleDiyEditTabViewRegister, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001617 RID: 5655
	// (get) Token: 0x06011515 RID: 70933 RVA: 0x0043A650 File Offset: 0x00438850
	// (set) Token: 0x06011516 RID: 70934 RVA: 0x0043A658 File Offset: 0x00438858
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001618 RID: 5656
	// (get) Token: 0x06011517 RID: 70935 RVA: 0x0043A661 File Offset: 0x00438861
	// (set) Token: 0x06011518 RID: 70936 RVA: 0x0043A669 File Offset: 0x00438869
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x17001619 RID: 5657
	// (get) Token: 0x06011519 RID: 70937 RVA: 0x0043A672 File Offset: 0x00438872
	// (set) Token: 0x0601151A RID: 70938 RVA: 0x0043A67A File Offset: 0x0043887A
	public Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x1700161A RID: 5658
	// (get) Token: 0x0601151B RID: 70939 RVA: 0x0043A683 File Offset: 0x00438883
	// (set) Token: 0x0601151C RID: 70940 RVA: 0x0043A68B File Offset: 0x0043888B
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }

	// Token: 0x0601151D RID: 70941 RVA: 0x0043A694 File Offset: 0x00438894
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

	// Token: 0x0601151E RID: 70942 RVA: 0x0043A870 File Offset: 0x00438A70
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyEditFrameTabView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyEditFrameTabView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601151F RID: 70943 RVA: 0x0043A8B4 File Offset: 0x00438AB4
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

	// Token: 0x06011520 RID: 70944 RVA: 0x0043A92A File Offset: 0x00438B2A
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

	// Token: 0x06011521 RID: 70945 RVA: 0x0043A944 File Offset: 0x00438B44
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x06011522 RID: 70946 RVA: 0x0043A962 File Offset: 0x00438B62
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x06011523 RID: 70947 RVA: 0x0043A980 File Offset: 0x00438B80
	[NullableContext(1)]
	private MotorcycleDiyEditFrameItem CreateFrameItem()
	{
		return new MotorcycleDiyEditFrameItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickFrame)
		};
	}

	// Token: 0x06011524 RID: 70948 RVA: 0x0043A999 File Offset: 0x00438B99
	public void RefreshItemScrollView()
	{
		if (this.FrameScrollView != null)
		{
			this.RefreshScrollViewByData(true);
		}
	}

	// Token: 0x06011525 RID: 70949 RVA: 0x0043A9AC File Offset: 0x00438BAC
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

	// Token: 0x06011526 RID: 70950 RVA: 0x0043AA94 File Offset: 0x00438C94
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

	// Token: 0x06011527 RID: 70951 RVA: 0x0043AB10 File Offset: 0x00438D10
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

	// Token: 0x06011528 RID: 70952 RVA: 0x0043AB90 File Offset: 0x00438D90
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

	// Token: 0x06011529 RID: 70953 RVA: 0x0043AC0E File Offset: 0x00438E0E
	private void OnFrameInfoUpdate()
	{
		this.RefreshScrollViewByData(false);
	}

	// Token: 0x0601152A RID: 70954 RVA: 0x0043AC18 File Offset: 0x00438E18
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

	// Token: 0x040083AF RID: 33711
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyEditFrameItem, MotorcycleDiyEditFrameItemData> FrameScrollView;

	// Token: 0x040083B0 RID: 33712
	[Nullable(1)]
	private List<MotorcycleDiyEditFrameItemData> CachedFrameDataList = new List<MotorcycleDiyEditFrameItemData>();

	// Token: 0x040083B1 RID: 33713
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083B2 RID: 33714
	private MotorcycleDiyEditPresetPanel EditPresetPanel;

	// Token: 0x020087DF RID: 34783
	[NullableContext(0)]
	private class EMotorFrameTabViewComponent
	{
		// Token: 0x0402C26C RID: 180844
		public const int LoopScrollView = 0;

		// Token: 0x0402C26D RID: 180845
		public const int SVContent = 1;

		// Token: 0x0402C26E RID: 180846
		public const int TogMotorDiyFrameItem = 2;

		// Token: 0x0402C26F RID: 180847
		public const int BtnOverview = 3;

		// Token: 0x0402C270 RID: 180848
		public const int TxtTitle = 4;

		// Token: 0x0402C271 RID: 180849
		public const int LockItem = 5;

		// Token: 0x0402C272 RID: 180850
		public const int TxtSubTitle = 6;

		// Token: 0x0402C273 RID: 180851
		public const int TitleGetItem = 7;

		// Token: 0x0402C274 RID: 180852
		public const int BtnJump = 8;

		// Token: 0x0402C275 RID: 180853
		public const int TipsItem = 9;

		// Token: 0x0402C276 RID: 180854
		public const int TxtTipsName = 10;

		// Token: 0x0402C277 RID: 180855
		public const int TxtJump = 11;

		// Token: 0x0402C278 RID: 180856
		public const int NormalPanel = 12;

		// Token: 0x0402C279 RID: 180857
		public const int EditPresetPanel = 13;
	}
}
