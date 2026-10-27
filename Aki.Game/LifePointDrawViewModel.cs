using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200129D RID: 4765
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawViewModel
{
	// Token: 0x0600827E RID: 33406 RVA: 0x001BB148 File Offset: 0x001B9348
	public void RegisterView(LifePointDrawDetailView view)
	{
		this.Panel = view;
		this.SelectChallengeId = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(this.GroupId).Value.ChallengeList(0);
	}

	// Token: 0x0600827F RID: 33407 RVA: 0x001BB183 File Offset: 0x001B9383
	public void OnSelectChallenge(int challengeId)
	{
		this.SelectChallengeId = challengeId;
		this.RefreshLayout();
		this.RefreshDifficultTexture();
		this.RefreshRewardLayout();
		this.RefreshTitleText();
		this.RefreshDescText();
		this.SaveCurrentChallengeRedDotState();
		this.PlaySwitchSequence();
	}

	// Token: 0x06008280 RID: 33408 RVA: 0x001BB1B8 File Offset: 0x001B93B8
	public void RefreshLayout()
	{
		LifePointGroup value = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(this.GroupId).Value;
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.RefreshLayout(value.GetChallengeListArray().ToList<int>());
	}

	// Token: 0x06008281 RID: 33409 RVA: 0x001BB1FA File Offset: 0x001B93FA
	public void OnShowView()
	{
		this.RefreshLayout();
		this.RefreshNumSprite();
		this.RefreshDifficultTexture();
		this.RefreshRewardLayout();
		this.RefreshTitleText();
		this.RefreshDescText();
		this.SaveCurrentChallengeRedDotState();
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x001BB226 File Offset: 0x001B9426
	public bool CheckChallengeIfSelect(int challengeId)
	{
		return this.SelectChallengeId == challengeId;
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x001BB231 File Offset: 0x001B9431
	public bool GetChallengeLockState(int challengeId)
	{
		return !LifePointDrawModel.Instance.GetChallengeRequireFinishState(this.LifePointDrawActivityData.Id, challengeId);
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x001BB24C File Offset: 0x001B944C
	private void RefreshNumSprite()
	{
		string levelNumResource = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(this.GroupId).Value.LevelNumResource;
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.RefreshLevelNumSprite(levelNumResource);
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x001BB28C File Offset: 0x001B948C
	private void RefreshTitleText()
	{
		string name = LifePointDrawConfig.Instance.GetLifePointChallengeById(this.SelectChallengeId).Value.Name;
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.ShowRightUpTitle(name);
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x001BB2CC File Offset: 0x001B94CC
	private void RefreshDescText()
	{
		string desc = LifePointDrawConfig.Instance.GetLifePointChallengeById(this.SelectChallengeId).Value.Desc;
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.ShowDescText(desc);
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x001BB30B File Offset: 0x001B950B
	private void PlaySwitchSequence()
	{
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.PlaySwitchSequence();
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x001BB320 File Offset: 0x001B9520
	private void RefreshDifficultTexture()
	{
		string difficultTexture = LifePointDrawConfig.Instance.GetLifePointChallengeById(this.SelectChallengeId).Value.DifficultTexture;
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(difficultTexture);
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.RefreshDifficultTexture(resourcePath);
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x001BB36C File Offset: 0x001B956C
	public string GetChallengeTitleId(int challengeId)
	{
		return LifePointDrawConfig.Instance.GetLifePointChallengeById(challengeId).Value.SubTitle;
	}

	// Token: 0x0600828A RID: 33418 RVA: 0x001BB394 File Offset: 0x001B9594
	public void RefreshRewardLayout()
	{
		int rewardId = LifePointDrawConfig.Instance.GetLifePointChallengeById(this.SelectChallengeId).Value.RewardId;
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId);
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.RefreshRewardLayout(dropPackagePreviewItemList);
	}

	// Token: 0x0600828B RID: 33419 RVA: 0x001BB3E0 File Offset: 0x001B95E0
	public bool GetCurrentChallengeFinishRewardState()
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(this.LifePointDrawActivityData.Id) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(this.SelectChallengeId);
	}

	// Token: 0x0600828C RID: 33420 RVA: 0x001BB41C File Offset: 0x001B961C
	public bool GetChallengeFinishState(int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(this.LifePointDrawActivityData.Id) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(challengeId);
	}

	// Token: 0x0600828D RID: 33421 RVA: 0x001BB450 File Offset: 0x001B9650
	public int GetCurrentChallengeId()
	{
		return this.SelectChallengeId;
	}

	// Token: 0x0600828E RID: 33422 RVA: 0x001BB458 File Offset: 0x001B9658
	public void SaveCurrentChallengeRedDotState()
	{
		int currentChallengeId = this.GetCurrentChallengeId();
		LifePointDrawModel.Instance.SaveChallengeRedDotState(this.LifePointDrawActivityData.Id, currentChallengeId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawGroupRedDot, this.GroupId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawChallengeRedDot, currentChallengeId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LifePointDrawActivityData.Id);
	}

	// Token: 0x04003AE9 RID: 15081
	[Nullable(2)]
	public LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x04003AEA RID: 15082
	public int GroupId;

	// Token: 0x04003AEB RID: 15083
	private int SelectChallengeId;

	// Token: 0x04003AEC RID: 15084
	[Nullable(2)]
	private LifePointDrawDetailView Panel;
}
