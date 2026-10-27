using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001489 RID: 5257
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainLineActivityInfoPanel : UiPanelBase
{
	// Token: 0x060094E4 RID: 38116 RVA: 0x00201A34 File Offset: 0x001FFC34
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

	// Token: 0x060094E5 RID: 38117 RVA: 0x00201AA4 File Offset: 0x001FFCA4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainLineActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainLineActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094E6 RID: 38118 RVA: 0x00201AE8 File Offset: 0x001FFCE8
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoToMainLineBtnClick));
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.ActivityBottom.FunctionButton.SetText(localTextNew ?? "");
		this.ActivityRewardListPanel.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.ActivityRewardListPanel.InitCommonGridItem));
		this.ActivityTitlePanel.SetTimeTextVisible(false);
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x00201B5F File Offset: 0x001FFD5F
	public void RefreshByData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshReward();
		this.RefreshFuncBtn();
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x00201B88 File Offset: 0x001FFD88
	private void RefreshTitle()
	{
		this.ActivityTitlePanel.SetTitleByTextId(this.Config.Value.Title, Array.Empty<string>());
	}

	// Token: 0x060094E9 RID: 38121 RVA: 0x00201BB8 File Offset: 0x001FFDB8
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

	// Token: 0x060094EA RID: 38122 RVA: 0x00201C28 File Offset: 0x001FFE28
	private void RefreshReward()
	{
		List<TItem> regressBaseRewardPreviewItemList = ActivityRegressModel.Instance.GetRegressBaseRewardPreviewItemList(this.Config.Value);
		this.ActivityRewardListPanel.RefreshItemLayout(regressBaseRewardPreviewItemList, new Action(this.RefreshRewardState));
	}

	// Token: 0x060094EB RID: 38123 RVA: 0x00201C64 File Offset: 0x001FFE64
	private void RefreshRewardState()
	{
		bool receivedVisible = ActivityRegressModel.Instance.IsMainLineTaskFinish(this.Config.Value);
		CommonItemSmallItemGrid[] layoutItemList = this.ActivityRewardListPanel.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Length; i++)
		{
			layoutItemList[i].SetReceivedVisible(receivedVisible);
		}
	}

	// Token: 0x060094EC RID: 38124 RVA: 0x00201CAC File Offset: 0x001FFEAC
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

	// Token: 0x060094ED RID: 38125 RVA: 0x00201D24 File Offset: 0x001FFF24
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

	// Token: 0x040041ED RID: 16877
	private RegressBase? Config;

	// Token: 0x040041EE RID: 16878
	private ActivityTitleTypeA ActivityTitlePanel;

	// Token: 0x040041EF RID: 16879
	private ActivityDescriptionTypeB ActivityDescPanel;

	// Token: 0x040041F0 RID: 16880
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> ActivityRewardListPanel;

	// Token: 0x040041F1 RID: 16881
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02007AB5 RID: 31413
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028607 RID: 165383
		ComActivityTitle,
		// Token: 0x04028608 RID: 165384
		ComActivityDesc,
		// Token: 0x04028609 RID: 165385
		ComActivityReward,
		// Token: 0x0402860A RID: 165386
		ComActivityBottom
	}
}
