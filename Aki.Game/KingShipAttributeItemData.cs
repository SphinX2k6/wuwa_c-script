using System;

// Token: 0x02001507 RID: 5383
public class KingShipAttributeItemData : IKingShipAttributeItemData
{
	// Token: 0x170013EB RID: 5099
	// (get) Token: 0x0600D748 RID: 55112 RVA: 0x003FCFE3 File Offset: 0x003FB1E3
	// (set) Token: 0x0600D749 RID: 55113 RVA: 0x003FCFEB File Offset: 0x003FB1EB
	public int AttributeId { get; set; }

	// Token: 0x170013EC RID: 5100
	// (get) Token: 0x0600D74A RID: 55114 RVA: 0x003FCFF4 File Offset: 0x003FB1F4
	// (set) Token: 0x0600D74B RID: 55115 RVA: 0x003FCFFC File Offset: 0x003FB1FC
	public int MaxCount { get; set; }

	// Token: 0x170013ED RID: 5101
	// (get) Token: 0x0600D74C RID: 55116 RVA: 0x003FD005 File Offset: 0x003FB205
	// (set) Token: 0x0600D74D RID: 55117 RVA: 0x003FD00D File Offset: 0x003FB20D
	public int MinCount { get; set; }

	// Token: 0x170013EE RID: 5102
	// (get) Token: 0x0600D74E RID: 55118 RVA: 0x003FD016 File Offset: 0x003FB216
	// (set) Token: 0x0600D74F RID: 55119 RVA: 0x003FD01E File Offset: 0x003FB21E
	public int Current { get; set; }

	// Token: 0x170013EF RID: 5103
	// (get) Token: 0x0600D750 RID: 55120 RVA: 0x003FD027 File Offset: 0x003FB227
	// (set) Token: 0x0600D751 RID: 55121 RVA: 0x003FD02F File Offset: 0x003FB22F
	public bool IsDefaultEnable { get; set; }
}
