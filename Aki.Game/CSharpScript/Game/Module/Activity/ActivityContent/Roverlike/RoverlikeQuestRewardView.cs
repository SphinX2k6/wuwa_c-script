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
	// Token: 0x020050F1 RID: 20721
	public class RoverlikeQuestRewardView : UiViewBase
	{
		// Token: 0x06033DBB RID: 212411 RVA: 0x00E841B8 File Offset: 0x00E823B8
		[NullableContext(1)]
		public RoverlikeQuestRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033DBC RID: 212412 RVA: 0x00E841C4 File Offset: 0x00E823C4
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

		// Token: 0x06033DBD RID: 212413 RVA: 0x00E842D0 File Offset: 0x00E824D0
		protected override void OnStart()
		{
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.TaskScroll = new GenericScrollViewNew<RoverlikeQuestRewardItem, int>(base.GetScrollViewWithScrollbar(1), new Func<RoverlikeQuestRewardItem>(this.CreateTaskItem), null, false, null);
		}

		// Token: 0x06033DBE RID: 212414 RVA: 0x00E84327 File Offset: 0x00E82527
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeQuestTaskUpdate, new Action(this.OnQuestTaskUpdate));
		}

		// Token: 0x06033DBF RID: 212415 RVA: 0x00E84345 File Offset: 0x00E82545
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeQuestTaskUpdate, new Action(this.OnQuestTaskUpdate));
		}

		// Token: 0x06033DC0 RID: 212416 RVA: 0x00E84363 File Offset: 0x00E82563
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06033DC1 RID: 212417 RVA: 0x00E8436B File Offset: 0x00E8256B
		[NullableContext(1)]
		private RoverlikeQuestRewardItem CreateTaskItem()
		{
			return new RoverlikeQuestRewardItem();
		}

		// Token: 0x06033DC2 RID: 212418 RVA: 0x00E84374 File Offset: 0x00E82574
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

		// Token: 0x06033DC3 RID: 212419 RVA: 0x00E843C4 File Offset: 0x00E825C4
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

		// Token: 0x06033DC4 RID: 212420 RVA: 0x00E84414 File Offset: 0x00E82614
		private void RefreshProgress()
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x06033DC5 RID: 212421 RVA: 0x00E84434 File Offset: 0x00E82634
		private void OnQuestTaskUpdate()
		{
			this.RefreshView();
		}

		// Token: 0x06033DC6 RID: 212422 RVA: 0x00E8443C File Offset: 0x00E8263C
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

		// Token: 0x0401B762 RID: 112482
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401B763 RID: 112483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RoverlikeQuestRewardItem, int> TaskScroll;

		// Token: 0x0200ADC3 RID: 44483
		private class EComponent
		{
			// Token: 0x04035B02 RID: 219906
			public const int Caption = 0;

			// Token: 0x04035B03 RID: 219907
			public const int TaskScroll = 1;

			// Token: 0x04035B04 RID: 219908
			public const int TaskItem = 2;

			// Token: 0x04035B05 RID: 219909
			public const int RestTime = 3;

			// Token: 0x04035B06 RID: 219910
			public const int Progress = 4;

			// Token: 0x04035B07 RID: 219911
			public const int SpRewardBtn = 5;
		}
	}
}
