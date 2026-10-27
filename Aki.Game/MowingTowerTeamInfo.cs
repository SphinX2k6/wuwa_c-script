using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200138C RID: 5004
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerTeamInfo
{
	// Token: 0x06008C26 RID: 35878 RVA: 0x001E099B File Offset: 0x001DEB9B
	[NullableContext(2)]
	public MowingTowerLevelDetailInfo GetCurrentSelectLevel()
	{
		return this.CurrentSelectLevelDetailInfo;
	}

	// Token: 0x06008C27 RID: 35879 RVA: 0x001E09A3 File Offset: 0x001DEBA3
	public List<MowingTowerBuffInfo> GetCurrentSelectBuff()
	{
		return this.CurrentSelectBuff;
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x001E09AB File Offset: 0x001DEBAB
	public List<MowingTowerBuffInfo> GetPrepareSelectBuff()
	{
		return this.PrepareSelectBuff;
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x001E09B3 File Offset: 0x001DEBB3
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<List<int>, List<int>> GetCurrentTeamMembers()
	{
		return new ValueTuple<List<int>, List<int>>(this.CurrentTeamFirstMembers, this.CurrentTeamLowMembers);
	}

	// Token: 0x06008C2A RID: 35882 RVA: 0x001E09C6 File Offset: 0x001DEBC6
	public void SetCurrentSelectLevel(MowingTowerLevelDetailInfo info)
	{
		this.CurrentSelectLevelDetailInfo = info;
	}

	// Token: 0x06008C2B RID: 35883 RVA: 0x001E09D0 File Offset: 0x001DEBD0
	public void InitLevelBuff(MowingTowerBuffInfo[] buff, MowingTowerBuffInfo[] unlockBuffs)
	{
		this.CurrentSelectBuff = new List<MowingTowerBuffInfo>();
		foreach (MowingTowerBuffInfo mowingTowerBuffInfo in buff)
		{
			MowingTowerBuffInfo mowingTowerBuffInfo2 = new MowingTowerBuffInfo();
			mowingTowerBuffInfo2.BuffId = mowingTowerBuffInfo.BuffId;
			mowingTowerBuffInfo2.Slot = mowingTowerBuffInfo.Slot;
			mowingTowerBuffInfo2.ChangeAble = mowingTowerBuffInfo.ChangeAble;
			this.CurrentSelectBuff.Add(mowingTowerBuffInfo2);
		}
		foreach (MowingTowerBuffInfo mowingTowerBuffInfo3 in buff)
		{
			if (mowingTowerBuffInfo3.BuffId > 0)
			{
				this.CurrentOptionBuff.Add(mowingTowerBuffInfo3);
			}
		}
		foreach (MowingTowerBuffInfo mowingTowerBuffInfo4 in unlockBuffs)
		{
			if (mowingTowerBuffInfo4.BuffId > 0)
			{
				this.CurrentOptionBuff.Add(mowingTowerBuffInfo4);
			}
		}
	}

	// Token: 0x06008C2C RID: 35884 RVA: 0x001E0A8A File Offset: 0x001DEC8A
	[NullableContext(2)]
	public MowingTowerBuffInfo GetIndexBuff(int index)
	{
		if (index >= this.CurrentSelectBuff.Count)
		{
			return null;
		}
		return this.CurrentSelectBuff[index];
	}

	// Token: 0x06008C2D RID: 35885 RVA: 0x001E0AA8 File Offset: 0x001DECA8
	public List<MowingTowerBuffInfo> GetOptionBuff()
	{
		List<MowingTowerBuffInfo> list = new List<MowingTowerBuffInfo>();
		using (List<MowingTowerBuffInfo>.Enumerator enumerator = this.CurrentOptionBuff.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MowingTowerBuffInfo item = enumerator.Current;
				if ((item.BuffId > 0 || item.Slot < 0) && list.FindIndex((MowingTowerBuffInfo x) => x.BuffId == item.BuffId) == -1)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06008C2E RID: 35886 RVA: 0x001E0B44 File Offset: 0x001DED44
	public void InitPrepareSelectBuff()
	{
		this.PrepareSelectBuff = new List<MowingTowerBuffInfo>();
		foreach (MowingTowerBuffInfo item in this.CurrentSelectBuff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06008C2F RID: 35887 RVA: 0x001E0BA8 File Offset: 0x001DEDA8
	public void SetIndexPrepareSelectBuff(int index, MowingTowerBuffInfo buff)
	{
		this.PrepareSelectBuff[index] = buff;
	}

	// Token: 0x06008C30 RID: 35888 RVA: 0x001E0BB7 File Offset: 0x001DEDB7
	[NullableContext(2)]
	public MowingTowerBuffInfo GetIndexPrepareSelectBuff(int index)
	{
		return this.PrepareSelectBuff[index];
	}

	// Token: 0x06008C31 RID: 35889 RVA: 0x001E0BC8 File Offset: 0x001DEDC8
	public void SetPrepareSelectBuff(MowingTowerBuffInfo[] buff)
	{
		this.PrepareSelectBuff = new List<MowingTowerBuffInfo>();
		foreach (MowingTowerBuffInfo item in buff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06008C32 RID: 35890 RVA: 0x001E0C00 File Offset: 0x001DEE00
	public int GetBuffMaxCount()
	{
		return this.CurrentSelectBuff.Count;
	}

	// Token: 0x06008C33 RID: 35891 RVA: 0x001E0C0D File Offset: 0x001DEE0D
	public void SetIndexTeamMembers(ETeamBelong belong, int index, int roleId)
	{
		if (belong == ETeamBelong.FirstPart)
		{
			this.SetIndexFirstTeamMembers(index, roleId);
			return;
		}
		if (belong == ETeamBelong.LowPart)
		{
			this.SetIndexLowTeamMembers(index, roleId);
		}
	}

	// Token: 0x06008C34 RID: 35892 RVA: 0x001E0C27 File Offset: 0x001DEE27
	public void SetIndexFirstTeamMembers(int index, int roleId)
	{
		if (this.CurrentTeamFirstMembers.Count <= index)
		{
			this.CurrentTeamFirstMembers.Add(roleId);
			return;
		}
		this.CurrentTeamFirstMembers[index] = roleId;
	}

	// Token: 0x06008C35 RID: 35893 RVA: 0x001E0C51 File Offset: 0x001DEE51
	public void SetIndexLowTeamMembers(int index, int roleId)
	{
		if (this.CurrentTeamLowMembers.Count <= index)
		{
			this.CurrentTeamLowMembers.Add(roleId);
			return;
		}
		this.CurrentTeamLowMembers[index] = roleId;
	}

	// Token: 0x06008C36 RID: 35894 RVA: 0x001E0C7B File Offset: 0x001DEE7B
	public void ReSortTeamMembers(ETeamBelong belong)
	{
		if (belong == ETeamBelong.FirstPart)
		{
			this.ReSortFirstTeamMembers();
			return;
		}
		if (belong == ETeamBelong.LowPart)
		{
			this.ReSortLowTeamMembers();
		}
	}

	// Token: 0x06008C37 RID: 35895 RVA: 0x001E0C94 File Offset: 0x001DEE94
	public void ReSortFirstTeamMembers()
	{
		List<int> list = new List<int>();
		foreach (int num in this.CurrentTeamFirstMembers)
		{
			if (num > 0)
			{
				list.Add(num);
			}
		}
		for (int i = list.Count; i < this.CurrentTeamFirstMembers.Count; i++)
		{
			list.Add(0);
		}
		this.CurrentTeamFirstMembers = list;
	}

	// Token: 0x06008C38 RID: 35896 RVA: 0x001E0D1C File Offset: 0x001DEF1C
	public void ReSortLowTeamMembers()
	{
		List<int> list = new List<int>();
		foreach (int num in this.CurrentTeamLowMembers)
		{
			if (num > 0)
			{
				list.Add(num);
			}
		}
		for (int i = list.Count; i < this.CurrentTeamLowMembers.Count; i++)
		{
			list.Add(0);
		}
		this.CurrentTeamLowMembers = list;
	}

	// Token: 0x06008C39 RID: 35897 RVA: 0x001E0DA4 File Offset: 0x001DEFA4
	public void SetCurrentTeamMembers(int[] firstPartRole, int[] lowPartRole)
	{
		this.CurrentTeamFirstMembers = new List<int>(firstPartRole);
		this.CurrentTeamLowMembers = new List<int>(lowPartRole);
	}

	// Token: 0x06008C3A RID: 35898 RVA: 0x001E0DC0 File Offset: 0x001DEFC0
	public int GetRecommendLevel()
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(this.LevelInfo.GetConfig().Value.InstIds()[0], WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x06008C3B RID: 35899 RVA: 0x001E0E00 File Offset: 0x001DF000
	public bool GetIfLevelTooLow()
	{
		float num = 0f;
		int num2 = 0;
		foreach (int id in this.CurrentTeamFirstMembers)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(id);
			if (roleInstanceById != null)
			{
				num += (float)roleInstanceById.GetLevelData().GetLevel();
				num2++;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
			if (roleDataById != null)
			{
				num += (float)roleDataById.GetLevelData().GetLevel();
				num2++;
			}
		}
		float num3 = (num2 > 0) ? (num / (float)num2) : 0f;
		if (num3 < (float)this.GetRecommendLevel() && num3 != 0f)
		{
			return true;
		}
		foreach (int id2 in this.CurrentTeamLowMembers)
		{
			RoleInstance roleInstanceById2 = RoleModel.Instance.GetRoleInstanceById(id2);
			if (roleInstanceById2 != null)
			{
				num += (float)roleInstanceById2.GetLevelData().GetLevel();
				num2++;
			}
			RoleDataBase roleDataById2 = RoleModel.Instance.GetRoleDataById(id2, true);
			if (roleDataById2 != null)
			{
				num += (float)roleDataById2.GetLevelData().GetLevel();
				num2++;
			}
		}
		float num4 = (num2 > 0) ? (num / (float)num2) : 0f;
		return num4 < (float)this.GetRecommendLevel() && num4 != 0f;
	}

	// Token: 0x06008C3C RID: 35900 RVA: 0x001E0F78 File Offset: 0x001DF178
	public void Clear()
	{
		this.CurrentSelectBuff = new List<MowingTowerBuffInfo>();
		this.CurrentTeamFirstMembers = new List<int>();
		this.CurrentTeamLowMembers = new List<int>();
	}

	// Token: 0x04003E31 RID: 15921
	public int ActivityId;

	// Token: 0x04003E32 RID: 15922
	[Nullable(2)]
	private MowingTowerLevelDetailInfo CurrentSelectLevelDetailInfo;

	// Token: 0x04003E33 RID: 15923
	private List<MowingTowerBuffInfo> CurrentSelectBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003E34 RID: 15924
	private readonly List<MowingTowerBuffInfo> CurrentOptionBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003E35 RID: 15925
	private List<MowingTowerBuffInfo> PrepareSelectBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003E36 RID: 15926
	private List<int> CurrentTeamFirstMembers = new List<int>();

	// Token: 0x04003E37 RID: 15927
	private List<int> CurrentTeamLowMembers = new List<int>();

	// Token: 0x04003E38 RID: 15928
	[Nullable(2)]
	public MowingTowerLevelDetailInfo LevelInfo;
}
