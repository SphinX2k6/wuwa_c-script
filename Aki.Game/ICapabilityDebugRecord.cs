using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

// Token: 0x02000236 RID: 566
[NullableContext(1)]
public interface ICapabilityDebugRecord
{
	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06002369 RID: 9065
	// (set) Token: 0x0600236A RID: 9066
	int Seq { get; set; }

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x0600236B RID: 9067
	// (set) Token: 0x0600236C RID: 9068
	double Time { get; set; }

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x0600236D RID: 9069
	// (set) Token: 0x0600236E RID: 9070
	CapabilityCommonDefine.ECapabilityDebugEvent Event { get; set; }

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x0600236F RID: 9071
	// (set) Token: 0x06002370 RID: 9072
	string CapabilityId { get; set; }

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06002371 RID: 9073
	// (set) Token: 0x06002372 RID: 9074
	string GameObjectId { get; set; }

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06002373 RID: 9075
	// (set) Token: 0x06002374 RID: 9076
	string ClassName { get; set; }

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06002375 RID: 9077
	// (set) Token: 0x06002376 RID: 9078
	[Nullable(2)]
	string Detail { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06002377 RID: 9079
	// (set) Token: 0x06002378 RID: 9080
	double? DurationMs { get; set; }
}
