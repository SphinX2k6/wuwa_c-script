using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E1C RID: 7708
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchPopViewParams
{
	// Token: 0x17001D24 RID: 7460
	// (get) Token: 0x06013173 RID: 78195 RVA: 0x00594EBD File Offset: 0x005930BD
	// (set) Token: 0x06013174 RID: 78196 RVA: 0x00594EC5 File Offset: 0x005930C5
	public List<RoleSkillBranchTeamTabData> RoleSkillBranchTeamTabDataList { get; set; } = new List<RoleSkillBranchTeamTabData>();

	// Token: 0x17001D25 RID: 7461
	// (get) Token: 0x06013175 RID: 78197 RVA: 0x00594ECE File Offset: 0x005930CE
	// (set) Token: 0x06013176 RID: 78198 RVA: 0x00594ED6 File Offset: 0x005930D6
	public int? PreferredTabIndex { get; set; }

	// Token: 0x06013177 RID: 78199 RVA: 0x00594EE0 File Offset: 0x005930E0
	public void Load(int[][] roleIdTab)
	{
		this.RoleSkillBranchTeamTabDataList.Clear();
		for (int i = 0; i < roleIdTab.Length; i++)
		{
			int[] array = roleIdTab[i];
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (int num in array)
			{
				if (num > 0)
				{
					int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(num);
					list.Add(new ValueTuple<int, int>(num, roleSkillBranchIndexInCurrentGamePlay));
				}
			}
			this.RoleSkillBranchTeamTabDataList.Add(new RoleSkillBranchTeamTabData
			{
				TeamIndex = i,
				RoleSkillBranchTeamDataList = list
			});
		}
	}
}
