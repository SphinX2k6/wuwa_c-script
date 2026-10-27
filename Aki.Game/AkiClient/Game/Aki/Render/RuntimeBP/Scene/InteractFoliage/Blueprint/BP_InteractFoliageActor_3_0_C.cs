using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B53 RID: 15187
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_3_0.BP_InteractFoliageActor_3_0_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_InteractFoliageActor_3_0_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021A89 RID: 137865 RVA: 0x008F22B0 File Offset: 0x008F04B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractFoliageActor_3_0_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_3_0.BP_InteractFoliageActor_3_0_C");
			}
			return BP_InteractFoliageActor_3_0_C._ClassPtr;
		}

		// Token: 0x06021A8A RID: 137866 RVA: 0x008F22D4 File Offset: 0x008F04D4
		public BP_InteractFoliageActor_3_0_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_3_0_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021A8B RID: 137867 RVA: 0x008F22FC File Offset: 0x008F04FC
		[NullableContext(1)]
		public BP_InteractFoliageActor_3_0_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_3_0_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x06021A8C RID: 137868 RVA: 0x008F232F File Offset: 0x008F052F
		// (set) Token: 0x06021A8D RID: 137869 RVA: 0x008F2343 File Offset: 0x008F0543
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x06021A8E RID: 137870 RVA: 0x008F2358 File Offset: 0x008F0558
		// (set) Token: 0x06021A8F RID: 137871 RVA: 0x008F236C File Offset: 0x008F056C
		public unsafe USkeletalMeshComponent SkeletalMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x06021A90 RID: 137872 RVA: 0x008F2381 File Offset: 0x008F0581
		// (set) Token: 0x06021A91 RID: 137873 RVA: 0x008F2395 File Offset: 0x008F0595
		public unsafe UStaticMeshComponent StaticMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x06021A92 RID: 137874 RVA: 0x008F23AA File Offset: 0x008F05AA
		// (set) Token: 0x06021A93 RID: 137875 RVA: 0x008F23BE File Offset: 0x008F05BE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x06021A94 RID: 137876 RVA: 0x008F23D3 File Offset: 0x008F05D3
		// (set) Token: 0x06021A95 RID: 137877 RVA: 0x008F23E7 File Offset: 0x008F05E7
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_3_0_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x06021A96 RID: 137878 RVA: 0x008F23FC File Offset: 0x008F05FC
		// (set) Token: 0x06021A97 RID: 137879 RVA: 0x008F240C File Offset: 0x008F060C
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_3_0_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_3_0_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x06021A98 RID: 137880 RVA: 0x008F241D File Offset: 0x008F061D
		// (set) Token: 0x06021A99 RID: 137881 RVA: 0x008F242D File Offset: 0x008F062D
		public unsafe float CachedQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageActor_3_0_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageActor_3_0_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06021A9A RID: 137882 RVA: 0x008F2440 File Offset: 0x008F0640
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AdaptQualityLevel(ref bool bShouldTick)
		{
			BP_InteractFoliageActor_3_0_C.__AdaptQualityLevel_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_3_0_C.__AdaptQualityLevel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractFoliageActor_3_0_C.__AdaptQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_3_0_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShouldTick = bShouldTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr);
			bShouldTick = ptr->bShouldTick;
		}

		// Token: 0x06021A9B RID: 137883 RVA: 0x008F2490 File Offset: 0x008F0690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeActiveFoliageNum(float ChangeNum)
		{
			BP_InteractFoliageActor_3_0_C.__ChangeActiveFoliageNum_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_3_0_C.__ChangeActiveFoliageNum_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractFoliageActor_3_0_C.__ChangeActiveFoliageNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_3_0_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChangeNum = ChangeNum;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A9C RID: 137884 RVA: 0x008F24D6 File Offset: 0x008F06D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021A9D RID: 137885 RVA: 0x008F24EA File Offset: 0x008F06EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021A9E RID: 137886 RVA: 0x008F24FF File Offset: 0x008F06FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021A9F RID: 137887 RVA: 0x008F2513 File Offset: 0x008F0713
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021AA0 RID: 137888 RVA: 0x008F2528 File Offset: 0x008F0728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CallChange(float Weight)
		{
			BP_InteractFoliageActor_3_0_C.__CallChange_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_3_0_C.__CallChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageActor_3_0_C.__CallChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_3_0_C.__CallChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__CallChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AA1 RID: 137889 RVA: 0x008F2570 File Offset: 0x008F0770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AA2 RID: 137890 RVA: 0x008F262C File Offset: 0x008F082C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_3_0_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AA3 RID: 137891 RVA: 0x008F26B5 File Offset: 0x008F08B5
		protected BP_InteractFoliageActor_3_0_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106A5 RID: 67237
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_3_0.BP_InteractFoliageActor_3_0_C";

		// Token: 0x040106A6 RID: 67238
		private static IntPtr _ClassPtr;

		// Token: 0x040106A7 RID: 67239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106A8 RID: 67240
		internal static int __PropertyOffset_1;

		// Token: 0x040106A9 RID: 67241
		internal static int __PropertyOffset_2;

		// Token: 0x040106AA RID: 67242
		internal static int __PropertyOffset_3;

		// Token: 0x040106AB RID: 67243
		internal static int __PropertyOffset_4;

		// Token: 0x040106AC RID: 67244
		internal static int __PropertyOffset_5;

		// Token: 0x040106AD RID: 67245
		internal static int __PropertyOffset_6;

		// Token: 0x040106AE RID: 67246
		internal static int __PropertyOffset_7;

		// Token: 0x040106AF RID: 67247
		private static IntPtr __AdaptQualityLevel_NativeFunctionPtr;

		// Token: 0x040106B0 RID: 67248
		private static IntPtr __ChangeActiveFoliageNum_NativeFunctionPtr;

		// Token: 0x040106B1 RID: 67249
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040106B2 RID: 67250
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040106B3 RID: 67251
		private static IntPtr __CallChange_NativeFunctionPtr;

		// Token: 0x040106B4 RID: 67252
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040106B5 RID: 67253
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009CB2 RID: 40114
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AdaptQualityLevel_FunctionParams
		{
			// Token: 0x04031387 RID: 201607
			[FieldOffset(0)]
			public bool bShouldTick;
		}

		// Token: 0x02009CB3 RID: 40115
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChangeActiveFoliageNum_FunctionParams
		{
			// Token: 0x04031388 RID: 201608
			[FieldOffset(0)]
			public float ChangeNum;
		}

		// Token: 0x02009CB4 RID: 40116
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CallChange_FunctionParams
		{
			// Token: 0x04031389 RID: 201609
			[FieldOffset(0)]
			public float Weight;
		}

		// Token: 0x02009CB5 RID: 40117
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403138A RID: 201610
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403138B RID: 201611
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403138C RID: 201612
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403138D RID: 201613
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403138E RID: 201614
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403138F RID: 201615
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009CB6 RID: 40118
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031390 RID: 201616
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031391 RID: 201617
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031392 RID: 201618
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031393 RID: 201619
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
