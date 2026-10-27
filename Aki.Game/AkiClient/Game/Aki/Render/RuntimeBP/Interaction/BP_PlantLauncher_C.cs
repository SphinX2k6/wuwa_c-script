using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1B RID: 15643
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_PlantLauncher_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060258B5 RID: 153781 RVA: 0x0095C92C File Offset: 0x0095AB2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantLauncher_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C");
			}
			return BP_PlantLauncher_C._ClassPtr;
		}

		// Token: 0x060258B6 RID: 153782 RVA: 0x0095C950 File Offset: 0x0095AB50
		public BP_PlantLauncher_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantLauncher_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060258B7 RID: 153783 RVA: 0x0095C978 File Offset: 0x0095AB78
		[NullableContext(1)]
		public BP_PlantLauncher_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantLauncher_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x060258B8 RID: 153784 RVA: 0x0095C9AB File Offset: 0x0095ABAB
		// (set) Token: 0x060258B9 RID: 153785 RVA: 0x0095C9BF File Offset: 0x0095ABBF
		public unsafe UInstancedStaticMeshComponent ISM_Vegetation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x060258BA RID: 153786 RVA: 0x0095C9D4 File Offset: 0x0095ABD4
		// (set) Token: 0x060258BB RID: 153787 RVA: 0x0095C9E8 File Offset: 0x0095ABE8
		public unsafe UInstancedStaticMeshComponent ISM_Reed
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x060258BC RID: 153788 RVA: 0x0095C9FD File Offset: 0x0095ABFD
		// (set) Token: 0x060258BD RID: 153789 RVA: 0x0095CA11 File Offset: 0x0095AC11
		public unsafe UInstancedStaticMeshComponent ISM_Flower
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x060258BE RID: 153790 RVA: 0x0095CA26 File Offset: 0x0095AC26
		// (set) Token: 0x060258BF RID: 153791 RVA: 0x0095CA3A File Offset: 0x0095AC3A
		public unsafe UInstancedStaticMeshComponent ISM_Grass
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x060258C0 RID: 153792 RVA: 0x0095CA4F File Offset: 0x0095AC4F
		// (set) Token: 0x060258C1 RID: 153793 RVA: 0x0095CA63 File Offset: 0x0095AC63
		public unsafe UNiagaraComponent ActivatingEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x060258C2 RID: 153794 RVA: 0x0095CA78 File Offset: 0x0095AC78
		// (set) Token: 0x060258C3 RID: 153795 RVA: 0x0095CA8C File Offset: 0x0095AC8C
		public unsafe UNiagaraComponent projectileniagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x060258C4 RID: 153796 RVA: 0x0095CAA1 File Offset: 0x0095ACA1
		// (set) Token: 0x060258C5 RID: 153797 RVA: 0x0095CAB5 File Offset: 0x0095ACB5
		public unsafe USceneComponent launchpoint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x060258C6 RID: 153798 RVA: 0x0095CACA File Offset: 0x0095ACCA
		// (set) Token: 0x060258C7 RID: 153799 RVA: 0x0095CADE File Offset: 0x0095ACDE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x060258C8 RID: 153800 RVA: 0x0095CAF4 File Offset: 0x0095ACF4
		// (set) Token: 0x060258C9 RID: 153801 RVA: 0x0095CB2D File Offset: 0x0095AD2D
		[Nullable(1)]
		public TArray<FVector> FinalTargetPositions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._FinalTargetPositions) == null)
				{
					result = (this._FinalTargetPositions = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FinalTargetPositions.CopyAssign(value);
			}
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x060258CA RID: 153802 RVA: 0x0095CB3B File Offset: 0x0095AD3B
		// (set) Token: 0x060258CB RID: 153803 RVA: 0x0095CB4F File Offset: 0x0095AD4F
		[Nullable(0)]
		public unsafe TEnumAsByte<EPlantType> currentlaunchertype
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x060258CC RID: 153804 RVA: 0x0095CB64 File Offset: 0x0095AD64
		// (set) Token: 0x060258CD RID: 153805 RVA: 0x0095CB9D File Offset: 0x0095AD9D
		[Nullable(1)]
		public TArray<FVector> testinput
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._testinput) == null)
				{
					result = (this._testinput = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.testinput.CopyAssign(value);
			}
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x060258CE RID: 153806 RVA: 0x0095CBAB File Offset: 0x0095ADAB
		// (set) Token: 0x060258CF RID: 153807 RVA: 0x0095CBBB File Offset: 0x0095ADBB
		public unsafe long InLauncherType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x060258D0 RID: 153808 RVA: 0x0095CBCC File Offset: 0x0095ADCC
		// (set) Token: 0x060258D1 RID: 153809 RVA: 0x0095CBDC File Offset: 0x0095ADDC
		public unsafe float FlyDuring
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x060258D2 RID: 153810 RVA: 0x0095CBF0 File Offset: 0x0095ADF0
		// (set) Token: 0x060258D3 RID: 153811 RVA: 0x0095CC29 File Offset: 0x0095AE29
		[Nullable(1)]
		public RequestEntityPlant RequestEntityPlant
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				RequestEntityPlant result;
				if ((result = this._RequestEntityPlant) == null)
				{
					result = (this._RequestEntityPlant = new RequestEntityPlant(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_14, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x060258D4 RID: 153812 RVA: 0x0095CC4A File Offset: 0x0095AE4A
		// (set) Token: 0x060258D5 RID: 153813 RVA: 0x0095CC5E File Offset: 0x0095AE5E
		public unsafe UNiagaraSystem AppearNS_Big
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x060258D6 RID: 153814 RVA: 0x0095CC73 File Offset: 0x0095AE73
		// (set) Token: 0x060258D7 RID: 153815 RVA: 0x0095CC87 File Offset: 0x0095AE87
		public unsafe UNiagaraSystem AppearNS_Medium
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x060258D8 RID: 153816 RVA: 0x0095CC9C File Offset: 0x0095AE9C
		// (set) Token: 0x060258D9 RID: 153817 RVA: 0x0095CCB0 File Offset: 0x0095AEB0
		public unsafe UNiagaraSystem AppearNS_Small
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x060258DA RID: 153818 RVA: 0x0095CCC8 File Offset: 0x0095AEC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddPlantsToISM(ref TArray<FVector> TargetPositions, UInstancedStaticMeshComponent TargetISM)
		{
			BP_PlantLauncher_C.__AddPlantsToISM_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__AddPlantsToISM_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_PlantLauncher_C.__AddPlantsToISM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__AddPlantsToISM_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = TargetPositions;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetPositions);
			}
			ptr->TargetISM = ((TargetISM != null) ? TargetISM.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__AddPlantsToISM_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = TargetPositions;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetPositions);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__AddPlantsToISM_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DB RID: 153819 RVA: 0x0095CD5C File Offset: 0x0095AF5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GenerateRandomTarget(int count, float Radius, ref TArray<FVector> finalOffsetArray)
		{
			BP_PlantLauncher_C.__GenerateRandomTarget_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__GenerateRandomTarget_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_PlantLauncher_C.__GenerateRandomTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__GenerateRandomTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->count = count;
			ptr->Radius = Radius;
			TArray<FVector> tarray = finalOffsetArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->finalOffsetArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__GenerateRandomTarget_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = finalOffsetArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->finalOffsetArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__GenerateRandomTarget_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DC RID: 153820 RVA: 0x0095CDE2 File Offset: 0x0095AFE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060258DD RID: 153821 RVA: 0x0095CDF6 File Offset: 0x0095AFF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantLauncher_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060258DE RID: 153822 RVA: 0x0095CE0C File Offset: 0x0095B00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RequestLaunch(EPlantType LauncherType, float Radius, int Count, in TArray<FVector> InputTargetPositions, float FlyDuring)
		{
			BP_PlantLauncher_C.__RequestLaunch_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__RequestLaunch_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_PlantLauncher_C.__RequestLaunch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__RequestLaunch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LauncherType = LauncherType;
			ptr->Radius = Radius;
			ptr->Count = Count;
			object obj = InputTargetPositions;
			if (obj != null)
			{
				obj.MoveTo(&ptr->InputTargetPositions);
			}
			ptr->FlyDuring = FlyDuring;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__RequestLaunch_NativeFunctionPtr, (void*)ptr);
			object obj2 = InputTargetPositions;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->InputTargetPositions);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__RequestLaunch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DF RID: 153823 RVA: 0x0095CEA8 File Offset: 0x0095B0A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LaunchNiagaraWithTargets(EPlantType LaunchType)
		{
			BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__LaunchNiagaraWithTargets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LaunchType = LaunchType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__LaunchNiagaraWithTargets_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060258E0 RID: 153824 RVA: 0x0095CEF4 File Offset: 0x0095B0F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SpawnPlantsByType(in TArray<FVector> TargetPositions, EPlantType LauncherType, bool bPlayAppearFX)
		{
			BP_PlantLauncher_C.__SpawnPlantsByType_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__SpawnPlantsByType_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_PlantLauncher_C.__SpawnPlantsByType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__SpawnPlantsByType_NativeFunctionPtr, (void*)ptr, 1);
			object obj = TargetPositions;
			if (obj != null)
			{
				obj.MoveTo(&ptr->TargetPositions);
			}
			ptr->LauncherType = LauncherType;
			ptr->bPlayAppearFX = bPlayAppearFX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__SpawnPlantsByType_NativeFunctionPtr, (void*)ptr);
			object obj2 = TargetPositions;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->TargetPositions);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__SpawnPlantsByType_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258E1 RID: 153825 RVA: 0x0095CF80 File Offset: 0x0095B180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RestorePlants(EPlantType Launcher_Type, float Radius, int Count, in TArray<FVector> input_Target_Positions)
		{
			BP_PlantLauncher_C.__RestorePlants_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__RestorePlants_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PlantLauncher_C.__RestorePlants_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__RestorePlants_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Launcher_Type = Launcher_Type;
			ptr->Radius = Radius;
			ptr->Count = Count;
			object obj = input_Target_Positions;
			if (obj != null)
			{
				obj.MoveTo(&ptr->input_Target_Positions);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__RestorePlants_NativeFunctionPtr, (void*)ptr);
			object obj2 = input_Target_Positions;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->input_Target_Positions);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__RestorePlants_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258E2 RID: 153826 RVA: 0x0095D014 File Offset: 0x0095B214
		protected BP_PlantLauncher_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BD3 RID: 76755
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C";

		// Token: 0x04012BD4 RID: 76756
		private static IntPtr _ClassPtr;

		// Token: 0x04012BD5 RID: 76757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BD6 RID: 76758
		public static IntPtr __RequestEntityPlant__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012BD7 RID: 76759
		internal static int __PropertyOffset_1;

		// Token: 0x04012BD8 RID: 76760
		internal static int __PropertyOffset_2;

		// Token: 0x04012BD9 RID: 76761
		internal static int __PropertyOffset_3;

		// Token: 0x04012BDA RID: 76762
		internal static int __PropertyOffset_4;

		// Token: 0x04012BDB RID: 76763
		internal static int __PropertyOffset_5;

		// Token: 0x04012BDC RID: 76764
		internal static int __PropertyOffset_6;

		// Token: 0x04012BDD RID: 76765
		internal static int __PropertyOffset_7;

		// Token: 0x04012BDE RID: 76766
		internal static int __PropertyOffset_8;

		// Token: 0x04012BDF RID: 76767
		internal static int __PropertyOffset_9;

		// Token: 0x04012BE0 RID: 76768
		private TArray<FVector> _FinalTargetPositions;

		// Token: 0x04012BE1 RID: 76769
		internal static int __PropertyOffset_10;

		// Token: 0x04012BE2 RID: 76770
		internal static int __PropertyOffset_11;

		// Token: 0x04012BE3 RID: 76771
		private TArray<FVector> _testinput;

		// Token: 0x04012BE4 RID: 76772
		internal static int __PropertyOffset_12;

		// Token: 0x04012BE5 RID: 76773
		internal static int __PropertyOffset_13;

		// Token: 0x04012BE6 RID: 76774
		internal static int __PropertyOffset_14;

		// Token: 0x04012BE7 RID: 76775
		private RequestEntityPlant _RequestEntityPlant;

		// Token: 0x04012BE8 RID: 76776
		internal static int __PropertyOffset_15;

		// Token: 0x04012BE9 RID: 76777
		internal static int __PropertyOffset_16;

		// Token: 0x04012BEA RID: 76778
		internal static int __PropertyOffset_17;

		// Token: 0x04012BEB RID: 76779
		private static IntPtr __AddPlantsToISM_NativeFunctionPtr;

		// Token: 0x04012BEC RID: 76780
		private static IntPtr __GenerateRandomTarget_NativeFunctionPtr;

		// Token: 0x04012BED RID: 76781
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012BEE RID: 76782
		private static IntPtr __RequestLaunch_NativeFunctionPtr;

		// Token: 0x04012BEF RID: 76783
		private static IntPtr __LaunchNiagaraWithTargets_NativeFunctionPtr;

		// Token: 0x04012BF0 RID: 76784
		private static IntPtr __SpawnPlantsByType_NativeFunctionPtr;

		// Token: 0x04012BF1 RID: 76785
		private static IntPtr __RestorePlants_NativeFunctionPtr;

		// Token: 0x0200A00D RID: 40973
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __AddPlantsToISM_FunctionParams
		{
			// Token: 0x04031AA8 RID: 203432
			[FieldOffset(0)]
			public byte TargetPositions;

			// Token: 0x04031AA9 RID: 203433
			[FieldOffset(16)]
			public IntPtr TargetISM;
		}

		// Token: 0x0200A00E RID: 40974
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __GenerateRandomTarget_FunctionParams
		{
			// Token: 0x04031AAA RID: 203434
			[FieldOffset(0)]
			public int count;

			// Token: 0x04031AAB RID: 203435
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x04031AAC RID: 203436
			[FieldOffset(8)]
			public byte finalOffsetArray;
		}

		// Token: 0x0200A00F RID: 40975
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RequestLaunch_FunctionParams
		{
			// Token: 0x04031AAD RID: 203437
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x04031AAE RID: 203438
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x04031AAF RID: 203439
			[FieldOffset(8)]
			public int Count;

			// Token: 0x04031AB0 RID: 203440
			[FieldOffset(16)]
			public byte InputTargetPositions;

			// Token: 0x04031AB1 RID: 203441
			[FieldOffset(32)]
			public float FlyDuring;
		}

		// Token: 0x0200A010 RID: 40976
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __LaunchNiagaraWithTargets_FunctionParams
		{
			// Token: 0x04031AB2 RID: 203442
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LaunchType;
		}

		// Token: 0x0200A011 RID: 40977
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SpawnPlantsByType_FunctionParams
		{
			// Token: 0x04031AB3 RID: 203443
			[FieldOffset(0)]
			public byte TargetPositions;

			// Token: 0x04031AB4 RID: 203444
			[FieldOffset(16)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x04031AB5 RID: 203445
			[FieldOffset(17)]
			public bool bPlayAppearFX;
		}

		// Token: 0x0200A012 RID: 40978
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RestorePlants_FunctionParams
		{
			// Token: 0x04031AB6 RID: 203446
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> Launcher_Type;

			// Token: 0x04031AB7 RID: 203447
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x04031AB8 RID: 203448
			[FieldOffset(8)]
			public int Count;

			// Token: 0x04031AB9 RID: 203449
			[FieldOffset(16)]
			public byte input_Target_Positions;
		}
	}
}
