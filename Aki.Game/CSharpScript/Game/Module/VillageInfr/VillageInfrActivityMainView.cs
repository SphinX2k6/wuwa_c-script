using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200486B RID: 18539
	[NullableContext(2)]
	[Nullable(0)]
	public class VillageInfrActivityMainView : ActivitySubViewBase
	{
		// Token: 0x1700792D RID: 31021
		// (get) Token: 0x06030867 RID: 198759 RVA: 0x00B4478C File Offset: 0x00B4298C
		protected new VillageInfrActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as VillageInfrActivityData;
			}
		}

		// Token: 0x06030868 RID: 198760 RVA: 0x00B4479C File Offset: 0x00B4299C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06030869 RID: 198761 RVA: 0x00B4480C File Offset: 0x00B42A0C
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrActivityMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrActivityMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603086A RID: 198762 RVA: 0x00B44850 File Offset: 0x00B42A50
		[NullableContext(0)]
		private UniTask<bool> RequestInfrV2Info()
		{
			VillageInfrActivityMainView.<RequestInfrV2Info>d__6 <RequestInfrV2Info>d__;
			<RequestInfrV2Info>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2Info>d__.<>1__state = -1;
			<RequestInfrV2Info>d__.<>t__builder.Start<VillageInfrActivityMainView.<RequestInfrV2Info>d__6>(ref <RequestInfrV2Info>d__);
			return <RequestInfrV2Info>d__.<>t__builder.Task;
		}

		// Token: 0x0603086B RID: 198763 RVA: 0x00B4488C File Offset: 0x00B42A8C
		private UniTask CreateRewardButton()
		{
			VillageInfrActivityMainView.<CreateRewardButton>d__7 <CreateRewardButton>d__;
			<CreateRewardButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardButton>d__.<>4__this = this;
			<CreateRewardButton>d__.<>1__state = -1;
			<CreateRewardButton>d__.<>t__builder.Start<VillageInfrActivityMainView.<CreateRewardButton>d__7>(ref <CreateRewardButton>d__);
			return <CreateRewardButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603086C RID: 198764 RVA: 0x00B448CF File Offset: 0x00B42ACF
		protected override void OnStart()
		{
			this.RefreshActivityInfo();
			this.RefreshRewardBtn();
		}

		// Token: 0x0603086D RID: 198765 RVA: 0x00B448DD File Offset: 0x00B42ADD
		protected override void OnRefreshView()
		{
			this.RefreshRewardBtn();
		}

		// Token: 0x0603086E RID: 198766 RVA: 0x00B448E8 File Offset: 0x00B42AE8
		private void RefreshActivityInfo()
		{
			this.CommonInfoPanel.SetBtnText("LongShanStage_Join01", Array.Empty<object>());
			this.CommonInfoPanel.SetClickFunc(new Action<ActivityBaseData>(this.OnConfirmBtnClick));
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.CheckRedDot());
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
			};
			functional.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x0603086F RID: 198767 RVA: 0x00B4496C File Offset: 0x00B42B6C
		private void RefreshRewardBtn()
		{
			if (!FunctionModel.Instance.IsOpen(EFunctionType.VillageInfr))
			{
				this.RewardButton.SetUiActive(false);
				return;
			}
			this.RewardButton.SetUiActive(true);
			this.RewardButton.BindRedDot(ERedDotName.VillageInfrTask, 0);
			List<VillageInfrLimitTaskData> activityTaskDataList = VillageInfrModel.Instance.GetActivityTaskDataList();
			int num = 0;
			using (List<VillageInfrLimitTaskData>.Enumerator enumerator = activityTaskDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskTaken)
					{
						num++;
					}
				}
			}
			ButtonItem rewardButton = this.RewardButton;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activityTaskDataList.Count);
			rewardButton.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06030870 RID: 198768 RVA: 0x00B44A44 File Offset: 0x00B42C44
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			this.OnConfirmBtnClick();
		}

		// Token: 0x06030871 RID: 198769 RVA: 0x00B44A4C File Offset: 0x00B42C4C
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				VillageInfrActivityData activityBaseData = this.ActivityBaseData;
				List<int> list = ((activityBaseData != null) ? activityBaseData.GetPreGuideQuestIds() : null) ?? new List<int>();
				if (list.Count <= 0)
				{
					VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
					return;
				}
				int num = list[0];
				if (QuestNewModel.Instance.CheckQuestFinished(num))
				{
					VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.QuestView, num, null);
			});
		}

		// Token: 0x06030872 RID: 198770 RVA: 0x00B44A6A File Offset: 0x00B42C6A
		private void OnClickBtnReward(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.VillageInfrTaskMainView, null, null);
		}

		// Token: 0x0401A0FD RID: 106749
		[Nullable(1)]
		protected ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x0401A0FE RID: 106750
		[Nullable(1)]
		private readonly ButtonItem RewardButton = new ButtonItem(null);
	}
}
