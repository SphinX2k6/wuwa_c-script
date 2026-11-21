using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA2 RID: 24226
	public class IRtSizeT
	{
		// Token: 0x1700B2E7 RID: 45799
		// (get) Token: 0x0602891A RID: 166170 RVA: 0x0058BDDC File Offset: 0x00589FDC
		// (set) Token: 0x0602891B RID: 166171 RVA: 0x0058BDE4 File Offset: 0x00589FE4
		public int Length { get; set; }

		// Token: 0x1700B2E8 RID: 45800
		// (get) Token: 0x0602891C RID: 166172 RVA: 0x0058BDED File Offset: 0x00589FED
		// (set) Token: 0x0602891D RID: 166173 RVA: 0x0058BDF5 File Offset: 0x00589FF5
		public int Width { get; set; }

		// Token: 0x0602891E RID: 166174 RVA: 0x0058BDFE File Offset: 0x00589FFE
		public IRtSizeT()
		{
			this.Length = 0;
			this.Width = 0;
		}
	}
}
