using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BC3 RID: 15299
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRippleGachaScene.BP_SurfaceRippleGachaScene_C")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1701)]
	public class BP_SurfaceRippleGachaScene_C : AKuroSurfaceRipple, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022439 RID: 140345 RVA: 0x00903E60 File Offset: 0x00902060
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SurfaceRippleGachaScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRippleGachaScene.BP_SurfaceRippleGachaScene_C");
			}
			return BP_SurfaceRippleGachaScene_C._ClassPtr;
		}

		// Token: 0x0602243A RID: 140346 RVA: 0x00903E84 File Offset: 0x00902084
		public BP_SurfaceRippleGachaScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_SurfaceRippleGachaScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602243B RID: 140347 RVA: 0x00903EAC File Offset: 0x009020AC
		[NullableContext(1)]
		public BP_SurfaceRippleGachaScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SurfaceRippleGachaScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x0602243C RID: 140348 RVA: 0x00903EDF File Offset: 0x009020DF
		// (set) Token: 0x0602243D RID: 140349 RVA: 0x00903EF3 File Offset: 0x009020F3
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x0602243E RID: 140350 RVA: 0x00903F08 File Offset: 0x00902108
		// (set) Token: 0x0602243F RID: 140351 RVA: 0x00903F1C File Offset: 0x0090211C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x06022440 RID: 140352 RVA: 0x00903F31 File Offset: 0x00902131
		// (set) Token: 0x06022441 RID: 140353 RVA: 0x00903F45 File Offset: 0x00902145
		public unsafe UMaterialParameterCollection Global_MPC_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x06022442 RID: 140354 RVA: 0x00903F5A File Offset: 0x0090215A
		// (set) Token: 0x06022443 RID: 140355 RVA: 0x00903F6E File Offset: 0x0090216E
		public unsafe UMaterialInstanceDynamic MID_Ripple_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x06022444 RID: 140356 RVA: 0x00903F83 File Offset: 0x00902183
		// (set) Token: 0x06022445 RID: 140357 RVA: 0x00903F97 File Offset: 0x00902197
		public unsafe UTextureRenderTarget2D RT_Ripple_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SurfaceRippleGachaScene_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x06022446 RID: 140358 RVA: 0x00903FAC File Offset: 0x009021AC
		// (set) Token: 0x06022447 RID: 140359 RVA: 0x00903FBC File Offset: 0x009021BC
		public unsafe float RainDensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x06022448 RID: 140360 RVA: 0x00903FCD File Offset: 0x009021CD
		// (set) Token: 0x06022449 RID: 140361 RVA: 0x00903FDD File Offset: 0x009021DD
		public unsafe float LastRainDensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0602244A RID: 140362 RVA: 0x00903FEE File Offset: 0x009021EE
		// (set) Token: 0x0602244B RID: 140363 RVA: 0x00903FFE File Offset: 0x009021FE
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0602244C RID: 140364 RVA: 0x0090400F File Offset: 0x0090220F
		// (set) Token: 0x0602244D RID: 140365 RVA: 0x0090401F File Offset: 0x0090221F
		public unsafe float RainTimePassed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0602244E RID: 140366 RVA: 0x00904030 File Offset: 0x00902230
		// (set) Token: 0x0602244F RID: 140367 RVA: 0x00904040 File Offset: 0x00902240
		public unsafe float 下雨渐变最大时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x06022450 RID: 140368 RVA: 0x00904051 File Offset: 0x00902251
		// (set) Token: 0x06022451 RID: 140369 RVA: 0x00904065 File Offset: 0x00902265
		public unsafe FVector4 下雨地面变化参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x06022452 RID: 140370 RVA: 0x0090407A File Offset: 0x0090227A
		// (set) Token: 0x06022453 RID: 140371 RVA: 0x0090408E File Offset: 0x0090228E
		public unsafe FLinearColor GlobalRainGradualData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x06022454 RID: 140372 RVA: 0x009040A3 File Offset: 0x009022A3
		// (set) Token: 0x06022455 RID: 140373 RVA: 0x009040B7 File Offset: 0x009022B7
		public unsafe FLinearColor GlobalRainLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x06022456 RID: 140374 RVA: 0x009040CC File Offset: 0x009022CC
		// (set) Token: 0x06022457 RID: 140375 RVA: 0x009040DC File Offset: 0x009022DC
		public unsafe float RainIntensity_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x06022458 RID: 140376 RVA: 0x009040ED File Offset: 0x009022ED
		// (set) Token: 0x06022459 RID: 140377 RVA: 0x009040FD File Offset: 0x009022FD
		public unsafe bool UpdateRainRT_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SurfaceRippleGachaScene_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602245A RID: 140378 RVA: 0x0090410E File Offset: 0x0090230E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_No_Rain_Roughness()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__Set_No_Rain_Roughness_NativeFunctionPtr, null);
		}

		// Token: 0x0602245B RID: 140379 RVA: 0x00904122 File Offset: 0x00902322
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Rain_Roughness()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__Set_Rain_Roughness_NativeFunctionPtr, null);
		}

		// Token: 0x0602245C RID: 140380 RVA: 0x00904136 File Offset: 0x00902336
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_No_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__Set_No_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x0602245D RID: 140381 RVA: 0x0090414A File Offset: 0x0090234A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__Set_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x0602245E RID: 140382 RVA: 0x00904160 File Offset: 0x00902360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateGradualData(int Index, float InputParam, ref FLinearColor GlobalRainGradualData, ref bool Vaild)
		{
			BP_SurfaceRippleGachaScene_C.__UpdateGradualData_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__UpdateGradualData_FunctionParams[(UIntPtr)107] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__UpdateGradualData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__UpdateGradualData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->InputParam = InputParam;
			ptr->GlobalRainGradualData = GlobalRainGradualData;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__UpdateGradualData_NativeFunctionPtr, (void*)ptr);
			GlobalRainGradualData = ptr->GlobalRainGradualData;
			Vaild = ptr->Vaild;
		}

		// Token: 0x0602245F RID: 140383 RVA: 0x009041D7 File Offset: 0x009023D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022460 RID: 140384 RVA: 0x009041EB File Offset: 0x009023EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022461 RID: 140385 RVA: 0x00904200 File Offset: 0x00902400
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022462 RID: 140386 RVA: 0x00904214 File Offset: 0x00902414
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022463 RID: 140387 RVA: 0x0090422C File Offset: 0x0090242C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022464 RID: 140388 RVA: 0x00904274 File Offset: 0x00902474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022465 RID: 140389 RVA: 0x009042BC File Offset: 0x009024BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022466 RID: 140390 RVA: 0x00904308 File Offset: 0x00902508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022467 RID: 140391 RVA: 0x00904354 File Offset: 0x00902554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022468 RID: 140392 RVA: 0x0090439C File Offset: 0x0090259C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SurfaceRippleGachaScene_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SurfaceRippleGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SurfaceRippleGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022469 RID: 140393 RVA: 0x009043E3 File Offset: 0x009025E3
		protected BP_SurfaceRippleGachaScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010CBC RID: 68796
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_SurfaceRippleGachaScene.BP_SurfaceRippleGachaScene_C";

		// Token: 0x04010CBD RID: 68797
		private static IntPtr _ClassPtr;

		// Token: 0x04010CBE RID: 68798
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010CBF RID: 68799
		internal static int __PropertyOffset_1;

		// Token: 0x04010CC0 RID: 68800
		internal static int __PropertyOffset_2;

		// Token: 0x04010CC1 RID: 68801
		internal static int __PropertyOffset_3;

		// Token: 0x04010CC2 RID: 68802
		internal static int __PropertyOffset_4;

		// Token: 0x04010CC3 RID: 68803
		internal static int __PropertyOffset_5;

		// Token: 0x04010CC4 RID: 68804
		internal static int __PropertyOffset_6;

		// Token: 0x04010CC5 RID: 68805
		internal static int __PropertyOffset_7;

		// Token: 0x04010CC6 RID: 68806
		internal static int __PropertyOffset_8;

		// Token: 0x04010CC7 RID: 68807
		internal static int __PropertyOffset_9;

		// Token: 0x04010CC8 RID: 68808
		internal static int __PropertyOffset_10;

		// Token: 0x04010CC9 RID: 68809
		internal static int __PropertyOffset_11;

		// Token: 0x04010CCA RID: 68810
		internal static int __PropertyOffset_12;

		// Token: 0x04010CCB RID: 68811
		internal static int __PropertyOffset_13;

		// Token: 0x04010CCC RID: 68812
		internal static int __PropertyOffset_14;

		// Token: 0x04010CCD RID: 68813
		internal static int __PropertyOffset_15;

		// Token: 0x04010CCE RID: 68814
		private static IntPtr __Set_No_Rain_Roughness_NativeFunctionPtr;

		// Token: 0x04010CCF RID: 68815
		private static IntPtr __Set_Rain_Roughness_NativeFunctionPtr;

		// Token: 0x04010CD0 RID: 68816
		private static IntPtr __Set_No_Rain_NativeFunctionPtr;

		// Token: 0x04010CD1 RID: 68817
		private static IntPtr __Set_Rain_NativeFunctionPtr;

		// Token: 0x04010CD2 RID: 68818
		private static IntPtr __UpdateGradualData_NativeFunctionPtr;

		// Token: 0x04010CD3 RID: 68819
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010CD4 RID: 68820
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010CD5 RID: 68821
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010CD6 RID: 68822
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010CD7 RID: 68823
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D5B RID: 40283
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 92)]
		protected ref struct __UpdateGradualData_FunctionParams
		{
			// Token: 0x040314D2 RID: 201938
			[FieldOffset(0)]
			public int Index;

			// Token: 0x040314D3 RID: 201939
			[FieldOffset(4)]
			public float InputParam;

			// Token: 0x040314D4 RID: 201940
			[FieldOffset(8)]
			public FLinearColor GlobalRainGradualData;

			// Token: 0x040314D5 RID: 201941
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02009D5C RID: 40284
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314D6 RID: 201942
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D5D RID: 40285
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314D7 RID: 201943
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009D5E RID: 40286
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314D8 RID: 201944
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
