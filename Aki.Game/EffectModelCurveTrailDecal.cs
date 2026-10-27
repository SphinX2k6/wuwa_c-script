using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200346F RID: 13423
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C")]
public class EffectModelCurveTrailDecal : UEffectModelCurveTrailDecal, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1C5 RID: 119237 RVA: 0x0081DB28 File Offset: 0x0081BD28
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelCurveTrailDecal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C");
		}
		return EffectModelCurveTrailDecal._ClassPtr;
	}

	// Token: 0x0601D1C6 RID: 119238 RVA: 0x0081DB4C File Offset: 0x0081BD4C
	public EffectModelCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1C7 RID: 119239 RVA: 0x0081DB74 File Offset: 0x0081BD74
	[NullableContext(1)]
	public EffectModelCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1C8 RID: 119240 RVA: 0x0081DBA7 File Offset: 0x0081BDA7
	protected EffectModelCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E534 RID: 58676
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C";

	// Token: 0x0400E535 RID: 58677
	private static IntPtr _ClassPtr;

	// Token: 0x0400E536 RID: 58678
	private static IntPtr _ClassDefaultObjectPtr;
}
