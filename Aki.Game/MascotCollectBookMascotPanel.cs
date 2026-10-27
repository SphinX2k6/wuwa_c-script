using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F0E RID: 7950
[NullableContext(1)]
[Nullable(0)]
public class MascotCollectBookMascotPanel : UiPanelBase
{
	// Token: 0x0600F4DC RID: 62684 RVA: 0x003B1378 File Offset: 0x003AF578
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F4DD RID: 62685 RVA: 0x003B152F File Offset: 0x003AF72F
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600F4DE RID: 62686 RVA: 0x003B154C File Offset: 0x003AF74C
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		this.MascotToggleLayout = new GenericLayout<MascotCollectBookInfoItem, IMascotCollectInfoData>(base.GetVerticalLayout(0), new Func<MascotCollectBookInfoItem>(this.CreateMascotInfoItem), null, false, true);
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(7), new Func<ActivitySmallItemGrid>(this.CreatePropItem), null, false, null);
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(9));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x0600F4DF RID: 62687 RVA: 0x003B1600 File Offset: 0x003AF800
	protected override void OnBeforeShow()
	{
		this.LevelPlaySequence.PlaySequence("Start", false, null);
	}

	// Token: 0x0600F4E0 RID: 62688 RVA: 0x003B1627 File Offset: 0x003AF827
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x0600F4E1 RID: 62689 RVA: 0x003B1664 File Offset: 0x003AF864
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Info_Switch_2")
		{
			this.RefreshDetailPanel();
		}
		if (param == "PnlHead_Refresh" && this.CurSelectMascotData != null)
		{
			base.SetTextureShowUntilLoaded(this.CurSelectMascotData.Config.Value.Picture, base.GetTexture(11), null);
		}
	}

	// Token: 0x0600F4E2 RID: 62690 RVA: 0x003B16C3 File Offset: 0x003AF8C3
	private MascotCollectBookInfoItem CreateMascotInfoItem()
	{
		MascotCollectBookInfoItem mascotCollectBookInfoItem = new MascotCollectBookInfoItem();
		mascotCollectBookInfoItem.BindMascotToggleClick(new Action<MascotCollectBookMascotToggle>(this.OnMascotToggleClick));
		return mascotCollectBookInfoItem;
	}

	// Token: 0x0600F4E3 RID: 62691 RVA: 0x003B16DC File Offset: 0x003AF8DC
	private ActivitySmallItemGrid CreatePropItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x0600F4E4 RID: 62692 RVA: 0x003B16E4 File Offset: 0x003AF8E4
	public UniTask InitPanel()
	{
		MascotCollectBookMascotPanel.<InitPanel>d__20 <InitPanel>d__;
		<InitPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPanel>d__.<>4__this = this;
		<InitPanel>d__.<>1__state = -1;
		<InitPanel>d__.<>t__builder.Start<MascotCollectBookMascotPanel.<InitPanel>d__20>(ref <InitPanel>d__);
		return <InitPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4E5 RID: 62693 RVA: 0x003B1728 File Offset: 0x003AF928
	private void InitMapData()
	{
		this.MascotDataMapByAreaId.Clear();
		foreach (HonamiStoryAreaData honamiStoryAreaData in this.ActivityData.GetHonamiStoryMascotAreaDataList())
		{
			List<HonamiStoryMascotData> honamiStoryMascotDataListByAreaId = this.ActivityData.GetHonamiStoryMascotDataListByAreaId(honamiStoryAreaData.Id);
			if (honamiStoryMascotDataListByAreaId.Count != 0)
			{
				this.MascotDataMapByAreaId[honamiStoryAreaData.Id] = honamiStoryMascotDataListByAreaId;
			}
		}
	}

	// Token: 0x0600F4E6 RID: 62694 RVA: 0x003B17B0 File Offset: 0x003AF9B0
	private UniTask InitInfoLayout()
	{
		MascotCollectBookMascotPanel.<InitInfoLayout>d__22 <InitInfoLayout>d__;
		<InitInfoLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInfoLayout>d__.<>4__this = this;
		<InitInfoLayout>d__.<>1__state = -1;
		<InitInfoLayout>d__.<>t__builder.Start<MascotCollectBookMascotPanel.<InitInfoLayout>d__22>(ref <InitInfoLayout>d__);
		return <InitInfoLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4E7 RID: 62695 RVA: 0x003B17F4 File Offset: 0x003AF9F4
	private void InitMascotToggleList()
	{
		List<MascotCollectBookInfoItem> layoutItemList = this.MascotToggleLayout.GetLayoutItemList();
		this.MascotToggleList.Clear();
		foreach (MascotCollectBookInfoItem mascotCollectBookInfoItem in layoutItemList)
		{
			foreach (MascotCollectBookMascotToggle item in mascotCollectBookInfoItem.GetMascotToggleList())
			{
				this.MascotToggleList.Add(item);
			}
		}
		if (this.MascotToggleList.Count > 0)
		{
			this.CurSelectMascotItem = this.MascotToggleList[0];
			this.CurSelectMascotItem.OnSelected(true);
		}
	}

	// Token: 0x0600F4E8 RID: 62696 RVA: 0x003B18BC File Offset: 0x003AFABC
	private void RefreshDetailPanel()
	{
		if (this.CurSelectMascotData == null)
		{
			return;
		}
		HonamiStoryMascotData curSelectMascotData = this.CurSelectMascotData;
		HonamiStoryAreaData honamiStoryAreaData = this.ActivityData.GetHonamiStoryAreaData(curSelectMascotData.AreaId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "HonamiStory_Mascot_Number_Text", new <>z__ReadOnlySingleElementList<object>(curSelectMascotData.Id));
		base.GetText(3).ShowTextNew(curSelectMascotData.Name);
		base.GetText(4).ShowTextNew(honamiStoryAreaData.Name);
		base.GetText(5).ShowTextNew(curSelectMascotData.FeatureDesc);
		base.GetText(6).ShowTextNew(curSelectMascotData.ClueDesc);
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in RewardConfig.Instance.GetDropPackagePreviewItemList(curSelectMascotData.DropId))
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = (curSelectMascotData.State == EHonamiStoryCollectState.GotReward)
			};
			list.Add(item2);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
		EHonamiStoryCollectState state = curSelectMascotData.State;
		this.ConfirmButtonItem.SetUiActive(state != EHonamiStoryCollectState.GotReward);
		this.ConfirmButtonItem.SetEnableClick(state == EHonamiStoryCollectState.Finished);
		this.ConfirmButtonItem.SetRedDotVisible(state == EHonamiStoryCollectState.Finished);
		string showText;
		if (HonamiStoryDefine.Instance.honamiCollectStateMap.TryGetValue(state, out showText))
		{
			this.ConfirmButtonItem.SetShowText(showText);
		}
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMascotUnlockSet, null) ?? new HashSet<int>();
		if (hashSet.Contains(curSelectMascotData.Id))
		{
			UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
			if (levelPlaySequence != null)
			{
				levelPlaySequence.PlaySequence("PnlHead_Refresh", false, null);
			}
			hashSet.Remove(curSelectMascotData.Id);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryMascotUnlockSet, hashSet);
		}
		else if (state == EHonamiStoryCollectState.Finished || state == EHonamiStoryCollectState.GotReward)
		{
			base.SetTextureShowUntilLoaded(curSelectMascotData.Config.Value.Picture, base.GetTexture(11), null);
		}
		else
		{
			base.SetTextureShowUntilLoaded("/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadAEmpty.T_HonamiStoryHeadAEmpty", base.GetTexture(11), null);
		}
		base.GetItem(10).SetUIActive(state == EHonamiStoryCollectState.GotReward);
	}

	// Token: 0x0600F4E9 RID: 62697 RVA: 0x003B1AF4 File Offset: 0x003AFCF4
	public void BindSwitchCallback(Action callback)
	{
		this.SwitchCallback = callback;
	}

	// Token: 0x0600F4EA RID: 62698 RVA: 0x003B1B00 File Offset: 0x003AFD00
	public void CloseWithSequence()
	{
		this.LevelPlaySequence.PlaySequence("Close", false, null);
	}

	// Token: 0x0600F4EB RID: 62699 RVA: 0x003B1B28 File Offset: 0x003AFD28
	private void OnMascotToggleClick(MascotCollectBookMascotToggle selectedMascotItem)
	{
		if (this.CurSelectMascotItem == selectedMascotItem)
		{
			return;
		}
		MascotCollectBookMascotToggle curSelectMascotItem = this.CurSelectMascotItem;
		if (curSelectMascotItem != null)
		{
			curSelectMascotItem.OnDeselected(true);
		}
		this.CurSelectMascotItem = selectedMascotItem;
		this.CurSelectMascotData = selectedMascotItem.Data;
		Action switchCallback = this.SwitchCallback;
		if (switchCallback != null)
		{
			switchCallback();
		}
		this.LevelPlaySequence.PlaySequence("Switch_2", false, null);
	}

	// Token: 0x0600F4EC RID: 62700 RVA: 0x003B1B90 File Offset: 0x003AFD90
	private void OnClickConfirm(int _)
	{
		if (this.CurSelectMascotData == null)
		{
			return;
		}
		HonamiStoryMascotData curSelectMascotData = this.CurSelectMascotData;
		if (curSelectMascotData.State != EHonamiStoryCollectState.Finished)
		{
			return;
		}
		HonamiStoryController.Instance.SendHonamiStoryMascotRewardRequest(curSelectMascotData.Id, delegate
		{
			this.WaitRewardViewClose = true;
		});
	}

	// Token: 0x0600F4ED RID: 62701 RVA: 0x003B1BD4 File Offset: 0x003AFDD4
	private void PlayStampSequence()
	{
		this.WaitRewardViewClose = false;
		this.CurSelectMascotItem.Refresh(this.CurSelectMascotItem.Data, true, 0);
		this.RefreshDetailPanel();
		this.LevelPlaySequence.PlaySequence("Stamp", false, null);
	}

	// Token: 0x0600F4EE RID: 62702 RVA: 0x003B1C20 File Offset: 0x003AFE20
	private void OnCloseRewardView()
	{
		if (this.WaitRewardViewClose)
		{
			this.PlayStampSequence();
		}
	}

	// Token: 0x04007145 RID: 28997
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007146 RID: 28998
	[Nullable(2)]
	private HonamiStoryMascotData CurSelectMascotData;

	// Token: 0x04007147 RID: 28999
	[Nullable(2)]
	private MascotCollectBookMascotToggle CurSelectMascotItem;

	// Token: 0x04007148 RID: 29000
	private readonly Dictionary<int, List<HonamiStoryMascotData>> MascotDataMapByAreaId = new Dictionary<int, List<HonamiStoryMascotData>>();

	// Token: 0x04007149 RID: 29001
	private GenericLayout<MascotCollectBookInfoItem, IMascotCollectInfoData> MascotToggleLayout;

	// Token: 0x0400714A RID: 29002
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0400714B RID: 29003
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400714C RID: 29004
	private readonly List<MascotCollectBookMascotToggle> MascotToggleList = new List<MascotCollectBookMascotToggle>();

	// Token: 0x0400714D RID: 29005
	[Nullable(2)]
	private Action SwitchCallback;

	// Token: 0x0400714E RID: 29006
	private bool WaitRewardViewClose;

	// Token: 0x0400714F RID: 29007
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x0200851B RID: 34075
	[NullableContext(0)]
	private enum EMascotCollectBookMascotPanel
	{
		// Token: 0x0402B518 RID: 177432
		InfoLayout,
		// Token: 0x0402B519 RID: 177433
		InfoItem,
		// Token: 0x0402B51A RID: 177434
		NumberText,
		// Token: 0x0402B51B RID: 177435
		NameText,
		// Token: 0x0402B51C RID: 177436
		LocationText,
		// Token: 0x0402B51D RID: 177437
		FeatureText,
		// Token: 0x0402B51E RID: 177438
		ClueText,
		// Token: 0x0402B51F RID: 177439
		RewardScrollView,
		// Token: 0x0402B520 RID: 177440
		RewardItem,
		// Token: 0x0402B521 RID: 177441
		ConfirmBtn,
		// Token: 0x0402B522 RID: 177442
		GotTagItem,
		// Token: 0x0402B523 RID: 177443
		PictureTexture
	}
}
