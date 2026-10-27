using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020028A1 RID: 10401
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchPopViewParams
{
	// Token: 0x17001CCC RID: 7372
	// (get) Token: 0x06015773 RID: 87923 RVA: 0x0056A075 File Offset: 0x00568275
	// (set) Token: 0x06015774 RID: 87924 RVA: 0x0056A07D File Offset: 0x0056827D
	public List<RoleSkillBranchTeamTabData> RoleSkillBranchTeamTabDataList { get; set; } = new List<RoleSkillBranchTeamTabData>();

	// Token: 0x17001CCD RID: 7373
	// (get) Token: 0x06015775 RID: 87925 RVA: 0x0056A086 File Offset: 0x00568286
	// (set) Token: 0x06015776 RID: 87926 RVA: 0x0056A08E File Offset: 0x0056828E
	public int? PreferredTabIndex { get; set; }

	// Token: 0x06015777 RID: 87927 RVA: 0x0056A098 File Offset: 0x00568298
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
