using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E4 RID: 10724
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C")]
public class EffectModelDecal : UEffectModelDecal, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AED1 RID: 110289 RVA: 0x00844EB0 File Offset: 0x008430B0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelDecal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C");
		}
		return EffectModelDecal._ClassPtr;
	}

	// Token: 0x0601AED2 RID: 110290 RVA: 0x00844ED4 File Offset: 0x008430D4
	public EffectModelDecal() : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AED3 RID: 110291 RVA: 0x00844EFC File Offset: 0x008430FC
	[NullableContext(1)]
	public EffectModelDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AED4 RID: 110292 RVA: 0x00844F2F File Offset: 0x0084312F
	protected EffectModelDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9EF RID: 59887
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C";

	// Token: 0x0400E9F0 RID: 59888
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9F1 RID: 59889
	private static IntPtr _ClassDefaultObjectPtr;
}
