using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003476 RID: 13430
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C")]
public class EffectModelNDC : UEffectModelNDC, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1E1 RID: 119265 RVA: 0x0081DEE0 File Offset: 0x0081C0E0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelNDC._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C");
		}
		return EffectModelNDC._ClassPtr;
	}

	// Token: 0x0601D1E2 RID: 119266 RVA: 0x0081DF04 File Offset: 0x0081C104
	public EffectModelNDC() : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1E3 RID: 119267 RVA: 0x0081DF2C File Offset: 0x0081C12C
	[NullableContext(1)]
	public EffectModelNDC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1E4 RID: 119268 RVA: 0x0081DF5F File Offset: 0x0081C15F
	protected EffectModelNDC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E549 RID: 58697
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C";

	// Token: 0x0400E54A RID: 58698
	private static IntPtr _ClassPtr;

	// Token: 0x0400E54B RID: 58699
	private static IntPtr _ClassDefaultObjectPtr;
}
