using System;

// Token: 0x02002034 RID: 8244
public class KingShipAttributeItemData : IKingShipAttributeItemData
{
	// Token: 0x170013BE RID: 5054
	// (get) Token: 0x060102E0 RID: 66272 RVA: 0x003F09EB File Offset: 0x003EEBEB
	// (set) Token: 0x060102E1 RID: 66273 RVA: 0x003F09F3 File Offset: 0x003EEBF3
	public int AttributeId { get; set; }

	// Token: 0x170013BF RID: 5055
	// (get) Token: 0x060102E2 RID: 66274 RVA: 0x003F09FC File Offset: 0x003EEBFC
	// (set) Token: 0x060102E3 RID: 66275 RVA: 0x003F0A04 File Offset: 0x003EEC04
	public int MaxCount { get; set; }

	// Token: 0x170013C0 RID: 5056
	// (get) Token: 0x060102E4 RID: 66276 RVA: 0x003F0A0D File Offset: 0x003EEC0D
	// (set) Token: 0x060102E5 RID: 66277 RVA: 0x003F0A15 File Offset: 0x003EEC15
	public int MinCount { get; set; }

	// Token: 0x170013C1 RID: 5057
	// (get) Token: 0x060102E6 RID: 66278 RVA: 0x003F0A1E File Offset: 0x003EEC1E
	// (set) Token: 0x060102E7 RID: 66279 RVA: 0x003F0A26 File Offset: 0x003EEC26
	public int Current { get; set; }

	// Token: 0x170013C2 RID: 5058
	// (get) Token: 0x060102E8 RID: 66280 RVA: 0x003F0A2F File Offset: 0x003EEC2F
	// (set) Token: 0x060102E9 RID: 66281 RVA: 0x003F0A37 File Offset: 0x003EEC37
	public bool IsDefaultEnable { get; set; }
}
