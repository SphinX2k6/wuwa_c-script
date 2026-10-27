using System;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D77 RID: 19831
	public class RoleLangSetVoiceParam : IRoleLangSetVoiceParam
	{
		// Token: 0x17007E7A RID: 32378
		// (get) Token: 0x060333F7 RID: 209911 RVA: 0x00BF32A9 File Offset: 0x00BF14A9
		// (set) Token: 0x060333F8 RID: 209912 RVA: 0x00BF32B1 File Offset: 0x00BF14B1
		public int RoleId { get; set; }

		// Token: 0x17007E7B RID: 32379
		// (get) Token: 0x060333F9 RID: 209913 RVA: 0x00BF32BA File Offset: 0x00BF14BA
		// (set) Token: 0x060333FA RID: 209914 RVA: 0x00BF32C2 File Offset: 0x00BF14C2
		public int Lang { get; set; }

		// Token: 0x17007E7C RID: 32380
		// (get) Token: 0x060333FB RID: 209915 RVA: 0x00BF32CB File Offset: 0x00BF14CB
		// (set) Token: 0x060333FC RID: 209916 RVA: 0x00BF32D3 File Offset: 0x00BF14D3
		public bool NeedRequest { get; set; }

		// Token: 0x17007E7D RID: 32381
		// (get) Token: 0x060333FD RID: 209917 RVA: 0x00BF32DC File Offset: 0x00BF14DC
		// (set) Token: 0x060333FE RID: 209918 RVA: 0x00BF32E4 File Offset: 0x00BF14E4
		public bool IsCustom { get; set; }

		// Token: 0x17007E7E RID: 32382
		// (get) Token: 0x060333FF RID: 209919 RVA: 0x00BF32ED File Offset: 0x00BF14ED
		// (set) Token: 0x06033400 RID: 209920 RVA: 0x00BF32F5 File Offset: 0x00BF14F5
		public bool IsCover { get; set; }
	}
}
