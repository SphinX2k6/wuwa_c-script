using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B4 RID: 22708
	public class IGridObjectComponentT
	{
		// Token: 0x1700A4A4 RID: 42148
		// (get) Token: 0x06024DBA RID: 150970 RVA: 0x0050FDA1 File Offset: 0x0050DFA1
		// (set) Token: 0x06024DBB RID: 150971 RVA: 0x0050FDA9 File Offset: 0x0050DFA9
		public bool Disabled { get; set; }

		// Token: 0x1700A4A5 RID: 42149
		// (get) Token: 0x06024DBC RID: 150972 RVA: 0x0050FDB2 File Offset: 0x0050DFB2
		// (set) Token: 0x06024DBD RID: 150973 RVA: 0x0050FDBA File Offset: 0x0050DFBA
		public IVector2T CellSize { get; set; }

		// Token: 0x1700A4A6 RID: 42150
		// (get) Token: 0x06024DBE RID: 150974 RVA: 0x0050FDC3 File Offset: 0x0050DFC3
		// (set) Token: 0x06024DBF RID: 150975 RVA: 0x0050FDCB File Offset: 0x0050DFCB
		public byte NullMask { get; set; }

		// Token: 0x06024DC0 RID: 150976 RVA: 0x0050FDD4 File Offset: 0x0050DFD4
		public IGridObjectComponentT()
		{
			this.Disabled = false;
			this.CellSize = null;
			this.NullMask = 0;
		}
	}
}
