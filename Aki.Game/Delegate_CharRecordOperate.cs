using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000315 RID: 789
// (Invoke) Token: 0x060028B4 RID: 10420
[EventRule(EEventName.CharRecordOperate)]
internal delegate void Delegate_CharRecordOperate([Nullable(2)] EntityHandle target, int skillId, IReadOnlyList<ESkillGenre> skillGenres);
