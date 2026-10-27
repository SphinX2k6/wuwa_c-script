using System;

// Token: 0x0200141A RID: 5146
public interface IBuffView
{
	// Token: 0x17000C6A RID: 3178
	// (get) Token: 0x06009113 RID: 37139
	// (set) Token: 0x06009114 RID: 37140
	int BuffId { get; set; }

	// Token: 0x17000C6B RID: 3179
	// (get) Token: 0x06009115 RID: 37141
	// (set) Token: 0x06009116 RID: 37142
	EPinballBuffType BuffType { get; set; }

	// Token: 0x17000C6C RID: 3180
	// (get) Token: 0x06009117 RID: 37143
	// (set) Token: 0x06009118 RID: 37144
	int BuffCount { get; set; }

	// Token: 0x17000C6D RID: 3181
	// (get) Token: 0x06009119 RID: 37145
	// (set) Token: 0x0600911A RID: 37146
	int Sort { get; set; }
}
