using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C7D RID: 15485
	public interface ISkillSlotExtendData
	{
		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x060279C4 RID: 162244
		// (set) Token: 0x060279C5 RID: 162245
		int RoleId { get; set; }

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x060279C6 RID: 162246
		// (set) Token: 0x060279C7 RID: 162247
		int SkillNodeId { get; set; }

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x060279C8 RID: 162248
		// (set) Token: 0x060279C9 RID: 162249
		int IconId { get; set; }

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x060279CA RID: 162250
		// (set) Token: 0x060279CB RID: 162251
		int CurrentLevel { get; set; }

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x060279CC RID: 162252
		// (set) Token: 0x060279CD RID: 162253
		int NormalTargetLevel { get; set; }

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x060279CE RID: 162254
		// (set) Token: 0x060279CF RID: 162255
		int PerfectTargetLevel { get; set; }

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x060279D0 RID: 162256
		// (set) Token: 0x060279D1 RID: 162257
		ESkillType SkillType { get; set; }

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x060279D2 RID: 162258
		// (set) Token: 0x060279D3 RID: 162259
		int NodeIndex { get; set; }
	}
}
