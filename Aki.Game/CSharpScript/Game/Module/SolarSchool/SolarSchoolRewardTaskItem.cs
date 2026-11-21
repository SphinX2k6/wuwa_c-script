using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A34 RID: 23092
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolRewardTaskItem : GridProxyAbstract<ConditionTask>
	{
		// Token: 0x06038E55 RID: 233045 RVA: 0x00FEECB0 File Offset: 0x00FECEB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038E56 RID: 233046 RVA: 0x00FEEDC0 File Offset: 0x00FECFC0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolRewardTaskItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolRewardTaskItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E57 RID: 233047 RVA: 0x00FEEE04 File Offset: 0x00FED004
		private void OnClickGetButton()
		{
			List<ConditionTask> taskList = this.ActivityData.GetTaskList(this.TaskType.Value);
			List<int> list = new List<int>();
			foreach (ConditionTask conditionTask in taskList)
			{
				if (conditionTask.Status == ConditionTaskState.ConditionTaskFinish)
				{
					list.Add(conditionTask.Id);
				}
			}
			if (list.Count > 0)
			{
				SolarSchoolController.Instance.GetRewardTaskReward(this.TaskType.Value, list);
			}
		}

		// Token: 0x06038E58 RID: 233048 RVA: 0x00FEEE9C File Offset: 0x00FED09C
		public void SetActivityDataAndType(SolarSchoolActivityData data, SolarSchoolTaskType taskType)
		{
			this.ActivityData = data;
			this.TaskType = new SolarSchoolTaskType?(taskType);
		}

		// Token: 0x06038E59 RID: 233049 RVA: 0x00FEEEB4 File Offset: 0x00FED0B4
		protected override void OnStart()
		{
			this.RootToggle = (this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle);
			UUIExtendToggle rootToggle = this.RootToggle;
			if (rootToggle != null)
			{
				rootToggle.SetToggleGroup(null);
			}
			UUIExtendToggle rootToggle2 = this.RootToggle;
			if (rootToggle2 != null)
			{
				rootToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
			UUIExtendToggle rootToggle3 = this.RootToggle;
			if (rootToggle3 != null)
			{
				rootToggle3.CanExecuteChange.Bind(() => false);
			}
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitGridItem), null, false, null);
		}

		// Token: 0x06038E5A RID: 233050 RVA: 0x00FEEF5E File Offset: 0x00FED15E
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle rootToggle = this.RootToggle;
			if (rootToggle != null)
			{
				rootToggle.CanExecuteChange.Unbind();
			}
			this.RootToggle = null;
		}

		// Token: 0x06038E5B RID: 233051 RVA: 0x00FEEF7D File Offset: 0x00FED17D
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x06038E5C RID: 233052 RVA: 0x00FEEF84 File Offset: 0x00FED184
		public override void Refresh(ConditionTask data, bool isSelected, int gridIndex)
		{
			SolarSchoolTask? config = ConfigSolarSchoolTaskById.GetConfig(data.Id, true);
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.TaskName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SolarSchoolRewardCounting", new <>z__ReadOnlyArray<object>(new object[]
			{
				data.Current,
				data.Target
			}));
			ConditionTaskState status = data.Status;
			bool uiactive = status == ConditionTaskState.ConditionTaskRunning;
			bool flag = status == ConditionTaskState.ConditionTaskFinish;
			bool flag2 = status == ConditionTaskState.ConditionTaskTaken;
			base.GetItem(4).SetUIActive(uiactive);
			SolarSchoolBtnItem getButtonItem = this.GetButtonItem;
			if (getButtonItem != null)
			{
				getButtonItem.SetUiActive(flag);
			}
			SolarSchoolBtnItem getButtonItem2 = this.GetButtonItem;
			if (getButtonItem2 != null)
			{
				getButtonItem2.SetRedDotVisible(flag);
			}
			base.GetItem(6).SetUIActive(flag2);
			this.RefreshReward(config.Value.DropId, flag2);
		}

		// Token: 0x06038E5D RID: 233053 RVA: 0x00FEF074 File Offset: 0x00FED274
		private void RefreshReward(int dropId, bool hasClaimed)
		{
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in dropPackagePreviewItemList)
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = hasClaimed
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0401DF03 RID: 122627
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DF04 RID: 122628
		private SolarSchoolTaskType? TaskType;

		// Token: 0x0401DF05 RID: 122629
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401DF06 RID: 122630
		[Nullable(2)]
		private UUIExtendToggle RootToggle;

		// Token: 0x0401DF07 RID: 122631
		[Nullable(2)]
		private SolarSchoolBtnItem GetButtonItem;

		// Token: 0x0200B61C RID: 46620
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403850D RID: 230669
			public const int NameText = 0;

			// Token: 0x0403850E RID: 230670
			public const int NumText = 1;

			// Token: 0x0403850F RID: 230671
			public const int RewardScroll = 2;

			// Token: 0x04038510 RID: 230672
			public const int RewardItem = 3;

			// Token: 0x04038511 RID: 230673
			public const int DoingItem = 4;

			// Token: 0x04038512 RID: 230674
			public const int GetBtn = 5;

			// Token: 0x04038513 RID: 230675
			public const int FinishItem = 6;
		}
	}
}
