using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

// Token: 0x02001D4E RID: 7502
[NullableContext(1)]
[Nullable(0)]
public class StopGamepadShakeImpl : ActionParams, IStopGamepadShake
{
	// Token: 0x1700122A RID: 4650
	// (get) Token: 0x0600E388 RID: 58248 RVA: 0x0035722B File Offset: 0x0035542B
	// (set) Token: 0x0600E389 RID: 58249 RVA: 0x00357233 File Offset: 0x00355433
	public FName Tag { get; set; }

	// Token: 0x1700122B RID: 4651
	// (get) Token: 0x0600E38A RID: 58250 RVA: 0x0035723C File Offset: 0x0035543C
	// (set) Token: 0x0600E38B RID: 58251 RVA: 0x00357244 File Offset: 0x00355444
	public UKuroForceFeedbackEffect GamepadShakeAsset { get; set; }

	// Token: 0x1700122C RID: 4652
	// (get) Token: 0x0600E38C RID: 58252 RVA: 0x0035724D File Offset: 0x0035544D
	// (set) Token: 0x0600E38D RID: 58253 RVA: 0x00357255 File Offset: 0x00355455
	public UForceFeedbackComponent FeedbackComponent { get; set; }
}
