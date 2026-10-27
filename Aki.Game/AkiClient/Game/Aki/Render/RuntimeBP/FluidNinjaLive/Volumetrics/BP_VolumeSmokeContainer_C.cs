using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Volumetrics
{
	// Token: 0x02003D96 RID: 15766
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/BP_VolumeSmokeContainer.BP_VolumeSmokeContainer_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_VolumeSmokeContainer_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060270D9 RID: 159961 RVA: 0x009859CC File Offset: 0x00983BCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumeSmokeContainer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/BP_VolumeSmokeContainer.BP_VolumeSmokeContainer_C");
			}
			return BP_VolumeSmokeContainer_C._ClassPtr;
		}

		// Token: 0x060270DA RID: 159962 RVA: 0x009859F0 File Offset: 0x00983BF0
		public BP_VolumeSmokeContainer_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumeSmokeContainer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060270DB RID: 159963 RVA: 0x00985A18 File Offset: 0x00983C18
		[NullableContext(1)]
		public BP_VolumeSmokeContainer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumeSmokeContainer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x060270DC RID: 159964 RVA: 0x00985A4B File Offset: 0x00983C4B
		// (set) Token: 0x060270DD RID: 159965 RVA: 0x00985A5F File Offset: 0x00983C5F
		public unsafe VolumeSmokeComponent_C VolumeSmokeComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<VolumeSmokeComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x060270DE RID: 159966 RVA: 0x00985A74 File Offset: 0x00983C74
		// (set) Token: 0x060270DF RID: 159967 RVA: 0x00985A88 File Offset: 0x00983C88
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x060270E0 RID: 159968 RVA: 0x00985A9D File Offset: 0x00983C9D
		// (set) Token: 0x060270E1 RID: 159969 RVA: 0x00985AB1 File Offset: 0x00983CB1
		public unsafe UBoxComponent VolumeVisualizeBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x060270E2 RID: 159970 RVA: 0x00985AC6 File Offset: 0x00983CC6
		// (set) Token: 0x060270E3 RID: 159971 RVA: 0x00985ADA File Offset: 0x00983CDA
		public unsafe UStaticMeshComponent DepthSlicer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x060270E4 RID: 159972 RVA: 0x00985AEF File Offset: 0x00983CEF
		// (set) Token: 0x060270E5 RID: 159973 RVA: 0x00985B03 File Offset: 0x00983D03
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x060270E6 RID: 159974 RVA: 0x00985B18 File Offset: 0x00983D18
		// (set) Token: 0x060270E7 RID: 159975 RVA: 0x00985B28 File Offset: 0x00983D28
		public unsafe float ObjScaleInv
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x060270E8 RID: 159976 RVA: 0x00985B39 File Offset: 0x00983D39
		// (set) Token: 0x060270E9 RID: 159977 RVA: 0x00985B49 File Offset: 0x00983D49
		public unsafe float FadeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x060270EA RID: 159978 RVA: 0x00985B5A File Offset: 0x00983D5A
		// (set) Token: 0x060270EB RID: 159979 RVA: 0x00985B6A File Offset: 0x00983D6A
		public unsafe bool DirectlySetMaterialByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x060270EC RID: 159980 RVA: 0x00985B7B File Offset: 0x00983D7B
		// (set) Token: 0x060270ED RID: 159981 RVA: 0x00985B8B File Offset: 0x00983D8B
		public unsafe bool DirectlySetPositionAndScaleByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x060270EE RID: 159982 RVA: 0x00985B9C File Offset: 0x00983D9C
		// (set) Token: 0x060270EF RID: 159983 RVA: 0x00985BAC File Offset: 0x00983DAC
		public unsafe bool UseInputRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x060270F0 RID: 159984 RVA: 0x00985BBD File Offset: 0x00983DBD
		// (set) Token: 0x060270F1 RID: 159985 RVA: 0x00985BCD File Offset: 0x00983DCD
		public unsafe bool AnchorVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x060270F2 RID: 159986 RVA: 0x00985BDE File Offset: 0x00983DDE
		// (set) Token: 0x060270F3 RID: 159987 RVA: 0x00985BF2 File Offset: 0x00983DF2
		public unsafe FName ActorTagToGetDirectlyIdentifiedByNinja
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x060270F4 RID: 159988 RVA: 0x00985C07 File Offset: 0x00983E07
		// (set) Token: 0x060270F5 RID: 159989 RVA: 0x00985C1B File Offset: 0x00983E1B
		public unsafe FName NullTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x060270F6 RID: 159990 RVA: 0x00985C30 File Offset: 0x00983E30
		// (set) Token: 0x060270F7 RID: 159991 RVA: 0x00985C44 File Offset: 0x00983E44
		public unsafe UTextureRenderTarget2D InputRenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x060270F8 RID: 159992 RVA: 0x00985C59 File Offset: 0x00983E59
		// (set) Token: 0x060270F9 RID: 159993 RVA: 0x00985C6D File Offset: 0x00983E6D
		public unsafe FVector VolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x060270FA RID: 159994 RVA: 0x00985C82 File Offset: 0x00983E82
		// (set) Token: 0x060270FB RID: 159995 RVA: 0x00985C96 File Offset: 0x00983E96
		public unsafe UMaterialInterface VolumeSmokeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x060270FC RID: 159996 RVA: 0x00985CAB File Offset: 0x00983EAB
		// (set) Token: 0x060270FD RID: 159997 RVA: 0x00985CBF File Offset: 0x00983EBF
		public unsafe UMaterialInstance VolumeSmokeMaterialNoInput
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x060270FE RID: 159998 RVA: 0x00985CD4 File Offset: 0x00983ED4
		// (set) Token: 0x060270FF RID: 159999 RVA: 0x00985CE8 File Offset: 0x00983EE8
		public unsafe AActor TrackThisActorAsPointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x06027100 RID: 160000 RVA: 0x00985CFD File Offset: 0x00983EFD
		// (set) Token: 0x06027101 RID: 160001 RVA: 0x00985D0D File Offset: 0x00983F0D
		public unsafe bool LockLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x06027102 RID: 160002 RVA: 0x00985D1E File Offset: 0x00983F1E
		// (set) Token: 0x06027103 RID: 160003 RVA: 0x00985D2E File Offset: 0x00983F2E
		public unsafe bool LockRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x06027104 RID: 160004 RVA: 0x00985D3F File Offset: 0x00983F3F
		// (set) Token: 0x06027105 RID: 160005 RVA: 0x00985D4F File Offset: 0x00983F4F
		public unsafe bool CameraFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x06027106 RID: 160006 RVA: 0x00985D60 File Offset: 0x00983F60
		// (set) Token: 0x06027107 RID: 160007 RVA: 0x00985D70 File Offset: 0x00983F70
		public unsafe bool CameraFacingLockY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x06027108 RID: 160008 RVA: 0x00985D81 File Offset: 0x00983F81
		// (set) Token: 0x06027109 RID: 160009 RVA: 0x00985D91 File Offset: 0x00983F91
		public unsafe bool UseLegacyCameraFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x0602710A RID: 160010 RVA: 0x00985DA2 File Offset: 0x00983FA2
		// (set) Token: 0x0602710B RID: 160011 RVA: 0x00985DB6 File Offset: 0x00983FB6
		public unsafe FVector PositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x0602710C RID: 160012 RVA: 0x00985DCB File Offset: 0x00983FCB
		// (set) Token: 0x0602710D RID: 160013 RVA: 0x00985DDF File Offset: 0x00983FDF
		public unsafe FVector PointLightPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x0602710E RID: 160014 RVA: 0x00985DF4 File Offset: 0x00983FF4
		// (set) Token: 0x0602710F RID: 160015 RVA: 0x00985E04 File Offset: 0x00984004
		public unsafe float VolumeSizeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x06027110 RID: 160016 RVA: 0x00985E15 File Offset: 0x00984015
		// (set) Token: 0x06027111 RID: 160017 RVA: 0x00985E25 File Offset: 0x00984025
		public unsafe float VolumeSideRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x06027112 RID: 160018 RVA: 0x00985E36 File Offset: 0x00984036
		// (set) Token: 0x06027113 RID: 160019 RVA: 0x00985E4A File Offset: 0x0098404A
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x06027114 RID: 160020 RVA: 0x00985E5F File Offset: 0x0098405F
		// (set) Token: 0x06027115 RID: 160021 RVA: 0x00985E73 File Offset: 0x00984073
		public unsafe FRotator InitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x06027116 RID: 160022 RVA: 0x00985E88 File Offset: 0x00984088
		// (set) Token: 0x06027117 RID: 160023 RVA: 0x00985E98 File Offset: 0x00984098
		public unsafe bool bIsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x06027118 RID: 160024 RVA: 0x00985EA9 File Offset: 0x009840A9
		// (set) Token: 0x06027119 RID: 160025 RVA: 0x00985EBD File Offset: 0x009840BD
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeSmokeContainer_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x0602711A RID: 160026 RVA: 0x00985ED2 File Offset: 0x009840D2
		// (set) Token: 0x0602711B RID: 160027 RVA: 0x00985EE2 File Offset: 0x009840E2
		public unsafe int CachedQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x0602711C RID: 160028 RVA: 0x00985EF3 File Offset: 0x009840F3
		// (set) Token: 0x0602711D RID: 160029 RVA: 0x00985F03 File Offset: 0x00984103
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x0602711E RID: 160030 RVA: 0x00985F14 File Offset: 0x00984114
		// (set) Token: 0x0602711F RID: 160031 RVA: 0x00985F28 File Offset: 0x00984128
		public unsafe FVectorDouble ValidBoxLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeSmokeContainer_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x06027120 RID: 160032 RVA: 0x00985F40 File Offset: 0x00984140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckQuality(ref bool IsValid)
		{
			BP_VolumeSmokeContainer_C.__CheckQuality_FunctionParams* ptr = stackalloc BP_VolumeSmokeContainer_C.__CheckQuality_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_VolumeSmokeContainer_C.__CheckQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumeSmokeContainer_C.__CheckQuality_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsValid = IsValid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__CheckQuality_NativeFunctionPtr, (void*)ptr);
			IsValid = ptr->IsValid;
		}

		// Token: 0x06027121 RID: 160033 RVA: 0x00985F8F File Offset: 0x0098418F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeMaterial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__InitializeMaterial_NativeFunctionPtr, null);
		}

		// Token: 0x06027122 RID: 160034 RVA: 0x00985FA3 File Offset: 0x009841A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027123 RID: 160035 RVA: 0x00985FB7 File Offset: 0x009841B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027124 RID: 160036 RVA: 0x00985FCC File Offset: 0x009841CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027125 RID: 160037 RVA: 0x00985FE0 File Offset: 0x009841E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027126 RID: 160038 RVA: 0x00985FF8 File Offset: 0x009841F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumeSmokeContainer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027127 RID: 160039 RVA: 0x00986040 File Offset: 0x00984240
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumeSmokeContainer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumeSmokeContainer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeSmokeContainer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027128 RID: 160040 RVA: 0x00986087 File Offset: 0x00984287
		protected BP_VolumeSmokeContainer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013AB9 RID: 80569
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Volumetrics/BP_VolumeSmokeContainer.BP_VolumeSmokeContainer_C";

		// Token: 0x04013ABA RID: 80570
		private static IntPtr _ClassPtr;

		// Token: 0x04013ABB RID: 80571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013ABC RID: 80572
		internal static int __PropertyOffset_1;

		// Token: 0x04013ABD RID: 80573
		internal static int __PropertyOffset_2;

		// Token: 0x04013ABE RID: 80574
		internal static int __PropertyOffset_3;

		// Token: 0x04013ABF RID: 80575
		internal static int __PropertyOffset_4;

		// Token: 0x04013AC0 RID: 80576
		internal static int __PropertyOffset_5;

		// Token: 0x04013AC1 RID: 80577
		internal static int __PropertyOffset_6;

		// Token: 0x04013AC2 RID: 80578
		internal static int __PropertyOffset_7;

		// Token: 0x04013AC3 RID: 80579
		internal static int __PropertyOffset_8;

		// Token: 0x04013AC4 RID: 80580
		internal static int __PropertyOffset_9;

		// Token: 0x04013AC5 RID: 80581
		internal static int __PropertyOffset_10;

		// Token: 0x04013AC6 RID: 80582
		internal static int __PropertyOffset_11;

		// Token: 0x04013AC7 RID: 80583
		internal static int __PropertyOffset_12;

		// Token: 0x04013AC8 RID: 80584
		internal static int __PropertyOffset_13;

		// Token: 0x04013AC9 RID: 80585
		internal static int __PropertyOffset_14;

		// Token: 0x04013ACA RID: 80586
		internal static int __PropertyOffset_15;

		// Token: 0x04013ACB RID: 80587
		internal static int __PropertyOffset_16;

		// Token: 0x04013ACC RID: 80588
		internal static int __PropertyOffset_17;

		// Token: 0x04013ACD RID: 80589
		internal static int __PropertyOffset_18;

		// Token: 0x04013ACE RID: 80590
		internal static int __PropertyOffset_19;

		// Token: 0x04013ACF RID: 80591
		internal static int __PropertyOffset_20;

		// Token: 0x04013AD0 RID: 80592
		internal static int __PropertyOffset_21;

		// Token: 0x04013AD1 RID: 80593
		internal static int __PropertyOffset_22;

		// Token: 0x04013AD2 RID: 80594
		internal static int __PropertyOffset_23;

		// Token: 0x04013AD3 RID: 80595
		internal static int __PropertyOffset_24;

		// Token: 0x04013AD4 RID: 80596
		internal static int __PropertyOffset_25;

		// Token: 0x04013AD5 RID: 80597
		internal static int __PropertyOffset_26;

		// Token: 0x04013AD6 RID: 80598
		internal static int __PropertyOffset_27;

		// Token: 0x04013AD7 RID: 80599
		internal static int __PropertyOffset_28;

		// Token: 0x04013AD8 RID: 80600
		internal static int __PropertyOffset_29;

		// Token: 0x04013AD9 RID: 80601
		internal static int __PropertyOffset_30;

		// Token: 0x04013ADA RID: 80602
		internal static int __PropertyOffset_31;

		// Token: 0x04013ADB RID: 80603
		internal static int __PropertyOffset_32;

		// Token: 0x04013ADC RID: 80604
		internal static int __PropertyOffset_33;

		// Token: 0x04013ADD RID: 80605
		internal static int __PropertyOffset_34;

		// Token: 0x04013ADE RID: 80606
		private static IntPtr __CheckQuality_NativeFunctionPtr;

		// Token: 0x04013ADF RID: 80607
		private static IntPtr __InitializeMaterial_NativeFunctionPtr;

		// Token: 0x04013AE0 RID: 80608
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013AE1 RID: 80609
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013AE2 RID: 80610
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A190 RID: 41360
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __CheckQuality_FunctionParams
		{
			// Token: 0x04031D73 RID: 204147
			[FieldOffset(0)]
			public bool IsValid;
		}

		// Token: 0x0200A191 RID: 41361
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D74 RID: 204148
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
