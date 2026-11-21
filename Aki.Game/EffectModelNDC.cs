using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029EA RID: 10730
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C")]
public class EffectModelNDC : UEffectModelNDC, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEE9 RID: 110313 RVA: 0x008451E0 File Offset: 0x008433E0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelNDC._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C");
		}
		return EffectModelNDC._ClassPtr;
	}

	// Token: 0x0601AEEA RID: 110314 RVA: 0x00845204 File Offset: 0x00843404
	public EffectModelNDC() : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEEB RID: 110315 RVA: 0x0084522C File Offset: 0x0084342C
	[NullableContext(1)]
	public EffectModelNDC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEEC RID: 110316 RVA: 0x0084525F File Offset: 0x0084345F
	protected EffectModelNDC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA01 RID: 59905
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C";

	// Token: 0x0400EA02 RID: 59906
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA03 RID: 59907
	private static IntPtr _ClassDefaultObjectPtr;
}
