using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;

// Token: 0x02000BBB RID: 3003
// (Invoke) Token: 0x06004B4C RID: 19276
[EventRule(EEventName.EncircleMapChange)]
internal delegate void Delegate_EncircleMapChange(int mapItemId, IHexPos currentPos, [Nullable(2)] IHexPos oldPos);
