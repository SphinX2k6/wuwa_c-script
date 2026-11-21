using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CC4 RID: 15556
	public class RoleDevelopTeamRecommendInfo
	{
		// Token: 0x04015B7C RID: 88956
		public int SkillBranchId;

		// Token: 0x04015B7D RID: 88957
		[Nullable(1)]
		public List<RoleDevelopTeamRecommendTeammate> Teammates = new List<RoleDevelopTeamRecommendTeammate>();
	}
}
