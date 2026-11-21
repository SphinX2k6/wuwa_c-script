using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000831 RID: 2097
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerLevelDetailInfo
{
	// Token: 0x06005F4A RID: 24394 RVA: 0x001E6D80 File Offset: 0x001E4F80
	public void Phrase(int activityId, MowTowerLevelsInfo data)
	{
		this.ActivityId = activityId;
		this.SetId(data.LevelsId);
		this.SetFirstScore(data.FirstScore);
		this.SetLowerScore(data.SecondScore);
		this.SetUnLockTime((double)data.UnlockTime / 1000.0);
		this.IsOpen = data.IsUnlock;
		this.BuffInfo = new List<MowingTowerBuffInfo>();
		this.OptionBuffInfo = new List<MowingTowerBuffInfo>();
		if (data.BuffSelection.Count == 0)
		{
			MowingTowerBuffInfo mowingTowerBuffInfo = new MowingTowerBuffInfo();
			mowingTowerBuffInfo.BuffId = 0;
			mowingTowerBuffInfo.Slot = 1;
			mowingTowerBuffInfo.ChangeAble = true;
			this.BuffInfo.Add(mowingTowerBuffInfo);
		}
		else
		{
			foreach (int buffId in data.BuffSelection)
			{
				MowingTowerBuffInfo mowingTowerBuffInfo2 = new MowingTowerBuffInfo();
				mowingTowerBuffInfo2.BuffId = buffId;
				mowingTowerBuffInfo2.Slot = 1;
				mowingTowerBuffInfo2.ChangeAble = true;
				this.BuffInfo.Add(mowingTowerBuffInfo2);
			}
		}
		foreach (int buffId2 in this.GetConfig().Value.OptionalBuff())
		{
			MowingTowerBuffInfo mowingTowerBuffInfo3 = new MowingTowerBuffInfo();
			mowingTowerBuffInfo3.BuffId = buffId2;
			mowingTowerBuffInfo3.Slot = 1;
			mowingTowerBuffInfo3.ChangeAble = true;
			this.OptionBuffInfo.Add(mowingTowerBuffInfo3);
		}
		this.FirstPartRoleInfo = new List<MowingTowerRoleInfo>();
		int num = 0;
		foreach (int roleId in data.FirstRoleSelection)
		{
			MowingTowerRoleInfo mowingTowerRoleInfo = new MowingTowerRoleInfo();
			mowingTowerRoleInfo.RoleId = roleId;
			mowingTowerRoleInfo.Slot = num;
			num++;
			this.FirstPartRoleInfo.Add(mowingTowerRoleInfo);
		}
		this.LowPartRoleInfo = new List<MowingTowerRoleInfo>();
		foreach (int roleId2 in data.SecondRoleSelection)
		{
			MowingTowerRoleInfo mowingTowerRoleInfo2 = new MowingTowerRoleInfo();
			mowingTowerRoleInfo2.RoleId = roleId2;
			mowingTowerRoleInfo2.Slot = num;
			num++;
			this.LowPartRoleInfo.Add(mowingTowerRoleInfo2);
		}
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x001E6FC4 File Offset: 0x001E51C4
	public void SetId(int id)
	{
		this.Id = id;
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x001E6FCD File Offset: 0x001E51CD
	public void SetFirstScore(int score)
	{
		this.FirstPartScore = score;
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x001E6FD6 File Offset: 0x001E51D6
	public void SetLowerScore(int score)
	{
		this.LowPartScore = score;
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x001E6FDF File Offset: 0x001E51DF
	public void SetUnLockTime(double unLockTime)
	{
		this.UnLockTime = unLockTime;
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x001E6FE8 File Offset: 0x001E51E8
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06005F50 RID: 24400 RVA: 0x001E6FF0 File Offset: 0x001E51F0
	public string GetNormalTexturePath()
	{
		return this.GetConfig().Value.NormalTexture;
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x001E7014 File Offset: 0x001E5214
	public string GetLockTexturePath()
	{
		return this.GetConfig().Value.LockTexture;
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x001E7038 File Offset: 0x001E5238
	public int[] GetRecommendElementIdArray(ETeamBelong belongTo)
	{
		return this.GetInstanceDungeonConfig(belongTo).Value.RecommendElement();
	}

	// Token: 0x06005F53 RID: 24403 RVA: 0x001E705C File Offset: 0x001E525C
	public bool GetUnLockState()
	{
		return this.IsOpen;
	}

	// Token: 0x06005F54 RID: 24404 RVA: 0x001E7064 File Offset: 0x001E5264
	public int GetScore()
	{
		return this.FirstPartScore + this.LowPartScore;
	}

	// Token: 0x06005F55 RID: 24405 RVA: 0x001E7073 File Offset: 0x001E5273
	public int GetFirstScore()
	{
		return this.FirstPartScore;
	}

	// Token: 0x06005F56 RID: 24406 RVA: 0x001E707B File Offset: 0x001E527B
	public int GetLowScore()
	{
		return this.LowPartScore;
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x001E7084 File Offset: 0x001E5284
	public string GetLevelTips()
	{
		return this.GetConfig().Value.LevelTips;
	}

	// Token: 0x06005F58 RID: 24408 RVA: 0x001E70A8 File Offset: 0x001E52A8
	public string GetUnlockTimeText()
	{
		if (TimeUtil.Instance.GetServerTime() < this.UnLockTime)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(this.UnLockTime - TimeUtil.Instance.GetServerTime());
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MowingTowerUnLockTime", null), new string[]
			{
				remainTimeDataFormat.CountDownText
			});
		}
		return ConfigMultiTextLang.GetLocalTextNew("MowingTowerUnlockCondition", null);
	}

	// Token: 0x06005F59 RID: 24409 RVA: 0x001E710E File Offset: 0x001E530E
	public double GetUnLockTime()
	{
		return this.UnLockTime;
	}

	// Token: 0x06005F5A RID: 24410 RVA: 0x001E7116 File Offset: 0x001E5316
	public MowTowerLevelsRe? GetConfig()
	{
		return MowingTowerConfig.Instance.GetBossMowingTowerConfigById(this.Id);
	}

	// Token: 0x06005F5B RID: 24411 RVA: 0x001E7128 File Offset: 0x001E5328
	public int GetMaxBuffCount()
	{
		return this.GetConfig().Value.BuffCount;
	}

	// Token: 0x06005F5C RID: 24412 RVA: 0x001E714C File Offset: 0x001E534C
	public int GetInstanceDungeonId()
	{
		return this.GetConfig().Value.InstIds()[0];
	}

	// Token: 0x06005F5D RID: 24413 RVA: 0x001E7174 File Offset: 0x001E5374
	public bool GetIsInfinite()
	{
		return this.GetConfig().Value.IsInfinite;
	}

	// Token: 0x06005F5E RID: 24414 RVA: 0x001E7198 File Offset: 0x001E5398
	public string GetLevelDesc()
	{
		return this.GetConfig().Value.LevelDesc;
	}

	// Token: 0x06005F5F RID: 24415 RVA: 0x001E71BC File Offset: 0x001E53BC
	public InstanceDungeon? GetInstanceDungeonConfig(ETeamBelong belongTo)
	{
		int id = this.GetConfig().Value.InstIds()[(int)belongTo];
		return InstanceDungeonConfig.Instance.GetConfig(id);
	}

	// Token: 0x06005F60 RID: 24416 RVA: 0x001E71F0 File Offset: 0x001E53F0
	public MowingTowerTeamInfo ConvertToTeamInfo()
	{
		MowingTowerTeamInfo mowingTowerTeamInfo = new MowingTowerTeamInfo();
		mowingTowerTeamInfo.SetCurrentSelectLevel(this);
		List<int> list = new List<int>();
		foreach (MowingTowerRoleInfo mowingTowerRoleInfo in this.FirstPartRoleInfo)
		{
			list.Add(mowingTowerRoleInfo.RoleId);
		}
		List<int> list2 = new List<int>();
		foreach (MowingTowerRoleInfo mowingTowerRoleInfo2 in this.LowPartRoleInfo)
		{
			list2.Add(mowingTowerRoleInfo2.RoleId);
		}
		mowingTowerTeamInfo.SetCurrentTeamMembers(list.ToArray(), list2.ToArray());
		mowingTowerTeamInfo.LevelInfo = this;
		mowingTowerTeamInfo.InitLevelBuff(this.BuffInfo.ToArray(), this.OptionBuffInfo.ToArray());
		mowingTowerTeamInfo.InitPrepareSelectBuff();
		mowingTowerTeamInfo.ActivityId = this.ActivityId;
		return mowingTowerTeamInfo;
	}

	// Token: 0x04003E86 RID: 16006
	private int ActivityId;

	// Token: 0x04003E87 RID: 16007
	private int Id;

	// Token: 0x04003E88 RID: 16008
	private int FirstPartScore;

	// Token: 0x04003E89 RID: 16009
	private int LowPartScore;

	// Token: 0x04003E8A RID: 16010
	private double UnLockTime;

	// Token: 0x04003E8B RID: 16011
	private List<MowingTowerBuffInfo> BuffInfo = new List<MowingTowerBuffInfo>();

	// Token: 0x04003E8C RID: 16012
	private List<MowingTowerBuffInfo> OptionBuffInfo = new List<MowingTowerBuffInfo>();

	// Token: 0x04003E8D RID: 16013
	private List<MowingTowerRoleInfo> FirstPartRoleInfo = new List<MowingTowerRoleInfo>();

	// Token: 0x04003E8E RID: 16014
	private List<MowingTowerRoleInfo> LowPartRoleInfo = new List<MowingTowerRoleInfo>();

	// Token: 0x04003E8F RID: 16015
	private bool IsOpen;
}
