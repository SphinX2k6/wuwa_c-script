using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.RippleSwim;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Water
{
	// Token: 0x02003D95 RID: 15765
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_WaterRipple.BP_WaterRipple_C")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1649)]
	public class BP_WaterRipple_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060270A0 RID: 159904 RVA: 0x009854AC File Offset: 0x009836AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterRipple_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_WaterRipple.BP_WaterRipple_C");
			}
			return BP_WaterRipple_C._ClassPtr;
		}

		// Token: 0x060270A1 RID: 159905 RVA: 0x009854D0 File Offset: 0x009836D0
		public BP_WaterRipple_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterRipple_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060270A2 RID: 159906 RVA: 0x009854F8 File Offset: 0x009836F8
		[NullableContext(1)]
		public BP_WaterRipple_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterRipple_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x060270A3 RID: 159907 RVA: 0x0098552B File Offset: 0x0098372B
		// (set) Token: 0x060270A4 RID: 159908 RVA: 0x0098553F File Offset: 0x0098373F
		public unsafe UKuroCustomCaptureVolume KuroCustomCaptureVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCustomCaptureVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x060270A5 RID: 159909 RVA: 0x00985554 File Offset: 0x00983754
		// (set) Token: 0x060270A6 RID: 159910 RVA: 0x00985568 File Offset: 0x00983768
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x060270A7 RID: 159911 RVA: 0x0098557D File Offset: 0x0098377D
		// (set) Token: 0x060270A8 RID: 159912 RVA: 0x00985591 File Offset: 0x00983791
		public unsafe NinjaLive_C Ninja
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLive_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x060270A9 RID: 159913 RVA: 0x009855A6 File Offset: 0x009837A6
		// (set) Token: 0x060270AA RID: 159914 RVA: 0x009855BA File Offset: 0x009837BA
		public unsafe ASceneCapture2D SceneCapture2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASceneCapture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x060270AB RID: 159915 RVA: 0x009855CF File Offset: 0x009837CF
		// (set) Token: 0x060270AC RID: 159916 RVA: 0x009855DF File Offset: 0x009837DF
		public unsafe bool Trace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x060270AD RID: 159917 RVA: 0x009855F0 File Offset: 0x009837F0
		// (set) Token: 0x060270AE RID: 159918 RVA: 0x00985600 File Offset: 0x00983800
		public unsafe bool bCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x060270AF RID: 159919 RVA: 0x00985611 File Offset: 0x00983811
		// (set) Token: 0x060270B0 RID: 159920 RVA: 0x00985625 File Offset: 0x00983825
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x060270B1 RID: 159921 RVA: 0x0098563A File Offset: 0x0098383A
		// (set) Token: 0x060270B2 RID: 159922 RVA: 0x0098564E File Offset: 0x0098384E
		[Nullable(0)]
		public unsafe TEnumAsByte<ECaptureMode> CaptureMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_8);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x060270B3 RID: 159923 RVA: 0x00985663 File Offset: 0x00983863
		// (set) Token: 0x060270B4 RID: 159924 RVA: 0x00985677 File Offset: 0x00983877
		public unsafe FVector CaptureVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x060270B5 RID: 159925 RVA: 0x0098568C File Offset: 0x0098388C
		// (set) Token: 0x060270B6 RID: 159926 RVA: 0x0098569C File Offset: 0x0098389C
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x060270B7 RID: 159927 RVA: 0x009856AD File Offset: 0x009838AD
		// (set) Token: 0x060270B8 RID: 159928 RVA: 0x009856BD File Offset: 0x009838BD
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x060270B9 RID: 159929 RVA: 0x009856CE File Offset: 0x009838CE
		// (set) Token: 0x060270BA RID: 159930 RVA: 0x009856E2 File Offset: 0x009838E2
		public unsafe UTextureRenderTarget2D RT_PressureBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x060270BB RID: 159931 RVA: 0x009856F7 File Offset: 0x009838F7
		// (set) Token: 0x060270BC RID: 159932 RVA: 0x0098570B File Offset: 0x0098390B
		public unsafe UTextureRenderTarget2D RT_VelocityDensityBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x060270BD RID: 159933 RVA: 0x00985720 File Offset: 0x00983920
		// (set) Token: 0x060270BE RID: 159934 RVA: 0x00985730 File Offset: 0x00983930
		public unsafe int State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x060270BF RID: 159935 RVA: 0x00985741 File Offset: 0x00983941
		// (set) Token: 0x060270C0 RID: 159936 RVA: 0x00985755 File Offset: 0x00983955
		public unsafe FLinearColor HeiHaiAnRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x060270C1 RID: 159937 RVA: 0x0098576A File Offset: 0x0098396A
		// (set) Token: 0x060270C2 RID: 159938 RVA: 0x0098577A File Offset: 0x0098397A
		public unsafe bool InsideHeiHaiAnRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x060270C3 RID: 159939 RVA: 0x0098578B File Offset: 0x0098398B
		// (set) Token: 0x060270C4 RID: 159940 RVA: 0x0098579B File Offset: 0x0098399B
		public unsafe int PreState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x060270C5 RID: 159941 RVA: 0x009857AC File Offset: 0x009839AC
		// (set) Token: 0x060270C6 RID: 159942 RVA: 0x009857C0 File Offset: 0x009839C0
		public unsafe BP_RippleSwim_C OldRippleSwim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleSwim_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x060270C7 RID: 159943 RVA: 0x009857D5 File Offset: 0x009839D5
		// (set) Token: 0x060270C8 RID: 159944 RVA: 0x009857E9 File Offset: 0x009839E9
		public unsafe FVectorDouble StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x060270C9 RID: 159945 RVA: 0x009857FE File Offset: 0x009839FE
		// (set) Token: 0x060270CA RID: 159946 RVA: 0x00985812 File Offset: 0x00983A12
		public unsafe FVectorDouble EndOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x060270CB RID: 159947 RVA: 0x00985827 File Offset: 0x00983A27
		// (set) Token: 0x060270CC RID: 159948 RVA: 0x0098583B File Offset: 0x00983A3B
		public unsafe UTextureRenderTarget2D RT_InputVelocityDensityBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x060270CD RID: 159949 RVA: 0x00985850 File Offset: 0x00983A50
		// (set) Token: 0x060270CE RID: 159950 RVA: 0x00985864 File Offset: 0x00983A64
		public unsafe UTextureRenderTarget2D RT_CaptureVelocityDensityBuffer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x060270CF RID: 159951 RVA: 0x00985879 File Offset: 0x00983A79
		// (set) Token: 0x060270D0 RID: 159952 RVA: 0x0098588D File Offset: 0x00983A8D
		public unsafe UMaterialInterface CombinMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRipple_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x060270D1 RID: 159953 RVA: 0x009858A2 File Offset: 0x00983AA2
		// (set) Token: 0x060270D2 RID: 159954 RVA: 0x009858B2 File Offset: 0x00983AB2
		public unsafe bool UseNewFluidRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRipple_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x060270D3 RID: 159955 RVA: 0x009858C4 File Offset: 0x00983AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetNewWaterRippleEnable(bool Condition)
		{
			BP_WaterRipple_C.__SetNewWaterRippleEnable_FunctionParams* ptr = stackalloc BP_WaterRipple_C.__SetNewWaterRippleEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WaterRipple_C.__SetNewWaterRippleEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRipple_C.__SetNewWaterRippleEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Condition = Condition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRipple_C.__SetNewWaterRippleEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060270D4 RID: 159956 RVA: 0x0098590A File Offset: 0x00983B0A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060270D5 RID: 159957 RVA: 0x0098591E File Offset: 0x00983B1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060270D6 RID: 159958 RVA: 0x00985934 File Offset: 0x00983B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterRipple_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterRipple_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRipple_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060270D7 RID: 159959 RVA: 0x0098597C File Offset: 0x00983B7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterRipple_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterRipple_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRipple_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRipple_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060270D8 RID: 159960 RVA: 0x009859C3 File Offset: 0x00983BC3
		protected BP_WaterRipple_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A9B RID: 80539
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_WaterRipple.BP_WaterRipple_C";

		// Token: 0x04013A9C RID: 80540
		private static IntPtr _ClassPtr;

		// Token: 0x04013A9D RID: 80541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A9E RID: 80542
		internal static int __PropertyOffset_1;

		// Token: 0x04013A9F RID: 80543
		internal static int __PropertyOffset_2;

		// Token: 0x04013AA0 RID: 80544
		internal static int __PropertyOffset_3;

		// Token: 0x04013AA1 RID: 80545
		internal static int __PropertyOffset_4;

		// Token: 0x04013AA2 RID: 80546
		internal static int __PropertyOffset_5;

		// Token: 0x04013AA3 RID: 80547
		internal static int __PropertyOffset_6;

		// Token: 0x04013AA4 RID: 80548
		internal static int __PropertyOffset_7;

		// Token: 0x04013AA5 RID: 80549
		internal static int __PropertyOffset_8;

		// Token: 0x04013AA6 RID: 80550
		internal static int __PropertyOffset_9;

		// Token: 0x04013AA7 RID: 80551
		internal static int __PropertyOffset_10;

		// Token: 0x04013AA8 RID: 80552
		internal static int __PropertyOffset_11;

		// Token: 0x04013AA9 RID: 80553
		internal static int __PropertyOffset_12;

		// Token: 0x04013AAA RID: 80554
		internal static int __PropertyOffset_13;

		// Token: 0x04013AAB RID: 80555
		internal static int __PropertyOffset_14;

		// Token: 0x04013AAC RID: 80556
		internal static int __PropertyOffset_15;

		// Token: 0x04013AAD RID: 80557
		internal static int __PropertyOffset_16;

		// Token: 0x04013AAE RID: 80558
		internal static int __PropertyOffset_17;

		// Token: 0x04013AAF RID: 80559
		internal static int __PropertyOffset_18;

		// Token: 0x04013AB0 RID: 80560
		internal static int __PropertyOffset_19;

		// Token: 0x04013AB1 RID: 80561
		internal static int __PropertyOffset_20;

		// Token: 0x04013AB2 RID: 80562
		internal static int __PropertyOffset_21;

		// Token: 0x04013AB3 RID: 80563
		internal static int __PropertyOffset_22;

		// Token: 0x04013AB4 RID: 80564
		internal static int __PropertyOffset_23;

		// Token: 0x04013AB5 RID: 80565
		internal static int __PropertyOffset_24;

		// Token: 0x04013AB6 RID: 80566
		private static IntPtr __SetNewWaterRippleEnable_NativeFunctionPtr;

		// Token: 0x04013AB7 RID: 80567
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013AB8 RID: 80568
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A18E RID: 41358
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetNewWaterRippleEnable_FunctionParams
		{
			// Token: 0x04031D71 RID: 204145
			[FieldOffset(0)]
			public bool Condition;
		}

		// Token: 0x0200A18F RID: 41359
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D72 RID: 204146
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
