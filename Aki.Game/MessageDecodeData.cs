using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A8E RID: 6798
[NullableContext(1)]
[Nullable(0)]
public class MessageDecodeData : CommonLogData
{
	// Token: 0x17001072 RID: 4210
	// (get) Token: 0x0600C89A RID: 51354 RVA: 0x002DBECC File Offset: 0x002DA0CC
	// (set) Token: 0x0600C89B RID: 51355 RVA: 0x002DBED4 File Offset: 0x002DA0D4
	public override string event_id { get; set; } = "1022";

	// Token: 0x04005C72 RID: 23666
	public uint i_kcp_conv;

	// Token: 0x04005C73 RID: 23667
	public int i_seq_no;

	// Token: 0x04005C74 RID: 23668
	public int i_message_id;

	// Token: 0x04005C75 RID: 23669
	public int i_crc;

	// Token: 0x04005C76 RID: 23670
	public int i_error_code;

	// Token: 0x04005C77 RID: 23671
	public string s_channel_id = string.Empty;

	// Token: 0x04005C78 RID: 23672
	public string s_client_ip = string.Empty;

	// Token: 0x04005C79 RID: 23673
	public string s_before_hexdump = string.Empty;

	// Token: 0x04005C7A RID: 23674
	public string s_after_hexdump = string.Empty;
}
