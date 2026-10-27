using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Components;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003979 RID: 14713
[NullableContext(1)]
[Nullable(0)]
public class __CharRenderingComponent_SubClassMissingExportProxy : __CharRenderingComponent_InheritProxy
{
	// Token: 0x0601ED89 RID: 126345 RVA: 0x0089D9FC File Offset: 0x0089BBFC
	protected __CharRenderingComponent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED8A RID: 126346 RVA: 0x0089DA2F File Offset: 0x0089BC2F
	protected __CharRenderingComponent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED8B RID: 126347 RVA: 0x0089DA38 File Offset: 0x0089BC38
	public unsafe override float QuickInitAndAddData(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("QuickInitAndAddData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__QuickInitAndAddData_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__QuickInitAndAddData_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddData_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->meshActor) = ((meshActor != null) ? meshActor.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED8C RID: 126348 RVA: 0x0089DAD8 File Offset: 0x0089BCD8
	public unsafe override float QuickInitAndAddDataWithMeshComponent(UObject data, [Nullable(2)] UMeshComponent meshComponent)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("QuickInitAndAddDataWithMeshComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->meshComponent) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED8D RID: 126349 RVA: 0x0089DB78 File Offset: 0x0089BD78
	public unsafe override float QuickInitAndAddDataGroup(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("QuickInitAndAddDataGroup"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->meshActor) = ((meshActor != null) ? meshActor.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED8E RID: 126350 RVA: 0x0089DC18 File Offset: 0x0089BE18
	public unsafe override float QuickInitAndAddDataGroupWithMeshComponent(UObject data, [Nullable(2)] UMeshComponent meshComponent)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("QuickInitAndAddDataGroupWithMeshComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->meshComponent) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED8F RID: 126351 RVA: 0x0089DCB8 File Offset: 0x0089BEB8
	public unsafe override void Init(ECharacterRenderingType renderType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Init"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__Init_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__Init_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__Init_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->renderType) = (byte)renderType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED90 RID: 126352 RVA: 0x0089DD34 File Offset: 0x0089BF34
	[NullableContext(2)]
	public unsafe override void SetLogicOwner(AActor owner)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetLogicOwner"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetLogicOwner_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetLogicOwner_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetLogicOwner_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->owner) = ((owner != null) ? owner.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED91 RID: 126353 RVA: 0x0089DDBC File Offset: 0x0089BFBC
	public unsafe override void AddComponent(string skelName, UMeshComponent skeletalComp)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddComponent_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
			*(&ptr2->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED92 RID: 126354 RVA: 0x0089DE50 File Offset: 0x0089C050
	public unsafe override void AddComponentWithEmptyMaterial(string skelName, UMeshComponent skeletalComp)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddComponentWithEmptyMaterial"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
			*(&ptr2->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED93 RID: 126355 RVA: 0x0089DEE4 File Offset: 0x0089C0E4
	public unsafe override void RemoveComponent(string skelName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveComponent_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED94 RID: 126356 RVA: 0x0089DF64 File Offset: 0x0089C164
	[NullableContext(2)]
	public unsafe override void AddComponentByCase(ECharacterControllerCaseType caseType, UMeshComponent skeletalComp)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddComponentByCase"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddComponentByCase_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddComponentByCase_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddComponentByCase_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->caseType) = (byte)caseType;
			*(&ptr2->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED95 RID: 126357 RVA: 0x0089DFF4 File Offset: 0x0089C1F4
	public unsafe override void RemoveComponentByCase(ECharacterControllerCaseType caseType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveComponentByCase"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveComponentByCase_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveComponentByCase_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponentByCase_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->caseType) = (byte)caseType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED96 RID: 126358 RVA: 0x0089E070 File Offset: 0x0089C270
	public unsafe override void AddComponentInnerV2(string skelName, UMeshComponent skeletalComp, bool useEmptyMaterial)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddComponentInnerV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddComponentInnerV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddComponentInnerV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddComponentInnerV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
			*(&ptr2->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
			ptr2->useEmptyMaterial = useEmptyMaterial;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED97 RID: 126359 RVA: 0x0089E10C File Offset: 0x0089C30C
	public unsafe override void RemoveComponentInnerV2(string skelName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveComponentInnerV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED98 RID: 126360 RVA: 0x0089E18C File Offset: 0x0089C38C
	[return: Nullable(2)]
	public unsafe override USkeletalMeshComponent GetSkeletalMeshComponent(string skelName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetSkeletalMeshComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->skelName), skelName);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601ED99 RID: 126361 RVA: 0x0089E214 File Offset: 0x0089C414
	public unsafe override FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent skeletalComp)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetSkeletalMeshComponentBodyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		FName _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED9A RID: 126362 RVA: 0x0089E2A0 File Offset: 0x0089C4A0
	public unsafe override bool CheckInit()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CheckInit"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__CheckInit_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__CheckInit_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__CheckInit_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED9B RID: 126363 RVA: 0x0089E318 File Offset: 0x0089C518
	public unsafe override void SetDebug(bool value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDebug"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetDebug_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetDebug_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetDebug_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601ED9C RID: 126364 RVA: 0x0089E390 File Offset: 0x0089C590
	[NullableContext(2)]
	public unsafe override PD_MaterialDebug_C GetDebugInfo()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugInfo"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetDebugInfo_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetDebugInfo_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetDebugInfo_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		PD_MaterialDebug_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<PD_MaterialDebug_C>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601ED9D RID: 126365 RVA: 0x0089E40C File Offset: 0x0089C60C
	public unsafe override bool GetInWater(float depthThreshold)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetInWater"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetInWater_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetInWater_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetInWater_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->depthThreshold = depthThreshold;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED9E RID: 126366 RVA: 0x0089E48C File Offset: 0x0089C68C
	public unsafe override bool GetInAudioShr()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetInAudioShr"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetInAudioShr_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetInAudioShr_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetInAudioShr_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601ED9F RID: 126367 RVA: 0x0089E504 File Offset: 0x0089C704
	public unsafe override void ResetAllRenderingState()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetAllRenderingState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA0 RID: 126368 RVA: 0x0089E574 File Offset: 0x0089C774
	[NullableContext(2)]
	public unsafe override int AddMaterialControllerDataGroup(UObject data)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddMaterialControllerDataGroup"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDA1 RID: 126369 RVA: 0x0089E600 File Offset: 0x0089C800
	[NullableContext(2)]
	public unsafe override float AddMaterialControllerDataGroupWithAnimObject(UObject data, USkeletalMeshComponent animObject)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddMaterialControllerDataGroupWithAnimObject"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->animObject) = ((animObject != null) ? animObject.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDA2 RID: 126370 RVA: 0x0089E6A0 File Offset: 0x0089C8A0
	public unsafe override void RemoveMaterialControllerDataGroup(int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveMaterialControllerDataGroup"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA3 RID: 126371 RVA: 0x0089E718 File Offset: 0x0089C918
	public unsafe override void RemoveMaterialControllerDataGroupWithEnding(int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveMaterialControllerDataGroupWithEnding"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA4 RID: 126372 RVA: 0x0089E790 File Offset: 0x0089C990
	[NullableContext(2)]
	public unsafe override float AddMaterialControllerDataWithAnimObject(UObject data, USkeletalMeshComponent animObject, UObject userData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddMaterialControllerDataWithAnimObject"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
			*(&ptr2->animObject) = ((animObject != null) ? animObject.NativePtr : ((IntPtr)0));
			*(&ptr2->userData) = ((userData != null) ? userData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDA5 RID: 126373 RVA: 0x0089E848 File Offset: 0x0089CA48
	[NullableContext(2)]
	public unsafe override int AddMaterialControllerData(UObject data)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddMaterialControllerData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddMaterialControllerData_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddMaterialControllerData_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerData_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDA6 RID: 126374 RVA: 0x0089E8D4 File Offset: 0x0089CAD4
	public unsafe override void RemoveMaterialControllerData(int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveMaterialControllerData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA7 RID: 126375 RVA: 0x0089E94C File Offset: 0x0089CB4C
	public unsafe override void SetEffectPause(int handle, bool paused)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEffectPause"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetEffectPause_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetEffectPause_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetEffectPause_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
			ptr2->paused = paused;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA8 RID: 126376 RVA: 0x0089E9CC File Offset: 0x0089CBCC
	public unsafe override void RemoveMaterialControllerDataWithEnding(int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveMaterialControllerDataWithEnding"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDA9 RID: 126377 RVA: 0x0089EA44 File Offset: 0x0089CC44
	public unsafe override void SetDitherEffect(float ditherRate, ECharacterDitherType ditherType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetDitherEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetDitherEffect_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetDitherEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->ditherRate = ditherRate;
			*(&ptr2->ditherType) = (byte)ditherType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAA RID: 126378 RVA: 0x0089EAC4 File Offset: 0x0089CCC4
	public unsafe override void SetDisableFightDither(bool disable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDisableFightDither"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetDisableFightDither_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetDisableFightDither_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetDisableFightDither_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->disable = disable;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAB RID: 126379 RVA: 0x0089EB3C File Offset: 0x0089CD3C
	public unsafe override void SetDitherApplyAll()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherApplyAll"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAC RID: 126380 RVA: 0x0089EBAC File Offset: 0x0089CDAC
	public unsafe override void SetDitherApplyHeadsOnly()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherApplyHeadsOnly"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAD RID: 126381 RVA: 0x0089EC1C File Offset: 0x0089CE1C
	public unsafe override void SetDitherUseHeadMaskHideEffect(bool enable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherUseHeadMaskHideEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->enable = enable;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAE RID: 126382 RVA: 0x0089EC94 File Offset: 0x0089CE94
	public unsafe override void TempRemoveDither()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TempRemoveDither"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDAF RID: 126383 RVA: 0x0089ED04 File Offset: 0x0089CF04
	public unsafe override void TempRecoverDither()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TempRecoverDither"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB0 RID: 126384 RVA: 0x0089ED74 File Offset: 0x0089CF74
	public unsafe override float GetOpacityConsiderVisibility()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetOpacityConsiderVisibility"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDB1 RID: 126385 RVA: 0x0089EDEC File Offset: 0x0089CFEC
	public unsafe override void SetMaterialPropertyFloat(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMaterialPropertyFloat"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->bodyType) = (byte)bodyType;
			ptr2->sectionIndex = sectionIndex;
			*(&ptr2->slotType) = (byte)slotType;
			FString.CopyFrom((void*)(&ptr2->propertyName), propertyName);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB2 RID: 126386 RVA: 0x0089EE8C File Offset: 0x0089D08C
	public unsafe override void SetMaterialPropertyColor(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, FLinearColor value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMaterialPropertyColor"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->bodyType) = (byte)bodyType;
			ptr2->sectionIndex = sectionIndex;
			*(&ptr2->slotType) = (byte)slotType;
			FString.CopyFrom((void*)(&ptr2->propertyName), propertyName);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB3 RID: 126387 RVA: 0x0089EF2C File Offset: 0x0089D12C
	public unsafe override void SetMaterialPropertyFloatV2(FName name, float value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMaterialPropertyFloatV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->name = name;
			ptr2->value = value;
			*(&ptr2->bodyType) = (byte)bodyType;
			*(&ptr2->slotType) = (byte)slotType;
			*(&ptr2->meshPart) = (byte)meshPart;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB4 RID: 126388 RVA: 0x0089EFC8 File Offset: 0x0089D1C8
	public unsafe override void AddFloatUpdateParamPermanentByIndexV2(FName name, float value, FName bodyName, float materialIndex)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddFloatUpdateParamPermanentByIndexV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->name = name;
			ptr2->value = value;
			ptr2->bodyName = bodyName;
			ptr2->materialIndex = materialIndex;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB5 RID: 126389 RVA: 0x0089F058 File Offset: 0x0089D258
	public unsafe override void SetMaterialPropertyColorV2(FName name, FLinearColor value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMaterialPropertyColorV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->name = name;
			ptr2->value = value;
			*(&ptr2->bodyType) = (byte)bodyType;
			*(&ptr2->slotType) = (byte)slotType;
			*(&ptr2->meshPart) = (byte)meshPart;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB6 RID: 126390 RVA: 0x0089F0F4 File Offset: 0x0089D2F4
	public unsafe override void SetMaterialReplaceV2(UMaterialInterface material, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMaterialReplaceV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->material) = ((material != null) ? material.NativePtr : ((IntPtr)0));
			*(&ptr2->bodyType) = (byte)bodyType;
			*(&ptr2->slotType) = (byte)slotType;
			*(&ptr2->meshPart) = (byte)meshPart;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB7 RID: 126391 RVA: 0x0089F198 File Offset: 0x0089D398
	public unsafe override void RemoveExternalMaterialReplaceV2(EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveExternalMaterialReplaceV2"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->bodyType) = (byte)bodyType;
			*(&ptr2->slotType) = (byte)slotType;
			*(&ptr2->meshPart) = (byte)meshPart;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB8 RID: 126392 RVA: 0x0089F224 File Offset: 0x0089D424
	public unsafe override void SetStarScarEnergy(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetStarScarEnergy"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetStarScarEnergy_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetStarScarEnergy_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetStarScarEnergy_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDB9 RID: 126393 RVA: 0x0089F29C File Offset: 0x0089D49C
	public unsafe override void SetCapsuleDither(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCapsuleDither"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetCapsuleDither_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetCapsuleDither_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetCapsuleDither_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBA RID: 126394 RVA: 0x0089F314 File Offset: 0x0089D514
	public unsafe override void SetDecalShadowEnabled(bool enable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDecalShadowEnabled"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->enable = enable;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBB RID: 126395 RVA: 0x0089F38C File Offset: 0x0089D58C
	public unsafe override void DisableAllShadowByDecalShadowComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DisableAllShadowByDecalShadowComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBC RID: 126396 RVA: 0x0089F3FC File Offset: 0x0089D5FC
	public unsafe override void SetShouldCastShadow(bool castShadow)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetShouldCastShadow"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetShouldCastShadow_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetShouldCastShadow_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetShouldCastShadow_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->castShadow = castShadow;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBD RID: 126397 RVA: 0x0089F474 File Offset: 0x0089D674
	public unsafe override void SetEffectProgress(float progress, int handleId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEffectProgress"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetEffectProgress_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetEffectProgress_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetEffectProgress_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->progress = progress;
			ptr2->handleId = handleId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBE RID: 126398 RVA: 0x0089F4F4 File Offset: 0x0089D6F4
	public unsafe override void SetEffectGroupProgress(float progress, int groupHandleId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEffectGroupProgress"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__SetEffectGroupProgress_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__SetEffectGroupProgress_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__SetEffectGroupProgress_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->progress = progress;
			ptr2->groupHandleId = groupHandleId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDBF RID: 126399 RVA: 0x0089F574 File Offset: 0x0089D774
	public unsafe override void RefreshMaterialController()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RefreshMaterialController"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDC0 RID: 126400 RVA: 0x0089F5E4 File Offset: 0x0089D7E4
	public unsafe override void Destroy()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Destroy"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDC1 RID: 126401 RVA: 0x0089F654 File Offset: 0x0089D854
	public unsafe override void OnFinalizedLevelSequence()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnFinalizedLevelSequence"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EDC2 RID: 126402 RVA: 0x0089F6C4 File Offset: 0x0089D8C4
	public unsafe override bool ShouldTickAfterGoDown()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ShouldTickAfterGoDown"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EDC3 RID: 126403 RVA: 0x0089F73C File Offset: 0x0089D93C
	public unsafe override void ReceiveSeqTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveSeqTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		CharRenderingComponent.__ReceiveSeqTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((CharRenderingComponent.__ReceiveSeqTick_FunctionParams*)ptr + 15L / (long)sizeof(CharRenderingComponent.__ReceiveSeqTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->deltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
