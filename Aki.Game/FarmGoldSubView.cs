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

// Token: 0x02001263 RID: 4707
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldSubView : ActivitySubViewBase
{
	// Token: 0x06008003 RID: 32771 RVA: 0x001B13C5 File Offset: 0x001AF5C5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06008004 RID: 32772 RVA: 0x001B1400 File Offset: 0x001AF600
	protected override UniTask OnBeforeStartAsync()
	{
		FarmGoldSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FarmGoldSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008005 RID: 32773 RVA: 0x001B1444 File Offset: 0x001AF644
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Add<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshRewardPopUp));
	}

	// Token: 0x06008006 RID: 32774 RVA: 0x001B14AC File Offset: 0x001AF6AC
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<int>(EEventName.FarmGoldRefreshRewardRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnFarmGoldOrCommonRedDot));
		EventSystem.Instance.Remove<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, new Action<IActivityRewardViewData>(this.OnRefreshRewardPopUp));
	}

	// Token: 0x06008007 RID: 32775 RVA: 0x001B1513 File Offset: 0x001AF713
	private void OnFarmGoldOrCommonRedDot(int id)
	{
		this.RefreshRedDot();
	}

	// Token: 0x06008008 RID: 32776 RVA: 0x001B151B File Offset: 0x001AF71B
	private void OnClickRewardButtonItem()
	{
		this.OnClickBtnReward();
	}

	// Token: 0x06008009 RID: 32777 RVA: 0x001B1523 File Offset: 0x001AF723
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

	// Token: 0x0600800A RID: 32778 RVA: 0x001B155E File Offset: 0x001AF75E
	protected override void OnStart()
	{
		this.FarmGoldDataField = (this.ActivityBaseData as FarmGoldData);
	}

	// Token: 0x0600800B RID: 32779 RVA: 0x001B1571 File Offset: 0x001AF771
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

	// Token: 0x0600800C RID: 32780 RVA: 0x001B15A0 File Offset: 0x001AF7A0
	protected override void OnRefreshView()
	{
		this.RefreshGoBtnText();
		this.RefreshRewardButtonText();
		this.RefreshRedDot();
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x001B15B4 File Offset: 0x001AF7B4
	private void RefreshGoBtnText()
	{
		if (this.ActivityBaseData.GetUnFinishPreGuideQuestId() > 0)
		{
			this.InfoComponent.SetBtnText("Activity_103300004_GoGuideQuest", Array.Empty<object>());
			return;
		}
		this.InfoComponent.SetBtnText("PrefabTextItem_2701983798_Text", Array.Empty<object>());
	}

	// Token: 0x0600800E RID: 32782 RVA: 0x001B15F0 File Offset: 0x001AF7F0
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

	// Token: 0x0600800F RID: 32783 RVA: 0x001B1679 File Offset: 0x001AF879
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

	// Token: 0x06008010 RID: 32784 RVA: 0x001B1698 File Offset: 0x001AF898
	private void RefreshRedDot()
	{
		bool flag = this.FarmGoldDataField.EntranceRedDot();
		bool preGuideQuestFinishState = this.FarmGoldDataField.GetPreGuideQuestFinishState();
		this.InfoComponent.SetFunctionRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x001B16CB File Offset: 0x001AF8CB
	[NullableContext(1)]
	private void OnRefreshRewardPopUp(IActivityRewardViewData data)
	{
		if (this.FarmGoldDataField != null)
		{
			this.RefreshRewardButtonText();
		}
	}

	// Token: 0x06008012 RID: 32786 RVA: 0x001B16DB File Offset: 0x001AF8DB
	protected override void OnBeforeHide()
	{
		this.UnBindFarmGoldRedDot();
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x001B16E3 File Offset: 0x001AF8E3
	private void UnBindFarmGoldRedDot()
	{
		ButtonItem rewardButtonItem = this.RewardButtonItem;
		if (rewardButtonItem == null)
		{
			return;
		}
		rewardButtonItem.UnBindRedDot();
	}

	// Token: 0x04003A2B RID: 14891
	private FarmGoldData FarmGoldDataField;

	// Token: 0x04003A2C RID: 14892
	private ActivitySubViewGeneralInfo InfoComponent;

	// Token: 0x04003A2D RID: 14893
	private ButtonItem RewardButtonItem;

	// Token: 0x02007874 RID: 30836
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027B08 RID: 162568
		public const int InfoItem = 0;

		// Token: 0x04027B09 RID: 162569
		public const int RewardButton = 1;
	}
}
