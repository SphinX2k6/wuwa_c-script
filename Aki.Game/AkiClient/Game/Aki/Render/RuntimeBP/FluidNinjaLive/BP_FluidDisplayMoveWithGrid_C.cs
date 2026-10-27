using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D87 RID: 15751
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_FluidDisplayMoveWithGrid.BP_FluidDisplayMoveWithGrid_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_FluidDisplayMoveWithGrid_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B8B RID: 158603 RVA: 0x0097CEF4 File Offset: 0x0097B0F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FluidDisplayMoveWithGrid_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_FluidDisplayMoveWithGrid.BP_FluidDisplayMoveWithGrid_C");
			}
			return BP_FluidDisplayMoveWithGrid_C._ClassPtr;
		}

		// Token: 0x06026B8C RID: 158604 RVA: 0x0097CF18 File Offset: 0x0097B118
		public BP_FluidDisplayMoveWithGrid_C() : this(BuiltinUtils.AllocNativeUObject(BP_FluidDisplayMoveWithGrid_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B8D RID: 158605 RVA: 0x0097CF40 File Offset: 0x0097B140
		[NullableContext(1)]
		public BP_FluidDisplayMoveWithGrid_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FluidDisplayMoveWithGrid_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x06026B8E RID: 158606 RVA: 0x0097CF73 File Offset: 0x0097B173
		// (set) Token: 0x06026B8F RID: 158607 RVA: 0x0097CF87 File Offset: 0x0097B187
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x06026B90 RID: 158608 RVA: 0x0097CF9C File Offset: 0x0097B19C
		// (set) Token: 0x06026B91 RID: 158609 RVA: 0x0097CFB0 File Offset: 0x0097B1B0
		public unsafe AActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x06026B92 RID: 158610 RVA: 0x0097CFC5 File Offset: 0x0097B1C5
		// (set) Token: 0x06026B93 RID: 158611 RVA: 0x0097CFD9 File Offset: 0x0097B1D9
		public unsafe NinjaLive_C TargetNinjaLive
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLive_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x06026B94 RID: 158612 RVA: 0x0097CFEE File Offset: 0x0097B1EE
		// (set) Token: 0x06026B95 RID: 158613 RVA: 0x0097CFFE File Offset: 0x0097B1FE
		public unsafe bool bUseGridFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x06026B96 RID: 158614 RVA: 0x0097D00F File Offset: 0x0097B20F
		// (set) Token: 0x06026B97 RID: 158615 RVA: 0x0097D01F File Offset: 0x0097B21F
		public unsafe bool bDisable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x06026B98 RID: 158616 RVA: 0x0097D030 File Offset: 0x0097B230
		// (set) Token: 0x06026B99 RID: 158617 RVA: 0x0097D040 File Offset: 0x0097B240
		public unsafe float ValidDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x06026B9A RID: 158618 RVA: 0x0097D051 File Offset: 0x0097B251
		// (set) Token: 0x06026B9B RID: 158619 RVA: 0x0097D065 File Offset: 0x0097B265
		public unsafe FVectorDouble rawPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FluidDisplayMoveWithGrid_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06026B9C RID: 158620 RVA: 0x0097D07A File Offset: 0x0097B27A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026B9D RID: 158621 RVA: 0x0097D08E File Offset: 0x0097B28E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B9E RID: 158622 RVA: 0x0097D0A4 File Offset: 0x0097B2A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B9F RID: 158623 RVA: 0x0097D0EC File Offset: 0x0097B2EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026BA0 RID: 158624 RVA: 0x0097D134 File Offset: 0x0097B334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026BA1 RID: 158625 RVA: 0x0097D180 File Offset: 0x0097B380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FluidDisplayMoveWithGrid_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026BA2 RID: 158626 RVA: 0x0097D1CC File Offset: 0x0097B3CC
		protected BP_FluidDisplayMoveWithGrid_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013795 RID: 79765
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/BP_FluidDisplayMoveWithGrid.BP_FluidDisplayMoveWithGrid_C";

		// Token: 0x04013796 RID: 79766
		private static IntPtr _ClassPtr;

		// Token: 0x04013797 RID: 79767
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013798 RID: 79768
		internal static int __PropertyOffset_1;

		// Token: 0x04013799 RID: 79769
		internal static int __PropertyOffset_2;

		// Token: 0x0401379A RID: 79770
		internal static int __PropertyOffset_3;

		// Token: 0x0401379B RID: 79771
		internal static int __PropertyOffset_4;

		// Token: 0x0401379C RID: 79772
		internal static int __PropertyOffset_5;

		// Token: 0x0401379D RID: 79773
		internal static int __PropertyOffset_6;

		// Token: 0x0401379E RID: 79774
		internal static int __PropertyOffset_7;

		// Token: 0x0401379F RID: 79775
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040137A0 RID: 79776
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040137A1 RID: 79777
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A14D RID: 41293
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CF4 RID: 204020
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A14E RID: 41294
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031CF5 RID: 204021
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
