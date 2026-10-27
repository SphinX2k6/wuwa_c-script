using System;
using UnrealEngine;

// Token: 0x020003E9 RID: 1001
// (Invoke) Token: 0x06002C04 RID: 11268
[EventRule(EEventName.BulletHitAirWall)]
internal delegate void Delegate_BulletHitAirWall(AActor airWall, Vector impactPoint, Vector normal);
