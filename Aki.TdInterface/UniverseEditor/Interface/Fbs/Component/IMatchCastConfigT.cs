using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005522 RID: 21794
	public class IMatchCastConfigT
	{
		// Token: 0x1700A0E0 RID: 41184
		// (get) Token: 0x06024003 RID: 147459 RVA: 0x004F9953 File Offset: 0x004F7B53
		// (set) Token: 0x06024004 RID: 147460 RVA: 0x004F995B File Offset: 0x004F7B5B
		public int Time { get; set; }

		// Token: 0x1700A0E1 RID: 41185
		// (get) Token: 0x06024005 RID: 147461 RVA: 0x004F9964 File Offset: 0x004F7B64
		// (set) Token: 0x06024006 RID: 147462 RVA: 0x004F996C File Offset: 0x004F7B6C
		public string Spline { get; set; }

		// Token: 0x1700A0E2 RID: 41186
		// (get) Token: 0x06024007 RID: 147463 RVA: 0x004F9975 File Offset: 0x004F7B75
		// (set) Token: 0x06024008 RID: 147464 RVA: 0x004F997D File Offset: 0x004F7B7D
		public List<IMatchSequenceT> MatchSequence { get; set; }

		// Token: 0x1700A0E3 RID: 41187
		// (get) Token: 0x06024009 RID: 147465 RVA: 0x004F9986 File Offset: 0x004F7B86
		// (set) Token: 0x0602400A RID: 147466 RVA: 0x004F998E File Offset: 0x004F7B8E
		public string SpeedCurve { get; set; }

		// Token: 0x1700A0E4 RID: 41188
		// (get) Token: 0x0602400B RID: 147467 RVA: 0x004F9997 File Offset: 0x004F7B97
		// (set) Token: 0x0602400C RID: 147468 RVA: 0x004F999F File Offset: 0x004F7B9F
		public byte NullMask { get; set; }

		// Token: 0x0602400D RID: 147469 RVA: 0x004F99A8 File Offset: 0x004F7BA8
		public IMatchCastConfigT()
		{
			this.Time = 0;
			this.Spline = null;
			this.MatchSequence = null;
			this.SpeedCurve = null;
			this.NullMask = 0;
		}
	}
}
