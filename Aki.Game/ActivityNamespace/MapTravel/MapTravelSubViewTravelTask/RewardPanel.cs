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
	// Token: 0x020044D6 RID: 17622
	internal class RewardPanel : UiPanelBase
	{
		// Token: 0x0602D678 RID: 185976 RVA: 0x00A3F1AA File Offset: 0x00A3D3AA
		[NullableContext(1)]
		public RewardPanel(ActivityMapTravelData ActivityBaseData)
		{
			this.ActivityBaseData = ActivityBaseData;
		}

		// Token: 0x0602D679 RID: 185977 RVA: 0x00A3F1BC File Offset: 0x00A3D3BC
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

		// Token: 0x0602D67A RID: 185978 RVA: 0x00A3F2E8 File Offset: 0x00A3D4E8
		protected override UniTask OnBeforeStartAsync()
		{
			RewardPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D67B RID: 185979 RVA: 0x00A3F32B File Offset: 0x00A3D52B
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602D67C RID: 185980 RVA: 0x00A3F334 File Offset: 0x00A3D534
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

		// Token: 0x0602D67D RID: 185981 RVA: 0x00A3F446 File Offset: 0x00A3D646
		private void OnClickedButton()
		{
			ActivityMapTravelController.Instance.RequestTakeTaskFinalReward();
		}

		// Token: 0x04018488 RID: 99464
		[Nullable(1)]
		private ActivityMapTravelData ActivityBaseData;

		// Token: 0x04018489 RID: 99465
		[Nullable(2)]
		private ActivitySmallItemGrid RewardItemGrid;

		// Token: 0x0200A722 RID: 42786
		private class EPanelReward
		{
			// Token: 0x04032797 RID: 206743
			public const int RewardGrid = 0;

			// Token: 0x04032798 RID: 206744
			public const int ButtonReward = 1;

			// Token: 0x04032799 RID: 206745
			public const int ItemDone = 2;

			// Token: 0x0403279A RID: 206746
			public const int ProgressBar = 3;

			// Token: 0x0403279B RID: 206747
			public const int ItemGoing = 4;

			// Token: 0x0403279C RID: 206748
			public const int TxtProgress = 5;
		}
	}
}
