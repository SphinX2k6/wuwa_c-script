using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200345D RID: 13405
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddTransferEffect.AnimNotifyAddTransferEffect_C")]
public class AnimNotifyAddTransferEffect : AnimNotifyAddMaterialControllerData, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601CF73 RID: 118643 RVA: 0x0081277C File Offset: 0x0081097C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601CF74 RID: 118644 RVA: 0x008127F7 File Offset: 0x008109F7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色传送";
	}

	// Token: 0x0601CF75 RID: 118645 RVA: 0x008127FE File Offset: 0x008109FE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddTransferEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddTransferEffect.AnimNotifyAddTransferEffect_C");
		}
		return AnimNotifyAddTransferEffect._ClassPtr;
	}

	// Token: 0x0601CF76 RID: 118646 RVA: 0x00812824 File Offset: 0x00810A24
	public AnimNotifyAddTransferEffect() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF77 RID: 118647 RVA: 0x0081284C File Offset: 0x00810A4C
	[NullableContext(1)]
	public AnimNotifyAddTransferEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddTransferEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF78 RID: 118648 RVA: 0x0081287F File Offset: 0x00810A7F
	protected AnimNotifyAddTransferEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF79 RID: 118649 RVA: 0x00812888 File Offset: 0x00810A88
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E45A RID: 58458
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddTransferEffect.AnimNotifyAddTransferEffect_C";

	// Token: 0x0400E45B RID: 58459
	private static IntPtr _ClassPtr;

	// Token: 0x0400E45C RID: 58460
	private static IntPtr _ClassDefaultObjectPtr;
}
