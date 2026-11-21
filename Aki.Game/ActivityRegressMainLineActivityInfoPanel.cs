using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200093D RID: 2365
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainLineActivityInfoPanel : UiPanelBase
{
	// Token: 0x06006879 RID: 26745 RVA: 0x0020A99C File Offset: 0x00208B9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600687A RID: 26746 RVA: 0x0020AA0C File Offset: 0x00208C0C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainLineActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainLineActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600687B RID: 26747 RVA: 0x0020AA50 File Offset: 0x00208C50
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoToMainLineBtnClick));
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.ActivityBottom.FunctionButton.SetText(localTextNew ?? "");
		this.ActivityRewardListPanel.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.ActivityRewardListPanel.InitCommonGridItem));
		this.ActivityTitlePanel.SetTimeTextVisible(false);
	}

	// Token: 0x0600687C RID: 26748 RVA: 0x0020AAC7 File Offset: 0x00208CC7
	public void RefreshByData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshReward();
		this.RefreshFuncBtn();
	}

	// Token: 0x0600687D RID: 26749 RVA: 0x0020AAF0 File Offset: 0x00208CF0
	private void RefreshTitle()
	{
		this.ActivityTitlePanel.SetTitleByTextId(this.Config.Value.Title, Array.Empty<string>());
	}

	// Token: 0x0600687E RID: 26750 RVA: 0x0020AB20 File Offset: 0x00208D20
	private void RefreshDesc()
	{
		string subTitle = this.Config.Value.SubTitle;
		string description = this.Config.Value.Description;
		bool flag = !StringUtils.IsEmpty(subTitle);
		this.ActivityTitlePanel.SetSubTitleVisible(flag);
		if (flag)
		{
			this.ActivityTitlePanel.SetSubTitleByTextId(subTitle, Array.Empty<string>());
		}
		this.ActivityDescPanel.SetContentByTextId(description, Array.Empty<string>());
	}

	// Token: 0x0600687F RID: 26751 RVA: 0x0020AB90 File Offset: 0x00208D90
	private void RefreshReward()
	{
		List<TItem> regressBaseRewardPreviewItemList = ActivityRegressModel.Instance.GetRegressBaseRewardPreviewItemList(this.Config.Value);
		this.ActivityRewardListPanel.RefreshItemLayout(regressBaseRewardPreviewItemList, new Action(this.RefreshRewardState));
	}

	// Token: 0x06006880 RID: 26752 RVA: 0x0020ABCC File Offset: 0x00208DCC
	private void RefreshRewardState()
	{
		bool receivedVisible = ActivityRegressModel.Instance.IsMainLineTaskFinish(this.Config.Value);
		CommonItemSmallItemGrid[] layoutItemList = this.ActivityRewardListPanel.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Length; i++)
		{
			layoutItemList[i].SetReceivedVisible(receivedVisible);
		}
	}

	// Token: 0x06006881 RID: 26753 RVA: 0x0020AC14 File Offset: 0x00208E14
	private void RefreshFuncBtn()
	{
		bool flag = ActivityRegressModel.Instance.IsMainLineTaskFinish(this.Config.Value);
		this.ActivityBottom.FunctionButton.SetUiActive(!flag);
		this.ActivityBottom.SetActivatePanelConditionVisible(flag);
		if (flag)
		{
			this.ActivityBottom.SetActivateTextByTextId("RecallActivity_Finish", Array.Empty<string>());
			return;
		}
		this.ActivityBottom.FunctionButton.SetLocalTextNew("RecallActivity_Go", Array.Empty<object>());
	}

	// Token: 0x06006882 RID: 26754 RVA: 0x0020AC8C File Offset: 0x00208E8C
	private void OnGotoToMainLineBtnClick()
	{
		int? num = ActivityRegressModel.Instance.GetFirstUnFinishTask(this.Config.Value);
		if (num != null)
		{
			ActivityRegressHelper.ReportRecallLog1024(EReportLogEventType.NewMainLine, num.Value);
		}
		else
		{
			num = ActivityRegressModel.Instance.GetFirstUnFinishMainQuestId();
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Role_Precondition", Array.Empty<object>());
		}
		UiManager.Instance.OpenView(EUiViewName.QuestView, num, null);
	}

	// Token: 0x04004285 RID: 17029
	private RegressBase? Config;

	// Token: 0x04004286 RID: 17030
	private ActivityTitleTypeA ActivityTitlePanel;

	// Token: 0x04004287 RID: 17031
	private ActivityDescriptionTypeB ActivityDescPanel;

	// Token: 0x04004288 RID: 17032
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> ActivityRewardListPanel;

	// Token: 0x04004289 RID: 17033
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02006C39 RID: 27705
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04023921 RID: 145697
		ComActivityTitle,
		// Token: 0x04023922 RID: 145698
		ComActivityDesc,
		// Token: 0x04023923 RID: 145699
		ComActivityReward,
		// Token: 0x04023924 RID: 145700
		ComActivityBottom
	}
}
