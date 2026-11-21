using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000840 RID: 2112
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerTeamInfo
{
	// Token: 0x06005FC1 RID: 24513 RVA: 0x001E97EF File Offset: 0x001E79EF
	[NullableContext(2)]
	public MowingTowerLevelDetailInfo GetCurrentSelectLevel()
	{
		return this.CurrentSelectLevelDetailInfo;
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x001E97F7 File Offset: 0x001E79F7
	public List<MowingTowerBuffInfo> GetCurrentSelectBuff()
	{
		return this.CurrentSelectBuff;
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x001E97FF File Offset: 0x001E79FF
	public List<MowingTowerBuffInfo> GetPrepareSelectBuff()
	{
		return this.PrepareSelectBuff;
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x001E9807 File Offset: 0x001E7A07
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

	// Token: 0x06005FC5 RID: 24517 RVA: 0x001E981A File Offset: 0x001E7A1A
	public void SetCurrentSelectLevel(MowingTowerLevelDetailInfo info)
	{
		this.CurrentSelectLevelDetailInfo = info;
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x001E9824 File Offset: 0x001E7A24
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

	// Token: 0x06005FC7 RID: 24519 RVA: 0x001E98DE File Offset: 0x001E7ADE
	[NullableContext(2)]
	public MowingTowerBuffInfo GetIndexBuff(int index)
	{
		if (index >= this.CurrentSelectBuff.Count)
		{
			return null;
		}
		return this.CurrentSelectBuff[index];
	}

	// Token: 0x06005FC8 RID: 24520 RVA: 0x001E98FC File Offset: 0x001E7AFC
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

	// Token: 0x06005FC9 RID: 24521 RVA: 0x001E9998 File Offset: 0x001E7B98
	public void InitPrepareSelectBuff()
	{
		this.PrepareSelectBuff = new List<MowingTowerBuffInfo>();
		foreach (MowingTowerBuffInfo item in this.CurrentSelectBuff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06005FCA RID: 24522 RVA: 0x001E99FC File Offset: 0x001E7BFC
	public void SetIndexPrepareSelectBuff(int index, MowingTowerBuffInfo buff)
	{
		this.PrepareSelectBuff[index] = buff;
	}

	// Token: 0x06005FCB RID: 24523 RVA: 0x001E9A0B File Offset: 0x001E7C0B
	[NullableContext(2)]
	public MowingTowerBuffInfo GetIndexPrepareSelectBuff(int index)
	{
		return this.PrepareSelectBuff[index];
	}

	// Token: 0x06005FCC RID: 24524 RVA: 0x001E9A1C File Offset: 0x001E7C1C
	public void SetPrepareSelectBuff(MowingTowerBuffInfo[] buff)
	{
		this.PrepareSelectBuff = new List<MowingTowerBuffInfo>();
		foreach (MowingTowerBuffInfo item in buff)
		{
			this.PrepareSelectBuff.Add(item);
		}
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x001E9A54 File Offset: 0x001E7C54
	public int GetBuffMaxCount()
	{
		return this.CurrentSelectBuff.Count;
	}

	// Token: 0x06005FCE RID: 24526 RVA: 0x001E9A61 File Offset: 0x001E7C61
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

	// Token: 0x06005FCF RID: 24527 RVA: 0x001E9A7B File Offset: 0x001E7C7B
	public void SetIndexFirstTeamMembers(int index, int roleId)
	{
		if (this.CurrentTeamFirstMembers.Count <= index)
		{
			this.CurrentTeamFirstMembers.Add(roleId);
			return;
		}
		this.CurrentTeamFirstMembers[index] = roleId;
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x001E9AA5 File Offset: 0x001E7CA5
	public void SetIndexLowTeamMembers(int index, int roleId)
	{
		if (this.CurrentTeamLowMembers.Count <= index)
		{
			this.CurrentTeamLowMembers.Add(roleId);
			return;
		}
		this.CurrentTeamLowMembers[index] = roleId;
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x001E9ACF File Offset: 0x001E7CCF
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

	// Token: 0x06005FD2 RID: 24530 RVA: 0x001E9AE8 File Offset: 0x001E7CE8
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

	// Token: 0x06005FD3 RID: 24531 RVA: 0x001E9B70 File Offset: 0x001E7D70
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

	// Token: 0x06005FD4 RID: 24532 RVA: 0x001E9BF8 File Offset: 0x001E7DF8
	public void SetCurrentTeamMembers(int[] firstPartRole, int[] lowPartRole)
	{
		this.CurrentTeamFirstMembers = new List<int>(firstPartRole);
		this.CurrentTeamLowMembers = new List<int>(lowPartRole);
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x001E9C14 File Offset: 0x001E7E14
	public int GetRecommendLevel()
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(this.LevelInfo.GetConfig().Value.InstIds()[0], WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x001E9C54 File Offset: 0x001E7E54
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

	// Token: 0x06005FD7 RID: 24535 RVA: 0x001E9DCC File Offset: 0x001E7FCC
	public void Clear()
	{
		this.CurrentSelectBuff = new List<MowingTowerBuffInfo>();
		this.CurrentTeamFirstMembers = new List<int>();
		this.CurrentTeamLowMembers = new List<int>();
	}

	// Token: 0x04003EC9 RID: 16073
	public int ActivityId;

	// Token: 0x04003ECA RID: 16074
	[Nullable(2)]
	private MowingTowerLevelDetailInfo CurrentSelectLevelDetailInfo;

	// Token: 0x04003ECB RID: 16075
	private List<MowingTowerBuffInfo> CurrentSelectBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003ECC RID: 16076
	private readonly List<MowingTowerBuffInfo> CurrentOptionBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003ECD RID: 16077
	private List<MowingTowerBuffInfo> PrepareSelectBuff = new List<MowingTowerBuffInfo>();

	// Token: 0x04003ECE RID: 16078
	private List<int> CurrentTeamFirstMembers = new List<int>();

	// Token: 0x04003ECF RID: 16079
	private List<int> CurrentTeamLowMembers = new List<int>();

	// Token: 0x04003ED0 RID: 16080
	[Nullable(2)]
	public MowingTowerLevelDetailInfo LevelInfo;
}
