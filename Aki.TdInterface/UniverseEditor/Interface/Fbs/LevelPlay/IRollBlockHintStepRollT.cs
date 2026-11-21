using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F6 RID: 18934
	public class IRollBlockHintStepRollT
	{
		// Token: 0x170084C3 RID: 33987
		// (get) Token: 0x0601C636 RID: 116278 RVA: 0x00402BFA File Offset: 0x00400DFA
		// (set) Token: 0x0601C637 RID: 116279 RVA: 0x00402C02 File Offset: 0x00400E02
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x170084C4 RID: 33988
		// (get) Token: 0x0601C638 RID: 116280 RVA: 0x00402C0B File Offset: 0x00400E0B
		// (set) Token: 0x0601C639 RID: 116281 RVA: 0x00402C13 File Offset: 0x00400E13
		public int BlockId { get; set; }

		// Token: 0x170084C5 RID: 33989
		// (get) Token: 0x0601C63A RID: 116282 RVA: 0x00402C1C File Offset: 0x00400E1C
		// (set) Token: 0x0601C63B RID: 116283 RVA: 0x00402C24 File Offset: 0x00400E24
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x0601C63C RID: 116284 RVA: 0x00402C2D File Offset: 0x00400E2D
		public IRollBlockHintStepRollT()
		{
			this.Type = ERollBlockHintStepType.Roll;
			this.BlockId = 0;
			this.Direction = ERollBlockLayType.Left;
		}
	}
}
