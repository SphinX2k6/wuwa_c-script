using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000631 RID: 1585
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerQuestView : UiViewBase
{
	// Token: 0x060049F1 RID: 18929 RVA: 0x00192134 File Offset: 0x00190334
	public BabelTowerQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x00192160 File Offset: 0x00190360
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x001922B1 File Offset: 0x001904B1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x001922CF File Offset: 0x001904CF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x001922F0 File Offset: 0x001904F0
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerQuestView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerQuestView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x00192334 File Offset: 0x00190534
	protected override void OnStart()
	{
		base.GetItem(5).SetUIActive(false);
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in BabelTowerController.Instance.GetBabelTowerData().NormalQuest)
		{
			int key = keyValuePair.Key;
			BabelTowerTask babelTowerNormalQuest = BabelTowerConfig.Instance.GetBabelTowerNormalQuest(key);
			if (BabelTowerConfig.Instance.GetBabelTowerLevelConfig(babelTowerNormalQuest.LevelId).IsDifficult)
			{
				this.NormalDifficultyList.Add(key);
			}
			else
			{
				this.NormalSimpleList.Add(key);
			}
		}
		this.SortItemList();
		this.QuestTypeList.Add(EBabelTowerTabItem.NormalQuest);
		this.QuestTypeList.Add(EBabelTowerTabItem.HardQuest);
		GenericScrollViewNew<BabelTowerQuestTabItem, int> tabScrollerView = this.TabScrollerView;
		if (tabScrollerView == null)
		{
			return;
		}
		tabScrollerView.RefreshByData(this.QuestTypeList.ConvertAll<int>((EBabelTowerTabItem x) => (int)x), delegate
		{
			int count = this.TabScrollerView.GetScrollItemList().Count;
			BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
			bool flag = false;
			for (int i = 0; i < count; i++)
			{
				if (babelTowerData.GetQuestTabRedDot((int)this.QuestTypeList[i]))
				{
					GenericScrollViewNew<BabelTowerQuestTabItem, int> tabScrollerView2 = this.TabScrollerView;
					if (tabScrollerView2 != null)
					{
						BabelTowerQuestTabItem scrollItemByIndex = tabScrollerView2.GetScrollItemByIndex(i);
						if (scrollItemByIndex != null)
						{
							scrollItemByIndex.SelectToggle();
						}
					}
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GenericScrollViewNew<BabelTowerQuestTabItem, int> tabScrollerView3 = this.TabScrollerView;
				if (tabScrollerView3 == null)
				{
					return;
				}
				BabelTowerQuestTabItem scrollItemByIndex2 = tabScrollerView3.GetScrollItemByIndex(0);
				if (scrollItemByIndex2 == null)
				{
					return;
				}
				scrollItemByIndex2.SelectToggle();
			}
		}, false);
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x00192448 File Offset: 0x00190648
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshQuestState);
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x00192460 File Offset: 0x00190660
	private void RefreshView()
	{
		EBabelTowerTabItem currentSelect = this.CurrentSelect;
		UUIInturnAnimController animController;
		if (currentSelect == EBabelTowerTabItem.NormalQuest)
		{
			base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(true);
			UUIInturnAnimController animController = base.GetScrollViewWithScrollbar(1).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
			Action <>9__1;
			this.NormalLoopScrollerView.RefreshByData(this.NormalSimpleList, delegate
			{
				GenericScrollViewNew<BabelTowerNormalQuestItem, int> normalLoopScrollerView = this.NormalLoopScrollerView;
				UUIItem itemByIndex = this.NormalLoopScrollerView.GetItemByIndex(0);
				Action callBack;
				if ((callBack = <>9__1) == null)
				{
					callBack = (<>9__1 = delegate()
					{
						UUIInturnAnimController animController = animController;
						if (animController == null)
						{
							return;
						}
						animController.Play("", -1, false);
					});
				}
				normalLoopScrollerView.LateScrollTo(itemByIndex, callBack, false);
			}, false);
			return;
		}
		if (currentSelect != EBabelTowerTabItem.HardQuest)
		{
			return;
		}
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(true);
		animController = (base.GetScrollViewWithScrollbar(1).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		Action <>9__3;
		this.NormalLoopScrollerView.RefreshByData(this.NormalDifficultyList, delegate
		{
			GenericScrollViewNew<BabelTowerNormalQuestItem, int> normalLoopScrollerView = this.NormalLoopScrollerView;
			UUIItem itemByIndex = this.NormalLoopScrollerView.GetItemByIndex(0);
			Action callBack;
			if ((callBack = <>9__3) == null)
			{
				callBack = (<>9__3 = delegate()
				{
					UUIInturnAnimController animController = animController;
					if (animController == null)
					{
						return;
					}
					animController.Play("", -1, false);
				});
			}
			normalLoopScrollerView.LateScrollTo(itemByIndex, callBack, false);
		}, false);
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x00192567 File Offset: 0x00190767
	private BabelTowerQuestTabItem InitTabItem()
	{
		return new BabelTowerQuestTabItem
		{
			OnClickToggleCallBack = new Action<UUIExtendToggle, int>(this.OnClickTabItem)
		};
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x00192580 File Offset: 0x00190780
	private BabelTowerNormalQuestItem InitNormalQuestItem()
	{
		return new BabelTowerNormalQuestItem();
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x00192587 File Offset: 0x00190787
	private void OnClickTabItem(UUIExtendToggle toggle, int index)
	{
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelect = (EBabelTowerTabItem)index;
		this.RefreshView();
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x001925B4 File Offset: 0x001907B4
	private void SortItemList()
	{
		BabelTowerData data = BabelTowerController.Instance.GetBabelTowerData();
		this.NormalSimpleList.Sort(delegate(int a, int b)
		{
			ActivityTask activityTask;
			data.NormalQuest.TryGetValue(a, out activityTask);
			int num = (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
			ActivityTask activityTask2;
			data.NormalQuest.TryGetValue(b, out activityTask2);
			int num2 = (activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
			return num - num2;
		});
		this.NormalDifficultyList.Sort(delegate(int a, int b)
		{
			ActivityTask activityTask;
			data.NormalQuest.TryGetValue(a, out activityTask);
			int num = (activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask != null && activityTask.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
			ActivityTask activityTask2;
			data.NormalQuest.TryGetValue(b, out activityTask2);
			int num2 = (activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskFinish) ? 0 : ((activityTask2 != null && activityTask2.Status == ActivityTaskState.ActivityTaskRunning) ? 1 : 2);
			return num - num2;
		});
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x00192605 File Offset: 0x00190805
	private void BabelTowerRefreshQuestState()
	{
		this.SortItemList();
		this.RefreshView();
	}

	// Token: 0x040036DA RID: 14042
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040036DB RID: 14043
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BabelTowerQuestTabItem, int> TabScrollerView;

	// Token: 0x040036DC RID: 14044
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BabelTowerNormalQuestItem, int> NormalLoopScrollerView;

	// Token: 0x040036DD RID: 14045
	private EBabelTowerTabItem CurrentSelect;

	// Token: 0x040036DE RID: 14046
	private readonly List<int> NormalSimpleList = new List<int>();

	// Token: 0x040036DF RID: 14047
	private readonly List<int> NormalDifficultyList = new List<int>();

	// Token: 0x040036E0 RID: 14048
	private readonly List<EBabelTowerTabItem> QuestTypeList = new List<EBabelTowerTabItem>();

	// Token: 0x040036E1 RID: 14049
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x020068DD RID: 26845
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040228FE RID: 141566
		public const int CaptionItem = 0;

		// Token: 0x040228FF RID: 141567
		public const int NormalQuestLoopScrollerView = 1;

		// Token: 0x04022900 RID: 141568
		public const int NormalQuestLoopScrollerItem = 2;

		// Token: 0x04022901 RID: 141569
		public const int TabScrollerView = 3;

		// Token: 0x04022902 RID: 141570
		public const int TabItem = 4;

		// Token: 0x04022903 RID: 141571
		public const int DailyQuestItem = 5;

		// Token: 0x04022904 RID: 141572
		public const int RefreshTimeText = 6;

		// Token: 0x04022905 RID: 141573
		public const int DailyQuestLoopScrollerView = 7;

		// Token: 0x04022906 RID: 141574
		public const int DailyQuestLoopScrollerItem = 8;
	}
}
