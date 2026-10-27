using System;
using CSharpScript.Game.Capability;

// Token: 0x0200022F RID: 559
// (Invoke) Token: 0x060022A5 RID: 8869
public delegate T TCapabilityCtor<T>(ICapabilityGameObject owner) where T : Capability;
