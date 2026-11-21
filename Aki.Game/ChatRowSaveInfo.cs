using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C4A RID: 3146
[NullableContext(1)]
[Nullable(0)]
public class ChatRowSaveInfo : IChatRowSaveInfo
{
	// Token: 0x17000EB0 RID: 3760
	// (get) Token: 0x0600836D RID: 33645 RVA: 0x00284D96 File Offset: 0x00282F96
	// (set) Token: 0x0600836E RID: 33646 RVA: 0x00284D9E File Offset: 0x00282F9E
	public ChatContentType ChatContentType { get; set; }

	// Token: 0x17000EB1 RID: 3761
	// (get) Token: 0x0600836F RID: 33647 RVA: 0x00284DA7 File Offset: 0x00282FA7
	// (set) Token: 0x06008370 RID: 33648 RVA: 0x00284DAF File Offset: 0x00282FAF
	public string Content { get; set; }

	// Token: 0x17000EB2 RID: 3762
	// (get) Token: 0x06008371 RID: 33649 RVA: 0x00284DB8 File Offset: 0x00282FB8
	// (set) Token: 0x06008372 RID: 33650 RVA: 0x00284DC0 File Offset: 0x00282FC0
	public string MsgId { get; set; }

	// Token: 0x17000EB3 RID: 3763
	// (get) Token: 0x06008373 RID: 33651 RVA: 0x00284DC9 File Offset: 0x00282FC9
	// (set) Token: 0x06008374 RID: 33652 RVA: 0x00284DD1 File Offset: 0x00282FD1
	public bool OfflineMsg { get; set; }

	// Token: 0x17000EB4 RID: 3764
	// (get) Token: 0x06008375 RID: 33653 RVA: 0x00284DDA File Offset: 0x00282FDA
	// (set) Token: 0x06008376 RID: 33654 RVA: 0x00284DE2 File Offset: 0x00282FE2
	public int SenderUid { get; set; }

	// Token: 0x17000EB5 RID: 3765
	// (get) Token: 0x06008377 RID: 33655 RVA: 0x00284DEB File Offset: 0x00282FEB
	// (set) Token: 0x06008378 RID: 33656 RVA: 0x00284DF3 File Offset: 0x00282FF3
	public long UtcTime { get; set; }
}
