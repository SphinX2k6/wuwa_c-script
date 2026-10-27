using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000BF7 RID: 3063
// (Invoke) Token: 0x06004C3C RID: 19516
[EventRule(EEventName.OnTsBasePlayerControllerInputAction)]
internal delegate void Delegate_OnTsBasePlayerControllerInputAction([Nullable(2)] TsBasePlayerController playerController, string actionName, bool bPress, FKey key);
