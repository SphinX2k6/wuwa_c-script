using System;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02003D40 RID: 15680
	public class RoleLangSetVoiceParam : IRoleLangSetVoiceParam
	{
		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x06028265 RID: 164453 RVA: 0x00B3C4CD File Offset: 0x00B3A6CD
		// (set) Token: 0x06028266 RID: 164454 RVA: 0x00B3C4D5 File Offset: 0x00B3A6D5
		public int RoleId { get; set; }

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x06028267 RID: 164455 RVA: 0x00B3C4DE File Offset: 0x00B3A6DE
		// (set) Token: 0x06028268 RID: 164456 RVA: 0x00B3C4E6 File Offset: 0x00B3A6E6
		public int Lang { get; set; }

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x06028269 RID: 164457 RVA: 0x00B3C4EF File Offset: 0x00B3A6EF
		// (set) Token: 0x0602826A RID: 164458 RVA: 0x00B3C4F7 File Offset: 0x00B3A6F7
		public bool NeedRequest { get; set; }

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x0602826B RID: 164459 RVA: 0x00B3C500 File Offset: 0x00B3A700
		// (set) Token: 0x0602826C RID: 164460 RVA: 0x00B3C508 File Offset: 0x00B3A708
		public bool IsCustom { get; set; }

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x0602826D RID: 164461 RVA: 0x00B3C511 File Offset: 0x00B3A711
		// (set) Token: 0x0602826E RID: 164462 RVA: 0x00B3C519 File Offset: 0x00B3A719
		public bool IsCover { get; set; }
	}
}
