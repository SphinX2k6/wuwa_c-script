using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005881 RID: 22657
	public class IGraffitiPointPairT
	{
		// Token: 0x1700A437 RID: 42039
		// (get) Token: 0x06024BE0 RID: 150496 RVA: 0x0050BF84 File Offset: 0x0050A184
		// (set) Token: 0x06024BE1 RID: 150497 RVA: 0x0050BF8C File Offset: 0x0050A18C
		public IVectorInfoT SourcePos { get; set; }

		// Token: 0x1700A438 RID: 42040
		// (get) Token: 0x06024BE2 RID: 150498 RVA: 0x0050BF95 File Offset: 0x0050A195
		// (set) Token: 0x06024BE3 RID: 150499 RVA: 0x0050BF9D File Offset: 0x0050A19D
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700A439 RID: 42041
		// (get) Token: 0x06024BE4 RID: 150500 RVA: 0x0050BFA6 File Offset: 0x0050A1A6
		// (set) Token: 0x06024BE5 RID: 150501 RVA: 0x0050BFAE File Offset: 0x0050A1AE
		public float ErrorRange { get; set; }

		// Token: 0x06024BE6 RID: 150502 RVA: 0x0050BFB7 File Offset: 0x0050A1B7
		public IGraffitiPointPairT()
		{
			this.SourcePos = null;
			this.TargetPos = null;
			this.ErrorRange = 0f;
		}
	}
}
