using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003471 RID: 13425
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C")]
public class EffectModelGhost : UEffectModelGhost, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1CD RID: 119245 RVA: 0x0081DC38 File Offset: 0x0081BE38
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGhost._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C");
		}
		return EffectModelGhost._ClassPtr;
	}

	// Token: 0x0601D1CE RID: 119246 RVA: 0x0081DC5C File Offset: 0x0081BE5C
	public EffectModelGhost() : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1CF RID: 119247 RVA: 0x0081DC84 File Offset: 0x0081BE84
	[NullableContext(1)]
	public EffectModelGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1D0 RID: 119248 RVA: 0x0081DCB7 File Offset: 0x0081BEB7
	protected EffectModelGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E53A RID: 58682
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C";

	// Token: 0x0400E53B RID: 58683
	private static IntPtr _ClassPtr;

	// Token: 0x0400E53C RID: 58684
	private static IntPtr _ClassDefaultObjectPtr;
}
