using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager
{
	// Token: 0x0200313B RID: 12603
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_CharacterRenderingFunctionLibrary_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFE5 RID: 126949 RVA: 0x00923044 File Offset: 0x00921244
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterRenderingFunctionLibrary_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C");
			}
			return BP_CharacterRenderingFunctionLibrary_C._ClassPtr;
		}

		// Token: 0x0601EFE6 RID: 126950 RVA: 0x00923068 File Offset: 0x00921268
		public BP_CharacterRenderingFunctionLibrary_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRenderingFunctionLibrary_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFE7 RID: 126951 RVA: 0x00923090 File Offset: 0x00921290
		[NullableContext(1)]
		public BP_CharacterRenderingFunctionLibrary_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRenderingFunctionLibrary_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601EFE8 RID: 126952 RVA: 0x009230C4 File Offset: 0x009212C4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetNiagaraSkeletalMeshSimpleNPC(UNiagaraComponent NiagaraComponen, [Nullable(1)] string ParamName, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NiagaraComponen = ((NiagaraComponen != null) ? NiagaraComponen.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ParamName), ParamName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CharacterRenderingFunctionLibrary_C.__SetNiagaraSkeletalMeshSimpleNPC_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EFE9 RID: 126953 RVA: 0x00923154 File Offset: 0x00921354
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerDataGroup_MeshComponent(UMeshComponent meshComponent, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_MeshComponent_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_MeshComponent_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_MeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_MeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->meshComponent = ((meshComponent != null) ? meshComponent.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_MeshComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFEA RID: 126954 RVA: 0x009231CC File Offset: 0x009213CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddDataGroup_MeshComponent(USkeletalMeshComponent MeshComponent, PD_CharacterControllerDataGroup_C Data, UObject __WorldContext, ref float HandleId, ref CharRenderingComponent CharRenderComponent)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComponent = ((MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ref BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_FunctionParams ptr2 = ref *ptr;
			CharRenderingComponent charRenderingComponent = CharRenderComponent;
			ptr2.CharRenderComponent = ((charRenderingComponent != null) ? charRenderingComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_MeshComponent_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
			CharRenderComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<CharRenderingComponent>(ptr->CharRenderComponent);
		}

		// Token: 0x0601EFEB RID: 126955 RVA: 0x0092328C File Offset: 0x0092148C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddMaterialControllerDataForAllCases(AActor Actor, PD_CharacterControllerData_C Data, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__AddMaterialControllerDataForAllCases_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__AddMaterialControllerDataForAllCases_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__AddMaterialControllerDataForAllCases_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__AddMaterialControllerDataForAllCases_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__AddMaterialControllerDataForAllCases_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFEC RID: 126956 RVA: 0x00923314 File Offset: 0x00921514
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetLGUIMPC(UObject __WorldContext, ref UMaterialParameterCollection MPC)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_FunctionParams ptr2 = ref *ptr;
			UMaterialParameterCollection umaterialParameterCollection = MPC;
			ptr2.MPC = ((umaterialParameterCollection != null) ? umaterialParameterCollection.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__GetLGUIMPC_NativeFunctionPtr, (void*)ptr);
			MPC = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialParameterCollection>(ptr->MPC);
		}

		// Token: 0x0601EFED RID: 126957 RVA: 0x00923394 File Offset: 0x00921594
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ApplyWeaponLevelMaterial(USkinnedMeshComponent Mesh, PD_WeaponLevelMaterialDatas_C Data, in int Level, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__ApplyWeaponLevelMaterial_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__ApplyWeaponLevelMaterial_FunctionParams[(UIntPtr)751] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__ApplyWeaponLevelMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__ApplyWeaponLevelMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->Level = Level;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__ApplyWeaponLevelMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFEE RID: 126958 RVA: 0x00923428 File Offset: 0x00921628
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveSimpleHolographicEffect(AActor Target, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFEF RID: 126959 RVA: 0x00923498 File Offset: 0x00921698
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddSimpleHolographicEffect(AActor Target, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF0 RID: 126960 RVA: 0x00923508 File Offset: 0x00921708
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerData_MeshComponent(UMeshComponent MeshComponent, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_MeshComponent_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_MeshComponent_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_MeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_MeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComponent = ((MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_MeshComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF1 RID: 126961 RVA: 0x00923580 File Offset: 0x00921780
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddData_MeshComponent(UMeshComponent MeshComponent, PD_CharacterControllerData_C Data, UObject __WorldContext, ref float HandleId)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_MeshComponent_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_MeshComponent_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_MeshComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_MeshComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComponent = ((MeshComponent != null) ? MeshComponent.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_MeshComponent_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
		}

		// Token: 0x0601EFF2 RID: 126962 RVA: 0x00923618 File Offset: 0x00921818
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetCharacterStarScarValue(TsBaseCharacter Character, float Value, float SectionIndex, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__SetCharacterStarScarValue_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__SetCharacterStarScarValue_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__SetCharacterStarScarValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__SetCharacterStarScarValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->Value = Value;
			ptr->SectionIndex = SectionIndex;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__SetCharacterStarScarValue_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF3 RID: 126963 RVA: 0x00923698 File Offset: 0x00921898
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerDataGroup_BP(TsBaseCharacter Character, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_BP_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_BP_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_BP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_BP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_BP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF4 RID: 126964 RVA: 0x00923710 File Offset: 0x00921910
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddDataGroup_BP(TsBaseCharacter Character, PD_CharacterControllerDataGroup_C Data, UObject __WorldContext, ref float HandleId)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_BP_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_BP_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_BP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_BP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_BP_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
		}

		// Token: 0x0601EFF5 RID: 126965 RVA: 0x009237A8 File Offset: 0x009219A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerData_BP(TsBaseCharacter Character, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_BP_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_BP_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_BP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_BP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_BP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF6 RID: 126966 RVA: 0x00923820 File Offset: 0x00921A20
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerDataGroup(ASkeletalMeshActor SkeletalMesh, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerDataGroup_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFF7 RID: 126967 RVA: 0x00923898 File Offset: 0x00921A98
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddData_BP(TsBaseCharacter Character, PD_CharacterControllerData_C Data, UObject __WorldContext, ref float HandleId)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_BP_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_BP_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_BP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_BP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_BP_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
		}

		// Token: 0x0601EFF8 RID: 126968 RVA: 0x00923930 File Offset: 0x00921B30
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddDataGroup(ASkeletalMeshActor SkeletalMesh, PD_CharacterControllerDataGroup_C Data, UObject __WorldContext, ref float HandleId)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddDataGroup_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
		}

		// Token: 0x0601EFF9 RID: 126969 RVA: 0x009239C8 File Offset: 0x00921BC8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RemoveMaterialControllerData(ASkeletalMeshActor SkeletalMesh, float HandleId, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveMaterialControllerData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EFFA RID: 126970 RVA: 0x00923A40 File Offset: 0x00921C40
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void QuickInitAndAddData(ASkeletalMeshActor SkeletalMesh, PD_CharacterControllerData_C Data, UObject __WorldContext, ref float HandleId)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkeletalMesh = ((SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__QuickInitAndAddData_NativeFunctionPtr, (void*)ptr);
			HandleId = ptr->HandleId;
		}

		// Token: 0x0601EFFB RID: 126971 RVA: 0x00923AD6 File Offset: 0x00921CD6
		protected BP_CharacterRenderingFunctionLibrary_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010824 RID: 67620
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C";

		// Token: 0x04010825 RID: 67621
		private static IntPtr _ClassPtr;

		// Token: 0x04010826 RID: 67622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010827 RID: 67623
		private static IntPtr __SetNiagaraSkeletalMeshSimpleNPC_NativeFunctionPtr;

		// Token: 0x04010828 RID: 67624
		private static IntPtr __RemoveMaterialControllerDataGroup_MeshComponent_NativeFunctionPtr;

		// Token: 0x04010829 RID: 67625
		private static IntPtr __QuickInitAndAddDataGroup_MeshComponent_NativeFunctionPtr;

		// Token: 0x0401082A RID: 67626
		private static IntPtr __AddMaterialControllerDataForAllCases_NativeFunctionPtr;

		// Token: 0x0401082B RID: 67627
		private static IntPtr __GetLGUIMPC_NativeFunctionPtr;

		// Token: 0x0401082C RID: 67628
		private static IntPtr __ApplyWeaponLevelMaterial_NativeFunctionPtr;

		// Token: 0x0401082D RID: 67629
		private static IntPtr __RemoveSimpleHolographicEffect_NativeFunctionPtr;

		// Token: 0x0401082E RID: 67630
		private static IntPtr __AddSimpleHolographicEffect_NativeFunctionPtr;

		// Token: 0x0401082F RID: 67631
		private static IntPtr __RemoveMaterialControllerData_MeshComponent_NativeFunctionPtr;

		// Token: 0x04010830 RID: 67632
		private static IntPtr __QuickInitAndAddData_MeshComponent_NativeFunctionPtr;

		// Token: 0x04010831 RID: 67633
		private static IntPtr __SetCharacterStarScarValue_NativeFunctionPtr;

		// Token: 0x04010832 RID: 67634
		private static IntPtr __RemoveMaterialControllerDataGroup_BP_NativeFunctionPtr;

		// Token: 0x04010833 RID: 67635
		private static IntPtr __QuickInitAndAddDataGroup_BP_NativeFunctionPtr;

		// Token: 0x04010834 RID: 67636
		private static IntPtr __RemoveMaterialControllerData_BP_NativeFunctionPtr;

		// Token: 0x04010835 RID: 67637
		private static IntPtr __RemoveMaterialControllerDataGroup_NativeFunctionPtr;

		// Token: 0x04010836 RID: 67638
		private static IntPtr __QuickInitAndAddData_BP_NativeFunctionPtr;

		// Token: 0x04010837 RID: 67639
		private static IntPtr __QuickInitAndAddDataGroup_NativeFunctionPtr;

		// Token: 0x04010838 RID: 67640
		private static IntPtr __RemoveMaterialControllerData_NativeFunctionPtr;

		// Token: 0x04010839 RID: 67641
		private static IntPtr __QuickInitAndAddData_NativeFunctionPtr;

		// Token: 0x02008EFF RID: 36607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetNiagaraSkeletalMeshSimpleNPC_FunctionParams
		{
			// Token: 0x0402CC00 RID: 183296
			[FieldOffset(0)]
			public IntPtr NiagaraComponen;

			// Token: 0x0402CC01 RID: 183297
			[FieldOffset(8)]
			public FString ParamName;

			// Token: 0x0402CC02 RID: 183298
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F00 RID: 36608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RemoveMaterialControllerDataGroup_MeshComponent_FunctionParams
		{
			// Token: 0x0402CC03 RID: 183299
			[FieldOffset(0)]
			public IntPtr meshComponent;

			// Token: 0x0402CC04 RID: 183300
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC05 RID: 183301
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F01 RID: 36609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __QuickInitAndAddDataGroup_MeshComponent_FunctionParams
		{
			// Token: 0x0402CC06 RID: 183302
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x0402CC07 RID: 183303
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC08 RID: 183304
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC09 RID: 183305
			[FieldOffset(24)]
			public float HandleId;

			// Token: 0x0402CC0A RID: 183306
			[FieldOffset(32)]
			public IntPtr CharRenderComponent;
		}

		// Token: 0x02008F02 RID: 36610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __AddMaterialControllerDataForAllCases_FunctionParams
		{
			// Token: 0x0402CC0B RID: 183307
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0402CC0C RID: 183308
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC0D RID: 183309
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F03 RID: 36611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetLGUIMPC_FunctionParams
		{
			// Token: 0x0402CC0E RID: 183310
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC0F RID: 183311
			[FieldOffset(8)]
			public IntPtr MPC;
		}

		// Token: 0x02008F04 RID: 36612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 736)]
		protected ref struct __ApplyWeaponLevelMaterial_FunctionParams
		{
			// Token: 0x0402CC10 RID: 183312
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x0402CC11 RID: 183313
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC12 RID: 183314
			[FieldOffset(16)]
			public int Level;

			// Token: 0x0402CC13 RID: 183315
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F05 RID: 36613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RemoveSimpleHolographicEffect_FunctionParams
		{
			// Token: 0x0402CC14 RID: 183316
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0402CC15 RID: 183317
			[FieldOffset(8)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F06 RID: 36614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __AddSimpleHolographicEffect_FunctionParams
		{
			// Token: 0x0402CC16 RID: 183318
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0402CC17 RID: 183319
			[FieldOffset(8)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F07 RID: 36615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RemoveMaterialControllerData_MeshComponent_FunctionParams
		{
			// Token: 0x0402CC18 RID: 183320
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x0402CC19 RID: 183321
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC1A RID: 183322
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F08 RID: 36616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __QuickInitAndAddData_MeshComponent_FunctionParams
		{
			// Token: 0x0402CC1B RID: 183323
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x0402CC1C RID: 183324
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC1D RID: 183325
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC1E RID: 183326
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x02008F09 RID: 36617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetCharacterStarScarValue_FunctionParams
		{
			// Token: 0x0402CC1F RID: 183327
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CC20 RID: 183328
			[FieldOffset(8)]
			public float Value;

			// Token: 0x0402CC21 RID: 183329
			[FieldOffset(12)]
			public float SectionIndex;

			// Token: 0x0402CC22 RID: 183330
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F0A RID: 36618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RemoveMaterialControllerDataGroup_BP_FunctionParams
		{
			// Token: 0x0402CC23 RID: 183331
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CC24 RID: 183332
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC25 RID: 183333
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F0B RID: 36619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __QuickInitAndAddDataGroup_BP_FunctionParams
		{
			// Token: 0x0402CC26 RID: 183334
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CC27 RID: 183335
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC28 RID: 183336
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC29 RID: 183337
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x02008F0C RID: 36620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RemoveMaterialControllerData_BP_FunctionParams
		{
			// Token: 0x0402CC2A RID: 183338
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CC2B RID: 183339
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC2C RID: 183340
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F0D RID: 36621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RemoveMaterialControllerDataGroup_FunctionParams
		{
			// Token: 0x0402CC2D RID: 183341
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x0402CC2E RID: 183342
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC2F RID: 183343
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F0E RID: 36622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __QuickInitAndAddData_BP_FunctionParams
		{
			// Token: 0x0402CC30 RID: 183344
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0402CC31 RID: 183345
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC32 RID: 183346
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC33 RID: 183347
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x02008F0F RID: 36623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __QuickInitAndAddDataGroup_FunctionParams
		{
			// Token: 0x0402CC34 RID: 183348
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x0402CC35 RID: 183349
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC36 RID: 183350
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC37 RID: 183351
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x02008F10 RID: 36624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RemoveMaterialControllerData_FunctionParams
		{
			// Token: 0x0402CC38 RID: 183352
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x0402CC39 RID: 183353
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x0402CC3A RID: 183354
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x02008F11 RID: 36625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __QuickInitAndAddData_FunctionParams
		{
			// Token: 0x0402CC3B RID: 183355
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x0402CC3C RID: 183356
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x0402CC3D RID: 183357
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402CC3E RID: 183358
			[FieldOffset(24)]
			public float HandleId;
		}
	}
}
