using System;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

// Token: 0x020009F5 RID: 2549
// (Invoke) Token: 0x06004434 RID: 17460
[EventRule(EEventName.OnRolePassPortalAfterTeleport)]
internal delegate void Delegate_OnRolePassPortalAfterTeleport(EntityHandle roleHandle, SceneItemPortalComponent inPortalComp, SceneItemPortalComponent outPortalComp);
