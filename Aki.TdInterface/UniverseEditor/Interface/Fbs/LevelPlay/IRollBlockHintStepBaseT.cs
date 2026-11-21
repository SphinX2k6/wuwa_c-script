using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049EA RID: 18922
	public class IRollBlockHintStepBaseT
	{
		// Token: 0x170084B2 RID: 33970
		// (get) Token: 0x0601C5E4 RID: 116196 RVA: 0x0040242E File Offset: 0x0040062E
		// (set) Token: 0x0601C5E5 RID: 116197 RVA: 0x00402436 File Offset: 0x00400636
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x0601C5E6 RID: 116198 RVA: 0x0040243F File Offset: 0x0040063F
		public IRollBlockHintStepBaseT()
		{
			this.Type = ERollBlockHintStepType.Roll;
		}
	}
}
