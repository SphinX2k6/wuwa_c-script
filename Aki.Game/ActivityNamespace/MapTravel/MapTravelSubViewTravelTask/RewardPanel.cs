using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x02002F63 RID: 12131
	internal class RewardPanel : UiPanelBase
	{
		// Token: 0x0601CBB6 RID: 117686 RVA: 0x008C4E0A File Offset: 0x008C300A
		[NullableContext(1)]
		public RewardPanel(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0601CBB7 RID: 117687 RVA: 0x008C4E1C File Offset: 0x008C301C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601CBB8 RID: 117688 RVA: 0x008C4F48 File Offset: 0x008C3148
		protected override UniTask OnBeforeStartAsync()
		{
			RewardPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x008C4F8B File Offset: 0x008C318B
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x008C4F94 File Offset: 0x008C3194
		public void Refresh()
		{
			MapTravelConfig activityConfig = this.ActivityBaseData.GetActivityConfig();
			FinalTravelTaskData taskFinalRewardData = this.ActivityBaseData.TaskFinalRewardData;
			TItem item = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(activityConfig.FinalRewardId)[0];
			bool flag = taskFinalRewardData.Current == taskFinalRewardData.Target;
			bool isReceived = taskFinalRewardData.IsReceived;
			base.GetSprite(3).SetFillAmount((float)taskFinalRewardData.Current / (float)taskFinalRewardData.Target);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MapTravelAllTaskProgress_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				taskFinalRewardData.Current,
				taskFinalRewardData.Target
			}));
			base.GetButton(1).RootUIComp.Get().SetUIActive(flag && !isReceived);
			base.GetItem(4).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(isReceived);
			ItemGridData data = new ItemGridData
			{
				Item = item,
				HasClaimed = isReceived
			};
			this.RewardItemGrid.Refresh(data);
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x008C50A6 File Offset: 0x008C32A6
		private void OnClickedButton()
		{
			ActivityMapTravelController.Instance.RequestTakeTaskFinalReward();
		}

		// Token: 0x0400F230 RID: 62000
		[Nullable(1)]
		private ActivityMapTravelData ActivityBaseData;

		// Token: 0x0400F231 RID: 62001
		[Nullable(2)]
		private ActivitySmallItemGrid RewardItemGrid;

		// Token: 0x02008BF8 RID: 35832
		private class EPanelReward
		{
			// Token: 0x0402C565 RID: 181605
			public const int RewardGrid = 0;

			// Token: 0x0402C566 RID: 181606
			public const int ButtonReward = 1;

			// Token: 0x0402C567 RID: 181607
			public const int ItemDone = 2;

			// Token: 0x0402C568 RID: 181608
			public const int ProgressBar = 3;

			// Token: 0x0402C569 RID: 181609
			public const int ItemGoing = 4;

			// Token: 0x0402C56A RID: 181610
			public const int TxtProgress = 5;
		}
	}
}
