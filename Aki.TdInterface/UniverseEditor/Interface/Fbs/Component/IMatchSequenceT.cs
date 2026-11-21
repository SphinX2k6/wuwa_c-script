using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAB RID: 23211
	public class IMatchSequenceT
	{
		// Token: 0x1700A923 RID: 43299
		// (get) Token: 0x060260DD RID: 155869 RVA: 0x00536E11 File Offset: 0x00535011
		// (set) Token: 0x060260DE RID: 155870 RVA: 0x00536E19 File Offset: 0x00535019
		public EItemFoundationMatchType FoundationType { get; set; }

		// Token: 0x1700A924 RID: 43300
		// (get) Token: 0x060260DF RID: 155871 RVA: 0x00536E22 File Offset: 0x00535022
		// (set) Token: 0x060260E0 RID: 155872 RVA: 0x00536E2A File Offset: 0x0053502A
		public IVectorInfoT MatchPoint { get; set; }

		// Token: 0x1700A925 RID: 43301
		// (get) Token: 0x060260E1 RID: 155873 RVA: 0x00536E33 File Offset: 0x00535033
		// (set) Token: 0x060260E2 RID: 155874 RVA: 0x00536E3B File Offset: 0x0053503B
		public string MatchSequence { get; set; }

		// Token: 0x060260E3 RID: 155875 RVA: 0x00536E44 File Offset: 0x00535044
		public IMatchSequenceT()
		{
			this.FoundationType = EItemFoundationMatchType.Branch;
			this.MatchPoint = null;
			this.MatchSequence = null;
		}
	}
}
