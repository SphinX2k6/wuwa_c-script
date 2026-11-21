using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F84 RID: 20356
	public class ICheckJigsawItemPlaceIndexT
	{
		// Token: 0x17009191 RID: 37265
		// (get) Token: 0x0601FB47 RID: 129863 RVA: 0x004684D5 File Offset: 0x004666D5
		// (set) Token: 0x0601FB48 RID: 129864 RVA: 0x004684DD File Offset: 0x004666DD
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x17009192 RID: 37266
		// (get) Token: 0x0601FB49 RID: 129865 RVA: 0x004684E6 File Offset: 0x004666E6
		// (set) Token: 0x0601FB4A RID: 129866 RVA: 0x004684EE File Offset: 0x004666EE
		public int ItemEntityId { get; set; }

		// Token: 0x17009193 RID: 37267
		// (get) Token: 0x0601FB4B RID: 129867 RVA: 0x004684F7 File Offset: 0x004666F7
		// (set) Token: 0x0601FB4C RID: 129868 RVA: 0x004684FF File Offset: 0x004666FF
		public int FoundationEntityId { get; set; }

		// Token: 0x17009194 RID: 37268
		// (get) Token: 0x0601FB4D RID: 129869 RVA: 0x00468508 File Offset: 0x00466708
		// (set) Token: 0x0601FB4E RID: 129870 RVA: 0x00468510 File Offset: 0x00466710
		public IPieceIndexT PlaceIndex { get; set; }

		// Token: 0x17009195 RID: 37269
		// (get) Token: 0x0601FB4F RID: 129871 RVA: 0x00468519 File Offset: 0x00466719
		// (set) Token: 0x0601FB50 RID: 129872 RVA: 0x00468521 File Offset: 0x00466721
		public ECompare Compare { get; set; }

		// Token: 0x0601FB51 RID: 129873 RVA: 0x0046852A File Offset: 0x0046672A
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
