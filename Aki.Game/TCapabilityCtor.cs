using System;
using CSharpScript.Game.Capability;

// Token: 0x02000233 RID: 563
// (Invoke) Token: 0x0600235D RID: 9053
public delegate T TCapabilityCtor<T>(ICapabilityGameObject owner) where T : Capability;
