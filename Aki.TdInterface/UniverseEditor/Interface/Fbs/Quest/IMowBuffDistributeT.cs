using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200438C RID: 17292
	public class IMowBuffDistributeT
	{
		// Token: 0x170076A6 RID: 30374
		// (get) Token: 0x0601871C RID: 100124 RVA: 0x0037BF78 File Offset: 0x0037A178
		// (set) Token: 0x0601871D RID: 100125 RVA: 0x0037BF80 File Offset: 0x0037A180
		public EShowUiType Type { get; set; }

		// Token: 0x170076A7 RID: 30375
		// (get) Token: 0x0601871E RID: 100126 RVA: 0x0037BF89 File Offset: 0x0037A189
		// (set) Token: 0x0601871F RID: 100127 RVA: 0x0037BF91 File Offset: 0x0037A191
		public int BoardId { get; set; }

		// Token: 0x06018720 RID: 100128 RVA: 0x0037BF9A File Offset: 0x0037A19A
		public IMowBuffDistributeT()
		{
			this.Type = EShowUiType.All;
			this.BoardId = 0;
		}
	}
}
