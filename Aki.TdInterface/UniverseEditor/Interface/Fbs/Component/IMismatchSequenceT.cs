using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005558 RID: 21848
	public class IMismatchSequenceT
	{
		// Token: 0x1700A159 RID: 41305
		// (get) Token: 0x060241FF RID: 147967 RVA: 0x004FD79B File Offset: 0x004FB99B
		// (set) Token: 0x06024200 RID: 147968 RVA: 0x004FD7A3 File Offset: 0x004FB9A3
		public EItemFoundationMatchType FoundationType { get; set; }

		// Token: 0x1700A15A RID: 41306
		// (get) Token: 0x06024201 RID: 147969 RVA: 0x004FD7AC File Offset: 0x004FB9AC
		// (set) Token: 0x06024202 RID: 147970 RVA: 0x004FD7B4 File Offset: 0x004FB9B4
		public string MatchSequence { get; set; }

		// Token: 0x06024203 RID: 147971 RVA: 0x004FD7BD File Offset: 0x004FB9BD
		public IMismatchSequenceT()
		{
			this.FoundationType = EItemFoundationMatchType.Branch;
			this.MatchSequence = null;
		}
	}
}
