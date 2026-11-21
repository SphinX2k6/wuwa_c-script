using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F41 RID: 3905
[NullableContext(1)]
public interface ICdnServerAddress
{
	// Token: 0x1700108B RID: 4235
	// (get) Token: 0x06009C0E RID: 39950
	string GachaDetailServerAddressPrefix { get; }

	// Token: 0x1700108C RID: 4236
	// (get) Token: 0x06009C0F RID: 39951
	string GachaDetailServerId { get; }

	// Token: 0x1700108D RID: 4237
	// (get) Token: 0x06009C10 RID: 39952
	string GachaRecordServerAddressPrefix { get; }

	// Token: 0x1700108E RID: 4238
	// (get) Token: 0x06009C11 RID: 39953
	string GachaRecordServerId { get; }

	// Token: 0x1700108F RID: 4239
	// (get) Token: 0x06009C12 RID: 39954
	string NoticeServerPrefixAddress { get; }

	// Token: 0x17001090 RID: 4240
	// (get) Token: 0x06009C13 RID: 39955
	string MarqueeServerId { get; }

	// Token: 0x17001091 RID: 4241
	// (get) Token: 0x06009C14 RID: 39956
	string GachaInfoServerPrefixAddress { get; }

	// Token: 0x17001092 RID: 4242
	// (get) Token: 0x06009C15 RID: 39957
	string GachaInfoServerId { get; }
}
