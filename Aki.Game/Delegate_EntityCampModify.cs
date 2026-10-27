using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000A78 RID: 2680
// (Invoke) Token: 0x06004640 RID: 17984
[EventRule(EEventName.EntityCampModify)]
internal delegate void Delegate_EntityCampModify(Entity entity, ECamp oldCamp, ECamp newCamp);
