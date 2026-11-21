using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E1 RID: 10721
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C")]
public class EffectModelAudio : UEffectModelAudio, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEC5 RID: 110277 RVA: 0x00844D18 File Offset: 0x00842F18
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelAudio._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C");
		}
		return EffectModelAudio._ClassPtr;
	}

	// Token: 0x0601AEC6 RID: 110278 RVA: 0x00844D3C File Offset: 0x00842F3C
	public EffectModelAudio() : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEC7 RID: 110279 RVA: 0x00844D64 File Offset: 0x00842F64
	[NullableContext(1)]
	public EffectModelAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEC8 RID: 110280 RVA: 0x00844D97 File Offset: 0x00842F97
	protected EffectModelAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9E6 RID: 59878
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelAudio.EffectModelAudio_C";

	// Token: 0x0400E9E7 RID: 59879
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9E8 RID: 59880
	private static IntPtr _ClassDefaultObjectPtr;
}
