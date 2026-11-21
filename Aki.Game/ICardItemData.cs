using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001510 RID: 5392
[NullableContext(1)]
public interface ICardItemData
{
	// Token: 0x170013F5 RID: 5109
	// (get) Token: 0x0600D7A6 RID: 55206
	// (set) Token: 0x0600D7A7 RID: 55207
	int Id { get; set; }

	// Token: 0x170013F6 RID: 5110
	// (get) Token: 0x0600D7A8 RID: 55208
	// (set) Token: 0x0600D7A9 RID: 55209
	List<ITalkOption> Options { get; set; }

	// Token: 0x170013F7 RID: 5111
	// (get) Token: 0x0600D7AA RID: 55210
	// (set) Token: 0x0600D7AB RID: 55211
	string Tid { get; set; }

	// Token: 0x170013F8 RID: 5112
	// (get) Token: 0x0600D7AC RID: 55212
	// (set) Token: 0x0600D7AD RID: 55213
	int WhoId { get; set; }

	// Token: 0x170013F9 RID: 5113
	// (get) Token: 0x0600D7AE RID: 55214
	// (set) Token: 0x0600D7AF RID: 55215
	string BackGroundConfig { get; set; }
}
