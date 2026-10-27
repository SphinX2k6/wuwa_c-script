using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056E7 RID: 22247
	public interface IKurotatoRoleSkillInfo
	{
		// Token: 0x170087BA RID: 34746
		// (get) Token: 0x06038952 RID: 231762
		// (set) Token: 0x06038953 RID: 231763
		int AttrId { get; set; }

		// Token: 0x170087BB RID: 34747
		// (get) Token: 0x06038954 RID: 231764
		// (set) Token: 0x06038955 RID: 231765
		int Value { get; set; }

		// Token: 0x170087BC RID: 34748
		// (get) Token: 0x06038956 RID: 231766
		// (set) Token: 0x06038957 RID: 231767
		bool IsRecommend { get; set; }

		// Token: 0x170087BD RID: 34749
		// (get) Token: 0x06038958 RID: 231768
		// (set) Token: 0x06038959 RID: 231769
		bool? IsAddition { get; set; }

		// Token: 0x170087BE RID: 34750
		// (get) Token: 0x0603895A RID: 231770
		// (set) Token: 0x0603895B RID: 231771
		int? BaseValue { get; set; }

		// Token: 0x170087BF RID: 34751
		// (get) Token: 0x0603895C RID: 231772
		// (set) Token: 0x0603895D RID: 231773
		bool? IsLocked { get; set; }

		// Token: 0x170087C0 RID: 34752
		// (get) Token: 0x0603895E RID: 231774
		// (set) Token: 0x0603895F RID: 231775
		int? LockedValue { get; set; }
	}
}
