using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B26 RID: 15142
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogFalloff_SpotLight.BP_VolumetricFogFalloff_SpotLight_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class BP_VolumetricFogFalloff_SpotLight_C : ASpotLight, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021553 RID: 136531 RVA: 0x008EA244 File Offset: 0x008E8444
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricFogFalloff_SpotLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogFalloff_SpotLight.BP_VolumetricFogFalloff_SpotLight_C");
			}
			return BP_VolumetricFogFalloff_SpotLight_C._ClassPtr;
		}

		// Token: 0x06021554 RID: 136532 RVA: 0x008EA268 File Offset: 0x008E8468
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricFogFalloff_SpotLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06021555 RID: 136533 RVA: 0x008EA270 File Offset: 0x008E8470
		public BP_VolumetricFogFalloff_SpotLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogFalloff_SpotLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021556 RID: 136534 RVA: 0x008EA298 File Offset: 0x008E8498
		[NullableContext(1)]
		public BP_VolumetricFogFalloff_SpotLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogFalloff_SpotLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x06021557 RID: 136535 RVA: 0x008EA2CB File Offset: 0x008E84CB
		// (set) Token: 0x06021558 RID: 136536 RVA: 0x008EA2DF File Offset: 0x008E84DF
		[Nullable(2)]
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x06021559 RID: 136537 RVA: 0x008EA2F4 File Offset: 0x008E84F4
		// (set) Token: 0x0602155A RID: 136538 RVA: 0x008EA304 File Offset: 0x008E8504
		public unsafe float VolumetricFogIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0602155B RID: 136539 RVA: 0x008EA315 File Offset: 0x008E8515
		// (set) Token: 0x0602155C RID: 136540 RVA: 0x008EA325 File Offset: 0x008E8525
		public unsafe float currentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0602155D RID: 136541 RVA: 0x008EA336 File Offset: 0x008E8536
		// (set) Token: 0x0602155E RID: 136542 RVA: 0x008EA346 File Offset: 0x008E8546
		public unsafe float brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0602155F RID: 136543 RVA: 0x008EA357 File Offset: 0x008E8557
		// (set) Token: 0x06021560 RID: 136544 RVA: 0x008EA36B File Offset: 0x008E856B
		public unsafe FVectorDouble CameraVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x06021561 RID: 136545 RVA: 0x008EA380 File Offset: 0x008E8580
		// (set) Token: 0x06021562 RID: 136546 RVA: 0x008EA390 File Offset: 0x008E8590
		public unsafe float DistanceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x06021563 RID: 136547 RVA: 0x008EA3A1 File Offset: 0x008E85A1
		// (set) Token: 0x06021564 RID: 136548 RVA: 0x008EA3B1 File Offset: 0x008E85B1
		public unsafe float DistanceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogFalloff_SpotLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06021565 RID: 136549 RVA: 0x008EA3C4 File Offset: 0x008E85C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021566 RID: 136550 RVA: 0x008EA40C File Offset: 0x008E860C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021567 RID: 136551 RVA: 0x008EA452 File Offset: 0x008E8652
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SpotLightFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__SpotLightFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06021568 RID: 136552 RVA: 0x008EA466 File Offset: 0x008E8666
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021569 RID: 136553 RVA: 0x008EA47A File Offset: 0x008E867A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602156A RID: 136554 RVA: 0x008EA48F File Offset: 0x008E868F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602156B RID: 136555 RVA: 0x008EA4A3 File Offset: 0x008E86A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602156C RID: 136556 RVA: 0x008EA4B8 File Offset: 0x008E86B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602156D RID: 136557 RVA: 0x008EA500 File Offset: 0x008E8700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602156E RID: 136558 RVA: 0x008EA547 File Offset: 0x008E8747
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimerEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogFalloff_SpotLight_C.__TimerEvent_NativeFunctionPtr, null);
		}

		// Token: 0x0602156F RID: 136559 RVA: 0x008EA55B File Offset: 0x008E875B
		protected BP_VolumetricFogFalloff_SpotLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103BA RID: 66490
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040103BB RID: 66491
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogFalloff_SpotLight.BP_VolumetricFogFalloff_SpotLight_C";

		// Token: 0x040103BC RID: 66492
		private static IntPtr _ClassPtr;

		// Token: 0x040103BD RID: 66493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103BE RID: 66494
		internal static int __PropertyOffset_1;

		// Token: 0x040103BF RID: 66495
		internal static int __PropertyOffset_2;

		// Token: 0x040103C0 RID: 66496
		internal static int __PropertyOffset_3;

		// Token: 0x040103C1 RID: 66497
		internal static int __PropertyOffset_4;

		// Token: 0x040103C2 RID: 66498
		internal static int __PropertyOffset_5;

		// Token: 0x040103C3 RID: 66499
		internal static int __PropertyOffset_6;

		// Token: 0x040103C4 RID: 66500
		internal static int __PropertyOffset_7;

		// Token: 0x040103C5 RID: 66501
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040103C6 RID: 66502
		private static IntPtr __SpotLightFunction_NativeFunctionPtr;

		// Token: 0x040103C7 RID: 66503
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040103C8 RID: 66504
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040103C9 RID: 66505
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040103CA RID: 66506
		private static IntPtr __TimerEvent_NativeFunctionPtr;

		// Token: 0x02009C87 RID: 40071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031345 RID: 201541
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C88 RID: 40072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031346 RID: 201542
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
