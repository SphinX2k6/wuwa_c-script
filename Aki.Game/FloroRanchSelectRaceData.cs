using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FF5 RID: 4085
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSelectRaceData
{
	// Token: 0x0600A2BB RID: 41659 RVA: 0x002FC710 File Offset: 0x002FA910
	public FloroRanchSelectRaceData(int raceId, FloroRanchSubDungeonData subDungeonData, EFloroRanchActivityDataType activityDataType)
	{
		this.RaceId = raceId;
		this.SubDungeonData = subDungeonData;
		this.ActivityDataType = activityDataType;
	}

	// Token: 0x1700115E RID: 4446
	// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x002FC72D File Offset: 0x002FA92D
	// (set) Token: 0x0600A2BD RID: 41661 RVA: 0x002FC735 File Offset: 0x002FA935
	public int RaceId { get; set; }

	// Token: 0x1700115F RID: 4447
	// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x002FC73E File Offset: 0x002FA93E
	// (set) Token: 0x0600A2BF RID: 41663 RVA: 0x002FC746 File Offset: 0x002FA946
	public FloroRanchSubDungeonData SubDungeonData { get; set; }

	// Token: 0x17001160 RID: 4448
	// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x002FC74F File Offset: 0x002FA94F
	// (set) Token: 0x0600A2C1 RID: 41665 RVA: 0x002FC757 File Offset: 0x002FA957
	public EFloroRanchActivityDataType ActivityDataType { get; set; }
}
