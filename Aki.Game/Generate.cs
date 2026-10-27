using System;

// Token: 0x02000E97 RID: 3735
public class Generate : IGenerate
{
	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x06005B9E RID: 23454 RVA: 0x0010B7E3 File Offset: 0x001099E3
	// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0010B7EB File Offset: 0x001099EB
	public int BornTrack { get; set; }

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x0010B7F4 File Offset: 0x001099F4
	// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0010B7FC File Offset: 0x001099FC
	public float BornDistance { get; set; }

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x0010B805 File Offset: 0x00109A05
	// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x0010B80D File Offset: 0x00109A0D
	public EGenerateType GenerateType { get; set; }

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x0010B816 File Offset: 0x00109A16
	// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x0010B81E File Offset: 0x00109A1E
	public int RefreshId { get; set; }

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x0010B827 File Offset: 0x00109A27
	// (set) Token: 0x06005BA7 RID: 23463 RVA: 0x0010B82F File Offset: 0x00109A2F
	public int BuffGateBornGroup { get; set; }
}
