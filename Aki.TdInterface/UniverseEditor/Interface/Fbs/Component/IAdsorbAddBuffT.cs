using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005371 RID: 21361
	public class IAdsorbAddBuffT
	{
		// Token: 0x170096CE RID: 38606
		// (get) Token: 0x0602144B RID: 136267 RVA: 0x004972F0 File Offset: 0x004954F0
		// (set) Token: 0x0602144C RID: 136268 RVA: 0x004972F8 File Offset: 0x004954F8
		public EBuffProducerMode Type { get; set; }

		// Token: 0x170096CF RID: 38607
		// (get) Token: 0x0602144D RID: 136269 RVA: 0x00497301 File Offset: 0x00495501
		// (set) Token: 0x0602144E RID: 136270 RVA: 0x00497309 File Offset: 0x00495509
		public int Speed { get; set; }

		// Token: 0x0602144F RID: 136271 RVA: 0x00497312 File Offset: 0x00495512
		public IAdsorbAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
			this.Speed = 0;
		}
	}
}
