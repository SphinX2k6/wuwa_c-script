using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F8 RID: 22264
	public class KurotatoMediumItemGridData : IKurotatoMediumItemGridData
	{
		// Token: 0x1700880F RID: 34831
		// (get) Token: 0x06038A04 RID: 231940 RVA: 0x00D706DA File Offset: 0x00D6E8DA
		// (set) Token: 0x06038A05 RID: 231941 RVA: 0x00D706E2 File Offset: 0x00D6E8E2
		public EKurotatoCardType Type { get; set; }

		// Token: 0x17008810 RID: 34832
		// (get) Token: 0x06038A06 RID: 231942 RVA: 0x00D706EB File Offset: 0x00D6E8EB
		// (set) Token: 0x06038A07 RID: 231943 RVA: 0x00D706F3 File Offset: 0x00D6E8F3
		public int Id { get; set; }

		// Token: 0x17008811 RID: 34833
		// (get) Token: 0x06038A08 RID: 231944 RVA: 0x00D706FC File Offset: 0x00D6E8FC
		// (set) Token: 0x06038A09 RID: 231945 RVA: 0x00D70704 File Offset: 0x00D6E904
		public int IncId { get; set; }

		// Token: 0x17008812 RID: 34834
		// (get) Token: 0x06038A0A RID: 231946 RVA: 0x00D7070D File Offset: 0x00D6E90D
		// (set) Token: 0x06038A0B RID: 231947 RVA: 0x00D70715 File Offset: 0x00D6E915
		public int Count { get; set; }

		// Token: 0x17008813 RID: 34835
		// (get) Token: 0x06038A0C RID: 231948 RVA: 0x00D7071E File Offset: 0x00D6E91E
		// (set) Token: 0x06038A0D RID: 231949 RVA: 0x00D70726 File Offset: 0x00D6E926
		public int? PreWaveDealtDamage { get; set; }
	}
}
