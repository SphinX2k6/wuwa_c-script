using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BDE RID: 19422
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelInfo : IBossPilingLevelInfo
	{
		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x060307A6 RID: 198566 RVA: 0x00D82410 File Offset: 0x00D80610
		// (set) Token: 0x060307A7 RID: 198567 RVA: 0x00D82418 File Offset: 0x00D80618
		public int Id { get; set; }

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x060307A8 RID: 198568 RVA: 0x00D82421 File Offset: 0x00D80621
		// (set) Token: 0x060307A9 RID: 198569 RVA: 0x00D82429 File Offset: 0x00D80629
		public int UnlockTime { get; set; }

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x060307AA RID: 198570 RVA: 0x00D82432 File Offset: 0x00D80632
		// (set) Token: 0x060307AB RID: 198571 RVA: 0x00D8243A File Offset: 0x00D8063A
		public int BossHp { get; set; }

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x060307AC RID: 198572 RVA: 0x00D82443 File Offset: 0x00D80643
		// (set) Token: 0x060307AD RID: 198573 RVA: 0x00D8244B File Offset: 0x00D8064B
		public List<int> SelectedRoleIds { get; set; }

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x060307AE RID: 198574 RVA: 0x00D82454 File Offset: 0x00D80654
		// (set) Token: 0x060307AF RID: 198575 RVA: 0x00D8245C File Offset: 0x00D8065C
		public List<int> SelectedTagBranchIds { get; set; }

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x060307B0 RID: 198576 RVA: 0x00D82465 File Offset: 0x00D80665
		// (set) Token: 0x060307B1 RID: 198577 RVA: 0x00D8246D File Offset: 0x00D8066D
		public bool IsUnlock { get; set; }
	}
}
