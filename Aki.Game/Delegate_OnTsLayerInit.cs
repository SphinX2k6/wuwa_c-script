using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C08 RID: 3080
// (Invoke) Token: 0x06004C80 RID: 19584
[EventRule(EEventName.OnTsLayerInit)]
internal delegate void Delegate_OnTsLayerInit(IReadOnlyList<AActor> actorList, IReadOnlyList<UUIItem> itemList, IReadOnlyDictionary<ELayerType, List<UUIItem>> floatUnitMap, UUIItem pureBattleFloatUnitItem);
