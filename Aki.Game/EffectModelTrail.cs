using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347C RID: 13436
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C")]
public class EffectModelTrail : UEffectModelTrail, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1F9 RID: 119289 RVA: 0x0081E210 File Offset: 0x0081C410
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelTrail._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C");
		}
		return EffectModelTrail._ClassPtr;
	}

	// Token: 0x0601D1FA RID: 119290 RVA: 0x0081E234 File Offset: 0x0081C434
	public EffectModelTrail() : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1FB RID: 119291 RVA: 0x0081E25C File Offset: 0x0081C45C
	[NullableContext(1)]
	public EffectModelTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1FC RID: 119292 RVA: 0x0081E28F File Offset: 0x0081C48F
	protected EffectModelTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E55B RID: 58715
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelTrail.EffectModelTrail_C";

	// Token: 0x0400E55C RID: 58716
	private static IntPtr _ClassPtr;

	// Token: 0x0400E55D RID: 58717
	private static IntPtr _ClassDefaultObjectPtr;
}
