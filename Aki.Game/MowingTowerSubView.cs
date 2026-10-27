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

// Token: 0x02001393 RID: 5011
[NullableContext(2)]
[Nullable(0)]
public class MowingTowerSubView : ActivitySubViewBase
{
	// Token: 0x06008C60 RID: 35936 RVA: 0x001E1788 File Offset: 0x001DF988
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

	// Token: 0x06008C61 RID: 35937 RVA: 0x001E185D File Offset: 0x001DFA5D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshMowingTowerData, new Action(this.OnMowingTowerDataUpdate));
	}

	// Token: 0x06008C62 RID: 35938 RVA: 0x001E187B File Offset: 0x001DFA7B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshMowingTowerData, new Action(this.OnMowingTowerDataUpdate));
	}

	// Token: 0x06008C63 RID: 35939 RVA: 0x001E1899 File Offset: 0x001DFA99
	private void OnMowingTowerDataUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06008C64 RID: 35940 RVA: 0x001E18A4 File Offset: 0x001DFAA4
	protected override UniTask OnBeforeStartAsync()
	{
		MowingTowerSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MowingTowerSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008C65 RID: 35941 RVA: 0x001E18E7 File Offset: 0x001DFAE7
	protected override void OnStart()
	{
		this.MowingTowerData = (this.ActivityBaseData as MowingTowerData);
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x001E18FA File Offset: 0x001DFAFA
	protected override void OnBeforeShow()
	{
		this.BindRedDot();
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x001E1902 File Offset: 0x001DFB02
	protected override void OnBeforeHide()
	{
		this.RemoveRedDot();
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x001E190C File Offset: 0x001DFB0C
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

	// Token: 0x06008C69 RID: 35945 RVA: 0x001E195F File Offset: 0x001DFB5F
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.MowingTowerReward, base.GetItem(6), null, this.MowingTowerData.Id);
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x001E1983 File Offset: 0x001DFB83
	private void RemoveRedDot()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.MowingTowerReward, base.GetItem(6), this.MowingTowerData.Id);
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x001E19A8 File Offset: 0x001DFBA8
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

	// Token: 0x06008C6C RID: 35948 RVA: 0x001E19F0 File Offset: 0x001DFBF0
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

	// Token: 0x06008C6D RID: 35949 RVA: 0x001E1A60 File Offset: 0x001DFC60
	private void RefreshScoreText()
	{
		MowingTowerData mowingTowerData = this.ActivityBaseData as MowingTowerData;
		base.GetText(5).SetText(mowingTowerData.GetFullScore().ToString() ?? "", true);
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x001E1AA0 File Offset: 0x001DFCA0
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

	// Token: 0x06008C6F RID: 35951 RVA: 0x001E1B04 File Offset: 0x001DFD04
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

	// Token: 0x06008C70 RID: 35952 RVA: 0x001E1B7C File Offset: 0x001DFD7C
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06008C71 RID: 35953 RVA: 0x001E1BBB File Offset: 0x001DFDBB
	protected override void OnTimer(float gap)
	{
		base.OnTimer(gap);
		this.RefreshTitle();
	}

	// Token: 0x06008C72 RID: 35954 RVA: 0x001E1BCA File Offset: 0x001DFDCA
	private void OnClickBtnReward()
	{
		MowingTowerModel.Instance.CurrentSelectActivityId = this.ActivityBaseData.Id;
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MowingTowerRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MowingTowerRewardView, null, null);
		}
	}

	// Token: 0x06008C73 RID: 35955 RVA: 0x001E1C04 File Offset: 0x001DFE04
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
	}

	// Token: 0x06008C74 RID: 35956 RVA: 0x001E1C2E File Offset: 0x001DFE2E
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

	// Token: 0x06008C75 RID: 35957 RVA: 0x001E1C4C File Offset: 0x001DFE4C
	private void RefreshRedDot()
	{
		bool flag = this.MowingTowerData.EntranceRedDot();
		bool preGuideQuestFinishState = this.MowingTowerData.GetPreGuideQuestFinishState();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
	}

	// Token: 0x04003E56 RID: 15958
	private MowingTowerData MowingTowerData;

	// Token: 0x04003E57 RID: 15959
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003E58 RID: 15960
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003E59 RID: 15961
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003E5A RID: 15962
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x020079FF RID: 31231
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028274 RID: 164468
		TitleItem,
		// Token: 0x04028275 RID: 164469
		DescItem,
		// Token: 0x04028276 RID: 164470
		RewardItem,
		// Token: 0x04028277 RID: 164471
		FunctionalAreaItem,
		// Token: 0x04028278 RID: 164472
		RewardBtn,
		// Token: 0x04028279 RID: 164473
		ScoreText,
		// Token: 0x0402827A RID: 164474
		RewardRedDotItem
	}
}
