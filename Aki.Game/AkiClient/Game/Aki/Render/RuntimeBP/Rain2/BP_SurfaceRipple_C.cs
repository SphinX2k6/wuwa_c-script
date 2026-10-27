using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BC4 RID: 15300
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRipple.BP_SurfaceRipple_C")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1701)]
	public class BP_SurfaceRipple_C : AKuroSurfaceRipple, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602246A RID: 140394 RVA: 0x009043EC File Offset: 0x009025EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SurfaceRipple_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRipple.BP_SurfaceRipple_C");
			}
			return BP_SurfaceRipple_C._ClassPtr;
		}

		// Token: 0x0602246B RID: 140395 RVA: 0x00904410 File Offset: 0x00902610
		public BP_SurfaceRipple_C() : this(BuiltinUtils.AllocNativeUObject(BP_SurfaceRipple_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602246C RID: 140396 RVA: 0x00904438 File Offset: 0x00902638
		[NullableContext(1)]
		public BP_SurfaceRipple_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SurfaceRipple_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0602246D RID: 140397 RVA: 0x0090446B File Offset: 0x0090266B
		// (set) Token: 0x0602246E RID: 140398 RVA: 0x0090447F File Offset: 0x0090267F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0602246F RID: 140399 RVA: 0x00904494 File Offset: 0x00902694
		// (set) Token: 0x06022470 RID: 140400 RVA: 0x009044A8 File Offset: 0x009026A8
		public unsafe UMaterialParameterCollection Global_MPC_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x06022471 RID: 140401 RVA: 0x009044BD File Offset: 0x009026BD
		// (set) Token: 0x06022472 RID: 140402 RVA: 0x009044D1 File Offset: 0x009026D1
		public unsafe UMaterialInstanceDynamic MID_Ripple_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x06022473 RID: 140403 RVA: 0x009044E6 File Offset: 0x009026E6
		// (set) Token: 0x06022474 RID: 140404 RVA: 0x009044FA File Offset: 0x009026FA
		public unsafe UTextureRenderTarget2D RT_Ripple_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRipple_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x06022475 RID: 140405 RVA: 0x0090450F File Offset: 0x0090270F
		// (set) Token: 0x06022476 RID: 140406 RVA: 0x0090451F File Offset: 0x0090271F
		public unsafe float RainDensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x06022477 RID: 140407 RVA: 0x00904530 File Offset: 0x00902730
		// (set) Token: 0x06022478 RID: 140408 RVA: 0x00904540 File Offset: 0x00902740
		public unsafe float LastRainDensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x06022479 RID: 140409 RVA: 0x00904551 File Offset: 0x00902751
		// (set) Token: 0x0602247A RID: 140410 RVA: 0x00904561 File Offset: 0x00902761
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0602247B RID: 140411 RVA: 0x00904572 File Offset: 0x00902772
		// (set) Token: 0x0602247C RID: 140412 RVA: 0x00904582 File Offset: 0x00902782
		public unsafe float RainTimePassed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0602247D RID: 140413 RVA: 0x00904593 File Offset: 0x00902793
		// (set) Token: 0x0602247E RID: 140414 RVA: 0x009045A3 File Offset: 0x009027A3
		public unsafe float 下雨渐变最大时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0602247F RID: 140415 RVA: 0x009045B4 File Offset: 0x009027B4
		// (set) Token: 0x06022480 RID: 140416 RVA: 0x009045C8 File Offset: 0x009027C8
		public unsafe FVector4 下雨地面变化参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x06022481 RID: 140417 RVA: 0x009045DD File Offset: 0x009027DD
		// (set) Token: 0x06022482 RID: 140418 RVA: 0x009045F1 File Offset: 0x009027F1
		public unsafe FLinearColor GlobalRainGradualData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x06022483 RID: 140419 RVA: 0x00904606 File Offset: 0x00902806
		// (set) Token: 0x06022484 RID: 140420 RVA: 0x0090461A File Offset: 0x0090281A
		public unsafe FLinearColor GlobalRainLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x06022485 RID: 140421 RVA: 0x0090462F File Offset: 0x0090282F
		// (set) Token: 0x06022486 RID: 140422 RVA: 0x0090463F File Offset: 0x0090283F
		public unsafe float RainIntensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x06022487 RID: 140423 RVA: 0x00904650 File Offset: 0x00902850
		// (set) Token: 0x06022488 RID: 140424 RVA: 0x00904660 File Offset: 0x00902860
		public unsafe bool UpdateRainRT_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRipple_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022489 RID: 140425 RVA: 0x00904671 File Offset: 0x00902871
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_No_Rain_Roughness()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__Set_No_Rain_Roughness_NativeFunctionPtr, null);
		}

		// Token: 0x0602248A RID: 140426 RVA: 0x00904685 File Offset: 0x00902885
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Rain_Roughness()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__Set_Rain_Roughness_NativeFunctionPtr, null);
		}

		// Token: 0x0602248B RID: 140427 RVA: 0x00904699 File Offset: 0x00902899
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_No_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__Set_No_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x0602248C RID: 140428 RVA: 0x009046AD File Offset: 0x009028AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__Set_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x0602248D RID: 140429 RVA: 0x009046C4 File Offset: 0x009028C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateGradualData(int Index, float InputParam, ref FLinearColor GlobalRainGradualData, ref bool Vaild)
		{
			BP_SurfaceRipple_C.__UpdateGradualData_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__UpdateGradualData_FunctionParams[(UIntPtr)107] + 15L / (long)sizeof(BP_SurfaceRipple_C.__UpdateGradualData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__UpdateGradualData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->InputParam = InputParam;
			ptr->GlobalRainGradualData = GlobalRainGradualData;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__UpdateGradualData_NativeFunctionPtr, (void*)ptr);
			GlobalRainGradualData = ptr->GlobalRainGradualData;
			Vaild = ptr->Vaild;
		}

		// Token: 0x0602248E RID: 140430 RVA: 0x0090473B File Offset: 0x0090293B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602248F RID: 140431 RVA: 0x0090474F File Offset: 0x0090294F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRipple_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022490 RID: 140432 RVA: 0x00904764 File Offset: 0x00902964
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022491 RID: 140433 RVA: 0x00904778 File Offset: 0x00902978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022492 RID: 140434 RVA: 0x00904790 File Offset: 0x00902990
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SurfaceRipple_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRipple_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022493 RID: 140435 RVA: 0x009047D8 File Offset: 0x009029D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SurfaceRipple_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRipple_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022494 RID: 140436 RVA: 0x00904820 File Offset: 0x00902A20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022495 RID: 140437 RVA: 0x0090486C File Offset: 0x00902A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SurfaceRipple_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRipple_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022496 RID: 140438 RVA: 0x009048B8 File Offset: 0x00902AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SurfaceRipple_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRipple_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRipple_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022497 RID: 140439 RVA: 0x00904900 File Offset: 0x00902B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SurfaceRipple_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SurfaceRipple_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRipple_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRipple_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRipple_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022498 RID: 140440 RVA: 0x00904947 File Offset: 0x00902B47
		protected BP_SurfaceRipple_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010CD8 RID: 68824
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRipple.BP_SurfaceRipple_C";

		// Token: 0x04010CD9 RID: 68825
		private static IntPtr _ClassPtr;

		// Token: 0x04010CDA RID: 68826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010CDB RID: 68827
		internal static int __PropertyOffset_1;

		// Token: 0x04010CDC RID: 68828
		internal static int __PropertyOffset_2;

		// Token: 0x04010CDD RID: 68829
		internal static int __PropertyOffset_3;

		// Token: 0x04010CDE RID: 68830
		internal static int __PropertyOffset_4;

		// Token: 0x04010CDF RID: 68831
		internal static int __PropertyOffset_5;

		// Token: 0x04010CE0 RID: 68832
		internal static int __PropertyOffset_6;

		// Token: 0x04010CE1 RID: 68833
		internal static int __PropertyOffset_7;

		// Token: 0x04010CE2 RID: 68834
		internal static int __PropertyOffset_8;

		// Token: 0x04010CE3 RID: 68835
		internal static int __PropertyOffset_9;

		// Token: 0x04010CE4 RID: 68836
		internal static int __PropertyOffset_10;

		// Token: 0x04010CE5 RID: 68837
		internal static int __PropertyOffset_11;

		// Token: 0x04010CE6 RID: 68838
		internal static int __PropertyOffset_12;

		// Token: 0x04010CE7 RID: 68839
		internal static int __PropertyOffset_13;

		// Token: 0x04010CE8 RID: 68840
		internal static int __PropertyOffset_14;

		// Token: 0x04010CE9 RID: 68841
		private static IntPtr __Set_No_Rain_Roughness_NativeFunctionPtr;

		// Token: 0x04010CEA RID: 68842
		private static IntPtr __Set_Rain_Roughness_NativeFunctionPtr;

		// Token: 0x04010CEB RID: 68843
		private static IntPtr __Set_No_Rain_NativeFunctionPtr;

		// Token: 0x04010CEC RID: 68844
		private static IntPtr __Set_Rain_NativeFunctionPtr;

		// Token: 0x04010CED RID: 68845
		private static IntPtr __UpdateGradualData_NativeFunctionPtr;

		// Token: 0x04010CEE RID: 68846
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010CEF RID: 68847
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010CF0 RID: 68848
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010CF1 RID: 68849
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010CF2 RID: 68850
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D5F RID: 40287
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 92)]
		protected ref struct __UpdateGradualData_FunctionParams
		{
			// Token: 0x040314D9 RID: 201945
			[FieldOffset(0)]
			public int Index;

			// Token: 0x040314DA RID: 201946
			[FieldOffset(4)]
			public float InputParam;

			// Token: 0x040314DB RID: 201947
			[FieldOffset(8)]
			public FLinearColor GlobalRainGradualData;

			// Token: 0x040314DC RID: 201948
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02009D60 RID: 40288
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314DD RID: 201949
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D61 RID: 40289
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314DE RID: 201950
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009D62 RID: 40290
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314DF RID: 201951
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
