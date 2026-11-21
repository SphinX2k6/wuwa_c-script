using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F0 RID: 18928
	public class IRollBlockHintStepJumpT
	{
		// Token: 0x170084B9 RID: 33977
		// (get) Token: 0x0601C60A RID: 116234 RVA: 0x004027F2 File Offset: 0x004009F2
		// (set) Token: 0x0601C60B RID: 116235 RVA: 0x004027FA File Offset: 0x004009FA
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x170084BA RID: 33978
		// (get) Token: 0x0601C60C RID: 116236 RVA: 0x00402803 File Offset: 0x00400A03
		// (set) Token: 0x0601C60D RID: 116237 RVA: 0x0040280B File Offset: 0x00400A0B
		public int BlockId { get; set; }

		// Token: 0x170084BB RID: 33979
		// (get) Token: 0x0601C60E RID: 116238 RVA: 0x00402814 File Offset: 0x00400A14
		// (set) Token: 0x0601C60F RID: 116239 RVA: 0x0040281C File Offset: 0x00400A1C
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x0601C610 RID: 116240 RVA: 0x00402825 File Offset: 0x00400A25
		public IRollBlockHintStepJumpT()
		{
			this.Type = ERollBlockHintStepType.Roll;
			this.BlockId = 0;
			this.Direction = ERollBlockLayType.Left;
		}
	}
}
