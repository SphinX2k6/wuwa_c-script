using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B10 RID: 15120
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LFPerShadow_seq.BP_LFPerShadow_seq_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1124)]
	public class BP_LFPerShadow_seq_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020FDF RID: 135135 RVA: 0x008E2084 File Offset: 0x008E0284
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LFPerShadow_seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LFPerShadow_seq.BP_LFPerShadow_seq_C");
			}
			return BP_LFPerShadow_seq_C._ClassPtr;
		}

		// Token: 0x06020FE0 RID: 135136 RVA: 0x008E20A8 File Offset: 0x008E02A8
		public BP_LFPerShadow_seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_LFPerShadow_seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020FE1 RID: 135137 RVA: 0x008E20D0 File Offset: 0x008E02D0
		[NullableContext(1)]
		public BP_LFPerShadow_seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LFPerShadow_seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x06020FE2 RID: 135138 RVA: 0x008E2103 File Offset: 0x008E0303
		// (set) Token: 0x06020FE3 RID: 135139 RVA: 0x008E2117 File Offset: 0x008E0317
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LFPerShadow_seq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LFPerShadow_seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x06020FE4 RID: 135140 RVA: 0x008E212C File Offset: 0x008E032C
		// (set) Token: 0x06020FE5 RID: 135141 RVA: 0x008E2140 File Offset: 0x008E0340
		public unsafe UMaterialParameterCollection LightFunction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LFPerShadow_seq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LFPerShadow_seq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x06020FE6 RID: 135142 RVA: 0x008E2155 File Offset: 0x008E0355
		// (set) Token: 0x06020FE7 RID: 135143 RVA: 0x008E2165 File Offset: 0x008E0365
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x06020FE8 RID: 135144 RVA: 0x008E2176 File Offset: 0x008E0376
		// (set) Token: 0x06020FE9 RID: 135145 RVA: 0x008E218A File Offset: 0x008E038A
		public unsafe FName VectorName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x06020FEA RID: 135146 RVA: 0x008E219F File Offset: 0x008E039F
		// (set) Token: 0x06020FEB RID: 135147 RVA: 0x008E21AF File Offset: 0x008E03AF
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x06020FEC RID: 135148 RVA: 0x008E21C0 File Offset: 0x008E03C0
		// (set) Token: 0x06020FED RID: 135149 RVA: 0x008E21D4 File Offset: 0x008E03D4
		public unsafe FName RotationAndOther
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x06020FEE RID: 135150 RVA: 0x008E21E9 File Offset: 0x008E03E9
		// (set) Token: 0x06020FEF RID: 135151 RVA: 0x008E21F9 File Offset: 0x008E03F9
		public unsafe float Evolutionary_rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x06020FF0 RID: 135152 RVA: 0x008E220A File Offset: 0x008E040A
		// (set) Token: 0x06020FF1 RID: 135153 RVA: 0x008E221E File Offset: 0x008E041E
		public unsafe FName EvolutionaryInten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x06020FF2 RID: 135154 RVA: 0x008E2233 File Offset: 0x008E0433
		// (set) Token: 0x06020FF3 RID: 135155 RVA: 0x008E2243 File Offset: 0x008E0443
		public unsafe float EvolutionaryIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LFPerShadow_seq_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06020FF4 RID: 135156 RVA: 0x008E2254 File Offset: 0x008E0454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LFPerShadow_seq_C.__SetMPC_NativeFunctionPtr, null);
		}

		// Token: 0x06020FF5 RID: 135157 RVA: 0x008E2268 File Offset: 0x008E0468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LFPerShadow_seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020FF6 RID: 135158 RVA: 0x008E227C File Offset: 0x008E047C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LFPerShadow_seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020FF7 RID: 135159 RVA: 0x008E2294 File Offset: 0x008E0494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LFPerShadow_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LFPerShadow_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FF8 RID: 135160 RVA: 0x008E22DC File Offset: 0x008E04DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LFPerShadow_seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LFPerShadow_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LFPerShadow_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020FF9 RID: 135161 RVA: 0x008E2323 File Offset: 0x008E0523
		protected BP_LFPerShadow_seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100AD RID: 65709
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LFPerShadow_seq.BP_LFPerShadow_seq_C";

		// Token: 0x040100AE RID: 65710
		private static IntPtr _ClassPtr;

		// Token: 0x040100AF RID: 65711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100B0 RID: 65712
		internal static int __PropertyOffset_1;

		// Token: 0x040100B1 RID: 65713
		internal static int __PropertyOffset_2;

		// Token: 0x040100B2 RID: 65714
		internal static int __PropertyOffset_3;

		// Token: 0x040100B3 RID: 65715
		internal static int __PropertyOffset_4;

		// Token: 0x040100B4 RID: 65716
		internal static int __PropertyOffset_5;

		// Token: 0x040100B5 RID: 65717
		internal static int __PropertyOffset_6;

		// Token: 0x040100B6 RID: 65718
		internal static int __PropertyOffset_7;

		// Token: 0x040100B7 RID: 65719
		internal static int __PropertyOffset_8;

		// Token: 0x040100B8 RID: 65720
		internal static int __PropertyOffset_9;

		// Token: 0x040100B9 RID: 65721
		private static IntPtr __SetMPC_NativeFunctionPtr;

		// Token: 0x040100BA RID: 65722
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040100BB RID: 65723
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C57 RID: 40023
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031313 RID: 201491
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
