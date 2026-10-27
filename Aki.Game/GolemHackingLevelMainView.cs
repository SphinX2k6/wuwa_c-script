using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200100D RID: 4109
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingLevelMainView : UiTickViewBase
{
	// Token: 0x0600695C RID: 26972 RVA: 0x0015032C File Offset: 0x0014E52C
	public GolemHackingLevelMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600695D RID: 26973 RVA: 0x0015033C File Offset: 0x0014E53C
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

	// Token: 0x0600695E RID: 26974 RVA: 0x00150408 File Offset: 0x0014E608
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x0600695F RID: 26975 RVA: 0x00150426 File Offset: 0x0014E626
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06006960 RID: 26976 RVA: 0x00150444 File Offset: 0x0014E644
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

	// Token: 0x06006961 RID: 26977 RVA: 0x001504DC File Offset: 0x0014E6DC
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

	// Token: 0x06006962 RID: 26978 RVA: 0x0015054C File Offset: 0x0014E74C
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

	// Token: 0x06006963 RID: 26979 RVA: 0x00150604 File Offset: 0x0014E804
	protected override void OnTick(float delta)
	{
		foreach (GolemHackingLevelGroupTab golemHackingLevelGroupTab in this.LevelLayout.GetScrollItemList())
		{
			golemHackingLevelGroupTab.OnTick();
		}
	}

	// Token: 0x06006964 RID: 26980 RVA: 0x0015065C File Offset: 0x0014E85C
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

	// Token: 0x06006965 RID: 26981 RVA: 0x0015067B File Offset: 0x0014E87B
	private void OnClickedClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006966 RID: 26982 RVA: 0x00150684 File Offset: 0x0014E884
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

	// Token: 0x06006967 RID: 26983 RVA: 0x001506D3 File Offset: 0x0014E8D3
	private GolemHackingLevelGroupTab CreateLevel()
	{
		return new GolemHackingLevelGroupTab
		{
			OnClickedCallback = new Action<GolemHackingLevelGroupInfo, int>(this.OnClickedCallback)
		};
	}

	// Token: 0x06006968 RID: 26984 RVA: 0x001506EC File Offset: 0x0014E8EC
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		GolemHackingController.Instance.CloseActivityView(closeActivities, false);
	}

	// Token: 0x04003093 RID: 12435
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003094 RID: 12436
	protected GenericScrollViewNew<GolemHackingLevelGroupTab, GolemHackingLevelGroupInfo> LevelLayout;

	// Token: 0x04003095 RID: 12437
	protected GolemHackingActivityData ActivityData;

	// Token: 0x04003096 RID: 12438
	protected int CurSelected = -1;

	// Token: 0x04003097 RID: 12439
	protected bool HasFirstInit;

	// Token: 0x02007606 RID: 30214
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FE0 RID: 159712
		CaptionItem,
		// Token: 0x04026FE1 RID: 159713
		PanelProgress,
		// Token: 0x04026FE2 RID: 159714
		TxtProgress,
		// Token: 0x04026FE3 RID: 159715
		SvList,
		// Token: 0x04026FE4 RID: 159716
		Item
	}
}
