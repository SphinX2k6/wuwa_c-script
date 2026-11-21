using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A5 RID: 29861
	public class IPlayMontageT
	{
		// Token: 0x1700DB6D RID: 56173
		// (get) Token: 0x060344B0 RID: 214192 RVA: 0x0070AEB4 File Offset: 0x007090B4
		// (set) Token: 0x060344B1 RID: 214193 RVA: 0x0070AEBC File Offset: 0x007090BC
		public int EntityId { get; set; }

		// Token: 0x1700DB6E RID: 56174
		// (get) Token: 0x060344B2 RID: 214194 RVA: 0x0070AEC5 File Offset: 0x007090C5
		// (set) Token: 0x060344B3 RID: 214195 RVA: 0x0070AECD File Offset: 0x007090CD
		public IActionMontageT ActionMontage { get; set; }

		// Token: 0x1700DB6F RID: 56175
		// (get) Token: 0x060344B4 RID: 214196 RVA: 0x0070AED6 File Offset: 0x007090D6
		// (set) Token: 0x060344B5 RID: 214197 RVA: 0x0070AEDE File Offset: 0x007090DE
		public string ExpressionMontage { get; set; }

		// Token: 0x1700DB70 RID: 56176
		// (get) Token: 0x060344B6 RID: 214198 RVA: 0x0070AEE7 File Offset: 0x007090E7
		// (set) Token: 0x060344B7 RID: 214199 RVA: 0x0070AEEF File Offset: 0x007090EF
		public string MouthSequence { get; set; }

		// Token: 0x1700DB71 RID: 56177
		// (get) Token: 0x060344B8 RID: 214200 RVA: 0x0070AEF8 File Offset: 0x007090F8
		// (set) Token: 0x060344B9 RID: 214201 RVA: 0x0070AF00 File Offset: 0x00709100
		public int Duration { get; set; }

		// Token: 0x1700DB72 RID: 56178
		// (get) Token: 0x060344BA RID: 214202 RVA: 0x0070AF09 File Offset: 0x00709109
		// (set) Token: 0x060344BB RID: 214203 RVA: 0x0070AF11 File Offset: 0x00709111
		public byte NullMask { get; set; }

		// Token: 0x060344BC RID: 214204 RVA: 0x0070AF1A File Offset: 0x0070911A
		public IPlayMontageT()
		{
			this.EntityId = 0;
			this.ActionMontage = null;
			this.ExpressionMontage = null;
			this.MouthSequence = null;
			this.Duration = 0;
			this.NullMask = 0;
		}
	}
}
