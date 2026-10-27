using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD7 RID: 24023
	public class IGiantStableValueRegionT
	{
		// Token: 0x1700B3D8 RID: 46040
		// (get) Token: 0x060291EE RID: 168430 RVA: 0x005A4C81 File Offset: 0x005A2E81
		// (set) Token: 0x060291EF RID: 168431 RVA: 0x005A4C89 File Offset: 0x005A2E89
		public EGiantStableValueType Type { get; set; }

		// Token: 0x1700B3D9 RID: 46041
		// (get) Token: 0x060291F0 RID: 168432 RVA: 0x005A4C92 File Offset: 0x005A2E92
		// (set) Token: 0x060291F1 RID: 168433 RVA: 0x005A4C9A File Offset: 0x005A2E9A
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x1700B3DA RID: 46042
		// (get) Token: 0x060291F2 RID: 168434 RVA: 0x005A4CA3 File Offset: 0x005A2EA3
		// (set) Token: 0x060291F3 RID: 168435 RVA: 0x005A4CAB File Offset: 0x005A2EAB
		public IGiantStableValueRangeT Range { get; set; }

		// Token: 0x060291F4 RID: 168436 RVA: 0x005A4CB4 File Offset: 0x005A2EB4
		public IGiantStableValueRegionT()
		{
			this.Type = EGiantStableValueType.Region;
			this.EcoType = EGiantEcoType.Fire;
			this.Range = null;
		}
	}
}
