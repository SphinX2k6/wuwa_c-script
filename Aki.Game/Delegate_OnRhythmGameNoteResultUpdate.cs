using System;
using UnrealEngine;

// Token: 0x02000D18 RID: 3352
// (Invoke) Token: 0x060050C0 RID: 20672
[EventRule(EEventName.OnRhythmGameNoteResultUpdate)]
internal delegate void Delegate_OnRhythmGameNoteResultUpdate(EKuroRhythmGameRating? result, FKuroRhythmGameStatistics statistics);
