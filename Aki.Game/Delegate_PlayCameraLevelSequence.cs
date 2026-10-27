using System;
using UnrealEngine;

// Token: 0x020007A3 RID: 1955
// (Invoke) Token: 0x06003AEC RID: 15084
[EventRule(EEventName.PlayCameraLevelSequence)]
internal delegate void Delegate_PlayCameraLevelSequence(ULevelSequence levelSequence, AActor role, ALevelSequenceActor sequenceActor, FTransformDouble startTransform, bool playResult, bool isStopModify, string cameraName);
