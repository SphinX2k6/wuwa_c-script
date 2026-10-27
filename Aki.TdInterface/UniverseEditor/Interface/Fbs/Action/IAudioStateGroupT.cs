using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B3 RID: 25011
	public class IAudioStateGroupT
	{
		// Token: 0x1700BA7F RID: 47743
		// (get) Token: 0x0602B19A RID: 176538 RVA: 0x005F1678 File Offset: 0x005EF878
		// (set) Token: 0x0602B19B RID: 176539 RVA: 0x005F1680 File Offset: 0x005EF880
		public string Group { get; set; }

		// Token: 0x1700BA80 RID: 47744
		// (get) Token: 0x0602B19C RID: 176540 RVA: 0x005F1689 File Offset: 0x005EF889
		// (set) Token: 0x0602B19D RID: 176541 RVA: 0x005F1691 File Offset: 0x005EF891
		public List<string> States { get; set; }

		// Token: 0x0602B19E RID: 176542 RVA: 0x005F169A File Offset: 0x005EF89A
		public IAudioStateGroupT()
		{
			this.Group = null;
			this.States = null;
		}
	}
}
