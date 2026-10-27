using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020007A4 RID: 1956
// (Invoke) Token: 0x06003AF0 RID: 15088
[EventRule(EEventName.CameraModeChanged)]
internal delegate void Delegate_CameraModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName);
