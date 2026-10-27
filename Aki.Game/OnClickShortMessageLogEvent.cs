using System;
using System.Runtime.CompilerServices;

// Token: 0x02002147 RID: 8519
[NullableContext(1)]
[Nullable(0)]
public class OnClickShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EC RID: 5356
	// (get) Token: 0x06010A0F RID: 68111 RVA: 0x0040BE7B File Offset: 0x0040A07B
	// (set) Token: 0x06010A10 RID: 68112 RVA: 0x0040BE83 File Offset: 0x0040A083
	public override string event_id { get; set; } = "1860";

	// Token: 0x04007DA0 RID: 32160
	public int i_id;

	// Token: 0x04007DA1 RID: 32161
	public int i_type;

	// Token: 0x04007DA2 RID: 32162
	public int i_role_id;

	// Token: 0x04007DA3 RID: 32163
	public long l_received_time;

	// Token: 0x04007DA4 RID: 32164
	public int i_config_id;
}
