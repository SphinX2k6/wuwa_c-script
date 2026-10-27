using System;
using UnrealEngine;

// Token: 0x0200092F RID: 2351
// (Invoke) Token: 0x0600411C RID: 16668
[EventRule(EEventName.OnLevelEnvChange)]
internal delegate void Delegate_OnLevelEnvChange(ELevelEnvChangeType type, FVectorDouble? pos, float? range);
