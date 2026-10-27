using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C23 RID: 15395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt_Test.BP_ConveyorBelt_Test_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1488)]
	public class BP_ConveyorBelt_Test_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060234CF RID: 144591 RVA: 0x00920540 File Offset: 0x0091E740
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ConveyorBelt_Test_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt_Test.BP_ConveyorBelt_Test_C");
			}
			return BP_ConveyorBelt_Test_C._ClassPtr;
		}

		// Token: 0x060234D0 RID: 144592 RVA: 0x00920564 File Offset: 0x0091E764
		public BP_ConveyorBelt_Test_C() : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_Test_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234D1 RID: 144593 RVA: 0x0092058C File Offset: 0x0091E78C
		[NullableContext(1)]
		public BP_ConveyorBelt_Test_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_Test_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x060234D2 RID: 144594 RVA: 0x009205BF File Offset: 0x0091E7BF
		// (set) Token: 0x060234D3 RID: 144595 RVA: 0x009205D3 File Offset: 0x0091E7D3
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x060234D4 RID: 144596 RVA: 0x009205E8 File Offset: 0x0091E7E8
		// (set) Token: 0x060234D5 RID: 144597 RVA: 0x009205FC File Offset: 0x0091E7FC
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x060234D6 RID: 144598 RVA: 0x00920611 File Offset: 0x0091E811
		// (set) Token: 0x060234D7 RID: 144599 RVA: 0x00920625 File Offset: 0x0091E825
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_Test_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060234D8 RID: 144600 RVA: 0x0092063C File Offset: 0x0091E83C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234D9 RID: 144601 RVA: 0x00920684 File Offset: 0x0091E884
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060234DA RID: 144602 RVA: 0x009206CC File Offset: 0x0091E8CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234DB RID: 144603 RVA: 0x00920714 File Offset: 0x0091E914
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060234DC RID: 144604 RVA: 0x0092075C File Offset: 0x0091E95C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234DD RID: 144605 RVA: 0x00920818 File Offset: 0x0091EA18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_Test_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234DE RID: 144606 RVA: 0x009208A1 File Offset: 0x0091EAA1
		protected BP_ConveyorBelt_Test_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011697 RID: 71319
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt_Test.BP_ConveyorBelt_Test_C";

		// Token: 0x04011698 RID: 71320
		private static IntPtr _ClassPtr;

		// Token: 0x04011699 RID: 71321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401169A RID: 71322
		internal static int __PropertyOffset_1;

		// Token: 0x0401169B RID: 71323
		internal static int __PropertyOffset_2;

		// Token: 0x0401169C RID: 71324
		internal static int __PropertyOffset_3;

		// Token: 0x0401169D RID: 71325
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401169E RID: 71326
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401169F RID: 71327
		private static IntPtr __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040116A0 RID: 71328
		private static IntPtr __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E52 RID: 40530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316CC RID: 202444
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E53 RID: 40531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316CD RID: 202445
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E54 RID: 40532
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316CE RID: 202446
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316CF RID: 202447
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316D0 RID: 202448
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316D1 RID: 202449
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040316D2 RID: 202450
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040316D3 RID: 202451
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E55 RID: 40533
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316D4 RID: 202452
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316D5 RID: 202453
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316D6 RID: 202454
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316D7 RID: 202455
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
