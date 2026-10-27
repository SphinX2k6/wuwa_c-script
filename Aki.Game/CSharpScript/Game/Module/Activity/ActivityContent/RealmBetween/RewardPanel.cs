using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200628E RID: 25230
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardPanel : UiPanelBase
	{
		// Token: 0x0603F7C8 RID: 260040 RVA: 0x00F59528 File Offset: 0x00F57728
		public RewardPanel(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F7C9 RID: 260041 RVA: 0x00F59538 File Offset: 0x00F57738
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

		// Token: 0x0603F7CA RID: 260042 RVA: 0x00F595F8 File Offset: 0x00F577F8
		protected override UniTask OnBeforeStartAsync()
		{
			RewardPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F7CB RID: 260043 RVA: 0x00F5963B File Offset: 0x00F5783B
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603F7CC RID: 260044 RVA: 0x00F59644 File Offset: 0x00F57844
		public void Refresh()
		{
			RealmBetweenConfig activityConfig = this.ActivityBaseData.GetActivityConfig();
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

		// Token: 0x0603F7CD RID: 260045 RVA: 0x00F59756 File Offset: 0x00F57956
		private void OnClickedButton()
		{
			ActivityRealmBetweenController.Instance.RequestTakeTaskFinalReward();
		}

		// Token: 0x040212FF RID: 135935
		[Nullable(2)]
		private ActivitySmallItemGrid RewardItemGrid;

		// Token: 0x04021300 RID: 135936
		protected ActivityRealmBetweenData ActivityBaseData;
	}
}
