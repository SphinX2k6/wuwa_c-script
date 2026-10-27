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

// Token: 0x02001DAF RID: 7599
[NullableContext(1)]
[Nullable(0)]
public class GreatSwordLevelSelectView : UiViewBase
{
	// Token: 0x0600E6A5 RID: 59045 RVA: 0x003656E3 File Offset: 0x003638E3
	public GreatSwordLevelSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E6A6 RID: 59046 RVA: 0x003656F7 File Offset: 0x003638F7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<ITrialSubChallenge>>(EEventName.GreatSwordLevelRefreshUI, new Action<IReadOnlyList<ITrialSubChallenge>>(this.OnRefreshChallengeUI));
		EventSystem.Instance.Add<int, int>(EEventName.GreatSwordLevelSelectedComplete, new Action<int, int>(this.OnChallengeConfirmed));
	}

	// Token: 0x0600E6A7 RID: 59047 RVA: 0x00365731 File Offset: 0x00363931
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GreatSwordLevelRefreshUI, new Action<IReadOnlyList<ITrialSubChallenge>>(this.OnRefreshChallengeUI));
		EventSystem.Instance.Remove(EEventName.GreatSwordLevelSelectedComplete, new Action<int, int>(this.OnChallengeConfirmed));
	}

	// Token: 0x0600E6A8 RID: 59048 RVA: 0x0036576C File Offset: 0x0036396C
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

	// Token: 0x0600E6A9 RID: 59049 RVA: 0x00365870 File Offset: 0x00363A70
	protected override UniTask OnBeforeStartAsync()
	{
		GreatSwordLevelSelectView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GreatSwordLevelSelectView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E6AA RID: 59050 RVA: 0x003658B3 File Offset: 0x00363AB3
	protected override void OnStart()
	{
		this.BindStaticUiData();
	}

	// Token: 0x0600E6AB RID: 59051 RVA: 0x003658BC File Offset: 0x00363ABC
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		int levelIndex = (GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>()).FindAll((TrialSubChallenge subChallenge) => subChallenge.Unlocked).Count - 1;
		this.OnClickTrialLevelItem(levelIndex);
	}

	// Token: 0x0600E6AC RID: 59052 RVA: 0x00365915 File Offset: 0x00363B15
	protected override void OnAfterDestroy()
	{
		GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(GreatSwordChallengeModel.Instance.GetIsStartChallenge() ? 2 : 0, GreatSwordChallengeModel.Instance.GetActionIncId());
		GreatSwordChallengeModel.Instance.ClearData();
	}

	// Token: 0x0600E6AD RID: 59053 RVA: 0x00365945 File Offset: 0x00363B45
	private void RefreshView()
	{
		this.RefreshTrialLevels();
		this.RefreshChallengeGoals();
		this.RefreshTopDescription();
	}

	// Token: 0x0600E6AE RID: 59054 RVA: 0x0036595C File Offset: 0x00363B5C
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

	// Token: 0x0600E6AF RID: 59055 RVA: 0x00365A04 File Offset: 0x00363C04
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

	// Token: 0x0600E6B0 RID: 59056 RVA: 0x00365A44 File Offset: 0x00363C44
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

	// Token: 0x0600E6B1 RID: 59057 RVA: 0x00365AA8 File Offset: 0x00363CA8
	private void RefreshTopDescription()
	{
		List<TrialSubChallenge> list = GreatSwordChallengeModel.Instance.GetSubChallenges() ?? new List<TrialSubChallenge>();
		int selectedIndex = GreatSwordChallengeModel.Instance.GetSelectedIndex();
		TrialSubChallenge trialSubChallenge = (selectedIndex < list.Count) ? list[selectedIndex] : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), (trialSubChallenge != null) ? trialSubChallenge.Config.RuleText : "", Array.Empty<object>());
	}

	// Token: 0x0600E6B2 RID: 59058 RVA: 0x00365B16 File Offset: 0x00363D16
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E6B3 RID: 59059 RVA: 0x00365B1F File Offset: 0x00363D1F
	private void OnRefreshChallengeUI(IReadOnlyList<ITrialSubChallenge> challenges)
	{
		this.RefreshView();
	}

	// Token: 0x0600E6B4 RID: 59060 RVA: 0x00365B27 File Offset: 0x00363D27
	private void OnChallengeConfirmed(int boardId, int levelId)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E6B5 RID: 59061 RVA: 0x00365B30 File Offset: 0x00363D30
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

	// Token: 0x0600E6B6 RID: 59062 RVA: 0x00365BBC File Offset: 0x00363DBC
	private GreatSwordTrialLevelItem InitTrialLevelItem()
	{
		GreatSwordTrialLevelItem greatSwordTrialLevelItem = new GreatSwordTrialLevelItem();
		greatSwordTrialLevelItem.CanClickCallBack = new Func<int, bool>(this.CanClickItem);
		greatSwordTrialLevelItem.OnClickToggleCallBack = new Action<int>(this.OnClickTrialLevelItem);
		this.TrialLevelItems.Add(greatSwordTrialLevelItem);
		return greatSwordTrialLevelItem;
	}

	// Token: 0x0600E6B7 RID: 59063 RVA: 0x00365C00 File Offset: 0x00363E00
	private GreatSwordGoalItem InitPnlListItem()
	{
		return new GreatSwordGoalItem();
	}

	// Token: 0x0600E6B8 RID: 59064 RVA: 0x00365C08 File Offset: 0x00363E08
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

	// Token: 0x0600E6B9 RID: 59065 RVA: 0x00365C60 File Offset: 0x00363E60
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

	// Token: 0x04006AB9 RID: 27321
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GreatSwordTrialLevelItem, TrialSubChallenge> TrialLevelLayout;

	// Token: 0x04006ABA RID: 27322
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GreatSwordGoalItem, TrialSubChallenge> ChallengeGoalLayout;

	// Token: 0x04006ABB RID: 27323
	private List<GreatSwordTrialLevelItem> TrialLevelItems = new List<GreatSwordTrialLevelItem>();

	// Token: 0x04006ABC RID: 27324
	[Nullable(2)]
	private ButtonItem ConfirmButton;
}
