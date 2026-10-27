using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347E RID: 13438
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C")]
public class EffectModelMultiEffect : UEffectModelMultiEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D202 RID: 119298 RVA: 0x0081E35C File Offset: 0x0081C55C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelMultiEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C");
		}
		return EffectModelMultiEffect._ClassPtr;
	}

	// Token: 0x0601D203 RID: 119299 RVA: 0x0081E380 File Offset: 0x0081C580
	public EffectModelMultiEffect() : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D204 RID: 119300 RVA: 0x0081E3A8 File Offset: 0x0081C5A8
	[NullableContext(1)]
	public EffectModelMultiEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D205 RID: 119301 RVA: 0x0081E3DB File Offset: 0x0081C5DB
	protected EffectModelMultiEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E563 RID: 58723
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C";

	// Token: 0x0400E564 RID: 58724
	private static IntPtr _ClassPtr;

	// Token: 0x0400E565 RID: 58725
	private static IntPtr _ClassDefaultObjectPtr;
}
