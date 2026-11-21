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

// Token: 0x020013D2 RID: 5074
[NullableContext(1)]
[Nullable(0)]
public class MascotCollectBookStagePanel : UiPanelBase
{
	// Token: 0x0600C91D RID: 51485 RVA: 0x003BD958 File Offset: 0x003BBB58
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

	// Token: 0x0600C91E RID: 51486 RVA: 0x003BDAA9 File Offset: 0x003BBCA9
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
	}

	// Token: 0x0600C91F RID: 51487 RVA: 0x003BDAC4 File Offset: 0x003BBCC4
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayout<MascotCollectBookStageToggle, HonamiStoryAreaData>(base.GetVerticalLayout(0), new Func<MascotCollectBookStageToggle>(this.CreateInfoItem), null, false, true);
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.CreatePropItem), null, false, null);
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(8));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickConfirm));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C920 RID: 51488 RVA: 0x003BDB58 File Offset: 0x003BBD58
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C921 RID: 51489 RVA: 0x003BDB76 File Offset: 0x003BBD76
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Stadtage_Switch_2")
		{
			this.RefreshDetailPanel();
		}
	}

	// Token: 0x0600C922 RID: 51490 RVA: 0x003BDB8C File Offset: 0x003BBD8C
	private MascotCollectBookStageToggle CreateInfoItem()
	{
		MascotCollectBookStageToggle mascotCollectBookStageToggle = new MascotCollectBookStageToggle();
		mascotCollectBookStageToggle.BindStageToggleClick(new Action<MascotCollectBookStageToggle>(this.OnStageToggleClick));
		this.InfoToggleList.Add(mascotCollectBookStageToggle);
		return mascotCollectBookStageToggle;
	}

	// Token: 0x0600C923 RID: 51491 RVA: 0x003BDBBE File Offset: 0x003BBDBE
	private ActivitySmallItemGrid CreatePropItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x0600C924 RID: 51492 RVA: 0x003BDBC8 File Offset: 0x003BBDC8
	public UniTask InitPanel()
	{
		MascotCollectBookStagePanel.<InitPanel>d__18 <InitPanel>d__;
		<InitPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPanel>d__.<>4__this = this;
		<InitPanel>d__.<>1__state = -1;
		<InitPanel>d__.<>t__builder.Start<MascotCollectBookStagePanel.<InitPanel>d__18>(ref <InitPanel>d__);
		return <InitPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C925 RID: 51493 RVA: 0x003BDC0B File Offset: 0x003BBE0B
	private void InitAreaDataList()
	{
		this.AreaDataList = this.ActivityData.GetHonamiStoryMascotAreaDataList();
	}

	// Token: 0x0600C926 RID: 51494 RVA: 0x003BDC20 File Offset: 0x003BBE20
	private UniTask InitInfoLayout()
	{
		MascotCollectBookStagePanel.<InitInfoLayout>d__20 <InitInfoLayout>d__;
		<InitInfoLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInfoLayout>d__.<>4__this = this;
		<InitInfoLayout>d__.<>1__state = -1;
		<InitInfoLayout>d__.<>t__builder.Start<MascotCollectBookStagePanel.<InitInfoLayout>d__20>(ref <InitInfoLayout>d__);
		return <InitInfoLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600C927 RID: 51495 RVA: 0x003BDC64 File Offset: 0x003BBE64
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

	// Token: 0x0600C928 RID: 51496 RVA: 0x003BDDA8 File Offset: 0x003BBFA8
	public void BindSwitchCallback(Action callback)
	{
		this.SwitchCallback = callback;
	}

	// Token: 0x0600C929 RID: 51497 RVA: 0x003BDDB4 File Offset: 0x003BBFB4
	public void CloseWithSequence()
	{
		this.LevelPlaySequence.PlaySequence("Close", false, null);
	}

	// Token: 0x0600C92A RID: 51498 RVA: 0x003BDDDC File Offset: 0x003BBFDC
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

	// Token: 0x0600C92B RID: 51499 RVA: 0x003BDE43 File Offset: 0x003BC043
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

	// Token: 0x04007234 RID: 29236
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007235 RID: 29237
	[Nullable(2)]
	private HonamiStoryAreaData CurSelectAreaData;

	// Token: 0x04007236 RID: 29238
	[Nullable(2)]
	private MascotCollectBookStageToggle CurSelectAreaToggle;

	// Token: 0x04007237 RID: 29239
	private List<HonamiStoryAreaData> AreaDataList = new List<HonamiStoryAreaData>();

	// Token: 0x04007238 RID: 29240
	private GenericLayout<MascotCollectBookStageToggle, HonamiStoryAreaData> InfoLayout;

	// Token: 0x04007239 RID: 29241
	private readonly List<MascotCollectBookStageToggle> InfoToggleList = new List<MascotCollectBookStageToggle>();

	// Token: 0x0400723A RID: 29242
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0400723B RID: 29243
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400723C RID: 29244
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x0400723D RID: 29245
	[Nullable(2)]
	private Action SwitchCallback;

	// Token: 0x020076A4 RID: 30372
	[NullableContext(0)]
	private enum EMascotCollectBookStagePanelComponent
	{
		// Token: 0x04026856 RID: 157782
		InfoLayout,
		// Token: 0x04026857 RID: 157783
		InfoItem,
		// Token: 0x04026858 RID: 157784
		NameText,
		// Token: 0x04026859 RID: 157785
		ScrollBar,
		// Token: 0x0402685A RID: 157786
		DetailText,
		// Token: 0x0402685B RID: 157787
		UnfinishPanel,
		// Token: 0x0402685C RID: 157788
		RewardScrollView,
		// Token: 0x0402685D RID: 157789
		RewardItem,
		// Token: 0x0402685E RID: 157790
		ConfirmBtn
	}
}
