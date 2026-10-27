using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653E RID: 25918
	public class IDartInteractTypeBaseT
	{
		// Token: 0x1700C0A9 RID: 49321
		// (get) Token: 0x0602CF70 RID: 184176 RVA: 0x0062C682 File Offset: 0x0062A882
		// (set) Token: 0x0602CF71 RID: 184177 RVA: 0x0062C68A File Offset: 0x0062A88A
		public EDartInteractType Type { get; set; }

		// Token: 0x0602CF72 RID: 184178 RVA: 0x0062C693 File Offset: 0x0062A893
		public IDartInteractTypeBaseT()
		{
			this.Type = EDartInteractType.Machine;
		}
	}
}
