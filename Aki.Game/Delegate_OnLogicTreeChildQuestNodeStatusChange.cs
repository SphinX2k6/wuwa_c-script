using System;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02000581 RID: 1409
// (Invoke) Token: 0x06003264 RID: 12900
[EventRule(EEventName.OnLogicTreeChildQuestNodeStatusChange)]
internal delegate void Delegate_OnLogicTreeChildQuestNodeStatusChange(GeneralContext contextType, ChildQuestNodeStatus oldStatus, ChildQuestNodeStatus newStatus, ENodeStatusUpdateReason reason);
