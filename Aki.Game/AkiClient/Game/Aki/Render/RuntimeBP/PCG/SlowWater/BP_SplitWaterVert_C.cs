using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SlowWater
{
	// Token: 0x02003BFB RID: 15355
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SplitWaterVert.BP_SplitWaterVert_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1540)]
	public class BP_SplitWaterVert_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022EE1 RID: 143073 RVA: 0x00916210 File Offset: 0x00914410
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitWaterVert_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SplitWaterVert.BP_SplitWaterVert_C");
			}
			return BP_SplitWaterVert_C._ClassPtr;
		}

		// Token: 0x06022EE2 RID: 143074 RVA: 0x00916234 File Offset: 0x00914434
		public BP_SplitWaterVert_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitWaterVert_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022EE3 RID: 143075 RVA: 0x0091625C File Offset: 0x0091445C
		[NullableContext(1)]
		public BP_SplitWaterVert_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitWaterVert_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x06022EE4 RID: 143076 RVA: 0x0091628F File Offset: 0x0091448F
		// (set) Token: 0x06022EE5 RID: 143077 RVA: 0x009162A3 File Offset: 0x009144A3
		public unsafe UStaticMeshComponent SM_SlowWater4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x06022EE6 RID: 143078 RVA: 0x009162B8 File Offset: 0x009144B8
		// (set) Token: 0x06022EE7 RID: 143079 RVA: 0x009162CC File Offset: 0x009144CC
		public unsafe UStaticMeshComponent SM_SlowWater5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x06022EE8 RID: 143080 RVA: 0x009162E1 File Offset: 0x009144E1
		// (set) Token: 0x06022EE9 RID: 143081 RVA: 0x009162F5 File Offset: 0x009144F5
		public unsafe UStaticMeshComponent SM_SlowWater3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x06022EEA RID: 143082 RVA: 0x0091630A File Offset: 0x0091450A
		// (set) Token: 0x06022EEB RID: 143083 RVA: 0x0091631E File Offset: 0x0091451E
		public unsafe UStaticMeshComponent SM_SlowWater2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x06022EEC RID: 143084 RVA: 0x00916333 File Offset: 0x00914533
		// (set) Token: 0x06022EED RID: 143085 RVA: 0x00916347 File Offset: 0x00914547
		public unsafe UStaticMeshComponent SM_SlowWater1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x06022EEE RID: 143086 RVA: 0x0091635C File Offset: 0x0091455C
		// (set) Token: 0x06022EEF RID: 143087 RVA: 0x00916370 File Offset: 0x00914570
		public unsafe UStaticMeshComponent SM_SlowWater
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x06022EF0 RID: 143088 RVA: 0x00916385 File Offset: 0x00914585
		// (set) Token: 0x06022EF1 RID: 143089 RVA: 0x00916399 File Offset: 0x00914599
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitWaterVert_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x06022EF2 RID: 143090 RVA: 0x009163AE File Offset: 0x009145AE
		// (set) Token: 0x06022EF3 RID: 143091 RVA: 0x009163BE File Offset: 0x009145BE
		public unsafe bool EnableTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x06022EF4 RID: 143092 RVA: 0x009163CF File Offset: 0x009145CF
		// (set) Token: 0x06022EF5 RID: 143093 RVA: 0x009163DF File Offset: 0x009145DF
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x06022EF6 RID: 143094 RVA: 0x009163F0 File Offset: 0x009145F0
		// (set) Token: 0x06022EF7 RID: 143095 RVA: 0x00916400 File Offset: 0x00914600
		public unsafe float CustomTimeFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x06022EF8 RID: 143096 RVA: 0x00916411 File Offset: 0x00914611
		// (set) Token: 0x06022EF9 RID: 143097 RVA: 0x00916421 File Offset: 0x00914621
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x06022EFA RID: 143098 RVA: 0x00916432 File Offset: 0x00914632
		// (set) Token: 0x06022EFB RID: 143099 RVA: 0x00916442 File Offset: 0x00914642
		public unsafe float Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x06022EFC RID: 143100 RVA: 0x00916453 File Offset: 0x00914653
		// (set) Token: 0x06022EFD RID: 143101 RVA: 0x00916463 File Offset: 0x00914663
		public unsafe float LocalSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x06022EFE RID: 143102 RVA: 0x00916474 File Offset: 0x00914674
		// (set) Token: 0x06022EFF RID: 143103 RVA: 0x00916484 File Offset: 0x00914684
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitWaterVert_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06022F00 RID: 143104 RVA: 0x00916498 File Offset: 0x00914698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplitWaterVert_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitWaterVert_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitWaterVert_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitWaterVert_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitWaterVert_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022F01 RID: 143105 RVA: 0x009164E0 File Offset: 0x009146E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplitWaterVert_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitWaterVert_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitWaterVert_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitWaterVert_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitWaterVert_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022F02 RID: 143106 RVA: 0x00916528 File Offset: 0x00914728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplitWaterVert_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitWaterVert_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitWaterVert_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitWaterVert_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitWaterVert_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022F03 RID: 143107 RVA: 0x00916570 File Offset: 0x00914770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplitWaterVert_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitWaterVert_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitWaterVert_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitWaterVert_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitWaterVert_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022F04 RID: 143108 RVA: 0x009165B7 File Offset: 0x009147B7
		protected BP_SplitWaterVert_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011313 RID: 70419
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SlowWater/BP_SplitWaterVert.BP_SplitWaterVert_C";

		// Token: 0x04011314 RID: 70420
		private static IntPtr _ClassPtr;

		// Token: 0x04011315 RID: 70421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011316 RID: 70422
		internal static int __PropertyOffset_1;

		// Token: 0x04011317 RID: 70423
		internal static int __PropertyOffset_2;

		// Token: 0x04011318 RID: 70424
		internal static int __PropertyOffset_3;

		// Token: 0x04011319 RID: 70425
		internal static int __PropertyOffset_4;

		// Token: 0x0401131A RID: 70426
		internal static int __PropertyOffset_5;

		// Token: 0x0401131B RID: 70427
		internal static int __PropertyOffset_6;

		// Token: 0x0401131C RID: 70428
		internal static int __PropertyOffset_7;

		// Token: 0x0401131D RID: 70429
		internal static int __PropertyOffset_8;

		// Token: 0x0401131E RID: 70430
		internal static int __PropertyOffset_9;

		// Token: 0x0401131F RID: 70431
		internal static int __PropertyOffset_10;

		// Token: 0x04011320 RID: 70432
		internal static int __PropertyOffset_11;

		// Token: 0x04011321 RID: 70433
		internal static int __PropertyOffset_12;

		// Token: 0x04011322 RID: 70434
		internal static int __PropertyOffset_13;

		// Token: 0x04011323 RID: 70435
		internal static int __PropertyOffset_14;

		// Token: 0x04011324 RID: 70436
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011325 RID: 70437
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009DF3 RID: 40435
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403160E RID: 202254
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DF4 RID: 40436
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403160F RID: 202255
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
