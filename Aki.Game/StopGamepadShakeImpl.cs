using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

// Token: 0x02001210 RID: 4624
[NullableContext(1)]
[Nullable(0)]
public class StopGamepadShakeImpl : ActionParams, IStopGamepadShake
{
	// Token: 0x17001254 RID: 4692
	// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x00362C5B File Offset: 0x00360E5B
	// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x00362C63 File Offset: 0x00360E63
	public FName Tag { get; set; }

	// Token: 0x17001255 RID: 4693
	// (get) Token: 0x0600B7A7 RID: 47015 RVA: 0x00362C6C File Offset: 0x00360E6C
	// (set) Token: 0x0600B7A8 RID: 47016 RVA: 0x00362C74 File Offset: 0x00360E74
	public UKuroForceFeedbackEffect GamepadShakeAsset { get; set; }

	// Token: 0x17001256 RID: 4694
	// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x00362C7D File Offset: 0x00360E7D
	// (set) Token: 0x0600B7AA RID: 47018 RVA: 0x00362C85 File Offset: 0x00360E85
	public UForceFeedbackComponent FeedbackComponent { get; set; }
}
