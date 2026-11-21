using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F3 RID: 18931
	public class IRollBlockHintStepOperationT
	{
		// Token: 0x170084BE RID: 33982
		// (get) Token: 0x0601C620 RID: 116256 RVA: 0x004029C2 File Offset: 0x00400BC2
		// (set) Token: 0x0601C621 RID: 116257 RVA: 0x004029CA File Offset: 0x00400BCA
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x0601C622 RID: 116258 RVA: 0x004029D3 File Offset: 0x00400BD3
		public IRollBlockHintStepOperationT()
		{
			this.Type = ERollBlockHintStepType.Roll;
		}
	}
}
