using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020011B8 RID: 4536
[NullableContext(1)]
[Nullable(0)]
public class BossRushLevelDetailInfo
{
	// Token: 0x06007885 RID: 30853 RVA: 0x001948BC File Offset: 0x00192ABC
	public void Phrase(int activityId, BossRushLevelData data, int[] unlockBuffs)
	{
		this.ActivityId = activityId;
		this.SetId(data.InstId);
		this.SetScore(data.Score);
		this.SetUnLockTime((double)data.StartTime / 1000.0);
		this.IsOpen = data.IsOpen;
		this.BuffInfo = new List<BossRushBuffInfo>();
		this.UnlockBuffInfo = new List<BossRushBuffInfo>();
		this.OptionBuffInfo = new List<BossRushBuffInfo>();
		this.ScoreBuffInfo = new List<BossRushBuffInfo>();
		this.AllScoreBuffInfo = new List<BossRushBuffInfo>();
		foreach (BuffSelection buffSelection in data.BuffSelectionRecord)
		{
			BossRushBuffInfo bossRushBuffInfo = new BossRushBuffInfo();
			bossRushBuffInfo.BuffId = buffSelection.BuffId;
			bossRushBuffInfo.Slot = buffSelection.Slot;
			bossRushBuffInfo.ChangeAble = (buffSelection.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffLocked && buffSelection.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffInactive);
			bossRushBuffInfo.State = buffSelection.BuffSelectionStatus;
			this.BuffInfo.Add(bossRushBuffInfo);
		}
		foreach (int buffId in this.GetConfig().Value.OptionalBuff())
		{
			BossRushBuffInfo bossRushBuffInfo2 = new BossRushBuffInfo();
			bossRushBuffInfo2.BuffId = buffId;
			bossRushBuffInfo2.Slot = -1;
			bossRushBuffInfo2.ChangeAble = true;
			this.OptionBuffInfo.Add(bossRushBuffInfo2);
		}
		foreach (int buffId2 in unlockBuffs)
		{
			BossRushBuffInfo bossRushBuffInfo3 = new BossRushBuffInfo();
			bossRushBuffInfo3.BuffId = buffId2;
			bossRushBuffInfo3.Slot = -1;
			bossRushBuffInfo3.ChangeAble = true;
			this.UnlockBuffInfo.Add(bossRushBuffInfo3);
		}
		int num = 1;
		foreach (int buffId3 in data.ScoreBuff)
		{
			BossRushBuffInfo bossRushBuffInfo4 = new BossRushBuffInfo();
			bossRushBuffInfo4.BuffId = buffId3;
			bossRushBuffInfo4.Slot = num++;
			bossRushBuffInfo4.ChangeAble = true;
			bossRushBuffInfo4.State = BossRushBuffSelectionStatus.BuffSelected;
			this.ScoreBuffInfo.Add(bossRushBuffInfo4);
		}
		for (int j = num; j <= 2; j++)
		{
			BossRushBuffInfo bossRushBuffInfo5 = new BossRushBuffInfo();
			bossRushBuffInfo5.BuffId = 0;
			bossRushBuffInfo5.Slot = num++;
			bossRushBuffInfo5.ChangeAble = (this.GetConfig().Value.ScoreBuffCount >= j);
			bossRushBuffInfo5.State = ((this.GetConfig().Value.ScoreBuffCount >= j) ? BossRushBuffSelectionStatus.BuffEmpty : BossRushBuffSelectionStatus.BuffInactive);
			this.ScoreBuffInfo.Add(bossRushBuffInfo5);
		}
		foreach (int buffId4 in this.GetConfig().Value.ScoreBuff())
		{
			BossRushBuffInfo bossRushBuffInfo6 = new BossRushBuffInfo();
			bossRushBuffInfo6.BuffId = buffId4;
			bossRushBuffInfo6.Slot = -1;
			bossRushBuffInfo6.ChangeAble = true;
			this.AllScoreBuffInfo.Add(bossRushBuffInfo6);
		}
		this.RoleInfo = new List<BossRushRoleInfo>();
		int num2 = 0;
		foreach (int roleId in data.CharacterSelectionRecord)
		{
			BossRushRoleInfo bossRushRoleInfo = new BossRushRoleInfo();
			bossRushRoleInfo.RoleId = roleId;
			bossRushRoleInfo.Slot = num2;
			num2++;
			this.RoleInfo.Add(bossRushRoleInfo);
		}
	}

	// Token: 0x06007886 RID: 30854 RVA: 0x00194C50 File Offset: 0x00192E50
	public void SetId(int id)
	{
		this.Id = id;
	}

	// Token: 0x06007887 RID: 30855 RVA: 0x00194C59 File Offset: 0x00192E59
	public void SetScore(int score)
	{
		this.Score = score;
	}

	// Token: 0x06007888 RID: 30856 RVA: 0x00194C62 File Offset: 0x00192E62
	public void SetUnLockTime(double unLockTime)
	{
		this.UnLockTime = unLockTime;
	}

	// Token: 0x06007889 RID: 30857 RVA: 0x00194C6B File Offset: 0x00192E6B
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600788A RID: 30858 RVA: 0x00194C74 File Offset: 0x00192E74
	public string GetMonsterTexturePath()
	{
		return this.GetConfig().Value.PreviewTexture;
	}

	// Token: 0x0600788B RID: 30859 RVA: 0x00194C98 File Offset: 0x00192E98
	public string GetBigMonsterTexturePath()
	{
		return this.GetConfig().Value.StageTexture;
	}

	// Token: 0x0600788C RID: 30860 RVA: 0x00194CBC File Offset: 0x00192EBC
	public string GetMonsterName()
	{
		int bossInfo = this.GetConfig().Value.BossInfo;
		Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(bossInfo);
		if (monsterInfoConfig == null)
		{
			return "";
		}
		return monsterInfoConfig.Value.Name;
	}

	// Token: 0x0600788D RID: 30861 RVA: 0x00194D0C File Offset: 0x00192F0C
	public string GetLevelDesc()
	{
		return this.GetConfig().Value.LevelDesc;
	}

	// Token: 0x0600788E RID: 30862 RVA: 0x00194D30 File Offset: 0x00192F30
	public int[] GetRecommendElementIdArray()
	{
		return this.GetInstanceDungeonConfig().Value.RecommendElement().ToArray<int>();
	}

	// Token: 0x0600788F RID: 30863 RVA: 0x00194D58 File Offset: 0x00192F58
	public bool GetUnLockState()
	{
		return this.IsOpen;
	}

	// Token: 0x06007890 RID: 30864 RVA: 0x00194D60 File Offset: 0x00192F60
	public int GetScore()
	{
		return this.Score;
	}

	// Token: 0x06007891 RID: 30865 RVA: 0x00194D68 File Offset: 0x00192F68
	public string GetUnlockTimeText()
	{
		if (TimeUtil.Instance.GetServerTime() >= this.UnLockTime)
		{
			return ConfigMultiTextLang.GetLocalTextNew("BossRushUnlockCondition", null) ?? "";
		}
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(this.UnLockTime - TimeUtil.Instance.GetServerTime());
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushUnLockTime", null);
		if (localTextNew == null)
		{
			return "";
		}
		return StringUtils.Format(localTextNew, new string[]
		{
			remainTimeDataFormat.CountDownText ?? ""
		});
	}

	// Token: 0x06007892 RID: 30866 RVA: 0x00194DEB File Offset: 0x00192FEB
	public double GetUnLockTime()
	{
		return this.UnLockTime;
	}

	// Token: 0x06007893 RID: 30867 RVA: 0x00194DF3 File Offset: 0x00192FF3
	public BossRushActivity? GetConfig()
	{
		return BossRushConfig.Instance.GetBossRushByActivityIdAndInstanceId(this.ActivityId, this.Id);
	}

	// Token: 0x06007894 RID: 30868 RVA: 0x00194E0C File Offset: 0x0019300C
	public int GetMaxBuffCount()
	{
		if (BossRushModel.Instance.CurrentSelectBuffTabName != EBuffTabName.Normal)
		{
			return this.GetConfig().Value.ScoreBuffCount;
		}
		return this.GetConfig().Value.BuffCount;
	}

	// Token: 0x06007895 RID: 30869 RVA: 0x00194E54 File Offset: 0x00193054
	public int GetInstanceDungeonId()
	{
		return this.GetConfig().Value.InstId;
	}

	// Token: 0x06007896 RID: 30870 RVA: 0x00194E78 File Offset: 0x00193078
	public int GetInstanceDungeonFormationId()
	{
		return this.GetInstanceDungeonConfig().Value.FightFormationId;
	}

	// Token: 0x06007897 RID: 30871 RVA: 0x00194E9C File Offset: 0x0019309C
	public int GetInstanceDungeonFormationNumb()
	{
		Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(this.GetInstanceDungeonFormationId());
		if (fightFormationConfig == null)
		{
			return 0;
		}
		return fightFormationConfig.Value.LimitCount().Length;
	}

	// Token: 0x06007898 RID: 30872 RVA: 0x00194ED8 File Offset: 0x001930D8
	public InstanceDungeon? GetInstanceDungeonConfig()
	{
		int instId = this.GetConfig().Value.InstId;
		return InstanceDungeonConfig.Instance.GetConfig(instId);
	}

	// Token: 0x06007899 RID: 30873 RVA: 0x00194F08 File Offset: 0x00193108
	public BossRushTeamInfo ConvertToTeamInfo()
	{
		BossRushTeamInfo bossRushTeamInfo = new BossRushTeamInfo();
		bossRushTeamInfo.SetCurrentSelectLevel(this);
		List<int> list = new List<int>();
		foreach (BossRushRoleInfo bossRushRoleInfo in this.RoleInfo)
		{
			int roleId = bossRushRoleInfo.RoleId;
			if (roleId >= 100000)
			{
				TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(roleId);
				if (trialRoleConfig != null)
				{
					TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(trialRoleConfig.Value.GroupId);
					if (trialRoleConfigByGroupId != null)
					{
						list.Add(trialRoleConfigByGroupId.Value.Id);
					}
				}
			}
			else
			{
				list.Add(roleId);
			}
		}
		bossRushTeamInfo.SetCurrentTeamMembers(list.ToArray());
		bossRushTeamInfo.LevelInfo = this;
		bossRushTeamInfo.InitLevelBuff(this.BuffInfo.ToArray(), this.UnlockBuffInfo.ToArray(), this.OptionBuffInfo.ToArray(), this.ScoreBuffInfo.ToArray(), this.AllScoreBuffInfo.ToArray());
		bossRushTeamInfo.InitPrepareSelectBuff();
		bossRushTeamInfo.InitPrepareSelectScoreBuff();
		bossRushTeamInfo.ActivityId = this.ActivityId;
		return bossRushTeamInfo;
	}

	// Token: 0x04003766 RID: 14182
	private int ActivityId;

	// Token: 0x04003767 RID: 14183
	private int Id;

	// Token: 0x04003768 RID: 14184
	private int Score;

	// Token: 0x04003769 RID: 14185
	private double UnLockTime;

	// Token: 0x0400376A RID: 14186
	private List<BossRushBuffInfo> BuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x0400376B RID: 14187
	private List<BossRushBuffInfo> UnlockBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x0400376C RID: 14188
	private List<BossRushBuffInfo> OptionBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x0400376D RID: 14189
	private List<BossRushBuffInfo> ScoreBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x0400376E RID: 14190
	private List<BossRushBuffInfo> AllScoreBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x0400376F RID: 14191
	private List<BossRushRoleInfo> RoleInfo = new List<BossRushRoleInfo>();

	// Token: 0x04003770 RID: 14192
	private bool IsOpen;
}
