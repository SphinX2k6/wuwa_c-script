using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B49 RID: 27465
	public class IMoveJigsawItemT
	{
		// Token: 0x1700CC15 RID: 52245
		// (get) Token: 0x0603035D RID: 197469 RVA: 0x0068D2A3 File Offset: 0x0068B4A3
		// (set) Token: 0x0603035E RID: 197470 RVA: 0x0068D2AB File Offset: 0x0068B4AB
		public ESetJigsawItemType Type { get; set; }

		// Token: 0x1700CC16 RID: 52246
		// (get) Token: 0x0603035F RID: 197471 RVA: 0x0068D2B4 File Offset: 0x0068B4B4
		// (set) Token: 0x06030360 RID: 197472 RVA: 0x0068D2BC File Offset: 0x0068B4BC
		public int ItemEntityId { get; set; }

		// Token: 0x1700CC17 RID: 52247
		// (get) Token: 0x06030361 RID: 197473 RVA: 0x0068D2C5 File Offset: 0x0068B4C5
		// (set) Token: 0x06030362 RID: 197474 RVA: 0x0068D2CD File Offset: 0x0068B4CD
		public int FoundationEntityId { get; set; }

		// Token: 0x1700CC18 RID: 52248
		// (get) Token: 0x06030363 RID: 197475 RVA: 0x0068D2D6 File Offset: 0x0068B4D6
		// (set) Token: 0x06030364 RID: 197476 RVA: 0x0068D2DE File Offset: 0x0068B4DE
		public IPieceIndexT Destination { get; set; }

		// Token: 0x06030365 RID: 197477 RVA: 0x0068D2E7 File Offset: 0x0068B4E7
		public IMoveJigsawItemT()
		{
			this.Type = ESetJigsawItemType.MoveJigsawItem;
			this.ItemEntityId = 0;
			this.FoundationEntityId = 0;
			this.Destination = null;
		}
	}
}
