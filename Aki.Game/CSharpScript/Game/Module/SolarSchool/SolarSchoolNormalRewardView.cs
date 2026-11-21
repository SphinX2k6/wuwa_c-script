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
	// Token: 0x02005A31 RID: 23089
	public class SolarSchoolNormalRewardView : UiViewBase
	{
		// Token: 0x06038E0F RID: 232975 RVA: 0x00FED420 File Offset: 0x00FEB620
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.LookBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038E10 RID: 232976 RVA: 0x00FED508 File Offset: 0x00FEB708
		private void LookBtnClick()
		{
			SolarSchoolTask? config = ConfigSolarSchoolTaskById.GetConfig(this.LookTaskId.Value, true);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.Value.DropId);
			ItemController.Instance.OpenItemTipsByItemId(dropPackagePreviewItemList[1].ItemData.ItemId, true, null, false);
		}

		// Token: 0x06038E11 RID: 232977 RVA: 0x00FED55F File Offset: 0x00FEB75F
		[NullableContext(1)]
		public SolarSchoolNormalRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038E12 RID: 232978 RVA: 0x00FED568 File Offset: 0x00FEB768
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolNormalRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolNormalRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E13 RID: 232979 RVA: 0x00FED5AB File Offset: 0x00FEB7AB
		[NullableContext(1)]
		private SolarSchoolRewardTaskItem CreateTaskItem()
		{
			SolarSchoolRewardTaskItem solarSchoolRewardTaskItem = new SolarSchoolRewardTaskItem();
			solarSchoolRewardTaskItem.SetActivityDataAndType(this.ActivityData, SolarSchoolTaskType.SolarSchoolResident);
			return solarSchoolRewardTaskItem;
		}

		// Token: 0x06038E14 RID: 232980 RVA: 0x00FED5BF File Offset: 0x00FEB7BF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnUpdateTaskInfo));
		}

		// Token: 0x06038E15 RID: 232981 RVA: 0x00FED5DD File Offset: 0x00FEB7DD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnUpdateTaskInfo));
		}

		// Token: 0x06038E16 RID: 232982 RVA: 0x00FED5FB File Offset: 0x00FEB7FB
		private void OnUpdateTaskInfo()
		{
			this.UpdateTaskScroll();
		}

		// Token: 0x06038E17 RID: 232983 RVA: 0x00FED603 File Offset: 0x00FEB803
		protected override void OnStart()
		{
			this.UpdateTaskScroll();
			GenericScrollViewNew<SolarSchoolRewardTaskItem, ConditionTask> taskLayout = this.TaskLayout;
			if (taskLayout == null)
			{
				return;
			}
			taskLayout.PlayTurnAnimation();
		}

		// Token: 0x06038E18 RID: 232984 RVA: 0x00FED61C File Offset: 0x00FEB81C
		private void UpdateTaskScroll()
		{
			List<ConditionTask> taskList = this.ActivityData.GetTaskList(SolarSchoolTaskType.SolarSchoolResident);
			this.TaskLayout.RefreshByData(taskList, null, false);
			ConditionTask conditionTask = null;
			foreach (ConditionTask conditionTask2 in taskList)
			{
				SolarSchoolTask? config = ConfigSolarSchoolTaskById.GetConfig(conditionTask2.Id, true);
				if (config != null && config.GetValueOrDefault().SortId == 1)
				{
					conditionTask = conditionTask2;
					break;
				}
			}
			this.LookTaskId = ((conditionTask != null) ? new int?(conditionTask.Id) : null);
		}

		// Token: 0x06038E19 RID: 232985 RVA: 0x00FED6D4 File Offset: 0x00FEB8D4
		protected override void OnAfterDestroy()
		{
			if (!SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				return;
			}
			SolarSchoolModel.Instance.ShowSettingView();
		}

		// Token: 0x0401DEE0 RID: 122592
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DEE1 RID: 122593
		[Nullable(2)]
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0401DEE2 RID: 122594
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolRewardTaskItem, ConditionTask> TaskLayout;

		// Token: 0x0401DEE3 RID: 122595
		private int? LookTaskId;

		// Token: 0x0200B60D RID: 46605
		private class EComponents
		{
			// Token: 0x040384BB RID: 230587
			public const int CaptionItem = 0;

			// Token: 0x040384BC RID: 230588
			public const int TaskScroll = 1;

			// Token: 0x040384BD RID: 230589
			public const int TaskItem = 2;

			// Token: 0x040384BE RID: 230590
			public const int HeadTexture = 3;

			// Token: 0x040384BF RID: 230591
			public const int LookBtn = 4;
		}
	}
}
