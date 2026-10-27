using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002789 RID: 10121
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleData
{
	// Token: 0x06014C2C RID: 85036 RVA: 0x00540D1A File Offset: 0x0053EF1A
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x06014C2D RID: 85037 RVA: 0x00540D24 File Offset: 0x0053EF24
	public List<RoleDataBase> GetSourceRoleList()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (MultiTeamRoleGridData multiTeamRoleGridData in this.MultiTeamRoleGridDataList)
		{
			RoleDataBase role = multiTeamRoleGridData.GetRole();
			if (role != null)
			{
				list.Add(role);
			}
		}
		return list;
	}

	// Token: 0x06014C2E RID: 85038 RVA: 0x00540D88 File Offset: 0x0053EF88
	public void SetSortedRoleList([Nullable(new byte[]
	{
		2,
		1
	})] List<RoleDataBase> roleList)
	{
		if (roleList == null)
		{
			this.SortedTeamRoleList = new List<MultiTeamRoleGridData>();
			foreach (MultiTeamRoleGridData multiTeamRoleGridData in this.MultiTeamRoleGridDataList)
			{
				if (multiTeamRoleGridData.GetRole() != null)
				{
					this.SortedTeamRoleList.Add(multiTeamRoleGridData);
				}
			}
			return;
		}
		this.SortedRoleList = roleList;
		this.SortedTeamRoleList = new List<MultiTeamRoleGridData>();
		foreach (MultiTeamRoleGridData multiTeamRoleGridData2 in this.MultiTeamRoleGridDataList)
		{
			RoleDataBase role = multiTeamRoleGridData2.GetRole();
			if (role != null && this.SortedRoleList.Contains(role))
			{
				this.SortedTeamRoleList.Add(multiTeamRoleGridData2);
			}
		}
		this.SortedTeamRoleList.Sort(delegate(MultiTeamRoleGridData a, MultiTeamRoleGridData b)
		{
			RoleDataBase role2 = a.GetRole();
			RoleDataBase role3 = b.GetRole();
			if (role2 == null || role3 == null)
			{
				return 0;
			}
			return this.SortedRoleList.IndexOf(role2) - this.SortedRoleList.IndexOf(role3);
		});
	}

	// Token: 0x06014C2F RID: 85039 RVA: 0x00540E80 File Offset: 0x0053F080
	public List<MultiTeamRoleGridData> GetShowMultiTeamRoleGridDataList()
	{
		return this.SortedTeamRoleList;
	}

	// Token: 0x06014C30 RID: 85040 RVA: 0x00540E88 File Offset: 0x0053F088
	public static MultiTeamRoleData Phrase(string title, List<MultiTeamRoleGridData> roleList)
	{
		MultiTeamRoleData multiTeamRoleData = new MultiTeamRoleData();
		multiTeamRoleData.Title = title;
		multiTeamRoleData.MultiTeamRoleGridDataList = roleList;
		multiTeamRoleData.SetSortedRoleList(null);
		return multiTeamRoleData;
	}

	// Token: 0x04009C23 RID: 39971
	private string Title = "";

	// Token: 0x04009C24 RID: 39972
	private List<MultiTeamRoleGridData> MultiTeamRoleGridDataList = new List<MultiTeamRoleGridData>();

	// Token: 0x04009C25 RID: 39973
	private List<MultiTeamRoleGridData> SortedTeamRoleList = new List<MultiTeamRoleGridData>();

	// Token: 0x04009C26 RID: 39974
	private List<RoleDataBase> SortedRoleList = new List<RoleDataBase>();
}
