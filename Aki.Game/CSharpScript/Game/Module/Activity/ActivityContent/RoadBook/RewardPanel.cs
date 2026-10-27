using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061F0 RID: 25072
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardPanel : UiPanelBase
	{
		// Token: 0x0603F463 RID: 259171 RVA: 0x00F4A3C0 File Offset: 0x00F485C0
		public RewardPanel(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F464 RID: 259172 RVA: 0x00F4A3D0 File Offset: 0x00F485D0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickedButton))
			};
		}

		// Token: 0x0603F465 RID: 259173 RVA: 0x00F4A490 File Offset: 0x00F48690
		protected override UniTask OnBeforeStartAsync()
		{
			RewardPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F466 RID: 259174 RVA: 0x00F4A4D3 File Offset: 0x00F486D3
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603F467 RID: 259175 RVA: 0x00F4A4DC File Offset: 0x00F486DC
		public void Refresh()
		{
			RoadBookConfig activityConfig = this.ActivityBaseData.GetActivityConfig();
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

		// Token: 0x0603F468 RID: 259176 RVA: 0x00F4A5EE File Offset: 0x00F487EE
		private void OnClickedButton()
		{
			ActivityRoadBookController.Instance.RequestTakeTaskFinalReward();
		}

		// Token: 0x04021005 RID: 135173
		[Nullable(2)]
		private ActivitySmallItemGrid RewardItemGrid;

		// Token: 0x04021006 RID: 135174
		protected ActivityRoadBookData ActivityBaseData;
	}
}
