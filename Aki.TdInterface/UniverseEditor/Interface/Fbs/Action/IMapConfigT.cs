using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007194 RID: 29076
	public class IMapConfigT
	{
		// Token: 0x1700D4D5 RID: 54485
		// (get) Token: 0x060328C4 RID: 207044 RVA: 0x006D4A0E File Offset: 0x006D2C0E
		// (set) Token: 0x060328C5 RID: 207045 RVA: 0x006D4A16 File Offset: 0x006D2C16
		public bool ExpandAreaTerminal { get; set; }

		// Token: 0x060328C6 RID: 207046 RVA: 0x006D4A1F File Offset: 0x006D2C1F
		public IMapConfigT()
		{
			this.ExpandAreaTerminal = false;
		}
	}
}
