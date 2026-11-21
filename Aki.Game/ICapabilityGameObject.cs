using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x02000232 RID: 562
[NullableContext(1)]
public interface ICapabilityGameObject
{
	// Token: 0x0600234E RID: 9038
	string GetId();

	// Token: 0x0600234F RID: 9039
	[NullableContext(2)]
	AActor GetBoundActor();

	// Token: 0x06002350 RID: 9040
	bool IsValid();

	// Token: 0x06002351 RID: 9041
	T AddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x06002352 RID: 9042
	[return: Nullable(2)]
	T GetCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x06002353 RID: 9043
	bool HasCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x06002354 RID: 9044
	T GetOrAddCapabilityData<[Nullable(0)] T>(Type ctor) where T : CapabilityData;

	// Token: 0x06002355 RID: 9045
	T AddCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x06002356 RID: 9046
	bool RemoveCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x06002357 RID: 9047
	IReadOnlyDictionary<Type, Capability> GetCapabilities();

	// Token: 0x06002358 RID: 9048
	[return: Nullable(2)]
	T GetCapability<[Nullable(0)] T>(Type ctor) where T : Capability;

	// Token: 0x06002359 RID: 9049
	void BlockCapabilities(int tag, object instigator);

	// Token: 0x0600235A RID: 9050
	void UnblockCapabilities(int tag, object instigator);

	// Token: 0x0600235B RID: 9051
	bool IsCapabilityState(Capability cap, CapabilityCommonDefine.ECapabilityState state);
}
