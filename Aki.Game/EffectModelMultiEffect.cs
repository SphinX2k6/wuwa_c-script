using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F2 RID: 10738
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C")]
public class EffectModelMultiEffect : UEffectModelMultiEffect, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AF0A RID: 110346 RVA: 0x0084565C File Offset: 0x0084385C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelMultiEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C");
		}
		return EffectModelMultiEffect._ClassPtr;
	}

	// Token: 0x0601AF0B RID: 110347 RVA: 0x00845680 File Offset: 0x00843880
	public EffectModelMultiEffect() : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF0C RID: 110348 RVA: 0x008456A8 File Offset: 0x008438A8
	[NullableContext(1)]
	public EffectModelMultiEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF0D RID: 110349 RVA: 0x008456DB File Offset: 0x008438DB
	protected EffectModelMultiEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA1B RID: 59931
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/MultiEffect/EffectModelMultiEffect.EffectModelMultiEffect_C";

	// Token: 0x0400EA1C RID: 59932
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA1D RID: 59933
	private static IntPtr _ClassDefaultObjectPtr;
}
