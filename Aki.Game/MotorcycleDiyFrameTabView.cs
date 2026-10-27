using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A2 RID: 8866
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyFrameTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001621 RID: 5665
	// (get) Token: 0x0601155D RID: 71005 RVA: 0x0043C2FA File Offset: 0x0043A4FA
	// (set) Token: 0x0601155E RID: 71006 RVA: 0x0043C302 File Offset: 0x0043A502
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001622 RID: 5666
	// (get) Token: 0x0601155F RID: 71007 RVA: 0x0043C30B File Offset: 0x0043A50B
	// (set) Token: 0x06011560 RID: 71008 RVA: 0x0043C313 File Offset: 0x0043A513
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x06011561 RID: 71009 RVA: 0x0043C31C File Offset: 0x0043A51C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnBtnJumpClick))
		};
	}

	// Token: 0x06011562 RID: 71010 RVA: 0x0043C44C File Offset: 0x0043A64C
	protected override void OnStart()
	{
		this.FrameScrollView = new LoopScrollView<MotorcycleDiyFrameItem, MotorcycleDiyFrameItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<MotorcycleDiyFrameItem>(this.CreateFrameItem), true);
		base.GetButton(3).SetActive(false, false);
	}

	// Token: 0x06011563 RID: 71011 RVA: 0x0043C48C File Offset: 0x0043A68C
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

	// Token: 0x06011564 RID: 71012 RVA: 0x0043C4A6 File Offset: 0x0043A6A6
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x06011565 RID: 71013 RVA: 0x0043C4C4 File Offset: 0x0043A6C4
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x06011566 RID: 71014 RVA: 0x0043C4E2 File Offset: 0x0043A6E2
	[NullableContext(1)]
	private MotorcycleDiyFrameItem CreateFrameItem()
	{
		return new MotorcycleDiyFrameItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickFrame)
		};
	}

	// Token: 0x06011567 RID: 71015 RVA: 0x0043C4FB File Offset: 0x0043A6FB
	public void RefreshItemScrollView()
	{
		if (this.FrameScrollView != null)
		{
			this.RefreshScrollViewByData(true);
		}
	}

	// Token: 0x06011568 RID: 71016 RVA: 0x0043C50C File Offset: 0x0043A70C
	private bool IsSkinBindFrameId(int targetFrameId, int defaultFrameId)
	{
		foreach (MotorSkin motorSkin in MotorDiyConfig.Instance.GetAllMotorSkinList())
		{
			if (motorSkin.BindFrame == targetFrameId && targetFrameId != defaultFrameId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06011569 RID: 71017 RVA: 0x0043C56C File Offset: 0x0043A76C
	[NullableContext(1)]
	private List<MotorcycleDiyFrameItemData> GetFrameItemDataList()
	{
		List<MotorcycleDiyFrameItemData> list = new List<MotorcycleDiyFrameItemData>();
		List<int> canUseFrameIdsInRegion = MotorcycleDiyModel.Instance.GetCanUseFrameIdsInRegion();
		int defaultFrameId = MotorcycleDiyModel.Instance.GetDefaultFrameId();
		foreach (int num in canUseFrameIdsInRegion)
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(num);
			if (motorFrameConfig != null && MotorcycleDiyModel.Instance.GetFrameState(num) != EOutLookState.IsHide && !this.IsSkinBindFrameId(num, defaultFrameId))
			{
				list.Add(new MotorcycleDiyFrameItemData
				{
					ItemId = num,
					QualityId = motorFrameConfig.Value.QualityId,
					SortIndex = motorFrameConfig.Value.SortIndex,
					IsDefault = (num == defaultFrameId)
				});
			}
		}
		return list;
	}

	// Token: 0x0601156A RID: 71018 RVA: 0x0043C654 File Offset: 0x0043A854
	[NullableContext(1)]
	private int SortFrameItemFunc(MotorcycleDiyFrameItemData dataA, MotorcycleDiyFrameItemData dataB)
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
		int num3 = (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(dataA.ItemId) > false) ? 1 : 0;
		int num4 = (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(dataB.ItemId) > false) ? 1 : 0;
		if (num3 != num4)
		{
			return num4 - num3;
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

	// Token: 0x0601156B RID: 71019 RVA: 0x0043C70C File Offset: 0x0043A90C
	private void RefreshScrollViewByData(bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Frame, null);
			List<MotorcycleDiyFrameItemData> frameDataList = this.GetFrameItemDataList();
			frameDataList.Sort(new Comparison<MotorcycleDiyFrameItemData>(this.SortFrameItemFunc));
			this.CachedFrameDataList = frameDataList;
			this.FrameScrollView.RefreshByData(frameDataList, true, delegate
			{
				this.AutoSelectGridByDataList(frameDataList);
			}, false);
			return;
		}
		this.FrameScrollView.RefreshByData(this.CachedFrameDataList, true, null, false);
	}

	// Token: 0x0601156C RID: 71020 RVA: 0x0043C7A0 File Offset: 0x0043A9A0
	[NullableContext(1)]
	private void AutoSelectGridByDataList(List<MotorcycleDiyFrameItemData> frameDataList)
	{
		int gridIndex = 0;
		int selectFrameId = 0;
		int selectedFrameId = MotorcycleDiyModel.Instance.GetSelectedFrameId();
		if (selectedFrameId != 0)
		{
			selectFrameId = selectedFrameId;
		}
		else
		{
			selectFrameId = MotorcycleDiyModel.Instance.GetEquippedFrameId();
		}
		int num = frameDataList.FindIndex((MotorcycleDiyFrameItemData frameData) => frameData.ItemId == selectFrameId);
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

	// Token: 0x0601156D RID: 71021 RVA: 0x0043C830 File Offset: 0x0043AA30
	private void OnFrameInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Frame, null);
		this.RefreshScrollViewByData(false);
	}

	// Token: 0x0601156E RID: 71022 RVA: 0x0043C858 File Offset: 0x0043AA58
	[NullableContext(1)]
	private void OnClickFrame(int frameId, UUIExtendToggle toggle, UUIItem newItem)
	{
		EOutLookState frameState = MotorcycleDiyModel.Instance.GetFrameState(frameId);
		if (frameState == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = MotorcycleDiyModel.Instance.GetBanTips(EOutlookType.Frame, frameId);
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
		if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer() && frameState == EOutLookState.CanEquipped)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYWarning02", Array.Empty<object>());
			return;
		}
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		this.UiViewSequence.PlaySequencePurely("Switch", false, false);
		List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(false);
		List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(false);
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = frameId,
			StickerIds = selectedStickerIdList.ToArray(),
			DecorationIds = selectedDecorationIdList.ToArray()
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
		MotorcycleDiyModel.Instance.SetSelectFrame(frameId);
		if (frameState == EOutLookState.CanEquipped)
		{
			MotorcycleDiyController.Instance.EquipMotorFrameRequest(frameId, null);
		}
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Frame, 0, frameId);
		}
		EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
		this.RefreshScrollViewByData(false);
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(9);
		UUIItem item3 = base.GetItem(7);
		UUIText text = base.GetText(10);
		UUIButtonComponent button = base.GetButton(8);
		UUIText text2 = base.GetText(11);
		UUIText text3 = base.GetText(4);
		UUIText text4 = base.GetText(6);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(false);
		MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(frameId);
		if (motorFrameConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text4, motorFrameConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text3, motorFrameConfig.Value.Title, Array.Empty<object>());
		item.SetUIActive(frameState == EOutLookState.IsLock);
		int[] itemAccessArray = motorFrameConfig.Value.GetItemAccessArray();
		if (itemAccessArray == null || itemAccessArray.Length == 0)
		{
			return;
		}
		int num = itemAccessArray[0];
		if (num == 0)
		{
			return;
		}
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(num);
		if (accessPathConfig == null)
		{
			return;
		}
		this.JumpId = num;
		ESkipName skipName = (ESkipName)accessPathConfig.Value.SkipName;
		button.RootUIComp.Get().SetUIActive(skipName != ESkipName.NoSkip && frameState == EOutLookState.IsLock);
		item3.SetUIActive(frameState == EOutLookState.IsLock);
		item2.SetUIActive(skipName == ESkipName.NoSkip && frameState == EOutLookState.IsLock);
		LguiUtil.Instance.SetLocalTextNew(text, accessPathConfig.Value.Description, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text2, accessPathConfig.Value.Description, Array.Empty<object>());
	}

	// Token: 0x0601156F RID: 71023 RVA: 0x0043CB94 File Offset: 0x0043AD94
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x040083C9 RID: 33737
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyFrameItem, MotorcycleDiyFrameItemData> FrameScrollView;

	// Token: 0x040083CA RID: 33738
	[Nullable(1)]
	private List<MotorcycleDiyFrameItemData> CachedFrameDataList = new List<MotorcycleDiyFrameItemData>();

	// Token: 0x040083CB RID: 33739
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083CC RID: 33740
	private int JumpId;

	// Token: 0x020087EB RID: 34795
	[NullableContext(0)]
	private class EMotorFrameScrollViewComponent
	{
		// Token: 0x0402C2B7 RID: 180919
		public const int LoopScrollView = 0;

		// Token: 0x0402C2B8 RID: 180920
		public const int SVContent = 1;

		// Token: 0x0402C2B9 RID: 180921
		public const int TogMotorDiyFrameItem = 2;

		// Token: 0x0402C2BA RID: 180922
		public const int BtnOverview = 3;

		// Token: 0x0402C2BB RID: 180923
		public const int TxtTitle = 4;

		// Token: 0x0402C2BC RID: 180924
		public const int LockItem = 5;

		// Token: 0x0402C2BD RID: 180925
		public const int TxtSubTitle = 6;

		// Token: 0x0402C2BE RID: 180926
		public const int TitleGetItem = 7;

		// Token: 0x0402C2BF RID: 180927
		public const int BtnJump = 8;

		// Token: 0x0402C2C0 RID: 180928
		public const int TipsItem = 9;

		// Token: 0x0402C2C1 RID: 180929
		public const int TxtTipsName = 10;

		// Token: 0x0402C2C2 RID: 180930
		public const int TxtJump = 11;
	}
}
