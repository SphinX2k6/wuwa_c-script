using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200203D RID: 8253
[NullableContext(1)]
public interface ICardItemData
{
	// Token: 0x170013C8 RID: 5064
	// (get) Token: 0x0601033E RID: 66366
	// (set) Token: 0x0601033F RID: 66367
	int Id { get; set; }

	// Token: 0x170013C9 RID: 5065
	// (get) Token: 0x06010340 RID: 66368
	// (set) Token: 0x06010341 RID: 66369
	List<ITalkOption> Options { get; set; }

	// Token: 0x170013CA RID: 5066
	// (get) Token: 0x06010342 RID: 66370
	// (set) Token: 0x06010343 RID: 66371
	string Tid { get; set; }

	// Token: 0x170013CB RID: 5067
	// (get) Token: 0x06010344 RID: 66372
	// (set) Token: 0x06010345 RID: 66373
	int WhoId { get; set; }

	// Token: 0x170013CC RID: 5068
	// (get) Token: 0x06010346 RID: 66374
	// (set) Token: 0x06010347 RID: 66375
	string BackGroundConfig { get; set; }
}
