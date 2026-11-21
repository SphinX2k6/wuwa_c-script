using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CE RID: 22734
	public class IGroupAiPatrolT
	{
		// Token: 0x1700A4DB RID: 42203
		// (get) Token: 0x06024EA8 RID: 151208 RVA: 0x00511A6C File Offset: 0x0050FC6C
		// (set) Token: 0x06024EA9 RID: 151209 RVA: 0x00511A74 File Offset: 0x0050FC74
		public EGroupAiMode Type { get; set; }

		// Token: 0x1700A4DC RID: 42204
		// (get) Token: 0x06024EAA RID: 151210 RVA: 0x00511A7D File Offset: 0x0050FC7D
		// (set) Token: 0x06024EAB RID: 151211 RVA: 0x00511A85 File Offset: 0x0050FC85
		public int Leader { get; set; }

		// Token: 0x1700A4DD RID: 42205
		// (get) Token: 0x06024EAC RID: 151212 RVA: 0x00511A8E File Offset: 0x0050FC8E
		// (set) Token: 0x06024EAD RID: 151213 RVA: 0x00511A96 File Offset: 0x0050FC96
		public int SplineEntityId { get; set; }

		// Token: 0x1700A4DE RID: 42206
		// (get) Token: 0x06024EAE RID: 151214 RVA: 0x00511A9F File Offset: 0x0050FC9F
		// (set) Token: 0x06024EAF RID: 151215 RVA: 0x00511AA7 File Offset: 0x0050FCA7
		public int PlayerPlaceholderEntityId { get; set; }

		// Token: 0x1700A4DF RID: 42207
		// (get) Token: 0x06024EB0 RID: 151216 RVA: 0x00511AB0 File Offset: 0x0050FCB0
		// (set) Token: 0x06024EB1 RID: 151217 RVA: 0x00511AB8 File Offset: 0x0050FCB8
		public EGroupAiFormationBasis FormationBasis { get; set; }

		// Token: 0x1700A4E0 RID: 42208
		// (get) Token: 0x06024EB2 RID: 151218 RVA: 0x00511AC1 File Offset: 0x0050FCC1
		// (set) Token: 0x06024EB3 RID: 151219 RVA: 0x00511AC9 File Offset: 0x0050FCC9
		public bool IsPreciseFormation { get; set; }

		// Token: 0x1700A4E1 RID: 42209
		// (get) Token: 0x06024EB4 RID: 151220 RVA: 0x00511AD2 File Offset: 0x0050FCD2
		// (set) Token: 0x06024EB5 RID: 151221 RVA: 0x00511ADA File Offset: 0x0050FCDA
		public IGroupAiEcologyGameplayAbpT EcologyGameplayAbp { get; set; }

		// Token: 0x1700A4E2 RID: 42210
		// (get) Token: 0x06024EB6 RID: 151222 RVA: 0x00511AE3 File Offset: 0x0050FCE3
		// (set) Token: 0x06024EB7 RID: 151223 RVA: 0x00511AEB File Offset: 0x0050FCEB
		public byte NullMask { get; set; }

		// Token: 0x06024EB8 RID: 151224 RVA: 0x00511AF4 File Offset: 0x0050FCF4
		public IGroupAiPatrolT()
		{
			this.Type = EGroupAiMode.Default;
			this.Leader = 0;
			this.SplineEntityId = 0;
			this.PlayerPlaceholderEntityId = 0;
			this.FormationBasis = EGroupAiFormationBasis.Spline;
			this.IsPreciseFormation = false;
			this.EcologyGameplayAbp = new IGroupAiEcologyGameplayAbpT();
			this.NullMask = 0;
		}
	}
}
