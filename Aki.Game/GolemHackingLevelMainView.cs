using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020004C1 RID: 1217
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingLevelMainView : UiTickViewBase
{
	// Token: 0x06003CF1 RID: 15601 RVA: 0x00158C54 File Offset: 0x00156E54
	public GolemHackingLevelMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x00158C64 File Offset: 0x00156E64
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x00158D30 File Offset: 0x00156F30
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x00158D4E File Offset: 0x00156F4E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06003CF5 RID: 15605 RVA: 0x00158D6C File Offset: 0x00156F6C
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
		this.CaptionItem.SetHelpCallBack(delegate
		{
			HelpController.Instance.OpenHelpById(576);
		});
		this.LevelLayout = new GenericScrollViewNew<GolemHackingLevelGroupTab, GolemHackingLevelGroupInfo>(base.GetScrollViewWithScrollbar(3), new Func<GolemHackingLevelGroupTab>(this.CreateLevel), null, false, null);
		this.ActivityData = GolemHackingController.Instance.GetActivityData();
		this.RefreshCurSelected();
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00158E04 File Offset: 0x00157004
	protected void RefreshCurSelected()
	{
		List<GolemHackingLevelGroupInfo> levelGroupList = this.ActivityData.GetLevelGroupList();
		for (int i = levelGroupList.Count - 1; i >= 0; i--)
		{
			GolemHackingLevelGroupInfo golemHackingLevelGroupInfo = levelGroupList[i];
			if (this.ActivityData.GetGroupState(golemHackingLevelGroupInfo.Group).Item1 == EGolemHackingGroupState.Normal)
			{
				this.CurSelected = i;
				break;
			}
		}
		if (this.CurSelected == -1)
		{
			this.CurSelected = levelGroupList.Count - 1;
		}
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x00158E74 File Offset: 0x00157074
	protected override void OnBeforeShow()
	{
		ValueTuple<int, int> groupProgressState = this.ActivityData.GetGroupProgressState();
		int item = groupProgressState.Item1;
		int item2 = groupProgressState.Item2;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "IntrusionProtocolActivity_Progress", new <>z__ReadOnlyArray<object>(new object[]
		{
			item,
			item2
		}));
		int count = this.LevelLayout.GetScrollItemList().Count;
		List<GolemHackingLevelGroupInfo> levelGroupList = this.ActivityData.GetLevelGroupList();
		if (count != levelGroupList.Count && count > 0)
		{
			this.CurSelected = levelGroupList.Count - 1;
			this.HasFirstInit = false;
		}
		this.LevelLayout.RefreshByData(levelGroupList, delegate
		{
			bool cacheRewardFocus = GolemHackingController.Instance.CacheRewardFocus;
			if (this.HasFirstInit && !cacheRewardFocus)
			{
				return;
			}
			if (cacheRewardFocus)
			{
				this.RefreshCurSelected();
				GolemHackingController.Instance.CacheRewardFocus = false;
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.OnLateUpdate();
			}, null, null);
		}, true);
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x00158F2C File Offset: 0x0015712C
	protected override void OnTick(float delta)
	{
		foreach (GolemHackingLevelGroupTab golemHackingLevelGroupTab in this.LevelLayout.GetScrollItemList())
		{
			golemHackingLevelGroupTab.OnTick();
		}
	}

	// Token: 0x06003CF9 RID: 15609 RVA: 0x00158F84 File Offset: 0x00157184
	protected void OnLateUpdate()
	{
		base.GetScrollViewWithScrollbar(3).OnLateUpdate.Bind(delegate(float _)
		{
			this.HasFirstInit = true;
			TimerSystem.Instance.Next(delegate(float _)
			{
				List<GolemHackingLevelGroupInfo> levelGroupList = this.ActivityData.GetLevelGroupList();
				int index = (this.CurSelected + 2 < levelGroupList.Count) ? (this.CurSelected + 2) : (levelGroupList.Count - 1);
				UUIItem itemByIndex = this.LevelLayout.GetItemByIndex(index);
				if (itemByIndex == null)
				{
					return;
				}
				this.LevelLayout.ScrollTo(itemByIndex, true);
				if (Info.Instance.IsInGamepad())
				{
					UUIItem itemByIndex2 = this.LevelLayout.GetItemByIndex(this.CurSelected);
					UiNavigationNewController.Instance.SetNavigationFocusForViewByRootItem(itemByIndex2, "Group1", true);
				}
			}, null, null);
			base.GetScrollViewWithScrollbar(3).OnLateUpdate.Unbind();
		});
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x00158FA3 File Offset: 0x001571A3
	private void OnClickedClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x00158FAC File Offset: 0x001571AC
	private void OnClickedCallback(GolemHackingLevelGroupInfo data, int gridIndex)
	{
		if (this.ActivityData.GetGroupState(data.Group).Item1 == EGolemHackingGroupState.Locked)
		{
			this.ActivityData.GetGroupLockTips(data.Group);
			return;
		}
		this.CurSelected = gridIndex;
		UiManager.Instance.OpenView(EUiViewName.GolemHackingLevelDetailView, data, null);
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x00158FFB File Offset: 0x001571FB
	private GolemHackingLevelGroupTab CreateLevel()
	{
		return new GolemHackingLevelGroupTab
		{
			OnClickedCallback = new Action<GolemHackingLevelGroupInfo, int>(this.OnClickedCallback)
		};
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x00159014 File Offset: 0x00157214
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		GolemHackingController.Instance.CloseActivityView(closeActivities, false);
	}

	// Token: 0x0400312C RID: 12588
	protected PopupCaptionItem CaptionItem;

	// Token: 0x0400312D RID: 12589
	protected GenericScrollViewNew<GolemHackingLevelGroupTab, GolemHackingLevelGroupInfo> LevelLayout;

	// Token: 0x0400312E RID: 12590
	protected GolemHackingActivityData ActivityData;

	// Token: 0x0400312F RID: 12591
	protected int CurSelected = -1;

	// Token: 0x04003130 RID: 12592
	protected bool HasFirstInit;

	// Token: 0x0200679A RID: 26522
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402232B RID: 140075
		CaptionItem,
		// Token: 0x0402232C RID: 140076
		PanelProgress,
		// Token: 0x0402232D RID: 140077
		TxtProgress,
		// Token: 0x0402232E RID: 140078
		SvList,
		// Token: 0x0402232F RID: 140079
		Item
	}
}
