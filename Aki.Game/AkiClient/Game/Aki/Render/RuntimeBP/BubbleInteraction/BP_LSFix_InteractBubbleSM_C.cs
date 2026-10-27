using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.BubbleInteraction
{
	// Token: 0x02003E34 RID: 15924
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_LSFix_InteractBubbleSM.BP_LSFix_InteractBubbleSM_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_LSFix_InteractBubbleSM_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F7A RID: 163706 RVA: 0x009A0B43 File Offset: 0x0099ED43
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LSFix_InteractBubbleSM_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_LSFix_InteractBubbleSM.BP_LSFix_InteractBubbleSM_C");
			}
			return BP_LSFix_InteractBubbleSM_C._ClassPtr;
		}

		// Token: 0x06027F7B RID: 163707 RVA: 0x009A0B68 File Offset: 0x0099ED68
		public BP_LSFix_InteractBubbleSM_C() : this(BuiltinUtils.AllocNativeUObject(BP_LSFix_InteractBubbleSM_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F7C RID: 163708 RVA: 0x009A0B90 File Offset: 0x0099ED90
		[NullableContext(1)]
		public BP_LSFix_InteractBubbleSM_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LSFix_InteractBubbleSM_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x06027F7D RID: 163709 RVA: 0x009A0BC3 File Offset: 0x0099EDC3
		// (set) Token: 0x06027F7E RID: 163710 RVA: 0x009A0BD7 File Offset: 0x0099EDD7
		public unsafe UStaticMeshComponent SM_Old_Lig_09AM_Collision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x06027F7F RID: 163711 RVA: 0x009A0BEC File Offset: 0x0099EDEC
		// (set) Token: 0x06027F80 RID: 163712 RVA: 0x009A0C00 File Offset: 0x0099EE00
		public unsafe UNiagaraComponent NS_BubbleExplosion
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x06027F81 RID: 163713 RVA: 0x009A0C15 File Offset: 0x0099EE15
		// (set) Token: 0x06027F82 RID: 163714 RVA: 0x009A0C29 File Offset: 0x0099EE29
		public unsafe UStaticMeshComponent SM_Old_Lig_09AM_T
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x06027F83 RID: 163715 RVA: 0x009A0C3E File Offset: 0x0099EE3E
		// (set) Token: 0x06027F84 RID: 163716 RVA: 0x009A0C52 File Offset: 0x0099EE52
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x06027F85 RID: 163717 RVA: 0x009A0C67 File Offset: 0x0099EE67
		// (set) Token: 0x06027F86 RID: 163718 RVA: 0x009A0C77 File Offset: 0x0099EE77
		public unsafe float TestRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x06027F87 RID: 163719 RVA: 0x009A0C88 File Offset: 0x0099EE88
		// (set) Token: 0x06027F88 RID: 163720 RVA: 0x009A0C98 File Offset: 0x0099EE98
		public unsafe bool bShouldUpdateRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x06027F89 RID: 163721 RVA: 0x009A0CA9 File Offset: 0x0099EEA9
		// (set) Token: 0x06027F8A RID: 163722 RVA: 0x009A0CB9 File Offset: 0x0099EEB9
		public unsafe float InterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x06027F8B RID: 163723 RVA: 0x009A0CCA File Offset: 0x0099EECA
		// (set) Token: 0x06027F8C RID: 163724 RVA: 0x009A0CDE File Offset: 0x0099EEDE
		public unsafe FVector SphereCenterVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x06027F8D RID: 163725 RVA: 0x009A0CF3 File Offset: 0x0099EEF3
		// (set) Token: 0x06027F8E RID: 163726 RVA: 0x009A0D03 File Offset: 0x0099EF03
		public unsafe float InterpRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005B0D RID: 23309
		// (get) Token: 0x06027F8F RID: 163727 RVA: 0x009A0D14 File Offset: 0x0099EF14
		// (set) Token: 0x06027F90 RID: 163728 RVA: 0x009A0D24 File Offset: 0x0099EF24
		public unsafe bool DebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LSFix_InteractBubbleSM_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B0E RID: 23310
		// (get) Token: 0x06027F91 RID: 163729 RVA: 0x009A0D35 File Offset: 0x0099EF35
		// (set) Token: 0x06027F92 RID: 163730 RVA: 0x009A0D49 File Offset: 0x0099EF49
		public unsafe UMaterialInstanceDynamic Bubble_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LSFix_InteractBubbleSM_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x06027F93 RID: 163731 RVA: 0x009A0D5E File Offset: 0x0099EF5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdataSDF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__UpdataSDF_NativeFunctionPtr, null);
		}

		// Token: 0x06027F94 RID: 163732 RVA: 0x009A0D74 File Offset: 0x0099EF74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_6B91D0B14409837F432BB3A8D9146B00(int PlayingID)
		{
			BP_LSFix_InteractBubbleSM_C.__Completed_6B91D0B14409837F432BB3A8D9146B00_FunctionParams* ptr = stackalloc BP_LSFix_InteractBubbleSM_C.__Completed_6B91D0B14409837F432BB3A8D9146B00_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LSFix_InteractBubbleSM_C.__Completed_6B91D0B14409837F432BB3A8D9146B00_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LSFix_InteractBubbleSM_C.__Completed_6B91D0B14409837F432BB3A8D9146B00_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__Completed_6B91D0B14409837F432BB3A8D9146B00_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F95 RID: 163733 RVA: 0x009A0DBA File Offset: 0x0099EFBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027F96 RID: 163734 RVA: 0x009A0DCE File Offset: 0x0099EFCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027F97 RID: 163735 RVA: 0x009A0DE4 File Offset: 0x0099EFE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LSFix_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F98 RID: 163736 RVA: 0x009A0E2C File Offset: 0x0099F02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LSFix_InteractBubbleSM_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LSFix_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027F99 RID: 163737 RVA: 0x009A0E74 File Offset: 0x0099F074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_LSFix_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_LSFix_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_LSFix_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LSFix_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LSFix_InteractBubbleSM_C.__BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027F9A RID: 163738 RVA: 0x009A0F2E File Offset: 0x0099F12E
		protected BP_LSFix_InteractBubbleSM_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401449C RID: 83100
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/BubbleInteraction/BP_LSFix_InteractBubbleSM.BP_LSFix_InteractBubbleSM_C";

		// Token: 0x0401449D RID: 83101
		private static IntPtr _ClassPtr;

		// Token: 0x0401449E RID: 83102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401449F RID: 83103
		internal static int __PropertyOffset_1;

		// Token: 0x040144A0 RID: 83104
		internal static int __PropertyOffset_2;

		// Token: 0x040144A1 RID: 83105
		internal static int __PropertyOffset_3;

		// Token: 0x040144A2 RID: 83106
		internal static int __PropertyOffset_4;

		// Token: 0x040144A3 RID: 83107
		internal static int __PropertyOffset_5;

		// Token: 0x040144A4 RID: 83108
		internal static int __PropertyOffset_6;

		// Token: 0x040144A5 RID: 83109
		internal static int __PropertyOffset_7;

		// Token: 0x040144A6 RID: 83110
		internal static int __PropertyOffset_8;

		// Token: 0x040144A7 RID: 83111
		internal static int __PropertyOffset_9;

		// Token: 0x040144A8 RID: 83112
		internal static int __PropertyOffset_10;

		// Token: 0x040144A9 RID: 83113
		internal static int __PropertyOffset_11;

		// Token: 0x040144AA RID: 83114
		private static IntPtr __UpdataSDF_NativeFunctionPtr;

		// Token: 0x040144AB RID: 83115
		private static IntPtr __Completed_6B91D0B14409837F432BB3A8D9146B00_NativeFunctionPtr;

		// Token: 0x040144AC RID: 83116
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040144AD RID: 83117
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040144AE RID: 83118
		private static IntPtr __BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A2B5 RID: 41653
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_6B91D0B14409837F432BB3A8D9146B00_FunctionParams
		{
			// Token: 0x04031FE7 RID: 204775
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x0200A2B6 RID: 41654
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FE8 RID: 204776
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2B7 RID: 41655
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_InteractBubbleSM_SM_Old_Lig_09AM_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031FE9 RID: 204777
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031FEA RID: 204778
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031FEB RID: 204779
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031FEC RID: 204780
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031FED RID: 204781
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031FEE RID: 204782
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
