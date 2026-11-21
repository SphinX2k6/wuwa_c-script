using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001337 RID: 4919
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMainQuestData : HonamiStoryQuestDataBase
{
	// Token: 0x0600C1C4 RID: 49604 RVA: 0x003954DA File Offset: 0x003936DA
	public HonamiStoryMainQuestData()
	{
		this.TaskType = EHonamiStoryQuestType.Main;
		this.ActivityQuestId = this.ActivityData.ActivityQuestId;
	}

	// Token: 0x0600C1C5 RID: 49605 RVA: 0x003954FC File Offset: 0x003936FC
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

	// Token: 0x0600C1C6 RID: 49606 RVA: 0x00395540 File Offset: 0x00393740
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

	// Token: 0x0600C1C7 RID: 49607 RVA: 0x00395588 File Offset: 0x00393788
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

	// Token: 0x0600C1C8 RID: 49608 RVA: 0x003955C4 File Offset: 0x003937C4
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

	// Token: 0x0600C1C9 RID: 49609 RVA: 0x0039560E File Offset: 0x0039380E
	public override bool IsFinished()
	{
		return HonamiStoryUtil.CheckActivityQuestFinished();
	}

	// Token: 0x0600C1CA RID: 49610 RVA: 0x00395615 File Offset: 0x00393815
	public override bool CanMapTrack()
	{
		return false;
	}

	// Token: 0x0600C1CB RID: 49611 RVA: 0x00395618 File Offset: 0x00393818
	public override bool MapTrack(bool isTrack)
	{
		Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "主线任务不能追踪", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x0600C1CC RID: 49612 RVA: 0x00395648 File Offset: 0x00393848
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

	// Token: 0x04006F24 RID: 28452
	private readonly int ActivityQuestId;
}
