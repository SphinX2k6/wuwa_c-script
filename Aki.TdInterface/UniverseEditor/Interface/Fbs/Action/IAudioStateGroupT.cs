using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006821 RID: 26657
	public class IAudioStateGroupT
	{
		// Token: 0x1700C402 RID: 50178
		// (get) Token: 0x0602D8E1 RID: 186593 RVA: 0x0063C0EC File Offset: 0x0063A2EC
		// (set) Token: 0x0602D8E2 RID: 186594 RVA: 0x0063C0F4 File Offset: 0x0063A2F4
		public string Group { get; set; }

		// Token: 0x1700C403 RID: 50179
		// (get) Token: 0x0602D8E3 RID: 186595 RVA: 0x0063C0FD File Offset: 0x0063A2FD
		// (set) Token: 0x0602D8E4 RID: 186596 RVA: 0x0063C105 File Offset: 0x0063A305
		public List<string> States { get; set; }

		// Token: 0x0602D8E5 RID: 186597 RVA: 0x0063C10E File Offset: 0x0063A30E
		public IAudioStateGroupT()
		{
			this.Group = null;
			this.States = null;
		}
	}
}
