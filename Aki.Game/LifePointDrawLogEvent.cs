using System;
using System.Runtime.CompilerServices;

// Token: 0x020015EC RID: 5612
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawLogEvent : PlayerCommonLogData
{
	// Token: 0x170014E8 RID: 5352
	// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x00417C54 File Offset: 0x00415E54
	// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x00417C5C File Offset: 0x00415E5C
	public override string event_id { get; set; } = "1704";

	// Token: 0x04007DA9 RID: 32169
	public int i_config_id;

	// Token: 0x04007DAA RID: 32170
	public int i_group_entity_id;

	// Token: 0x04007DAB RID: 32171
	public string s_type_name = "";

	// Token: 0x04007DAC RID: 32172
	public int i_result;

	// Token: 0x04007DAD RID: 32173
	public int i_try_count;
}
