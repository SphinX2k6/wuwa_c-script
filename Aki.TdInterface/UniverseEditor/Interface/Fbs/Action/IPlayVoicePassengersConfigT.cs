using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D45 RID: 27973
	public class IPlayVoicePassengersConfigT
	{
		// Token: 0x1700D09D RID: 53405
		// (get) Token: 0x0603163D RID: 202301 RVA: 0x006B2BB1 File Offset: 0x006B0DB1
		// (set) Token: 0x0603163E RID: 202302 RVA: 0x006B2BB9 File Offset: 0x006B0DB9
		public List<int> Passengers { get; set; }

		// Token: 0x1700D09E RID: 53406
		// (get) Token: 0x0603163F RID: 202303 RVA: 0x006B2BC2 File Offset: 0x006B0DC2
		// (set) Token: 0x06031640 RID: 202304 RVA: 0x006B2BCA File Offset: 0x006B0DCA
		public bool MatchNone { get; set; }

		// Token: 0x1700D09F RID: 53407
		// (get) Token: 0x06031641 RID: 202305 RVA: 0x006B2BD3 File Offset: 0x006B0DD3
		// (set) Token: 0x06031642 RID: 202306 RVA: 0x006B2BDB File Offset: 0x006B0DDB
		public byte NullMask { get; set; }

		// Token: 0x06031643 RID: 202307 RVA: 0x006B2BE4 File Offset: 0x006B0DE4
		public IPlayVoicePassengersConfigT()
		{
			this.Passengers = null;
			this.MatchNone = false;
			this.NullMask = 0;
		}
	}
}
