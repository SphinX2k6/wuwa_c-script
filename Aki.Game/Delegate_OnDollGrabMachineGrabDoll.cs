using System;
using System.Collections.Generic;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;

// Token: 0x02000D50 RID: 3408
// (Invoke) Token: 0x060051A0 RID: 20896
[EventRule(EEventName.OnDollGrabMachineGrabDoll)]
internal delegate void Delegate_OnDollGrabMachineGrabDoll(int leaveDollCount, List<IGrabItemData> grabItemDataList);
