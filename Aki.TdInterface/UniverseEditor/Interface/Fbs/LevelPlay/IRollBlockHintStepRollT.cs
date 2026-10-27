using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200458E RID: 17806
	public class IRollBlockHintStepRollT
	{
		// Token: 0x17007E82 RID: 32386
		// (get) Token: 0x0601AE61 RID: 110177 RVA: 0x003D695E File Offset: 0x003D4B5E
		// (set) Token: 0x0601AE62 RID: 110178 RVA: 0x003D6966 File Offset: 0x003D4B66
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x17007E83 RID: 32387
		// (get) Token: 0x0601AE63 RID: 110179 RVA: 0x003D696F File Offset: 0x003D4B6F
		// (set) Token: 0x0601AE64 RID: 110180 RVA: 0x003D6977 File Offset: 0x003D4B77
		public int BlockId { get; set; }

		// Token: 0x17007E84 RID: 32388
		// (get) Token: 0x0601AE65 RID: 110181 RVA: 0x003D6980 File Offset: 0x003D4B80
		// (set) Token: 0x0601AE66 RID: 110182 RVA: 0x003D6988 File Offset: 0x003D4B88
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x0601AE67 RID: 110183 RVA: 0x003D6991 File Offset: 0x003D4B91
		public IRollBlockHintStepRollT()
		{
			this.Type = ERollBlockHintStepType.Roll;
			this.BlockId = 0;
			this.Direction = ERollBlockLayType.Left;
		}
	}
}
