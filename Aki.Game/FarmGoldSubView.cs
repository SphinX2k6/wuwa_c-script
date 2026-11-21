using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000717 RID: 1815
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldSubView : ActivitySubViewBase
{
	// Token: 0x0600539A RID: 21402 RVA: 0x001BA095 File Offset: 0x001B8295
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600539B RID: 21403 RVA: 0x001BA0D0 File Offset: 0x001B82D0
	protected override UniTask OnBeforeStartAsync()
	{
		FarmGoldSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FarmGoldSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x001BA114 File Offset: 0x001B8314
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshRewardPopUp));
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x001BA17C File Offset: 0x001B837C
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshRewardPopUp));
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x001BA1E3 File Offset: 0x001B83E3
	private void OnFarmGoldOrCommonRedDot(int id)
	{
		this.RefreshRedDot();
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x001BA1EB File Offset: 0x001B83EB
	private void OnClickRewardButtonItem()
	{
		this.OnClickBtnReward();
	}

	// Token: 0x060053A0 RID: 21408 RVA: 0x001BA1F3 File Offset: 0x001B83F3
	private void OnClickBtnReward()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.FarmGoldDataField.GetRewardPopUpViewData(), delegate(bool success, int viewId)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
			if (viewByName == null)
			{
				return;
			}
			viewByName.AddChildViewById(viewId);
		});
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x001BA22E File Offset: 0x001B842E
	protected override void OnStart()
	{
		this.FarmGoldDataField = (this.ActivityBaseData as FarmGoldData);
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x001BA241 File Offset: 0x001B8441
	protected override void OnBeforeShow()
	{
		this.UnBindFarmGoldRedDot();
		ButtonItem rewardButtonItem = this.RewardButtonItem;
		if (rewardButtonItem == null)
		{
			return;
		}
		ERedDotName redDotName = ERedDotName.FarmGoldReward;
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		rewardButtonItem.BindRedDot(redDotName, (activityBaseData != null) ? activityBaseData.Id : 0);
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x001BA270 File Offset: 0x001B8470
	protected override void OnRefreshView()
	{
		this.RefreshGoBtnText();
		this.RefreshRewardButtonText();
		this.RefreshRedDot();
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x001BA284 File Offset: 0x001B8484
	private void RefreshGoBtnText()
	{
		if (this.ActivityBaseData.GetUnFinishPreGuideQuestId() > 0)
		{
			this.InfoComponent.SetBtnText("Activity_103300004_GoGuideQuest", Array.Empty<object>());
			return;
		}
		this.InfoComponent.SetBtnText("PrefabTextItem_2701983798_Text", Array.Empty<object>());
	}

	// Token: 0x060053A5 RID: 21413 RVA: 0x001BA2C0 File Offset: 0x001B84C0
	private void RefreshRewardButtonText()
	{
		FarmGoldData farmGoldDataField = this.FarmGoldDataField;
		ValueTuple<int, int>? valueTuple = (farmGoldDataField != null) ? new ValueTuple<int, int>?(farmGoldDataField.GetAllRewardClaimedAndTotalNum()) : null;
		if (valueTuple == null)
		{
			return;
		}
		ButtonItem rewardButtonItem = this.RewardButtonItem;
		if (rewardButtonItem == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Value.Item1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Value.Item2);
		rewardButtonItem.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060053A6 RID: 21414 RVA: 0x001BA349 File Offset: 0x001B8549
	private void FunctionExecute(ActivityBaseData data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			if (unFinishPreGuideQuestId > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			int entranceId = FarmGoldConfig.Instance.GetFarmGoldMarkByActivityId(this.ActivityBaseData.Id).EntranceId;
			if (entranceId > 0)
			{
				InstanceDungeonEntranceController.Instance.EnterEntrance(entranceId, 0, null).Forget<bool>();
			}
		});
	}

	// Token: 0x060053A7 RID: 21415 RVA: 0x001BA368 File Offset: 0x001B8568
	private void RefreshRedDot()
	{
		bool flag = this.FarmGoldDataField.EntranceRedDot();
		bool preGuideQuestFinishState = this.FarmGoldDataField.GetPreGuideQuestFinishState();
		this.InfoComponent.SetFunctionRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x001BA39B File Offset: 0x001B859B
	[NullableContext(1)]
	private void OnRefreshRewardPopUp(IActivityRewardViewData data)
	{
		if (this.FarmGoldDataField != null)
		{
			this.RefreshRewardButtonText();
		}
	}

	// Token: 0x060053A9 RID: 21417 RVA: 0x001BA3AB File Offset: 0x001B85AB
	protected override void OnBeforeHide()
	{
		this.UnBindFarmGoldRedDot();
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x001BA3B3 File Offset: 0x001B85B3
	private void UnBindFarmGoldRedDot()
	{
		ButtonItem rewardButtonItem = this.RewardButtonItem;
		if (rewardButtonItem == null)
		{
			return;
		}
		rewardButtonItem.UnBindRedDot();
	}

	// Token: 0x04003AC3 RID: 15043
	private FarmGoldData FarmGoldDataField;

	// Token: 0x04003AC4 RID: 15044
	private ActivitySubViewGeneralInfo InfoComponent;

	// Token: 0x04003AC5 RID: 15045
	private ButtonItem RewardButtonItem;

	// Token: 0x020069FF RID: 27135
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022E39 RID: 142905
		public const int InfoItem = 0;

		// Token: 0x04022E3A RID: 142906
		public const int RewardButton = 1;
	}
}
