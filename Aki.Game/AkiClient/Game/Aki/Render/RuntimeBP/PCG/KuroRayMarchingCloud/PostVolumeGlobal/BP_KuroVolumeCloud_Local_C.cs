using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal
{
	// Token: 0x02003C7C RID: 15484
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Local.BP_KuroVolumeCloud_Local_C")]
	[UnrealStructLayout(2048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2044)]
	public class BP_KuroVolumeCloud_Local_C : BP_KuroVolumeCloud_Global_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240B6 RID: 147638 RVA: 0x00933A25 File Offset: 0x00931C25
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeCloud_Local_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Local.BP_KuroVolumeCloud_Local_C");
			}
			return BP_KuroVolumeCloud_Local_C._ClassPtr;
		}

		// Token: 0x060240B7 RID: 147639 RVA: 0x00933A4C File Offset: 0x00931C4C
		public BP_KuroVolumeCloud_Local_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Local_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240B8 RID: 147640 RVA: 0x00933A74 File Offset: 0x00931C74
		[NullableContext(1)]
		public BP_KuroVolumeCloud_Local_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Local_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x060240B9 RID: 147641 RVA: 0x00933AA7 File Offset: 0x00931CA7
		// (set) Token: 0x060240BA RID: 147642 RVA: 0x00933ABB File Offset: 0x00931CBB
		[Nullable(2)]
		public unsafe UMaterialInstanceConstant HighCloudMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Local_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Local_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x060240BB RID: 147643 RVA: 0x00933AD0 File Offset: 0x00931CD0
		// (set) Token: 0x060240BC RID: 147644 RVA: 0x00933AE0 File Offset: 0x00931CE0
		public unsafe bool bTickInUI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x060240BD RID: 147645 RVA: 0x00933AF1 File Offset: 0x00931CF1
		// (set) Token: 0x060240BE RID: 147646 RVA: 0x00933B01 File Offset: 0x00931D01
		public unsafe bool bUseMPCRenderQueueOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x060240BF RID: 147647 RVA: 0x00933B12 File Offset: 0x00931D12
		// (set) Token: 0x060240C0 RID: 147648 RVA: 0x00933B22 File Offset: 0x00931D22
		public unsafe bool bNoTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x060240C1 RID: 147649 RVA: 0x00933B33 File Offset: 0x00931D33
		// (set) Token: 0x060240C2 RID: 147650 RVA: 0x00933B43 File Offset: 0x00931D43
		public unsafe bool bUseMaterialSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Local_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x060240C3 RID: 147651 RVA: 0x00933B54 File Offset: 0x00931D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x060240C4 RID: 147652 RVA: 0x00933B68 File Offset: 0x00931D68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060240C5 RID: 147653 RVA: 0x00933B7C File Offset: 0x00931D7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240C6 RID: 147654 RVA: 0x00933B91 File Offset: 0x00931D91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060240C7 RID: 147655 RVA: 0x00933BA5 File Offset: 0x00931DA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240C8 RID: 147656 RVA: 0x00933BBC File Offset: 0x00931DBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060240C9 RID: 147657 RVA: 0x00933C14 File Offset: 0x00931E14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060240CA RID: 147658 RVA: 0x00933C6C File Offset: 0x00931E6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Local_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060240CB RID: 147659 RVA: 0x00933CB4 File Offset: 0x00931EB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Local_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Local_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060240CC RID: 147660 RVA: 0x00933CFB File Offset: 0x00931EFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeSave_NativeFunctionPtr, null);
		}

		// Token: 0x060240CD RID: 147661 RVA: 0x00933D0F File Offset: 0x00931F0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeSave_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x00933D24 File Offset: 0x00931F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x00933D38 File Offset: 0x00931F38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x00933D4D File Offset: 0x00931F4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x00933D61 File Offset: 0x00931F61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x00933D76 File Offset: 0x00931F76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Local_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060240D3 RID: 147667 RVA: 0x00933D8A File Offset: 0x00931F8A
		protected BP_KuroVolumeCloud_Local_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D75 RID: 73077
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Local.BP_KuroVolumeCloud_Local_C";

		// Token: 0x04011D76 RID: 73078
		private static IntPtr _ClassPtr;

		// Token: 0x04011D77 RID: 73079
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D78 RID: 73080
		internal new static int __PropertyOffset_1;

		// Token: 0x04011D79 RID: 73081
		internal new static int __PropertyOffset_2;

		// Token: 0x04011D7A RID: 73082
		internal new static int __PropertyOffset_3;

		// Token: 0x04011D7B RID: 73083
		internal new static int __PropertyOffset_4;

		// Token: 0x04011D7C RID: 73084
		internal new static int __PropertyOffset_5;

		// Token: 0x04011D7D RID: 73085
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04011D7E RID: 73086
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011D7F RID: 73087
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011D80 RID: 73088
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04011D81 RID: 73089
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011D82 RID: 73090
		private static IntPtr __BeforeSave_NativeFunctionPtr;

		// Token: 0x04011D83 RID: 73091
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04011D84 RID: 73092
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x04011D85 RID: 73093
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ECA RID: 40650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x040317B7 RID: 202679
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009ECB RID: 40651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317B8 RID: 202680
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
