using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E75 RID: 7797
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMainQuestData : HonamiStoryQuestDataBase
{
	// Token: 0x0600EDA5 RID: 60837 RVA: 0x003898EA File Offset: 0x00387AEA
	public HonamiStoryMainQuestData()
	{
		this.TaskType = EHonamiStoryQuestType.Main;
		this.ActivityQuestId = this.ActivityData.ActivityQuestId;
	}

	// Token: 0x0600EDA6 RID: 60838 RVA: 0x0038990C File Offset: 0x00387B0C
	[NullableContext(2)]
	public override LevelPlayInfo GetLevelPlayInfo()
	{
		if (!base.IsInDungeon)
		{
			return null;
		}
		int curAreaId = HonamiStoryModel.Instance.CurAreaId;
		HonamiStoryAreaData honamiStoryAreaData = this.ActivityData.GetHonamiStoryAreaData(curAreaId);
		if (honamiStoryAreaData == null)
		{
			return null;
		}
		return LevelPlayModel.Instance.GetLevelPlayInfo(honamiStoryAreaData.LevelPlayId);
	}

	// Token: 0x0600EDA7 RID: 60839 RVA: 0x00389950 File Offset: 0x00387B50
	public override string GetNameKey()
	{
		if (base.IsInDungeon)
		{
			LevelPlayInfo levelPlayInfo = this.GetLevelPlayInfo();
			if (levelPlayInfo != null)
			{
				return levelPlayInfo.NameKey;
			}
		}
		Quest quest = QuestNewModel.Instance.GetQuest(this.ActivityQuestId);
		if (quest == null)
		{
			return "";
		}
		return quest.NameKey;
	}

	// Token: 0x0600EDA8 RID: 60840 RVA: 0x00389998 File Offset: 0x00387B98
	public override string GetDesc()
	{
		if (base.IsInDungeon)
		{
			return "";
		}
		Quest quest = QuestNewModel.Instance.GetQuest(this.ActivityQuestId);
		if (quest == null)
		{
			return "";
		}
		return quest.QuestDescribe;
	}

	// Token: 0x0600EDA9 RID: 60841 RVA: 0x003899D4 File Offset: 0x00387BD4
	public override int GetRewardId()
	{
		if (base.IsInDungeon)
		{
			LevelPlayInfo levelPlayInfo = this.GetLevelPlayInfo();
			if (levelPlayInfo != null)
			{
				return levelPlayInfo.RewardId;
			}
		}
		Quest quest = QuestNewModel.Instance.GetQuest(this.ActivityQuestId);
		if (quest == null)
		{
			return 0;
		}
		return quest.RewardId.GetValueOrDefault();
	}

	// Token: 0x0600EDAA RID: 60842 RVA: 0x00389A1E File Offset: 0x00387C1E
	public override bool IsFinished()
	{
		return HonamiStoryUtil.CheckActivityQuestFinished();
	}

	// Token: 0x0600EDAB RID: 60843 RVA: 0x00389A25 File Offset: 0x00387C25
	public override bool CanMapTrack()
	{
		return false;
	}

	// Token: 0x0600EDAC RID: 60844 RVA: 0x00389A28 File Offset: 0x00387C28
	public override bool MapTrack(bool isTrack)
	{
		Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "主线任务不能追踪", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x0600EDAD RID: 60845 RVA: 0x00389A58 File Offset: 0x00387C58
	[NullableContext(2)]
	public override BehaviorTreeViewShowData GetTreeShowData()
	{
		bool flag = HonamiStoryUtil.CheckInActivityQuest();
		if (!base.IsInDungeon && flag)
		{
			Quest quest = QuestNewModel.Instance.GetQuest(this.ActivityQuestId);
			if (quest == null)
			{
				return null;
			}
			BaseBehaviorTree tree = quest.Tree;
			if (tree == null)
			{
				return null;
			}
			Blackboard blackBoard = tree.GetBlackBoard();
			if (blackBoard == null)
			{
				return null;
			}
			return blackBoard.CreateShowData(true);
		}
		else
		{
			LevelPlayInfo levelPlayInfo = this.GetLevelPlayInfo();
			if (levelPlayInfo == null)
			{
				return null;
			}
			BaseBehaviorTree tree2 = levelPlayInfo.Tree;
			if (tree2 == null)
			{
				return null;
			}
			Blackboard blackBoard2 = tree2.GetBlackBoard();
			if (blackBoard2 == null)
			{
				return null;
			}
			return blackBoard2.CreateShowData(true);
		}
	}

	// Token: 0x04006E43 RID: 28227
	private readonly int ActivityQuestId;
}
