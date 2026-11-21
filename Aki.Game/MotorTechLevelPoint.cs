using System;
using System.Runtime.CompilerServices;

// Token: 0x02001741 RID: 5953
[NullableContext(2)]
[Nullable(0)]
public class MotorTechLevelPoint : IMotorTechLevelPoint
{
	// Token: 0x17001618 RID: 5656
	// (get) Token: 0x0600E713 RID: 59155 RVA: 0x0043AF3B File Offset: 0x0043913B
	// (set) Token: 0x0600E714 RID: 59156 RVA: 0x0043AF43 File Offset: 0x00439143
	public string Title { get; set; }

	// Token: 0x17001619 RID: 5657
	// (get) Token: 0x0600E715 RID: 59157 RVA: 0x0043AF4C File Offset: 0x0043914C
	// (set) Token: 0x0600E716 RID: 59158 RVA: 0x0043AF54 File Offset: 0x00439154
	public string Desc { get; set; }

	// Token: 0x1700161A RID: 5658
	// (get) Token: 0x0600E717 RID: 59159 RVA: 0x0043AF5D File Offset: 0x0043915D
	// (set) Token: 0x0600E718 RID: 59160 RVA: 0x0043AF65 File Offset: 0x00439165
	public int TargetLevel { get; set; }

	// Token: 0x1700161B RID: 5659
	// (get) Token: 0x0600E719 RID: 59161 RVA: 0x0043AF6E File Offset: 0x0043916E
	// (set) Token: 0x0600E71A RID: 59162 RVA: 0x0043AF76 File Offset: 0x00439176
	public int CurLevel { get; set; }
}
