using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD1 RID: 24017
	public class IGiantStableValueT
	{
		// Token: 0x1700B3CD RID: 46029
		// (get) Token: 0x060291C0 RID: 168384 RVA: 0x005A46A8 File Offset: 0x005A28A8
		// (set) Token: 0x060291C1 RID: 168385 RVA: 0x005A46B0 File Offset: 0x005A28B0
		public EGiantStableValueBoundary Boundary { get; set; }

		// Token: 0x1700B3CE RID: 46030
		// (get) Token: 0x060291C2 RID: 168386 RVA: 0x005A46B9 File Offset: 0x005A28B9
		// (set) Token: 0x060291C3 RID: 168387 RVA: 0x005A46C1 File Offset: 0x005A28C1
		public int Value { get; set; }

		// Token: 0x060291C4 RID: 168388 RVA: 0x005A46CA File Offset: 0x005A28CA
		public IGiantStableValueT()
		{
			this.Boundary = EGiantStableValueBoundary.Open;
			this.Value = 0;
		}
	}
}
