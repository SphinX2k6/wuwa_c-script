using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004588 RID: 17800
	public class IRollBlockHintStepJumpT
	{
		// Token: 0x17007E78 RID: 32376
		// (get) Token: 0x0601AE35 RID: 110133 RVA: 0x003D6556 File Offset: 0x003D4756
		// (set) Token: 0x0601AE36 RID: 110134 RVA: 0x003D655E File Offset: 0x003D475E
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x17007E79 RID: 32377
		// (get) Token: 0x0601AE37 RID: 110135 RVA: 0x003D6567 File Offset: 0x003D4767
		// (set) Token: 0x0601AE38 RID: 110136 RVA: 0x003D656F File Offset: 0x003D476F
		public int BlockId { get; set; }

		// Token: 0x17007E7A RID: 32378
		// (get) Token: 0x0601AE39 RID: 110137 RVA: 0x003D6578 File Offset: 0x003D4778
		// (set) Token: 0x0601AE3A RID: 110138 RVA: 0x003D6580 File Offset: 0x003D4780
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x0601AE3B RID: 110139 RVA: 0x003D6589 File Offset: 0x003D4789
		public IRollBlockHintStepJumpT()
		{
			this.Type = ERollBlockHintStepType.Roll;
			this.BlockId = 0;
			this.Direction = ERollBlockLayType.Left;
		}
	}
}
