using System;
using CSharpScript.Game.Module.WorldMap;

// Token: 0x02000969 RID: 2409
// (Invoke) Token: 0x06004204 RID: 16900
[EventRule(EEventName.WorldMapScaleTierChanged)]
internal delegate void Delegate_WorldMapScaleTierChanged(EWorldMapScaleTier tier, EMapScaleSetType type);
