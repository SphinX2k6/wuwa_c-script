using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B24 RID: 15140
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_PointLight.BP_VolumetricFogDistFalloff_PointLight_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_VolumetricFogDistFalloff_PointLight_C : APointLight, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602151B RID: 136475 RVA: 0x008E9C2D File Offset: 0x008E7E2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricFogDistFalloff_PointLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_PointLight.BP_VolumetricFogDistFalloff_PointLight_C");
			}
			return BP_VolumetricFogDistFalloff_PointLight_C._ClassPtr;
		}

		// Token: 0x0602151C RID: 136476 RVA: 0x008E9C51 File Offset: 0x008E7E51
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricFogDistFalloff_PointLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602151D RID: 136477 RVA: 0x008E9C58 File Offset: 0x008E7E58
		public BP_VolumetricFogDistFalloff_PointLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogDistFalloff_PointLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602151E RID: 136478 RVA: 0x008E9C80 File Offset: 0x008E7E80
		[NullableContext(1)]
		public BP_VolumetricFogDistFalloff_PointLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogDistFalloff_PointLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0602151F RID: 136479 RVA: 0x008E9CB3 File Offset: 0x008E7EB3
		// (set) Token: 0x06021520 RID: 136480 RVA: 0x008E9CC7 File Offset: 0x008E7EC7
		[Nullable(2)]
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x06021521 RID: 136481 RVA: 0x008E9CDC File Offset: 0x008E7EDC
		// (set) Token: 0x06021522 RID: 136482 RVA: 0x008E9CEC File Offset: 0x008E7EEC
		public unsafe float VolumetricFogIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x06021523 RID: 136483 RVA: 0x008E9CFD File Offset: 0x008E7EFD
		// (set) Token: 0x06021524 RID: 136484 RVA: 0x008E9D0D File Offset: 0x008E7F0D
		public unsafe float DistanceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x06021525 RID: 136485 RVA: 0x008E9D1E File Offset: 0x008E7F1E
		// (set) Token: 0x06021526 RID: 136486 RVA: 0x008E9D2E File Offset: 0x008E7F2E
		public unsafe float brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x06021527 RID: 136487 RVA: 0x008E9D3F File Offset: 0x008E7F3F
		// (set) Token: 0x06021528 RID: 136488 RVA: 0x008E9D53 File Offset: 0x008E7F53
		public unsafe FVectorDouble CameraVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x06021529 RID: 136489 RVA: 0x008E9D68 File Offset: 0x008E7F68
		// (set) Token: 0x0602152A RID: 136490 RVA: 0x008E9D78 File Offset: 0x008E7F78
		public unsafe float DistanceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0602152B RID: 136491 RVA: 0x008E9D89 File Offset: 0x008E7F89
		// (set) Token: 0x0602152C RID: 136492 RVA: 0x008E9D99 File Offset: 0x008E7F99
		public unsafe float currentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_PointLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602152D RID: 136493 RVA: 0x008E9DAC File Offset: 0x008E7FAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602152E RID: 136494 RVA: 0x008E9DF4 File Offset: 0x008E7FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602152F RID: 136495 RVA: 0x008E9E3A File Offset: 0x008E803A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PointFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__PointFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06021530 RID: 136496 RVA: 0x008E9E4E File Offset: 0x008E804E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021531 RID: 136497 RVA: 0x008E9E62 File Offset: 0x008E8062
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021532 RID: 136498 RVA: 0x008E9E77 File Offset: 0x008E8077
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021533 RID: 136499 RVA: 0x008E9E8B File Offset: 0x008E808B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021534 RID: 136500 RVA: 0x008E9EA0 File Offset: 0x008E80A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021535 RID: 136501 RVA: 0x008E9EE8 File Offset: 0x008E80E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021536 RID: 136502 RVA: 0x008E9F2F File Offset: 0x008E812F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimerEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_PointLight_C.__TimerEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06021537 RID: 136503 RVA: 0x008E9F43 File Offset: 0x008E8143
		protected BP_VolumetricFogDistFalloff_PointLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010399 RID: 66457
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0401039A RID: 66458
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_PointLight.BP_VolumetricFogDistFalloff_PointLight_C";

		// Token: 0x0401039B RID: 66459
		private static IntPtr _ClassPtr;

		// Token: 0x0401039C RID: 66460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401039D RID: 66461
		internal static int __PropertyOffset_1;

		// Token: 0x0401039E RID: 66462
		internal static int __PropertyOffset_2;

		// Token: 0x0401039F RID: 66463
		internal static int __PropertyOffset_3;

		// Token: 0x040103A0 RID: 66464
		internal static int __PropertyOffset_4;

		// Token: 0x040103A1 RID: 66465
		internal static int __PropertyOffset_5;

		// Token: 0x040103A2 RID: 66466
		internal static int __PropertyOffset_6;

		// Token: 0x040103A3 RID: 66467
		internal static int __PropertyOffset_7;

		// Token: 0x040103A4 RID: 66468
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040103A5 RID: 66469
		private static IntPtr __PointFunction_NativeFunctionPtr;

		// Token: 0x040103A6 RID: 66470
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040103A7 RID: 66471
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040103A8 RID: 66472
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040103A9 RID: 66473
		private static IntPtr __TimerEvent_NativeFunctionPtr;

		// Token: 0x02009C83 RID: 40067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031341 RID: 201537
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C84 RID: 40068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031342 RID: 201538
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
