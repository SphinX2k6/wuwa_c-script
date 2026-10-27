using System;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

// Token: 0x020008D7 RID: 2263
// (Invoke) Token: 0x06003FBC RID: 16316
[EventRule(EEventName.TakeMarkComponentEnterContainer)]
internal delegate void Delegate_TakeMarkComponentEnterContainer(UUIItem markComponentRootItem, EMarkType markType, EMarkPriorityType showPriority);
