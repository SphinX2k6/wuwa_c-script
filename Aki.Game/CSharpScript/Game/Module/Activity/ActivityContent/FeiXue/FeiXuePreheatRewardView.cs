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
	// Token: 0x02006648 RID: 26184
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXuePreheatRewardView : UiTickViewBase
	{
		// Token: 0x060419D6 RID: 268758 RVA: 0x00FEA379 File Offset: 0x00FE8579
		public FeiXuePreheatRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060419D7 RID: 268759 RVA: 0x00FEA384 File Offset: 0x00FE8584
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

		// Token: 0x060419D8 RID: 268760 RVA: 0x00FEA3F4 File Offset: 0x00FE85F4
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as ActivityFeiXuePreheatData);
			new PopupCaptionItem(base.GetItem(0)).SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.TaskLayout = new GenericScrollViewNew<FeiXuePreheatTaskItem, FeiXuePreheatTaskData>(base.GetScrollViewWithScrollbar(1), new Func<FeiXuePreheatTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x060419D9 RID: 268761 RVA: 0x00FEA457 File Offset: 0x00FE8657
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060419DA RID: 268762 RVA: 0x00FEA475 File Offset: 0x00FE8675
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060419DB RID: 268763 RVA: 0x00FEA494 File Offset: 0x00FE8694
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

		// Token: 0x060419DC RID: 268764 RVA: 0x00FEA4D7 File Offset: 0x00FE86D7
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshTaskLayout(false);
		}

		// Token: 0x060419DD RID: 268765 RVA: 0x00FEA4EF File Offset: 0x00FE86EF
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

		// Token: 0x060419DE RID: 268766 RVA: 0x00FEA514 File Offset: 0x00FE8714
		private FeiXuePreheatTaskItem CreateTaskItem()
		{
			return new FeiXuePreheatTaskItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x060419DF RID: 268767 RVA: 0x00FEA52D File Offset: 0x00FE872D
		private void OnRewardBtnClick()
		{
			ActivityFeiXuePreheatController.Instance.RequestTaskReward(this.ActivityData.Id, null);
		}

		// Token: 0x060419E0 RID: 268768 RVA: 0x00FEA545 File Offset: 0x00FE8745
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022270 RID: 139888
		[Nullable(2)]
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x04022271 RID: 139889
		private GenericScrollViewNew<FeiXuePreheatTaskItem, FeiXuePreheatTaskData> TaskLayout;
	}
}
