using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Volumetrics
{
	// Token: 0x02003D97 RID: 15767
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/VolumeSmokeComponent.VolumeSmokeComponent_C")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 377)]
	public class VolumeSmokeComponent_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027129 RID: 160041 RVA: 0x00986090 File Offset: 0x00984290
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (VolumeSmokeComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/VolumeSmokeComponent.VolumeSmokeComponent_C");
			}
			return VolumeSmokeComponent_C._ClassPtr;
		}

		// Token: 0x0602712A RID: 160042 RVA: 0x009860B4 File Offset: 0x009842B4
		public VolumeSmokeComponent_C() : this(BuiltinUtils.AllocNativeUObject(VolumeSmokeComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602712B RID: 160043 RVA: 0x009860DC File Offset: 0x009842DC
		[NullableContext(1)]
		public VolumeSmokeComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(VolumeSmokeComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x0602712C RID: 160044 RVA: 0x0098610F File Offset: 0x0098430F
		// (set) Token: 0x0602712D RID: 160045 RVA: 0x00986123 File Offset: 0x00984323
		public unsafe UStaticMeshComponent DepthSlicerComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x0602712E RID: 160046 RVA: 0x00986138 File Offset: 0x00984338
		// (set) Token: 0x0602712F RID: 160047 RVA: 0x00986148 File Offset: 0x00984348
		public unsafe bool Disable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x06027130 RID: 160048 RVA: 0x00986159 File Offset: 0x00984359
		// (set) Token: 0x06027131 RID: 160049 RVA: 0x00986169 File Offset: 0x00984369
		public unsafe bool DirectlySetMaterialByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x06027132 RID: 160050 RVA: 0x0098617A File Offset: 0x0098437A
		// (set) Token: 0x06027133 RID: 160051 RVA: 0x0098618A File Offset: 0x0098438A
		public unsafe bool DirectlySetPositionAnd_ScaleByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x06027134 RID: 160052 RVA: 0x0098619B File Offset: 0x0098439B
		// (set) Token: 0x06027135 RID: 160053 RVA: 0x009861AB File Offset: 0x009843AB
		public unsafe bool AnchorVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x06027136 RID: 160054 RVA: 0x009861BC File Offset: 0x009843BC
		// (set) Token: 0x06027137 RID: 160055 RVA: 0x009861D0 File Offset: 0x009843D0
		public unsafe FName ComponentTagToGetDirectlyIdentifiedByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x06027138 RID: 160056 RVA: 0x009861E5 File Offset: 0x009843E5
		// (set) Token: 0x06027139 RID: 160057 RVA: 0x009861F9 File Offset: 0x009843F9
		public unsafe FName NullTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x0602713A RID: 160058 RVA: 0x0098620E File Offset: 0x0098440E
		// (set) Token: 0x0602713B RID: 160059 RVA: 0x00986222 File Offset: 0x00984422
		public unsafe UTextureRenderTarget2D InputRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x0602713C RID: 160060 RVA: 0x00986237 File Offset: 0x00984437
		// (set) Token: 0x0602713D RID: 160061 RVA: 0x0098624B File Offset: 0x0098444B
		public unsafe UMaterialInterface VolumeSmokeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x0602713E RID: 160062 RVA: 0x00986260 File Offset: 0x00984460
		// (set) Token: 0x0602713F RID: 160063 RVA: 0x00986274 File Offset: 0x00984474
		public unsafe AActor TrackThisActorAsPointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x06027140 RID: 160064 RVA: 0x00986289 File Offset: 0x00984489
		// (set) Token: 0x06027141 RID: 160065 RVA: 0x00986299 File Offset: 0x00984499
		public unsafe bool LockRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x06027142 RID: 160066 RVA: 0x009862AA File Offset: 0x009844AA
		// (set) Token: 0x06027143 RID: 160067 RVA: 0x009862BA File Offset: 0x009844BA
		public unsafe bool CameraFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x06027144 RID: 160068 RVA: 0x009862CB File Offset: 0x009844CB
		// (set) Token: 0x06027145 RID: 160069 RVA: 0x009862DB File Offset: 0x009844DB
		public unsafe bool CameraFacingLockY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x06027146 RID: 160070 RVA: 0x009862EC File Offset: 0x009844EC
		// (set) Token: 0x06027147 RID: 160071 RVA: 0x009862FC File Offset: 0x009844FC
		public unsafe bool UseLegacyCameraFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x06027148 RID: 160072 RVA: 0x0098630D File Offset: 0x0098450D
		// (set) Token: 0x06027149 RID: 160073 RVA: 0x00986321 File Offset: 0x00984521
		public unsafe FVector PositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x0602714A RID: 160074 RVA: 0x00986336 File Offset: 0x00984536
		// (set) Token: 0x0602714B RID: 160075 RVA: 0x0098634A File Offset: 0x0098454A
		public unsafe FVector PointLightPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x0602714C RID: 160076 RVA: 0x0098635F File Offset: 0x0098455F
		// (set) Token: 0x0602714D RID: 160077 RVA: 0x0098636F File Offset: 0x0098456F
		public unsafe float VolumeSizeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x0602714E RID: 160078 RVA: 0x00986380 File Offset: 0x00984580
		// (set) Token: 0x0602714F RID: 160079 RVA: 0x00986390 File Offset: 0x00984590
		public unsafe float VolumeSideRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x06027150 RID: 160080 RVA: 0x009863A1 File Offset: 0x009845A1
		// (set) Token: 0x06027151 RID: 160081 RVA: 0x009863B5 File Offset: 0x009845B5
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x06027152 RID: 160082 RVA: 0x009863CA File Offset: 0x009845CA
		// (set) Token: 0x06027153 RID: 160083 RVA: 0x009863DE File Offset: 0x009845DE
		public unsafe FRotator InitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x06027154 RID: 160084 RVA: 0x009863F3 File Offset: 0x009845F3
		// (set) Token: 0x06027155 RID: 160085 RVA: 0x00986407 File Offset: 0x00984607
		public unsafe UMaterialInterface PreviousMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x06027156 RID: 160086 RVA: 0x0098641C File Offset: 0x0098461C
		// (set) Token: 0x06027157 RID: 160087 RVA: 0x00986430 File Offset: 0x00984630
		public unsafe UStaticMesh DepthSlicer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x06027158 RID: 160088 RVA: 0x00986445 File Offset: 0x00984645
		// (set) Token: 0x06027159 RID: 160089 RVA: 0x00986459 File Offset: 0x00984659
		public unsafe UBoxComponent Volume_Visualize_Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + VolumeSmokeComponent_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x0602715A RID: 160090 RVA: 0x0098646E File Offset: 0x0098466E
		// (set) Token: 0x0602715B RID: 160091 RVA: 0x0098647E File Offset: 0x0098467E
		public unsafe bool OwnerIsVolumeSmokeActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)VolumeSmokeComponent_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602715C RID: 160092 RVA: 0x0098648F File Offset: 0x0098468F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeRemotelySetMaterial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, VolumeSmokeComponent_C.__InitializeRemotelySetMaterial_NativeFunctionPtr, null);
		}

		// Token: 0x0602715D RID: 160093 RVA: 0x009864A3 File Offset: 0x009846A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeLocallySetMaterial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, VolumeSmokeComponent_C.__InitializeLocallySetMaterial_NativeFunctionPtr, null);
		}

		// Token: 0x0602715E RID: 160094 RVA: 0x009864B7 File Offset: 0x009846B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh_Lighting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, VolumeSmokeComponent_C.__Refresh_Lighting_NativeFunctionPtr, null);
		}

		// Token: 0x0602715F RID: 160095 RVA: 0x009864CB File Offset: 0x009846CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, VolumeSmokeComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027160 RID: 160096 RVA: 0x009864DF File Offset: 0x009846DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, VolumeSmokeComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027161 RID: 160097 RVA: 0x009864F4 File Offset: 0x009846F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			VolumeSmokeComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc VolumeSmokeComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(VolumeSmokeComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(VolumeSmokeComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, VolumeSmokeComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027162 RID: 160098 RVA: 0x0098653C File Offset: 0x0098473C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			VolumeSmokeComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc VolumeSmokeComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(VolumeSmokeComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(VolumeSmokeComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, VolumeSmokeComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027163 RID: 160099 RVA: 0x00986583 File Offset: 0x00984783
		protected VolumeSmokeComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013AE3 RID: 80611
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/VolumeSmokeComponent.VolumeSmokeComponent_C";

		// Token: 0x04013AE4 RID: 80612
		private static IntPtr _ClassPtr;

		// Token: 0x04013AE5 RID: 80613
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013AE6 RID: 80614
		internal static int __PropertyOffset_1;

		// Token: 0x04013AE7 RID: 80615
		internal static int __PropertyOffset_2;

		// Token: 0x04013AE8 RID: 80616
		internal static int __PropertyOffset_3;

		// Token: 0x04013AE9 RID: 80617
		internal static int __PropertyOffset_4;

		// Token: 0x04013AEA RID: 80618
		internal static int __PropertyOffset_5;

		// Token: 0x04013AEB RID: 80619
		internal static int __PropertyOffset_6;

		// Token: 0x04013AEC RID: 80620
		internal static int __PropertyOffset_7;

		// Token: 0x04013AED RID: 80621
		internal static int __PropertyOffset_8;

		// Token: 0x04013AEE RID: 80622
		internal static int __PropertyOffset_9;

		// Token: 0x04013AEF RID: 80623
		internal static int __PropertyOffset_10;

		// Token: 0x04013AF0 RID: 80624
		internal static int __PropertyOffset_11;

		// Token: 0x04013AF1 RID: 80625
		internal static int __PropertyOffset_12;

		// Token: 0x04013AF2 RID: 80626
		internal static int __PropertyOffset_13;

		// Token: 0x04013AF3 RID: 80627
		internal static int __PropertyOffset_14;

		// Token: 0x04013AF4 RID: 80628
		internal static int __PropertyOffset_15;

		// Token: 0x04013AF5 RID: 80629
		internal static int __PropertyOffset_16;

		// Token: 0x04013AF6 RID: 80630
		internal static int __PropertyOffset_17;

		// Token: 0x04013AF7 RID: 80631
		internal static int __PropertyOffset_18;

		// Token: 0x04013AF8 RID: 80632
		internal static int __PropertyOffset_19;

		// Token: 0x04013AF9 RID: 80633
		internal static int __PropertyOffset_20;

		// Token: 0x04013AFA RID: 80634
		internal static int __PropertyOffset_21;

		// Token: 0x04013AFB RID: 80635
		internal static int __PropertyOffset_22;

		// Token: 0x04013AFC RID: 80636
		internal static int __PropertyOffset_23;

		// Token: 0x04013AFD RID: 80637
		internal static int __PropertyOffset_24;

		// Token: 0x04013AFE RID: 80638
		private static IntPtr __InitializeRemotelySetMaterial_NativeFunctionPtr;

		// Token: 0x04013AFF RID: 80639
		private static IntPtr __InitializeLocallySetMaterial_NativeFunctionPtr;

		// Token: 0x04013B00 RID: 80640
		private static IntPtr __Refresh_Lighting_NativeFunctionPtr;

		// Token: 0x04013B01 RID: 80641
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013B02 RID: 80642
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A192 RID: 41362
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D75 RID: 204149
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
