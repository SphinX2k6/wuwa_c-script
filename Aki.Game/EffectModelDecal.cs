using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003470 RID: 13424
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C")]
public class EffectModelDecal : UEffectModelDecal, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1C9 RID: 119241 RVA: 0x0081DBB0 File Offset: 0x0081BDB0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelDecal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C");
		}
		return EffectModelDecal._ClassPtr;
	}

	// Token: 0x0601D1CA RID: 119242 RVA: 0x0081DBD4 File Offset: 0x0081BDD4
	public EffectModelDecal() : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1CB RID: 119243 RVA: 0x0081DBFC File Offset: 0x0081BDFC
	[NullableContext(1)]
	public EffectModelDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1CC RID: 119244 RVA: 0x0081DC2F File Offset: 0x0081BE2F
	protected EffectModelDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E537 RID: 58679
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelDecal.EffectModelDecal_C";

	// Token: 0x0400E538 RID: 58680
	private static IntPtr _ClassPtr;

	// Token: 0x0400E539 RID: 58681
	private static IntPtr _ClassDefaultObjectPtr;
}
