using System;

// Token: 0x02000F83 RID: 3971
public class FurnitureSlotScrollItemData : IFurnitureSlotScrollItemData
{
	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x060065D1 RID: 26065 RVA: 0x00143D62 File Offset: 0x00141F62
	// (set) Token: 0x060065D2 RID: 26066 RVA: 0x00143D6A File Offset: 0x00141F6A
	public int SceneSlotEntityId { get; set; }

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x060065D3 RID: 26067 RVA: 0x00143D73 File Offset: 0x00141F73
	// (set) Token: 0x060065D4 RID: 26068 RVA: 0x00143D7B File Offset: 0x00141F7B
	public int PlacedFurnitureId { get; set; }

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x060065D5 RID: 26069 RVA: 0x00143D84 File Offset: 0x00141F84
	// (set) Token: 0x060065D6 RID: 26070 RVA: 0x00143D8C File Offset: 0x00141F8C
	public int SubSlotIndex { get; set; }

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x060065D7 RID: 26071 RVA: 0x00143D95 File Offset: 0x00141F95
	// (set) Token: 0x060065D8 RID: 26072 RVA: 0x00143D9D File Offset: 0x00141F9D
	public EFurnitureSlotType SlotType { get; set; }

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x060065D9 RID: 26073 RVA: 0x00143DA6 File Offset: 0x00141FA6
	// (set) Token: 0x060065DA RID: 26074 RVA: 0x00143DAE File Offset: 0x00141FAE
	public int TagId { get; set; }

	// Token: 0x170007D1 RID: 2001
	// (get) Token: 0x060065DB RID: 26075 RVA: 0x00143DB7 File Offset: 0x00141FB7
	// (set) Token: 0x060065DC RID: 26076 RVA: 0x00143DBF File Offset: 0x00141FBF
	public int TagIndex { get; set; }

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x060065DD RID: 26077 RVA: 0x00143DC8 File Offset: 0x00141FC8
	// (set) Token: 0x060065DE RID: 26078 RVA: 0x00143DD0 File Offset: 0x00141FD0
	public bool ShowTagIndex { get; set; }

	// Token: 0x170007D3 RID: 2003
	// (get) Token: 0x060065DF RID: 26079 RVA: 0x00143DD9 File Offset: 0x00141FD9
	// (set) Token: 0x060065E0 RID: 26080 RVA: 0x00143DE1 File Offset: 0x00141FE1
	public bool IsSelected { get; set; }

	// Token: 0x170007D4 RID: 2004
	// (get) Token: 0x060065E1 RID: 26081 RVA: 0x00143DEA File Offset: 0x00141FEA
	// (set) Token: 0x060065E2 RID: 26082 RVA: 0x00143DF2 File Offset: 0x00141FF2
	public bool LineShowState { get; set; }

	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x060065E3 RID: 26083 RVA: 0x00143DFB File Offset: 0x00141FFB
	// (set) Token: 0x060065E4 RID: 26084 RVA: 0x00143E03 File Offset: 0x00142003
	public bool RedDotShowState { get; set; }
}
