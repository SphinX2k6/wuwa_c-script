using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005525 RID: 21797
	public class IMatchSequenceT
	{
		// Token: 0x1700A0E9 RID: 41193
		// (get) Token: 0x06024023 RID: 147491 RVA: 0x004F9CED File Offset: 0x004F7EED
		// (set) Token: 0x06024024 RID: 147492 RVA: 0x004F9CF5 File Offset: 0x004F7EF5
		public EItemFoundationMatchType FoundationType { get; set; }

		// Token: 0x1700A0EA RID: 41194
		// (get) Token: 0x06024025 RID: 147493 RVA: 0x004F9CFE File Offset: 0x004F7EFE
		// (set) Token: 0x06024026 RID: 147494 RVA: 0x004F9D06 File Offset: 0x004F7F06
		public IVectorInfoT MatchPoint { get; set; }

		// Token: 0x1700A0EB RID: 41195
		// (get) Token: 0x06024027 RID: 147495 RVA: 0x004F9D0F File Offset: 0x004F7F0F
		// (set) Token: 0x06024028 RID: 147496 RVA: 0x004F9D17 File Offset: 0x004F7F17
		public string MatchSequence { get; set; }

		// Token: 0x06024029 RID: 147497 RVA: 0x004F9D20 File Offset: 0x004F7F20
		public IMatchSequenceT()
		{
			this.FoundationType = EItemFoundationMatchType.Branch;
			this.MatchPoint = null;
			this.MatchSequence = null;
		}
	}
}
