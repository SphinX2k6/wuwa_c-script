using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001793 RID: 6035
[NullableContext(2)]
[Nullable(0)]
public class ChatHistory : IChatHistory
{
	// Token: 0x17000E9D RID: 3741
	// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x0027A980 File Offset: 0x00278B80
	// (set) Token: 0x0600AFA7 RID: 44967 RVA: 0x0027A988 File Offset: 0x00278B88
	public long? UtcTime { get; set; }

	// Token: 0x17000E9E RID: 3742
	// (get) Token: 0x0600AFA8 RID: 44968 RVA: 0x0027A991 File Offset: 0x00278B91
	// (set) Token: 0x0600AFA9 RID: 44969 RVA: 0x0027A999 File Offset: 0x00278B99
	public string MsgId { get; set; }

	// Token: 0x17000E9F RID: 3743
	// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x0027A9A2 File Offset: 0x00278BA2
	// (set) Token: 0x0600AFAB RID: 44971 RVA: 0x0027A9AA File Offset: 0x00278BAA
	public int? SenderUid { get; set; }

	// Token: 0x17000EA0 RID: 3744
	// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x0027A9B3 File Offset: 0x00278BB3
	// (set) Token: 0x0600AFAD RID: 44973 RVA: 0x0027A9BB File Offset: 0x00278BBB
	public int? SenderPlayerId { get; set; }

	// Token: 0x17000EA1 RID: 3745
	// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x0027A9C4 File Offset: 0x00278BC4
	// (set) Token: 0x0600AFAF RID: 44975 RVA: 0x0027A9CC File Offset: 0x00278BCC
	public string SenderPlayerName { get; set; }

	// Token: 0x17000EA2 RID: 3746
	// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x0027A9D5 File Offset: 0x00278BD5
	// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x0027A9DD File Offset: 0x00278BDD
	public int? SenderIcon { get; set; }

	// Token: 0x17000EA3 RID: 3747
	// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x0027A9E6 File Offset: 0x00278BE6
	// (set) Token: 0x0600AFB3 RID: 44979 RVA: 0x0027A9EE File Offset: 0x00278BEE
	[Nullable(1)]
	public string Content { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000EA4 RID: 3748
	// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x0027A9F7 File Offset: 0x00278BF7
	// (set) Token: 0x0600AFB5 RID: 44981 RVA: 0x0027A9FF File Offset: 0x00278BFF
	public ChatContentType ChatContentType { get; set; }

	// Token: 0x17000EA5 RID: 3749
	// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x0027AA08 File Offset: 0x00278C08
	// (set) Token: 0x0600AFB7 RID: 44983 RVA: 0x0027AA10 File Offset: 0x00278C10
	public ChatChannelNoticeType? NoticeType { get; set; }

	// Token: 0x17000EA6 RID: 3750
	// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x0027AA19 File Offset: 0x00278C19
	// (set) Token: 0x0600AFB9 RID: 44985 RVA: 0x0027AA21 File Offset: 0x00278C21
	public bool? OfflineMsg { get; set; }
}
