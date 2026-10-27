using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003479 RID: 13433
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C")]
public class EffectModelSequencePose : UEffectModelSequencePose, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1ED RID: 119277 RVA: 0x0081E078 File Offset: 0x0081C278
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelSequencePose._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C");
		}
		return EffectModelSequencePose._ClassPtr;
	}

	// Token: 0x0601D1EE RID: 119278 RVA: 0x0081E09C File Offset: 0x0081C29C
	public EffectModelSequencePose() : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1EF RID: 119279 RVA: 0x0081E0C4 File Offset: 0x0081C2C4
	[NullableContext(1)]
	public EffectModelSequencePose(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1F0 RID: 119280 RVA: 0x0081E0F7 File Offset: 0x0081C2F7
	protected EffectModelSequencePose(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E552 RID: 58706
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C";

	// Token: 0x0400E553 RID: 58707
	private static IntPtr _ClassPtr;

	// Token: 0x0400E554 RID: 58708
	private static IntPtr _ClassDefaultObjectPtr;
}
