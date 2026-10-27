using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB5 RID: 19125
	public class ICheckJigsawItemPlaceIndexT
	{
		// Token: 0x17008AA4 RID: 35492
		// (get) Token: 0x0601E05E RID: 122974 RVA: 0x00436CB5 File Offset: 0x00434EB5
		// (set) Token: 0x0601E05F RID: 122975 RVA: 0x00436CBD File Offset: 0x00434EBD
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x17008AA5 RID: 35493
		// (get) Token: 0x0601E060 RID: 122976 RVA: 0x00436CC6 File Offset: 0x00434EC6
		// (set) Token: 0x0601E061 RID: 122977 RVA: 0x00436CCE File Offset: 0x00434ECE
		public int ItemEntityId { get; set; }

		// Token: 0x17008AA6 RID: 35494
		// (get) Token: 0x0601E062 RID: 122978 RVA: 0x00436CD7 File Offset: 0x00434ED7
		// (set) Token: 0x0601E063 RID: 122979 RVA: 0x00436CDF File Offset: 0x00434EDF
		public int FoundationEntityId { get; set; }

		// Token: 0x17008AA7 RID: 35495
		// (get) Token: 0x0601E064 RID: 122980 RVA: 0x00436CE8 File Offset: 0x00434EE8
		// (set) Token: 0x0601E065 RID: 122981 RVA: 0x00436CF0 File Offset: 0x00434EF0
		public IPieceIndexT PlaceIndex { get; set; }

		// Token: 0x17008AA8 RID: 35496
		// (get) Token: 0x0601E066 RID: 122982 RVA: 0x00436CF9 File Offset: 0x00434EF9
		// (set) Token: 0x0601E067 RID: 122983 RVA: 0x00436D01 File Offset: 0x00434F01
		public ECompare Compare { get; set; }

		// Token: 0x0601E068 RID: 122984 RVA: 0x00436D0A File Offset: 0x00434F0A
		public ICheckJigsawItemPlaceIndexT()
		{
			this.Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
			this.ItemEntityId = 0;
			this.FoundationEntityId = 0;
			this.PlaceIndex = null;
			this.Compare = ECompare.Eq;
		}
	}
}
