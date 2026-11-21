using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E8 RID: 10728
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C")]
public class EffectModelLight : UEffectModelLight, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEE1 RID: 110305 RVA: 0x008450D0 File Offset: 0x008432D0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelLight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C");
		}
		return EffectModelLight._ClassPtr;
	}

	// Token: 0x0601AEE2 RID: 110306 RVA: 0x008450F4 File Offset: 0x008432F4
	public EffectModelLight() : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEE3 RID: 110307 RVA: 0x0084511C File Offset: 0x0084331C
	[NullableContext(1)]
	public EffectModelLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEE4 RID: 110308 RVA: 0x0084514F File Offset: 0x0084334F
	protected EffectModelLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9FB RID: 59899
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelLight.EffectModelLight_C";

	// Token: 0x0400E9FC RID: 59900
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9FD RID: 59901
	private static IntPtr _ClassDefaultObjectPtr;
}
