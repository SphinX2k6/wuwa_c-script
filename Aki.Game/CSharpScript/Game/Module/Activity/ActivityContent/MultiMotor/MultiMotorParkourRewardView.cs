using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005319 RID: 21273
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorParkourRewardView : UiTickViewBase
	{
		// Token: 0x06034EDA RID: 216794 RVA: 0x00ECD70E File Offset: 0x00ECB90E
		public MultiMotorParkourRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034EDB RID: 216795 RVA: 0x00ECD724 File Offset: 0x00ECB924
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034EDC RID: 216796 RVA: 0x00ECD811 File Offset: 0x00ECBA11
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
			EventSystem.Instance.Add(EEventName.MultiMotorRefresh, new Action(this.OnMultiMotorRefresh));
		}

		// Token: 0x06034EDD RID: 216797 RVA: 0x00ECD84B File Offset: 0x00ECBA4B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
			EventSystem.Instance.Remove(EEventName.MultiMotorRefresh, new Action(this.OnMultiMotorRefresh));
		}

		// Token: 0x06034EDE RID: 216798 RVA: 0x00ECD888 File Offset: 0x00ECBA88
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorParkourRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorParkourRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034EDF RID: 216799 RVA: 0x00ECD8CC File Offset: 0x00ECBACC
		protected override void OnTick(float delta)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, localTextNew);
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x06034EE0 RID: 216800 RVA: 0x00ECD910 File Offset: 0x00ECBB10
		private void RefreshTaskLayout()
		{
			List<MultiMotorTaskData> taskList;
			if (this.CurTabData == 0)
			{
				taskList = this.ActivityData.GetGlobalTaskList();
			}
			else
			{
				MultiMotorLevelData multiMotorLevelData;
				this.ActivityData.LevelDataMap.TryGetValue(this.CurTabData, out multiMotorLevelData);
				taskList = (((multiMotorLevelData != null) ? multiMotorLevelData.TaskList : null) ?? new List<MultiMotorTaskData>());
			}
			this.TaskScrollView.RefreshByData(this.SortTaskList(taskList), false, delegate
			{
				this.TaskScrollView.ScrollToGridIndex(0, true);
			}, true);
		}

		// Token: 0x06034EE1 RID: 216801 RVA: 0x00ECD982 File Offset: 0x00ECBB82
		private List<MultiMotorTaskData> SortTaskList(List<MultiMotorTaskData> taskList)
		{
			return NoLinq.SortToList<MultiMotorTaskData>(taskList, delegate(MultiMotorTaskData left, MultiMotorTaskData right)
			{
				int num = left.IsFinished ? 0 : (left.IsReceived ? 2 : 1);
				int value = right.IsFinished ? 0 : (right.IsReceived ? 2 : 1);
				int num2 = num.CompareTo(value);
				if (num2 == 0)
				{
					return left.TaskId.CompareTo(right.TaskId);
				}
				return num2;
			});
		}

		// Token: 0x06034EE2 RID: 216802 RVA: 0x00ECD9A9 File Offset: 0x00ECBBA9
		private void OnRefreshCommonActivityRedDot(int uid)
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x06034EE3 RID: 216803 RVA: 0x00ECD9BC File Offset: 0x00ECBBBC
		private void OnMultiMotorRefresh()
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x06034EE4 RID: 216804 RVA: 0x00ECD9D0 File Offset: 0x00ECBBD0
		private void OnTabClickCallBack(int data)
		{
			this.CurTabData = data;
			int gridIndex = this.TabList.IndexOf(data);
			this.TabScrollView.SelectGridProxy(gridIndex, false);
			this.RefreshTaskLayout();
		}

		// Token: 0x06034EE5 RID: 216805 RVA: 0x00ECDA04 File Offset: 0x00ECBC04
		private MultiMotorParkourTaskTabItem CreateTabItem()
		{
			return new MultiMotorParkourTaskTabItem
			{
				ActivityData = this.ActivityData,
				OnToggleCallback = new Action<int>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x06034EE6 RID: 216806 RVA: 0x00ECDA29 File Offset: 0x00ECBC29
		private MultiMotorParkourTaskItem OnCreateTaskItem()
		{
			return new MultiMotorParkourTaskItem();
		}

		// Token: 0x06034EE7 RID: 216807 RVA: 0x00ECDA30 File Offset: 0x00ECBC30
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BFD4 RID: 114644
		private MultiMotorData ActivityData;

		// Token: 0x0401BFD5 RID: 114645
		private List<int> TabList = new List<int>();

		// Token: 0x0401BFD6 RID: 114646
		private int CurTabData;

		// Token: 0x0401BFD7 RID: 114647
		private LoopScrollView<MultiMotorParkourTaskTabItem, int> TabScrollView;

		// Token: 0x0401BFD8 RID: 114648
		private LoopScrollView<MultiMotorParkourTaskItem, MultiMotorTaskData> TaskScrollView;

		// Token: 0x0200AF99 RID: 44953
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036463 RID: 222307
			public const int ItemCaption = 0;

			// Token: 0x04036464 RID: 222308
			public const int LoopScrollLayoutTab = 1;

			// Token: 0x04036465 RID: 222309
			public const int ItemContent = 2;

			// Token: 0x04036466 RID: 222310
			public const int ItemTab = 3;

			// Token: 0x04036467 RID: 222311
			public const int LoopScrollLayoutTask = 4;

			// Token: 0x04036468 RID: 222312
			public const int ItemContent2 = 5;

			// Token: 0x04036469 RID: 222313
			public const int ItemTask = 6;

			// Token: 0x0403646A RID: 222314
			public const int TextRemainTime = 7;
		}
	}
}
