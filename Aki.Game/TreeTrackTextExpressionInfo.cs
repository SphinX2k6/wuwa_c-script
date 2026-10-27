using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02001D85 RID: 7557
[NullableContext(1)]
[Nullable(0)]
public class TreeTrackTextExpressionInfo
{
	// Token: 0x0600E54E RID: 58702 RVA: 0x00360247 File Offset: 0x0035E447
	public void Clear()
	{
		this.MainTitle = null;
		this.ClearSubTitle();
	}

	// Token: 0x0600E54F RID: 58703 RVA: 0x00360258 File Offset: 0x0035E458
	[NullableContext(2)]
	public void SetMainTitle(IQuestScheduleMainTitle mainTitle)
	{
		if (mainTitle == null)
		{
			this.MainTitle = null;
			return;
		}
		this.MainTitle = new BehaviorTreeStepTextInfo(mainTitle.TidTitle, mainTitle.QuestScheduleType, null, null, null, null, null);
	}

	// Token: 0x0600E550 RID: 58704 RVA: 0x00360294 File Offset: 0x0035E494
	[NullableContext(2)]
	public void SetMainTitle(BehaviorTreeStepTextInfo mainTitle)
	{
		if (mainTitle == null)
		{
			this.MainTitle = null;
			return;
		}
		this.MainTitle = new BehaviorTreeStepTextInfo(mainTitle.TidTitle, mainTitle.QuestScheduleType, null, null, null, null, null);
	}

	// Token: 0x0600E551 RID: 58705 RVA: 0x003602D0 File Offset: 0x0035E4D0
	public void AddSubTitle(IQuestScheduleSubTitle subTitle)
	{
		this.SubTitles.Add(new BehaviorTreeStepTextInfo(subTitle.TidTitle, subTitle.QuestScheduleType, subTitle.ShowConditions, subTitle.ConditionText, subTitle.ProgressBar, subTitle.BlankTitleStillShow, subTitle.CustomPlaceholderBindingProgressList));
	}

	// Token: 0x0600E552 RID: 58706 RVA: 0x0036030C File Offset: 0x0035E50C
	public void AddSubTitle(BehaviorTreeStepTextInfo subTitle)
	{
		this.SubTitles.Add(new BehaviorTreeStepTextInfo(subTitle.TidTitle, subTitle.QuestScheduleType, subTitle.ShowConditions, subTitle.ConditionText, subTitle.ProgressBar, subTitle.BlankTitleStillShow, subTitle.CustomPlaceholderBindingProgressList));
	}

	// Token: 0x0600E553 RID: 58707 RVA: 0x00360348 File Offset: 0x0035E548
	public void ClearSubTitle()
	{
		this.SubTitles.Clear();
	}

	// Token: 0x0600E554 RID: 58708 RVA: 0x00360358 File Offset: 0x0035E558
	public void CopyConfig(IQuestScheduleConfig config)
	{
		this.SetMainTitle(config.MainTitle);
		this.ClearSubTitle();
		foreach (IQuestScheduleSubTitle subTitle in config.SubTitles)
		{
			this.AddSubTitle(subTitle);
		}
	}

	// Token: 0x0600E555 RID: 58709 RVA: 0x003603C0 File Offset: 0x0035E5C0
	public void CopyConfig(TreeTrackTextExpressionInfo config)
	{
		this.SetMainTitle(config.MainTitle);
		this.ClearSubTitle();
		foreach (BehaviorTreeStepTextInfo subTitle in config.SubTitles)
		{
			this.AddSubTitle(subTitle);
		}
	}

	// Token: 0x0600E556 RID: 58710 RVA: 0x00360428 File Offset: 0x0035E628
	public bool IsSubTitle(int nodeId)
	{
		if (this.SubTitles.Count == 0)
		{
			return false;
		}
		foreach (BehaviorTreeStepTextInfo behaviorTreeStepTextInfo in this.SubTitles)
		{
			IQuestScheduleChildQuestCompleted questScheduleChildQuestCompleted = behaviorTreeStepTextInfo.QuestScheduleType as IQuestScheduleChildQuestCompleted;
			if (questScheduleChildQuestCompleted != null && questScheduleChildQuestCompleted.ChildQuestId == nodeId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04006A15 RID: 27157
	[Nullable(2)]
	public BehaviorTreeStepTextInfo MainTitle;

	// Token: 0x04006A16 RID: 27158
	public List<BehaviorTreeStepTextInfo> SubTitles = new List<BehaviorTreeStepTextInfo>();
}
