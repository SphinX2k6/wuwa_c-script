using System;
using CSharpScript.Game.Capability;

// Token: 0x02000234 RID: 564
// (Invoke) Token: 0x06002361 RID: 9057
public delegate T TCapabilityDataCtor<T>(ICapabilityGameObject owner) where T : CapabilityData;
