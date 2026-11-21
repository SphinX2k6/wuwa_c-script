using System;
using System.Runtime.CompilerServices;

// Token: 0x02001622 RID: 5666
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMusicPlayLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151D RID: 5405
	// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x0041863A File Offset: 0x0041683A
	// (set) Token: 0x0600DE8C RID: 56972 RVA: 0x00418642 File Offset: 0x00416842
	public override string event_id { get; set; } = "101702";

	// Token: 0x04007EBC RID: 32444
	public int i_item_id;

	// Token: 0x04007EBD RID: 32445
	public int i_album_id;
}
