using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA6 RID: 23718
	public class IPasserbyNpcPerNpcRandomExitIntervalT
	{
		// Token: 0x1700AE39 RID: 44601
		// (get) Token: 0x06027593 RID: 161171 RVA: 0x00562F1B File Offset: 0x0056111B
		// (set) Token: 0x06027594 RID: 161172 RVA: 0x00562F23 File Offset: 0x00561123
		public EPasserbyNpcExitIntervalType Type { get; set; }

		// Token: 0x1700AE3A RID: 44602
		// (get) Token: 0x06027595 RID: 161173 RVA: 0x00562F2C File Offset: 0x0056112C
		// (set) Token: 0x06027596 RID: 161174 RVA: 0x00562F34 File Offset: 0x00561134
		public IPasserbyNpcNearSplineStartFirstExitOrderT MoveOrder { get; set; }

		// Token: 0x1700AE3B RID: 44603
		// (get) Token: 0x06027597 RID: 161175 RVA: 0x00562F3D File Offset: 0x0056113D
		// (set) Token: 0x06027598 RID: 161176 RVA: 0x00562F45 File Offset: 0x00561145
		public float MaxInterval { get; set; }

		// Token: 0x1700AE3C RID: 44604
		// (get) Token: 0x06027599 RID: 161177 RVA: 0x00562F4E File Offset: 0x0056114E
		// (set) Token: 0x0602759A RID: 161178 RVA: 0x00562F56 File Offset: 0x00561156
		public float MinInterval { get; set; }

		// Token: 0x0602759B RID: 161179 RVA: 0x00562F5F File Offset: 0x0056115F
		public IPasserbyNpcPerNpcRandomExitIntervalT()
		{
			this.Type = EPasserbyNpcExitIntervalType.PerNpcRandom;
			this.MoveOrder = null;
			this.MaxInterval = 0f;
			this.MinInterval = 0f;
		}
	}
}
