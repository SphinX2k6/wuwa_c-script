using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E60 RID: 20064
	public class IAdsorbAddBuffT
	{
		// Token: 0x17008F95 RID: 36757
		// (get) Token: 0x0601F800 RID: 129024 RVA: 0x004632D8 File Offset: 0x004614D8
		// (set) Token: 0x0601F801 RID: 129025 RVA: 0x004632E0 File Offset: 0x004614E0
		public EBuffProducerMode Type { get; set; }

		// Token: 0x17008F96 RID: 36758
		// (get) Token: 0x0601F802 RID: 129026 RVA: 0x004632E9 File Offset: 0x004614E9
		// (set) Token: 0x0601F803 RID: 129027 RVA: 0x004632F1 File Offset: 0x004614F1
		public int Speed { get; set; }

		// Token: 0x0601F804 RID: 129028 RVA: 0x004632FA File Offset: 0x004614FA
		public IAdsorbAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
			this.Speed = 0;
		}
	}
}
