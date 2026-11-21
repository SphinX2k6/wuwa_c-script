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

// Token: 0x020013D0 RID: 5072
[NullableContext(1)]
[Nullable(0)]
public class MascotCollectBookMascotPanel : UiPanelBase
{
	// Token: 0x0600C8FB RID: 51451 RVA: 0x003BCE64 File Offset: 0x003BB064
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

	// Token: 0x0600C8FC RID: 51452 RVA: 0x003BD01B File Offset: 0x003BB21B
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600C8FD RID: 51453 RVA: 0x003BD038 File Offset: 0x003BB238
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		this.MascotToggleLayout = new GenericLayout<MascotCollectBookInfoItem, IMascotCollectInfoData>(base.GetVerticalLayout(0), new Func<MascotCollectBookInfoItem>(this.CreateMascotInfoItem), null, false, true);
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(7), new Func<ActivitySmallItemGrid>(this.CreatePropItem), null, false, null);
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(9));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x0600C8FE RID: 51454 RVA: 0x003BD0EC File Offset: 0x003BB2EC
	protected override void OnBeforeShow()
	{
		this.LevelPlaySequence.PlaySequence("Start", false, null);
	}

	// Token: 0x0600C8FF RID: 51455 RVA: 0x003BD113 File Offset: 0x003BB313
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
	}

	// Token: 0x0600C900 RID: 51456 RVA: 0x003BD150 File Offset: 0x003BB350
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

	// Token: 0x0600C901 RID: 51457 RVA: 0x003BD1AF File Offset: 0x003BB3AF
	private MascotCollectBookInfoItem CreateMascotInfoItem()
	{
		MascotCollectBookInfoItem mascotCollectBookInfoItem = new MascotCollectBookInfoItem();
		mascotCollectBookInfoItem.BindMascotToggleClick(new Action<MascotCollectBookMascotToggle>(this.OnMascotToggleClick));
		return mascotCollectBookInfoItem;
	}

	// Token: 0x0600C902 RID: 51458 RVA: 0x003BD1C8 File Offset: 0x003BB3C8
	private ActivitySmallItemGrid CreatePropItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x0600C903 RID: 51459 RVA: 0x003BD1D0 File Offset: 0x003BB3D0
	public UniTask InitPanel()
	{
		MascotCollectBookMascotPanel.<InitPanel>d__20 <InitPanel>d__;
		<InitPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPanel>d__.<>4__this = this;
		<InitPanel>d__.<>1__state = -1;
		<InitPanel>d__.<>t__builder.Start<MascotCollectBookMascotPanel.<InitPanel>d__20>(ref <InitPanel>d__);
		return <InitPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C904 RID: 51460 RVA: 0x003BD214 File Offset: 0x003BB414
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

	// Token: 0x0600C905 RID: 51461 RVA: 0x003BD29C File Offset: 0x003BB49C
	private UniTask InitInfoLayout()
	{
		MascotCollectBookMascotPanel.<InitInfoLayout>d__22 <InitInfoLayout>d__;
		<InitInfoLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInfoLayout>d__.<>4__this = this;
		<InitInfoLayout>d__.<>1__state = -1;
		<InitInfoLayout>d__.<>t__builder.Start<MascotCollectBookMascotPanel.<InitInfoLayout>d__22>(ref <InitInfoLayout>d__);
		return <InitInfoLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600C906 RID: 51462 RVA: 0x003BD2E0 File Offset: 0x003BB4E0
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

	// Token: 0x0600C907 RID: 51463 RVA: 0x003BD3A8 File Offset: 0x003BB5A8
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

	// Token: 0x0600C908 RID: 51464 RVA: 0x003BD5E0 File Offset: 0x003BB7E0
	public void BindSwitchCallback(Action callback)
	{
		this.SwitchCallback = callback;
	}

	// Token: 0x0600C909 RID: 51465 RVA: 0x003BD5EC File Offset: 0x003BB7EC
	public void CloseWithSequence()
	{
		this.LevelPlaySequence.PlaySequence("Close", false, null);
	}

	// Token: 0x0600C90A RID: 51466 RVA: 0x003BD614 File Offset: 0x003BB814
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

	// Token: 0x0600C90B RID: 51467 RVA: 0x003BD67C File Offset: 0x003BB87C
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

	// Token: 0x0600C90C RID: 51468 RVA: 0x003BD6C0 File Offset: 0x003BB8C0
	private void PlayStampSequence()
	{
		this.WaitRewardViewClose = false;
		this.CurSelectMascotItem.Refresh(this.CurSelectMascotItem.Data, true, 0);
		this.RefreshDetailPanel();
		this.LevelPlaySequence.PlaySequence("Stamp", false, null);
	}

	// Token: 0x0600C90D RID: 51469 RVA: 0x003BD70C File Offset: 0x003BB90C
	private void OnCloseRewardView()
	{
		if (this.WaitRewardViewClose)
		{
			this.PlayStampSequence();
		}
	}

	// Token: 0x04007226 RID: 29222
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007227 RID: 29223
	[Nullable(2)]
	private HonamiStoryMascotData CurSelectMascotData;

	// Token: 0x04007228 RID: 29224
	[Nullable(2)]
	private MascotCollectBookMascotToggle CurSelectMascotItem;

	// Token: 0x04007229 RID: 29225
	private readonly Dictionary<int, List<HonamiStoryMascotData>> MascotDataMapByAreaId = new Dictionary<int, List<HonamiStoryMascotData>>();

	// Token: 0x0400722A RID: 29226
	private GenericLayout<MascotCollectBookInfoItem, IMascotCollectInfoData> MascotToggleLayout;

	// Token: 0x0400722B RID: 29227
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0400722C RID: 29228
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400722D RID: 29229
	private readonly List<MascotCollectBookMascotToggle> MascotToggleList = new List<MascotCollectBookMascotToggle>();

	// Token: 0x0400722E RID: 29230
	[Nullable(2)]
	private Action SwitchCallback;

	// Token: 0x0400722F RID: 29231
	private bool WaitRewardViewClose;

	// Token: 0x04007230 RID: 29232
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x020076A0 RID: 30368
	[NullableContext(0)]
	private enum EMascotCollectBookMascotPanel
	{
		// Token: 0x0402683C RID: 157756
		InfoLayout,
		// Token: 0x0402683D RID: 157757
		InfoItem,
		// Token: 0x0402683E RID: 157758
		NumberText,
		// Token: 0x0402683F RID: 157759
		NameText,
		// Token: 0x04026840 RID: 157760
		LocationText,
		// Token: 0x04026841 RID: 157761
		FeatureText,
		// Token: 0x04026842 RID: 157762
		ClueText,
		// Token: 0x04026843 RID: 157763
		RewardScrollView,
		// Token: 0x04026844 RID: 157764
		RewardItem,
		// Token: 0x04026845 RID: 157765
		ConfirmBtn,
		// Token: 0x04026846 RID: 157766
		GotTagItem,
		// Token: 0x04026847 RID: 157767
		PictureTexture
	}
}
