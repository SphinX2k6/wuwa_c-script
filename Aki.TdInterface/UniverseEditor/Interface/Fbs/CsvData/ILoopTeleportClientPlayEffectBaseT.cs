using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA4 RID: 19876
	public class ILoopTeleportClientPlayEffectBaseT
	{
		// Token: 0x17008E35 RID: 36405
		// (get) Token: 0x0601ED47 RID: 126279 RVA: 0x0044F13B File Offset: 0x0044D33B
		// (set) Token: 0x0601ED48 RID: 126280 RVA: 0x0044F143 File Offset: 0x0044D343
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x17008E36 RID: 36406
		// (get) Token: 0x0601ED49 RID: 126281 RVA: 0x0044F14C File Offset: 0x0044D34C
		// (set) Token: 0x0601ED4A RID: 126282 RVA: 0x0044F154 File Offset: 0x0044D354
		public string Path { get; set; }

		// Token: 0x0601ED4B RID: 126283 RVA: 0x0044F15D File Offset: 0x0044D35D
		public ILoopTeleportClientPlayEffectBaseT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
