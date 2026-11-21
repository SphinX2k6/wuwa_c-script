using System;
using System.Runtime.CompilerServices;

// Token: 0x02001621 RID: 5665
[NullableContext(1)]
[Nullable(0)]
public class PhonographPlayLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151C RID: 5404
	// (get) Token: 0x0600DE88 RID: 56968 RVA: 0x00418616 File Offset: 0x00416816
	// (set) Token: 0x0600DE89 RID: 56969 RVA: 0x0041861E File Offset: 0x0041681E
	public override string event_id { get; set; } = "101701";

	// Token: 0x04007EB9 RID: 32441
	public int i_item_id;

	// Token: 0x04007EBA RID: 32442
	public int i_album_id;
}
