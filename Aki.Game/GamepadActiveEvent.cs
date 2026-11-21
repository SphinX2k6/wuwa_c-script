using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C1 RID: 5569
[NullableContext(1)]
[Nullable(0)]
public class GamepadActiveEvent : PlayerCommonLogData
{
	// Token: 0x170014BD RID: 5309
	// (get) Token: 0x0600DD6A RID: 56682 RVA: 0x004175D0 File Offset: 0x004157D0
	// (set) Token: 0x0600DD6B RID: 56683 RVA: 0x004175D8 File Offset: 0x004157D8
	public override string event_id { get; set; } = "1050";

	// Token: 0x04007D1F RID: 32031
	public int i_gamepad_count;

	// Token: 0x04007D20 RID: 32032
	public float i_gamepad_time;

	// Token: 0x04007D21 RID: 32033
	public string s_suit_name = "";
}
