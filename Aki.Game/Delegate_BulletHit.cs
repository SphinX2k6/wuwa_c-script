using System;
using System.Runtime.CompilerServices;

// Token: 0x020003E6 RID: 998
// (Invoke) Token: 0x06002BF8 RID: 11256
[EventRule(EEventName.BulletHit)]
internal delegate void Delegate_BulletHit(HitInformation hitData, [Nullable(2)] IAttributeSet attackerAttribute);
