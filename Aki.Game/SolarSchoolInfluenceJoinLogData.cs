using System;
using System.Runtime.CompilerServices;

// Token: 0x02001660 RID: 5728
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolInfluenceJoinLogData : SolarSchoolLogData
{
	// Token: 0x17001553 RID: 5459
	// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x00418F9A File Offset: 0x0041719A
	// (set) Token: 0x0600DF36 RID: 57142 RVA: 0x00418FA2 File Offset: 0x004171A2
	public override string event_id { get; set; } = "2102";

	// Token: 0x04008014 RID: 32788
	public int i_activity_type;

	// Token: 0x04008015 RID: 32789
	public int i_status;
}
