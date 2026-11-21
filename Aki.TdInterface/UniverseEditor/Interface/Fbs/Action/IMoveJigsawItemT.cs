using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728F RID: 29327
	public class IMoveJigsawItemT
	{
		// Token: 0x1700D6FA RID: 55034
		// (get) Token: 0x060331B4 RID: 209332 RVA: 0x006E585F File Offset: 0x006E3A5F
		// (set) Token: 0x060331B5 RID: 209333 RVA: 0x006E5867 File Offset: 0x006E3A67
		public ESetJigsawItemType Type { get; set; }

		// Token: 0x1700D6FB RID: 55035
		// (get) Token: 0x060331B6 RID: 209334 RVA: 0x006E5870 File Offset: 0x006E3A70
		// (set) Token: 0x060331B7 RID: 209335 RVA: 0x006E5878 File Offset: 0x006E3A78
		public int ItemEntityId { get; set; }

		// Token: 0x1700D6FC RID: 55036
		// (get) Token: 0x060331B8 RID: 209336 RVA: 0x006E5881 File Offset: 0x006E3A81
		// (set) Token: 0x060331B9 RID: 209337 RVA: 0x006E5889 File Offset: 0x006E3A89
		public int FoundationEntityId { get; set; }

		// Token: 0x1700D6FD RID: 55037
		// (get) Token: 0x060331BA RID: 209338 RVA: 0x006E5892 File Offset: 0x006E3A92
		// (set) Token: 0x060331BB RID: 209339 RVA: 0x006E589A File Offset: 0x006E3A9A
		public IPieceIndexT Destination { get; set; }

		// Token: 0x060331BC RID: 209340 RVA: 0x006E58A3 File Offset: 0x006E3AA3
		public IMoveJigsawItemT()
		{
			this.Type = ESetJigsawItemType.MoveJigsawItem;
			this.ItemEntityId = 0;
			this.FoundationEntityId = 0;
			this.Destination = null;
		}
	}
}
