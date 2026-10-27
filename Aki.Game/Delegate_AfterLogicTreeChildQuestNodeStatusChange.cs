using System;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02000582 RID: 1410
// (Invoke) Token: 0x06003268 RID: 12904
[EventRule(EEventName.AfterLogicTreeChildQuestNodeStatusChange)]
internal delegate void Delegate_AfterLogicTreeChildQuestNodeStatusChange(GeneralContext contextType, ChildQuestNodeStatus oldStatus, ChildQuestNodeStatus newStatus);
