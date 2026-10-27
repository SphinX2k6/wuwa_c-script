using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A30 RID: 6704
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssCommonRewardView : UiViewBase
{
	// Token: 0x0600C528 RID: 50472 RVA: 0x002CB814 File Offset: 0x002C9A14
	public DangoAbyssCommonRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C529 RID: 50473 RVA: 0x002CB830 File Offset: 0x002C9A30
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

	// Token: 0x0600C52A RID: 50474 RVA: 0x002CB95A File Offset: 0x002C9B5A
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C52B RID: 50475 RVA: 0x002CB969 File Offset: 0x002C9B69
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRewardStateUpdate, new Action(this.OnAbyssRewardStateUpdate));
	}

	// Token: 0x0600C52C RID: 50476 RVA: 0x002CB987 File Offset: 0x002C9B87
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRewardStateUpdate, new Action(this.OnAbyssRewardStateUpdate));
	}

	// Token: 0x0600C52D RID: 50477 RVA: 0x002CB9A5 File Offset: 0x002C9BA5
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C52E RID: 50478 RVA: 0x002CB9B0 File Offset: 0x002C9BB0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssCommonRewardView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssCommonRewardView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C52F RID: 50479 RVA: 0x002CB9F4 File Offset: 0x002C9BF4
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

	// Token: 0x0600C530 RID: 50480 RVA: 0x002CBA81 File Offset: 0x002C9C81
	private void OnAbyssRewardStateUpdate()
	{
		this.RefreshRewardLayout();
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.CurrentData.Data.Id);
	}

	// Token: 0x0600C531 RID: 50481 RVA: 0x002CBAAC File Offset: 0x002C9CAC
	private void RefreshRewardLayout()
	{
		foreach (TabItem tabItem in this.TabItemList)
		{
			tabItem.RefreshRedDot();
		}
		IActivityRewardData[] taskActivityRewardDataList = this.CurrentData.Data.GetTaskActivityRewardDataList(2, this.CurrentTabId);
		this.LoopScrollView.RefreshByData(taskActivityRewardDataList.ToList<IActivityRewardData>(), false, null, true);
	}

	// Token: 0x0600C532 RID: 50482 RVA: 0x002CBB28 File Offset: 0x002C9D28
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

	// Token: 0x0600C533 RID: 50483 RVA: 0x002CBBDB File Offset: 0x002C9DDB
	private void OnClickTab(int tabId)
	{
		this.CurrentTabId = tabId;
		this.RefreshRewardLayout();
		this.RefreshTabLayout();
	}

	// Token: 0x0600C534 RID: 50484 RVA: 0x002CBBF0 File Offset: 0x002C9DF0
	private DangoAbyssRewardItem CreateLoopItem()
	{
		return new DangoAbyssRewardItem();
	}

	// Token: 0x0600C535 RID: 50485 RVA: 0x002CBBF7 File Offset: 0x002C9DF7
	protected override void OnBeforeShow()
	{
		this.CurrentTabId = ((this.CurrentData.Data.GetRewardTypeTabList(2).Length != 0) ? this.CurrentData.Data.GetRewardTypeTabList(2)[0] : 1);
		this.RefreshRewardLayout();
		this.RefreshTabLayout();
	}

	// Token: 0x04005AE1 RID: 23265
	private int CurrentTabId = 1;

	// Token: 0x04005AE2 RID: 23266
	[Nullable(2)]
	private DangoAbyssRewardViewData CurrentData;

	// Token: 0x04005AE3 RID: 23267
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<DangoAbyssRewardItem, IActivityRewardData> LoopScrollView;

	// Token: 0x04005AE4 RID: 23268
	[Nullable(2)]
	private TabItem TabItem1;

	// Token: 0x04005AE5 RID: 23269
	[Nullable(2)]
	private TabItem TabItem2;

	// Token: 0x04005AE6 RID: 23270
	private readonly List<TabItem> TabItemList = new List<TabItem>();

	// Token: 0x02007F77 RID: 32631
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040299C5 RID: 170437
		public const int BtnClose = 0;

		// Token: 0x040299C6 RID: 170438
		public const int TabItem1 = 1;

		// Token: 0x040299C7 RID: 170439
		public const int TabItem2 = 2;

		// Token: 0x040299C8 RID: 170440
		public const int LoopScroller = 3;

		// Token: 0x040299C9 RID: 170441
		public const int TabLayout = 4;

		// Token: 0x040299CA RID: 170442
		public const int ScrollerItem = 5;
	}
}
