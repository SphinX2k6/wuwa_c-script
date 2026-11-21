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
	// Token: 0x02005252 RID: 21074
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPermanentRewardView : UiTickViewBase
	{
		// Token: 0x0603476C RID: 214892 RVA: 0x00EAE744 File Offset: 0x00EAC944
		public PinballPermanentRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603476D RID: 214893 RVA: 0x00EAE750 File Offset: 0x00EAC950
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

		// Token: 0x0603476E RID: 214894 RVA: 0x00EAE7DC File Offset: 0x00EAC9DC
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as PinballActivityData);
			PopupCaptionItem popupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			popupCaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			popupCaptionItem.SetHelpBtnActive(false);
			this.TaskLayout = new GenericScrollViewNew<PinballPermanentRewardTaskItem, PinballTaskData>(base.GetScrollViewWithScrollbar(1), new Func<PinballPermanentRewardTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshTaskLayout(true);
		}

		// Token: 0x0603476F RID: 214895 RVA: 0x00EAE846 File Offset: 0x00EACA46
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06034770 RID: 214896 RVA: 0x00EAE864 File Offset: 0x00EACA64
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06034771 RID: 214897 RVA: 0x00EAE882 File Offset: 0x00EACA82
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshTaskLayout(false);
		}

		// Token: 0x06034772 RID: 214898 RVA: 0x00EAE89A File Offset: 0x00EACA9A
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

		// Token: 0x06034773 RID: 214899 RVA: 0x00EAE8BF File Offset: 0x00EACABF
		private PinballPermanentRewardTaskItem CreateTaskItem()
		{
			return new PinballPermanentRewardTaskItem
			{
				OnTaskRewardClick = new Func<int, UniTask>(this.OnTaskRewardBtnClick)
			};
		}

		// Token: 0x06034774 RID: 214900 RVA: 0x00EAE8D8 File Offset: 0x00EACAD8
		private UniTask OnTaskRewardBtnClick(int taskId)
		{
			PinballPermanentRewardView.<OnTaskRewardBtnClick>d__11 <OnTaskRewardBtnClick>d__;
			<OnTaskRewardBtnClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnTaskRewardBtnClick>d__.<>4__this = this;
			<OnTaskRewardBtnClick>d__.<>1__state = -1;
			<OnTaskRewardBtnClick>d__.<>t__builder.Start<PinballPermanentRewardView.<OnTaskRewardBtnClick>d__11>(ref <OnTaskRewardBtnClick>d__);
			return <OnTaskRewardBtnClick>d__.<>t__builder.Task;
		}

		// Token: 0x06034775 RID: 214901 RVA: 0x00EAE91B File Offset: 0x00EACB1B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BD66 RID: 114022
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x0401BD67 RID: 114023
		private GenericScrollViewNew<PinballPermanentRewardTaskItem, PinballTaskData> TaskLayout;

		// Token: 0x0200AEA6 RID: 44710
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035F4A RID: 221002
			ItemCaption,
			// Token: 0x04035F4B RID: 221003
			RewardItemScroll,
			// Token: 0x04035F4C RID: 221004
			RewardItem
		}
	}
}
