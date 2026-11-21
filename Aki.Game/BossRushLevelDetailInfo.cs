using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200066C RID: 1644
[NullableContext(1)]
[Nullable(0)]
public class BossRushLevelDetailInfo
{
	// Token: 0x06004C1C RID: 19484 RVA: 0x0019D4C4 File Offset: 0x0019B6C4
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

	// Token: 0x06004C1D RID: 19485 RVA: 0x0019D858 File Offset: 0x0019BA58
	public void SetId(int id)
	{
		this.Id = id;
	}

	// Token: 0x06004C1E RID: 19486 RVA: 0x0019D861 File Offset: 0x0019BA61
	public void SetScore(int score)
	{
		this.Score = score;
	}

	// Token: 0x06004C1F RID: 19487 RVA: 0x0019D86A File Offset: 0x0019BA6A
	public void SetUnLockTime(double unLockTime)
	{
		this.UnLockTime = unLockTime;
	}

	// Token: 0x06004C20 RID: 19488 RVA: 0x0019D873 File Offset: 0x0019BA73
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06004C21 RID: 19489 RVA: 0x0019D87C File Offset: 0x0019BA7C
	public string GetMonsterTexturePath()
	{
		return this.GetConfig().Value.PreviewTexture;
	}

	// Token: 0x06004C22 RID: 19490 RVA: 0x0019D8A0 File Offset: 0x0019BAA0
	public string GetBigMonsterTexturePath()
	{
		return this.GetConfig().Value.StageTexture;
	}

	// Token: 0x06004C23 RID: 19491 RVA: 0x0019D8C4 File Offset: 0x0019BAC4
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

	// Token: 0x06004C24 RID: 19492 RVA: 0x0019D914 File Offset: 0x0019BB14
	public string GetLevelDesc()
	{
		return this.GetConfig().Value.LevelDesc;
	}

	// Token: 0x06004C25 RID: 19493 RVA: 0x0019D938 File Offset: 0x0019BB38
	public int[] GetRecommendElementIdArray()
	{
		return this.GetInstanceDungeonConfig().Value.RecommendElement().ToArray<int>();
	}

	// Token: 0x06004C26 RID: 19494 RVA: 0x0019D960 File Offset: 0x0019BB60
	public bool GetUnLockState()
	{
		return this.IsOpen;
	}

	// Token: 0x06004C27 RID: 19495 RVA: 0x0019D968 File Offset: 0x0019BB68
	public int GetScore()
	{
		return this.Score;
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x0019D970 File Offset: 0x0019BB70
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

	// Token: 0x06004C29 RID: 19497 RVA: 0x0019D9F3 File Offset: 0x0019BBF3
	public double GetUnLockTime()
	{
		return this.UnLockTime;
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x0019D9FB File Offset: 0x0019BBFB
	public BossRushActivity? GetConfig()
	{
		return BossRushConfig.Instance.GetBossRushByActivityIdAndInstanceId(this.ActivityId, this.Id);
	}

	// Token: 0x06004C2B RID: 19499 RVA: 0x0019DA14 File Offset: 0x0019BC14
	public int GetMaxBuffCount()
	{
		if (BossRushModel.Instance.CurrentSelectBuffTabName != EBuffTabName.Normal)
		{
			return this.GetConfig().Value.ScoreBuffCount;
		}
		return this.GetConfig().Value.BuffCount;
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x0019DA5C File Offset: 0x0019BC5C
	public int GetInstanceDungeonId()
	{
		return this.GetConfig().Value.InstId;
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x0019DA80 File Offset: 0x0019BC80
	public int GetInstanceDungeonFormationId()
	{
		return this.GetInstanceDungeonConfig().Value.FightFormationId;
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x0019DAA4 File Offset: 0x0019BCA4
	public int GetInstanceDungeonFormationNumb()
	{
		Aki.Config.FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(this.GetInstanceDungeonFormationId());
		if (fightFormationConfig == null)
		{
			return 0;
		}
		return fightFormationConfig.Value.LimitCount().Length;
	}

	// Token: 0x06004C2F RID: 19503 RVA: 0x0019DAE0 File Offset: 0x0019BCE0
	public InstanceDungeon? GetInstanceDungeonConfig()
	{
		int instId = this.GetConfig().Value.InstId;
		return InstanceDungeonConfig.Instance.GetConfig(instId);
	}

	// Token: 0x06004C30 RID: 19504 RVA: 0x0019DB10 File Offset: 0x0019BD10
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

	// Token: 0x040037FF RID: 14335
	private int ActivityId;

	// Token: 0x04003800 RID: 14336
	private int Id;

	// Token: 0x04003801 RID: 14337
	private int Score;

	// Token: 0x04003802 RID: 14338
	private double UnLockTime;

	// Token: 0x04003803 RID: 14339
	private List<BossRushBuffInfo> BuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x04003804 RID: 14340
	private List<BossRushBuffInfo> UnlockBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x04003805 RID: 14341
	private List<BossRushBuffInfo> OptionBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x04003806 RID: 14342
	private List<BossRushBuffInfo> ScoreBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x04003807 RID: 14343
	private List<BossRushBuffInfo> AllScoreBuffInfo = new List<BossRushBuffInfo>();

	// Token: 0x04003808 RID: 14344
	private List<BossRushRoleInfo> RoleInfo = new List<BossRushRoleInfo>();

	// Token: 0x04003809 RID: 14345
	private bool IsOpen;
}
