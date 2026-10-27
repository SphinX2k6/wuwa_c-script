using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CE RID: 21710
	public class ILevelAiCycleModeTypeT
	{
		// Token: 0x17009FFC RID: 40956
		// (get) Token: 0x06023C80 RID: 146560 RVA: 0x004F24A2 File Offset: 0x004F06A2
		// (set) Token: 0x06023C81 RID: 146561 RVA: 0x004F24AA File Offset: 0x004F06AA
		public ELevelAiCycleMode Type { get; set; }

		// Token: 0x06023C82 RID: 146562 RVA: 0x004F24B3 File Offset: 0x004F06B3
		public ILevelAiCycleModeTypeT()
		{
			this.Type = ELevelAiCycleMode.Loop;
		}
	}
}
