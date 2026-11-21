using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E9 RID: 10729
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C")]
public class EffectModelMaterialController : UEffectModelMaterialController, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEE5 RID: 110309 RVA: 0x00845158 File Offset: 0x00843358
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelMaterialController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C");
		}
		return EffectModelMaterialController._ClassPtr;
	}

	// Token: 0x0601AEE6 RID: 110310 RVA: 0x0084517C File Offset: 0x0084337C
	public EffectModelMaterialController() : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEE7 RID: 110311 RVA: 0x008451A4 File Offset: 0x008433A4
	[NullableContext(1)]
	public EffectModelMaterialController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelMaterialController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEE8 RID: 110312 RVA: 0x008451D7 File Offset: 0x008433D7
	protected EffectModelMaterialController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9FE RID: 59902
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelMaterialController.EffectModelMaterialController_C";

	// Token: 0x0400E9FF RID: 59903
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA00 RID: 59904
	private static IntPtr _ClassDefaultObjectPtr;
}
