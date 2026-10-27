using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D4 RID: 25300
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPermanentRewardView : UiTickViewBase
	{
		// Token: 0x0603FAAB RID: 260779 RVA: 0x00F677E8 File Offset: 0x00F659E8
		public PinballPermanentRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FAAC RID: 260780 RVA: 0x00F677F4 File Offset: 0x00F659F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FAAD RID: 260781 RVA: 0x00F67880 File Offset: 0x00F65A80
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as PinballActivityData);
			PopupCaptionItem popupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			popupCaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			popupCaptionItem.SetHelpBtnActive(false);
			this.TaskLayout = new GenericScrollViewNew<PinballPermanentRewardTaskItem, PinballTaskData>(base.GetScrollViewWithScrollbar(1), new Func<PinballPermanentRewardTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x0603FAAE RID: 260782 RVA: 0x00F678EA File Offset: 0x00F65AEA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603FAAF RID: 260783 RVA: 0x00F67908 File Offset: 0x00F65B08
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0603FAB0 RID: 260784 RVA: 0x00F67926 File Offset: 0x00F65B26
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshTaskLayout(false);
		}

		// Token: 0x0603FAB1 RID: 260785 RVA: 0x00F6793E File Offset: 0x00F65B3E
		private void RefreshTaskLayout(bool isPlayAnim = false)
		{
			this.TaskLayout.RefreshByData(this.ActivityData.GetPermanentTaskList(), delegate
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}, isPlayAnim);
		}

		// Token: 0x0603FAB2 RID: 260786 RVA: 0x00F67963 File Offset: 0x00F65B63
		private PinballPermanentRewardTaskItem CreateTaskItem()
		{
			return new PinballPermanentRewardTaskItem
			{
				OnTaskRewardClick = new Func<int, UniTask>(this.OnTaskRewardBtnClick)
			};
		}

		// Token: 0x0603FAB3 RID: 260787 RVA: 0x00F6797C File Offset: 0x00F65B7C
		private UniTask OnTaskRewardBtnClick(int taskId)
		{
			PinballPermanentRewardView.<OnTaskRewardBtnClick>d__11 <OnTaskRewardBtnClick>d__;
			<OnTaskRewardBtnClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnTaskRewardBtnClick>d__.<>4__this = this;
			<OnTaskRewardBtnClick>d__.<>1__state = -1;
			<OnTaskRewardBtnClick>d__.<>t__builder.Start<PinballPermanentRewardView.<OnTaskRewardBtnClick>d__11>(ref <OnTaskRewardBtnClick>d__);
			return <OnTaskRewardBtnClick>d__.<>t__builder.Task;
		}

		// Token: 0x0603FAB4 RID: 260788 RVA: 0x00F679BF File Offset: 0x00F65BBF
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021437 RID: 136247
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x04021438 RID: 136248
		private GenericScrollViewNew<PinballPermanentRewardTaskItem, PinballTaskData> TaskLayout;

		// Token: 0x0200C4BF RID: 50367
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403B5E8 RID: 243176
			ItemCaption,
			// Token: 0x0403B5E9 RID: 243177
			RewardItemScroll,
			// Token: 0x0403B5EA RID: 243178
			RewardItem
		}
	}
}
