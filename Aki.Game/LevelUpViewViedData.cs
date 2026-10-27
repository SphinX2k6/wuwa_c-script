using System;

// Token: 0x02002068 RID: 8296
public class LevelUpViewViedData : ILevelUpViewViedData
{
	// Token: 0x17001423 RID: 5155
	// (get) Token: 0x06010544 RID: 66884 RVA: 0x003FBFC4 File Offset: 0x003FA1C4
	// (set) Token: 0x06010545 RID: 66885 RVA: 0x003FBFCC File Offset: 0x003FA1CC
	public bool AddExp { get; set; }

	// Token: 0x17001424 RID: 5156
	// (get) Token: 0x06010546 RID: 66886 RVA: 0x003FBFD5 File Offset: 0x003FA1D5
	// (set) Token: 0x06010547 RID: 66887 RVA: 0x003FBFDD File Offset: 0x003FA1DD
	public int PreLevel { get; set; }

	// Token: 0x17001425 RID: 5157
	// (get) Token: 0x06010548 RID: 66888 RVA: 0x003FBFE6 File Offset: 0x003FA1E6
	// (set) Token: 0x06010549 RID: 66889 RVA: 0x003FBFEE File Offset: 0x003FA1EE
	public int PreExp { get; set; }

	// Token: 0x17001426 RID: 5158
	// (get) Token: 0x0601054A RID: 66890 RVA: 0x003FBFF7 File Offset: 0x003FA1F7
	// (set) Token: 0x0601054B RID: 66891 RVA: 0x003FBFFF File Offset: 0x003FA1FF
	public int CurLevel { get; set; }

	// Token: 0x17001427 RID: 5159
	// (get) Token: 0x0601054C RID: 66892 RVA: 0x003FC008 File Offset: 0x003FA208
	// (set) Token: 0x0601054D RID: 66893 RVA: 0x003FC010 File Offset: 0x003FA210
	public int CurExp { get; set; }
}
