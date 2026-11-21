using System;
using System.Runtime.CompilerServices;

// Token: 0x02001740 RID: 5952
[NullableContext(2)]
public interface IMotorTechLevelPoint
{
	// Token: 0x17001614 RID: 5652
	// (get) Token: 0x0600E70B RID: 59147
	// (set) Token: 0x0600E70C RID: 59148
	string Title { get; set; }

	// Token: 0x17001615 RID: 5653
	// (get) Token: 0x0600E70D RID: 59149
	// (set) Token: 0x0600E70E RID: 59150
	string Desc { get; set; }

	// Token: 0x17001616 RID: 5654
	// (get) Token: 0x0600E70F RID: 59151
	// (set) Token: 0x0600E710 RID: 59152
	int TargetLevel { get; set; }

	// Token: 0x17001617 RID: 5655
	// (get) Token: 0x0600E711 RID: 59153
	// (set) Token: 0x0600E712 RID: 59154
	int CurLevel { get; set; }
}
