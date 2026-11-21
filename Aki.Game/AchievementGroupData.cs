using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020003C9 RID: 969
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupData
{
	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x0600350F RID: 13583 RVA: 0x001389C0 File Offset: 0x00136BC0
	// (set) Token: 0x06003510 RID: 13584 RVA: 0x001389C8 File Offset: 0x00136BC8
	public long UUID { get; set; }

	// Token: 0x06003511 RID: 13585 RVA: 0x001389D1 File Offset: 0x00136BD1
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x001389E0 File Offset: 0x00136BE0
	public AchievementGroupData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06003513 RID: 13587 RVA: 0x00138A13 File Offset: 0x00136C13
	public void Phrase(AchievementGroupEntry message)
	{
		this.HasGetRewardState = new bool?(message.IsReceive);
		this.FinishTime = new long?((long)((ulong)message.FinishTime));
		this.IfUnLock = true;
	}

	// Token: 0x06003514 RID: 13588 RVA: 0x00138A3F File Offset: 0x00136C3F
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06003515 RID: 13589 RVA: 0x00138A47 File Offset: 0x00136C47
	public int GetSort()
	{
		return AchievementConfig.Instance.GetAchievementGroupSort(this.Id);
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x00138A59 File Offset: 0x00136C59
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetAchievementGroupTitle(this.Id);
	}

	// Token: 0x06003517 RID: 13591 RVA: 0x00138A6B File Offset: 0x00136C6B
	public string GetTitleId()
	{
		return AchievementConfig.Instance.GetAchievementGroupTitleId(this.Id);
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x00138A7D File Offset: 0x00136C7D
	public string GetTexture()
	{
		return AchievementConfig.Instance.GetAchievementGroupIcon(this.Id);
	}

	// Token: 0x06003519 RID: 13593 RVA: 0x00138A8F File Offset: 0x00136C8F
	public string GetSmallIcon()
	{
		return AchievementConfig.Instance.GetAchievementGroupSmallIcon(this.Id);
	}

	// Token: 0x0600351A RID: 13594 RVA: 0x00138AA1 File Offset: 0x00136CA1
	public string GetBackgroundIcon()
	{
		return AchievementConfig.Instance.GetAchievementGroupBackgroundIcon(this.Id);
	}

	// Token: 0x0600351B RID: 13595 RVA: 0x00138AB3 File Offset: 0x00136CB3
	public int GetCategory()
	{
		return AchievementConfig.Instance.GetAchievementGroupCategory(this.Id);
	}

	// Token: 0x0600351C RID: 13596 RVA: 0x00138AC5 File Offset: 0x00136CC5
	public long? GetFinishTime()
	{
		return this.FinishTime;
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x00138ACD File Offset: 0x00136CCD
	public bool GetShowState()
	{
		return this.IfUnLock && AchievementConfig.Instance.GetAchievementGroupEnable(this.Id);
	}

	// Token: 0x0600351E RID: 13598 RVA: 0x00138AF0 File Offset: 0x00136CF0
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

	// Token: 0x0600351F RID: 13599 RVA: 0x00138BAA File Offset: 0x00136DAA
	public bool SmallItemRedPoint()
	{
		return this.RedPoint() || AchievementModel.Instance.GetGroupAchievementsIsRedDot(this.Id);
	}

	// Token: 0x06003520 RID: 13600 RVA: 0x00138BC6 File Offset: 0x00136DC6
	public bool RedPoint()
	{
		return this.GetFinishState() == EAchievementStateEnum.CanGetReward && this.GetShowState() && this.GetRewards().Count > 0;
	}

	// Token: 0x06003521 RID: 13601 RVA: 0x00138BF0 File Offset: 0x00136DF0
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

	// Token: 0x06003522 RID: 13602 RVA: 0x00138C54 File Offset: 0x00136E54
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

	// Token: 0x06003523 RID: 13603 RVA: 0x00138CB8 File Offset: 0x00136EB8
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

	// Token: 0x06003524 RID: 13604 RVA: 0x00138CF8 File Offset: 0x00136EF8
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

	// Token: 0x04002CEA RID: 11498
	private bool? HasGetRewardState = new bool?(false);

	// Token: 0x04002CEB RID: 11499
	private long? FinishTime = new long?(0L);

	// Token: 0x04002CEC RID: 11500
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04002CED RID: 11501
	private bool RewardInitState;

	// Token: 0x04002CEE RID: 11502
	private bool IfUnLock;

	// Token: 0x04002CEF RID: 11503
	private int Id;
}
