using System;
using System.Runtime.CompilerServices;

// Token: 0x020019F5 RID: 6645
[NullableContext(2)]
[Nullable(0)]
public class ChatPartnerTabItemData
{
	// Token: 0x060105FB RID: 67067 RVA: 0x004C85E6 File Offset: 0x004C67E6
	public ChatPartnerTabItemData(int chatPartnerId)
	{
		this.ChatPartnerId = chatPartnerId;
	}

	// Token: 0x04009120 RID: 37152
	public int ChatPartnerId;

	// Token: 0x04009121 RID: 37153
	public Action<int> OnClickPartner;

	// Token: 0x04009122 RID: 37154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, TogChatTalkItem> OnClickChatItem;

	// Token: 0x04009123 RID: 37155
	public Func<int, bool> IsExpandedProvider;

	// Token: 0x04009124 RID: 37156
	public Func<int, bool> IsSelectedPartnerProvider;

	// Token: 0x04009125 RID: 37157
	public Func<int> SelectedShortMsgIdProvider;
}
