using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E3 RID: 10723
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C")]
public class EffectModelCurveTrailDecal : UEffectModelCurveTrailDecal, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AECD RID: 110285 RVA: 0x00844E28 File Offset: 0x00843028
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelCurveTrailDecal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C");
		}
		return EffectModelCurveTrailDecal._ClassPtr;
	}

	// Token: 0x0601AECE RID: 110286 RVA: 0x00844E4C File Offset: 0x0084304C
	public EffectModelCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AECF RID: 110287 RVA: 0x00844E74 File Offset: 0x00843074
	[NullableContext(1)]
	public EffectModelCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AED0 RID: 110288 RVA: 0x00844EA7 File Offset: 0x008430A7
	protected EffectModelCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9EC RID: 59884
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelCurveTrailDecal.EffectModelCurveTrailDecal_C";

	// Token: 0x0400E9ED RID: 59885
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9EE RID: 59886
	private static IntPtr _ClassDefaultObjectPtr;
}
