using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004582 RID: 17794
	public class IRollBlockHintStepBaseT
	{
		// Token: 0x17007E71 RID: 32369
		// (get) Token: 0x0601AE0F RID: 110095 RVA: 0x003D6192 File Offset: 0x003D4392
		// (set) Token: 0x0601AE10 RID: 110096 RVA: 0x003D619A File Offset: 0x003D439A
		public ERollBlockHintStepType Type { get; set; }

		// Token: 0x0601AE11 RID: 110097 RVA: 0x003D61A3 File Offset: 0x003D43A3
		public IRollBlockHintStepBaseT()
		{
			this.Type = ERollBlockHintStepType.Roll;
		}
	}
}
