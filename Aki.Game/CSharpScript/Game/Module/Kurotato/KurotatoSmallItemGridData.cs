using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F6 RID: 22262
	public class KurotatoSmallItemGridData : IKurotatoSmallItemGridData
	{
		// Token: 0x17008802 RID: 34818
		// (get) Token: 0x060389E9 RID: 231913 RVA: 0x00D7064A File Offset: 0x00D6E84A
		// (set) Token: 0x060389EA RID: 231914 RVA: 0x00D70652 File Offset: 0x00D6E852
		public EKurotatoCardType Type { get; set; }

		// Token: 0x17008803 RID: 34819
		// (get) Token: 0x060389EB RID: 231915 RVA: 0x00D7065B File Offset: 0x00D6E85B
		// (set) Token: 0x060389EC RID: 231916 RVA: 0x00D70663 File Offset: 0x00D6E863
		public int Id { get; set; }

		// Token: 0x17008804 RID: 34820
		// (get) Token: 0x060389ED RID: 231917 RVA: 0x00D7066C File Offset: 0x00D6E86C
		// (set) Token: 0x060389EE RID: 231918 RVA: 0x00D70674 File Offset: 0x00D6E874
		public int IncId { get; set; }

		// Token: 0x17008805 RID: 34821
		// (get) Token: 0x060389EF RID: 231919 RVA: 0x00D7067D File Offset: 0x00D6E87D
		// (set) Token: 0x060389F0 RID: 231920 RVA: 0x00D70685 File Offset: 0x00D6E885
		public int Count { get; set; }

		// Token: 0x17008806 RID: 34822
		// (get) Token: 0x060389F1 RID: 231921 RVA: 0x00D7068E File Offset: 0x00D6E88E
		// (set) Token: 0x060389F2 RID: 231922 RVA: 0x00D70696 File Offset: 0x00D6E896
		public bool? PlayComposeFx { get; set; }

		// Token: 0x17008807 RID: 34823
		// (get) Token: 0x060389F3 RID: 231923 RVA: 0x00D7069F File Offset: 0x00D6E89F
		// (set) Token: 0x060389F4 RID: 231924 RVA: 0x00D706A7 File Offset: 0x00D6E8A7
		public bool? ShowArrow { get; set; }

		// Token: 0x17008808 RID: 34824
		// (get) Token: 0x060389F5 RID: 231925 RVA: 0x00D706B0 File Offset: 0x00D6E8B0
		// (set) Token: 0x060389F6 RID: 231926 RVA: 0x00D706B8 File Offset: 0x00D6E8B8
		public bool? IsReceived { get; set; }

		// Token: 0x17008809 RID: 34825
		// (get) Token: 0x060389F7 RID: 231927 RVA: 0x00D706C1 File Offset: 0x00D6E8C1
		// (set) Token: 0x060389F8 RID: 231928 RVA: 0x00D706C9 File Offset: 0x00D6E8C9
		public bool? IsShowCount { get; set; }
	}
}
