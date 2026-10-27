using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200346D RID: 13421
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C")]
public class EffectModelAudio : UEffectModelAudio, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1BD RID: 119229 RVA: 0x0081DA18 File Offset: 0x0081BC18
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelAudio._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C");
		}
		return EffectModelAudio._ClassPtr;
	}

	// Token: 0x0601D1BE RID: 119230 RVA: 0x0081DA3C File Offset: 0x0081BC3C
	public EffectModelAudio() : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1BF RID: 119231 RVA: 0x0081DA64 File Offset: 0x0081BC64
	[NullableContext(1)]
	public EffectModelAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1C0 RID: 119232 RVA: 0x0081DA97 File Offset: 0x0081BC97
	protected EffectModelAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E52E RID: 58670
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C";

	// Token: 0x0400E52F RID: 58671
	private static IntPtr _ClassPtr;

	// Token: 0x0400E530 RID: 58672
	private static IntPtr _ClassDefaultObjectPtr;
}
