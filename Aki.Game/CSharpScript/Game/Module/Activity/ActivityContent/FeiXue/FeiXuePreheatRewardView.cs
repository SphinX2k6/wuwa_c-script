using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055C6 RID: 21958
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXuePreheatRewardView : UiTickViewBase
	{
		// Token: 0x0603669B RID: 222875 RVA: 0x00F31432 File Offset: 0x00F2F632
		public FeiXuePreheatRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603669C RID: 222876 RVA: 0x00F3143C File Offset: 0x00F2F63C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0603669D RID: 222877 RVA: 0x00F314AC File Offset: 0x00F2F6AC
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as ActivityFeiXuePreheatData);
			new PopupCaptionItem(base.GetItem(0)).SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.TaskLayout = new GenericScrollViewNew<FeiXuePreheatTaskItem, FeiXuePreheatTaskData>(base.GetScrollViewWithScrollbar(1), new Func<FeiXuePreheatTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x0603669E RID: 222878 RVA: 0x00F3150F File Offset: 0x00F2F70F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603669F RID: 222879 RVA: 0x00F3152D File Offset: 0x00F2F72D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060366A0 RID: 222880 RVA: 0x00F3154C File Offset: 0x00F2F74C
		protected override void OnTick(float delta)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, localTextNew);
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x060366A1 RID: 222881 RVA: 0x00F3158F File Offset: 0x00F2F78F
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshTaskLayout(false);
		}

		// Token: 0x060366A2 RID: 222882 RVA: 0x00F315A7 File Offset: 0x00F2F7A7
		private void RefreshTaskLayout(bool isPlayAnim = false)
		{
			this.TaskLayout.RefreshByData(this.ActivityData.GetTaskDataSortList(), delegate
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}, isPlayAnim);
		}

		// Token: 0x060366A3 RID: 222883 RVA: 0x00F315CC File Offset: 0x00F2F7CC
		private FeiXuePreheatTaskItem CreateTaskItem()
		{
			return new FeiXuePreheatTaskItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x060366A4 RID: 222884 RVA: 0x00F315E5 File Offset: 0x00F2F7E5
		private void OnRewardBtnClick()
		{
			ActivityFeiXuePreheatController.Instance.RequestTaskReward(this.ActivityData.Id, null);
		}

		// Token: 0x060366A5 RID: 222885 RVA: 0x00F315FD File Offset: 0x00F2F7FD
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401CBA1 RID: 117665
		[Nullable(2)]
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x0401CBA2 RID: 117666
		private GenericScrollViewNew<FeiXuePreheatTaskItem, FeiXuePreheatTaskData> TaskLayout;
	}
}
