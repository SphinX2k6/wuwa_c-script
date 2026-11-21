using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001511 RID: 5393
[NullableContext(1)]
[Nullable(0)]
public class CardItemData : ICardItemData
{
	// Token: 0x170013FA RID: 5114
	// (get) Token: 0x0600D7B0 RID: 55216 RVA: 0x003FF4D3 File Offset: 0x003FD6D3
	// (set) Token: 0x0600D7B1 RID: 55217 RVA: 0x003FF4DB File Offset: 0x003FD6DB
	public int Id { get; set; }

	// Token: 0x170013FB RID: 5115
	// (get) Token: 0x0600D7B2 RID: 55218 RVA: 0x003FF4E4 File Offset: 0x003FD6E4
	// (set) Token: 0x0600D7B3 RID: 55219 RVA: 0x003FF4EC File Offset: 0x003FD6EC
	public List<ITalkOption> Options { get; set; }

	// Token: 0x170013FC RID: 5116
	// (get) Token: 0x0600D7B4 RID: 55220 RVA: 0x003FF4F5 File Offset: 0x003FD6F5
	// (set) Token: 0x0600D7B5 RID: 55221 RVA: 0x003FF4FD File Offset: 0x003FD6FD
	public string Tid { get; set; }

	// Token: 0x170013FD RID: 5117
	// (get) Token: 0x0600D7B6 RID: 55222 RVA: 0x003FF506 File Offset: 0x003FD706
	// (set) Token: 0x0600D7B7 RID: 55223 RVA: 0x003FF50E File Offset: 0x003FD70E
	public int WhoId { get; set; }

	// Token: 0x170013FE RID: 5118
	// (get) Token: 0x0600D7B8 RID: 55224 RVA: 0x003FF517 File Offset: 0x003FD717
	// (set) Token: 0x0600D7B9 RID: 55225 RVA: 0x003FF51F File Offset: 0x003FD71F
	public string BackGroundConfig { get; set; }
}
