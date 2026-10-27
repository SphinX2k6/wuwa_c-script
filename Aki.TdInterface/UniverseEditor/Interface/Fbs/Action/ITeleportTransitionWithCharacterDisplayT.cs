using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AD RID: 29613
	public class ITeleportTransitionWithCharacterDisplayT
	{
		// Token: 0x1700E0CC RID: 57548
		// (get) Token: 0x06035C2B RID: 220203 RVA: 0x0075150C File Offset: 0x0074F70C
		// (set) Token: 0x06035C2C RID: 220204 RVA: 0x00751514 File Offset: 0x0074F714
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0CD RID: 57549
		// (get) Token: 0x06035C2D RID: 220205 RVA: 0x0075151D File Offset: 0x0074F71D
		// (set) Token: 0x06035C2E RID: 220206 RVA: 0x00751525 File Offset: 0x0074F725
		public int StyleId { get; set; }

		// Token: 0x06035C2F RID: 220207 RVA: 0x0075152E File Offset: 0x0074F72E
		public ITeleportTransitionWithCharacterDisplayT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.StyleId = 0;
		}
	}
}
