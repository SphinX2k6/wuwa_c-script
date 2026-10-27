using System;
using System.Runtime.CompilerServices;

// Token: 0x020020EA RID: 8426
[NullableContext(1)]
[Nullable(0)]
public class GamepadActiveEvent : PlayerCommonLogData
{
	// Token: 0x17001490 RID: 5264
	// (get) Token: 0x060108FA RID: 67834 RVA: 0x0040AEC0 File Offset: 0x004090C0
	// (set) Token: 0x060108FB RID: 67835 RVA: 0x0040AEC8 File Offset: 0x004090C8
	public override string event_id { get; set; } = "1050";

	// Token: 0x04007C20 RID: 31776
	public int i_gamepad_count;

	// Token: 0x04007C21 RID: 31777
	public float i_gamepad_time;

	// Token: 0x04007C22 RID: 31778
	public string s_suit_name = "";
}
