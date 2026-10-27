using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200137D RID: 4989
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerLevelDetailInfo
{
	// Token: 0x06008BAF RID: 35759 RVA: 0x001DDF50 File Offset: 0x001DC150
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

	// Token: 0x06008BB0 RID: 35760 RVA: 0x001DE194 File Offset: 0x001DC394
	public void SetId(int id)
	{
		this.Id = id;
	}

	// Token: 0x06008BB1 RID: 35761 RVA: 0x001DE19D File Offset: 0x001DC39D
	public void SetFirstScore(int score)
	{
		this.FirstPartScore = score;
	}

	// Token: 0x06008BB2 RID: 35762 RVA: 0x001DE1A6 File Offset: 0x001DC3A6
	public void SetLowerScore(int score)
	{
		this.LowPartScore = score;
	}

	// Token: 0x06008BB3 RID: 35763 RVA: 0x001DE1AF File Offset: 0x001DC3AF
	public void SetUnLockTime(double unLockTime)
	{
		this.UnLockTime = unLockTime;
	}

	// Token: 0x06008BB4 RID: 35764 RVA: 0x001DE1B8 File Offset: 0x001DC3B8
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06008BB5 RID: 35765 RVA: 0x001DE1C0 File Offset: 0x001DC3C0
	public string GetNormalTexturePath()
	{
		return this.GetConfig().Value.NormalTexture;
	}

	// Token: 0x06008BB6 RID: 35766 RVA: 0x001DE1E4 File Offset: 0x001DC3E4
	public string GetLockTexturePath()
	{
		return this.GetConfig().Value.LockTexture;
	}

	// Token: 0x06008BB7 RID: 35767 RVA: 0x001DE208 File Offset: 0x001DC408
	public int[] GetRecommendElementIdArray(ETeamBelong belongTo)
	{
		return this.GetInstanceDungeonConfig(belongTo).Value.RecommendElement();
	}

	// Token: 0x06008BB8 RID: 35768 RVA: 0x001DE22C File Offset: 0x001DC42C
	public bool GetUnLockState()
	{
		return this.IsOpen;
	}

	// Token: 0x06008BB9 RID: 35769 RVA: 0x001DE234 File Offset: 0x001DC434
	public int GetScore()
	{
		return this.FirstPartScore + this.LowPartScore;
	}

	// Token: 0x06008BBA RID: 35770 RVA: 0x001DE243 File Offset: 0x001DC443
	public int GetFirstScore()
	{
		return this.FirstPartScore;
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x001DE24B File Offset: 0x001DC44B
	public int GetLowScore()
	{
		return this.LowPartScore;
	}

	// Token: 0x06008BBC RID: 35772 RVA: 0x001DE254 File Offset: 0x001DC454
	public string GetLevelTips()
	{
		return this.GetConfig().Value.LevelTips;
	}

	// Token: 0x06008BBD RID: 35773 RVA: 0x001DE278 File Offset: 0x001DC478
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

	// Token: 0x06008BBE RID: 35774 RVA: 0x001DE2DE File Offset: 0x001DC4DE
	public double GetUnLockTime()
	{
		return this.UnLockTime;
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x001DE2E6 File Offset: 0x001DC4E6
	public MowTowerLevelsRe? GetConfig()
	{
		return MowingTowerConfig.Instance.GetBossMowingTowerConfigById(this.Id);
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x001DE2F8 File Offset: 0x001DC4F8
	public int GetMaxBuffCount()
	{
		return this.GetConfig().Value.BuffCount;
	}

	// Token: 0x06008BC1 RID: 35777 RVA: 0x001DE31C File Offset: 0x001DC51C
	public int GetInstanceDungeonId()
	{
		return this.GetConfig().Value.InstIds()[0];
	}

	// Token: 0x06008BC2 RID: 35778 RVA: 0x001DE344 File Offset: 0x001DC544
	public bool GetIsInfinite()
	{
		return this.GetConfig().Value.IsInfinite;
	}

	// Token: 0x06008BC3 RID: 35779 RVA: 0x001DE368 File Offset: 0x001DC568
	public string GetLevelDesc()
	{
		return this.GetConfig().Value.LevelDesc;
	}

	// Token: 0x06008BC4 RID: 35780 RVA: 0x001DE38C File Offset: 0x001DC58C
	public InstanceDungeon? GetInstanceDungeonConfig(ETeamBelong belongTo)
	{
		int id = this.GetConfig().Value.InstIds()[(int)belongTo];
		return InstanceDungeonConfig.Instance.GetConfig(id);
	}

	// Token: 0x06008BC5 RID: 35781 RVA: 0x001DE3C0 File Offset: 0x001DC5C0
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

	// Token: 0x04003DEE RID: 15854
	private int ActivityId;

	// Token: 0x04003DEF RID: 15855
	private int Id;

	// Token: 0x04003DF0 RID: 15856
	private int FirstPartScore;

	// Token: 0x04003DF1 RID: 15857
	private int LowPartScore;

	// Token: 0x04003DF2 RID: 15858
	private double UnLockTime;

	// Token: 0x04003DF3 RID: 15859
	private List<MowingTowerBuffInfo> BuffInfo = new List<MowingTowerBuffInfo>();

	// Token: 0x04003DF4 RID: 15860
	private List<MowingTowerBuffInfo> OptionBuffInfo = new List<MowingTowerBuffInfo>();

	// Token: 0x04003DF5 RID: 15861
	private List<MowingTowerRoleInfo> FirstPartRoleInfo = new List<MowingTowerRoleInfo>();

	// Token: 0x04003DF6 RID: 15862
	private List<MowingTowerRoleInfo> LowPartRoleInfo = new List<MowingTowerRoleInfo>();

	// Token: 0x04003DF7 RID: 15863
	private bool IsOpen;
}
