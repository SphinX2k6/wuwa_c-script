using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterFallSpray
{
	// Token: 0x02003BE0 RID: 15328
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterFallSpray/BP_WaterfallSpray.BP_WaterfallSpray_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1098)]
	public class BP_WaterfallSpray_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602296C RID: 141676 RVA: 0x0090CCC1 File Offset: 0x0090AEC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterfallSpray_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterFallSpray/BP_WaterfallSpray.BP_WaterfallSpray_C");
			}
			return BP_WaterfallSpray_C._ClassPtr;
		}

		// Token: 0x0602296D RID: 141677 RVA: 0x0090CCE8 File Offset: 0x0090AEE8
		public BP_WaterfallSpray_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterfallSpray_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602296E RID: 141678 RVA: 0x0090CD10 File Offset: 0x0090AF10
		[NullableContext(1)]
		public BP_WaterfallSpray_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterfallSpray_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0602296F RID: 141679 RVA: 0x0090CD43 File Offset: 0x0090AF43
		// (set) Token: 0x06022970 RID: 141680 RVA: 0x0090CD57 File Offset: 0x0090AF57
		public unsafe UBoxComponent Box_NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x06022971 RID: 141681 RVA: 0x0090CD6C File Offset: 0x0090AF6C
		// (set) Token: 0x06022972 RID: 141682 RVA: 0x0090CD80 File Offset: 0x0090AF80
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x06022973 RID: 141683 RVA: 0x0090CD95 File Offset: 0x0090AF95
		// (set) Token: 0x06022974 RID: 141684 RVA: 0x0090CDA9 File Offset: 0x0090AFA9
		public unsafe UNiagaraComponent NS_Fx_WaterfallSpray
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x06022975 RID: 141685 RVA: 0x0090CDBE File Offset: 0x0090AFBE
		// (set) Token: 0x06022976 RID: 141686 RVA: 0x0090CDD2 File Offset: 0x0090AFD2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x06022977 RID: 141687 RVA: 0x0090CDE7 File Offset: 0x0090AFE7
		// (set) Token: 0x06022978 RID: 141688 RVA: 0x0090CDFB File Offset: 0x0090AFFB
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterfallSpray_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x06022979 RID: 141689 RVA: 0x0090CE10 File Offset: 0x0090B010
		// (set) Token: 0x0602297A RID: 141690 RVA: 0x0090CE20 File Offset: 0x0090B020
		public unsafe bool bPlayerOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterfallSpray_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterfallSpray_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0602297B RID: 141691 RVA: 0x0090CE31 File Offset: 0x0090B031
		// (set) Token: 0x0602297C RID: 141692 RVA: 0x0090CE41 File Offset: 0x0090B041
		public unsafe bool bNPCWaterfall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterfallSpray_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterfallSpray_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602297D RID: 141693 RVA: 0x0090CE52 File Offset: 0x0090B052
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x0090CE66 File Offset: 0x0090B066
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602297F RID: 141695 RVA: 0x0090CE7A File Offset: 0x0090B07A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterfallSpray_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022980 RID: 141696 RVA: 0x0090CE8F File Offset: 0x0090B08F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022981 RID: 141697 RVA: 0x0090CEA3 File Offset: 0x0090B0A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterfallSpray_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022982 RID: 141698 RVA: 0x0090CEB8 File Offset: 0x0090B0B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterfallSpray_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterfallSpray_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterfallSpray_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterfallSpray_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022983 RID: 141699 RVA: 0x0090CF00 File Offset: 0x0090B100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterfallSpray_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterfallSpray_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterfallSpray_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterfallSpray_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterfallSpray_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022984 RID: 141700 RVA: 0x0090CF48 File Offset: 0x0090B148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022985 RID: 141701 RVA: 0x0090D004 File Offset: 0x0090B204
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterfallSpray_C.__BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022986 RID: 141702 RVA: 0x0090D08D File Offset: 0x0090B28D
		protected BP_WaterfallSpray_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FD0 RID: 69584
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterFallSpray/BP_WaterfallSpray.BP_WaterfallSpray_C";

		// Token: 0x04010FD1 RID: 69585
		private static IntPtr _ClassPtr;

		// Token: 0x04010FD2 RID: 69586
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FD3 RID: 69587
		internal static int __PropertyOffset_1;

		// Token: 0x04010FD4 RID: 69588
		internal static int __PropertyOffset_2;

		// Token: 0x04010FD5 RID: 69589
		internal static int __PropertyOffset_3;

		// Token: 0x04010FD6 RID: 69590
		internal static int __PropertyOffset_4;

		// Token: 0x04010FD7 RID: 69591
		internal static int __PropertyOffset_5;

		// Token: 0x04010FD8 RID: 69592
		internal static int __PropertyOffset_6;

		// Token: 0x04010FD9 RID: 69593
		internal static int __PropertyOffset_7;

		// Token: 0x04010FDA RID: 69594
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04010FDB RID: 69595
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010FDC RID: 69596
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010FDD RID: 69597
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010FDE RID: 69598
		private static IntPtr __BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010FDF RID: 69599
		private static IntPtr __BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D99 RID: 40345
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403156A RID: 202090
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D9A RID: 40346
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403156B RID: 202091
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403156C RID: 202092
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403156D RID: 202093
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403156E RID: 202094
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403156F RID: 202095
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031570 RID: 202096
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D9B RID: 40347
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterfallSpray_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031571 RID: 202097
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031572 RID: 202098
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031573 RID: 202099
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031574 RID: 202100
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
