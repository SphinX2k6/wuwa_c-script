using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EEF RID: 3823
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssCommonRewardView : UiViewBase
{
	// Token: 0x06009938 RID: 39224 RVA: 0x002D6934 File Offset: 0x002D4B34
	public DangoAbyssCommonRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009939 RID: 39225 RVA: 0x002D6950 File Offset: 0x002D4B50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600993A RID: 39226 RVA: 0x002D6A7A File Offset: 0x002D4C7A
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600993B RID: 39227 RVA: 0x002D6A89 File Offset: 0x002D4C89
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRewardStateUpdate, new Action(this.OnAbyssRewardStateUpdate));
	}

	// Token: 0x0600993C RID: 39228 RVA: 0x002D6AA7 File Offset: 0x002D4CA7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRewardStateUpdate, new Action(this.OnAbyssRewardStateUpdate));
	}

	// Token: 0x0600993D RID: 39229 RVA: 0x002D6AC5 File Offset: 0x002D4CC5
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600993E RID: 39230 RVA: 0x002D6AD0 File Offset: 0x002D4CD0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssCommonRewardView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssCommonRewardView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600993F RID: 39231 RVA: 0x002D6B14 File Offset: 0x002D4D14
	protected override void OnStart()
	{
		this.CurrentData = (this.OpenParam as DangoAbyssRewardViewData);
		int[] rewardTypeTabList = this.CurrentData.Data.GetRewardTypeTabList(2);
		if (rewardTypeTabList.Length != 0)
		{
			this.CurrentTabId = rewardTypeTabList[0];
		}
		for (int i = 0; i < rewardTypeTabList.Length; i++)
		{
			this.TabItemList[i].SetActive(true);
		}
		this.LoopScrollView = new LoopScrollView<DangoAbyssRewardItem, IActivityRewardData>(base.GetLoopScrollViewComponent(3), base.GetItem(5).GetOwner() as AUIBaseActor, new Func<DangoAbyssRewardItem>(this.CreateLoopItem), false);
	}

	// Token: 0x06009940 RID: 39232 RVA: 0x002D6BA1 File Offset: 0x002D4DA1
	private void OnAbyssRewardStateUpdate()
	{
		this.RefreshRewardLayout();
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.CurrentData.Data.Id);
	}

	// Token: 0x06009941 RID: 39233 RVA: 0x002D6BCC File Offset: 0x002D4DCC
	private void RefreshRewardLayout()
	{
		foreach (TabItem tabItem in this.TabItemList)
		{
			tabItem.RefreshRedDot();
		}
		IActivityRewardData[] taskActivityRewardDataList = this.CurrentData.Data.GetTaskActivityRewardDataList(2, this.CurrentTabId);
		this.LoopScrollView.RefreshByData(taskActivityRewardDataList, false, null, true);
	}

	// Token: 0x06009942 RID: 39234 RVA: 0x002D6C44 File Offset: 0x002D4E44
	private void RefreshTabLayout()
	{
		int[] rewardTypeTabList = this.CurrentData.Data.GetRewardTypeTabList(2);
		List<TabData> list = new List<TabData>();
		int num = rewardTypeTabList.Length;
		foreach (int tabId in rewardTypeTabList)
		{
			list.Add(new TabData
			{
				TabId = tabId,
				CurrentSelectTabId = this.CurrentTabId,
				ClickCallBack = new Action<int>(this.OnClickTab),
				ActivityData = this.CurrentData.Data
			});
		}
		for (int j = 0; j < num; j++)
		{
			this.TabItemList[j].Refresh(list[j], false, j);
		}
	}

	// Token: 0x06009943 RID: 39235 RVA: 0x002D6CF7 File Offset: 0x002D4EF7
	private void OnClickTab(int tabId)
	{
		this.CurrentTabId = tabId;
		this.RefreshRewardLayout();
		this.RefreshTabLayout();
	}

	// Token: 0x06009944 RID: 39236 RVA: 0x002D6D0C File Offset: 0x002D4F0C
	private DangoAbyssRewardItem CreateLoopItem()
	{
		return new DangoAbyssRewardItem();
	}

	// Token: 0x06009945 RID: 39237 RVA: 0x002D6D13 File Offset: 0x002D4F13
	protected override void OnBeforeShow()
	{
		this.CurrentTabId = ((this.CurrentData.Data.GetRewardTypeTabList(2).Length != 0) ? this.CurrentData.Data.GetRewardTypeTabList(2)[0] : 1);
		this.RefreshRewardLayout();
		this.RefreshTabLayout();
	}

	// Token: 0x04005BB0 RID: 23472
	private int CurrentTabId = 1;

	// Token: 0x04005BB1 RID: 23473
	[Nullable(2)]
	private DangoAbyssRewardViewData CurrentData;

	// Token: 0x04005BB2 RID: 23474
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<DangoAbyssRewardItem, IActivityRewardData> LoopScrollView;

	// Token: 0x04005BB3 RID: 23475
	[Nullable(2)]
	private TabItem TabItem1;

	// Token: 0x04005BB4 RID: 23476
	[Nullable(2)]
	private TabItem TabItem2;

	// Token: 0x04005BB5 RID: 23477
	private readonly List<TabItem> TabItemList = new List<TabItem>();

	// Token: 0x02007106 RID: 28934
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024D02 RID: 150786
		public const int BtnClose = 0;

		// Token: 0x04024D03 RID: 150787
		public const int TabItem1 = 1;

		// Token: 0x04024D04 RID: 150788
		public const int TabItem2 = 2;

		// Token: 0x04024D05 RID: 150789
		public const int LoopScroller = 3;

		// Token: 0x04024D06 RID: 150790
		public const int TabLayout = 4;

		// Token: 0x04024D07 RID: 150791
		public const int ScrollerItem = 5;
	}
}
