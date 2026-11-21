using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACB RID: 27339
	public class ICommonBtContextT
	{
		// Token: 0x1700C8C2 RID: 51394
		// (get) Token: 0x0602EED9 RID: 192217 RVA: 0x006645DC File Offset: 0x006627DC
		// (set) Token: 0x0602EEDA RID: 192218 RVA: 0x006645E4 File Offset: 0x006627E4
		public EVarContext Type { get; set; }

		// Token: 0x1700C8C3 RID: 51395
		// (get) Token: 0x0602EEDB RID: 192219 RVA: 0x006645ED File Offset: 0x006627ED
		// (set) Token: 0x0602EEDC RID: 192220 RVA: 0x006645F5 File Offset: 0x006627F5
		public int Id { get; set; }

		// Token: 0x0602EEDD RID: 192221 RVA: 0x006645FE File Offset: 0x006627FE
		public ICommonBtContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
