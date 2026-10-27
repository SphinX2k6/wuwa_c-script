using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F7 RID: 18423
	public class TCsvEffectConfigDataT
	{
		// Token: 0x17008466 RID: 33894
		// (get) Token: 0x0601C7F9 RID: 116729 RVA: 0x00408037 File Offset: 0x00406237
		// (set) Token: 0x0601C7FA RID: 116730 RVA: 0x0040803F File Offset: 0x0040623F
		public int Id { get; set; }

		// Token: 0x17008467 RID: 33895
		// (get) Token: 0x0601C7FB RID: 116731 RVA: 0x00408048 File Offset: 0x00406248
		// (set) Token: 0x0601C7FC RID: 116732 RVA: 0x00408050 File Offset: 0x00406250
		public IEffectConfigBase_UnionUnion Data { get; set; }

		// Token: 0x0601C7FD RID: 116733 RVA: 0x00408059 File Offset: 0x00406259
		public TCsvEffectConfigDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
