using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B25 RID: 15141
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_RectLight.BP_VolumetricFogDistFalloff_RectLight_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1124)]
	public class BP_VolumetricFogDistFalloff_RectLight_C : ARectLight, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021538 RID: 136504 RVA: 0x008E9F4C File Offset: 0x008E814C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricFogDistFalloff_RectLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_RectLight.BP_VolumetricFogDistFalloff_RectLight_C");
			}
			return BP_VolumetricFogDistFalloff_RectLight_C._ClassPtr;
		}

		// Token: 0x06021539 RID: 136505 RVA: 0x008E9F70 File Offset: 0x008E8170
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricFogDistFalloff_RectLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602153A RID: 136506 RVA: 0x008E9F78 File Offset: 0x008E8178
		public BP_VolumetricFogDistFalloff_RectLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogDistFalloff_RectLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602153B RID: 136507 RVA: 0x008E9FA0 File Offset: 0x008E81A0
		[NullableContext(1)]
		public BP_VolumetricFogDistFalloff_RectLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricFogDistFalloff_RectLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0602153C RID: 136508 RVA: 0x008E9FD3 File Offset: 0x008E81D3
		// (set) Token: 0x0602153D RID: 136509 RVA: 0x008E9FE3 File Offset: 0x008E81E3
		public unsafe float VolumetricFogIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0602153E RID: 136510 RVA: 0x008E9FF4 File Offset: 0x008E81F4
		// (set) Token: 0x0602153F RID: 136511 RVA: 0x008EA004 File Offset: 0x008E8204
		public unsafe float brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x06021540 RID: 136512 RVA: 0x008EA015 File Offset: 0x008E8215
		// (set) Token: 0x06021541 RID: 136513 RVA: 0x008EA029 File Offset: 0x008E8229
		public unsafe FVectorDouble CameraVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x06021542 RID: 136514 RVA: 0x008EA03E File Offset: 0x008E823E
		// (set) Token: 0x06021543 RID: 136515 RVA: 0x008EA04E File Offset: 0x008E824E
		public unsafe float currentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x06021544 RID: 136516 RVA: 0x008EA05F File Offset: 0x008E825F
		// (set) Token: 0x06021545 RID: 136517 RVA: 0x008EA06F File Offset: 0x008E826F
		public unsafe float DistanceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x06021546 RID: 136518 RVA: 0x008EA080 File Offset: 0x008E8280
		// (set) Token: 0x06021547 RID: 136519 RVA: 0x008EA090 File Offset: 0x008E8290
		public unsafe float DistanceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricFogDistFalloff_RectLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06021548 RID: 136520 RVA: 0x008EA0A4 File Offset: 0x008E82A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021549 RID: 136521 RVA: 0x008EA0EC File Offset: 0x008E82EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602154A RID: 136522 RVA: 0x008EA132 File Offset: 0x008E8332
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RectLightFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__RectLightFunction_NativeFunctionPtr, null);
		}

		// Token: 0x0602154B RID: 136523 RVA: 0x008EA146 File Offset: 0x008E8346
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602154C RID: 136524 RVA: 0x008EA15A File Offset: 0x008E835A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602154D RID: 136525 RVA: 0x008EA16F File Offset: 0x008E836F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602154E RID: 136526 RVA: 0x008EA183 File Offset: 0x008E8383
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602154F RID: 136527 RVA: 0x008EA198 File Offset: 0x008E8398
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021550 RID: 136528 RVA: 0x008EA1E0 File Offset: 0x008E83E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021551 RID: 136529 RVA: 0x008EA227 File Offset: 0x008E8427
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimerEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricFogDistFalloff_RectLight_C.__TimerEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06021552 RID: 136530 RVA: 0x008EA23B File Offset: 0x008E843B
		protected BP_VolumetricFogDistFalloff_RectLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103AA RID: 66474
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040103AB RID: 66475
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricFogDistFalloff_RectLight.BP_VolumetricFogDistFalloff_RectLight_C";

		// Token: 0x040103AC RID: 66476
		private static IntPtr _ClassPtr;

		// Token: 0x040103AD RID: 66477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103AE RID: 66478
		internal static int __PropertyOffset_1;

		// Token: 0x040103AF RID: 66479
		internal static int __PropertyOffset_2;

		// Token: 0x040103B0 RID: 66480
		internal static int __PropertyOffset_3;

		// Token: 0x040103B1 RID: 66481
		internal static int __PropertyOffset_4;

		// Token: 0x040103B2 RID: 66482
		internal static int __PropertyOffset_5;

		// Token: 0x040103B3 RID: 66483
		internal static int __PropertyOffset_6;

		// Token: 0x040103B4 RID: 66484
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040103B5 RID: 66485
		private static IntPtr __RectLightFunction_NativeFunctionPtr;

		// Token: 0x040103B6 RID: 66486
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040103B7 RID: 66487
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040103B8 RID: 66488
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040103B9 RID: 66489
		private static IntPtr __TimerEvent_NativeFunctionPtr;

		// Token: 0x02009C85 RID: 40069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031343 RID: 201539
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C86 RID: 40070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031344 RID: 201540
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
