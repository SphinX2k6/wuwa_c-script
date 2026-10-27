using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AdsorbedGraphite
{
	// Token: 0x02003CDE RID: 15582
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AdsorbedGraphite/BP_AdsorbedGraphite.BP_AdsorbedGraphite_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1509)]
	public class BP_AdsorbedGraphite_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FFD RID: 151549 RVA: 0x0094E408 File Offset: 0x0094C608
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AdsorbedGraphite_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AdsorbedGraphite/BP_AdsorbedGraphite.BP_AdsorbedGraphite_C");
			}
			return BP_AdsorbedGraphite_C._ClassPtr;
		}

		// Token: 0x06024FFE RID: 151550 RVA: 0x0094E42C File Offset: 0x0094C62C
		public BP_AdsorbedGraphite_C() : this(BuiltinUtils.AllocNativeUObject(BP_AdsorbedGraphite_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FFF RID: 151551 RVA: 0x0094E454 File Offset: 0x0094C654
		[NullableContext(1)]
		public BP_AdsorbedGraphite_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AdsorbedGraphite_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x06025000 RID: 151552 RVA: 0x0094E487 File Offset: 0x0094C687
		// (set) Token: 0x06025001 RID: 151553 RVA: 0x0094E49B File Offset: 0x0094C69B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x06025002 RID: 151554 RVA: 0x0094E4B0 File Offset: 0x0094C6B0
		// (set) Token: 0x06025003 RID: 151555 RVA: 0x0094E4C4 File Offset: 0x0094C6C4
		public unsafe UNiagaraComponent NS_Fx_AdsorbedGraphite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x06025004 RID: 151556 RVA: 0x0094E4D9 File Offset: 0x0094C6D9
		// (set) Token: 0x06025005 RID: 151557 RVA: 0x0094E4ED File Offset: 0x0094C6ED
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x06025006 RID: 151558 RVA: 0x0094E502 File Offset: 0x0094C702
		// (set) Token: 0x06025007 RID: 151559 RVA: 0x0094E516 File Offset: 0x0094C716
		public unsafe UChildActorComponent EditorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AdsorbedGraphite_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x06025008 RID: 151560 RVA: 0x0094E52B File Offset: 0x0094C72B
		// (set) Token: 0x06025009 RID: 151561 RVA: 0x0094E53B File Offset: 0x0094C73B
		public unsafe bool UsePlayerAsTheAdsorbedCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x0602500A RID: 151562 RVA: 0x0094E54C File Offset: 0x0094C74C
		// (set) Token: 0x0602500B RID: 151563 RVA: 0x0094E560 File Offset: 0x0094C760
		public unsafe FVector AdsorbedCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x0602500C RID: 151564 RVA: 0x0094E575 File Offset: 0x0094C775
		// (set) Token: 0x0602500D RID: 151565 RVA: 0x0094E585 File Offset: 0x0094C785
		public unsafe float AdsorbedRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x0602500E RID: 151566 RVA: 0x0094E596 File Offset: 0x0094C796
		// (set) Token: 0x0602500F RID: 151567 RVA: 0x0094E5A6 File Offset: 0x0094C7A6
		public unsafe float AdsorbedIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x06025010 RID: 151568 RVA: 0x0094E5B7 File Offset: 0x0094C7B7
		// (set) Token: 0x06025011 RID: 151569 RVA: 0x0094E5C7 File Offset: 0x0094C7C7
		public unsafe float AdsorbedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x06025012 RID: 151570 RVA: 0x0094E5D8 File Offset: 0x0094C7D8
		// (set) Token: 0x06025013 RID: 151571 RVA: 0x0094E5E8 File Offset: 0x0094C7E8
		public unsafe bool bPlayerOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AdsorbedGraphite_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025014 RID: 151572 RVA: 0x0094E5F9 File Offset: 0x0094C7F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x06025015 RID: 151573 RVA: 0x0094E60D File Offset: 0x0094C80D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025016 RID: 151574 RVA: 0x0094E621 File Offset: 0x0094C821
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025017 RID: 151575 RVA: 0x0094E638 File Offset: 0x0094C838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025018 RID: 151576 RVA: 0x0094E680 File Offset: 0x0094C880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025019 RID: 151577 RVA: 0x0094E6C7 File Offset: 0x0094C8C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602501A RID: 151578 RVA: 0x0094E6DB File Offset: 0x0094C8DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x0602501B RID: 151579 RVA: 0x0094E6F0 File Offset: 0x0094C8F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602501C RID: 151580 RVA: 0x0094E748 File Offset: 0x0094C948
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602501D RID: 151581 RVA: 0x0094E7A0 File Offset: 0x0094C9A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602501E RID: 151582 RVA: 0x0094E7F8 File Offset: 0x0094C9F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AdsorbedGraphite_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602501F RID: 151583 RVA: 0x0094E84E File Offset: 0x0094CA4E
		protected BP_AdsorbedGraphite_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401266C RID: 75372
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AdsorbedGraphite/BP_AdsorbedGraphite.BP_AdsorbedGraphite_C";

		// Token: 0x0401266D RID: 75373
		private static IntPtr _ClassPtr;

		// Token: 0x0401266E RID: 75374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401266F RID: 75375
		internal static int __PropertyOffset_1;

		// Token: 0x04012670 RID: 75376
		internal static int __PropertyOffset_2;

		// Token: 0x04012671 RID: 75377
		internal static int __PropertyOffset_3;

		// Token: 0x04012672 RID: 75378
		internal static int __PropertyOffset_4;

		// Token: 0x04012673 RID: 75379
		internal static int __PropertyOffset_5;

		// Token: 0x04012674 RID: 75380
		internal static int __PropertyOffset_6;

		// Token: 0x04012675 RID: 75381
		internal static int __PropertyOffset_7;

		// Token: 0x04012676 RID: 75382
		internal static int __PropertyOffset_8;

		// Token: 0x04012677 RID: 75383
		internal static int __PropertyOffset_9;

		// Token: 0x04012678 RID: 75384
		internal static int __PropertyOffset_10;

		// Token: 0x04012679 RID: 75385
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x0401267A RID: 75386
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401267B RID: 75387
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401267C RID: 75388
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401267D RID: 75389
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x0401267E RID: 75390
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x0401267F RID: 75391
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x02009F9F RID: 40863
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319E5 RID: 203237
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FA0 RID: 40864
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x040319E6 RID: 203238
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009FA1 RID: 40865
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x040319E7 RID: 203239
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
