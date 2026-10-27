using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D3 RID: 25299
	public class IChangeElementalBoxStateT
	{
		// Token: 0x1700BCDB RID: 48347
		// (get) Token: 0x0602BBB9 RID: 179129 RVA: 0x006048B3 File Offset: 0x00602AB3
		// (set) Token: 0x0602BBBA RID: 179130 RVA: 0x006048BB File Offset: 0x00602ABB
		public TChangeElementalBoxStateTargetUnion Target { get; set; }

		// Token: 0x1700BCDC RID: 48348
		// (get) Token: 0x0602BBBB RID: 179131 RVA: 0x006048C4 File Offset: 0x00602AC4
		// (set) Token: 0x0602BBBC RID: 179132 RVA: 0x006048CC File Offset: 0x00602ACC
		public string State { get; set; }

		// Token: 0x0602BBBD RID: 179133 RVA: 0x006048D5 File Offset: 0x00602AD5
		public IChangeElementalBoxStateT()
		{
			this.Target = null;
			this.State = null;
		}
	}
}
