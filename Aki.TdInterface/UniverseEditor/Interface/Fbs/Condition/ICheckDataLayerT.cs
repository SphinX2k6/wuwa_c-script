using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E7F RID: 20095
	public class ICheckDataLayerT
	{
		// Token: 0x17008F4E RID: 36686
		// (get) Token: 0x0601F205 RID: 127493 RVA: 0x004579C8 File Offset: 0x00455BC8
		// (set) Token: 0x0601F206 RID: 127494 RVA: 0x004579D0 File Offset: 0x00455BD0
		public int DataLayerId { get; set; }

		// Token: 0x17008F4F RID: 36687
		// (get) Token: 0x0601F207 RID: 127495 RVA: 0x004579D9 File Offset: 0x00455BD9
		// (set) Token: 0x0601F208 RID: 127496 RVA: 0x004579E1 File Offset: 0x00455BE1
		public bool IsLoad { get; set; }

		// Token: 0x0601F209 RID: 127497 RVA: 0x004579EA File Offset: 0x00455BEA
		public ICheckDataLayerT()
		{
			this.DataLayerId = 0;
			this.IsLoad = false;
		}
	}
}
