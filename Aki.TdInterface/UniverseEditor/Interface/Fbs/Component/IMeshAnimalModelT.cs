using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADE RID: 23262
	public class IMeshAnimalModelT
	{
		// Token: 0x1700A9BB RID: 43451
		// (get) Token: 0x0602633C RID: 156476 RVA: 0x0053C4F7 File Offset: 0x0053A6F7
		// (set) Token: 0x0602633D RID: 156477 RVA: 0x0053C4FF File Offset: 0x0053A6FF
		public EAnimalModelType Type { get; set; }

		// Token: 0x1700A9BC RID: 43452
		// (get) Token: 0x0602633E RID: 156478 RVA: 0x0053C508 File Offset: 0x0053A708
		// (set) Token: 0x0602633F RID: 156479 RVA: 0x0053C510 File Offset: 0x0053A710
		public string Mesh { get; set; }

		// Token: 0x06026340 RID: 156480 RVA: 0x0053C519 File Offset: 0x0053A719
		public IMeshAnimalModelT()
		{
			this.Type = EAnimalModelType.Mesh;
			this.Mesh = null;
		}
	}
}
