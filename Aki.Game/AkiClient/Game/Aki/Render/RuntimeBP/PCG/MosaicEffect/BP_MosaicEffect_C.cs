using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MosaicEffect
{
	// Token: 0x02003C4E RID: 15438
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MosaicEffect/BP_MosaicEffect.BP_MosaicEffect_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1481)]
	public class BP_MosaicEffect_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023C5E RID: 146526 RVA: 0x0092C6BC File Offset: 0x0092A8BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MosaicEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MosaicEffect/BP_MosaicEffect.BP_MosaicEffect_C");
			}
			return BP_MosaicEffect_C._ClassPtr;
		}

		// Token: 0x06023C5F RID: 146527 RVA: 0x0092C6E0 File Offset: 0x0092A8E0
		public BP_MosaicEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_MosaicEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023C60 RID: 146528 RVA: 0x0092C708 File Offset: 0x0092A908
		[NullableContext(1)]
		public BP_MosaicEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MosaicEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x06023C61 RID: 146529 RVA: 0x0092C73B File Offset: 0x0092A93B
		// (set) Token: 0x06023C62 RID: 146530 RVA: 0x0092C74F File Offset: 0x0092A94F
		public unsafe UNiagaraComponent NS_Fx_MosaicEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x06023C63 RID: 146531 RVA: 0x0092C764 File Offset: 0x0092A964
		// (set) Token: 0x06023C64 RID: 146532 RVA: 0x0092C778 File Offset: 0x0092A978
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x06023C65 RID: 146533 RVA: 0x0092C78D File Offset: 0x0092A98D
		// (set) Token: 0x06023C66 RID: 146534 RVA: 0x0092C7A1 File Offset: 0x0092A9A1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x06023C67 RID: 146535 RVA: 0x0092C7B6 File Offset: 0x0092A9B6
		// (set) Token: 0x06023C68 RID: 146536 RVA: 0x0092C7CA File Offset: 0x0092A9CA
		public unsafe PCG_RoadSpline_C RoadSpline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PCG_RoadSpline_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MosaicEffect_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x06023C69 RID: 146537 RVA: 0x0092C7DF File Offset: 0x0092A9DF
		// (set) Token: 0x06023C6A RID: 146538 RVA: 0x0092C7EF File Offset: 0x0092A9EF
		public unsafe bool bPlayerOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MosaicEffect_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MosaicEffect_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023C6B RID: 146539 RVA: 0x0092C800 File Offset: 0x0092AA00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MosaicEffect_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023C6C RID: 146540 RVA: 0x0092C814 File Offset: 0x0092AA14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MosaicEffect_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C6D RID: 146541 RVA: 0x0092C829 File Offset: 0x0092AA29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023C6E RID: 146542 RVA: 0x0092C83D File Offset: 0x0092AA3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C6F RID: 146543 RVA: 0x0092C854 File Offset: 0x0092AA54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MosaicEffect_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C70 RID: 146544 RVA: 0x0092C8AC File Offset: 0x0092AAAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_MosaicEffect_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MosaicEffect_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C71 RID: 146545 RVA: 0x0092C904 File Offset: 0x0092AB04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MosaicEffect_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C72 RID: 146546 RVA: 0x0092C95C File Offset: 0x0092AB5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_MosaicEffect_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MosaicEffect_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MosaicEffect_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C73 RID: 146547 RVA: 0x0092C9B2 File Offset: 0x0092ABB2
		protected BP_MosaicEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AE1 RID: 72417
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MosaicEffect/BP_MosaicEffect.BP_MosaicEffect_C";

		// Token: 0x04011AE2 RID: 72418
		private static IntPtr _ClassPtr;

		// Token: 0x04011AE3 RID: 72419
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AE4 RID: 72420
		internal static int __PropertyOffset_1;

		// Token: 0x04011AE5 RID: 72421
		internal static int __PropertyOffset_2;

		// Token: 0x04011AE6 RID: 72422
		internal static int __PropertyOffset_3;

		// Token: 0x04011AE7 RID: 72423
		internal static int __PropertyOffset_4;

		// Token: 0x04011AE8 RID: 72424
		internal static int __PropertyOffset_5;

		// Token: 0x04011AE9 RID: 72425
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011AEA RID: 72426
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011AEB RID: 72427
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04011AEC RID: 72428
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x02009E9D RID: 40605
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031763 RID: 202595
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009E9E RID: 40606
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04031764 RID: 202596
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
