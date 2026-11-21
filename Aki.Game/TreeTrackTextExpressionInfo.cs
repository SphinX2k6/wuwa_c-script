using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02001247 RID: 4679
[NullableContext(1)]
[Nullable(0)]
public class TreeTrackTextExpressionInfo
{
	// Token: 0x0600B96C RID: 47468 RVA: 0x0036BE9B File Offset: 0x0036A09B
	public void Clear()
	{
		this.MainTitle = null;
		this.ClearSubTitle();
	}

	// Token: 0x0600B96D RID: 47469 RVA: 0x0036BEAC File Offset: 0x0036A0AC
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

	// Token: 0x0600B96E RID: 47470 RVA: 0x0036BEE8 File Offset: 0x0036A0E8
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

	// Token: 0x0600B96F RID: 47471 RVA: 0x0036BF24 File Offset: 0x0036A124
	public void AddSubTitle(IQuestScheduleSubTitle subTitle)
	{
		this.SubTitles.Add(new BehaviorTreeStepTextInfo(subTitle.TidTitle, subTitle.QuestScheduleType, subTitle.ShowConditions, subTitle.ConditionText, subTitle.ProgressBar, subTitle.BlankTitleStillShow, subTitle.CustomPlaceholderBindingProgressList));
	}

	// Token: 0x0600B970 RID: 47472 RVA: 0x0036BF60 File Offset: 0x0036A160
	public void AddSubTitle(BehaviorTreeStepTextInfo subTitle)
	{
		this.SubTitles.Add(new BehaviorTreeStepTextInfo(subTitle.TidTitle, subTitle.QuestScheduleType, subTitle.ShowConditions, subTitle.ConditionText, subTitle.ProgressBar, subTitle.BlankTitleStillShow, subTitle.CustomPlaceholderBindingProgressList));
	}

	// Token: 0x0600B971 RID: 47473 RVA: 0x0036BF9C File Offset: 0x0036A19C
	public void ClearSubTitle()
	{
		this.SubTitles.Clear();
	}

	// Token: 0x0600B972 RID: 47474 RVA: 0x0036BFAC File Offset: 0x0036A1AC
	public void CopyConfig(IQuestScheduleConfig config)
	{
		this.SetMainTitle(config.MainTitle);
		this.ClearSubTitle();
		foreach (IQuestScheduleSubTitle subTitle in config.SubTitles)
		{
			this.AddSubTitle(subTitle);
		}
	}

	// Token: 0x0600B973 RID: 47475 RVA: 0x0036C014 File Offset: 0x0036A214
	public void CopyConfig(TreeTrackTextExpressionInfo config)
	{
		this.SetMainTitle(config.MainTitle);
		this.ClearSubTitle();
		foreach (BehaviorTreeStepTextInfo subTitle in config.SubTitles)
		{
			this.AddSubTitle(subTitle);
		}
	}

	// Token: 0x0600B974 RID: 47476 RVA: 0x0036C07C File Offset: 0x0036A27C
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

	// Token: 0x04006AF6 RID: 27382
	[Nullable(2)]
	public BehaviorTreeStepTextInfo MainTitle;

	// Token: 0x04006AF7 RID: 27383
	public List<BehaviorTreeStepTextInfo> SubTitles = new List<BehaviorTreeStepTextInfo>();
}
