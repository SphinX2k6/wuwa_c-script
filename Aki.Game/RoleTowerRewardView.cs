using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CFB RID: 7419
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerRewardView : UiViewBase
{
	// Token: 0x060125DE RID: 75230 RVA: 0x0056C6AB File Offset: 0x0056A8AB
	[NullableContext(1)]
	public RoleTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125DF RID: 75231 RVA: 0x0056C6B4 File Offset: 0x0056A8B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x060125E0 RID: 75232 RVA: 0x0056C768 File Offset: 0x0056A968
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125E1 RID: 75233 RVA: 0x0056C7AC File Offset: 0x0056A9AC
	protected override void OnStart()
	{
		this.TabList = new GenericScrollViewNew<RoleTowerRewardTabItem, RoleTowerRewardTabData>(base.GetScrollViewWithScrollbar(1), new Func<RoleTowerRewardTabItem>(this.CreateTabItem), null, false, null);
		this.RewardItemList = new GenericScrollViewNew<RoleTowerRewardItem, RoleTowerRewardItemData>(base.GetScrollViewWithScrollbar(3), () => new RoleTowerRewardItem(), null, false, null);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		object obj;
		if (scrollViewWithScrollbar == null)
		{
			obj = null;
		}
		else
		{
			AUIBaseActor auibaseActor = scrollViewWithScrollbar.Content.Get();
			obj = ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
		}
		this.RewardListAnim = (obj as UUIInturnAnimController);
	}

	// Token: 0x060125E2 RID: 75234 RVA: 0x0056C84A File Offset: 0x0056AA4A
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		UUIInturnAnimController rewardListAnim = this.RewardListAnim;
		if (rewardListAnim != null)
		{
			rewardListAnim.Play("", -1, false);
		}
		return UniTask.CompletedTask;
	}

	// Token: 0x060125E3 RID: 75235 RVA: 0x0056C86C File Offset: 0x0056AA6C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerRewardReceive, new Action(this.OnRewardReceive));
		EventSystem.Instance.Add(EEventName.RoleTowerInfoUpdate, new Action(this.OnRewardReceive));
		ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
	}

	// Token: 0x060125E4 RID: 75236 RVA: 0x0056C8C8 File Offset: 0x0056AAC8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerRewardReceive, new Action(this.OnRewardReceive));
		EventSystem.Instance.Remove(EEventName.RoleTowerInfoUpdate, new Action(this.OnRewardReceive));
		ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
	}

	// Token: 0x060125E5 RID: 75237 RVA: 0x0056C924 File Offset: 0x0056AB24
	protected override void OnBeforeShow()
	{
		this.InitSelectTab();
		this.RefreshTabList();
		this.RefreshRewardList();
		this.RefreshTime();
		RoleTowerRewardBottomPanel bottomPanel = this.BottomPanel;
		if (bottomPanel != null)
		{
			bottomPanel.Refresh();
		}
		HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, delegate(RewardTakeComponent component)
		{
			component.SetDataCallback(() => RoleTowerModel.Instance.GetLastNotTakenScoreRewardIndex());
		});
	}

	// Token: 0x060125E6 RID: 75238 RVA: 0x0056C985 File Offset: 0x0056AB85
	[NullableContext(1)]
	private RoleTowerRewardTabItem CreateTabItem()
	{
		RoleTowerRewardTabItem roleTowerRewardTabItem = new RoleTowerRewardTabItem();
		roleTowerRewardTabItem.SetClickCallback(new Action<int>(this.OnClickTab));
		return roleTowerRewardTabItem;
	}

	// Token: 0x060125E7 RID: 75239 RVA: 0x0056C9A0 File Offset: 0x0056ABA0
	private void InitSelectTab()
	{
		IReadOnlyList<RoleTowerRewardTab> rewardTabCfgList = RoleTowerModel.Instance.GetRewardTabCfgList();
		this.CurTabId = ((rewardTabCfgList.Count > 0) ? rewardTabCfgList[0].Id : 0);
	}

	// Token: 0x060125E8 RID: 75240 RVA: 0x0056C9DC File Offset: 0x0056ABDC
	private void RefreshTabList()
	{
		IEnumerable<RoleTowerRewardTab> rewardTabCfgList = RoleTowerModel.Instance.GetRewardTabCfgList();
		List<RoleTowerRewardTabData> list = new List<RoleTowerRewardTabData>();
		foreach (RoleTowerRewardTab roleTowerRewardTab in rewardTabCfgList)
		{
			list.Add(new RoleTowerRewardTabData
			{
				TabId = roleTowerRewardTab.Id,
				IsSelected = (roleTowerRewardTab.Id == this.CurTabId)
			});
		}
		GenericScrollViewNew<RoleTowerRewardTabItem, RoleTowerRewardTabData> tabList = this.TabList;
		if (tabList == null)
		{
			return;
		}
		tabList.RefreshByData(list, null, false);
	}

	// Token: 0x060125E9 RID: 75241 RVA: 0x0056CA6C File Offset: 0x0056AC6C
	private void RefreshRewardList()
	{
		IEnumerable<RoleTowerReward> rewardCfgListByTab = RoleTowerModel.Instance.GetRewardCfgListByTab(this.CurTabId);
		List<RoleTowerRewardItemData> list = new List<RoleTowerRewardItemData>();
		foreach (RoleTowerReward roleTowerReward in rewardCfgListByTab)
		{
			list.Add(new RoleTowerRewardItemData
			{
				RewardId = roleTowerReward.Id
			});
		}
		GenericScrollViewNew<RoleTowerRewardItem, RoleTowerRewardItemData> rewardItemList = this.RewardItemList;
		if (rewardItemList == null)
		{
			return;
		}
		rewardItemList.RefreshByData(list, null, false);
	}

	// Token: 0x060125EA RID: 75242 RVA: 0x0056CAF0 File Offset: 0x0056ACF0
	private void RefreshTime()
	{
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		UUIText text = base.GetText(5);
		if (data == null)
		{
			if (text != null)
			{
				text.SetUIActive(false);
			}
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(data, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		if (text != null)
		{
			text.SetUIActive(item);
		}
		if (item && text != null)
		{
			text.SetText(item2, true);
		}
	}

	// Token: 0x060125EB RID: 75243 RVA: 0x0056CB4F File Offset: 0x0056AD4F
	private void OnTimerRefresh(float delta)
	{
		this.RefreshTime();
	}

	// Token: 0x060125EC RID: 75244 RVA: 0x0056CB57 File Offset: 0x0056AD57
	private void OnClickTab(int tabId)
	{
		this.CurTabId = tabId;
		this.RefreshTabList();
		this.RefreshRewardList();
		UUIInturnAnimController rewardListAnim = this.RewardListAnim;
		if (rewardListAnim == null)
		{
			return;
		}
		rewardListAnim.Play("", -1, false);
	}

	// Token: 0x060125ED RID: 75245 RVA: 0x0056CB83 File Offset: 0x0056AD83
	private void OnRewardReceive()
	{
		this.RefreshTabList();
		this.RefreshRewardList();
		RoleTowerRewardBottomPanel bottomPanel = this.BottomPanel;
		if (bottomPanel == null)
		{
			return;
		}
		bottomPanel.Refresh();
	}

	// Token: 0x0400A016 RID: 40982
	private PopupCaptionItem Caption;

	// Token: 0x0400A017 RID: 40983
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerRewardTabItem, RoleTowerRewardTabData> TabList;

	// Token: 0x0400A018 RID: 40984
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerRewardItem, RoleTowerRewardItemData> RewardItemList;

	// Token: 0x0400A019 RID: 40985
	private RoleTowerRewardBottomPanel BottomPanel;

	// Token: 0x0400A01A RID: 40986
	private UUIInturnAnimController RewardListAnim;

	// Token: 0x0400A01B RID: 40987
	private int CurTabId;

	// Token: 0x0200801D RID: 32797
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029732 RID: 169778
		public const int UiItemCaption = 0;

		// Token: 0x04029733 RID: 169779
		public const int TabScroll = 1;

		// Token: 0x04029734 RID: 169780
		public const int UiItemRewardMenuItem = 2;

		// Token: 0x04029735 RID: 169781
		public const int RewardItemScroll = 3;

		// Token: 0x04029736 RID: 169782
		public const int UiItemRewardItem = 4;

		// Token: 0x04029737 RID: 169783
		public const int TxtTime = 5;

		// Token: 0x04029738 RID: 169784
		public const int PnlBottom = 6;
	}
}
