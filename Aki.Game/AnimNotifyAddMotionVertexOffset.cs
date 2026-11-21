using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029D0 RID: 10704
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C")]
public class AnimNotifyAddMotionVertexOffset : AnimNotifyAddMaterialControllerData, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AC6B RID: 109675 RVA: 0x00838F90 File Offset: 0x00837190
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyAddMotionVertexOffset) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyAddMotionVertexOffset.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601AC6C RID: 109676 RVA: 0x00839020 File Offset: 0x00837220
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色顶点运动偏移";
	}

	// Token: 0x0601AC6D RID: 109677 RVA: 0x00839027 File Offset: 0x00837227
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMotionVertexOffset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C");
		}
		return AnimNotifyAddMotionVertexOffset._ClassPtr;
	}

	// Token: 0x0601AC6E RID: 109678 RVA: 0x0083904C File Offset: 0x0083724C
	public AnimNotifyAddMotionVertexOffset() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC6F RID: 109679 RVA: 0x00839074 File Offset: 0x00837274
	[NullableContext(1)]
	public AnimNotifyAddMotionVertexOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC70 RID: 109680 RVA: 0x008390A7 File Offset: 0x008372A7
	protected AnimNotifyAddMotionVertexOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC71 RID: 109681 RVA: 0x008390B0 File Offset: 0x008372B0
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E908 RID: 59656
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C";

	// Token: 0x0400E909 RID: 59657
	private static IntPtr _ClassPtr;

	// Token: 0x0400E90A RID: 59658
	private static IntPtr _ClassDefaultObjectPtr;
}
