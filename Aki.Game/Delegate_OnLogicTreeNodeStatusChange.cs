using System;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02000580 RID: 1408
// (Invoke) Token: 0x06003260 RID: 12896
[EventRule(EEventName.OnLogicTreeNodeStatusChange)]
internal delegate void Delegate_OnLogicTreeNodeStatusChange(GeneralContext contextType, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason);
