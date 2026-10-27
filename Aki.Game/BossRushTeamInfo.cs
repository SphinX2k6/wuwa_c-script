using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;

// Token: 0x020011BD RID: 4541
[NullableContext(1)]
[Nullable(0)]
public class BossRushTeamInfo
{
	// Token: 0x060078CE RID: 30926 RVA: 0x00196252 File Offset: 0x00194452
	[NullableContext(2)]
	public BossRushLevelDetailInfo GetCurrentSelectLevel()
	{
		return this.CurrentSelectLevelDetailInfo;
	}

	// Token: 0x060078CF RID: 30927 RVA: 0x0019625A File Offset: 0x0019445A
	public List<BossRushBuffInfo> GetCurrentSelectBuff()
	{
		return this.CurrentSelectBuff;
	}

	// Token: 0x060078D0 RID: 30928 RVA: 0x00196262 File Offset: 0x00194462
	public List<BossRushBuffInfo> GetPrepareSelectBuff()
	{
		return this.PrepareSelectBuff;
	}

	// Token: 0x060078D1 RID: 30929 RVA: 0x0019626A File Offset: 0x0019446A
	public List<BossRushBuffInfo> GetCurrentSelectScoreBuff()
	{
		return this.CurrentSelectScoreBuff;
	}

	// Token: 0x060078D2 RID: 30930 RVA: 0x00196272 File Offset: 0x00194472
	public List<BossRushBuffInfo> GetCurrentOptionScoreBuff()
	{
		return this.CurrentOptionScoreBuff;
	}

	// Token: 0x060078D3 RID: 30931 RVA: 0x0019627A File Offset: 0x0019447A
	public List<BossRushBuffInfo> GetPrepareSelectScoreBuff()
	{
		return this.PrepareSelectScoreBuff;
	}

	// Token: 0x060078D4 RID: 30932 RVA: 0x00196282 File Offset: 0x00194482
	public int[] GetCurrentTeamMembers()
	{
		return this.CurrentTeamMembers.ToArray();
	}

	// Token: 0x060078D5 RID: 30933 RVA: 0x0019628F File Offset: 0x0019448F
	public void SetCurrentSelectLevel(BossRushLevelDetailInfo info)
	{
		this.CurrentSelectLevelDetailInfo = info;
	}

	// Token: 0x060078D6 RID: 30934 RVA: 0x00196298 File Offset: 0x00194498
	public void InitLevelBuff(BossRushBuffInfo[] buff, BossRushBuffInfo[] unlockBuffs, BossRushBuffInfo[] optionBuffs, BossRushBuffInfo[] scoreBuffs, BossRushBuffInfo[] allScoreBuffs)
	{
		this.CurrentSelectBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo bossRushBuffInfo in buff)
		{
			BossRushBuffInfo bossRushBuffInfo2 = new BossRushBuffInfo();
			bossRushBuffInfo2.BuffId = bossRushBuffInfo.BuffId;
			bossRushBuffInfo2.Slot = bossRushBuffInfo.Slot;
			bossRushBuffInfo2.ChangeAble = bossRushBuffInfo.ChangeAble;
			bossRushBuffInfo2.State = bossRushBuffInfo.State;
			this.CurrentSelectBuff.Add(bossRushBuffInfo2);
		}
		foreach (BossRushBuffInfo bossRushBuffInfo3 in buff)
		{
			if (bossRushBuffInfo3.BuffId > 0)
			{
				this.CurrentOptionBuff.Add(bossRushBuffInfo3);
			}
		}
		foreach (BossRushBuffInfo bossRushBuffInfo4 in unlockBuffs)
		{
			if (bossRushBuffInfo4.BuffId > 0)
			{
				this.CurrentOptionBuff.Add(bossRushBuffInfo4);
			}
		}
		foreach (BossRushBuffInfo bossRushBuffInfo5 in optionBuffs)
		{
			if (bossRushBuffInfo5.BuffId > 0)
			{
				this.CurrentOptionBuff.Add(bossRushBuffInfo5);
			}
		}
		foreach (BossRushBuffInfo bossRushBuffInfo6 in scoreBuffs)
		{
			BossRushBuffInfo bossRushBuffInfo7 = new BossRushBuffInfo();
			bossRushBuffInfo7.BuffId = bossRushBuffInfo6.BuffId;
			bossRushBuffInfo7.Slot = bossRushBuffInfo6.Slot;
			bossRushBuffInfo7.ChangeAble = bossRushBuffInfo6.ChangeAble;
			bossRushBuffInfo7.State = bossRushBuffInfo6.State;
			this.CurrentSelectScoreBuff.Add(bossRushBuffInfo7);
		}
		foreach (BossRushBuffInfo bossRushBuffInfo8 in allScoreBuffs)
		{
			if (bossRushBuffInfo8.BuffId > 0)
			{
				this.CurrentOptionScoreBuff.Add(bossRushBuffInfo8);
			}
		}
	}

	// Token: 0x060078D7 RID: 30935 RVA: 0x00196419 File Offset: 0x00194619
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexBuff(int index)
	{
		if (index >= this.CurrentSelectBuff.Count)
		{
			return null;
		}
		return this.CurrentSelectBuff[index];
	}

	// Token: 0x060078D8 RID: 30936 RVA: 0x00196438 File Offset: 0x00194638
	public List<BossRushBuffInfo> GetOptionBuff()
	{
		List<BossRushBuffInfo> list = new List<BossRushBuffInfo>();
		if (BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Normal)
		{
			using (List<BossRushBuffInfo>.Enumerator enumerator = this.CurrentOptionBuff.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BossRushBuffInfo item = enumerator.Current;
					if (((item.BuffId > 0 && item.State == BossRushBuffSelectionStatus.BuffLocked) || item.Slot < 0) && !list.Any((BossRushBuffInfo x) => x.BuffId == item.BuffId))
					{
						list.Add(item);
					}
				}
				return list;
			}
		}
		using (List<BossRushBuffInfo>.Enumerator enumerator = this.CurrentOptionScoreBuff.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				BossRushBuffInfo item = enumerator.Current;
				if (!list.Any((BossRushBuffInfo x) => x.BuffId == item.BuffId))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x060078D9 RID: 30937 RVA: 0x00196558 File Offset: 0x00194758
	public void InitPrepareSelectBuff()
	{
		this.PrepareSelectBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in this.CurrentSelectBuff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x060078DA RID: 30938 RVA: 0x001965BC File Offset: 0x001947BC
	public void InitPrepareSelectScoreBuff()
	{
		this.PrepareSelectScoreBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in this.CurrentSelectScoreBuff)
		{
			this.PrepareSelectScoreBuff.Add(item);
		}
	}

	// Token: 0x060078DB RID: 30939 RVA: 0x00196620 File Offset: 0x00194820
	public void SetIndexPrepareSelectBuff(int index, BossRushBuffInfo buff)
	{
		if (index < this.PrepareSelectBuff.Count)
		{
			this.PrepareSelectBuff[index] = buff;
			return;
		}
		while (this.PrepareSelectBuff.Count <= index)
		{
			this.PrepareSelectBuff.Add(new BossRushBuffInfo());
		}
		this.PrepareSelectBuff[index] = buff;
	}

	// Token: 0x060078DC RID: 30940 RVA: 0x00196674 File Offset: 0x00194874
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexPrepareSelectBuff(int index)
	{
		if (index >= this.PrepareSelectBuff.Count)
		{
			return null;
		}
		return this.PrepareSelectBuff[index];
	}

	// Token: 0x060078DD RID: 30941 RVA: 0x00196692 File Offset: 0x00194892
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexPrepareSelectScoreBuff(int index)
	{
		if (index >= this.PrepareSelectScoreBuff.Count)
		{
			return null;
		}
		return this.PrepareSelectScoreBuff[index];
	}

	// Token: 0x060078DE RID: 30942 RVA: 0x001966B0 File Offset: 0x001948B0
	public void SetPrepareSelectBuff(BossRushBuffInfo[] buff)
	{
		this.PrepareSelectBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in buff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x060078DF RID: 30943 RVA: 0x001966E8 File Offset: 0x001948E8
	public void SetPrepareSelectScoreBuff(BossRushBuffInfo[] buff)
	{
		this.PrepareSelectScoreBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in buff)
		{
			this.PrepareSelectScoreBuff.Add(item);
		}
	}

	// Token: 0x060078E0 RID: 30944 RVA: 0x00196720 File Offset: 0x00194920
	public int GetBuffMaxCount()
	{
		return this.CurrentSelectBuff.Count;
	}

	// Token: 0x060078E1 RID: 30945 RVA: 0x00196730 File Offset: 0x00194930
	public void SetIndexTeamMembers(int index, int roleId)
	{
		if (this.CurrentTeamMembers.Count <= index)
		{
			while (this.CurrentTeamMembers.Count < index)
			{
				this.CurrentTeamMembers.Add(0);
			}
			this.CurrentTeamMembers.Add(roleId);
			return;
		}
		this.CurrentTeamMembers[index] = roleId;
	}

	// Token: 0x060078E2 RID: 30946 RVA: 0x00196784 File Offset: 0x00194984
	public void ReSortTeamMembers()
	{
		List<int> list = new List<int>();
		using (List<int>.Enumerator enumerator = this.CurrentTeamMembers.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int num = enumerator.Current;
				if (num > 0)
				{
					list.Add(num);
				}
			}
			goto IL_47;
		}
		IL_40:
		list.Add(0);
		IL_47:
		if (list.Count >= this.CurrentTeamMembers.Count)
		{
			this.CurrentTeamMembers = list;
			return;
		}
		goto IL_40;
	}

	// Token: 0x060078E3 RID: 30947 RVA: 0x00196804 File Offset: 0x00194A04
	public void SetCurrentTeamMembers(int[] members)
	{
		this.CurrentTeamMembers = new List<int>(members);
	}

	// Token: 0x060078E4 RID: 30948 RVA: 0x00196814 File Offset: 0x00194A14
	public int GetRecommendLevel()
	{
		if (this.LevelInfo == null || this.LevelInfo.GetConfig() == null)
		{
			return 0;
		}
		return InstanceDungeonConfig.Instance.GetRecommendLevel(this.LevelInfo.GetConfig().Value.InstId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x060078E5 RID: 30949 RVA: 0x00196870 File Offset: 0x00194A70
	public bool GetIfLevelTooLow()
	{
		int num = 0;
		int num2 = 0;
		foreach (int id in this.CurrentTeamMembers)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(id);
			if (roleInstanceById != null)
			{
				num += roleInstanceById.GetLevelData().GetLevel();
				num2++;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
			if (roleDataById != null)
			{
				num += roleDataById.GetLevelData().GetLevel();
				num2++;
			}
		}
		return num2 == 0 || (float)num / (float)num2 < (float)this.GetRecommendLevel();
	}

	// Token: 0x060078E6 RID: 30950 RVA: 0x00196920 File Offset: 0x00194B20
	public void Clear()
	{
		this.CurrentSelectBuff = new List<BossRushBuffInfo>();
		this.CurrentTeamMembers = new List<int>();
	}

	// Token: 0x060078E7 RID: 30951 RVA: 0x00196938 File Offset: 0x00194B38
	public void ClearTeamInfo()
	{
		this.CurrentTeamMembers = new List<int>();
	}

	// Token: 0x04003787 RID: 14215
	public int ActivityId;

	// Token: 0x04003788 RID: 14216
	[Nullable(2)]
	private BossRushLevelDetailInfo CurrentSelectLevelDetailInfo;

	// Token: 0x04003789 RID: 14217
	private List<BossRushBuffInfo> CurrentSelectBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378A RID: 14218
	private readonly List<BossRushBuffInfo> CurrentOptionBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378B RID: 14219
	private List<BossRushBuffInfo> PrepareSelectBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378C RID: 14220
	private readonly List<BossRushBuffInfo> CurrentSelectScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378D RID: 14221
	private readonly List<BossRushBuffInfo> CurrentOptionScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378E RID: 14222
	private List<BossRushBuffInfo> PrepareSelectScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x0400378F RID: 14223
	private List<int> CurrentTeamMembers = new List<int>();

	// Token: 0x04003790 RID: 14224
	[Nullable(2)]
	public BossRushLevelDetailInfo LevelInfo;
}
