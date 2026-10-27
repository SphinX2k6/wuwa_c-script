using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A12 RID: 27154
	public class ILimitPlayerActionT
	{
		// Token: 0x1700C976 RID: 51574
		// (get) Token: 0x0602F84B RID: 194635 RVA: 0x0067856A File Offset: 0x0067676A
		// (set) Token: 0x0602F84C RID: 194636 RVA: 0x00678572 File Offset: 0x00676772
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F84D RID: 194637 RVA: 0x0067857B File Offset: 0x0067677B
		public ILimitPlayerActionT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
