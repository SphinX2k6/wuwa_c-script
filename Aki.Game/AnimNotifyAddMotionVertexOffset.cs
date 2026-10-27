using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200345C RID: 13404
[UClass("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C")]
public class AnimNotifyAddMotionVertexOffset : AnimNotifyAddMaterialControllerData, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601CF6C RID: 118636 RVA: 0x0081265C File Offset: 0x0081085C
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

	// Token: 0x0601CF6D RID: 118637 RVA: 0x008126D7 File Offset: 0x008108D7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色顶点运动偏移";
	}

	// Token: 0x0601CF6E RID: 118638 RVA: 0x008126DE File Offset: 0x008108DE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyAddMotionVertexOffset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C");
		}
		return AnimNotifyAddMotionVertexOffset._ClassPtr;
	}

	// Token: 0x0601CF6F RID: 118639 RVA: 0x00812704 File Offset: 0x00810904
	public AnimNotifyAddMotionVertexOffset() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF70 RID: 118640 RVA: 0x0081272C File Offset: 0x0081092C
	[NullableContext(1)]
	public AnimNotifyAddMotionVertexOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMotionVertexOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF71 RID: 118641 RVA: 0x0081275F File Offset: 0x0081095F
	protected AnimNotifyAddMotionVertexOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF72 RID: 118642 RVA: 0x00812768 File Offset: 0x00810968
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E457 RID: 58455
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/AnimNotify/AnimNotifyAddMotionVertexOffset.AnimNotifyAddMotionVertexOffset_C";

	// Token: 0x0400E458 RID: 58456
	private static IntPtr _ClassPtr;

	// Token: 0x0400E459 RID: 58457
	private static IntPtr _ClassDefaultObjectPtr;
}
