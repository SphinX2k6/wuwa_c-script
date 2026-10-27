using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02000372 RID: 882
// (Invoke) Token: 0x06002A28 RID: 10792
[EventRule(EEventName.AddEntity)]
internal delegate void Delegate_AddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor);
