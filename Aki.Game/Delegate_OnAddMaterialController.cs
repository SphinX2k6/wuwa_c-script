using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

// Token: 0x0200066B RID: 1643
// (Invoke) Token: 0x0600360C RID: 13836
[EventRule(EEventName.OnAddMaterialController)]
internal delegate void Delegate_OnAddMaterialController(PD_CharacterControllerData_C data, [Nullable(2)] UObject userData, int handle);
