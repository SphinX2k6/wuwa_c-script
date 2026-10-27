using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005717 RID: 22295
	public class IPavedWayConfigT
	{
		// Token: 0x1700A61E RID: 42526
		// (get) Token: 0x060254C5 RID: 152773 RVA: 0x00525A6E File Offset: 0x00523C6E
		// (set) Token: 0x060254C6 RID: 152774 RVA: 0x00525A76 File Offset: 0x00523C76
		public bool AutoSprint { get; set; }

		// Token: 0x060254C7 RID: 152775 RVA: 0x00525A7F File Offset: 0x00523C7F
		public IPavedWayConfigT()
		{
			this.AutoSprint = false;
		}
	}
}
