using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003472 RID: 13426
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C")]
public class EffectModelGpuParticle : UEffectModelGpuParticle, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1D1 RID: 119249 RVA: 0x0081DCC0 File Offset: 0x0081BEC0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGpuParticle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C");
		}
		return EffectModelGpuParticle._ClassPtr;
	}

	// Token: 0x0601D1D2 RID: 119250 RVA: 0x0081DCE4 File Offset: 0x0081BEE4
	public EffectModelGpuParticle() : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1D3 RID: 119251 RVA: 0x0081DD0C File Offset: 0x0081BF0C
	[NullableContext(1)]
	public EffectModelGpuParticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGpuParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1D4 RID: 119252 RVA: 0x0081DD3F File Offset: 0x0081BF3F
	protected EffectModelGpuParticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E53D RID: 58685
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGpuParticle.EffectModelGpuParticle_C";

	// Token: 0x0400E53E RID: 58686
	private static IntPtr _ClassPtr;

	// Token: 0x0400E53F RID: 58687
	private static IntPtr _ClassDefaultObjectPtr;
}
