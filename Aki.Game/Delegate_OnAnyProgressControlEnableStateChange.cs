using System;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

// Token: 0x0200087A RID: 2170
// (Invoke) Token: 0x06003E48 RID: 15944
[EventRule(EEventName.OnAnyProgressControlEnableStateChange)]
internal delegate void Delegate_OnAnyProgressControlEnableStateChange(Entity entity, bool isEnable, SceneItemProgressControlComponent.TProgressData progressData);
