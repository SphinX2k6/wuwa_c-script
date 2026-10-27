using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B36 RID: 6966
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSelectRaceData
{
	// Token: 0x0600CEAA RID: 52906 RVA: 0x002F1630 File Offset: 0x002EF830
	public FloroRanchSelectRaceData(int raceId, FloroRanchSubDungeonData subDungeonData, EFloroRanchActivityDataType activityDataType)
	{
		this.RaceId = raceId;
		this.SubDungeonData = subDungeonData;
		this.ActivityDataType = activityDataType;
	}

	// Token: 0x17001139 RID: 4409
	// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x002F164D File Offset: 0x002EF84D
	// (set) Token: 0x0600CEAC RID: 52908 RVA: 0x002F1655 File Offset: 0x002EF855
	public int RaceId { get; set; }

	// Token: 0x1700113A RID: 4410
	// (get) Token: 0x0600CEAD RID: 52909 RVA: 0x002F165E File Offset: 0x002EF85E
	// (set) Token: 0x0600CEAE RID: 52910 RVA: 0x002F1666 File Offset: 0x002EF866
	public FloroRanchSubDungeonData SubDungeonData { get; set; }

	// Token: 0x1700113B RID: 4411
	// (get) Token: 0x0600CEAF RID: 52911 RVA: 0x002F166F File Offset: 0x002EF86F
	// (set) Token: 0x0600CEB0 RID: 52912 RVA: 0x002F1677 File Offset: 0x002EF877
	public EFloroRanchActivityDataType ActivityDataType { get; set; }
}
