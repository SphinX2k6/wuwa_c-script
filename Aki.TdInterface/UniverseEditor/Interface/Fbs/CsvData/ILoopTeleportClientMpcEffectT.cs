using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA1 RID: 19873
	public class ILoopTeleportClientMpcEffectT
	{
		// Token: 0x17008E30 RID: 36400
		// (get) Token: 0x0601ED2F RID: 126255 RVA: 0x0044EF07 File Offset: 0x0044D107
		// (set) Token: 0x0601ED30 RID: 126256 RVA: 0x0044EF0F File Offset: 0x0044D10F
		public ELoopTeleportClientEffectType Type { get; set; }

		// Token: 0x17008E31 RID: 36401
		// (get) Token: 0x0601ED31 RID: 126257 RVA: 0x0044EF18 File Offset: 0x0044D118
		// (set) Token: 0x0601ED32 RID: 126258 RVA: 0x0044EF20 File Offset: 0x0044D120
		public string Path { get; set; }

		// Token: 0x0601ED33 RID: 126259 RVA: 0x0044EF29 File Offset: 0x0044D129
		public ILoopTeleportClientMpcEffectT()
		{
			this.Type = ELoopTeleportClientEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
