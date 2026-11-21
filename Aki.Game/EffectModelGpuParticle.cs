using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E6 RID: 10726
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C")]
public class EffectModelGpuParticle : UEffectModelGpuParticle, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AED9 RID: 110297 RVA: 0x00844FC0 File Offset: 0x008431C0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGpuParticle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C");
		}
		return EffectModelGpuParticle._ClassPtr;
	}

	// Token: 0x0601AEDA RID: 110298 RVA: 0x00844FE4 File Offset: 0x008431E4
	public EffectModelGpuParticle() : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEDB RID: 110299 RVA: 0x0084500C File Offset: 0x0084320C
	[NullableContext(1)]
	public EffectModelGpuParticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEDC RID: 110300 RVA: 0x0084503F File Offset: 0x0084323F
	protected EffectModelGpuParticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9F5 RID: 59893
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C";

	// Token: 0x0400E9F6 RID: 59894
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9F7 RID: 59895
	private static IntPtr _ClassDefaultObjectPtr;
}
