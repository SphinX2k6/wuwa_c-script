using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LongGrass
{
	// Token: 0x02003CF3 RID: 15603
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvInteraction.BP_WeaponEnvInteraction_C")]
	[UnrealStructLayout(1736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1732)]
	public class BP_WeaponEnvInteraction_C : AKuroWeaponEnvInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602533B RID: 152379 RVA: 0x00953CE4 File Offset: 0x00951EE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeaponEnvInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvInteraction.BP_WeaponEnvInteraction_C");
			}
			return BP_WeaponEnvInteraction_C._ClassPtr;
		}

		// Token: 0x0602533C RID: 152380 RVA: 0x00953D08 File Offset: 0x00951F08
		public BP_WeaponEnvInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeaponEnvInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602533D RID: 152381 RVA: 0x00953D30 File Offset: 0x00951F30
		[NullableContext(1)]
		public BP_WeaponEnvInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeaponEnvInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x0602533E RID: 152382 RVA: 0x00953D63 File Offset: 0x00951F63
		// (set) Token: 0x0602533F RID: 152383 RVA: 0x00953D77 File Offset: 0x00951F77
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x06025340 RID: 152384 RVA: 0x00953D8C File Offset: 0x00951F8C
		// (set) Token: 0x06025341 RID: 152385 RVA: 0x00953DA0 File Offset: 0x00951FA0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x06025342 RID: 152386 RVA: 0x00953DB5 File Offset: 0x00951FB5
		// (set) Token: 0x06025343 RID: 152387 RVA: 0x00953DC9 File Offset: 0x00951FC9
		public unsafe BP_SceneBattleInteract_C Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x06025344 RID: 152388 RVA: 0x00953DDE File Offset: 0x00951FDE
		// (set) Token: 0x06025345 RID: 152389 RVA: 0x00953DF2 File Offset: 0x00951FF2
		public unsafe BP_WeaponEnvReadback_C GPUReadBackActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WeaponEnvReadback_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponEnvInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x06025346 RID: 152390 RVA: 0x00953E07 File Offset: 0x00952007
		// (set) Token: 0x06025347 RID: 152391 RVA: 0x00953E17 File Offset: 0x00952017
		public unsafe int RTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponEnvInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponEnvInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06025348 RID: 152392 RVA: 0x00953E28 File Offset: 0x00952028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool WeaponPointVaildation(FVectorDouble SceneInteractPos, BP_SceneBattleInteract_C SceneInteractDA)
		{
			BP_WeaponEnvInteraction_C.__WeaponPointVaildation_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__WeaponPointVaildation_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__WeaponPointVaildation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__WeaponPointVaildation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SceneInteractPos = SceneInteractPos;
			ptr->SceneInteractDA = ((SceneInteractDA != null) ? SceneInteractDA.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__WeaponPointVaildation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025349 RID: 152393 RVA: 0x00953E90 File Offset: 0x00952090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcDistance2D(FVectorDouble V1, FVectorDouble V2, ref double Distance)
		{
			BP_WeaponEnvInteraction_C.__CalcDistance2D_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__CalcDistance2D_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__CalcDistance2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V1 = V1;
			ptr->V2 = V2;
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr);
			Distance = ptr->Distance;
		}

		// Token: 0x0602534A RID: 152394 RVA: 0x00953EF0 File Offset: 0x009520F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble MainPlayerPos, FVectorDouble OtherPlayerPos, float InteractionSize, ref FVector2D TexCoord)
		{
			BP_WeaponEnvInteraction_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MainPlayerPos = MainPlayerPos;
			ptr->OtherPlayerPos = OtherPlayerPos;
			ptr->InteractionSize = InteractionSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0602534B RID: 152395 RVA: 0x00953F64 File Offset: 0x00952164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ResizeRT(int Size)
		{
			BP_WeaponEnvInteraction_C.__ResizeRT_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__ResizeRT_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__ResizeRT_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__ResizeRT_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Size = Size;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ResizeRT_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602534C RID: 152396 RVA: 0x00953FAA File Offset: 0x009521AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x0602534D RID: 152397 RVA: 0x00953FBE File Offset: 0x009521BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_MID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__Create_MID_NativeFunctionPtr, null);
		}

		// Token: 0x0602534E RID: 152398 RVA: 0x00953FD2 File Offset: 0x009521D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602534F RID: 152399 RVA: 0x00953FE6 File Offset: 0x009521E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x00953FFC File Offset: 0x009521FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_WeaponEnvInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x0095405F File Offset: 0x0095225F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x00954073 File Offset: 0x00952273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025353 RID: 152403 RVA: 0x00954088 File Offset: 0x00952288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025354 RID: 152404 RVA: 0x009540D0 File Offset: 0x009522D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025355 RID: 152405 RVA: 0x00954117 File Offset: 0x00952317
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRenderTarget()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__ClearRenderTarget_NativeFunctionPtr, null);
		}

		// Token: 0x06025356 RID: 152406 RVA: 0x0095412C File Offset: 0x0095232C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnEnvInteractChanged(bool bEnableEnvInteract)
		{
			BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnableEnvInteract = bEnableEnvInteract;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025357 RID: 152407 RVA: 0x00954174 File Offset: 0x00952374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnEnvInteractChanged_Implementation(bool bEnableEnvInteract)
		{
			BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams* ptr = stackalloc BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnableEnvInteract = bEnableEnvInteract;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvInteraction_C.__OnEnvInteractChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025358 RID: 152408 RVA: 0x009541BB File Offset: 0x009523BB
		protected BP_WeaponEnvInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012880 RID: 75904
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvInteraction.BP_WeaponEnvInteraction_C";

		// Token: 0x04012881 RID: 75905
		private static IntPtr _ClassPtr;

		// Token: 0x04012882 RID: 75906
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012883 RID: 75907
		internal static int __PropertyOffset_1;

		// Token: 0x04012884 RID: 75908
		internal static int __PropertyOffset_2;

		// Token: 0x04012885 RID: 75909
		internal static int __PropertyOffset_3;

		// Token: 0x04012886 RID: 75910
		internal static int __PropertyOffset_4;

		// Token: 0x04012887 RID: 75911
		internal static int __PropertyOffset_5;

		// Token: 0x04012888 RID: 75912
		private static IntPtr __WeaponPointVaildation_NativeFunctionPtr;

		// Token: 0x04012889 RID: 75913
		private static IntPtr __CalcDistance2D_NativeFunctionPtr;

		// Token: 0x0401288A RID: 75914
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0401288B RID: 75915
		private static IntPtr __ResizeRT_NativeFunctionPtr;

		// Token: 0x0401288C RID: 75916
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x0401288D RID: 75917
		private static IntPtr __Create_MID_NativeFunctionPtr;

		// Token: 0x0401288E RID: 75918
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401288F RID: 75919
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04012890 RID: 75920
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012891 RID: 75921
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012892 RID: 75922
		private static IntPtr __ClearRenderTarget_NativeFunctionPtr;

		// Token: 0x04012893 RID: 75923
		private static IntPtr __OnEnvInteractChanged_NativeFunctionPtr;

		// Token: 0x02009FC8 RID: 40904
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __WeaponPointVaildation_FunctionParams
		{
			// Token: 0x04031A37 RID: 203319
			[FieldOffset(0)]
			public FVectorDouble SceneInteractPos;

			// Token: 0x04031A38 RID: 203320
			[FieldOffset(24)]
			public IntPtr SceneInteractDA;

			// Token: 0x04031A39 RID: 203321
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02009FC9 RID: 40905
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __CalcDistance2D_FunctionParams
		{
			// Token: 0x04031A3A RID: 203322
			[FieldOffset(0)]
			public FVectorDouble V1;

			// Token: 0x04031A3B RID: 203323
			[FieldOffset(24)]
			public FVectorDouble V2;

			// Token: 0x04031A3C RID: 203324
			[FieldOffset(48)]
			public double Distance;
		}

		// Token: 0x02009FCA RID: 40906
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031A3D RID: 203325
			[FieldOffset(0)]
			public FVectorDouble MainPlayerPos;

			// Token: 0x04031A3E RID: 203326
			[FieldOffset(24)]
			public FVectorDouble OtherPlayerPos;

			// Token: 0x04031A3F RID: 203327
			[FieldOffset(48)]
			public float InteractionSize;

			// Token: 0x04031A40 RID: 203328
			[FieldOffset(52)]
			public FVector2D TexCoord;
		}

		// Token: 0x02009FCB RID: 40907
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResizeRT_FunctionParams
		{
			// Token: 0x04031A41 RID: 203329
			[FieldOffset(0)]
			public int Size;
		}

		// Token: 0x02009FCC RID: 40908
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031A42 RID: 203330
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A43 RID: 203331
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A44 RID: 203332
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009FCD RID: 40909
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A45 RID: 203333
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FCE RID: 40910
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __OnEnvInteractChanged_FunctionParams
		{
			// Token: 0x04031A46 RID: 203334
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}
	}
}
