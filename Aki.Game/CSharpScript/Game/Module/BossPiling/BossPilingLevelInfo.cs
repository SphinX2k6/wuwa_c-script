using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFE RID: 23550
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelInfo : IBossPilingLevelInfo
	{
		// Token: 0x17008D7F RID: 36223
		// (get) Token: 0x0603B85B RID: 243803 RVA: 0x00E320D0 File Offset: 0x00E302D0
		// (set) Token: 0x0603B85C RID: 243804 RVA: 0x00E320D8 File Offset: 0x00E302D8
		public int Id { get; set; }

		// Token: 0x17008D80 RID: 36224
		// (get) Token: 0x0603B85D RID: 243805 RVA: 0x00E320E1 File Offset: 0x00E302E1
		// (set) Token: 0x0603B85E RID: 243806 RVA: 0x00E320E9 File Offset: 0x00E302E9
		public int UnlockTime { get; set; }

		// Token: 0x17008D81 RID: 36225
		// (get) Token: 0x0603B85F RID: 243807 RVA: 0x00E320F2 File Offset: 0x00E302F2
		// (set) Token: 0x0603B860 RID: 243808 RVA: 0x00E320FA File Offset: 0x00E302FA
		public int BossHp { get; set; }

		// Token: 0x17008D82 RID: 36226
		// (get) Token: 0x0603B861 RID: 243809 RVA: 0x00E32103 File Offset: 0x00E30303
		// (set) Token: 0x0603B862 RID: 243810 RVA: 0x00E3210B File Offset: 0x00E3030B
		public List<int> SelectedRoleIds { get; set; }

		// Token: 0x17008D83 RID: 36227
		// (get) Token: 0x0603B863 RID: 243811 RVA: 0x00E32114 File Offset: 0x00E30314
		// (set) Token: 0x0603B864 RID: 243812 RVA: 0x00E3211C File Offset: 0x00E3031C
		public List<int> SelectedTagBranchIds { get; set; }

		// Token: 0x17008D84 RID: 36228
		// (get) Token: 0x0603B865 RID: 243813 RVA: 0x00E32125 File Offset: 0x00E30325
		// (set) Token: 0x0603B866 RID: 243814 RVA: 0x00E3212D File Offset: 0x00E3032D
		public bool IsUnlock { get; set; }
	}
}
