using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670D RID: 26381
	public class IActorFxEmoteT
	{
		// Token: 0x1700BFC3 RID: 49091
		// (get) Token: 0x0602CAC9 RID: 182985 RVA: 0x0061CCA3 File Offset: 0x0061AEA3
		// (set) Token: 0x0602CACA RID: 182986 RVA: 0x0061CCAB File Offset: 0x0061AEAB
		public int ActorIndex { get; set; }

		// Token: 0x1700BFC4 RID: 49092
		// (get) Token: 0x0602CACB RID: 182987 RVA: 0x0061CCB4 File Offset: 0x0061AEB4
		// (set) Token: 0x0602CACC RID: 182988 RVA: 0x0061CCBC File Offset: 0x0061AEBC
		public TActorFxEmoteUnion FxEmote { get; set; }

		// Token: 0x0602CACD RID: 182989 RVA: 0x0061CCC5 File Offset: 0x0061AEC5
		public IActorFxEmoteT()
		{
			this.ActorIndex = 0;
			this.FxEmote = null;
		}
	}
}
