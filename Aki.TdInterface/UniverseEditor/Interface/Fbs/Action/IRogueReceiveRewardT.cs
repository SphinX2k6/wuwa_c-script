using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766D RID: 30317
	public class IRogueReceiveRewardT
	{
		// Token: 0x1700DE96 RID: 56982
		// (get) Token: 0x06035315 RID: 217877 RVA: 0x00723D38 File Offset: 0x00721F38
		// (set) Token: 0x06035316 RID: 217878 RVA: 0x00723D40 File Offset: 0x00721F40
		public ERogueRewardReceiveType RogueRewardReceiveType { get; set; }

		// Token: 0x1700DE97 RID: 56983
		// (get) Token: 0x06035317 RID: 217879 RVA: 0x00723D49 File Offset: 0x00721F49
		// (set) Token: 0x06035318 RID: 217880 RVA: 0x00723D51 File Offset: 0x00721F51
		public byte NullMask { get; set; }

		// Token: 0x06035319 RID: 217881 RVA: 0x00723D5A File Offset: 0x00721F5A
		public IRogueReceiveRewardT()
		{
			this.RogueRewardReceiveType = ERogueRewardReceiveType.ReceiveByCount;
			this.NullMask = 0;
		}
	}
}
