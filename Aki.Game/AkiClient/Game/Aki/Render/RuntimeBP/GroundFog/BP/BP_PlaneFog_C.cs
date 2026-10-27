using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GroundFog.BP
{
	// Token: 0x02003D29 RID: 15657
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_PlaneFog.BP_PlaneFog_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1132)]
	public class BP_PlaneFog_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025ABF RID: 154303 RVA: 0x0095FFB0 File Offset: 0x0095E1B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlaneFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_PlaneFog.BP_PlaneFog_C");
			}
			return BP_PlaneFog_C._ClassPtr;
		}

		// Token: 0x06025AC0 RID: 154304 RVA: 0x0095FFD4 File Offset: 0x0095E1D4
		public BP_PlaneFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlaneFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025AC1 RID: 154305 RVA: 0x0095FFFC File Offset: 0x0095E1FC
		[NullableContext(1)]
		public BP_PlaneFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlaneFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06025AC2 RID: 154306 RVA: 0x0096002F File Offset: 0x0095E22F
		// (set) Token: 0x06025AC3 RID: 154307 RVA: 0x00960043 File Offset: 0x0095E243
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x06025AC4 RID: 154308 RVA: 0x00960058 File Offset: 0x0095E258
		// (set) Token: 0x06025AC5 RID: 154309 RVA: 0x0096006C File Offset: 0x0095E26C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x06025AC6 RID: 154310 RVA: 0x00960081 File Offset: 0x0095E281
		// (set) Token: 0x06025AC7 RID: 154311 RVA: 0x00960095 File Offset: 0x0095E295
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlaneFog_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x06025AC8 RID: 154312 RVA: 0x009600AA File Offset: 0x0095E2AA
		// (set) Token: 0x06025AC9 RID: 154313 RVA: 0x009600BA File Offset: 0x0095E2BA
		public unsafe float DepthFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x06025ACA RID: 154314 RVA: 0x009600CB File Offset: 0x0095E2CB
		// (set) Token: 0x06025ACB RID: 154315 RVA: 0x009600DB File Offset: 0x0095E2DB
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x06025ACC RID: 154316 RVA: 0x009600EC File Offset: 0x0095E2EC
		// (set) Token: 0x06025ACD RID: 154317 RVA: 0x009600FC File Offset: 0x0095E2FC
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x06025ACE RID: 154318 RVA: 0x0096010D File Offset: 0x0095E30D
		// (set) Token: 0x06025ACF RID: 154319 RVA: 0x0096011D File Offset: 0x0095E31D
		public unsafe float XYRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06025AD0 RID: 154320 RVA: 0x0096012E File Offset: 0x0095E32E
		// (set) Token: 0x06025AD1 RID: 154321 RVA: 0x0096013E File Offset: 0x0095E33E
		public unsafe float TexID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06025AD2 RID: 154322 RVA: 0x0096014F File Offset: 0x0095E34F
		// (set) Token: 0x06025AD3 RID: 154323 RVA: 0x00960163 File Offset: 0x0095E363
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06025AD4 RID: 154324 RVA: 0x00960178 File Offset: 0x0095E378
		// (set) Token: 0x06025AD5 RID: 154325 RVA: 0x0096018C File Offset: 0x0095E38C
		public unsafe FLinearColor DarkColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlaneFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06025AD6 RID: 154326 RVA: 0x009601A1 File Offset: 0x0095E3A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlaneFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025AD7 RID: 154327 RVA: 0x009601B5 File Offset: 0x0095E3B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlaneFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025AD8 RID: 154328 RVA: 0x009601CA File Offset: 0x0095E3CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlaneFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025AD9 RID: 154329 RVA: 0x009601DE File Offset: 0x0095E3DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlaneFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025ADA RID: 154330 RVA: 0x009601F4 File Offset: 0x0095E3F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PlaneFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlaneFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlaneFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlaneFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlaneFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025ADB RID: 154331 RVA: 0x0096023C File Offset: 0x0095E43C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PlaneFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlaneFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlaneFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlaneFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlaneFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025ADC RID: 154332 RVA: 0x00960283 File Offset: 0x0095E483
		protected BP_PlaneFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D12 RID: 77074
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_PlaneFog.BP_PlaneFog_C";

		// Token: 0x04012D13 RID: 77075
		private static IntPtr _ClassPtr;

		// Token: 0x04012D14 RID: 77076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012D15 RID: 77077
		internal static int __PropertyOffset_1;

		// Token: 0x04012D16 RID: 77078
		internal static int __PropertyOffset_2;

		// Token: 0x04012D17 RID: 77079
		internal static int __PropertyOffset_3;

		// Token: 0x04012D18 RID: 77080
		internal static int __PropertyOffset_4;

		// Token: 0x04012D19 RID: 77081
		internal static int __PropertyOffset_5;

		// Token: 0x04012D1A RID: 77082
		internal static int __PropertyOffset_6;

		// Token: 0x04012D1B RID: 77083
		internal static int __PropertyOffset_7;

		// Token: 0x04012D1C RID: 77084
		internal static int __PropertyOffset_8;

		// Token: 0x04012D1D RID: 77085
		internal static int __PropertyOffset_9;

		// Token: 0x04012D1E RID: 77086
		internal static int __PropertyOffset_10;

		// Token: 0x04012D1F RID: 77087
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012D20 RID: 77088
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012D21 RID: 77089
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A021 RID: 40993
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ACA RID: 203466
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
