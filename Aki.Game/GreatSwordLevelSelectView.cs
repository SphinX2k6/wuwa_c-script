using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001271 RID: 4721
[NullableContext(1)]
[Nullable(0)]
public class GreatSwordLevelSelectView : UiViewBase
{
	// Token: 0x0600BAC3 RID: 47811 RVA: 0x00371343 File Offset: 0x0036F543
	public GreatSwordLevelSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BAC4 RID: 47812 RVA: 0x00371357 File Offset: 0x0036F557
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<ITrialSubChallenge>>(EEventName.GreatSwordLevelRefreshUI, new Action<IReadOnlyList<ITrialSubChallenge>>(this.OnRefreshChallengeUI));
		EventSystem.Instance.Add<int, int>(EEventName.GreatSwordLevelSelectedComplete, new Action<int, int>(this.OnChallengeConfirmed));
	}

	// Token: 0x0600BAC5 RID: 47813 RVA: 0x00371391 File Offset: 0x0036F591
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GreatSwordLevelRefreshUI, new Action<IReadOnlyList<ITrialSubChallenge>>(this.OnRefreshChallengeUI));
		EventSystem.Instance.Remove(EEventName.GreatSwordLevelSelectedComplete, new Action<int, int>(this.OnChallengeConfirmed));
	}

	// Token: 0x0600BAC6 RID: 47814 RVA: 0x003713CC File Offset: 0x0036F5CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickClose))
		};
	}

	// Token: 0x0600BAC7 RID: 47815 RVA: 0x003714D0 File Offset: 0x0036F6D0
	protected override UniTask OnBeforeStartAsync()
	{
		GreatSwordLevelSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GreatSwordLevelSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAC8 RID: 47816 RVA: 0x00371513 File Offset: 0x0036F713
	protected override void OnStart()
	{
		this.BindStaticUiData();
	}

	// Token: 0x0600BAC9 RID: 47817 RVA: 0x0037151C File Offset: 0x0036F71C
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		int levelIndex = (GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>()).FindAll((TrialSubChallenge subChallenge) => subChallenge.Unlocked).Count - 1;
		this.OnClickTrialLevelItem(levelIndex);
	}

	// Token: 0x0600BACA RID: 47818 RVA: 0x00371575 File Offset: 0x0036F775
	protected override void OnAfterDestroy()
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(GreatSwordChallengeModel.Instance.GetIsStartChallenge() ? 2 : 0, GreatSwordChallengeModel.Instance.GetActionIncId());
		GreatSwordChallengeModel.Instance.ClearData();
	}

	// Token: 0x0600BACB RID: 47819 RVA: 0x003715A5 File Offset: 0x0036F7A5
	private void RefreshView()
	{
		this.RefreshTrialLevels();
		this.RefreshChallengeGoals();
		this.RefreshTopDescription();
	}

	// Token: 0x0600BACC RID: 47820 RVA: 0x003715BC File Offset: 0x0036F7BC
	private void BindStaticUiData()
	{
		ITrialChallenge challenge = GreatSwordChallengeModel.Instance.GetChallenge();
		BlackSwordChallenge? config = ConfigBlackSwordChallengeById.GetConfig((challenge != null) ? challenge.BoardId : 0, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ((config != null) ? config.GetValueOrDefault().Title : null) ?? "", Array.Empty<object>());
		string path = ((config != null) ? config.GetValueOrDefault().Icon : null) ?? "";
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			this.SetSpriteByPath(path, sprite, false, null, null);
		}
	}

	// Token: 0x0600BACD RID: 47821 RVA: 0x00371664 File Offset: 0x0036F864
	private void RefreshTrialLevels()
	{
		this.TrialLevelItems = new List<GreatSwordTrialLevelItem>();
		List<TrialSubChallenge> data = GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>();
		GenericLayout<GreatSwordTrialLevelItem, TrialSubChallenge> trialLevelLayout = this.TrialLevelLayout;
		if (trialLevelLayout == null)
		{
			return;
		}
		trialLevelLayout.RefreshByData(data, null, false);
	}

	// Token: 0x0600BACE RID: 47822 RVA: 0x003716A4 File Offset: 0x0036F8A4
	private void RefreshChallengeGoals()
	{
		List<TrialSubChallenge> list = GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>();
		int selectedIndex = GreatSwordChallengeModel.Instance.GetSelectedIndex();
		List<TrialSubChallenge> list2;
		if (selectedIndex >= list.Count)
		{
			list2 = new List<TrialSubChallenge>();
		}
		else
		{
			(list2 = new List<TrialSubChallenge>()).Add(list[selectedIndex]);
		}
		List<TrialSubChallenge> data = list2;
		GenericLayout<GreatSwordGoalItem, TrialSubChallenge> challengeGoalLayout = this.ChallengeGoalLayout;
		if (challengeGoalLayout == null)
		{
			return;
		}
		challengeGoalLayout.RefreshByData(data, null, false);
	}

	// Token: 0x0600BACF RID: 47823 RVA: 0x00371708 File Offset: 0x0036F908
	private void RefreshTopDescription()
	{
		List<TrialSubChallenge> list = GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>();
		int selectedIndex = GreatSwordChallengeModel.Instance.GetSelectedIndex();
		TrialSubChallenge trialSubChallenge = (selectedIndex < list.Count) ? list[selectedIndex] : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), (trialSubChallenge != null) ? trialSubChallenge.Config.RuleText : "", Array.Empty<object>());
	}

	// Token: 0x0600BAD0 RID: 47824 RVA: 0x00371776 File Offset: 0x0036F976
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BAD1 RID: 47825 RVA: 0x0037177F File Offset: 0x0036F97F
	private void OnRefreshChallengeUI(IReadOnlyList<ITrialSubChallenge> challenges)
	{
		this.RefreshView();
	}

	// Token: 0x0600BAD2 RID: 47826 RVA: 0x00371787 File Offset: 0x0036F987
	private void OnChallengeConfirmed(int boardId, int levelId)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BAD3 RID: 47827 RVA: 0x00371790 File Offset: 0x0036F990
	private void OnClickStartChallenge(int _)
	{
		ITrialChallenge challenge = GreatSwordChallengeModel.Instance.GetChallenge();
		BlackSwordChallenge? blackSwordChallenge;
		int instId = (ConfigBlackSwordChallengeById.GetConfig((challenge != null) ? challenge.BoardId : 0, true) != null) ? blackSwordChallenge.GetValueOrDefault().RelativeDungeonId : 0;
		int selectedIndex = GreatSwordChallengeModel.Instance.GetSelectedIndex();
		List<TrialSubChallenge> subChallenges = GreatSwordChallengeModel.Instance.GetSubChallenges();
		int levelId = (selectedIndex < subChallenges.Count) ? subChallenges[selectedIndex].Config.Id : 0;
		GreatSwordController.Instance.RequestGreatSwordLevelSelected(instId, levelId);
	}

	// Token: 0x0600BAD4 RID: 47828 RVA: 0x0037181C File Offset: 0x0036FA1C
	private GreatSwordTrialLevelItem InitTrialLevelItem()
	{
		GreatSwordTrialLevelItem greatSwordTrialLevelItem = new GreatSwordTrialLevelItem();
		greatSwordTrialLevelItem.CanClickCallBack = new Func<int, bool>(this.CanClickItem);
		greatSwordTrialLevelItem.OnClickToggleCallBack = new Action<int>(this.OnClickTrialLevelItem);
		this.TrialLevelItems.Add(greatSwordTrialLevelItem);
		return greatSwordTrialLevelItem;
	}

	// Token: 0x0600BAD5 RID: 47829 RVA: 0x00371860 File Offset: 0x0036FA60
	private GreatSwordGoalItem InitPnlListItem()
	{
		return new GreatSwordGoalItem();
	}

	// Token: 0x0600BAD6 RID: 47830 RVA: 0x00371868 File Offset: 0x0036FA68
	private bool CanClickItem(int levelIndex)
	{
		List<TrialSubChallenge> list = GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>();
		TrialSubChallenge trialSubChallenge = (levelIndex < list.Count) ? list[levelIndex] : null;
		if (trialSubChallenge == null || !trialSubChallenge.Unlocked)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BlackSwordTips_LevelNotUnlocked", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600BAD7 RID: 47831 RVA: 0x003718C0 File Offset: 0x0036FAC0
	private void OnClickTrialLevelItem(int levelIndex)
	{
		if (!this.CanClickItem(levelIndex))
		{
			return;
		}
		for (int i = 0; i < this.TrialLevelItems.Count; i++)
		{
			this.TrialLevelItems[i].SetToggleState((i == levelIndex) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}
		GreatSwordChallengeModel.Instance.SetSelectedIndex(levelIndex);
		this.RefreshChallengeGoals();
		this.RefreshTopDescription();
		this.UiViewSequence.StopSequenceByKey("Switch", false, true);
		this.UiViewSequence.PlaySequence("Switch", false, null);
	}

	// Token: 0x04006B9A RID: 27546
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GreatSwordTrialLevelItem, TrialSubChallenge> TrialLevelLayout;

	// Token: 0x04006B9B RID: 27547
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GreatSwordGoalItem, TrialSubChallenge> ChallengeGoalLayout;

	// Token: 0x04006B9C RID: 27548
	private List<GreatSwordTrialLevelItem> TrialLevelItems = new List<GreatSwordTrialLevelItem>();

	// Token: 0x04006B9D RID: 27549
	[Nullable(2)]
	private ButtonItem ConfirmButton;
}
