using System;
using System.Runtime.CompilerServices;

// Token: 0x0200214A RID: 8522
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicPlayLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EF RID: 5359
	// (get) Token: 0x06010A18 RID: 68120 RVA: 0x0040BEF2 File Offset: 0x0040A0F2
	// (set) Token: 0x06010A19 RID: 68121 RVA: 0x0040BEFA File Offset: 0x0040A0FA
	public override string event_id { get; set; } = "101702";

	// Token: 0x04007DAC RID: 32172
	public int i_item_id;

	// Token: 0x04007DAD RID: 32173
	public int i_album_id;
}
