using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC0 RID: 27328
	public class IColorMapDataT
	{
		// Token: 0x1700C8B2 RID: 51378
		// (get) Token: 0x0602EE8C RID: 192140 RVA: 0x00663F07 File Offset: 0x00662107
		// (set) Token: 0x0602EE8D RID: 192141 RVA: 0x00663F0F File Offset: 0x0066210F
		public string Key { get; set; }

		// Token: 0x1700C8B3 RID: 51379
		// (get) Token: 0x0602EE8E RID: 192142 RVA: 0x00663F18 File Offset: 0x00662118
		// (set) Token: 0x0602EE8F RID: 192143 RVA: 0x00663F20 File Offset: 0x00662120
		public IColorT Color { get; set; }

		// Token: 0x0602EE90 RID: 192144 RVA: 0x00663F29 File Offset: 0x00662129
		public IColorMapDataT()
		{
			this.Key = null;
			this.Color = null;
		}
	}
}
