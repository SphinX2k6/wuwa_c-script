using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420B RID: 16907
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillData : IPhantomArenaSkillData
	{
		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x0602AB70 RID: 174960 RVA: 0x00C07548 File Offset: 0x00C05748
		// (set) Token: 0x0602AB71 RID: 174961 RVA: 0x00C07550 File Offset: 0x00C05750
		public bool IsOwn { get; set; }

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x0602AB72 RID: 174962 RVA: 0x00C07559 File Offset: 0x00C05759
		// (set) Token: 0x0602AB73 RID: 174963 RVA: 0x00C07561 File Offset: 0x00C05761
		public int SkillId { get; set; }

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x0602AB74 RID: 174964 RVA: 0x00C0756A File Offset: 0x00C0576A
		// (set) Token: 0x0602AB75 RID: 174965 RVA: 0x00C07572 File Offset: 0x00C05772
		public bool IsPassive { get; set; }

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x0602AB76 RID: 174966 RVA: 0x00C0757B File Offset: 0x00C0577B
		// (set) Token: 0x0602AB77 RID: 174967 RVA: 0x00C07583 File Offset: 0x00C05783
		public string Icon { get; set; }

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x0602AB78 RID: 174968 RVA: 0x00C0758C File Offset: 0x00C0578C
		// (set) Token: 0x0602AB79 RID: 174969 RVA: 0x00C07594 File Offset: 0x00C05794
		public string SkillName { get; set; }

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x0602AB7A RID: 174970 RVA: 0x00C0759D File Offset: 0x00C0579D
		// (set) Token: 0x0602AB7B RID: 174971 RVA: 0x00C075A5 File Offset: 0x00C057A5
		public string SkillDesc { get; set; }

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x0602AB7C RID: 174972 RVA: 0x00C075AE File Offset: 0x00C057AE
		// (set) Token: 0x0602AB7D RID: 174973 RVA: 0x00C075B6 File Offset: 0x00C057B6
		public List<string> SkillDescParams { get; set; }

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x0602AB7E RID: 174974 RVA: 0x00C075BF File Offset: 0x00C057BF
		// (set) Token: 0x0602AB7F RID: 174975 RVA: 0x00C075C7 File Offset: 0x00C057C7
		public int CostConsume { get; set; }
	}
}
