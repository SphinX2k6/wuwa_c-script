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

// Token: 0x02001786 RID: 6022
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyFrameTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001658 RID: 5720
	// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x00448EF2 File Offset: 0x004470F2
	// (set) Token: 0x0600E9F6 RID: 59894 RVA: 0x00448EFA File Offset: 0x004470FA
	public Action<int> OnTabCameraClick { get; set; }

	// Token: 0x17001659 RID: 5721
	// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x00448F03 File Offset: 0x00447103
	// (set) Token: 0x0600E9F8 RID: 59896 RVA: 0x00448F0B File Offset: 0x0044710B
	public Action<EOutlookType, int, int> OnSelectItemClick { get; set; }

	// Token: 0x0600E9F9 RID: 59897 RVA: 0x00448F14 File Offset: 0x00447114
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

	// Token: 0x0600E9FA RID: 59898 RVA: 0x00449044 File Offset: 0x00447244
	protected override void OnStart()
	{
		this.FrameScrollView = new LoopScrollView<MotorcycleDiyFrameItem, MotorcycleDiyFrameItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<MotorcycleDiyFrameItem>(this.CreateFrameItem), true);
		base.GetButton(3).SetActive(false, false);
	}

	// Token: 0x0600E9FB RID: 59899 RVA: 0x00449084 File Offset: 0x00447284
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

	// Token: 0x0600E9FC RID: 59900 RVA: 0x0044909E File Offset: 0x0044729E
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x0600E9FD RID: 59901 RVA: 0x004490BC File Offset: 0x004472BC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnFrameInfoUpdate));
	}

	// Token: 0x0600E9FE RID: 59902 RVA: 0x004490DA File Offset: 0x004472DA
	[NullableContext(1)]
	private MotorcycleDiyFrameItem CreateFrameItem()
	{
		return new MotorcycleDiyFrameItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickFrame)
		};
	}

	// Token: 0x0600E9FF RID: 59903 RVA: 0x004490F3 File Offset: 0x004472F3
	public void RefreshItemScrollView()
	{
		if (this.FrameScrollView != null)
		{
			this.RefreshScrollViewByData(true);
		}
	}

	// Token: 0x0600EA00 RID: 59904 RVA: 0x00449104 File Offset: 0x00447304
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

	// Token: 0x0600EA01 RID: 59905 RVA: 0x00449164 File Offset: 0x00447364
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

	// Token: 0x0600EA02 RID: 59906 RVA: 0x0044924C File Offset: 0x0044744C
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

	// Token: 0x0600EA03 RID: 59907 RVA: 0x00449304 File Offset: 0x00447504
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

	// Token: 0x0600EA04 RID: 59908 RVA: 0x00449398 File Offset: 0x00447598
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

	// Token: 0x0600EA05 RID: 59909 RVA: 0x00449428 File Offset: 0x00447628
	private void OnFrameInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Frame, null);
		this.RefreshScrollViewByData(false);
	}

	// Token: 0x0600EA06 RID: 59910 RVA: 0x00449450 File Offset: 0x00447650
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

	// Token: 0x0600EA07 RID: 59911 RVA: 0x0044978C File Offset: 0x0044798C
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x04008507 RID: 34055
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyFrameItem, MotorcycleDiyFrameItemData> FrameScrollView;

	// Token: 0x04008508 RID: 34056
	[Nullable(1)]
	private List<MotorcycleDiyFrameItemData> CachedFrameDataList = new List<MotorcycleDiyFrameItemData>();

	// Token: 0x04008509 RID: 34057
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0400850A RID: 34058
	private int JumpId;

	// Token: 0x02007974 RID: 31092
	[NullableContext(0)]
	private class EMotorFrameScrollViewComponent
	{
		// Token: 0x040275C3 RID: 161219
		public const int LoopScrollView = 0;

		// Token: 0x040275C4 RID: 161220
		public const int SVContent = 1;

		// Token: 0x040275C5 RID: 161221
		public const int TogMotorDiyFrameItem = 2;

		// Token: 0x040275C6 RID: 161222
		public const int BtnOverview = 3;

		// Token: 0x040275C7 RID: 161223
		public const int TxtTitle = 4;

		// Token: 0x040275C8 RID: 161224
		public const int LockItem = 5;

		// Token: 0x040275C9 RID: 161225
		public const int TxtSubTitle = 6;

		// Token: 0x040275CA RID: 161226
		public const int TitleGetItem = 7;

		// Token: 0x040275CB RID: 161227
		public const int BtnJump = 8;

		// Token: 0x040275CC RID: 161228
		public const int TipsItem = 9;

		// Token: 0x040275CD RID: 161229
		public const int TxtTipsName = 10;

		// Token: 0x040275CE RID: 161230
		public const int TxtJump = 11;
	}
}
