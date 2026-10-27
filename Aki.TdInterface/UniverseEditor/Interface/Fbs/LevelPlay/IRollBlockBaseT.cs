using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200454F RID: 17743
	public class IRollBlockBaseT
	{
		// Token: 0x17007DDE RID: 32222
		// (get) Token: 0x0601AB43 RID: 109379 RVA: 0x003CEEBC File Offset: 0x003CD0BC
		// (set) Token: 0x0601AB44 RID: 109380 RVA: 0x003CEEC4 File Offset: 0x003CD0C4
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17007DDF RID: 32223
		// (get) Token: 0x0601AB45 RID: 109381 RVA: 0x003CEECD File Offset: 0x003CD0CD
		// (set) Token: 0x0601AB46 RID: 109382 RVA: 0x003CEED5 File Offset: 0x003CD0D5
		public int BlockId { get; set; }

		// Token: 0x0601AB47 RID: 109383 RVA: 0x003CEEDE File Offset: 0x003CD0DE
		public IRollBlockBaseT()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
		}
	}
}
