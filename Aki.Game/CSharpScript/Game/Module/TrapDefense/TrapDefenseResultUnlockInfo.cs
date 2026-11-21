using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A06 RID: 14854
	public class TrapDefenseResultUnlockInfo : ITrapDefenseResultUnlockInfo
	{
		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06026393 RID: 156563 RVA: 0x00AB648D File Offset: 0x00AB468D
		// (set) Token: 0x06026394 RID: 156564 RVA: 0x00AB6495 File Offset: 0x00AB4695
		public ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06026395 RID: 156565 RVA: 0x00AB649E File Offset: 0x00AB469E
		// (set) Token: 0x06026396 RID: 156566 RVA: 0x00AB64A6 File Offset: 0x00AB46A6
		public int Id { get; set; }

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06026397 RID: 156567 RVA: 0x00AB64AF File Offset: 0x00AB46AF
		// (set) Token: 0x06026398 RID: 156568 RVA: 0x00AB64B7 File Offset: 0x00AB46B7
		public bool? NeedUnlockBar { get; set; }

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06026399 RID: 156569 RVA: 0x00AB64C0 File Offset: 0x00AB46C0
		// (set) Token: 0x0602639A RID: 156570 RVA: 0x00AB64C8 File Offset: 0x00AB46C8
		public bool? IsFinish { get; set; }

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x0602639B RID: 156571 RVA: 0x00AB64D1 File Offset: 0x00AB46D1
		// (set) Token: 0x0602639C RID: 156572 RVA: 0x00AB64D9 File Offset: 0x00AB46D9
		public bool? IsNewUnlock { get; set; }

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x0602639D RID: 156573 RVA: 0x00AB64E2 File Offset: 0x00AB46E2
		// (set) Token: 0x0602639E RID: 156574 RVA: 0x00AB64EA File Offset: 0x00AB46EA
		public bool? ForShare { get; set; }
	}
}
