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
	// Token: 0x020053AB RID: 21419
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRewardView : UiTickViewBase
	{
		// Token: 0x0603546C RID: 218220 RVA: 0x00EE1BFF File Offset: 0x00EDFDFF
		public MotorFightRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603546D RID: 218221 RVA: 0x00EE1C08 File Offset: 0x00EDFE08
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

		// Token: 0x0603546E RID: 218222 RVA: 0x00EE1CF8 File Offset: 0x00EDFEF8
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603546F RID: 218223 RVA: 0x00EE1D3B File Offset: 0x00EDFF3B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06035470 RID: 218224 RVA: 0x00EE1D59 File Offset: 0x00EDFF59
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06035471 RID: 218225 RVA: 0x00EE1D78 File Offset: 0x00EDFF78
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

		// Token: 0x06035472 RID: 218226 RVA: 0x00EE1DBB File Offset: 0x00EDFFBB
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

		// Token: 0x06035473 RID: 218227 RVA: 0x00EE1DEE File Offset: 0x00EDFFEE
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

		// Token: 0x06035474 RID: 218228 RVA: 0x00EE1E19 File Offset: 0x00EE0019
		private MotorFightTaskTabItem CreateTabItem()
		{
			return new MotorFightTaskTabItem
			{
				ActivityData = this.ActivityData,
				OnToggleClickCallBack = new Action<int>(this.OnTabClickCallBack)
			};
		}

		// Token: 0x06035475 RID: 218229 RVA: 0x00EE1E3E File Offset: 0x00EE003E
		private void OnTabClickCallBack(int tabId)
		{
			this.CurrentTabId = tabId;
			this.TabLayout.SelectGridProxy(this.TabLayout.GetScrollItemByKey(tabId).GridIndex, false);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x06035476 RID: 218230 RVA: 0x00EE1E70 File Offset: 0x00EE0070
		private MotorFightTaskItem CreateTaskItem()
		{
			return new MotorFightTaskItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x06035477 RID: 218231 RVA: 0x00EE1E89 File Offset: 0x00EE0089
		private void OnRewardBtnClick()
		{
			this.ActivityData.RequestTaskReward(this.CurrentTabId);
		}

		// Token: 0x06035478 RID: 218232 RVA: 0x00EE1E9C File Offset: 0x00EE009C
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C186 RID: 115078
		[Nullable(2)]
		private MotorFightActivityData ActivityData;

		// Token: 0x0401C187 RID: 115079
		private int CurrentTabId;

		// Token: 0x0401C188 RID: 115080
		private GenericScrollViewNew<MotorFightTaskTabItem, MotorFightTaskTab> TabLayout;

		// Token: 0x0401C189 RID: 115081
		private GenericScrollViewNew<MotorFightTaskItem, MotorFightTaskData> TaskLayout;

		// Token: 0x0200B051 RID: 45137
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040367C9 RID: 223177
			public const int ItemCaption = 0;

			// Token: 0x040367CA RID: 223178
			public const int ScrollLayoutTab = 1;

			// Token: 0x040367CB RID: 223179
			public const int ItemTab = 2;

			// Token: 0x040367CC RID: 223180
			public const int ScrollReward = 3;

			// Token: 0x040367CD RID: 223181
			public const int ItemReward = 4;

			// Token: 0x040367CE RID: 223182
			public const int TextRemainTime = 5;
		}
	}
}
