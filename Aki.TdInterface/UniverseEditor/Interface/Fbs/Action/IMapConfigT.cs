using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A72 RID: 27250
	public class IMapConfigT
	{
		// Token: 0x1700CA2A RID: 51754
		// (get) Token: 0x0602FB9E RID: 195486 RVA: 0x0067E94E File Offset: 0x0067CB4E
		// (set) Token: 0x0602FB9F RID: 195487 RVA: 0x0067E956 File Offset: 0x0067CB56
		public bool ExpandAreaTerminal { get; set; }

		// Token: 0x0602FBA0 RID: 195488 RVA: 0x0067E95F File Offset: 0x0067CB5F
		public IMapConfigT()
		{
			this.ExpandAreaTerminal = false;
		}
	}
}
