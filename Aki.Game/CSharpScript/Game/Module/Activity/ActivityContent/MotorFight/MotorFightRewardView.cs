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

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200642D RID: 25645
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRewardView : UiTickViewBase
	{
		// Token: 0x060407AB RID: 264107 RVA: 0x00F9AC5F File Offset: 0x00F98E5F
		public MotorFightRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060407AC RID: 264108 RVA: 0x00F9AC68 File Offset: 0x00F98E68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060407AD RID: 264109 RVA: 0x00F9AD58 File Offset: 0x00F98F58
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060407AE RID: 264110 RVA: 0x00F9AD9B File Offset: 0x00F98F9B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060407AF RID: 264111 RVA: 0x00F9ADB9 File Offset: 0x00F98FB9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060407B0 RID: 264112 RVA: 0x00F9ADD8 File Offset: 0x00F98FD8
		protected override void OnTick(float delta)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, localTextNew);
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x060407B1 RID: 264113 RVA: 0x00F9AE1B File Offset: 0x00F9901B
		private void OnRefreshCommonActivityRedDot(int activityId)
		{
			if (activityId == this.ActivityData.Id)
			{
				this.TabLayout.RefreshByData(this.ActivityData.GetMotorFightTaskTabList(), delegate
				{
					this.OnTabClickCallBack(this.CurrentTabId);
				}, false);
			}
		}

		// Token: 0x060407B2 RID: 264114 RVA: 0x00F9AE4E File Offset: 0x00F9904E
		private void RefreshTaskLayout(bool isPlayAnim = false)
		{
			this.TaskLayout.RefreshByData(this.ActivityData.GetTaskDataList(this.CurrentTabId), delegate
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}, isPlayAnim);
		}

		// Token: 0x060407B3 RID: 264115 RVA: 0x00F9AE79 File Offset: 0x00F99079
		private MotorFightTaskTabItem CreateTabItem()
		{
			return new MotorFightTaskTabItem
			{
				ActivityData = this.ActivityData,
				OnToggleClickCallBack = new Action<int>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x060407B4 RID: 264116 RVA: 0x00F9AE9E File Offset: 0x00F9909E
		private void OnTabClickCallBack(int tabId)
		{
			this.CurrentTabId = tabId;
			this.TabLayout.SelectGridProxy(this.TabLayout.GetScrollItemByKey(tabId).GridIndex, false);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x060407B5 RID: 264117 RVA: 0x00F9AED0 File Offset: 0x00F990D0
		private MotorFightTaskItem CreateTaskItem()
		{
			return new MotorFightTaskItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x060407B6 RID: 264118 RVA: 0x00F9AEE9 File Offset: 0x00F990E9
		private void OnRewardBtnClick()
		{
			this.ActivityData.RequestTaskReward(this.CurrentTabId);
		}

		// Token: 0x060407B7 RID: 264119 RVA: 0x00F9AEFC File Offset: 0x00F990FC
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021857 RID: 137303
		[Nullable(2)]
		private MotorFightActivityData ActivityData;

		// Token: 0x04021858 RID: 137304
		private int CurrentTabId;

		// Token: 0x04021859 RID: 137305
		private GenericScrollViewNew<MotorFightTaskTabItem, MotorFightTaskTab> TabLayout;

		// Token: 0x0402185A RID: 137306
		private GenericScrollViewNew<MotorFightTaskItem, MotorFightTaskData> TaskLayout;

		// Token: 0x0200C66A RID: 50794
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BE6C RID: 245356
			public const int ItemCaption = 0;

			// Token: 0x0403BE6D RID: 245357
			public const int ScrollLayoutTab = 1;

			// Token: 0x0403BE6E RID: 245358
			public const int ItemTab = 2;

			// Token: 0x0403BE6F RID: 245359
			public const int ScrollReward = 3;

			// Token: 0x0403BE70 RID: 245360
			public const int ItemReward = 4;

			// Token: 0x0403BE71 RID: 245361
			public const int TextRemainTime = 5;
		}
	}
}
