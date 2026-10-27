using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003475 RID: 13429
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C")]
public class EffectModelMaterialController : UEffectModelMaterialController, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1DD RID: 119261 RVA: 0x0081DE58 File Offset: 0x0081C058
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelMaterialController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C");
		}
		return EffectModelMaterialController._ClassPtr;
	}

	// Token: 0x0601D1DE RID: 119262 RVA: 0x0081DE7C File Offset: 0x0081C07C
	public EffectModelMaterialController() : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1DF RID: 119263 RVA: 0x0081DEA4 File Offset: 0x0081C0A4
	[NullableContext(1)]
	public EffectModelMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1E0 RID: 119264 RVA: 0x0081DED7 File Offset: 0x0081C0D7
	protected EffectModelMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E546 RID: 58694
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C";

	// Token: 0x0400E547 RID: 58695
	private static IntPtr _ClassPtr;

	// Token: 0x0400E548 RID: 58696
	private static IntPtr _ClassDefaultObjectPtr;
}
