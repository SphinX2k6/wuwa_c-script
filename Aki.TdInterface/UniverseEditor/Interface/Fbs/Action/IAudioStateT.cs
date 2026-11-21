using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681E RID: 26654
	public class IAudioStateT
	{
		// Token: 0x1700C3FD RID: 50173
		// (get) Token: 0x0602D8C3 RID: 186563 RVA: 0x0063BD6E File Offset: 0x00639F6E
		// (set) Token: 0x0602D8C4 RID: 186564 RVA: 0x0063BD76 File Offset: 0x00639F76
		public string Group { get; set; }

		// Token: 0x1700C3FE RID: 50174
		// (get) Token: 0x0602D8C5 RID: 186565 RVA: 0x0063BD7F File Offset: 0x00639F7F
		// (set) Token: 0x0602D8C6 RID: 186566 RVA: 0x0063BD87 File Offset: 0x00639F87
		public string State { get; set; }

		// Token: 0x0602D8C7 RID: 186567 RVA: 0x0063BD90 File Offset: 0x00639F90
		public IAudioStateT()
		{
			this.Group = null;
			this.State = null;
		}
	}
}
