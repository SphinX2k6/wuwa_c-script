using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200639B RID: 25499
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorParkourRewardView : UiTickViewBase
	{
		// Token: 0x06040219 RID: 262681 RVA: 0x00F8679A File Offset: 0x00F8499A
		public MultiMotorParkourRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604021A RID: 262682 RVA: 0x00F867B0 File Offset: 0x00F849B0
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

		// Token: 0x0604021B RID: 262683 RVA: 0x00F8689D File Offset: 0x00F84A9D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
			EventSystem.Instance.Add(EEventName.MultiMotorRefresh, new Action(this.OnMultiMotorRefresh));
		}

		// Token: 0x0604021C RID: 262684 RVA: 0x00F868D7 File Offset: 0x00F84AD7
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
			EventSystem.Instance.Remove(EEventName.MultiMotorRefresh, new Action(this.OnMultiMotorRefresh));
		}

		// Token: 0x0604021D RID: 262685 RVA: 0x00F86914 File Offset: 0x00F84B14
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorParkourRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorParkourRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604021E RID: 262686 RVA: 0x00F86958 File Offset: 0x00F84B58
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

		// Token: 0x0604021F RID: 262687 RVA: 0x00F8699C File Offset: 0x00F84B9C
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

		// Token: 0x06040220 RID: 262688 RVA: 0x00F86A10 File Offset: 0x00F84C10
		private List<MultiMotorTaskData> SortTaskList(List<MultiMotorTaskData> taskList)
		{
			return taskList.OrderBy(delegate(MultiMotorTaskData task)
			{
				if (task.IsFinished)
				{
					return 0;
				}
				if (task.IsReceived)
				{
					return 2;
				}
				return 1;
			}).ThenBy((MultiMotorTaskData task) => task.TaskId).ToList<MultiMotorTaskData>();
		}

		// Token: 0x06040221 RID: 262689 RVA: 0x00F86A6B File Offset: 0x00F84C6B
		private void OnRefreshCommonActivityRedDot(int uid)
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x06040222 RID: 262690 RVA: 0x00F86A7E File Offset: 0x00F84C7E
		private void OnMultiMotorRefresh()
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x06040223 RID: 262691 RVA: 0x00F86A94 File Offset: 0x00F84C94
		private void OnTabClickCallBack(int data)
		{
			this.CurTabData = data;
			int gridIndex = this.TabList.IndexOf(data);
			this.TabScrollView.SelectGridProxy(gridIndex, false);
			this.RefreshTaskLayout();
		}

		// Token: 0x06040224 RID: 262692 RVA: 0x00F86AC8 File Offset: 0x00F84CC8
		private MultiMotorParkourTaskTabItem CreateTabItem()
		{
			return new MultiMotorParkourTaskTabItem
			{
				ActivityData = this.ActivityData,
				OnToggleCallback = new Action<int>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x06040225 RID: 262693 RVA: 0x00F86AED File Offset: 0x00F84CED
		private MultiMotorParkourTaskItem OnCreateTaskItem()
		{
			return new MultiMotorParkourTaskItem();
		}

		// Token: 0x06040226 RID: 262694 RVA: 0x00F86AF4 File Offset: 0x00F84CF4
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040216A5 RID: 136869
		private MultiMotorData ActivityData;

		// Token: 0x040216A6 RID: 136870
		private List<int> TabList = new List<int>();

		// Token: 0x040216A7 RID: 136871
		private int CurTabData;

		// Token: 0x040216A8 RID: 136872
		private LoopScrollView<MultiMotorParkourTaskTabItem, int> TabScrollView;

		// Token: 0x040216A9 RID: 136873
		private LoopScrollView<MultiMotorParkourTaskItem, MultiMotorTaskData> TaskScrollView;

		// Token: 0x0200C5B2 RID: 50610
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BB02 RID: 244482
			public const int ItemCaption = 0;

			// Token: 0x0403BB03 RID: 244483
			public const int LoopScrollLayoutTab = 1;

			// Token: 0x0403BB04 RID: 244484
			public const int ItemContent = 2;

			// Token: 0x0403BB05 RID: 244485
			public const int ItemTab = 3;

			// Token: 0x0403BB06 RID: 244486
			public const int LoopScrollLayoutTask = 4;

			// Token: 0x0403BB07 RID: 244487
			public const int ItemContent2 = 5;

			// Token: 0x0403BB08 RID: 244488
			public const int ItemTask = 6;

			// Token: 0x0403BB09 RID: 244489
			public const int TextRemainTime = 7;
		}
	}
}
