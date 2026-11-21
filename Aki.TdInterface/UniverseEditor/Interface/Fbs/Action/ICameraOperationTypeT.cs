using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006905 RID: 26885
	public class ICameraOperationTypeT
	{
		// Token: 0x1700C5E0 RID: 50656
		// (get) Token: 0x0602E0F2 RID: 188658 RVA: 0x0064B662 File Offset: 0x00649862
		// (set) Token: 0x0602E0F3 RID: 188659 RVA: 0x0064B66A File Offset: 0x0064986A
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602E0F4 RID: 188660 RVA: 0x0064B673 File Offset: 0x00649873
		public ICameraOperationTypeT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
