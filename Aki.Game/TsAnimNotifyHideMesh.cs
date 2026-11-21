using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C2 RID: 450
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C")]
public class TsAnimNotifyHideMesh : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00095E77 File Offset: 0x00094077
	// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00095E8B File Offset: 0x0009408B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ChildMeshName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_ChildMeshName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_ChildMeshName)), value);
		}
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00095EA0 File Offset: 0x000940A0
	// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00095EB0 File Offset: 0x000940B0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildren
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildren) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildren) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00095EC1 File Offset: 0x000940C1
	// (set) Token: 0x06001C99 RID: 7321 RVA: 0x00095ED1 File Offset: 0x000940D1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildrenActors
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildrenActors) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildrenActors) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00095EE2 File Offset: 0x000940E2
	// (set) Token: 0x06001C9B RID: 7323 RVA: 0x00095EF2 File Offset: 0x000940F2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x00095F04 File Offset: 0x00094104
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyHideMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyHideMesh.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x00095FBC File Offset: 0x000941BC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		UMeshComponent umeshComponent = null;
		if (string.IsNullOrEmpty(this.ChildMeshName))
		{
			umeshComponent = meshComp;
		}
		else
		{
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(UMeshComponent.StaticClass());
			for (int i = tarray.Num() - 1; i >= 0; i--)
			{
				UMeshComponent umeshComponent2 = tarray.Get(i) as UMeshComponent;
				if (((umeshComponent2 != null) ? umeshComponent2.GetName() : null) == this.ChildMeshName)
				{
					umeshComponent = umeshComponent2;
					break;
				}
			}
		}
		if (umeshComponent == null)
		{
			return false;
		}
		umeshComponent.SetHiddenInGame(this.Hide, this.HideChildren);
		return true;
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x00096054 File Offset: 0x00094254
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyHideMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyHideMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C9F RID: 7327 RVA: 0x000960E4 File Offset: 0x000942E4
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏网格体";
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x000960EB File Offset: 0x000942EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyHideMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C");
		}
		return TsAnimNotifyHideMesh._ClassPtr;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00096110 File Offset: 0x00094310
	public TsAnimNotifyHideMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00096138 File Offset: 0x00094338
	public TsAnimNotifyHideMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x0009616B File Offset: 0x0009436B
	protected TsAnimNotifyHideMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x00096174 File Offset: 0x00094374
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x000961A7 File Offset: 0x000943A7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011FE RID: 4606
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C";

	// Token: 0x040011FF RID: 4607
	private static IntPtr _ClassPtr;

	// Token: 0x04001200 RID: 4608
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001201 RID: 4609
	private static int __PropertyOffset_ChildMeshName;

	// Token: 0x04001202 RID: 4610
	private static int __PropertyOffset_HideChildren;

	// Token: 0x04001203 RID: 4611
	private static int __PropertyOffset_HideChildrenActors;

	// Token: 0x04001204 RID: 4612
	private static int __PropertyOffset_Hide;
}
