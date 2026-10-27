using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003474 RID: 13428
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C")]
public class EffectModelLight : UEffectModelLight, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1D9 RID: 119257 RVA: 0x0081DDD0 File Offset: 0x0081BFD0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelLight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C");
		}
		return EffectModelLight._ClassPtr;
	}

	// Token: 0x0601D1DA RID: 119258 RVA: 0x0081DDF4 File Offset: 0x0081BFF4
	public EffectModelLight() : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1DB RID: 119259 RVA: 0x0081DE1C File Offset: 0x0081C01C
	[NullableContext(1)]
	public EffectModelLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1DC RID: 119260 RVA: 0x0081DE4F File Offset: 0x0081C04F
	protected EffectModelLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E543 RID: 58691
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C";

	// Token: 0x0400E544 RID: 58692
	private static IntPtr _ClassPtr;

	// Token: 0x0400E545 RID: 58693
	private static IntPtr _ClassDefaultObjectPtr;
}
