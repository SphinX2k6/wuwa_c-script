using System;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

// Token: 0x020009F4 RID: 2548
// (Invoke) Token: 0x06004430 RID: 17456
[EventRule(EEventName.OnRolePassPortalBeforeTeleport)]
internal delegate void Delegate_OnRolePassPortalBeforeTeleport(EntityHandle roleHandle, SceneItemPortalComponent inPortalComp, SceneItemPortalComponent outPortalComp);
