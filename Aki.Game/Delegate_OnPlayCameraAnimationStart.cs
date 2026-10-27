using System;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;

// Token: 0x02000860 RID: 2144
// (Invoke) Token: 0x06003DE0 RID: 15840
[EventRule(EEventName.OnPlayCameraAnimationStart)]
internal delegate void Delegate_OnPlayCameraAnimationStart(UiCameraHandleData fromHandleData, UiCameraHandleData toHandleData, string blendName);
