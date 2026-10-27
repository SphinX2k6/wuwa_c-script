using System;
using Aki.Config;

// Token: 0x0200030B RID: 779
// (Invoke) Token: 0x0600288C RID: 10380
[EventRule(EEventName.CharOnBuffAddUIDamage)]
internal delegate void Delegate_CharOnBuffAddUIDamage(int entityId, GameplayCue cue, bool isAdd, int handleId);
