using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F10 RID: 7952
[NullableContext(1)]
[Nullable(0)]
public class MascotCollectBookStagePanel : UiPanelBase
{
	// Token: 0x0600F4FE RID: 62718 RVA: 0x003B1E6C File Offset: 0x003B006C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F4FF RID: 62719 RVA: 0x003B1FBD File Offset: 0x003B01BD
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600F500 RID: 62720 RVA: 0x003B1FD8 File Offset: 0x003B01D8
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayout<MascotCollectBookStageToggle, HonamiStoryAreaData>(base.GetVerticalLayout(0), new Func<MascotCollectBookStageToggle>(this.CreateInfoItem), null, false, true);
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.CreatePropItem), null, false, null);
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(8));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickConfirm));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F501 RID: 62721 RVA: 0x003B206C File Offset: 0x003B026C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F502 RID: 62722 RVA: 0x003B208A File Offset: 0x003B028A
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Stadtage_Switch_2")
		{
			this.RefreshDetailPanel();
		}
	}

	// Token: 0x0600F503 RID: 62723 RVA: 0x003B20A0 File Offset: 0x003B02A0
	private MascotCollectBookStageToggle CreateInfoItem()
	{
		MascotCollectBookStageToggle mascotCollectBookStageToggle = new MascotCollectBookStageToggle();
		mascotCollectBookStageToggle.BindStageToggleClick(new Action<MascotCollectBookStageToggle>(this.OnStageToggleClick));
		this.InfoToggleList.Add(mascotCollectBookStageToggle);
		return mascotCollectBookStageToggle;
	}

	// Token: 0x0600F504 RID: 62724 RVA: 0x003B20D2 File Offset: 0x003B02D2
	private ActivitySmallItemGrid CreatePropItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x0600F505 RID: 62725 RVA: 0x003B20DC File Offset: 0x003B02DC
	public UniTask InitPanel()
	{
		MascotCollectBookStagePanel.<InitPanel>d__18 <InitPanel>d__;
		<InitPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPanel>d__.<>4__this = this;
		<InitPanel>d__.<>1__state = -1;
		<InitPanel>d__.<>t__builder.Start<MascotCollectBookStagePanel.<InitPanel>d__18>(ref <InitPanel>d__);
		return <InitPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F506 RID: 62726 RVA: 0x003B211F File Offset: 0x003B031F
	private void InitAreaDataList()
	{
		this.AreaDataList = this.ActivityData.GetHonamiStoryMascotAreaDataList();
	}

	// Token: 0x0600F507 RID: 62727 RVA: 0x003B2134 File Offset: 0x003B0334
	private UniTask InitInfoLayout()
	{
		MascotCollectBookStagePanel.<InitInfoLayout>d__20 <InitInfoLayout>d__;
		<InitInfoLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInfoLayout>d__.<>4__this = this;
		<InitInfoLayout>d__.<>1__state = -1;
		<InitInfoLayout>d__.<>t__builder.Start<MascotCollectBookStagePanel.<InitInfoLayout>d__20>(ref <InitInfoLayout>d__);
		return <InitInfoLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600F508 RID: 62728 RVA: 0x003B2178 File Offset: 0x003B0378
	private void RefreshDetailPanel()
	{
		if (this.CurSelectAreaData == null)
		{
			return;
		}
		base.GetText(2).ShowTextNew(this.CurSelectAreaData.Name);
		EHonamiStoryCollectState collectMascotState = this.CurSelectAreaData.CollectMascotState;
		base.GetItem(5).SetUIActive(collectMascotState == EHonamiStoryCollectState.Unfinished);
		base.GetText(4).SetUIActive(collectMascotState > EHonamiStoryCollectState.Unfinished);
		base.GetText(4).ShowTextNew(this.CurSelectAreaData.Desc);
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.CurSelectAreaData.DropId);
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in dropPackagePreviewItemList)
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = (collectMascotState == EHonamiStoryCollectState.GotReward)
			};
			list.Add(item2);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
		this.ConfirmButtonItem.SetUiActive(collectMascotState != EHonamiStoryCollectState.GotReward);
		this.ConfirmButtonItem.SetEnableClick(collectMascotState == EHonamiStoryCollectState.Finished);
		this.ConfirmButtonItem.SetRedDotVisible(collectMascotState == EHonamiStoryCollectState.Finished);
		string showText;
		if (HonamiStoryDefine.Instance.honamiCollectStateMap.TryGetValue(collectMascotState, out showText))
		{
			this.ConfirmButtonItem.SetShowText(showText);
		}
	}

	// Token: 0x0600F509 RID: 62729 RVA: 0x003B22BC File Offset: 0x003B04BC
	public void BindSwitchCallback(Action callback)
	{
		this.SwitchCallback = callback;
	}

	// Token: 0x0600F50A RID: 62730 RVA: 0x003B22C8 File Offset: 0x003B04C8
	public void CloseWithSequence()
	{
		this.LevelPlaySequence.PlaySequence("Close", false, null);
	}

	// Token: 0x0600F50B RID: 62731 RVA: 0x003B22F0 File Offset: 0x003B04F0
	private void OnStageToggleClick(MascotCollectBookStageToggle areaSecretItem)
	{
		if (this.CurSelectAreaToggle == areaSecretItem)
		{
			return;
		}
		MascotCollectBookStageToggle curSelectAreaToggle = this.CurSelectAreaToggle;
		if (curSelectAreaToggle != null)
		{
			curSelectAreaToggle.OnDeselected(true);
		}
		this.CurSelectAreaToggle = areaSecretItem;
		this.CurSelectAreaData = areaSecretItem.Data;
		Action switchCallback = this.SwitchCallback;
		if (switchCallback != null)
		{
			switchCallback();
		}
		this.LevelPlaySequence.PlaySequence("Switch_2", false, null);
	}

	// Token: 0x0600F50C RID: 62732 RVA: 0x003B2357 File Offset: 0x003B0557
	private void OnClickConfirm(int _)
	{
		if (this.CurSelectAreaData == null)
		{
			return;
		}
		HonamiStoryController.Instance.SendHonamiStoryAreaSecretRewardRequest(this.CurSelectAreaData.Id, delegate
		{
			this.CurSelectAreaToggle.Refresh(this.CurSelectAreaToggle.Data, true, 0);
			this.RefreshDetailPanel();
		});
	}

	// Token: 0x04007153 RID: 29011
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007154 RID: 29012
	[Nullable(2)]
	private HonamiStoryAreaData CurSelectAreaData;

	// Token: 0x04007155 RID: 29013
	[Nullable(2)]
	private MascotCollectBookStageToggle CurSelectAreaToggle;

	// Token: 0x04007156 RID: 29014
	private List<HonamiStoryAreaData> AreaDataList = new List<HonamiStoryAreaData>();

	// Token: 0x04007157 RID: 29015
	private GenericLayout<MascotCollectBookStageToggle, HonamiStoryAreaData> InfoLayout;

	// Token: 0x04007158 RID: 29016
	private readonly List<MascotCollectBookStageToggle> InfoToggleList = new List<MascotCollectBookStageToggle>();

	// Token: 0x04007159 RID: 29017
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0400715A RID: 29018
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400715B RID: 29019
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x0400715C RID: 29020
	[Nullable(2)]
	private Action SwitchCallback;

	// Token: 0x0200851F RID: 34079
	[NullableContext(0)]
	private enum EMascotCollectBookStagePanelComponent
	{
		// Token: 0x0402B532 RID: 177458
		InfoLayout,
		// Token: 0x0402B533 RID: 177459
		InfoItem,
		// Token: 0x0402B534 RID: 177460
		NameText,
		// Token: 0x0402B535 RID: 177461
		ScrollBar,
		// Token: 0x0402B536 RID: 177462
		DetailText,
		// Token: 0x0402B537 RID: 177463
		UnfinishPanel,
		// Token: 0x0402B538 RID: 177464
		RewardScrollView,
		// Token: 0x0402B539 RID: 177465
		RewardItem,
		// Token: 0x0402B53A RID: 177466
		ConfirmBtn
	}
}
