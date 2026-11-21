using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E2 RID: 10722
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C")]
public class EffectModelBillboard : UEffectModelBillboard, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEC9 RID: 110281 RVA: 0x00844DA0 File Offset: 0x00842FA0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelBillboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C");
		}
		return EffectModelBillboard._ClassPtr;
	}

	// Token: 0x0601AECA RID: 110282 RVA: 0x00844DC4 File Offset: 0x00842FC4
	public EffectModelBillboard() : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AECB RID: 110283 RVA: 0x00844DEC File Offset: 0x00842FEC
	[NullableContext(1)]
	public EffectModelBillboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AECC RID: 110284 RVA: 0x00844E1F File Offset: 0x0084301F
	protected EffectModelBillboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9E9 RID: 59881
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C";

	// Token: 0x0400E9EA RID: 59882
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9EB RID: 59883
	private static IntPtr _ClassDefaultObjectPtr;
}
