using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000847 RID: 2119
[NullableContext(2)]
[Nullable(0)]
public class MowingTowerSubView : ActivitySubViewBase
{
	// Token: 0x06005FFB RID: 24571 RVA: 0x001EA5DC File Offset: 0x001E87DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnReward))
		};
	}

	// Token: 0x06005FFC RID: 24572 RVA: 0x001EA6B1 File Offset: 0x001E88B1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshMowingTowerData, new Action(this.OnMowingTowerDataUpdate));
	}

	// Token: 0x06005FFD RID: 24573 RVA: 0x001EA6CF File Offset: 0x001E88CF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMowingTowerData, new Action(this.OnMowingTowerDataUpdate));
	}

	// Token: 0x06005FFE RID: 24574 RVA: 0x001EA6ED File Offset: 0x001E88ED
	private void OnMowingTowerDataUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06005FFF RID: 24575 RVA: 0x001EA6F8 File Offset: 0x001E88F8
	protected override UniTask OnBeforeStartAsync()
	{
		MowingTowerSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MowingTowerSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006000 RID: 24576 RVA: 0x001EA73B File Offset: 0x001E893B
	protected override void OnStart()
	{
		this.MowingTowerData = (this.ActivityBaseData as MowingTowerData);
	}

	// Token: 0x06006001 RID: 24577 RVA: 0x001EA74E File Offset: 0x001E894E
	protected override void OnBeforeShow()
	{
		this.BindRedDot();
	}

	// Token: 0x06006002 RID: 24578 RVA: 0x001EA756 File Offset: 0x001E8956
	protected override void OnBeforeHide()
	{
		this.RemoveRedDot();
	}

	// Token: 0x06006003 RID: 24579 RVA: 0x001EA760 File Offset: 0x001E8960
	protected override void OnRefreshView()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.RefreshDesc();
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshFunctionalComponent();
		this.RefreshRedDot();
		this.RefreshState();
		this.RefreshScoreText();
		this.TryShowNewUnlockTips();
	}

	// Token: 0x06006004 RID: 24580 RVA: 0x001EA7B3 File Offset: 0x001E89B3
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.MowingTowerReward, base.GetItem(6), null, this.MowingTowerData.Id);
	}

	// Token: 0x06006005 RID: 24581 RVA: 0x001EA7D7 File Offset: 0x001E89D7
	private void RemoveRedDot()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.MowingTowerReward, base.GetItem(6), this.MowingTowerData.Id);
	}

	// Token: 0x06006006 RID: 24582 RVA: 0x001EA7FC File Offset: 0x001E89FC
	private void TryShowNewUnlockTips()
	{
		if (this.MowingTowerData.GetNewUnlockState())
		{
			this.MowingTowerData.CacheNewUnlock();
			DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
			difficultUnlockTipsData.Text = "MowTowerNewLevelTips";
			UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
		}
	}

	// Token: 0x06006007 RID: 24583 RVA: 0x001EA844 File Offset: 0x001E8A44
	private void RefreshState()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		bool flag = this.ActivityBaseData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06006008 RID: 24584 RVA: 0x001EA8B4 File Offset: 0x001E8AB4
	private void RefreshScoreText()
	{
		MowingTowerData mowingTowerData = this.ActivityBaseData as MowingTowerData;
		base.GetText(5).SetText(mowingTowerData.GetFullScore().ToString() ?? "", true);
	}

	// Token: 0x06006009 RID: 24585 RVA: 0x001EA8F4 File Offset: 0x001E8AF4
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x0600600A RID: 24586 RVA: 0x001EA958 File Offset: 0x001E8B58
	private void RefreshDesc()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		string descTheme = localConfig.Value.DescTheme;
		string desc = localConfig.Value.Desc;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x001EA9D0 File Offset: 0x001E8BD0
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x0600600C RID: 24588 RVA: 0x001EAA0F File Offset: 0x001E8C0F
	protected override void OnTimer(float gap)
	{
		base.OnTimer(gap);
		this.RefreshTitle();
	}

	// Token: 0x0600600D RID: 24589 RVA: 0x001EAA1E File Offset: 0x001E8C1E
	private void OnClickBtnReward()
	{
		MowingTowerModel.Instance.CurrentSelectActivityId = this.ActivityBaseData.Id;
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MowingTowerRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MowingTowerRewardView, null, null);
		}
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x001EAA58 File Offset: 0x001E8C58
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x001EAA82 File Offset: 0x001E8C82
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			MowingTowerController.Instance.OpenMowingTowerView(this.ActivityBaseData.Id);
		});
	}

	// Token: 0x06006010 RID: 24592 RVA: 0x001EAAA0 File Offset: 0x001E8CA0
	private void RefreshRedDot()
	{
		bool flag = this.MowingTowerData.EntranceRedDot();
		bool preGuideQuestFinishState = this.MowingTowerData.GetPreGuideQuestFinishState();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x04003EEE RID: 16110
	private MowingTowerData MowingTowerData;

	// Token: 0x04003EEF RID: 16111
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003EF0 RID: 16112
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003EF1 RID: 16113
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003EF2 RID: 16114
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02006B89 RID: 27529
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040235A1 RID: 144801
		TitleItem,
		// Token: 0x040235A2 RID: 144802
		DescItem,
		// Token: 0x040235A3 RID: 144803
		RewardItem,
		// Token: 0x040235A4 RID: 144804
		FunctionalAreaItem,
		// Token: 0x040235A5 RID: 144805
		RewardBtn,
		// Token: 0x040235A6 RID: 144806
		ScoreText,
		// Token: 0x040235A7 RID: 144807
		RewardRedDotItem
	}
}
