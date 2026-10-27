using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFD RID: 23549
	[NullableContext(1)]
	public interface IBossPilingLevelInfo
	{
		// Token: 0x17008D79 RID: 36217
		// (get) Token: 0x0603B84F RID: 243791
		// (set) Token: 0x0603B850 RID: 243792
		int Id { get; set; }

		// Token: 0x17008D7A RID: 36218
		// (get) Token: 0x0603B851 RID: 243793
		// (set) Token: 0x0603B852 RID: 243794
		int UnlockTime { get; set; }

		// Token: 0x17008D7B RID: 36219
		// (get) Token: 0x0603B853 RID: 243795
		// (set) Token: 0x0603B854 RID: 243796
		int BossHp { get; set; }

		// Token: 0x17008D7C RID: 36220
		// (get) Token: 0x0603B855 RID: 243797
		// (set) Token: 0x0603B856 RID: 243798
		List<int> SelectedRoleIds { get; set; }

		// Token: 0x17008D7D RID: 36221
		// (get) Token: 0x0603B857 RID: 243799
		// (set) Token: 0x0603B858 RID: 243800
		List<int> SelectedTagBranchIds { get; set; }

		// Token: 0x17008D7E RID: 36222
		// (get) Token: 0x0603B859 RID: 243801
		// (set) Token: 0x0603B85A RID: 243802
		bool IsUnlock { get; set; }
	}
}
