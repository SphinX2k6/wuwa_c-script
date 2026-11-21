using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E5 RID: 10725
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C")]
public class EffectModelGhost : UEffectModelGhost, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AED5 RID: 110293 RVA: 0x00844F38 File Offset: 0x00843138
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGhost._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C");
		}
		return EffectModelGhost._ClassPtr;
	}

	// Token: 0x0601AED6 RID: 110294 RVA: 0x00844F5C File Offset: 0x0084315C
	public EffectModelGhost() : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AED7 RID: 110295 RVA: 0x00844F84 File Offset: 0x00843184
	[NullableContext(1)]
	public EffectModelGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AED8 RID: 110296 RVA: 0x00844FB7 File Offset: 0x008431B7
	protected EffectModelGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9F2 RID: 59890
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGhost.EffectModelGhost_C";

	// Token: 0x0400E9F3 RID: 59891
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9F4 RID: 59892
	private static IntPtr _ClassDefaultObjectPtr;
}
