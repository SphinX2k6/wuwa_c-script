using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7E RID: 23166
	public class ILifePointCenterComponentT
	{
		// Token: 0x1700A8C0 RID: 43200
		// (get) Token: 0x06025F45 RID: 155461 RVA: 0x00534040 File Offset: 0x00532240
		// (set) Token: 0x06025F46 RID: 155462 RVA: 0x00534048 File Offset: 0x00532248
		public bool Disabled { get; set; }

		// Token: 0x1700A8C1 RID: 43201
		// (get) Token: 0x06025F47 RID: 155463 RVA: 0x00534051 File Offset: 0x00532251
		// (set) Token: 0x06025F48 RID: 155464 RVA: 0x00534059 File Offset: 0x00532259
		public byte NullMask { get; set; }

		// Token: 0x06025F49 RID: 155465 RVA: 0x00534062 File Offset: 0x00532262
		public ILifePointCenterComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
