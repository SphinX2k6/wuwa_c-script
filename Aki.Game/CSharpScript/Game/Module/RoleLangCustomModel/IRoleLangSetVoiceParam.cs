using System;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D76 RID: 19830
	public interface IRoleLangSetVoiceParam
	{
		// Token: 0x17007E75 RID: 32373
		// (get) Token: 0x060333ED RID: 209901
		// (set) Token: 0x060333EE RID: 209902
		int RoleId { get; set; }

		// Token: 0x17007E76 RID: 32374
		// (get) Token: 0x060333EF RID: 209903
		// (set) Token: 0x060333F0 RID: 209904
		int Lang { get; set; }

		// Token: 0x17007E77 RID: 32375
		// (get) Token: 0x060333F1 RID: 209905
		// (set) Token: 0x060333F2 RID: 209906
		bool NeedRequest { get; set; }

		// Token: 0x17007E78 RID: 32376
		// (get) Token: 0x060333F3 RID: 209907
		// (set) Token: 0x060333F4 RID: 209908
		bool IsCustom { get; set; }

		// Token: 0x17007E79 RID: 32377
		// (get) Token: 0x060333F5 RID: 209909
		// (set) Token: 0x060333F6 RID: 209910
		bool IsCover { get; set; }
	}
}
