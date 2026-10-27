using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200458B RID: 17803
	public class IRollBlockHintStepOperationT
	{
		// Token: 0x17007E7D RID: 32381
		// (get) Token: 0x0601AE4B RID: 110155 RVA: 0x003D6726 File Offset: 0x003D4926
		// (set) Token: 0x0601AE4C RID: 110156 RVA: 0x003D672E File Offset: 0x003D492E
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x0601AE4D RID: 110157 RVA: 0x003D6737 File Offset: 0x003D4937
		public IRollBlockHintStepOperationT()
		{
			this.Type = ERollBlockHintStepType.Roll;
		}
	}
}
