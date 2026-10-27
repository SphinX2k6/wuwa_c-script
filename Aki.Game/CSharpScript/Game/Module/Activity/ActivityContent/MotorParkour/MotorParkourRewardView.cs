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

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063FB RID: 25595
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRewardView : UiTickViewBase
	{
		// Token: 0x060405ED RID: 263661 RVA: 0x00F922FA File Offset: 0x00F904FA
		public MotorParkourRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060405EE RID: 263662 RVA: 0x00F92310 File Offset: 0x00F90510
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

		// Token: 0x060405EF RID: 263663 RVA: 0x00F923FD File Offset: 0x00F905FD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060405F0 RID: 263664 RVA: 0x00F9241B File Offset: 0x00F9061B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060405F1 RID: 263665 RVA: 0x00F9243C File Offset: 0x00F9063C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourRewardView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourRewardView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060405F2 RID: 263666 RVA: 0x00F92480 File Offset: 0x00F90680
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

		// Token: 0x060405F3 RID: 263667 RVA: 0x00F924C4 File Offset: 0x00F906C4
		private void RefreshTaskLayout()
		{
			List<MotorParkourTaskData> taskList = this.CurLevelData.TaskList;
			this.TaskScrollView.RefreshByData(taskList, false, delegate
			{
				this.TaskScrollView.ScrollToGridIndex(0, true);
			}, true);
		}

		// Token: 0x060405F4 RID: 263668 RVA: 0x00F924F7 File Offset: 0x00F906F7
		private void OnRefreshCommonActivityRedDot(int _)
		{
			this.TabScrollView.RefreshAllGridProxies();
			this.RefreshTaskLayout();
		}

		// Token: 0x060405F5 RID: 263669 RVA: 0x00F9250C File Offset: 0x00F9070C
		private void OnTabClickCallBack(MotorParkourLevelData tab)
		{
			this.CurLevelData = tab2;
			int gridIndex = this.TabList.FindIndex((MotorParkourLevelData tab) => tab.Id == this.CurLevelData.Id);
			this.TabScrollView.SelectGridProxy(gridIndex, false);
			this.RefreshTaskLayout();
		}

		// Token: 0x060405F6 RID: 263670 RVA: 0x00F9254B File Offset: 0x00F9074B
		private MotorParkourTaskTabItem CreateTabItem()
		{
			return new MotorParkourTaskTabItem
			{
				OnToggleCallback = new Action<MotorParkourLevelData>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x060405F7 RID: 263671 RVA: 0x00F92564 File Offset: 0x00F90764
		private MotorParkourTaskItem OnCreateTaskItem()
		{
			return new MotorParkourTaskItem();
		}

		// Token: 0x060405F8 RID: 263672 RVA: 0x00F9256B File Offset: 0x00F9076B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040217AF RID: 137135
		private MotorParkourActivityData ActivityData;

		// Token: 0x040217B0 RID: 137136
		private List<MotorParkourLevelData> TabList = new List<MotorParkourLevelData>();

		// Token: 0x040217B1 RID: 137137
		private MotorParkourLevelData CurLevelData;

		// Token: 0x040217B2 RID: 137138
		private LoopScrollView<MotorParkourTaskTabItem, MotorParkourLevelData> TabScrollView;

		// Token: 0x040217B3 RID: 137139
		private LoopScrollView<MotorParkourTaskItem, MotorParkourTaskData> TaskScrollView;

		// Token: 0x0200C61B RID: 50715
		public interface IMotorParkourRewardViewData
		{
			// Token: 0x1700A282 RID: 41602
			// (get) Token: 0x06050C9D RID: 330909
			// (set) Token: 0x06050C9E RID: 330910
			MotorParkourActivityData ActivityData { get; set; }

			// Token: 0x1700A283 RID: 41603
			// (get) Token: 0x06050C9F RID: 330911
			// (set) Token: 0x06050CA0 RID: 330912
			MotorParkourLevelData SelectLevelData { get; set; }
		}

		// Token: 0x0200C61C RID: 50716
		[Nullable(0)]
		public class MotorParkourRewardViewData : MotorParkourRewardView.IMotorParkourRewardViewData
		{
			// Token: 0x1700A284 RID: 41604
			// (get) Token: 0x06050CA1 RID: 330913 RVA: 0x015CBDCE File Offset: 0x015C9FCE
			// (set) Token: 0x06050CA2 RID: 330914 RVA: 0x015CBDD6 File Offset: 0x015C9FD6
			public MotorParkourActivityData ActivityData { get; set; }

			// Token: 0x1700A285 RID: 41605
			// (get) Token: 0x06050CA3 RID: 330915 RVA: 0x015CBDDF File Offset: 0x015C9FDF
			// (set) Token: 0x06050CA4 RID: 330916 RVA: 0x015CBDE7 File Offset: 0x015C9FE7
			public MotorParkourLevelData SelectLevelData { get; set; }
		}

		// Token: 0x0200C61D RID: 50717
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCFB RID: 244987
			public const int ItemCaption = 0;

			// Token: 0x0403BCFC RID: 244988
			public const int LoopScrollLayoutTab = 1;

			// Token: 0x0403BCFD RID: 244989
			public const int ItemContent = 2;

			// Token: 0x0403BCFE RID: 244990
			public const int ItemTab = 3;

			// Token: 0x0403BCFF RID: 244991
			public const int LoopScrollLayoutTask = 4;

			// Token: 0x0403BD00 RID: 244992
			public const int ItemContent2 = 5;

			// Token: 0x0403BD01 RID: 244993
			public const int ItemTask = 6;

			// Token: 0x0403BD02 RID: 244994
			public const int TextRemainTime = 7;
		}
	}
}
