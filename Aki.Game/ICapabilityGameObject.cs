using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x0200022E RID: 558
[NullableContext(1)]
public interface ICapabilityGameObject
{
	// Token: 0x06002296 RID: 8854
	string GetId();

	// Token: 0x06002297 RID: 8855
	[NullableContext(2)]
	AActor GetBoundActor();

	// Token: 0x06002298 RID: 8856
	bool IsValid();

	// Token: 0x06002299 RID: 8857
	T AddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x0600229A RID: 8858
	[return: Nullable(2)]
	T GetCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x0600229B RID: 8859
	bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x0600229C RID: 8860
	T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x0600229D RID: 8861
	T AddCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x0600229E RID: 8862
	bool RemoveCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x0600229F RID: 8863
	IReadOnlyDictionary<Type, Capability> GetCapabilities();

	// Token: 0x060022A0 RID: 8864
	[return: Nullable(2)]
	T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x060022A1 RID: 8865
	void BlockCapabilities(int tag, object instigator);

	// Token: 0x060022A2 RID: 8866
	void UnblockCapabilities(int tag, object instigator);

	// Token: 0x060022A3 RID: 8867
	bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state);
}
