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

// Token: 0x0200117D RID: 4477
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerQuestView : UiViewBase
{
	// Token: 0x0600765A RID: 30298 RVA: 0x00189584 File Offset: 0x00187784
	public BabelTowerQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600765B RID: 30299 RVA: 0x001895B0 File Offset: 0x001877B0
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

	// Token: 0x0600765C RID: 30300 RVA: 0x00189701 File Offset: 0x00187901
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x0600765D RID: 30301 RVA: 0x0018971F File Offset: 0x0018791F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(this.BabelTowerRefreshQuestState));
	}

	// Token: 0x0600765E RID: 30302 RVA: 0x00189740 File Offset: 0x00187940
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerQuestView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerQuestView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600765F RID: 30303 RVA: 0x00189784 File Offset: 0x00187984
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

	// Token: 0x06007660 RID: 30304 RVA: 0x00189898 File Offset: 0x00187A98
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshQuestState);
	}

	// Token: 0x06007661 RID: 30305 RVA: 0x001898B0 File Offset: 0x00187AB0
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

	// Token: 0x06007662 RID: 30306 RVA: 0x001899B7 File Offset: 0x00187BB7
	private BabelTowerQuestTabItem InitTabItem()
	{
		return new BabelTowerQuestTabItem
		{
			OnClickToggleCallBack = new Action<UUIExtendToggle, int>(this.OnClickTabItem)
		};
	}

	// Token: 0x06007663 RID: 30307 RVA: 0x001899D0 File Offset: 0x00187BD0
	private BabelTowerNormalQuestItem InitNormalQuestItem()
	{
		return new BabelTowerNormalQuestItem();
	}

	// Token: 0x06007664 RID: 30308 RVA: 0x001899D7 File Offset: 0x00187BD7
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

	// Token: 0x06007665 RID: 30309 RVA: 0x00189A04 File Offset: 0x00187C04
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

	// Token: 0x06007666 RID: 30310 RVA: 0x00189A55 File Offset: 0x00187C55
	private void BabelTowerRefreshQuestState()
	{
		this.SortItemList();
		this.RefreshView();
	}

	// Token: 0x04003641 RID: 13889
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003642 RID: 13890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BabelTowerQuestTabItem, int> TabScrollerView;

	// Token: 0x04003643 RID: 13891
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<BabelTowerNormalQuestItem, int> NormalLoopScrollerView;

	// Token: 0x04003644 RID: 13892
	private EBabelTowerTabItem CurrentSelect;

	// Token: 0x04003645 RID: 13893
	private readonly List<int> NormalSimpleList = new List<int>();

	// Token: 0x04003646 RID: 13894
	private readonly List<int> NormalDifficultyList = new List<int>();

	// Token: 0x04003647 RID: 13895
	private readonly List<EBabelTowerTabItem> QuestTypeList = new List<EBabelTowerTabItem>();

	// Token: 0x04003648 RID: 13896
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x02007750 RID: 30544
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040275C5 RID: 161221
		public const int CaptionItem = 0;

		// Token: 0x040275C6 RID: 161222
		public const int NormalQuestLoopScrollerView = 1;

		// Token: 0x040275C7 RID: 161223
		public const int NormalQuestLoopScrollerItem = 2;

		// Token: 0x040275C8 RID: 161224
		public const int TabScrollerView = 3;

		// Token: 0x040275C9 RID: 161225
		public const int TabItem = 4;

		// Token: 0x040275CA RID: 161226
		public const int DailyQuestItem = 5;

		// Token: 0x040275CB RID: 161227
		public const int RefreshTimeText = 6;

		// Token: 0x040275CC RID: 161228
		public const int DailyQuestLoopScrollerView = 7;

		// Token: 0x040275CD RID: 161229
		public const int DailyQuestLoopScrollerItem = 8;
	}
}
