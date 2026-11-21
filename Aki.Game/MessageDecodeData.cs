using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F4D RID: 3917
[NullableContext(1)]
[Nullable(0)]
public class MessageDecodeData : CommonLogData
{
	// Token: 0x17001097 RID: 4247
	// (get) Token: 0x06009CAB RID: 40107 RVA: 0x002E7050 File Offset: 0x002E5250
	// (set) Token: 0x06009CAC RID: 40108 RVA: 0x002E7058 File Offset: 0x002E5258
	public override string event_id { get; set; } = "1022";

	// Token: 0x04005D41 RID: 23873
	public uint i_kcp_conv;

	// Token: 0x04005D42 RID: 23874
	public int i_seq_no;

	// Token: 0x04005D43 RID: 23875
	public int i_message_id;

	// Token: 0x04005D44 RID: 23876
	public int i_crc;

	// Token: 0x04005D45 RID: 23877
	public int i_error_code;

	// Token: 0x04005D46 RID: 23878
	public string s_channel_id = string.Empty;

	// Token: 0x04005D47 RID: 23879
	public string s_client_ip = string.Empty;

	// Token: 0x04005D48 RID: 23880
	public string s_before_hexdump = string.Empty;

	// Token: 0x04005D49 RID: 23881
	public string s_after_hexdump = string.Empty;
}
