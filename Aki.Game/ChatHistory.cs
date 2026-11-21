using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C4C RID: 3148
[NullableContext(2)]
[Nullable(0)]
public class ChatHistory : IChatHistory
{
	// Token: 0x17000EC0 RID: 3776
	// (get) Token: 0x0600838E RID: 33678 RVA: 0x00284E04 File Offset: 0x00283004
	// (set) Token: 0x0600838F RID: 33679 RVA: 0x00284E0C File Offset: 0x0028300C
	public long? UtcTime { get; set; }

	// Token: 0x17000EC1 RID: 3777
	// (get) Token: 0x06008390 RID: 33680 RVA: 0x00284E15 File Offset: 0x00283015
	// (set) Token: 0x06008391 RID: 33681 RVA: 0x00284E1D File Offset: 0x0028301D
	public string MsgId { get; set; }

	// Token: 0x17000EC2 RID: 3778
	// (get) Token: 0x06008392 RID: 33682 RVA: 0x00284E26 File Offset: 0x00283026
	// (set) Token: 0x06008393 RID: 33683 RVA: 0x00284E2E File Offset: 0x0028302E
	public int? SenderUid { get; set; }

	// Token: 0x17000EC3 RID: 3779
	// (get) Token: 0x06008394 RID: 33684 RVA: 0x00284E37 File Offset: 0x00283037
	// (set) Token: 0x06008395 RID: 33685 RVA: 0x00284E3F File Offset: 0x0028303F
	public int? SenderPlayerId { get; set; }

	// Token: 0x17000EC4 RID: 3780
	// (get) Token: 0x06008396 RID: 33686 RVA: 0x00284E48 File Offset: 0x00283048
	// (set) Token: 0x06008397 RID: 33687 RVA: 0x00284E50 File Offset: 0x00283050
	public string SenderPlayerName { get; set; }

	// Token: 0x17000EC5 RID: 3781
	// (get) Token: 0x06008398 RID: 33688 RVA: 0x00284E59 File Offset: 0x00283059
	// (set) Token: 0x06008399 RID: 33689 RVA: 0x00284E61 File Offset: 0x00283061
	public int? SenderIcon { get; set; }

	// Token: 0x17000EC6 RID: 3782
	// (get) Token: 0x0600839A RID: 33690 RVA: 0x00284E6A File Offset: 0x0028306A
	// (set) Token: 0x0600839B RID: 33691 RVA: 0x00284E72 File Offset: 0x00283072
	[Nullable(1)]
	public string Content { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000EC7 RID: 3783
	// (get) Token: 0x0600839C RID: 33692 RVA: 0x00284E7B File Offset: 0x0028307B
	// (set) Token: 0x0600839D RID: 33693 RVA: 0x00284E83 File Offset: 0x00283083
	public ChatContentType ChatContentType { get; set; }

	// Token: 0x17000EC8 RID: 3784
	// (get) Token: 0x0600839E RID: 33694 RVA: 0x00284E8C File Offset: 0x0028308C
	// (set) Token: 0x0600839F RID: 33695 RVA: 0x00284E94 File Offset: 0x00283094
	public ChatChannelNoticeType? NoticeType { get; set; }

	// Token: 0x17000EC9 RID: 3785
	// (get) Token: 0x060083A0 RID: 33696 RVA: 0x00284E9D File Offset: 0x0028309D
	// (set) Token: 0x060083A1 RID: 33697 RVA: 0x00284EA5 File Offset: 0x002830A5
	public bool? OfflineMsg { get; set; }
}
