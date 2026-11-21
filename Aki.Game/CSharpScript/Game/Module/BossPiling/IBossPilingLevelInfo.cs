using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BDD RID: 19421
	[NullableContext(1)]
	public interface IBossPilingLevelInfo
	{
		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x0603079A RID: 198554
		// (set) Token: 0x0603079B RID: 198555
		int Id { get; set; }

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0603079C RID: 198556
		// (set) Token: 0x0603079D RID: 198557
		int UnlockTime { get; set; }

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0603079E RID: 198558
		// (set) Token: 0x0603079F RID: 198559
		int BossHp { get; set; }

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x060307A0 RID: 198560
		// (set) Token: 0x060307A1 RID: 198561
		List<int> SelectedRoleIds { get; set; }

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x060307A2 RID: 198562
		// (set) Token: 0x060307A3 RID: 198563
		List<int> SelectedTagBranchIds { get; set; }

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x060307A4 RID: 198564
		// (set) Token: 0x060307A5 RID: 198565
		bool IsUnlock { get; set; }
	}
}
