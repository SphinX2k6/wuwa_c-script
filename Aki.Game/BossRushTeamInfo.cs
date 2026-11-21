using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;

// Token: 0x02000671 RID: 1649
[NullableContext(1)]
[Nullable(0)]
public class BossRushTeamInfo
{
	// Token: 0x06004C65 RID: 19557 RVA: 0x0019EF00 File Offset: 0x0019D100
	[NullableContext(2)]
	public BossRushLevelDetailInfo GetCurrentSelectLevel()
	{
		return this.CurrentSelectLevelDetailInfo;
	}

	// Token: 0x06004C66 RID: 19558 RVA: 0x0019EF08 File Offset: 0x0019D108
	public List<BossRushBuffInfo> GetCurrentSelectBuff()
	{
		return this.CurrentSelectBuff;
	}

	// Token: 0x06004C67 RID: 19559 RVA: 0x0019EF10 File Offset: 0x0019D110
	public List<BossRushBuffInfo> GetPrepareSelectBuff()
	{
		return this.PrepareSelectBuff;
	}

	// Token: 0x06004C68 RID: 19560 RVA: 0x0019EF18 File Offset: 0x0019D118
	public List<BossRushBuffInfo> GetCurrentSelectScoreBuff()
	{
		return this.CurrentSelectScoreBuff;
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x0019EF20 File Offset: 0x0019D120
	public List<BossRushBuffInfo> GetCurrentOptionScoreBuff()
	{
		return this.CurrentOptionScoreBuff;
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x0019EF28 File Offset: 0x0019D128
	public List<BossRushBuffInfo> GetPrepareSelectScoreBuff()
	{
		return this.PrepareSelectScoreBuff;
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x0019EF30 File Offset: 0x0019D130
	public int[] GetCurrentTeamMembers()
	{
		return this.CurrentTeamMembers.ToArray();
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x0019EF3D File Offset: 0x0019D13D
	public void SetCurrentSelectLevel(BossRushLevelDetailInfo info)
	{
		this.CurrentSelectLevelDetailInfo = info;
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x0019EF48 File Offset: 0x0019D148
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

	// Token: 0x06004C6E RID: 19566 RVA: 0x0019F0C9 File Offset: 0x0019D2C9
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexBuff(int index)
	{
		if (index >= this.CurrentSelectBuff.Count)
		{
			return null;
		}
		return this.CurrentSelectBuff[index];
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x0019F0E8 File Offset: 0x0019D2E8
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
					if (((item.BuffId > 0 && item.State == BossRushBuffSelectionStatus.BuffLocked) || item.Slot < 0) && !list.Exists((BossRushBuffInfo x) => x.BuffId == item.BuffId))
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
				if (!list.Exists((BossRushBuffInfo x) => x.BuffId == item.BuffId))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x0019F208 File Offset: 0x0019D408
	public void InitPrepareSelectBuff()
	{
		this.PrepareSelectBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in this.CurrentSelectBuff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x0019F26C File Offset: 0x0019D46C
	public void InitPrepareSelectScoreBuff()
	{
		this.PrepareSelectScoreBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in this.CurrentSelectScoreBuff)
		{
			this.PrepareSelectScoreBuff.Add(item);
		}
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x0019F2D0 File Offset: 0x0019D4D0
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

	// Token: 0x06004C73 RID: 19571 RVA: 0x0019F324 File Offset: 0x0019D524
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexPrepareSelectBuff(int index)
	{
		if (index >= this.PrepareSelectBuff.Count)
		{
			return null;
		}
		return this.PrepareSelectBuff[index];
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x0019F342 File Offset: 0x0019D542
	[NullableContext(2)]
	public BossRushBuffInfo GetIndexPrepareSelectScoreBuff(int index)
	{
		if (index >= this.PrepareSelectScoreBuff.Count)
		{
			return null;
		}
		return this.PrepareSelectScoreBuff[index];
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x0019F360 File Offset: 0x0019D560
	public void SetPrepareSelectBuff(BossRushBuffInfo[] buff)
	{
		this.PrepareSelectBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in buff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x0019F398 File Offset: 0x0019D598
	public void SetPrepareSelectScoreBuff(BossRushBuffInfo[] buff)
	{
		this.PrepareSelectScoreBuff = new List<BossRushBuffInfo>();
		foreach (BossRushBuffInfo item in buff)
		{
			this.PrepareSelectScoreBuff.Add(item);
		}
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x0019F3D0 File Offset: 0x0019D5D0
	public int GetBuffMaxCount()
	{
		return this.CurrentSelectBuff.Count;
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x0019F3E0 File Offset: 0x0019D5E0
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

	// Token: 0x06004C79 RID: 19577 RVA: 0x0019F434 File Offset: 0x0019D634
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

	// Token: 0x06004C7A RID: 19578 RVA: 0x0019F4B4 File Offset: 0x0019D6B4
	public void SetCurrentTeamMembers(int[] members)
	{
		this.CurrentTeamMembers = new List<int>(members);
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x0019F4C4 File Offset: 0x0019D6C4
	public int GetRecommendLevel()
	{
		if (this.LevelInfo == null || this.LevelInfo.GetConfig() == null)
		{
			return 0;
		}
		return InstanceDungeonConfig.Instance.GetRecommendLevel(this.LevelInfo.GetConfig().Value.InstId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x0019F520 File Offset: 0x0019D720
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

	// Token: 0x06004C7D RID: 19581 RVA: 0x0019F5D0 File Offset: 0x0019D7D0
	public void Clear()
	{
		this.CurrentSelectBuff = new List<BossRushBuffInfo>();
		this.CurrentTeamMembers = new List<int>();
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x0019F5E8 File Offset: 0x0019D7E8
	public void ClearTeamInfo()
	{
		this.CurrentTeamMembers = new List<int>();
	}

	// Token: 0x04003820 RID: 14368
	public int ActivityId;

	// Token: 0x04003821 RID: 14369
	[Nullable(2)]
	private BossRushLevelDetailInfo CurrentSelectLevelDetailInfo;

	// Token: 0x04003822 RID: 14370
	private List<BossRushBuffInfo> CurrentSelectBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003823 RID: 14371
	private readonly List<BossRushBuffInfo> CurrentOptionBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003824 RID: 14372
	private List<BossRushBuffInfo> PrepareSelectBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003825 RID: 14373
	private readonly List<BossRushBuffInfo> CurrentSelectScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003826 RID: 14374
	private readonly List<BossRushBuffInfo> CurrentOptionScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003827 RID: 14375
	private List<BossRushBuffInfo> PrepareSelectScoreBuff = new List<BossRushBuffInfo>();

	// Token: 0x04003828 RID: 14376
	private List<int> CurrentTeamMembers = new List<int>();

	// Token: 0x04003829 RID: 14377
	[Nullable(2)]
	public BossRushLevelDetailInfo LevelInfo;
}
