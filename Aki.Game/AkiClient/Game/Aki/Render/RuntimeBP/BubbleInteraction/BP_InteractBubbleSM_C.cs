using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.BubbleInteraction
{
	// Token: 0x02003E33 RID: 15923
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_InteractBubbleSM.BP_InteractBubbleSM_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_InteractBubbleSM_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F58 RID: 163672 RVA: 0x009A0694 File Offset: 0x0099E894
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractBubbleSM_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_InteractBubbleSM.BP_InteractBubbleSM_C");
			}
			return BP_InteractBubbleSM_C._ClassPtr;
		}

		// Token: 0x06027F59 RID: 163673 RVA: 0x009A06B8 File Offset: 0x0099E8B8
		public BP_InteractBubbleSM_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractBubbleSM_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x009A06E0 File Offset: 0x0099E8E0
		[NullableContext(1)]
		public BP_InteractBubbleSM_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractBubbleSM_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AF9 RID: 23289
		// (get) Token: 0x06027F5B RID: 163675 RVA: 0x009A0713 File Offset: 0x0099E913
		// (set) Token: 0x06027F5C RID: 163676 RVA: 0x009A0727 File Offset: 0x0099E927
		public unsafe UStaticMeshComponent SM_Old_Lig_09AM_Collision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x06027F5D RID: 163677 RVA: 0x009A073C File Offset: 0x0099E93C
		// (set) Token: 0x06027F5E RID: 163678 RVA: 0x009A0750 File Offset: 0x0099E950
		public unsafe UNiagaraComponent NS_BubbleExplosion
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x06027F5F RID: 163679 RVA: 0x009A0765 File Offset: 0x0099E965
		// (set) Token: 0x06027F60 RID: 163680 RVA: 0x009A0779 File Offset: 0x0099E979
		public unsafe UStaticMeshComponent SM_Old_Lig_09AM_T
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x06027F61 RID: 163681 RVA: 0x009A078E File Offset: 0x0099E98E
		// (set) Token: 0x06027F62 RID: 163682 RVA: 0x009A07A2 File Offset: 0x0099E9A2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x06027F63 RID: 163683 RVA: 0x009A07B7 File Offset: 0x0099E9B7
		// (set) Token: 0x06027F64 RID: 163684 RVA: 0x009A07C7 File Offset: 0x0099E9C7
		public unsafe float TestRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x06027F65 RID: 163685 RVA: 0x009A07D8 File Offset: 0x0099E9D8
		// (set) Token: 0x06027F66 RID: 163686 RVA: 0x009A07E8 File Offset: 0x0099E9E8
		public unsafe bool bShouldUpdateRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x06027F67 RID: 163687 RVA: 0x009A07F9 File Offset: 0x0099E9F9
		// (set) Token: 0x06027F68 RID: 163688 RVA: 0x009A0809 File Offset: 0x0099EA09
		public unsafe float InterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x06027F69 RID: 163689 RVA: 0x009A081A File Offset: 0x0099EA1A
		// (set) Token: 0x06027F6A RID: 163690 RVA: 0x009A082E File Offset: 0x0099EA2E
		public unsafe FVector SphereCenterVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x06027F6B RID: 163691 RVA: 0x009A0843 File Offset: 0x0099EA43
		// (set) Token: 0x06027F6C RID: 163692 RVA: 0x009A0853 File Offset: 0x0099EA53
		public unsafe float InterpRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x06027F6D RID: 163693 RVA: 0x009A0864 File Offset: 0x0099EA64
		// (set) Token: 0x06027F6E RID: 163694 RVA: 0x009A0874 File Offset: 0x0099EA74
		public unsafe bool DebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBubbleSM_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x06027F6F RID: 163695 RVA: 0x009A0885 File Offset: 0x0099EA85
		// (set) Token: 0x06027F70 RID: 163696 RVA: 0x009A0899 File Offset: 0x0099EA99
		public unsafe UMaterialInstanceDynamic Bubble_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBubbleSM_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x06027F71 RID: 163697 RVA: 0x009A08AE File Offset: 0x0099EAAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdataSDF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__UpdataSDF_NativeFunctionPtr, null);
		}

		// Token: 0x06027F72 RID: 163698 RVA: 0x009A08C4 File Offset: 0x0099EAC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_7248FFF24C6ED5791FB19C83C313381A(int PlayingID)
		{
			BP_InteractBubbleSM_C.__Completed_7248FFF24C6ED5791FB19C83C313381A_FunctionParams* ptr = stackalloc BP_InteractBubbleSM_C.__Completed_7248FFF24C6ED5791FB19C83C313381A_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBubbleSM_C.__Completed_7248FFF24C6ED5791FB19C83C313381A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBubbleSM_C.__Completed_7248FFF24C6ED5791FB19C83C313381A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__Completed_7248FFF24C6ED5791FB19C83C313381A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F73 RID: 163699 RVA: 0x009A090A File Offset: 0x0099EB0A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027F74 RID: 163700 RVA: 0x009A091E File Offset: 0x0099EB1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractBubbleSM_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027F75 RID: 163701 RVA: 0x009A0934 File Offset: 0x0099EB34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F76 RID: 163702 RVA: 0x009A097C File Offset: 0x0099EB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBubbleSM_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027F77 RID: 163703 RVA: 0x009A09C4 File Offset: 0x0099EBC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_InteractBubbleSM_C.__BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractBubbleSM_C.__BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_InteractBubbleSM_C.__BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBubbleSM_C.__BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F78 RID: 163704 RVA: 0x009A0A80 File Offset: 0x0099EC80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F79 RID: 163705 RVA: 0x009A0B3A File Offset: 0x0099ED3A
		protected BP_InteractBubbleSM_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014488 RID: 83080
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_InteractBubbleSM.BP_InteractBubbleSM_C";

		// Token: 0x04014489 RID: 83081
		private static IntPtr _ClassPtr;

		// Token: 0x0401448A RID: 83082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401448B RID: 83083
		internal static int __PropertyOffset_1;

		// Token: 0x0401448C RID: 83084
		internal static int __PropertyOffset_2;

		// Token: 0x0401448D RID: 83085
		internal static int __PropertyOffset_3;

		// Token: 0x0401448E RID: 83086
		internal static int __PropertyOffset_4;

		// Token: 0x0401448F RID: 83087
		internal static int __PropertyOffset_5;

		// Token: 0x04014490 RID: 83088
		internal static int __PropertyOffset_6;

		// Token: 0x04014491 RID: 83089
		internal static int __PropertyOffset_7;

		// Token: 0x04014492 RID: 83090
		internal static int __PropertyOffset_8;

		// Token: 0x04014493 RID: 83091
		internal static int __PropertyOffset_9;

		// Token: 0x04014494 RID: 83092
		internal static int __PropertyOffset_10;

		// Token: 0x04014495 RID: 83093
		internal static int __PropertyOffset_11;

		// Token: 0x04014496 RID: 83094
		private static IntPtr __UpdataSDF_NativeFunctionPtr;

		// Token: 0x04014497 RID: 83095
		private static IntPtr __Completed_7248FFF24C6ED5791FB19C83C313381A_NativeFunctionPtr;

		// Token: 0x04014498 RID: 83096
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04014499 RID: 83097
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401449A RID: 83098
		private static IntPtr __BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401449B RID: 83099
		private static IntPtr __BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A2B1 RID: 41649
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_7248FFF24C6ED5791FB19C83C313381A_FunctionParams
		{
			// Token: 0x04031FD9 RID: 204761
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x0200A2B2 RID: 41650
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FDA RID: 204762
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2B3 RID: 41651
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BubbleHit_SM_Old_Lig_09AM_T_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031FDB RID: 204763
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031FDC RID: 204764
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031FDD RID: 204765
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031FDE RID: 204766
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031FDF RID: 204767
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031FE0 RID: 204768
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x0200A2B4 RID: 41652
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031FE1 RID: 204769
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031FE2 RID: 204770
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031FE3 RID: 204771
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031FE4 RID: 204772
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031FE5 RID: 204773
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031FE6 RID: 204774
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
