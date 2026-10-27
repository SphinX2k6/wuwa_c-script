using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000F14 RID: 3860
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupData
{
	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x06006177 RID: 24951 RVA: 0x0013009C File Offset: 0x0012E29C
	// (set) Token: 0x06006178 RID: 24952 RVA: 0x001300A4 File Offset: 0x0012E2A4
	public long UUID { get; set; }

	// Token: 0x06006179 RID: 24953 RVA: 0x001300AD File Offset: 0x0012E2AD
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x001300BC File Offset: 0x0012E2BC
	public AchievementGroupData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600617B RID: 24955 RVA: 0x001300EF File Offset: 0x0012E2EF
	public void Phrase(AchievementGroupEntry message)
	{
		this.HasGetRewardState = new bool?(message.IsReceive);
		this.FinishTime = new long?((long)((ulong)message.FinishTime));
		this.IfUnLock = true;
	}

	// Token: 0x0600617C RID: 24956 RVA: 0x0013011B File Offset: 0x0012E31B
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x00130123 File Offset: 0x0012E323
	public int GetSort()
	{
		return AchievementConfig.Instance.GetAchievementGroupSort(this.Id);
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x00130135 File Offset: 0x0012E335
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetAchievementGroupTitle(this.Id);
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x00130147 File Offset: 0x0012E347
	public string GetTitleId()
	{
		return AchievementConfig.Instance.GetAchievementGroupTitleId(this.Id);
	}

	// Token: 0x06006180 RID: 24960 RVA: 0x00130159 File Offset: 0x0012E359
	public string GetTexture()
	{
		return AchievementConfig.Instance.GetAchievementGroupIcon(this.Id);
	}

	// Token: 0x06006181 RID: 24961 RVA: 0x0013016B File Offset: 0x0012E36B
	public string GetSmallIcon()
	{
		return AchievementConfig.Instance.GetAchievementGroupSmallIcon(this.Id);
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x0013017D File Offset: 0x0012E37D
	public string GetBackgroundIcon()
	{
		return AchievementConfig.Instance.GetAchievementGroupBackgroundIcon(this.Id);
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x0013018F File Offset: 0x0012E38F
	public int GetCategory()
	{
		return AchievementConfig.Instance.GetAchievementGroupCategory(this.Id);
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x001301A1 File Offset: 0x0012E3A1
	public long? GetFinishTime()
	{
		return this.FinishTime;
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x001301A9 File Offset: 0x0012E3A9
	public bool GetShowState()
	{
		return this.IfUnLock && AchievementConfig.Instance.GetAchievementGroupEnable(this.Id);
	}

	// Token: 0x06006186 RID: 24966 RVA: 0x001301CC File Offset: 0x0012E3CC
	public List<TItem> GetRewards()
	{
		if (!this.RewardInitState)
		{
			this.Rewards = new List<TItem>();
			DropPackage? achievementGroupReward = AchievementConfig.Instance.GetAchievementGroupReward(this.Id);
			if (achievementGroupReward != null)
			{
				int dropPreviewLength = achievementGroupReward.Value.DropPreviewLength;
				for (int i = 0; i < dropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = achievementGroupReward.Value.DropPreview(i);
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
					this.Rewards.Add(item);
				}
			}
			this.RewardInitState = true;
		}
		return this.Rewards;
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x00130286 File Offset: 0x0012E486
	public bool SmallItemRedPoint()
	{
		return this.RedPoint() || AchievementModel.Instance.GetGroupAchievementsIsRedDot(this.Id);
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x001302A2 File Offset: 0x0012E4A2
	public bool RedPoint()
	{
		return this.GetFinishState() == EAchievementStateEnum.CanGetReward && this.GetShowState() && this.GetRewards().Count > 0;
	}

	// Token: 0x06006189 RID: 24969 RVA: 0x001302CC File Offset: 0x0012E4CC
	public int GetCurrentProgress()
	{
		List<AchievementData> groupAchievements = AchievementModel.Instance.GetGroupAchievements(this.Id, true);
		int num = 0;
		using (List<AchievementData>.Enumerator enumerator = groupAchievements.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetFinishState() != EAchievementStateEnum.UnFinished)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x00130330 File Offset: 0x0012E530
	public int GetMaxProgress()
	{
		List<AchievementData> groupAchievements = AchievementModel.Instance.GetGroupAchievements(this.Id, true);
		int num = 0;
		using (List<AchievementData>.Enumerator enumerator = groupAchievements.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetShowState())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x00130394 File Offset: 0x0012E594
	public EAchievementStateEnum GetFinishState()
	{
		if (this.HasGetRewardState.GetValueOrDefault())
		{
			return EAchievementStateEnum.HaveGetReward;
		}
		long? finishTime = this.FinishTime;
		long num = 0L;
		if (finishTime.GetValueOrDefault() > num & finishTime != null)
		{
			return EAchievementStateEnum.CanGetReward;
		}
		return EAchievementStateEnum.UnFinished;
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x001303D4 File Offset: 0x0012E5D4
	public string GetAchievementGroupProgress()
	{
		int num = 0;
		int num2 = 0;
		foreach (AchievementData achievementData in AchievementModel.Instance.GetGroupAchievements(this.Id, false))
		{
			if (achievementData.GetId() == 200101)
			{
				achievementData.PrintUnsafeAddress();
			}
			EAchievementStateEnum finishState = achievementData.GetFinishState();
			if ((!achievementData.GetHiddenState() || finishState != EAchievementStateEnum.UnFinished) && achievementData.GetMaxProgress() != null)
			{
				num++;
				if (finishState != EAchievementStateEnum.UnFinished)
				{
					num2++;
				}
			}
		}
		int value = (int)Math.Round((double)num2 * 100.0 / (double)num);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04002C51 RID: 11345
	private bool? HasGetRewardState = new bool?(false);

	// Token: 0x04002C52 RID: 11346
	private long? FinishTime = new long?(0L);

	// Token: 0x04002C53 RID: 11347
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04002C54 RID: 11348
	private bool RewardInitState;

	// Token: 0x04002C55 RID: 11349
	private bool IfUnLock;

	// Token: 0x04002C56 RID: 11350
	private int Id;
}
