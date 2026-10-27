using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.AreaLightManager
{
	// Token: 0x02003BA7 RID: 15271
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaTrigger.BP_AreaTrigger_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1145)]
	public class BP_AreaTrigger_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022060 RID: 139360 RVA: 0x008FD0A7 File Offset: 0x008FB2A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AreaTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaTrigger.BP_AreaTrigger_C");
			}
			return BP_AreaTrigger_C._ClassPtr;
		}

		// Token: 0x06022061 RID: 139361 RVA: 0x008FD0CC File Offset: 0x008FB2CC
		public BP_AreaTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_AreaTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022062 RID: 139362 RVA: 0x008FD0F4 File Offset: 0x008FB2F4
		[NullableContext(1)]
		public BP_AreaTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AreaTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x06022063 RID: 139363 RVA: 0x008FD127 File Offset: 0x008FB327
		// (set) Token: 0x06022064 RID: 139364 RVA: 0x008FD13B File Offset: 0x008FB33B
		public unsafe UBoxComponent RightTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x06022065 RID: 139365 RVA: 0x008FD150 File Offset: 0x008FB350
		// (set) Token: 0x06022066 RID: 139366 RVA: 0x008FD164 File Offset: 0x008FB364
		public unsafe UBoxComponent LeftTrigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x06022067 RID: 139367 RVA: 0x008FD179 File Offset: 0x008FB379
		// (set) Token: 0x06022068 RID: 139368 RVA: 0x008FD18D File Offset: 0x008FB38D
		public unsafe UStaticMeshComponent AreaTriggerArrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x06022069 RID: 139369 RVA: 0x008FD1A2 File Offset: 0x008FB3A2
		// (set) Token: 0x0602206A RID: 139370 RVA: 0x008FD1B6 File Offset: 0x008FB3B6
		public unsafe UBoxComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0602206B RID: 139371 RVA: 0x008FD1CB File Offset: 0x008FB3CB
		// (set) Token: 0x0602206C RID: 139372 RVA: 0x008FD1DF File Offset: 0x008FB3DF
		public unsafe UTextRenderComponent RightTextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0602206D RID: 139373 RVA: 0x008FD1F4 File Offset: 0x008FB3F4
		// (set) Token: 0x0602206E RID: 139374 RVA: 0x008FD208 File Offset: 0x008FB408
		public unsafe UTextRenderComponent LeftTextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0602206F RID: 139375 RVA: 0x008FD21D File Offset: 0x008FB41D
		// (set) Token: 0x06022070 RID: 139376 RVA: 0x008FD231 File Offset: 0x008FB431
		public unsafe BP_AreaLightManager_C LightManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_AreaLightManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AreaTrigger_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x06022071 RID: 139377 RVA: 0x008FD246 File Offset: 0x008FB446
		// (set) Token: 0x06022072 RID: 139378 RVA: 0x008FD256 File Offset: 0x008FB456
		public unsafe int LeftAreaIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x06022073 RID: 139379 RVA: 0x008FD267 File Offset: 0x008FB467
		// (set) Token: 0x06022074 RID: 139380 RVA: 0x008FD277 File Offset: 0x008FB477
		public unsafe int RightAreaIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x06022075 RID: 139381 RVA: 0x008FD288 File Offset: 0x008FB488
		// (set) Token: 0x06022076 RID: 139382 RVA: 0x008FD298 File Offset: 0x008FB498
		public unsafe int PlayerInAreaIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x06022077 RID: 139383 RVA: 0x008FD2A9 File Offset: 0x008FB4A9
		// (set) Token: 0x06022078 RID: 139384 RVA: 0x008FD2BD File Offset: 0x008FB4BD
		[Nullable(1)]
		public unsafe string AreaText
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_AreaTrigger_C.__PropertyOffset_11)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_AreaTrigger_C.__PropertyOffset_11)), value);
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x06022079 RID: 139385 RVA: 0x008FD2D2 File Offset: 0x008FB4D2
		// (set) Token: 0x0602207A RID: 139386 RVA: 0x008FD2E2 File Offset: 0x008FB4E2
		public unsafe bool EnableOverlapTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AreaTrigger_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602207B RID: 139387 RVA: 0x008FD2F3 File Offset: 0x008FB4F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602207C RID: 139388 RVA: 0x008FD307 File Offset: 0x008FB507
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AreaTrigger_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602207D RID: 139389 RVA: 0x008FD31C File Offset: 0x008FB51C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602207E RID: 139390 RVA: 0x008FD330 File Offset: 0x008FB530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AreaTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602207F RID: 139391 RVA: 0x008FD348 File Offset: 0x008FB548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_AreaTrigger_C.__BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AreaTrigger_C.__BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AreaTrigger_C.__BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaTrigger_C.__BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022080 RID: 139392 RVA: 0x008FD3D4 File Offset: 0x008FB5D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_AreaTrigger_C.__BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AreaTrigger_C.__BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AreaTrigger_C.__BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaTrigger_C.__BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022081 RID: 139393 RVA: 0x008FD460 File Offset: 0x008FB660
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022082 RID: 139394 RVA: 0x008FD51C File Offset: 0x008FB71C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AreaTrigger_C.__BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022083 RID: 139395 RVA: 0x008FD5D6 File Offset: 0x008FB7D6
		protected BP_AreaTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A66 RID: 68198
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/BP_AreaTrigger.BP_AreaTrigger_C";

		// Token: 0x04010A67 RID: 68199
		private static IntPtr _ClassPtr;

		// Token: 0x04010A68 RID: 68200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A69 RID: 68201
		internal static int __PropertyOffset_1;

		// Token: 0x04010A6A RID: 68202
		internal static int __PropertyOffset_2;

		// Token: 0x04010A6B RID: 68203
		internal static int __PropertyOffset_3;

		// Token: 0x04010A6C RID: 68204
		internal static int __PropertyOffset_4;

		// Token: 0x04010A6D RID: 68205
		internal static int __PropertyOffset_5;

		// Token: 0x04010A6E RID: 68206
		internal static int __PropertyOffset_6;

		// Token: 0x04010A6F RID: 68207
		internal static int __PropertyOffset_7;

		// Token: 0x04010A70 RID: 68208
		internal static int __PropertyOffset_8;

		// Token: 0x04010A71 RID: 68209
		internal static int __PropertyOffset_9;

		// Token: 0x04010A72 RID: 68210
		internal static int __PropertyOffset_10;

		// Token: 0x04010A73 RID: 68211
		internal static int __PropertyOffset_11;

		// Token: 0x04010A74 RID: 68212
		internal static int __PropertyOffset_12;

		// Token: 0x04010A75 RID: 68213
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010A76 RID: 68214
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010A77 RID: 68215
		private static IntPtr __BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010A78 RID: 68216
		private static IntPtr __BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010A79 RID: 68217
		private static IntPtr __BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010A7A RID: 68218
		private static IntPtr __BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D18 RID: 40216
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_Test_FrontBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031442 RID: 201794
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031443 RID: 201795
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031444 RID: 201796
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031445 RID: 201797
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D19 RID: 40217
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_Test_BackBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031446 RID: 201798
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031447 RID: 201799
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031448 RID: 201800
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031449 RID: 201801
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D1A RID: 40218
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_AreaTrigger_LeftTrigger_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403144A RID: 201802
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403144B RID: 201803
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403144C RID: 201804
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403144D RID: 201805
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403144E RID: 201806
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403144F RID: 201807
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D1B RID: 40219
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_AreaTrigger_RightTrigger_K2Node_ComponentBoundEvent_4_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031450 RID: 201808
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031451 RID: 201809
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031452 RID: 201810
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031453 RID: 201811
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031454 RID: 201812
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031455 RID: 201813
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
