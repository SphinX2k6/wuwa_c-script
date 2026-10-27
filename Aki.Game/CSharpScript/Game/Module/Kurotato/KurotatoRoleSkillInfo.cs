using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056E8 RID: 22248
	public class KurotatoRoleSkillInfo : IKurotatoRoleSkillInfo
	{
		// Token: 0x170087C1 RID: 34753
		// (get) Token: 0x06038960 RID: 231776 RVA: 0x00D703F2 File Offset: 0x00D6E5F2
		// (set) Token: 0x06038961 RID: 231777 RVA: 0x00D703FA File Offset: 0x00D6E5FA
		public int AttrId { get; set; }

		// Token: 0x170087C2 RID: 34754
		// (get) Token: 0x06038962 RID: 231778 RVA: 0x00D70403 File Offset: 0x00D6E603
		// (set) Token: 0x06038963 RID: 231779 RVA: 0x00D7040B File Offset: 0x00D6E60B
		public int Value { get; set; }

		// Token: 0x170087C3 RID: 34755
		// (get) Token: 0x06038964 RID: 231780 RVA: 0x00D70414 File Offset: 0x00D6E614
		// (set) Token: 0x06038965 RID: 231781 RVA: 0x00D7041C File Offset: 0x00D6E61C
		public bool IsRecommend { get; set; }

		// Token: 0x170087C4 RID: 34756
		// (get) Token: 0x06038966 RID: 231782 RVA: 0x00D70425 File Offset: 0x00D6E625
		// (set) Token: 0x06038967 RID: 231783 RVA: 0x00D7042D File Offset: 0x00D6E62D
		public bool? IsAddition { get; set; }

		// Token: 0x170087C5 RID: 34757
		// (get) Token: 0x06038968 RID: 231784 RVA: 0x00D70436 File Offset: 0x00D6E636
		// (set) Token: 0x06038969 RID: 231785 RVA: 0x00D7043E File Offset: 0x00D6E63E
		public int? BaseValue { get; set; }

		// Token: 0x170087C6 RID: 34758
		// (get) Token: 0x0603896A RID: 231786 RVA: 0x00D70447 File Offset: 0x00D6E647
		// (set) Token: 0x0603896B RID: 231787 RVA: 0x00D7044F File Offset: 0x00D6E64F
		public bool? IsLocked { get; set; }

		// Token: 0x170087C7 RID: 34759
		// (get) Token: 0x0603896C RID: 231788 RVA: 0x00D70458 File Offset: 0x00D6E658
		// (set) Token: 0x0603896D RID: 231789 RVA: 0x00D70460 File Offset: 0x00D6E660
		public int? LockedValue { get; set; }
	}
}
