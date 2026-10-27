using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006173 RID: 24947
	public class RoverlikeQuestRewardView : UiViewBase
	{
		// Token: 0x0603F0FB RID: 258299 RVA: 0x00F3D2E4 File Offset: 0x00F3B4E4
		[NullableContext(1)]
		public RoverlikeQuestRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F0FC RID: 258300 RVA: 0x00F3D2F0 File Offset: 0x00F3B4F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnSpRewardBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F0FD RID: 258301 RVA: 0x00F3D3FC File Offset: 0x00F3B5FC
		protected override void OnStart()
		{
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.TaskScroll = new GenericScrollViewNew<RoverlikeQuestRewardItem, int>(base.GetScrollViewWithScrollbar(1), new Func<RoverlikeQuestRewardItem>(this.CreateTaskItem), null, false, null);
		}

		// Token: 0x0603F0FE RID: 258302 RVA: 0x00F3D453 File Offset: 0x00F3B653
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeQuestTaskUpdate, new Action(this.OnQuestTaskUpdate));
		}

		// Token: 0x0603F0FF RID: 258303 RVA: 0x00F3D471 File Offset: 0x00F3B671
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeQuestTaskUpdate, new Action(this.OnQuestTaskUpdate));
		}

		// Token: 0x0603F100 RID: 258304 RVA: 0x00F3D48F File Offset: 0x00F3B68F
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0603F101 RID: 258305 RVA: 0x00F3D497 File Offset: 0x00F3B697
		[NullableContext(1)]
		private RoverlikeQuestRewardItem CreateTaskItem()
		{
			return new RoverlikeQuestRewardItem();
		}

		// Token: 0x0603F102 RID: 258306 RVA: 0x00F3D4A0 File Offset: 0x00F3B6A0
		private void RefreshView()
		{
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			List<int> sortedTaskIdList = currentActivityData.QuestData.GetSortedTaskIdList();
			this.TaskScroll.RefreshByData(sortedTaskIdList, null, false);
			this.TaskScroll.PlayTurnAnimation();
			this.RefreshRestTime();
			this.RefreshProgress();
		}

		// Token: 0x0603F103 RID: 258307 RVA: 0x00F3D4F0 File Offset: 0x00F3B6F0
		private void RefreshRestTime()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				text.SetText("", true);
				return;
			}
			string item = ActivityModel.Instance.GetTimeVisibleAndRemainTime(currentActivityData, null).Item2;
			text.SetText(item, true);
		}

		// Token: 0x0603F104 RID: 258308 RVA: 0x00F3D540 File Offset: 0x00F3B740
		private void RefreshProgress()
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603F105 RID: 258309 RVA: 0x00F3D560 File Offset: 0x00F3B760
		private void OnQuestTaskUpdate()
		{
			this.RefreshView();
		}

		// Token: 0x0603F106 RID: 258310 RVA: 0x00F3D568 File Offset: 0x00F3B768
		private void OnSpRewardBtnClick()
		{
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			RoverRogueActivity? activityParamConfig = RoverlikeConfig.Instance.GetActivityParamConfig(currentActivityData.Id);
			int num = (activityParamConfig != null) ? activityParamConfig.GetValueOrDefault().TaskCoreReward : 0;
			if (num <= 0)
			{
				return;
			}
			ItemController.Instance.OpenTitleTipsByItemId(num);
		}

		// Token: 0x04020E35 RID: 134709
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04020E36 RID: 134710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RoverlikeQuestRewardItem, int> TaskScroll;

		// Token: 0x0200C3DC RID: 50140
		private class EComponent
		{
			// Token: 0x0403B1A1 RID: 242081
			public const int Caption = 0;

			// Token: 0x0403B1A2 RID: 242082
			public const int TaskScroll = 1;

			// Token: 0x0403B1A3 RID: 242083
			public const int TaskItem = 2;

			// Token: 0x0403B1A4 RID: 242084
			public const int RestTime = 3;

			// Token: 0x0403B1A5 RID: 242085
			public const int Progress = 4;

			// Token: 0x0403B1A6 RID: 242086
			public const int SpRewardBtn = 5;
		}
	}
}
