using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200346E RID: 13422
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C")]
public class EffectModelBillboard : UEffectModelBillboard, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1C1 RID: 119233 RVA: 0x0081DAA0 File Offset: 0x0081BCA0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelBillboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C");
		}
		return EffectModelBillboard._ClassPtr;
	}

	// Token: 0x0601D1C2 RID: 119234 RVA: 0x0081DAC4 File Offset: 0x0081BCC4
	public EffectModelBillboard() : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1C3 RID: 119235 RVA: 0x0081DAEC File Offset: 0x0081BCEC
	[NullableContext(1)]
	public EffectModelBillboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1C4 RID: 119236 RVA: 0x0081DB1F File Offset: 0x0081BD1F
	protected EffectModelBillboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E531 RID: 58673
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelBillboard.EffectModelBillboard_C";

	// Token: 0x0400E532 RID: 58674
	private static IntPtr _ClassPtr;

	// Token: 0x0400E533 RID: 58675
	private static IntPtr _ClassDefaultObjectPtr;
}
