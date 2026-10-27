using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005895 RID: 22677
	public class IRtSizeT
	{
		// Token: 0x1700A9B7 RID: 43447
		// (get) Token: 0x060263B8 RID: 156600 RVA: 0x00545290 File Offset: 0x00543490
		// (set) Token: 0x060263B9 RID: 156601 RVA: 0x00545298 File Offset: 0x00543498
		public int Length { get; set; }

		// Token: 0x1700A9B8 RID: 43448
		// (get) Token: 0x060263BA RID: 156602 RVA: 0x005452A1 File Offset: 0x005434A1
		// (set) Token: 0x060263BB RID: 156603 RVA: 0x005452A9 File Offset: 0x005434A9
		public int Width { get; set; }

		// Token: 0x060263BC RID: 156604 RVA: 0x005452B2 File Offset: 0x005434B2
		public IRtSizeT()
		{
			this.Length = 0;
			this.Width = 0;
		}
	}
}
