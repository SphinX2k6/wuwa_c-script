using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003473 RID: 13427
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C")]
public class EffectModelGroup : UEffectModelGroup, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1D5 RID: 119253 RVA: 0x0081DD48 File Offset: 0x0081BF48
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C");
		}
		return EffectModelGroup._ClassPtr;
	}

	// Token: 0x0601D1D6 RID: 119254 RVA: 0x0081DD6C File Offset: 0x0081BF6C
	public EffectModelGroup() : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1D7 RID: 119255 RVA: 0x0081DD94 File Offset: 0x0081BF94
	[NullableContext(1)]
	public EffectModelGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1D8 RID: 119256 RVA: 0x0081DDC7 File Offset: 0x0081BFC7
	protected EffectModelGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E540 RID: 58688
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C";

	// Token: 0x0400E541 RID: 58689
	private static IntPtr _ClassPtr;

	// Token: 0x0400E542 RID: 58690
	private static IntPtr _ClassDefaultObjectPtr;
}
