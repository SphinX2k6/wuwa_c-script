using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F2 RID: 12530
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_PlantLauncher_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E6E9 RID: 124649 RVA: 0x00913BBB File Offset: 0x00911DBB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantLauncher_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C");
			}
			return BP_PlantLauncher_C._ClassPtr;
		}

		// Token: 0x0601E6EA RID: 124650 RVA: 0x00913BE0 File Offset: 0x00911DE0
		public BP_PlantLauncher_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantLauncher_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E6EB RID: 124651 RVA: 0x00913C08 File Offset: 0x00911E08
		[NullableContext(1)]
		public BP_PlantLauncher_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantLauncher_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0601E6EC RID: 124652 RVA: 0x00913C3B File Offset: 0x00911E3B
		// (set) Token: 0x0601E6ED RID: 124653 RVA: 0x00913C4F File Offset: 0x00911E4F
		public unsafe UNiagaraComponent ActivatingEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_ActivatingEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_ActivatingEffect, value);
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0601E6EE RID: 124654 RVA: 0x00913C64 File Offset: 0x00911E64
		// (set) Token: 0x0601E6EF RID: 124655 RVA: 0x00913C78 File Offset: 0x00911E78
		public unsafe UNiagaraComponent projectileniagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_projectileniagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_projectileniagara, value);
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0601E6F0 RID: 124656 RVA: 0x00913C8D File Offset: 0x00911E8D
		// (set) Token: 0x0601E6F1 RID: 124657 RVA: 0x00913CA1 File Offset: 0x00911EA1
		public unsafe USceneComponent launchpoint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_launchpoint);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_launchpoint, value);
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0601E6F2 RID: 124658 RVA: 0x00913CB6 File Offset: 0x00911EB6
		// (set) Token: 0x0601E6F3 RID: 124659 RVA: 0x00913CCA File Offset: 0x00911ECA
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0601E6F4 RID: 124660 RVA: 0x00913CE0 File Offset: 0x00911EE0
		// (set) Token: 0x0601E6F5 RID: 124661 RVA: 0x00913D19 File Offset: 0x00911F19
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
					result = (this._FinalTargetPositions = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_FinalTargetPositions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FinalTargetPositions.CopyAssign(value);
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0601E6F6 RID: 124662 RVA: 0x00913D27 File Offset: 0x00911F27
		// (set) Token: 0x0601E6F7 RID: 124663 RVA: 0x00913D3B File Offset: 0x00911F3B
		[Nullable(0)]
		public unsafe TEnumAsByte<EPlantType> currentlaunchertype
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_currentlaunchertype);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_currentlaunchertype) = value;
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0601E6F8 RID: 124664 RVA: 0x00913D50 File Offset: 0x00911F50
		// (set) Token: 0x0601E6F9 RID: 124665 RVA: 0x00913D89 File Offset: 0x00911F89
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
					result = (this._testinput = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_testinput, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.testinput.CopyAssign(value);
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0601E6FA RID: 124666 RVA: 0x00913D97 File Offset: 0x00911F97
		// (set) Token: 0x0601E6FB RID: 124667 RVA: 0x00913DA7 File Offset: 0x00911FA7
		public unsafe long InLauncherType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_InLauncherType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_InLauncherType) = value;
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0601E6FC RID: 124668 RVA: 0x00913DB8 File Offset: 0x00911FB8
		// (set) Token: 0x0601E6FD RID: 124669 RVA: 0x00913DC8 File Offset: 0x00911FC8
		public unsafe float FlyDuring
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_FlyDuring);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_FlyDuring) = value;
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0601E6FE RID: 124670 RVA: 0x00913DDC File Offset: 0x00911FDC
		// (set) Token: 0x0601E6FF RID: 124671 RVA: 0x00913E15 File Offset: 0x00912015
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
					result = (this._RequestEntityPlant = new RequestEntityPlant(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_RequestEntityPlant, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_PlantLauncher_C.__PropertyOffset_RequestEntityPlant, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0601E700 RID: 124672 RVA: 0x00913E36 File Offset: 0x00912036
		// (set) Token: 0x0601E701 RID: 124673 RVA: 0x00913E4A File Offset: 0x0091204A
		public unsafe UNiagaraSystem AppearNS_Big
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Big);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Big, value);
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0601E702 RID: 124674 RVA: 0x00913E5F File Offset: 0x0091205F
		// (set) Token: 0x0601E703 RID: 124675 RVA: 0x00913E73 File Offset: 0x00912073
		public unsafe UNiagaraSystem AppearNS_Medium
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Medium);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Medium, value);
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0601E704 RID: 124676 RVA: 0x00913E88 File Offset: 0x00912088
		// (set) Token: 0x0601E705 RID: 124677 RVA: 0x00913E9C File Offset: 0x0091209C
		public unsafe UNiagaraSystem AppearNS_Small
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Small);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantLauncher_C.__PropertyOffset_AppearNS_Small, value);
			}
		}

		// Token: 0x0601E706 RID: 124678 RVA: 0x00913EB4 File Offset: 0x009120B4
		[SkipLocalsInit]
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

		// Token: 0x0601E707 RID: 124679 RVA: 0x00913F3A File Offset: 0x0091213A
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E708 RID: 124680 RVA: 0x00913F4E File Offset: 0x0091214E
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantLauncher_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E709 RID: 124681 RVA: 0x00913F64 File Offset: 0x00912164
		[SkipLocalsInit]
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

		// Token: 0x0601E70A RID: 124682 RVA: 0x00914000 File Offset: 0x00912200
		[SkipLocalsInit]
		public unsafe virtual void LaunchNiagaraWithTargets(EPlantType LaunchType)
		{
			BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams* ptr = stackalloc BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_PlantLauncher_C.__LaunchNiagaraWithTargets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantLauncher_C.__LaunchNiagaraWithTargets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LaunchType = LaunchType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantLauncher_C.__LaunchNiagaraWithTargets_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E70B RID: 124683 RVA: 0x0091404C File Offset: 0x0091224C
		[SkipLocalsInit]
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

		// Token: 0x0601E70C RID: 124684 RVA: 0x009140D8 File Offset: 0x009122D8
		[SkipLocalsInit]
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

		// Token: 0x0601E70D RID: 124685 RVA: 0x0091416C File Offset: 0x0091236C
		protected BP_PlantLauncher_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101DF RID: 66015
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C";

		// Token: 0x040101E0 RID: 66016
		private static IntPtr _ClassPtr;

		// Token: 0x040101E1 RID: 66017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101E2 RID: 66018
		public static IntPtr __RequestEntityPlant__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040101E3 RID: 66019
		internal static int __PropertyOffset_ActivatingEffect;

		// Token: 0x040101E4 RID: 66020
		internal static int __PropertyOffset_projectileniagara;

		// Token: 0x040101E5 RID: 66021
		internal static int __PropertyOffset_launchpoint;

		// Token: 0x040101E6 RID: 66022
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040101E7 RID: 66023
		internal static int __PropertyOffset_FinalTargetPositions;

		// Token: 0x040101E8 RID: 66024
		private TArray<FVector> _FinalTargetPositions;

		// Token: 0x040101E9 RID: 66025
		internal static int __PropertyOffset_currentlaunchertype;

		// Token: 0x040101EA RID: 66026
		internal static int __PropertyOffset_testinput;

		// Token: 0x040101EB RID: 66027
		private TArray<FVector> _testinput;

		// Token: 0x040101EC RID: 66028
		internal static int __PropertyOffset_InLauncherType;

		// Token: 0x040101ED RID: 66029
		internal static int __PropertyOffset_FlyDuring;

		// Token: 0x040101EE RID: 66030
		internal static int __PropertyOffset_RequestEntityPlant;

		// Token: 0x040101EF RID: 66031
		private RequestEntityPlant _RequestEntityPlant;

		// Token: 0x040101F0 RID: 66032
		internal static int __PropertyOffset_AppearNS_Big;

		// Token: 0x040101F1 RID: 66033
		internal static int __PropertyOffset_AppearNS_Medium;

		// Token: 0x040101F2 RID: 66034
		internal static int __PropertyOffset_AppearNS_Small;

		// Token: 0x040101F3 RID: 66035
		private static IntPtr __GenerateRandomTarget_NativeFunctionPtr;

		// Token: 0x040101F4 RID: 66036
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040101F5 RID: 66037
		private static IntPtr __RequestLaunch_NativeFunctionPtr;

		// Token: 0x040101F6 RID: 66038
		private static IntPtr __LaunchNiagaraWithTargets_NativeFunctionPtr;

		// Token: 0x040101F7 RID: 66039
		private static IntPtr __SpawnPlantsByType_NativeFunctionPtr;

		// Token: 0x040101F8 RID: 66040
		private static IntPtr __RestorePlants_NativeFunctionPtr;

		// Token: 0x02008E7A RID: 36474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __GenerateRandomTarget_FunctionParams
		{
			// Token: 0x0402CAC7 RID: 182983
			[FieldOffset(0)]
			public int count;

			// Token: 0x0402CAC8 RID: 182984
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x0402CAC9 RID: 182985
			[FieldOffset(8)]
			public byte finalOffsetArray;
		}

		// Token: 0x02008E7B RID: 36475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RequestLaunch_FunctionParams
		{
			// Token: 0x0402CACA RID: 182986
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x0402CACB RID: 182987
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x0402CACC RID: 182988
			[FieldOffset(8)]
			public int Count;

			// Token: 0x0402CACD RID: 182989
			[FieldOffset(16)]
			public byte InputTargetPositions;

			// Token: 0x0402CACE RID: 182990
			[FieldOffset(32)]
			public float FlyDuring;
		}

		// Token: 0x02008E7C RID: 36476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __LaunchNiagaraWithTargets_FunctionParams
		{
			// Token: 0x0402CACF RID: 182991
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LaunchType;
		}

		// Token: 0x02008E7D RID: 36477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SpawnPlantsByType_FunctionParams
		{
			// Token: 0x0402CAD0 RID: 182992
			[FieldOffset(0)]
			public byte TargetPositions;

			// Token: 0x0402CAD1 RID: 182993
			[FieldOffset(16)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x0402CAD2 RID: 182994
			[FieldOffset(17)]
			public bool bPlayAppearFX;
		}

		// Token: 0x02008E7E RID: 36478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RestorePlants_FunctionParams
		{
			// Token: 0x0402CAD3 RID: 182995
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> Launcher_Type;

			// Token: 0x0402CAD4 RID: 182996
			[FieldOffset(4)]
			public float Radius;

			// Token: 0x0402CAD5 RID: 182997
			[FieldOffset(8)]
			public int Count;

			// Token: 0x0402CAD6 RID: 182998
			[FieldOffset(16)]
			public byte input_Target_Positions;
		}
	}
}
