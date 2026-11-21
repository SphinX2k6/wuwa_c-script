using System;
using System.Runtime.CompilerServices;

// Token: 0x020018E4 RID: 6372
[NullableContext(1)]
[Nullable(0)]
public class MainSkillInfoData : IMainSkillInfoData
{
	// Token: 0x17001811 RID: 6161
	// (get) Token: 0x0600FBAB RID: 64427 RVA: 0x00499E29 File Offset: 0x00498029
	// (set) Token: 0x0600FBAC RID: 64428 RVA: 0x00499E31 File Offset: 0x00498031
	public string MainSkillText { get; set; }

	// Token: 0x17001812 RID: 6162
	// (get) Token: 0x0600FBAD RID: 64429 RVA: 0x00499E3A File Offset: 0x0049803A
	// (set) Token: 0x0600FBAE RID: 64430 RVA: 0x00499E42 File Offset: 0x00498042
	public string[] MainSkillParameter { get; set; }

	// Token: 0x17001813 RID: 6163
	// (get) Token: 0x0600FBAF RID: 64431 RVA: 0x00499E4B File Offset: 0x0049804B
	// (set) Token: 0x0600FBB0 RID: 64432 RVA: 0x00499E53 File Offset: 0x00498053
	public string MainSkillIcon { get; set; }
}
