using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroLocalVolumetricFog
{
	// Token: 0x02003D04 RID: 15620
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroLocalVolumetricFog/BP_KuroLocalVolumetricFog.BP_KuroLocalVolumetricFog_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class BP_KuroLocalVolumetricFog_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602556E RID: 152942 RVA: 0x009576F4 File Offset: 0x009558F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroLocalVolumetricFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroLocalVolumetricFog/BP_KuroLocalVolumetricFog.BP_KuroLocalVolumetricFog_C");
			}
			return BP_KuroLocalVolumetricFog_C._ClassPtr;
		}

		// Token: 0x0602556F RID: 152943 RVA: 0x00957718 File Offset: 0x00955918
		public BP_KuroLocalVolumetricFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroLocalVolumetricFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025570 RID: 152944 RVA: 0x00957740 File Offset: 0x00955940
		[NullableContext(1)]
		public BP_KuroLocalVolumetricFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroLocalVolumetricFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06025571 RID: 152945 RVA: 0x00957773 File Offset: 0x00955973
		// (set) Token: 0x06025572 RID: 152946 RVA: 0x00957787 File Offset: 0x00955987
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06025573 RID: 152947 RVA: 0x0095779C File Offset: 0x0095599C
		// (set) Token: 0x06025574 RID: 152948 RVA: 0x009577B0 File Offset: 0x009559B0
		public unsafe UStaticMesh Mesh_FogSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x06025575 RID: 152949 RVA: 0x009577C5 File Offset: 0x009559C5
		// (set) Token: 0x06025576 RID: 152950 RVA: 0x009577D5 File Offset: 0x009559D5
		public unsafe int FogScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x06025577 RID: 152951 RVA: 0x009577E6 File Offset: 0x009559E6
		// (set) Token: 0x06025578 RID: 152952 RVA: 0x009577FA File Offset: 0x009559FA
		public unsafe UMaterialInstance M_LocalVolumetricFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x06025579 RID: 152953 RVA: 0x0095780F File Offset: 0x00955A0F
		// (set) Token: 0x0602557A RID: 152954 RVA: 0x00957823 File Offset: 0x00955A23
		public unsafe FColor FogInColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x0602557B RID: 152955 RVA: 0x00957838 File Offset: 0x00955A38
		// (set) Token: 0x0602557C RID: 152956 RVA: 0x0095784C File Offset: 0x00955A4C
		public unsafe FColor FogOutColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x0602557D RID: 152957 RVA: 0x00957861 File Offset: 0x00955A61
		// (set) Token: 0x0602557E RID: 152958 RVA: 0x00957871 File Offset: 0x00955A71
		public unsafe float FogEnvLightBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x0602557F RID: 152959 RVA: 0x00957882 File Offset: 0x00955A82
		// (set) Token: 0x06025580 RID: 152960 RVA: 0x00957892 File Offset: 0x00955A92
		public unsafe float FogInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x06025581 RID: 152961 RVA: 0x009578A3 File Offset: 0x00955AA3
		// (set) Token: 0x06025582 RID: 152962 RVA: 0x009578B3 File Offset: 0x00955AB3
		public unsafe float FogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x06025583 RID: 152963 RVA: 0x009578C4 File Offset: 0x00955AC4
		// (set) Token: 0x06025584 RID: 152964 RVA: 0x009578D4 File Offset: 0x00955AD4
		public unsafe float FogHgX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x06025585 RID: 152965 RVA: 0x009578E5 File Offset: 0x00955AE5
		// (set) Token: 0x06025586 RID: 152966 RVA: 0x009578F5 File Offset: 0x00955AF5
		public unsafe float FogPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x06025587 RID: 152967 RVA: 0x00957906 File Offset: 0x00955B06
		// (set) Token: 0x06025588 RID: 152968 RVA: 0x00957916 File Offset: 0x00955B16
		public unsafe float FogHg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x06025589 RID: 152969 RVA: 0x00957927 File Offset: 0x00955B27
		// (set) Token: 0x0602558A RID: 152970 RVA: 0x00957937 File Offset: 0x00955B37
		public unsafe float FogPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x0602558B RID: 152971 RVA: 0x00957948 File Offset: 0x00955B48
		// (set) Token: 0x0602558C RID: 152972 RVA: 0x00957958 File Offset: 0x00955B58
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x0602558D RID: 152973 RVA: 0x00957969 File Offset: 0x00955B69
		// (set) Token: 0x0602558E RID: 152974 RVA: 0x00957979 File Offset: 0x00955B79
		public unsafe bool EnableNoise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x0602558F RID: 152975 RVA: 0x0095798A File Offset: 0x00955B8A
		// (set) Token: 0x06025590 RID: 152976 RVA: 0x0095799A File Offset: 0x00955B9A
		public unsafe bool EnableObjectScreenUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x06025591 RID: 152977 RVA: 0x009579AB File Offset: 0x00955BAB
		// (set) Token: 0x06025592 RID: 152978 RVA: 0x009579BB File Offset: 0x00955BBB
		public unsafe float NoiseInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x06025593 RID: 152979 RVA: 0x009579CC File Offset: 0x00955BCC
		// (set) Token: 0x06025594 RID: 152980 RVA: 0x009579DC File Offset: 0x00955BDC
		public unsafe float NoiseOneTill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x06025595 RID: 152981 RVA: 0x009579ED File Offset: 0x00955BED
		// (set) Token: 0x06025596 RID: 152982 RVA: 0x009579FD File Offset: 0x00955BFD
		public unsafe float NoiseOneSpeedX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x06025597 RID: 152983 RVA: 0x00957A0E File Offset: 0x00955C0E
		// (set) Token: 0x06025598 RID: 152984 RVA: 0x00957A1E File Offset: 0x00955C1E
		public unsafe float NoiseOneSpeedY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x06025599 RID: 152985 RVA: 0x00957A2F File Offset: 0x00955C2F
		// (set) Token: 0x0602559A RID: 152986 RVA: 0x00957A43 File Offset: 0x00955C43
		public unsafe UTexture2D NoiseOne
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x0602559B RID: 152987 RVA: 0x00957A58 File Offset: 0x00955C58
		// (set) Token: 0x0602559C RID: 152988 RVA: 0x00957A68 File Offset: 0x00955C68
		public unsafe float NoiseTwoTill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x0602559D RID: 152989 RVA: 0x00957A79 File Offset: 0x00955C79
		// (set) Token: 0x0602559E RID: 152990 RVA: 0x00957A89 File Offset: 0x00955C89
		public unsafe float NoiseTwoSpeedX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x0602559F RID: 152991 RVA: 0x00957A9A File Offset: 0x00955C9A
		// (set) Token: 0x060255A0 RID: 152992 RVA: 0x00957AAA File Offset: 0x00955CAA
		public unsafe float NoiseTwoSpeedY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLocalVolumetricFog_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x060255A1 RID: 152993 RVA: 0x00957ABB File Offset: 0x00955CBB
		// (set) Token: 0x060255A2 RID: 152994 RVA: 0x00957ACF File Offset: 0x00955CCF
		public unsafe UTexture2D NoiseTwo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x060255A3 RID: 152995 RVA: 0x00957AE4 File Offset: 0x00955CE4
		// (set) Token: 0x060255A4 RID: 152996 RVA: 0x00957AF8 File Offset: 0x00955CF8
		public unsafe UMaterialInstance M_LocalVolumetricFogDisNoise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x060255A5 RID: 152997 RVA: 0x00957B0D File Offset: 0x00955D0D
		// (set) Token: 0x060255A6 RID: 152998 RVA: 0x00957B21 File Offset: 0x00955D21
		public unsafe UMaterialInstance M_LocalVolumetricFog_ObjScreenUV
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x060255A7 RID: 152999 RVA: 0x00957B36 File Offset: 0x00955D36
		// (set) Token: 0x060255A8 RID: 153000 RVA: 0x00957B4A File Offset: 0x00955D4A
		public unsafe UMaterialInstanceDynamic DynMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLocalVolumetricFog_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x060255A9 RID: 153001 RVA: 0x00957B5F File Offset: 0x00955D5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLocalVolumetricFog_C.__UpdatePara_NativeFunctionPtr, null);
		}

		// Token: 0x060255AA RID: 153002 RVA: 0x00957B73 File Offset: 0x00955D73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLocalVolumetricFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060255AB RID: 153003 RVA: 0x00957B87 File Offset: 0x00955D87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLocalVolumetricFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060255AC RID: 153004 RVA: 0x00957B9C File Offset: 0x00955D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLocalVolumetricFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060255AD RID: 153005 RVA: 0x00957BB0 File Offset: 0x00955DB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLocalVolumetricFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060255AE RID: 153006 RVA: 0x00957BC5 File Offset: 0x00955DC5
		protected BP_KuroLocalVolumetricFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129EF RID: 76271
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroLocalVolumetricFog/BP_KuroLocalVolumetricFog.BP_KuroLocalVolumetricFog_C";

		// Token: 0x040129F0 RID: 76272
		private static IntPtr _ClassPtr;

		// Token: 0x040129F1 RID: 76273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129F2 RID: 76274
		internal static int __PropertyOffset_1;

		// Token: 0x040129F3 RID: 76275
		internal static int __PropertyOffset_2;

		// Token: 0x040129F4 RID: 76276
		internal static int __PropertyOffset_3;

		// Token: 0x040129F5 RID: 76277
		internal static int __PropertyOffset_4;

		// Token: 0x040129F6 RID: 76278
		internal static int __PropertyOffset_5;

		// Token: 0x040129F7 RID: 76279
		internal static int __PropertyOffset_6;

		// Token: 0x040129F8 RID: 76280
		internal static int __PropertyOffset_7;

		// Token: 0x040129F9 RID: 76281
		internal static int __PropertyOffset_8;

		// Token: 0x040129FA RID: 76282
		internal static int __PropertyOffset_9;

		// Token: 0x040129FB RID: 76283
		internal static int __PropertyOffset_10;

		// Token: 0x040129FC RID: 76284
		internal static int __PropertyOffset_11;

		// Token: 0x040129FD RID: 76285
		internal static int __PropertyOffset_12;

		// Token: 0x040129FE RID: 76286
		internal static int __PropertyOffset_13;

		// Token: 0x040129FF RID: 76287
		internal static int __PropertyOffset_14;

		// Token: 0x04012A00 RID: 76288
		internal static int __PropertyOffset_15;

		// Token: 0x04012A01 RID: 76289
		internal static int __PropertyOffset_16;

		// Token: 0x04012A02 RID: 76290
		internal static int __PropertyOffset_17;

		// Token: 0x04012A03 RID: 76291
		internal static int __PropertyOffset_18;

		// Token: 0x04012A04 RID: 76292
		internal static int __PropertyOffset_19;

		// Token: 0x04012A05 RID: 76293
		internal static int __PropertyOffset_20;

		// Token: 0x04012A06 RID: 76294
		internal static int __PropertyOffset_21;

		// Token: 0x04012A07 RID: 76295
		internal static int __PropertyOffset_22;

		// Token: 0x04012A08 RID: 76296
		internal static int __PropertyOffset_23;

		// Token: 0x04012A09 RID: 76297
		internal static int __PropertyOffset_24;

		// Token: 0x04012A0A RID: 76298
		internal static int __PropertyOffset_25;

		// Token: 0x04012A0B RID: 76299
		internal static int __PropertyOffset_26;

		// Token: 0x04012A0C RID: 76300
		internal static int __PropertyOffset_27;

		// Token: 0x04012A0D RID: 76301
		internal static int __PropertyOffset_28;

		// Token: 0x04012A0E RID: 76302
		private static IntPtr __UpdatePara_NativeFunctionPtr;

		// Token: 0x04012A0F RID: 76303
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012A10 RID: 76304
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
