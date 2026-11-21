using System;
using System.Runtime.CompilerServices;

// Token: 0x0200165E RID: 5726
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolFavorLevelUpLogData : SolarSchoolLogData
{
	// Token: 0x17001551 RID: 5457
	// (get) Token: 0x0600DF2F RID: 57135 RVA: 0x00418F52 File Offset: 0x00417152
	// (set) Token: 0x0600DF30 RID: 57136 RVA: 0x00418F5A File Offset: 0x0041715A
	public override string event_id { get; set; } = "2100";

	// Token: 0x0400800B RID: 32779
	public int i_activity_type;

	// Token: 0x0400800C RID: 32780
	public int i_role_id;

	// Token: 0x0400800D RID: 32781
	public int i_new_level;
}
