using System;
using System.Runtime.CompilerServices;

// Token: 0x02001421 RID: 5153
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleBossComingTipsParam : IPinballBattleBossComingTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000C81 RID: 3201
	// (get) Token: 0x06009146 RID: 37190 RVA: 0x001F2CB4 File Offset: 0x001F0EB4
	// (set) Token: 0x06009147 RID: 37191 RVA: 0x001F2CBC File Offset: 0x001F0EBC
	public int BossTypeId { get; set; }

	// Token: 0x17000C82 RID: 3202
	// (get) Token: 0x06009148 RID: 37192 RVA: 0x001F2CC5 File Offset: 0x001F0EC5
	// (set) Token: 0x06009149 RID: 37193 RVA: 0x001F2CCD File Offset: 0x001F0ECD
	public Action CloseCallback { get; set; }

	// Token: 0x17000C83 RID: 3203
	// (get) Token: 0x0600914A RID: 37194 RVA: 0x001F2CD6 File Offset: 0x001F0ED6
	// (set) Token: 0x0600914B RID: 37195 RVA: 0x001F2CDE File Offset: 0x001F0EDE
	public bool? AddMask { get; set; }

	// Token: 0x17000C84 RID: 3204
	// (get) Token: 0x0600914C RID: 37196 RVA: 0x001F2CE7 File Offset: 0x001F0EE7
	// (set) Token: 0x0600914D RID: 37197 RVA: 0x001F2CEF File Offset: 0x001F0EEF
	public int? CloseTime { get; set; }

	// Token: 0x17000C85 RID: 3205
	// (get) Token: 0x0600914E RID: 37198 RVA: 0x001F2CF8 File Offset: 0x001F0EF8
	// (set) Token: 0x0600914F RID: 37199 RVA: 0x001F2D00 File Offset: 0x001F0F00
	public bool? MoveToBehind { get; set; }
}
