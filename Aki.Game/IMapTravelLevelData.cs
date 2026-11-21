using System;

// Token: 0x02000784 RID: 1924
public interface IMapTravelLevelData
{
	// Token: 0x17000B6D RID: 2925
	// (get) Token: 0x06005856 RID: 22614
	// (set) Token: 0x06005857 RID: 22615
	int Id { get; set; }

	// Token: 0x17000B6E RID: 2926
	// (get) Token: 0x06005858 RID: 22616
	// (set) Token: 0x06005859 RID: 22617
	int Level { get; set; }

	// Token: 0x17000B6F RID: 2927
	// (get) Token: 0x0600585A RID: 22618
	// (set) Token: 0x0600585B RID: 22619
	int AccumulateExp { get; set; }

	// Token: 0x17000B70 RID: 2928
	// (get) Token: 0x0600585C RID: 22620
	// (set) Token: 0x0600585D RID: 22621
	int TargetExp { get; set; }
}
