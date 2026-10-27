using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GaussianSplatting
{
	// Token: 0x02003CC1 RID: 15553
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GaussianSplatting/BP_GaussianSplatting.BP_GaussianSplatting_C")]
	[UnrealStructLayout(1504, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1500)]
	public class BP_GaussianSplatting_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C19 RID: 150553 RVA: 0x0094771A File Offset: 0x0094591A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GaussianSplatting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GaussianSplatting/BP_GaussianSplatting.BP_GaussianSplatting_C");
			}
			return BP_GaussianSplatting_C._ClassPtr;
		}

		// Token: 0x06024C1A RID: 150554 RVA: 0x00947740 File Offset: 0x00945940
		public BP_GaussianSplatting_C() : this(BuiltinUtils.AllocNativeUObject(BP_GaussianSplatting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C1B RID: 150555 RVA: 0x00947768 File Offset: 0x00945968
		[NullableContext(1)]
		public BP_GaussianSplatting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GaussianSplatting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x06024C1C RID: 150556 RVA: 0x0094779B File Offset: 0x0094599B
		// (set) Token: 0x06024C1D RID: 150557 RVA: 0x009477AF File Offset: 0x009459AF
		public unsafe UNiagaraComponent NS_Fx_GaussianSplatting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GaussianSplatting_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GaussianSplatting_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x06024C1E RID: 150558 RVA: 0x009477C4 File Offset: 0x009459C4
		// (set) Token: 0x06024C1F RID: 150559 RVA: 0x009477D8 File Offset: 0x009459D8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GaussianSplatting_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GaussianSplatting_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06024C20 RID: 150560 RVA: 0x009477ED File Offset: 0x009459ED
		// (set) Token: 0x06024C21 RID: 150561 RVA: 0x00947801 File Offset: 0x00945A01
		public unsafe FVector4 GaussianSplattingParams
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x06024C22 RID: 150562 RVA: 0x00947816 File Offset: 0x00945A16
		// (set) Token: 0x06024C23 RID: 150563 RVA: 0x00947826 File Offset: 0x00945A26
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x06024C24 RID: 150564 RVA: 0x00947837 File Offset: 0x00945A37
		// (set) Token: 0x06024C25 RID: 150565 RVA: 0x00947847 File Offset: 0x00945A47
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x06024C26 RID: 150566 RVA: 0x00947858 File Offset: 0x00945A58
		// (set) Token: 0x06024C27 RID: 150567 RVA: 0x00947868 File Offset: 0x00945A68
		public unsafe float ParticleScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GaussianSplatting_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06024C28 RID: 150568 RVA: 0x00947879 File Offset: 0x00945A79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GaussianSplatting_C.__SetParams_NativeFunctionPtr, null);
		}

		// Token: 0x06024C29 RID: 150569 RVA: 0x0094788D File Offset: 0x00945A8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GaussianSplatting_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024C2A RID: 150570 RVA: 0x009478A1 File Offset: 0x00945AA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GaussianSplatting_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C2B RID: 150571 RVA: 0x009478B8 File Offset: 0x00945AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GaussianSplatting_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GaussianSplatting_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GaussianSplatting_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GaussianSplatting_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GaussianSplatting_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024C2C RID: 150572 RVA: 0x00947900 File Offset: 0x00945B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GaussianSplatting_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GaussianSplatting_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GaussianSplatting_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GaussianSplatting_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GaussianSplatting_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024C2D RID: 150573 RVA: 0x00947947 File Offset: 0x00945B47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GaussianSplatting_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x06024C2E RID: 150574 RVA: 0x0094795B File Offset: 0x00945B5B
		protected BP_GaussianSplatting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401242F RID: 74799
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GaussianSplatting/BP_GaussianSplatting.BP_GaussianSplatting_C";

		// Token: 0x04012430 RID: 74800
		private static IntPtr _ClassPtr;

		// Token: 0x04012431 RID: 74801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012432 RID: 74802
		internal static int __PropertyOffset_1;

		// Token: 0x04012433 RID: 74803
		internal static int __PropertyOffset_2;

		// Token: 0x04012434 RID: 74804
		internal static int __PropertyOffset_3;

		// Token: 0x04012435 RID: 74805
		internal static int __PropertyOffset_4;

		// Token: 0x04012436 RID: 74806
		internal static int __PropertyOffset_5;

		// Token: 0x04012437 RID: 74807
		internal static int __PropertyOffset_6;

		// Token: 0x04012438 RID: 74808
		private static IntPtr __SetParams_NativeFunctionPtr;

		// Token: 0x04012439 RID: 74809
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401243A RID: 74810
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401243B RID: 74811
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x02009F65 RID: 40805
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403195B RID: 203099
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
