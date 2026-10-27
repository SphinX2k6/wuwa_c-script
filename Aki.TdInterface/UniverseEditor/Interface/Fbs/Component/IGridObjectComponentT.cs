using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532E RID: 21294
	public class IGridObjectComponentT
	{
		// Token: 0x17009C6C RID: 40044
		// (get) Token: 0x06022D06 RID: 142598 RVA: 0x004D2ECD File Offset: 0x004D10CD
		// (set) Token: 0x06022D07 RID: 142599 RVA: 0x004D2ED5 File Offset: 0x004D10D5
		public bool Disabled { get; set; }

		// Token: 0x17009C6D RID: 40045
		// (get) Token: 0x06022D08 RID: 142600 RVA: 0x004D2EDE File Offset: 0x004D10DE
		// (set) Token: 0x06022D09 RID: 142601 RVA: 0x004D2EE6 File Offset: 0x004D10E6
		public IVector2T CellSize { get; set; }

		// Token: 0x17009C6E RID: 40046
		// (get) Token: 0x06022D0A RID: 142602 RVA: 0x004D2EEF File Offset: 0x004D10EF
		// (set) Token: 0x06022D0B RID: 142603 RVA: 0x004D2EF7 File Offset: 0x004D10F7
		public byte NullMask { get; set; }

		// Token: 0x06022D0C RID: 142604 RVA: 0x004D2F00 File Offset: 0x004D1100
		public IGridObjectComponentT()
		{
			this.Disabled = false;
			this.CellSize = null;
			this.NullMask = 0;
		}
	}
}
