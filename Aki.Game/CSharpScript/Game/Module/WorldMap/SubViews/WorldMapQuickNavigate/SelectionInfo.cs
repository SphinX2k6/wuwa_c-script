using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x0200370B RID: 14091
	public class SelectionInfo : ISelectionInfo
	{
		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x06024AC8 RID: 150216 RVA: 0x00A5A4E9 File Offset: 0x00A586E9
		// (set) Token: 0x06024AC9 RID: 150217 RVA: 0x00A5A4F1 File Offset: 0x00A586F1
		public int FirstIndex { get; set; }

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x06024ACA RID: 150218 RVA: 0x00A5A4FA File Offset: 0x00A586FA
		// (set) Token: 0x06024ACB RID: 150219 RVA: 0x00A5A502 File Offset: 0x00A58702
		public int SecondIndex { get; set; }

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x06024ACC RID: 150220 RVA: 0x00A5A50B File Offset: 0x00A5870B
		// (set) Token: 0x06024ACD RID: 150221 RVA: 0x00A5A513 File Offset: 0x00A58713
		public int CountryId { get; set; }

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x06024ACE RID: 150222 RVA: 0x00A5A51C File Offset: 0x00A5871C
		// (set) Token: 0x06024ACF RID: 150223 RVA: 0x00A5A524 File Offset: 0x00A58724
		public bool ExpandCountry { get; set; }

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x06024AD0 RID: 150224 RVA: 0x00A5A52D File Offset: 0x00A5872D
		// (set) Token: 0x06024AD1 RID: 150225 RVA: 0x00A5A535 File Offset: 0x00A58735
		public int StateId { get; set; }

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x06024AD2 RID: 150226 RVA: 0x00A5A53E File Offset: 0x00A5873E
		// (set) Token: 0x06024AD3 RID: 150227 RVA: 0x00A5A546 File Offset: 0x00A58746
		public int AreaId { get; set; }
	}
}
