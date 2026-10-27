using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE1 RID: 20193
	public class IAutoConfigT
	{
		// Token: 0x170090F1 RID: 37105
		// (get) Token: 0x0601FD45 RID: 130373 RVA: 0x0046DC98 File Offset: 0x0046BE98
		// (set) Token: 0x0601FD46 RID: 130374 RVA: 0x0046DCA0 File Offset: 0x0046BEA0
		public bool IsCircle { get; set; }

		// Token: 0x170090F2 RID: 37106
		// (get) Token: 0x0601FD47 RID: 130375 RVA: 0x0046DCA9 File Offset: 0x0046BEA9
		// (set) Token: 0x0601FD48 RID: 130376 RVA: 0x0046DCB1 File Offset: 0x0046BEB1
		public int Interval { get; set; }

		// Token: 0x0601FD49 RID: 130377 RVA: 0x0046DCBA File Offset: 0x0046BEBA
		public IAutoConfigT()
		{
			this.IsCircle = false;
			this.Interval = 0;
		}
	}
}
