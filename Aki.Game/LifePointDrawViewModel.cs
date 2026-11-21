using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000751 RID: 1873
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawViewModel
{
	// Token: 0x06005615 RID: 22037 RVA: 0x001C3E18 File Offset: 0x001C2018
	public void RegisterView(LifePointDrawDetailView view)
	{
		this.Panel = view;
		this.SelectChallengeId = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(this.GroupId).Value.ChallengeList(0);
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x001C3E53 File Offset: 0x001C2053
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

	// Token: 0x06005617 RID: 22039 RVA: 0x001C3E88 File Offset: 0x001C2088
	public void RefreshLayout()
	{
		LifePointGroup value = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(this.GroupId).Value;
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.RefreshLayout(value.GetChallengeListArray());
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x001C3EC5 File Offset: 0x001C20C5
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

	// Token: 0x06005619 RID: 22041 RVA: 0x001C3EF1 File Offset: 0x001C20F1
	public bool CheckChallengeIfSelect(int challengeId)
	{
		return this.SelectChallengeId == challengeId;
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x001C3EFC File Offset: 0x001C20FC
	public bool GetChallengeLockState(int challengeId)
	{
		return !LifePointDrawModel.Instance.GetChallengeRequireFinishState(this.LifePointDrawActivityData.Id, challengeId);
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x001C3F18 File Offset: 0x001C2118
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

	// Token: 0x0600561C RID: 22044 RVA: 0x001C3F58 File Offset: 0x001C2158
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

	// Token: 0x0600561D RID: 22045 RVA: 0x001C3F98 File Offset: 0x001C2198
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

	// Token: 0x0600561E RID: 22046 RVA: 0x001C3FD7 File Offset: 0x001C21D7
	private void PlaySwitchSequence()
	{
		LifePointDrawDetailView panel = this.Panel;
		if (panel == null)
		{
			return;
		}
		panel.PlaySwitchSequence();
	}

	// Token: 0x0600561F RID: 22047 RVA: 0x001C3FEC File Offset: 0x001C21EC
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

	// Token: 0x06005620 RID: 22048 RVA: 0x001C4038 File Offset: 0x001C2238
	public string GetChallengeTitleId(int challengeId)
	{
		return LifePointDrawConfig.Instance.GetLifePointChallengeById(challengeId).Value.SubTitle;
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x001C4060 File Offset: 0x001C2260
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

	// Token: 0x06005622 RID: 22050 RVA: 0x001C40AC File Offset: 0x001C22AC
	public bool GetCurrentChallengeFinishRewardState()
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(this.LifePointDrawActivityData.Id) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(this.SelectChallengeId);
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x001C40E8 File Offset: 0x001C22E8
	public bool GetChallengeFinishState(int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(this.LifePointDrawActivityData.Id) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(challengeId);
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x001C411C File Offset: 0x001C231C
	public int GetCurrentChallengeId()
	{
		return this.SelectChallengeId;
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x001C4124 File Offset: 0x001C2324
	public void SaveCurrentChallengeRedDotState()
	{
		int currentChallengeId = this.GetCurrentChallengeId();
		LifePointDrawModel.Instance.SaveChallengeRedDotState(this.LifePointDrawActivityData.Id, currentChallengeId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawGroupRedDot, this.GroupId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawChallengeRedDot, currentChallengeId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LifePointDrawActivityData.Id);
	}

	// Token: 0x04003B81 RID: 15233
	[Nullable(2)]
	public LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x04003B82 RID: 15234
	public int GroupId;

	// Token: 0x04003B83 RID: 15235
	private int SelectChallengeId;

	// Token: 0x04003B84 RID: 15236
	[Nullable(2)]
	private LifePointDrawDetailView Panel;
}
