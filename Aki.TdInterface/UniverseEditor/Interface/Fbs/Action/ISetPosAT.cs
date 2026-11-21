using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007828 RID: 30760
	public class ISetPosAT
	{
		// Token: 0x1700E1B7 RID: 57783
		// (get) Token: 0x06036193 RID: 221587 RVA: 0x0073F9B5 File Offset: 0x0073DBB5
		// (set) Token: 0x06036194 RID: 221588 RVA: 0x0073F9BD File Offset: 0x0073DBBD
		public IPosAT Pos { get; set; }

		// Token: 0x06036195 RID: 221589 RVA: 0x0073F9C6 File Offset: 0x0073DBC6
		public ISetPosAT()
		{
			this.Pos = null;
		}
	}
}
