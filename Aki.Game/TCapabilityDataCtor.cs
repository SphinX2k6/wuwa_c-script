using System;
using CSharpScript.Game.Capability;

// Token: 0x02000230 RID: 560
// (Invoke) Token: 0x060022A9 RID: 8873
public delegate T TCapabilityDataCtor<T>(ICapabilityGameObject owner) where T : CapabilityData;
