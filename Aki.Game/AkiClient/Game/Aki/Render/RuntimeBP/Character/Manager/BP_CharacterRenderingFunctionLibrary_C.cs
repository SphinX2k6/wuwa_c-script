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
	// Token: 0x02003E27 RID: 15911
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_CharacterRenderingFunctionLibrary_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E0B RID: 163339 RVA: 0x0099D9C7 File Offset: 0x0099BBC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterRenderingFunctionLibrary_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C");
			}
			return BP_CharacterRenderingFunctionLibrary_C._ClassPtr;
		}

		// Token: 0x06027E0C RID: 163340 RVA: 0x0099D9EC File Offset: 0x0099BBEC
		public BP_CharacterRenderingFunctionLibrary_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRenderingFunctionLibrary_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E0D RID: 163341 RVA: 0x0099DA14 File Offset: 0x0099BC14
		[NullableContext(1)]
		public BP_CharacterRenderingFunctionLibrary_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRenderingFunctionLibrary_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027E0E RID: 163342 RVA: 0x0099DA48 File Offset: 0x0099BC48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E0F RID: 163343 RVA: 0x0099DAD8 File Offset: 0x0099BCD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E10 RID: 163344 RVA: 0x0099DB50 File Offset: 0x0099BD50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E11 RID: 163345 RVA: 0x0099DC10 File Offset: 0x0099BE10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E12 RID: 163346 RVA: 0x0099DC98 File Offset: 0x0099BE98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E13 RID: 163347 RVA: 0x0099DD18 File Offset: 0x0099BF18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E14 RID: 163348 RVA: 0x0099DDAC File Offset: 0x0099BFAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetFallbackLevelData(int FirstIndex, PD_WeaponLevelMaterialDatas_C Data, UObject __WorldContext, ref SWeaponLevelMaterialData Value)
		{
			BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FirstIndex = FirstIndex;
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (Value != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponLevelMaterialData.StaticStruct(), &ptr->Value, Value.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_NativeFunctionPtr, (void*)ptr);
			if (Value != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponLevelMaterialData.StaticStruct(), Value.NativePtr, &ptr->Value, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CharacterRenderingFunctionLibrary_C.__GetFallbackLevelData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027E15 RID: 163349 RVA: 0x0099DE80 File Offset: 0x0099C080
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyMaterialParems(SWeaponMaterialParams Params, UMaterialInstanceDynamic Material, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_NativeFunctionPtr, (void*)ptr, 1);
			if (Params != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponMaterialParams.StaticStruct(), &ptr->Params, Params.NativePtr, 1, false);
			}
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CharacterRenderingFunctionLibrary_C.__ApplyMaterialParems_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027E16 RID: 163350 RVA: 0x0099DF24 File Offset: 0x0099C124
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveSimpleHolographicEffect(AActor Target, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__RemoveSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027E17 RID: 163351 RVA: 0x0099DF94 File Offset: 0x0099C194
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddSimpleHolographicEffect(AActor Target, UObject __WorldContext)
		{
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams* ptr = stackalloc BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BP_CharacterRenderingFunctionLibrary_C._ClassDefaultObjectPtr, BP_CharacterRenderingFunctionLibrary_C.__AddSimpleHolographicEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027E18 RID: 163352 RVA: 0x0099E004 File Offset: 0x0099C204
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E19 RID: 163353 RVA: 0x0099E07C File Offset: 0x0099C27C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1A RID: 163354 RVA: 0x0099E114 File Offset: 0x0099C314
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1B RID: 163355 RVA: 0x0099E194 File Offset: 0x0099C394
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1C RID: 163356 RVA: 0x0099E20C File Offset: 0x0099C40C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1D RID: 163357 RVA: 0x0099E2A4 File Offset: 0x0099C4A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1E RID: 163358 RVA: 0x0099E31C File Offset: 0x0099C51C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E1F RID: 163359 RVA: 0x0099E394 File Offset: 0x0099C594
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E20 RID: 163360 RVA: 0x0099E42C File Offset: 0x0099C62C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E21 RID: 163361 RVA: 0x0099E4C4 File Offset: 0x0099C6C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E22 RID: 163362 RVA: 0x0099E53C File Offset: 0x0099C73C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027E23 RID: 163363 RVA: 0x0099E5D2 File Offset: 0x0099C7D2
		protected BP_CharacterRenderingFunctionLibrary_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014398 RID: 82840
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Manager/BP_CharacterRenderingFunctionLibrary.BP_CharacterRenderingFunctionLibrary_C";

		// Token: 0x04014399 RID: 82841
		private static IntPtr _ClassPtr;

		// Token: 0x0401439A RID: 82842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401439B RID: 82843
		private static IntPtr __SetNiagaraSkeletalMeshSimpleNPC_NativeFunctionPtr;

		// Token: 0x0401439C RID: 82844
		private static IntPtr __RemoveMaterialControllerDataGroup_MeshComponent_NativeFunctionPtr;

		// Token: 0x0401439D RID: 82845
		private static IntPtr __QuickInitAndAddDataGroup_MeshComponent_NativeFunctionPtr;

		// Token: 0x0401439E RID: 82846
		private static IntPtr __AddMaterialControllerDataForAllCases_NativeFunctionPtr;

		// Token: 0x0401439F RID: 82847
		private static IntPtr __GetLGUIMPC_NativeFunctionPtr;

		// Token: 0x040143A0 RID: 82848
		private static IntPtr __ApplyWeaponLevelMaterial_NativeFunctionPtr;

		// Token: 0x040143A1 RID: 82849
		private static IntPtr __GetFallbackLevelData_NativeFunctionPtr;

		// Token: 0x040143A2 RID: 82850
		private static IntPtr __ApplyMaterialParems_NativeFunctionPtr;

		// Token: 0x040143A3 RID: 82851
		private static IntPtr __RemoveSimpleHolographicEffect_NativeFunctionPtr;

		// Token: 0x040143A4 RID: 82852
		private static IntPtr __AddSimpleHolographicEffect_NativeFunctionPtr;

		// Token: 0x040143A5 RID: 82853
		private static IntPtr __RemoveMaterialControllerData_MeshComponent_NativeFunctionPtr;

		// Token: 0x040143A6 RID: 82854
		private static IntPtr __QuickInitAndAddData_MeshComponent_NativeFunctionPtr;

		// Token: 0x040143A7 RID: 82855
		private static IntPtr __SetCharacterStarScarValue_NativeFunctionPtr;

		// Token: 0x040143A8 RID: 82856
		private static IntPtr __RemoveMaterialControllerDataGroup_BP_NativeFunctionPtr;

		// Token: 0x040143A9 RID: 82857
		private static IntPtr __QuickInitAndAddDataGroup_BP_NativeFunctionPtr;

		// Token: 0x040143AA RID: 82858
		private static IntPtr __RemoveMaterialControllerData_BP_NativeFunctionPtr;

		// Token: 0x040143AB RID: 82859
		private static IntPtr __RemoveMaterialControllerDataGroup_NativeFunctionPtr;

		// Token: 0x040143AC RID: 82860
		private static IntPtr __QuickInitAndAddData_BP_NativeFunctionPtr;

		// Token: 0x040143AD RID: 82861
		private static IntPtr __QuickInitAndAddDataGroup_NativeFunctionPtr;

		// Token: 0x040143AE RID: 82862
		private static IntPtr __RemoveMaterialControllerData_NativeFunctionPtr;

		// Token: 0x040143AF RID: 82863
		private static IntPtr __QuickInitAndAddData_NativeFunctionPtr;

		// Token: 0x0200A28D RID: 41613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetNiagaraSkeletalMeshSimpleNPC_FunctionParams
		{
			// Token: 0x04031F80 RID: 204672
			[FieldOffset(0)]
			public IntPtr NiagaraComponen;

			// Token: 0x04031F81 RID: 204673
			[FieldOffset(8)]
			public FString ParamName;

			// Token: 0x04031F82 RID: 204674
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A28E RID: 41614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RemoveMaterialControllerDataGroup_MeshComponent_FunctionParams
		{
			// Token: 0x04031F83 RID: 204675
			[FieldOffset(0)]
			public IntPtr meshComponent;

			// Token: 0x04031F84 RID: 204676
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031F85 RID: 204677
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A28F RID: 41615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __QuickInitAndAddDataGroup_MeshComponent_FunctionParams
		{
			// Token: 0x04031F86 RID: 204678
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x04031F87 RID: 204679
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031F88 RID: 204680
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031F89 RID: 204681
			[FieldOffset(24)]
			public float HandleId;

			// Token: 0x04031F8A RID: 204682
			[FieldOffset(32)]
			public IntPtr CharRenderComponent;
		}

		// Token: 0x0200A290 RID: 41616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __AddMaterialControllerDataForAllCases_FunctionParams
		{
			// Token: 0x04031F8B RID: 204683
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04031F8C RID: 204684
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031F8D RID: 204685
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A291 RID: 41617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetLGUIMPC_FunctionParams
		{
			// Token: 0x04031F8E RID: 204686
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04031F8F RID: 204687
			[FieldOffset(8)]
			public IntPtr MPC;
		}

		// Token: 0x0200A292 RID: 41618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 736)]
		protected ref struct __ApplyWeaponLevelMaterial_FunctionParams
		{
			// Token: 0x04031F90 RID: 204688
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031F91 RID: 204689
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031F92 RID: 204690
			[FieldOffset(16)]
			public int Level;

			// Token: 0x04031F93 RID: 204691
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A293 RID: 41619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __GetFallbackLevelData_FunctionParams
		{
			// Token: 0x04031F94 RID: 204692
			[FieldOffset(0)]
			public int FirstIndex;

			// Token: 0x04031F95 RID: 204693
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031F96 RID: 204694
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031F97 RID: 204695
			[FieldOffset(24)]
			public byte Value;
		}

		// Token: 0x0200A294 RID: 41620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __ApplyMaterialParems_FunctionParams
		{
			// Token: 0x04031F98 RID: 204696
			[FieldOffset(0)]
			public byte Params;

			// Token: 0x04031F99 RID: 204697
			[FieldOffset(240)]
			public IntPtr Material;

			// Token: 0x04031F9A RID: 204698
			[FieldOffset(248)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A295 RID: 41621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RemoveSimpleHolographicEffect_FunctionParams
		{
			// Token: 0x04031F9B RID: 204699
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x04031F9C RID: 204700
			[FieldOffset(8)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A296 RID: 41622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __AddSimpleHolographicEffect_FunctionParams
		{
			// Token: 0x04031F9D RID: 204701
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x04031F9E RID: 204702
			[FieldOffset(8)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A297 RID: 41623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RemoveMaterialControllerData_MeshComponent_FunctionParams
		{
			// Token: 0x04031F9F RID: 204703
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x04031FA0 RID: 204704
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031FA1 RID: 204705
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A298 RID: 41624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __QuickInitAndAddData_MeshComponent_FunctionParams
		{
			// Token: 0x04031FA2 RID: 204706
			[FieldOffset(0)]
			public IntPtr MeshComponent;

			// Token: 0x04031FA3 RID: 204707
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031FA4 RID: 204708
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031FA5 RID: 204709
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x0200A299 RID: 41625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetCharacterStarScarValue_FunctionParams
		{
			// Token: 0x04031FA6 RID: 204710
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04031FA7 RID: 204711
			[FieldOffset(8)]
			public float Value;

			// Token: 0x04031FA8 RID: 204712
			[FieldOffset(12)]
			public float SectionIndex;

			// Token: 0x04031FA9 RID: 204713
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A29A RID: 41626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RemoveMaterialControllerDataGroup_BP_FunctionParams
		{
			// Token: 0x04031FAA RID: 204714
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04031FAB RID: 204715
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031FAC RID: 204716
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A29B RID: 41627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __QuickInitAndAddDataGroup_BP_FunctionParams
		{
			// Token: 0x04031FAD RID: 204717
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04031FAE RID: 204718
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031FAF RID: 204719
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031FB0 RID: 204720
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x0200A29C RID: 41628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RemoveMaterialControllerData_BP_FunctionParams
		{
			// Token: 0x04031FB1 RID: 204721
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04031FB2 RID: 204722
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031FB3 RID: 204723
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A29D RID: 41629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RemoveMaterialControllerDataGroup_FunctionParams
		{
			// Token: 0x04031FB4 RID: 204724
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x04031FB5 RID: 204725
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031FB6 RID: 204726
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A29E RID: 41630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __QuickInitAndAddData_BP_FunctionParams
		{
			// Token: 0x04031FB7 RID: 204727
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04031FB8 RID: 204728
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031FB9 RID: 204729
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031FBA RID: 204730
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x0200A29F RID: 41631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __QuickInitAndAddDataGroup_FunctionParams
		{
			// Token: 0x04031FBB RID: 204731
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x04031FBC RID: 204732
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031FBD RID: 204733
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031FBE RID: 204734
			[FieldOffset(24)]
			public float HandleId;
		}

		// Token: 0x0200A2A0 RID: 41632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RemoveMaterialControllerData_FunctionParams
		{
			// Token: 0x04031FBF RID: 204735
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x04031FC0 RID: 204736
			[FieldOffset(8)]
			public float HandleId;

			// Token: 0x04031FC1 RID: 204737
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A2A1 RID: 41633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __QuickInitAndAddData_FunctionParams
		{
			// Token: 0x04031FC2 RID: 204738
			[FieldOffset(0)]
			public IntPtr SkeletalMesh;

			// Token: 0x04031FC3 RID: 204739
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04031FC4 RID: 204740
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031FC5 RID: 204741
			[FieldOffset(24)]
			public float HandleId;
		}
	}
}
