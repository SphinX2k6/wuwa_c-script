using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x02006362 RID: 25442
	[NullableContext(1)]
	public interface IPinballFormationSelectRoleViewData
	{
		// Token: 0x1700932E RID: 37678
		// (get) Token: 0x06040025 RID: 262181
		// (set) Token: 0x06040026 RID: 262182
		List<int> RoleList { get; set; }

		// Token: 0x1700932F RID: 37679
		// (get) Token: 0x06040027 RID: 262183
		// (set) Token: 0x06040028 RID: 262184
		List<int> RecommendRoleList { get; set; }

		// Token: 0x17009330 RID: 37680
		// (get) Token: 0x06040029 RID: 262185
		// (set) Token: 0x0604002A RID: 262186
		Action<List<int>> OnConfirm { get; set; }

		// Token: 0x17009331 RID: 37681
		// (get) Token: 0x0604002B RID: 262187
		// (set) Token: 0x0604002C RID: 262188
		int? OpenRole { get; set; }
	}
}
