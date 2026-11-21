using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C74 RID: 7284
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleData
{
	// Token: 0x06012113 RID: 74003 RVA: 0x0054FBF6 File Offset: 0x0054DDF6
	public void SetPromoteToTopPredicate([Nullable(new byte[]
	{
		2,
		1
	})] Func<MultiTeamRoleGridData, bool> predicate)
	{
		this.PromoteToTopPredicate = predicate;
	}

	// Token: 0x06012114 RID: 74004 RVA: 0x0054FBFF File Offset: 0x0054DDFF
	public void SetSinkToBottomPredicate([Nullable(new byte[]
	{
		2,
		1
	})] Func<MultiTeamRoleGridData, bool> predicate)
	{
		this.SinkToBottomPredicate = predicate;
	}

	// Token: 0x06012115 RID: 74005 RVA: 0x0054FC08 File Offset: 0x0054DE08
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x06012116 RID: 74006 RVA: 0x0054FC10 File Offset: 0x0054DE10
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

	// Token: 0x06012117 RID: 74007 RVA: 0x0054FC74 File Offset: 0x0054DE74
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
			this.ApplySortPriority();
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
		this.ApplySortPriority();
	}

	// Token: 0x06012118 RID: 74008 RVA: 0x0054FD78 File Offset: 0x0054DF78
	private void ApplySortPriority()
	{
		if ((this.PromoteToTopPredicate == null && this.SinkToBottomPredicate == null) || this.SortedTeamRoleList.Count == 0)
		{
			return;
		}
		List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
		List<MultiTeamRoleGridData> list2 = new List<MultiTeamRoleGridData>(this.SortedTeamRoleList.Count);
		List<MultiTeamRoleGridData> list3 = new List<MultiTeamRoleGridData>();
		foreach (MultiTeamRoleGridData multiTeamRoleGridData in this.SortedTeamRoleList)
		{
			Func<MultiTeamRoleGridData, bool> promoteToTopPredicate = this.PromoteToTopPredicate;
			if (promoteToTopPredicate != null && promoteToTopPredicate(multiTeamRoleGridData))
			{
				list.Add(multiTeamRoleGridData);
			}
			else
			{
				Func<MultiTeamRoleGridData, bool> sinkToBottomPredicate = this.SinkToBottomPredicate;
				if (sinkToBottomPredicate != null && sinkToBottomPredicate(multiTeamRoleGridData))
				{
					list3.Add(multiTeamRoleGridData);
				}
				else
				{
					list2.Add(multiTeamRoleGridData);
				}
			}
		}
		list.AddRange(list2);
		list.AddRange(list3);
		this.SortedTeamRoleList = list;
	}

	// Token: 0x06012119 RID: 74009 RVA: 0x0054FE60 File Offset: 0x0054E060
	public List<MultiTeamRoleGridData> GetShowMultiTeamRoleGridDataList()
	{
		return this.SortedTeamRoleList;
	}

	// Token: 0x0601211A RID: 74010 RVA: 0x0054FE68 File Offset: 0x0054E068
	public static MultiTeamRoleData Phrase(string title, List<MultiTeamRoleGridData> roleList)
	{
		MultiTeamRoleData multiTeamRoleData = new MultiTeamRoleData();
		multiTeamRoleData.Title = title;
		multiTeamRoleData.MultiTeamRoleGridDataList = roleList;
		multiTeamRoleData.SetSortedRoleList(null);
		return multiTeamRoleData;
	}

	// Token: 0x04009D81 RID: 40321
	private string Title = "";

	// Token: 0x04009D82 RID: 40322
	private List<MultiTeamRoleGridData> MultiTeamRoleGridDataList = new List<MultiTeamRoleGridData>();

	// Token: 0x04009D83 RID: 40323
	private List<MultiTeamRoleGridData> SortedTeamRoleList = new List<MultiTeamRoleGridData>();

	// Token: 0x04009D84 RID: 40324
	private List<RoleDataBase> SortedRoleList = new List<RoleDataBase>();

	// Token: 0x04009D85 RID: 40325
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<MultiTeamRoleGridData, bool> PromoteToTopPredicate;

	// Token: 0x04009D86 RID: 40326
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<MultiTeamRoleGridData, bool> SinkToBottomPredicate;
}
