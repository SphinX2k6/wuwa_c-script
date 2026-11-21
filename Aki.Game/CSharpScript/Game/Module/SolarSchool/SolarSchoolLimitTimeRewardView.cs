using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A2A RID: 23082
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolLimitTimeRewardView : UiTickViewBase
	{
		// Token: 0x06038D7F RID: 232831 RVA: 0x00FE9E04 File Offset: 0x00FE8004
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.LookBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D80 RID: 232832 RVA: 0x00FE9F50 File Offset: 0x00FE8150
		private void LookBtnClick()
		{
			SolarSchoolActivity? config = ConfigSolarSchoolActivityById.GetConfig(this.ActivityData.Id, true);
			if (config == null)
			{
				return;
			}
			int limitAccDropId = config.Value.LimitAccDropId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(limitAccDropId);
			ItemController.Instance.OpenItemTipsByItemId(dropPackagePreviewItemList[0].ItemData.ItemId, true, null, false);
		}

		// Token: 0x06038D81 RID: 232833 RVA: 0x00FE9FB3 File Offset: 0x00FE81B3
		[NullableContext(1)]
		public SolarSchoolLimitTimeRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D82 RID: 232834 RVA: 0x00FE9FC4 File Offset: 0x00FE81C4
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolLimitTimeRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolLimitTimeRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D83 RID: 232835 RVA: 0x00FEA007 File Offset: 0x00FE8207
		[NullableContext(1)]
		private SolarSchoolRewardTaskItem CreateTaskItem()
		{
			SolarSchoolRewardTaskItem solarSchoolRewardTaskItem = new SolarSchoolRewardTaskItem();
			solarSchoolRewardTaskItem.SetActivityDataAndType(this.ActivityData, SolarSchoolTaskType.SolarSchoolLimited);
			return solarSchoolRewardTaskItem;
		}

		// Token: 0x06038D84 RID: 232836 RVA: 0x00FEA01B File Offset: 0x00FE821B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnUpdateTaskInfo));
		}

		// Token: 0x06038D85 RID: 232837 RVA: 0x00FEA039 File Offset: 0x00FE8239
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnUpdateTaskInfo));
		}

		// Token: 0x06038D86 RID: 232838 RVA: 0x00FEA057 File Offset: 0x00FE8257
		private void OnUpdateTaskInfo()
		{
			this.UpdateTaskScroll();
			this.BottomItem.RefreshView();
		}

		// Token: 0x06038D87 RID: 232839 RVA: 0x00FEA06A File Offset: 0x00FE826A
		protected override void OnStart()
		{
			this.UpdateTaskScroll();
			GenericScrollViewNew<SolarSchoolRewardTaskItem, ConditionTask> taskLayout = this.TaskLayout;
			if (taskLayout != null)
			{
				taskLayout.PlayTurnAnimation();
			}
			this.RefreshTimeText();
		}

		// Token: 0x06038D88 RID: 232840 RVA: 0x00FEA08C File Offset: 0x00FE828C
		private void UpdateTaskScroll()
		{
			List<ConditionTask> taskListBySortId = this.ActivityData.GetTaskListBySortId(SolarSchoolTaskType.SolarSchoolLimited);
			this.TaskLayout.RefreshByData(taskListBySortId, null, false);
		}

		// Token: 0x06038D89 RID: 232841 RVA: 0x00FEA0B4 File Offset: 0x00FE82B4
		protected override void OnAfterDestroy()
		{
			if (!SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				return;
			}
			SolarSchoolModel.Instance.ShowSettingView();
		}

		// Token: 0x06038D8A RID: 232842 RVA: 0x00FEA0CD File Offset: 0x00FE82CD
		protected override void OnTick(float delta)
		{
			if (this.LimitTimeRewardOn)
			{
				this.RefreshTimeText();
			}
		}

		// Token: 0x06038D8B RID: 232843 RVA: 0x00FEA0E0 File Offset: 0x00FE82E0
		private void RefreshTimeText()
		{
			if (!this.ActivityData.CheckIfInRewardTime())
			{
				this.LimitTimeRewardOn = false;
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
				return;
			}
			string item = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityData, null).Item2;
			base.GetText(6).SetText(item, true);
		}

		// Token: 0x0401DEA4 RID: 122532
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DEA5 RID: 122533
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0401DEA6 RID: 122534
		private SolarSchoolLimitTimeRewardBottomItem BottomItem;

		// Token: 0x0401DEA7 RID: 122535
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolRewardTaskItem, ConditionTask> TaskLayout;

		// Token: 0x0401DEA8 RID: 122536
		private bool LimitTimeRewardOn = true;

		// Token: 0x0200B5FA RID: 46586
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403845D RID: 230493
			public const int CaptionItem = 0;

			// Token: 0x0403845E RID: 230494
			public const int TaskScroll = 1;

			// Token: 0x0403845F RID: 230495
			public const int TaskItem = 2;

			// Token: 0x04038460 RID: 230496
			public const int SpecialTaskItem = 3;

			// Token: 0x04038461 RID: 230497
			public const int DescriptText = 4;

			// Token: 0x04038462 RID: 230498
			public const int LookBtn = 5;

			// Token: 0x04038463 RID: 230499
			public const int TimeText = 6;
		}
	}
}
