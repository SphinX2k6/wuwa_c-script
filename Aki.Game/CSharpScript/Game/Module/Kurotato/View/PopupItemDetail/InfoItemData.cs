using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02004711 RID: 18193
	[NullableContext(1)]
	[Nullable(0)]
	public class InfoItemData : IInfoItemData
	{
		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x0602DB64 RID: 187236 RVA: 0x00CC8E20 File Offset: 0x00CC7020
		// (set) Token: 0x0602DB65 RID: 187237 RVA: 0x00CC8E28 File Offset: 0x00CC7028
		public int Level { get; set; }

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x0602DB66 RID: 187238 RVA: 0x00CC8E31 File Offset: 0x00CC7031
		// (set) Token: 0x0602DB67 RID: 187239 RVA: 0x00CC8E39 File Offset: 0x00CC7039
		public string Description { get; set; } = string.Empty;

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x0602DB68 RID: 187240 RVA: 0x00CC8E42 File Offset: 0x00CC7042
		// (set) Token: 0x0602DB69 RID: 187241 RVA: 0x00CC8E4A File Offset: 0x00CC704A
		public int BuildLevel { get; set; }

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x0602DB6A RID: 187242 RVA: 0x00CC8E53 File Offset: 0x00CC7053
		// (set) Token: 0x0602DB6B RID: 187243 RVA: 0x00CC8E5B File Offset: 0x00CC705B
		public bool IsArrowLevel { get; set; }
	}
}
