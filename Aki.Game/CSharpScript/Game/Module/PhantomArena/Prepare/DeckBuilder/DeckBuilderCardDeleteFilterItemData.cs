using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005187 RID: 20871
	public class DeckBuilderCardDeleteFilterItemData : IDeckBuilderCardDeleteFilterItemData
	{
		// Token: 0x17008140 RID: 33088
		// (get) Token: 0x0603561B RID: 218651 RVA: 0x00CA506F File Offset: 0x00CA326F
		// (set) Token: 0x0603561C RID: 218652 RVA: 0x00CA5077 File Offset: 0x00CA3277
		public ECardElement Element { get; set; }

		// Token: 0x17008141 RID: 33089
		// (get) Token: 0x0603561D RID: 218653 RVA: 0x00CA5080 File Offset: 0x00CA3280
		// (set) Token: 0x0603561E RID: 218654 RVA: 0x00CA5088 File Offset: 0x00CA3288
		public bool Enabled { get; set; }

		// Token: 0x17008142 RID: 33090
		// (get) Token: 0x0603561F RID: 218655 RVA: 0x00CA5091 File Offset: 0x00CA3291
		// (set) Token: 0x06035620 RID: 218656 RVA: 0x00CA5099 File Offset: 0x00CA3299
		public bool Selected { get; set; }
	}
}
