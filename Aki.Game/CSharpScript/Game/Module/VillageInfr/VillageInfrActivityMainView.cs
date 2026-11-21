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
	// Token: 0x020037E2 RID: 14306
	[NullableContext(2)]
	[Nullable(0)]
	public class VillageInfrActivityMainView : ActivitySubViewBase
	{
		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x06025393 RID: 152467 RVA: 0x00A7F528 File Offset: 0x00A7D728
		protected new VillageInfrActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as VillageInfrActivityData;
			}
		}

		// Token: 0x06025394 RID: 152468 RVA: 0x00A7F538 File Offset: 0x00A7D738
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

		// Token: 0x06025395 RID: 152469 RVA: 0x00A7F5A8 File Offset: 0x00A7D7A8
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrActivityMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrActivityMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025396 RID: 152470 RVA: 0x00A7F5EC File Offset: 0x00A7D7EC
		[NullableContext(0)]
		private UniTask<bool> RequestInfrV2Info()
		{
			VillageInfrActivityMainView.<RequestInfrV2Info>d__6 <RequestInfrV2Info>d__;
			<RequestInfrV2Info>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2Info>d__.<>1__state = -1;
			<RequestInfrV2Info>d__.<>t__builder.Start<VillageInfrActivityMainView.<RequestInfrV2Info>d__6>(ref <RequestInfrV2Info>d__);
			return <RequestInfrV2Info>d__.<>t__builder.Task;
		}

		// Token: 0x06025397 RID: 152471 RVA: 0x00A7F628 File Offset: 0x00A7D828
		private UniTask CreateRewardButton()
		{
			VillageInfrActivityMainView.<CreateRewardButton>d__7 <CreateRewardButton>d__;
			<CreateRewardButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardButton>d__.<>4__this = this;
			<CreateRewardButton>d__.<>1__state = -1;
			<CreateRewardButton>d__.<>t__builder.Start<VillageInfrActivityMainView.<CreateRewardButton>d__7>(ref <CreateRewardButton>d__);
			return <CreateRewardButton>d__.<>t__builder.Task;
		}

		// Token: 0x06025398 RID: 152472 RVA: 0x00A7F66B File Offset: 0x00A7D86B
		protected override void OnStart()
		{
			this.RefreshActivityInfo();
			this.RefreshRewardBtn();
		}

		// Token: 0x06025399 RID: 152473 RVA: 0x00A7F679 File Offset: 0x00A7D879
		protected override void OnRefreshView()
		{
			this.RefreshRewardBtn();
		}

		// Token: 0x0602539A RID: 152474 RVA: 0x00A7F684 File Offset: 0x00A7D884
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

		// Token: 0x0602539B RID: 152475 RVA: 0x00A7F708 File Offset: 0x00A7D908
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

		// Token: 0x0602539C RID: 152476 RVA: 0x00A7F7E0 File Offset: 0x00A7D9E0
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			this.OnConfirmBtnClick();
		}

		// Token: 0x0602539D RID: 152477 RVA: 0x00A7F7E8 File Offset: 0x00A7D9E8
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

		// Token: 0x0602539E RID: 152478 RVA: 0x00A7F806 File Offset: 0x00A7DA06
		private void OnClickBtnReward(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.VillageInfrTaskMainView, null, null);
		}

		// Token: 0x04014970 RID: 84336
		[Nullable(1)]
		protected ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x04014971 RID: 84337
		[Nullable(1)]
		private readonly ButtonItem RewardButton = new ButtonItem(null);
	}
}
