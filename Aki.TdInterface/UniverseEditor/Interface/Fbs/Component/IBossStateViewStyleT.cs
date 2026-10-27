using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F1D RID: 20253
	public class IBossStateViewStyleT
	{
		// Token: 0x170091E5 RID: 37349
		// (get) Token: 0x0602008A RID: 131210 RVA: 0x0047528E File Offset: 0x0047348E
		// (set) Token: 0x0602008B RID: 131211 RVA: 0x00475296 File Offset: 0x00473496
		public EBossStateViewStyle Type { get; set; }

		// Token: 0x0602008C RID: 131212 RVA: 0x0047529F File Offset: 0x0047349F
		public IBossStateViewStyleT()
		{
			this.Type = EBossStateViewStyle.DoubleView;
		}
	}
}
