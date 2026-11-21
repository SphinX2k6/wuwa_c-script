using System;
using System.Runtime.CompilerServices;

// Token: 0x0200161F RID: 5663
[NullableContext(1)]
[Nullable(0)]
public class OnClickShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151A RID: 5402
	// (get) Token: 0x0600DE82 RID: 56962 RVA: 0x004185C3 File Offset: 0x004167C3
	// (set) Token: 0x0600DE83 RID: 56963 RVA: 0x004185CB File Offset: 0x004167CB
	public override string event_id { get; set; } = "1860";

	// Token: 0x04007EB0 RID: 32432
	public int i_id;

	// Token: 0x04007EB1 RID: 32433
	public int i_type;

	// Token: 0x04007EB2 RID: 32434
	public int i_role_id;

	// Token: 0x04007EB3 RID: 32435
	public long l_received_time;

	// Token: 0x04007EB4 RID: 32436
	public int i_config_id;
}
