using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BF8 RID: 3064
// (Invoke) Token: 0x06004C40 RID: 19520
[EventRule(EEventName.OnTsBasePlayerControllerInputAxis)]
internal delegate void Delegate_OnTsBasePlayerControllerInputAxis([Nullable(2)] TsBasePlayerController playerController, string axisName, float value, bool alwaysTick);
