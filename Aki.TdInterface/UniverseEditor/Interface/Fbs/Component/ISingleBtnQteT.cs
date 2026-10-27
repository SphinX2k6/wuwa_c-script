using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005915 RID: 22805
	public class ISingleBtnQteT
	{
		// Token: 0x1700AAF3 RID: 43763
		// (get) Token: 0x060268BA RID: 157882 RVA: 0x0054F4C2 File Offset: 0x0054D6C2
		// (set) Token: 0x060268BB RID: 157883 RVA: 0x0054F4CA File Offset: 0x0054D6CA
		public EQteType Type { get; set; }

		// Token: 0x1700AAF4 RID: 43764
		// (get) Token: 0x060268BC RID: 157884 RVA: 0x0054F4D3 File Offset: 0x0054D6D3
		// (set) Token: 0x060268BD RID: 157885 RVA: 0x0054F4DB File Offset: 0x0054D6DB
		public int QteId { get; set; }

		// Token: 0x1700AAF5 RID: 43765
		// (get) Token: 0x060268BE RID: 157886 RVA: 0x0054F4E4 File Offset: 0x0054D6E4
		// (set) Token: 0x060268BF RID: 157887 RVA: 0x0054F4EC File Offset: 0x0054D6EC
		public IQteCallbackT SuccessCallback { get; set; }

		// Token: 0x1700AAF6 RID: 43766
		// (get) Token: 0x060268C0 RID: 157888 RVA: 0x0054F4F5 File Offset: 0x0054D6F5
		// (set) Token: 0x060268C1 RID: 157889 RVA: 0x0054F4FD File Offset: 0x0054D6FD
		public IQteCallbackT FailureCallback { get; set; }

		// Token: 0x060268C2 RID: 157890 RVA: 0x0054F506 File Offset: 0x0054D706
		public ISingleBtnQteT()
		{
			this.Type = EQteType.SingleBtn;
			this.QteId = 0;
			this.SuccessCallback = null;
			this.FailureCallback = null;
		}
	}
}
