using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C83 RID: 15491
	public interface IRoleDevSkillSlotItemData
	{
		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x060279FB RID: 162299
		// (set) Token: 0x060279FC RID: 162300
		int RoleId { get; set; }

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x060279FD RID: 162301
		// (set) Token: 0x060279FE RID: 162302
		int SkillNodeId { get; set; }

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x060279FF RID: 162303
		// (set) Token: 0x06027A00 RID: 162304
		int CurrentLevel { get; set; }

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x06027A01 RID: 162305
		// (set) Token: 0x06027A02 RID: 162306
		int NormalTargetLevel { get; set; }

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x06027A03 RID: 162307
		// (set) Token: 0x06027A04 RID: 162308
		int PerfectTargetLevel { get; set; }
	}
}
