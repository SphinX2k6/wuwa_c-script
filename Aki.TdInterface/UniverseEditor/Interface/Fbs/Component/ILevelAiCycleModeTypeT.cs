using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A54 RID: 23124
	public class ILevelAiCycleModeTypeT
	{
		// Token: 0x1700A836 RID: 43062
		// (get) Token: 0x06025D38 RID: 154936 RVA: 0x0052F516 File Offset: 0x0052D716
		// (set) Token: 0x06025D39 RID: 154937 RVA: 0x0052F51E File Offset: 0x0052D71E
		public ELevelAiCycleMode Type { get; set; }

		// Token: 0x06025D3A RID: 154938 RVA: 0x0052F527 File Offset: 0x0052D727
		public ILevelAiCycleModeTypeT()
		{
			this.Type = ELevelAiCycleMode.Loop;
		}
	}
}
