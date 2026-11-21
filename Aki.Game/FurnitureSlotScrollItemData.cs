using System;

// Token: 0x02000438 RID: 1080
public class FurnitureSlotScrollItemData : IFurnitureSlotScrollItemData
{
	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x06003969 RID: 14697 RVA: 0x0014C5F6 File Offset: 0x0014A7F6
	// (set) Token: 0x0600396A RID: 14698 RVA: 0x0014C5FE File Offset: 0x0014A7FE
	public int SceneSlotEntityId { get; set; }

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x0600396B RID: 14699 RVA: 0x0014C607 File Offset: 0x0014A807
	// (set) Token: 0x0600396C RID: 14700 RVA: 0x0014C60F File Offset: 0x0014A80F
	public int PlacedFurnitureId { get; set; }

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x0600396D RID: 14701 RVA: 0x0014C618 File Offset: 0x0014A818
	// (set) Token: 0x0600396E RID: 14702 RVA: 0x0014C620 File Offset: 0x0014A820
	public int SubSlotIndex { get; set; }

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x0600396F RID: 14703 RVA: 0x0014C629 File Offset: 0x0014A829
	// (set) Token: 0x06003970 RID: 14704 RVA: 0x0014C631 File Offset: 0x0014A831
	public EFurnitureSlotType SlotType { get; set; }

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x06003971 RID: 14705 RVA: 0x0014C63A File Offset: 0x0014A83A
	// (set) Token: 0x06003972 RID: 14706 RVA: 0x0014C642 File Offset: 0x0014A842
	public int TagId { get; set; }

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x06003973 RID: 14707 RVA: 0x0014C64B File Offset: 0x0014A84B
	// (set) Token: 0x06003974 RID: 14708 RVA: 0x0014C653 File Offset: 0x0014A853
	public int TagIndex { get; set; }

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x06003975 RID: 14709 RVA: 0x0014C65C File Offset: 0x0014A85C
	// (set) Token: 0x06003976 RID: 14710 RVA: 0x0014C664 File Offset: 0x0014A864
	public bool ShowTagIndex { get; set; }

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x06003977 RID: 14711 RVA: 0x0014C66D File Offset: 0x0014A86D
	// (set) Token: 0x06003978 RID: 14712 RVA: 0x0014C675 File Offset: 0x0014A875
	public bool IsSelected { get; set; }

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06003979 RID: 14713 RVA: 0x0014C67E File Offset: 0x0014A87E
	// (set) Token: 0x0600397A RID: 14714 RVA: 0x0014C686 File Offset: 0x0014A886
	public bool LineShowState { get; set; }

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x0600397B RID: 14715 RVA: 0x0014C68F File Offset: 0x0014A88F
	// (set) Token: 0x0600397C RID: 14716 RVA: 0x0014C697 File Offset: 0x0014A897
	public bool RedDotShowState { get; set; }
}
