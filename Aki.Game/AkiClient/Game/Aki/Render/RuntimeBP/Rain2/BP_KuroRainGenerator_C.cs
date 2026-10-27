using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BBD RID: 15293
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_KuroRainGenerator.BP_KuroRainGenerator_C")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1689)]
	public class BP_KuroRainGenerator_C : AKuroRainActorV2, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060222CB RID: 139979 RVA: 0x00901B36 File Offset: 0x008FFD36
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroRainGenerator_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_KuroRainGenerator.BP_KuroRainGenerator_C");
			}
			return BP_KuroRainGenerator_C._ClassPtr;
		}

		// Token: 0x060222CC RID: 139980 RVA: 0x00901B5C File Offset: 0x008FFD5C
		public BP_KuroRainGenerator_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroRainGenerator_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222CD RID: 139981 RVA: 0x00901B84 File Offset: 0x008FFD84
		[NullableContext(1)]
		public BP_KuroRainGenerator_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroRainGenerator_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x060222CE RID: 139982 RVA: 0x00901BB7 File Offset: 0x008FFDB7
		// (set) Token: 0x060222CF RID: 139983 RVA: 0x00901BCB File Offset: 0x008FFDCB
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_CyberRain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x060222D0 RID: 139984 RVA: 0x00901BE0 File Offset: 0x008FFDE0
		// (set) Token: 0x060222D1 RID: 139985 RVA: 0x00901BF4 File Offset: 0x008FFDF4
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_StormRain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x060222D2 RID: 139986 RVA: 0x00901C09 File Offset: 0x008FFE09
		// (set) Token: 0x060222D3 RID: 139987 RVA: 0x00901C1D File Offset: 0x008FFE1D
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_SnowStorm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x060222D4 RID: 139988 RVA: 0x00901C32 File Offset: 0x008FFE32
		// (set) Token: 0x060222D5 RID: 139989 RVA: 0x00901C46 File Offset: 0x008FFE46
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_BlackWave
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x060222D6 RID: 139990 RVA: 0x00901C5B File Offset: 0x008FFE5B
		// (set) Token: 0x060222D7 RID: 139991 RVA: 0x00901C6F File Offset: 0x008FFE6F
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_Snow_JinkuBoss
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x060222D8 RID: 139992 RVA: 0x00901C84 File Offset: 0x008FFE84
		// (set) Token: 0x060222D9 RID: 139993 RVA: 0x00901C98 File Offset: 0x008FFE98
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_RainCommonDrop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x060222DA RID: 139994 RVA: 0x00901CAD File Offset: 0x008FFEAD
		// (set) Token: 0x060222DB RID: 139995 RVA: 0x00901CC1 File Offset: 0x008FFEC1
		public unsafe BP_WorldRainComponent_Common_C BP_WorldRainComponent_Snow_CommonDrop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WorldRainComponent_Common_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x060222DC RID: 139996 RVA: 0x00901CD6 File Offset: 0x008FFED6
		// (set) Token: 0x060222DD RID: 139997 RVA: 0x00901CEA File Offset: 0x008FFEEA
		public unsafe UNiagaraComponent Niagara_CommonReverse_UrgentTurn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x060222DE RID: 139998 RVA: 0x00901CFF File Offset: 0x008FFEFF
		// (set) Token: 0x060222DF RID: 139999 RVA: 0x00901D13 File Offset: 0x008FFF13
		public unsafe BP_RainComponent_CommonReverse_C BP_RainComponent_CommonReverse_UrgentTurn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RainComponent_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x060222E0 RID: 140000 RVA: 0x00901D28 File Offset: 0x008FFF28
		// (set) Token: 0x060222E1 RID: 140001 RVA: 0x00901D3C File Offset: 0x008FFF3C
		public unsafe UNiagaraComponent Niagara_CommonReverse_Fast
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x060222E2 RID: 140002 RVA: 0x00901D51 File Offset: 0x008FFF51
		// (set) Token: 0x060222E3 RID: 140003 RVA: 0x00901D65 File Offset: 0x008FFF65
		public unsafe BP_RainComponent_CommonReverse_C BP_RainComponent_CommonReverse_Fast
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RainComponent_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x060222E4 RID: 140004 RVA: 0x00901D7A File Offset: 0x008FFF7A
		// (set) Token: 0x060222E5 RID: 140005 RVA: 0x00901D8E File Offset: 0x008FFF8E
		public unsafe UNiagaraComponent Niagara_CommonReverse_Stable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x060222E6 RID: 140006 RVA: 0x00901DA3 File Offset: 0x008FFFA3
		// (set) Token: 0x060222E7 RID: 140007 RVA: 0x00901DB7 File Offset: 0x008FFFB7
		public unsafe UNiagaraComponent Niagara_CommonReverse_Lively
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x060222E8 RID: 140008 RVA: 0x00901DCC File Offset: 0x008FFFCC
		// (set) Token: 0x060222E9 RID: 140009 RVA: 0x00901DE0 File Offset: 0x008FFFE0
		public unsafe BP_RainComponent_CommonReverse_C BP_RainComponent_CommonReverse_Stable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RainComponent_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x060222EA RID: 140010 RVA: 0x00901DF5 File Offset: 0x008FFFF5
		// (set) Token: 0x060222EB RID: 140011 RVA: 0x00901E09 File Offset: 0x00900009
		public unsafe BP_RainComponent_CommonReverse_C BP_RainComponent_CommonReverse_Lively
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RainComponent_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x060222EC RID: 140012 RVA: 0x00901E1E File Offset: 0x0090001E
		// (set) Token: 0x060222ED RID: 140013 RVA: 0x00901E32 File Offset: 0x00900032
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x060222EE RID: 140014 RVA: 0x00901E47 File Offset: 0x00900047
		// (set) Token: 0x060222EF RID: 140015 RVA: 0x00901E5B File Offset: 0x0090005B
		public unsafe AActor Handle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x060222F0 RID: 140016 RVA: 0x00901E70 File Offset: 0x00900070
		// (set) Token: 0x060222F1 RID: 140017 RVA: 0x00901E84 File Offset: 0x00900084
		public unsafe PDA_RainConfigs_C Configs
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfigs_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x060222F2 RID: 140018 RVA: 0x00901E99 File Offset: 0x00900099
		// (set) Token: 0x060222F3 RID: 140019 RVA: 0x00901EA9 File Offset: 0x009000A9
		public unsafe float TeleportDistanceToRestart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x060222F4 RID: 140020 RVA: 0x00901EBA File Offset: 0x009000BA
		// (set) Token: 0x060222F5 RID: 140021 RVA: 0x00901ECE File Offset: 0x009000CE
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> CachedRainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_20);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x060222F6 RID: 140022 RVA: 0x00901EE3 File Offset: 0x009000E3
		// (set) Token: 0x060222F7 RID: 140023 RVA: 0x00901EF7 File Offset: 0x009000F7
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> CurrentRainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_21);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x060222F8 RID: 140024 RVA: 0x00901F0C File Offset: 0x0090010C
		// (set) Token: 0x060222F9 RID: 140025 RVA: 0x00901F1C File Offset: 0x0090011C
		public unsafe float RainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x060222FA RID: 140026 RVA: 0x00901F2D File Offset: 0x0090012D
		// (set) Token: 0x060222FB RID: 140027 RVA: 0x00901F41 File Offset: 0x00900141
		public unsafe FVector Wind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x060222FC RID: 140028 RVA: 0x00901F56 File Offset: 0x00900156
		// (set) Token: 0x060222FD RID: 140029 RVA: 0x00901F66 File Offset: 0x00900166
		public unsafe float RainFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x060222FE RID: 140030 RVA: 0x00901F77 File Offset: 0x00900177
		// (set) Token: 0x060222FF RID: 140031 RVA: 0x00901F8B File Offset: 0x0090018B
		public unsafe FVectorDouble CameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x06022300 RID: 140032 RVA: 0x00901FA0 File Offset: 0x009001A0
		// (set) Token: 0x06022301 RID: 140033 RVA: 0x00901FB4 File Offset: 0x009001B4
		public unsafe FVector Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x06022302 RID: 140034 RVA: 0x00901FC9 File Offset: 0x009001C9
		// (set) Token: 0x06022303 RID: 140035 RVA: 0x00901FD9 File Offset: 0x009001D9
		public unsafe bool IsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x06022304 RID: 140036 RVA: 0x00901FEA File Offset: 0x009001EA
		// (set) Token: 0x06022305 RID: 140037 RVA: 0x00901FFA File Offset: 0x009001FA
		public unsafe bool bRainAffectPointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x06022306 RID: 140038 RVA: 0x0090200B File Offset: 0x0090020B
		// (set) Token: 0x06022307 RID: 140039 RVA: 0x0090201F File Offset: 0x0090021F
		public unsafe UTODLightManagerSubsystem TODLightSubsystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTODLightManagerSubsystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroRainGenerator_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x06022308 RID: 140040 RVA: 0x00902034 File Offset: 0x00900234
		// (set) Token: 0x06022309 RID: 140041 RVA: 0x00902048 File Offset: 0x00900248
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> SustainRainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_30);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroRainGenerator_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x0602230A RID: 140042 RVA: 0x00902060 File Offset: 0x00900260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartWorldRain(ref SWorldRainComb Config, BP_WorldRainComponent_Common_C Comp)
		{
			BP_KuroRainGenerator_C.__StartWorldRain_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__StartWorldRain_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__StartWorldRain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__StartWorldRain_NativeFunctionPtr, (void*)ptr, 1);
			if (Config != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), &ptr->Config, Config.NativePtr, 1, false);
			}
			ptr->Comp = ((Comp != null) ? Comp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartWorldRain_NativeFunctionPtr, (void*)ptr);
			if (Config != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWorldRainComb.StaticStruct(), Config.NativePtr, &ptr->Config, 1, false);
			}
		}

		// Token: 0x0602230B RID: 140043 RVA: 0x009020FD File Offset: 0x009002FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UpdateMPC_NativeFunctionPtr, null);
		}

		// Token: 0x0602230C RID: 140044 RVA: 0x00902111 File Offset: 0x00900311
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopAll()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StopAll_NativeFunctionPtr, null);
		}

		// Token: 0x0602230D RID: 140045 RVA: 0x00902125 File Offset: 0x00900325
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CyberRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CyberRain_NativeFunctionPtr, null);
		}

		// Token: 0x0602230E RID: 140046 RVA: 0x00902139 File Offset: 0x00900339
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_StormRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_StormRain_NativeFunctionPtr, null);
		}

		// Token: 0x0602230F RID: 140047 RVA: 0x0090214D File Offset: 0x0090034D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSnow_SnowStorm()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartSnow_SnowStorm_NativeFunctionPtr, null);
		}

		// Token: 0x06022310 RID: 140048 RVA: 0x00902161 File Offset: 0x00900361
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_BlackWave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_BlackWave_NativeFunctionPtr, null);
		}

		// Token: 0x06022311 RID: 140049 RVA: 0x00902175 File Offset: 0x00900375
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSnow_Jinku_Boss()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartSnow_Jinku_Boss_NativeFunctionPtr, null);
		}

		// Token: 0x06022312 RID: 140050 RVA: 0x00902189 File Offset: 0x00900389
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSnow_CommonDrop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartSnow_CommonDrop_NativeFunctionPtr, null);
		}

		// Token: 0x06022313 RID: 140051 RVA: 0x0090219D File Offset: 0x0090039D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CommonReverse_UrgentTurn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CommonReverse_UrgentTurn_NativeFunctionPtr, null);
		}

		// Token: 0x06022314 RID: 140052 RVA: 0x009021B1 File Offset: 0x009003B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CommonReverse_Fast()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CommonReverse_Fast_NativeFunctionPtr, null);
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x009021C5 File Offset: 0x009003C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateRainGlobalParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UpdateRainGlobalParams_NativeFunctionPtr, null);
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x009021D9 File Offset: 0x009003D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CommonReverse_Stable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CommonReverse_Stable_NativeFunctionPtr, null);
		}

		// Token: 0x06022317 RID: 140055 RVA: 0x009021ED File Offset: 0x009003ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCameraInfos()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UpdateCameraInfos_NativeFunctionPtr, null);
		}

		// Token: 0x06022318 RID: 140056 RVA: 0x00902201 File Offset: 0x00900401
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CommonReverse_Lively()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CommonReverse_Lively_NativeFunctionPtr, null);
		}

		// Token: 0x06022319 RID: 140057 RVA: 0x00902215 File Offset: 0x00900415
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartRain_CommonDrop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__StartRain_CommonDrop_NativeFunctionPtr, null);
		}

		// Token: 0x0602231A RID: 140058 RVA: 0x00902229 File Offset: 0x00900429
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DeactivateAll()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__DeactivateAll_NativeFunctionPtr, null);
		}

		// Token: 0x0602231B RID: 140059 RVA: 0x0090223D File Offset: 0x0090043D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshDeactivateStat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__RefreshDeactivateStat_NativeFunctionPtr, null);
		}

		// Token: 0x0602231C RID: 140060 RVA: 0x00902251 File Offset: 0x00900451
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PrintSpeed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__PrintSpeed_NativeFunctionPtr, null);
		}

		// Token: 0x0602231D RID: 140061 RVA: 0x00902265 File Offset: 0x00900465
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602231E RID: 140062 RVA: 0x00902279 File Offset: 0x00900479
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602231F RID: 140063 RVA: 0x00902290 File Offset: 0x00900490
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroRainGenerator_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022320 RID: 140064 RVA: 0x009022D8 File Offset: 0x009004D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroRainGenerator_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022321 RID: 140065 RVA: 0x0090231F File Offset: 0x0090051F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EnableRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__EnableRain_NativeFunctionPtr, null);
		}

		// Token: 0x06022322 RID: 140066 RVA: 0x00902333 File Offset: 0x00900533
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EnableRain_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__EnableRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022323 RID: 140067 RVA: 0x00902348 File Offset: 0x00900548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void DisableRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__DisableRain_NativeFunctionPtr, null);
		}

		// Token: 0x06022324 RID: 140068 RVA: 0x0090235C File Offset: 0x0090055C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void DisableRain_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__DisableRain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022325 RID: 140069 RVA: 0x00902371 File Offset: 0x00900571
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022326 RID: 140070 RVA: 0x00902385 File Offset: 0x00900585
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022327 RID: 140071 RVA: 0x0090239C File Offset: 0x0090059C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022328 RID: 140072 RVA: 0x009023E8 File Offset: 0x009005E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022329 RID: 140073 RVA: 0x00902434 File Offset: 0x00900634
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void UpdatePlayingRainComponent(UKuroRainComponent RainComponent)
		{
			BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RainComponent = ((RainComponent != null) ? RainComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602232A RID: 140074 RVA: 0x0090248C File Offset: 0x0090068C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void UpdatePlayingRainComponent_Implementation(UKuroRainComponent RainComponent)
		{
			BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RainComponent = ((RainComponent != null) ? RainComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__UpdatePlayingRainComponent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602232B RID: 140075 RVA: 0x009024E4 File Offset: 0x009006E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602232C RID: 140076 RVA: 0x0090252C File Offset: 0x0090072C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroRainGenerator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroRainGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroRainGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602232D RID: 140077 RVA: 0x00902573 File Offset: 0x00900773
		protected BP_KuroRainGenerator_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BE9 RID: 68585
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_KuroRainGenerator.BP_KuroRainGenerator_C";

		// Token: 0x04010BEA RID: 68586
		private static IntPtr _ClassPtr;

		// Token: 0x04010BEB RID: 68587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BEC RID: 68588
		internal static int __PropertyOffset_1;

		// Token: 0x04010BED RID: 68589
		internal static int __PropertyOffset_2;

		// Token: 0x04010BEE RID: 68590
		internal static int __PropertyOffset_3;

		// Token: 0x04010BEF RID: 68591
		internal static int __PropertyOffset_4;

		// Token: 0x04010BF0 RID: 68592
		internal static int __PropertyOffset_5;

		// Token: 0x04010BF1 RID: 68593
		internal static int __PropertyOffset_6;

		// Token: 0x04010BF2 RID: 68594
		internal static int __PropertyOffset_7;

		// Token: 0x04010BF3 RID: 68595
		internal static int __PropertyOffset_8;

		// Token: 0x04010BF4 RID: 68596
		internal static int __PropertyOffset_9;

		// Token: 0x04010BF5 RID: 68597
		internal static int __PropertyOffset_10;

		// Token: 0x04010BF6 RID: 68598
		internal static int __PropertyOffset_11;

		// Token: 0x04010BF7 RID: 68599
		internal static int __PropertyOffset_12;

		// Token: 0x04010BF8 RID: 68600
		internal static int __PropertyOffset_13;

		// Token: 0x04010BF9 RID: 68601
		internal static int __PropertyOffset_14;

		// Token: 0x04010BFA RID: 68602
		internal static int __PropertyOffset_15;

		// Token: 0x04010BFB RID: 68603
		internal static int __PropertyOffset_16;

		// Token: 0x04010BFC RID: 68604
		internal static int __PropertyOffset_17;

		// Token: 0x04010BFD RID: 68605
		internal static int __PropertyOffset_18;

		// Token: 0x04010BFE RID: 68606
		internal static int __PropertyOffset_19;

		// Token: 0x04010BFF RID: 68607
		internal static int __PropertyOffset_20;

		// Token: 0x04010C00 RID: 68608
		internal static int __PropertyOffset_21;

		// Token: 0x04010C01 RID: 68609
		internal static int __PropertyOffset_22;

		// Token: 0x04010C02 RID: 68610
		internal static int __PropertyOffset_23;

		// Token: 0x04010C03 RID: 68611
		internal static int __PropertyOffset_24;

		// Token: 0x04010C04 RID: 68612
		internal static int __PropertyOffset_25;

		// Token: 0x04010C05 RID: 68613
		internal static int __PropertyOffset_26;

		// Token: 0x04010C06 RID: 68614
		internal static int __PropertyOffset_27;

		// Token: 0x04010C07 RID: 68615
		internal static int __PropertyOffset_28;

		// Token: 0x04010C08 RID: 68616
		internal static int __PropertyOffset_29;

		// Token: 0x04010C09 RID: 68617
		internal static int __PropertyOffset_30;

		// Token: 0x04010C0A RID: 68618
		private static IntPtr __StartWorldRain_NativeFunctionPtr;

		// Token: 0x04010C0B RID: 68619
		private static IntPtr __UpdateMPC_NativeFunctionPtr;

		// Token: 0x04010C0C RID: 68620
		private static IntPtr __StopAll_NativeFunctionPtr;

		// Token: 0x04010C0D RID: 68621
		private static IntPtr __StartRain_CyberRain_NativeFunctionPtr;

		// Token: 0x04010C0E RID: 68622
		private static IntPtr __StartRain_StormRain_NativeFunctionPtr;

		// Token: 0x04010C0F RID: 68623
		private static IntPtr __StartSnow_SnowStorm_NativeFunctionPtr;

		// Token: 0x04010C10 RID: 68624
		private static IntPtr __StartRain_BlackWave_NativeFunctionPtr;

		// Token: 0x04010C11 RID: 68625
		private static IntPtr __StartSnow_Jinku_Boss_NativeFunctionPtr;

		// Token: 0x04010C12 RID: 68626
		private static IntPtr __StartSnow_CommonDrop_NativeFunctionPtr;

		// Token: 0x04010C13 RID: 68627
		private static IntPtr __StartRain_CommonReverse_UrgentTurn_NativeFunctionPtr;

		// Token: 0x04010C14 RID: 68628
		private static IntPtr __StartRain_CommonReverse_Fast_NativeFunctionPtr;

		// Token: 0x04010C15 RID: 68629
		private static IntPtr __UpdateRainGlobalParams_NativeFunctionPtr;

		// Token: 0x04010C16 RID: 68630
		private static IntPtr __StartRain_CommonReverse_Stable_NativeFunctionPtr;

		// Token: 0x04010C17 RID: 68631
		private static IntPtr __UpdateCameraInfos_NativeFunctionPtr;

		// Token: 0x04010C18 RID: 68632
		private static IntPtr __StartRain_CommonReverse_Lively_NativeFunctionPtr;

		// Token: 0x04010C19 RID: 68633
		private static IntPtr __StartRain_CommonDrop_NativeFunctionPtr;

		// Token: 0x04010C1A RID: 68634
		private static IntPtr __DeactivateAll_NativeFunctionPtr;

		// Token: 0x04010C1B RID: 68635
		private static IntPtr __RefreshDeactivateStat_NativeFunctionPtr;

		// Token: 0x04010C1C RID: 68636
		private static IntPtr __PrintSpeed_NativeFunctionPtr;

		// Token: 0x04010C1D RID: 68637
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010C1E RID: 68638
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010C1F RID: 68639
		private static IntPtr __EnableRain_NativeFunctionPtr;

		// Token: 0x04010C20 RID: 68640
		private static IntPtr __DisableRain_NativeFunctionPtr;

		// Token: 0x04010C21 RID: 68641
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010C22 RID: 68642
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010C23 RID: 68643
		private static IntPtr __UpdatePlayingRainComponent_NativeFunctionPtr;

		// Token: 0x04010C24 RID: 68644
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D4D RID: 40269
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __StartWorldRain_FunctionParams
		{
			// Token: 0x040314C0 RID: 201920
			[FieldOffset(0)]
			public byte Config;

			// Token: 0x040314C1 RID: 201921
			[FieldOffset(40)]
			public IntPtr Comp;
		}

		// Token: 0x02009D4E RID: 40270
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314C2 RID: 201922
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D4F RID: 40271
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314C3 RID: 201923
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009D50 RID: 40272
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __UpdatePlayingRainComponent_FunctionParams
		{
			// Token: 0x040314C4 RID: 201924
			[FieldOffset(0)]
			public IntPtr RainComponent;
		}

		// Token: 0x02009D51 RID: 40273
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314C5 RID: 201925
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
