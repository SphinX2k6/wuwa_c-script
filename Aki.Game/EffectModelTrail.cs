using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F0 RID: 10736
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C")]
public class EffectModelTrail : UEffectModelTrail, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AF01 RID: 110337 RVA: 0x00845510 File Offset: 0x00843710
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelTrail._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C");
		}
		return EffectModelTrail._ClassPtr;
	}

	// Token: 0x0601AF02 RID: 110338 RVA: 0x00845534 File Offset: 0x00843734
	public EffectModelTrail() : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF03 RID: 110339 RVA: 0x0084555C File Offset: 0x0084375C
	[NullableContext(1)]
	public EffectModelTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF04 RID: 110340 RVA: 0x0084558F File Offset: 0x0084378F
	protected EffectModelTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA13 RID: 59923
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C";

	// Token: 0x0400EA14 RID: 59924
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA15 RID: 59925
	private static IntPtr _ClassDefaultObjectPtr;
}
