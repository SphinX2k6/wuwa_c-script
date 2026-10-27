using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C13 RID: 27667
	public class IOpenPanelQteQteT
	{
		// Token: 0x1700CDCB RID: 52683
		// (get) Token: 0x06030A8B RID: 199307 RVA: 0x0069B260 File Offset: 0x00699460
		// (set) Token: 0x06030A8C RID: 199308 RVA: 0x0069B268 File Offset: 0x00699468
		public EOpenQteType Type { get; set; }

		// Token: 0x1700CDCC RID: 52684
		// (get) Token: 0x06030A8D RID: 199309 RVA: 0x0069B271 File Offset: 0x00699471
		// (set) Token: 0x06030A8E RID: 199310 RVA: 0x0069B279 File Offset: 0x00699479
		public int Id { get; set; }

		// Token: 0x06030A8F RID: 199311 RVA: 0x0069B282 File Offset: 0x00699482
		public IOpenPanelQteQteT()
		{
			this.Type = EOpenQteType.PanelQte;
			this.Id = 0;
		}
	}
}
