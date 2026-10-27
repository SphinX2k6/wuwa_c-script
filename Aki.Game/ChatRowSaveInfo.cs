using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001791 RID: 6033
[NullableContext(1)]
[Nullable(0)]
public class ChatRowSaveInfo : IChatRowSaveInfo
{
	// Token: 0x17000E8D RID: 3725
	// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x0027A912 File Offset: 0x00278B12
	// (set) Token: 0x0600AF86 RID: 44934 RVA: 0x0027A91A File Offset: 0x00278B1A
	public ChatContentType ChatContentType { get; set; }

	// Token: 0x17000E8E RID: 3726
	// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x0027A923 File Offset: 0x00278B23
	// (set) Token: 0x0600AF88 RID: 44936 RVA: 0x0027A92B File Offset: 0x00278B2B
	public string Content { get; set; }

	// Token: 0x17000E8F RID: 3727
	// (get) Token: 0x0600AF89 RID: 44937 RVA: 0x0027A934 File Offset: 0x00278B34
	// (set) Token: 0x0600AF8A RID: 44938 RVA: 0x0027A93C File Offset: 0x00278B3C
	public string MsgId { get; set; }

	// Token: 0x17000E90 RID: 3728
	// (get) Token: 0x0600AF8B RID: 44939 RVA: 0x0027A945 File Offset: 0x00278B45
	// (set) Token: 0x0600AF8C RID: 44940 RVA: 0x0027A94D File Offset: 0x00278B4D
	public bool OfflineMsg { get; set; }

	// Token: 0x17000E91 RID: 3729
	// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x0027A956 File Offset: 0x00278B56
	// (set) Token: 0x0600AF8E RID: 44942 RVA: 0x0027A95E File Offset: 0x00278B5E
	public int SenderUid { get; set; }

	// Token: 0x17000E92 RID: 3730
	// (get) Token: 0x0600AF8F RID: 44943 RVA: 0x0027A967 File Offset: 0x00278B67
	// (set) Token: 0x0600AF90 RID: 44944 RVA: 0x0027A96F File Offset: 0x00278B6F
	public long UtcTime { get; set; }
}
