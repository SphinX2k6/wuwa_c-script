using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x020030F7 RID: 12535
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C")]
	[UnrealStructLayout(17504, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 17503)]
	public class BP_GlobalGI_C : AKuroGlobalGI, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E730 RID: 124720 RVA: 0x0091455C File Offset: 0x0091275C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalGI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C");
			}
			return BP_GlobalGI_C._ClassPtr;
		}

		// Token: 0x0601E731 RID: 124721 RVA: 0x00914580 File Offset: 0x00912780
		public BP_GlobalGI_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E732 RID: 124722 RVA: 0x009145A8 File Offset: 0x009127A8
		[NullableContext(1)]
		public BP_GlobalGI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0601E733 RID: 124723 RVA: 0x009145DB File Offset: 0x009127DB
		// (set) Token: 0x0601E734 RID: 124724 RVA: 0x009145EF File Offset: 0x009127EF
		public unsafe UChildActorComponent KuroDynamicSky
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_KuroDynamicSky);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_KuroDynamicSky, value);
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0601E735 RID: 124725 RVA: 0x00914604 File Offset: 0x00912804
		// (set) Token: 0x0601E736 RID: 124726 RVA: 0x00914618 File Offset: 0x00912818
		public unsafe UKuroPostProcessComponent ToonBaseFFTPost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_ToonBaseFFTPost);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_ToonBaseFFTPost, value);
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0601E737 RID: 124727 RVA: 0x0091462D File Offset: 0x0091282D
		// (set) Token: 0x0601E738 RID: 124728 RVA: 0x00914641 File Offset: 0x00912841
		public unsafe UPostProcessComponent GodRayPostVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GodRayPostVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GodRayPostVolume, value);
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0601E739 RID: 124729 RVA: 0x00914656 File Offset: 0x00912856
		// (set) Token: 0x0601E73A RID: 124730 RVA: 0x0091466A File Offset: 0x0091286A
		public unsafe UChildActorComponent KuroVolumeCloudGlobal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_KuroVolumeCloudGlobal);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_KuroVolumeCloudGlobal, value);
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0601E73B RID: 124731 RVA: 0x0091467F File Offset: 0x0091287F
		// (set) Token: 0x0601E73C RID: 124732 RVA: 0x00914693 File Offset: 0x00912893
		public unsafe UChildActorComponent RainOverrider
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_RainOverrider);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_RainOverrider, value);
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0601E73D RID: 124733 RVA: 0x009146A8 File Offset: 0x009128A8
		// (set) Token: 0x0601E73E RID: 124734 RVA: 0x009146BC File Offset: 0x009128BC
		public unsafe UStaticMeshComponent CloudOcean
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CloudOcean);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CloudOcean, value);
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0601E73F RID: 124735 RVA: 0x009146D1 File Offset: 0x009128D1
		// (set) Token: 0x0601E740 RID: 124736 RVA: 0x009146E5 File Offset: 0x009128E5
		public unsafe UStaticMeshComponent SM_MilkyWay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_MilkyWay);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_MilkyWay, value);
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0601E741 RID: 124737 RVA: 0x009146FA File Offset: 0x009128FA
		// (set) Token: 0x0601E742 RID: 124738 RVA: 0x0091470E File Offset: 0x0091290E
		public unsafe UKuroPostProcessComponent GlobalUiScenePostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GlobalUiScenePostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GlobalUiScenePostProcess, value);
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0601E743 RID: 124739 RVA: 0x00914723 File Offset: 0x00912923
		// (set) Token: 0x0601E744 RID: 124740 RVA: 0x00914737 File Offset: 0x00912937
		public unsafe UChildActorComponent ImposterManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_ImposterManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_ImposterManager, value);
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0601E745 RID: 124741 RVA: 0x0091474C File Offset: 0x0091294C
		// (set) Token: 0x0601E746 RID: 124742 RVA: 0x00914760 File Offset: 0x00912960
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS6, value);
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0601E747 RID: 124743 RVA: 0x00914775 File Offset: 0x00912975
		// (set) Token: 0x0601E748 RID: 124744 RVA: 0x00914789 File Offset: 0x00912989
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS5, value);
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0601E749 RID: 124745 RVA: 0x0091479E File Offset: 0x0091299E
		// (set) Token: 0x0601E74A RID: 124746 RVA: 0x009147B2 File Offset: 0x009129B2
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS4, value);
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0601E74B RID: 124747 RVA: 0x009147C7 File Offset: 0x009129C7
		// (set) Token: 0x0601E74C RID: 124748 RVA: 0x009147DB File Offset: 0x009129DB
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS3, value);
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0601E74D RID: 124749 RVA: 0x009147F0 File Offset: 0x009129F0
		// (set) Token: 0x0601E74E RID: 124750 RVA: 0x00914804 File Offset: 0x00912A04
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS2, value);
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0601E74F RID: 124751 RVA: 0x00914819 File Offset: 0x00912A19
		// (set) Token: 0x0601E750 RID: 124752 RVA: 0x0091482D File Offset: 0x00912A2D
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS1, value);
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0601E751 RID: 124753 RVA: 0x00914842 File Offset: 0x00912A42
		// (set) Token: 0x0601E752 RID: 124754 RVA: 0x00914856 File Offset: 0x00912A56
		public unsafe UStaticMeshComponent SM_Com_Roc_01AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Com_Roc_01AS, value);
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0601E753 RID: 124755 RVA: 0x0091486B File Offset: 0x00912A6B
		// (set) Token: 0x0601E754 RID: 124756 RVA: 0x0091487F File Offset: 0x00912A7F
		public unsafe UKuroPostProcessComponent LUTPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LUTPostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LUTPostProcess, value);
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0601E755 RID: 124757 RVA: 0x00914894 File Offset: 0x00912A94
		// (set) Token: 0x0601E756 RID: 124758 RVA: 0x009148A8 File Offset: 0x00912AA8
		public unsafe UStaticMeshComponent SM_Stars
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Stars);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SM_Stars, value);
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0601E757 RID: 124759 RVA: 0x009148BD File Offset: 0x00912ABD
		// (set) Token: 0x0601E758 RID: 124760 RVA: 0x009148D1 File Offset: 0x00912AD1
		public unsafe UStaticMeshComponent Skybox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Skybox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Skybox, value);
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0601E759 RID: 124761 RVA: 0x009148E6 File Offset: 0x00912AE6
		// (set) Token: 0x0601E75A RID: 124762 RVA: 0x009148FA File Offset: 0x00912AFA
		public unsafe UPostProcessComponent GlobalPostProcessVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GlobalPostProcessVolume);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_GlobalPostProcessVolume, value);
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0601E75B RID: 124763 RVA: 0x0091490F File Offset: 0x00912B0F
		// (set) Token: 0x0601E75C RID: 124764 RVA: 0x00914923 File Offset: 0x00912B23
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0601E75D RID: 124765 RVA: 0x00914938 File Offset: 0x00912B38
		// (set) Token: 0x0601E75E RID: 124766 RVA: 0x00914948 File Offset: 0x00912B48
		public unsafe float CharacterLightHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharacterLightHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharacterLightHorizontal) = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0601E75F RID: 124767 RVA: 0x00914959 File Offset: 0x00912B59
		// (set) Token: 0x0601E760 RID: 124768 RVA: 0x00914969 File Offset: 0x00912B69
		public unsafe float CurrTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CurrTimeOfDay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CurrTimeOfDay) = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0601E761 RID: 124769 RVA: 0x0091497A File Offset: 0x00912B7A
		// (set) Token: 0x0601E762 RID: 124770 RVA: 0x0091498A File Offset: 0x00912B8A
		public unsafe bool EnableTODCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableTODCycle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableTODCycle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0601E763 RID: 124771 RVA: 0x0091499B File Offset: 0x00912B9B
		// (set) Token: 0x0601E764 RID: 124772 RVA: 0x009149AB File Offset: 0x00912BAB
		public unsafe bool PauseTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PauseTOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PauseTOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0601E765 RID: 124773 RVA: 0x009149BC File Offset: 0x00912BBC
		// (set) Token: 0x0601E766 RID: 124774 RVA: 0x009149CC File Offset: 0x00912BCC
		public unsafe bool 编辑器下更新
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_编辑器下更新) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_编辑器下更新) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0601E767 RID: 124775 RVA: 0x009149DD File Offset: 0x00912BDD
		// (set) Token: 0x0601E768 RID: 124776 RVA: 0x009149ED File Offset: 0x00912BED
		public unsafe float TODCycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TODCycleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TODCycleTime) = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0601E769 RID: 124777 RVA: 0x009149FE File Offset: 0x00912BFE
		// (set) Token: 0x0601E76A RID: 124778 RVA: 0x00914A12 File Offset: 0x00912C12
		public unsafe FRotator SenenDirLightRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SenenDirLightRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SenenDirLightRot) = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0601E76B RID: 124779 RVA: 0x00914A27 File Offset: 0x00912C27
		// (set) Token: 0x0601E76C RID: 124780 RVA: 0x00914A37 File Offset: 0x00912C37
		public unsafe float MainLightAngleLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightAngleLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightAngleLimit) = value;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0601E76D RID: 124781 RVA: 0x00914A48 File Offset: 0x00912C48
		// (set) Token: 0x0601E76E RID: 124782 RVA: 0x00914A58 File Offset: 0x00912C58
		public unsafe bool IsGIEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsGIEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsGIEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0601E76F RID: 124783 RVA: 0x00914A69 File Offset: 0x00912C69
		// (set) Token: 0x0601E770 RID: 124784 RVA: 0x00914A79 File Offset: 0x00912C79
		public unsafe bool 使用随机的昼夜循环天气组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用随机的昼夜循环天气组) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用随机的昼夜循环天气组) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0601E771 RID: 124785 RVA: 0x00914A8A File Offset: 0x00912C8A
		// (set) Token: 0x0601E772 RID: 124786 RVA: 0x00914A9A File Offset: 0x00912C9A
		public unsafe int 当前的天气组索引值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_当前的天气组索引值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_当前的天气组索引值) = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0601E773 RID: 124787 RVA: 0x00914AAB File Offset: 0x00912CAB
		// (set) Token: 0x0601E774 RID: 124788 RVA: 0x00914ABF File Offset: 0x00912CBF
		public unsafe FLinearColor 太阳颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_太阳颜色);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_太阳颜色) = value;
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0601E775 RID: 124789 RVA: 0x00914AD4 File Offset: 0x00912CD4
		// (set) Token: 0x0601E776 RID: 124790 RVA: 0x00914B0D File Offset: 0x00912D0D
		[Nullable(1)]
		public TArray<FVector2D> SunLightExistTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._SunLightExistTime) == null)
				{
					result = (this._SunLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunLightExistTime, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SunLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0601E777 RID: 124791 RVA: 0x00914B1C File Offset: 0x00912D1C
		// (set) Token: 0x0601E778 RID: 124792 RVA: 0x00914B55 File Offset: 0x00912D55
		[Nullable(1)]
		public TArray<FVector2D> MoonLightExistTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._MoonLightExistTime) == null)
				{
					result = (this._MoonLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonLightExistTime, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoonLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0601E779 RID: 124793 RVA: 0x00914B63 File Offset: 0x00912D63
		// (set) Token: 0x0601E77A RID: 124794 RVA: 0x00914B73 File Offset: 0x00912D73
		public unsafe bool 运行时自动开始循环
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_运行时自动开始循环) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_运行时自动开始循环) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0601E77B RID: 124795 RVA: 0x00914B84 File Offset: 0x00912D84
		// (set) Token: 0x0601E77C RID: 124796 RVA: 0x00914B94 File Offset: 0x00912D94
		public unsafe bool UISceneRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UISceneRendering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UISceneRendering) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0601E77D RID: 124797 RVA: 0x00914BA5 File Offset: 0x00912DA5
		// (set) Token: 0x0601E77E RID: 124798 RVA: 0x00914BB5 File Offset: 0x00912DB5
		public unsafe bool IsRootGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsRootGI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsRootGI) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0601E77F RID: 124799 RVA: 0x00914BC6 File Offset: 0x00912DC6
		// (set) Token: 0x0601E780 RID: 124800 RVA: 0x00914BD6 File Offset: 0x00912DD6
		public unsafe bool DEBUG_使用角色预览方向光
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_使用角色预览方向光) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_使用角色预览方向光) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0601E781 RID: 124801 RVA: 0x00914BE7 File Offset: 0x00912DE7
		// (set) Token: 0x0601E782 RID: 124802 RVA: 0x00914BF7 File Offset: 0x00912DF7
		public unsafe float DEBUG_角色预览方向光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_角色预览方向光方向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_角色预览方向光方向) = value;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0601E783 RID: 124803 RVA: 0x00914C08 File Offset: 0x00912E08
		// (set) Token: 0x0601E784 RID: 124804 RVA: 0x00914C18 File Offset: 0x00912E18
		public unsafe int TotalDaysElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TotalDaysElapsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TotalDaysElapsed) = value;
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0601E785 RID: 124805 RVA: 0x00914C29 File Offset: 0x00912E29
		// (set) Token: 0x0601E786 RID: 124806 RVA: 0x00914C39 File Offset: 0x00912E39
		public unsafe float MoonFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonFade) = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0601E787 RID: 124807 RVA: 0x00914C4A File Offset: 0x00912E4A
		// (set) Token: 0x0601E788 RID: 124808 RVA: 0x00914C5E File Offset: 0x00912E5E
		public unsafe FVector2D MoonVisibleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonVisibleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonVisibleTime) = value;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0601E789 RID: 124809 RVA: 0x00914C73 File Offset: 0x00912E73
		// (set) Token: 0x0601E78A RID: 124810 RVA: 0x00914C83 File Offset: 0x00912E83
		public unsafe bool 编辑器下关闭LensFlare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_编辑器下关闭LensFlare) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_编辑器下关闭LensFlare) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0601E78B RID: 124811 RVA: 0x00914C94 File Offset: 0x00912E94
		// (set) Token: 0x0601E78C RID: 124812 RVA: 0x00914CA4 File Offset: 0x00912EA4
		public unsafe bool 关闭雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_关闭雾效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_关闭雾效) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0601E78D RID: 124813 RVA: 0x00914CB5 File Offset: 0x00912EB5
		// (set) Token: 0x0601E78E RID: 124814 RVA: 0x00914CC5 File Offset: 0x00912EC5
		public unsafe bool RuntimeTimeEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RuntimeTimeEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RuntimeTimeEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0601E78F RID: 124815 RVA: 0x00914CD6 File Offset: 0x00912ED6
		// (set) Token: 0x0601E790 RID: 124816 RVA: 0x00914CE6 File Offset: 0x00912EE6
		public unsafe float MainLightTickSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightTickSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightTickSecond) = value;
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0601E791 RID: 124817 RVA: 0x00914CF7 File Offset: 0x00912EF7
		// (set) Token: 0x0601E792 RID: 124818 RVA: 0x00914D07 File Offset: 0x00912F07
		public unsafe float MainLightTickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightTickCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainLightTickCounter) = value;
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0601E793 RID: 124819 RVA: 0x00914D18 File Offset: 0x00912F18
		// (set) Token: 0x0601E794 RID: 124820 RVA: 0x00914D28 File Offset: 0x00912F28
		public unsafe bool ForceUpdateMainLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ForceUpdateMainLightDir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ForceUpdateMainLightDir) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0601E795 RID: 124821 RVA: 0x00914D39 File Offset: 0x00912F39
		// (set) Token: 0x0601E796 RID: 124822 RVA: 0x00914D49 File Offset: 0x00912F49
		public unsafe float WindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_WindDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_WindDir) = value;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0601E797 RID: 124823 RVA: 0x00914D5A File Offset: 0x00912F5A
		// (set) Token: 0x0601E798 RID: 124824 RVA: 0x00914D6A File Offset: 0x00912F6A
		public unsafe bool 使用临时雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用临时雾效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用临时雾效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0601E799 RID: 124825 RVA: 0x00914D7B File Offset: 0x00912F7B
		// (set) Token: 0x0601E79A RID: 124826 RVA: 0x00914D8F File Offset: 0x00912F8F
		public unsafe UMaterialInstance TempFogMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_TempFogMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_TempFogMaterial, value);
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0601E79B RID: 124827 RVA: 0x00914DA4 File Offset: 0x00912FA4
		// (set) Token: 0x0601E79C RID: 124828 RVA: 0x00914DB8 File Offset: 0x00912FB8
		public unsafe UMaterialInstanceDynamic TempFogDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_TempFogDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_TempFogDMI, value);
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0601E79D RID: 124829 RVA: 0x00914DCD File Offset: 0x00912FCD
		// (set) Token: 0x0601E79E RID: 124830 RVA: 0x00914DE1 File Offset: 0x00912FE1
		public unsafe UMaterialInstance SkyboxMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SkyboxMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_SkyboxMaterial, value);
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0601E79F RID: 124831 RVA: 0x00914DF6 File Offset: 0x00912FF6
		// (set) Token: 0x0601E7A0 RID: 124832 RVA: 0x00914E0A File Offset: 0x0091300A
		public unsafe FLinearColor SunDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunDiscColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunDiscColor) = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0601E7A1 RID: 124833 RVA: 0x00914E1F File Offset: 0x0091301F
		// (set) Token: 0x0601E7A2 RID: 124834 RVA: 0x00914E33 File Offset: 0x00913033
		public unsafe FLinearColor SunScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunScatterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunScatterColor) = value;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0601E7A3 RID: 124835 RVA: 0x00914E48 File Offset: 0x00913048
		// (set) Token: 0x0601E7A4 RID: 124836 RVA: 0x00914E58 File Offset: 0x00913058
		public unsafe float SunSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunSize) = value;
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0601E7A5 RID: 124837 RVA: 0x00914E69 File Offset: 0x00913069
		// (set) Token: 0x0601E7A6 RID: 124838 RVA: 0x00914E7D File Offset: 0x0091307D
		public unsafe FLinearColor MoonDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonDiscColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonDiscColor) = value;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0601E7A7 RID: 124839 RVA: 0x00914E92 File Offset: 0x00913092
		// (set) Token: 0x0601E7A8 RID: 124840 RVA: 0x00914EA6 File Offset: 0x009130A6
		public unsafe FLinearColor MoonScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonScatterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonScatterColor) = value;
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0601E7A9 RID: 124841 RVA: 0x00914EBB File Offset: 0x009130BB
		// (set) Token: 0x0601E7AA RID: 124842 RVA: 0x00914ECB File Offset: 0x009130CB
		public unsafe float MoonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MoonSize) = value;
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0601E7AB RID: 124843 RVA: 0x00914EDC File Offset: 0x009130DC
		// (set) Token: 0x0601E7AC RID: 124844 RVA: 0x00914EF0 File Offset: 0x009130F0
		public unsafe FLinearColor HorizonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HorizonColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HorizonColor) = value;
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0601E7AD RID: 124845 RVA: 0x00914F05 File Offset: 0x00913105
		// (set) Token: 0x0601E7AE RID: 124846 RVA: 0x00914F15 File Offset: 0x00913115
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HorizonFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HorizonFalloff) = value;
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0601E7AF RID: 124847 RVA: 0x00914F26 File Offset: 0x00913126
		// (set) Token: 0x0601E7B0 RID: 124848 RVA: 0x00914F3A File Offset: 0x0091313A
		public unsafe FLinearColor ZenithColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ZenithColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ZenithColor) = value;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0601E7B1 RID: 124849 RVA: 0x00914F4F File Offset: 0x0091314F
		// (set) Token: 0x0601E7B2 RID: 124850 RVA: 0x00914F5F File Offset: 0x0091315F
		public unsafe float ExtremWeatherWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ExtremWeatherWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ExtremWeatherWeight) = value;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0601E7B3 RID: 124851 RVA: 0x00914F70 File Offset: 0x00913170
		// (set) Token: 0x0601E7B4 RID: 124852 RVA: 0x00914F84 File Offset: 0x00913184
		public unsafe FLinearColor ST_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_TopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_TopColor) = value;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0601E7B5 RID: 124853 RVA: 0x00914F99 File Offset: 0x00913199
		// (set) Token: 0x0601E7B6 RID: 124854 RVA: 0x00914FAD File Offset: 0x009131AD
		public unsafe FLinearColor ST_DomeColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_DomeColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_DomeColorTint) = value;
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0601E7B7 RID: 124855 RVA: 0x00914FC2 File Offset: 0x009131C2
		// (set) Token: 0x0601E7B8 RID: 124856 RVA: 0x00914FD2 File Offset: 0x009131D2
		public unsafe float ST_TopWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_TopWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ST_TopWidth) = value;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0601E7B9 RID: 124857 RVA: 0x00914FE3 File Offset: 0x009131E3
		// (set) Token: 0x0601E7BA RID: 124858 RVA: 0x00914FF7 File Offset: 0x009131F7
		public unsafe UCurveFloat CharMainLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharMainLightCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharMainLightCurve, value);
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0601E7BB RID: 124859 RVA: 0x0091500C File Offset: 0x0091320C
		// (set) Token: 0x0601E7BC RID: 124860 RVA: 0x00915020 File Offset: 0x00913220
		public unsafe UCurveFloat CharSkyLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharSkyLightCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharSkyLightCurve, value);
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0601E7BD RID: 124861 RVA: 0x00915035 File Offset: 0x00913235
		// (set) Token: 0x0601E7BE RID: 124862 RVA: 0x00915045 File Offset: 0x00913245
		public unsafe bool UseCharCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UseCharCustomLighting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UseCharCustomLighting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0601E7BF RID: 124863 RVA: 0x00915056 File Offset: 0x00913256
		// (set) Token: 0x0601E7C0 RID: 124864 RVA: 0x0091506A File Offset: 0x0091326A
		public unsafe FLinearColor CharAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharAmbientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharAmbientColor) = value;
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0601E7C1 RID: 124865 RVA: 0x0091507F File Offset: 0x0091327F
		// (set) Token: 0x0601E7C2 RID: 124866 RVA: 0x00915093 File Offset: 0x00913293
		public unsafe FLinearColor CharSkinAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharSkinAmbientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CharSkinAmbientColor) = value;
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0601E7C3 RID: 124867 RVA: 0x009150A8 File Offset: 0x009132A8
		// (set) Token: 0x0601E7C4 RID: 124868 RVA: 0x009150BC File Offset: 0x009132BC
		public unsafe UCurveFloat CharShadowCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharShadowCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_CharShadowCurve, value);
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0601E7C5 RID: 124869 RVA: 0x009150D1 File Offset: 0x009132D1
		// (set) Token: 0x0601E7C6 RID: 124870 RVA: 0x009150E5 File Offset: 0x009132E5
		public unsafe UMaterialInstance LightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionMaterial, value);
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0601E7C7 RID: 124871 RVA: 0x009150FA File Offset: 0x009132FA
		// (set) Token: 0x0601E7C8 RID: 124872 RVA: 0x0091510A File Offset: 0x0091330A
		public unsafe float LightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_LightFunctionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_LightFunctionIntensity) = value;
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0601E7C9 RID: 124873 RVA: 0x0091511B File Offset: 0x0091331B
		// (set) Token: 0x0601E7CA RID: 124874 RVA: 0x0091512F File Offset: 0x0091332F
		public unsafe UMaterialInstanceDynamic LightFunctionDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionDMI, value);
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0601E7CB RID: 124875 RVA: 0x00915144 File Offset: 0x00913344
		// (set) Token: 0x0601E7CC RID: 124876 RVA: 0x00915154 File Offset: 0x00913354
		public unsafe bool DEBUG开启无音区特殊地表
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG开启无音区特殊地表) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG开启无音区特殊地表) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0601E7CD RID: 124877 RVA: 0x00915165 File Offset: 0x00913365
		// (set) Token: 0x0601E7CE RID: 124878 RVA: 0x00915179 File Offset: 0x00913379
		public unsafe UMaterialInstance LensFlareMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LensFlareMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LensFlareMI, value);
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0601E7CF RID: 124879 RVA: 0x0091518E File Offset: 0x0091338E
		// (set) Token: 0x0601E7D0 RID: 124880 RVA: 0x009151A2 File Offset: 0x009133A2
		public unsafe UMaterialInstanceDynamic LensFlareDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LensFlareDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LensFlareDMI, value);
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0601E7D1 RID: 124881 RVA: 0x009151B7 File Offset: 0x009133B7
		// (set) Token: 0x0601E7D2 RID: 124882 RVA: 0x009151CB File Offset: 0x009133CB
		public unsafe UMaterialInstance MobileLensFlareMI_Ghost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareMI_Ghost);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareMI_Ghost, value);
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0601E7D3 RID: 124883 RVA: 0x009151E0 File Offset: 0x009133E0
		// (set) Token: 0x0601E7D4 RID: 124884 RVA: 0x009151F4 File Offset: 0x009133F4
		public unsafe FLinearColor Nadir_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Nadir_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Nadir_Color) = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0601E7D5 RID: 124885 RVA: 0x00915209 File Offset: 0x00913409
		// (set) Token: 0x0601E7D6 RID: 124886 RVA: 0x00915219 File Offset: 0x00913419
		public unsafe float Nadir_Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Nadir_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Nadir_Falloff) = value;
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0601E7D7 RID: 124887 RVA: 0x0091522A File Offset: 0x0091342A
		// (set) Token: 0x0601E7D8 RID: 124888 RVA: 0x0091523A File Offset: 0x0091343A
		public unsafe float Sun_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sun_Scatter_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sun_Scatter_Size) = value;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0601E7D9 RID: 124889 RVA: 0x0091524B File Offset: 0x0091344B
		// (set) Token: 0x0601E7DA RID: 124890 RVA: 0x0091525B File Offset: 0x0091345B
		public unsafe float Moon_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Moon_Scatter_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Moon_Scatter_Size) = value;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0601E7DB RID: 124891 RVA: 0x0091526C File Offset: 0x0091346C
		// (set) Token: 0x0601E7DC RID: 124892 RVA: 0x00915280 File Offset: 0x00913480
		public unsafe UMaterialInstance StarsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_StarsMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_StarsMaterial, value);
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0601E7DD RID: 124893 RVA: 0x00915295 File Offset: 0x00913495
		// (set) Token: 0x0601E7DE RID: 124894 RVA: 0x009152A5 File Offset: 0x009134A5
		public unsafe float MainDirectionLightUpdateThreshold_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainDirectionLightUpdateThreshold_Mobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainDirectionLightUpdateThreshold_Mobile) = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0601E7DF RID: 124895 RVA: 0x009152B6 File Offset: 0x009134B6
		// (set) Token: 0x0601E7E0 RID: 124896 RVA: 0x009152C6 File Offset: 0x009134C6
		public unsafe float MainDirectionLightUpdateThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainDirectionLightUpdateThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_MainDirectionLightUpdateThreshold) = value;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0601E7E1 RID: 124897 RVA: 0x009152D7 File Offset: 0x009134D7
		// (set) Token: 0x0601E7E2 RID: 124898 RVA: 0x009152EB File Offset: 0x009134EB
		public unsafe FVector GlobalWindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_GlobalWindDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_GlobalWindDirection) = value;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0601E7E3 RID: 124899 RVA: 0x00915300 File Offset: 0x00913500
		// (set) Token: 0x0601E7E4 RID: 124900 RVA: 0x00915314 File Offset: 0x00913514
		public unsafe FVector GlobalWindRightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_GlobalWindRightDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_GlobalWindRightDirection) = value;
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0601E7E5 RID: 124901 RVA: 0x00915329 File Offset: 0x00913529
		// (set) Token: 0x0601E7E6 RID: 124902 RVA: 0x00915339 File Offset: 0x00913539
		public unsafe float DEBUG无音区特殊地表强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG无音区特殊地表强度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG无音区特殊地表强度) = value;
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0601E7E7 RID: 124903 RVA: 0x0091534A File Offset: 0x0091354A
		// (set) Token: 0x0601E7E8 RID: 124904 RVA: 0x0091535A File Offset: 0x0091355A
		public unsafe float RealTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RealTimeOfDay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RealTimeOfDay) = value;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0601E7E9 RID: 124905 RVA: 0x0091536B File Offset: 0x0091356B
		// (set) Token: 0x0601E7EA RID: 124906 RVA: 0x0091537F File Offset: 0x0091357F
		public unsafe BP_Clouds_C DynamicCloudsActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Clouds_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_DynamicCloudsActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_DynamicCloudsActor, value);
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0601E7EB RID: 124907 RVA: 0x00915394 File Offset: 0x00913594
		// (set) Token: 0x0601E7EC RID: 124908 RVA: 0x009153A4 File Offset: 0x009135A4
		public unsafe float RainDensityChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainDensityChangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainDensityChangeSpeed) = value;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0601E7ED RID: 124909 RVA: 0x009153B5 File Offset: 0x009135B5
		// (set) Token: 0x0601E7EE RID: 124910 RVA: 0x009153C5 File Offset: 0x009135C5
		public unsafe float RainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainDensity) = value;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0601E7EF RID: 124911 RVA: 0x009153D6 File Offset: 0x009135D6
		// (set) Token: 0x0601E7F0 RID: 124912 RVA: 0x009153E6 File Offset: 0x009135E6
		public unsafe float SnowDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SnowDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SnowDensity) = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0601E7F1 RID: 124913 RVA: 0x009153F7 File Offset: 0x009135F7
		// (set) Token: 0x0601E7F2 RID: 124914 RVA: 0x00915407 File Offset: 0x00913607
		public unsafe float RainGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainGravity) = value;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0601E7F3 RID: 124915 RVA: 0x00915418 File Offset: 0x00913618
		// (set) Token: 0x0601E7F4 RID: 124916 RVA: 0x00915428 File Offset: 0x00913628
		public unsafe float RainGravityChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainGravityChangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainGravityChangeSpeed) = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0601E7F5 RID: 124917 RVA: 0x00915439 File Offset: 0x00913639
		// (set) Token: 0x0601E7F6 RID: 124918 RVA: 0x00915449 File Offset: 0x00913649
		public unsafe float RainWindPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainWindPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainWindPower) = value;
			}
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0601E7F7 RID: 124919 RVA: 0x0091545A File Offset: 0x0091365A
		// (set) Token: 0x0601E7F8 RID: 124920 RVA: 0x0091546A File Offset: 0x0091366A
		public unsafe float RainWindPowerChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainWindPowerChangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_RainWindPowerChangeSpeed) = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0601E7F9 RID: 124921 RVA: 0x0091547B File Offset: 0x0091367B
		// (set) Token: 0x0601E7FA RID: 124922 RVA: 0x0091548B File Offset: 0x0091368B
		public unsafe bool CanSpawnEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CanSpawnEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CanSpawnEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0601E7FB RID: 124923 RVA: 0x0091549C File Offset: 0x0091369C
		// (set) Token: 0x0601E7FC RID: 124924 RVA: 0x009154AC File Offset: 0x009136AC
		public unsafe float FinalSnowDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalSnowDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalSnowDensity) = value;
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0601E7FD RID: 124925 RVA: 0x009154BD File Offset: 0x009136BD
		// (set) Token: 0x0601E7FE RID: 124926 RVA: 0x009154CD File Offset: 0x009136CD
		public unsafe float FinalRainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalRainDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalRainDensity) = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0601E7FF RID: 124927 RVA: 0x009154DE File Offset: 0x009136DE
		// (set) Token: 0x0601E800 RID: 124928 RVA: 0x009154EE File Offset: 0x009136EE
		public unsafe float FinalRainGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalRainGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FinalRainGravity) = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0601E801 RID: 124929 RVA: 0x009154FF File Offset: 0x009136FF
		// (set) Token: 0x0601E802 RID: 124930 RVA: 0x0091550F File Offset: 0x0091370F
		public unsafe float DefaultSkyLightShadowSupplement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DefaultSkyLightShadowSupplement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DefaultSkyLightShadowSupplement) = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0601E803 RID: 124931 RVA: 0x00915520 File Offset: 0x00913720
		// (set) Token: 0x0601E804 RID: 124932 RVA: 0x00915530 File Offset: 0x00913730
		public unsafe float DefaultSkyLightReflectionAddIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DefaultSkyLightReflectionAddIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DefaultSkyLightReflectionAddIntensity) = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0601E805 RID: 124933 RVA: 0x00915541 File Offset: 0x00913741
		// (set) Token: 0x0601E806 RID: 124934 RVA: 0x00915555 File Offset: 0x00913755
		public unsafe UMaterialInstance MobileLensFlareMI_Halo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareMI_Halo);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareMI_Halo, value);
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0601E807 RID: 124935 RVA: 0x0091556A File Offset: 0x0091376A
		// (set) Token: 0x0601E808 RID: 124936 RVA: 0x0091557E File Offset: 0x0091377E
		public unsafe UMaterialInstanceDynamic MobileLensFlareDMI_Ghost
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareDMI_Ghost);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareDMI_Ghost, value);
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0601E809 RID: 124937 RVA: 0x00915593 File Offset: 0x00913793
		// (set) Token: 0x0601E80A RID: 124938 RVA: 0x009155A7 File Offset: 0x009137A7
		public unsafe UMaterialInstanceDynamic MobileLensFlareDMI_Halo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareDMI_Halo);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MobileLensFlareDMI_Halo, value);
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0601E80B RID: 124939 RVA: 0x009155BC File Offset: 0x009137BC
		// (set) Token: 0x0601E80C RID: 124940 RVA: 0x009155D0 File Offset: 0x009137D0
		public unsafe UTexture2D HeightMapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_HeightMapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_HeightMapTexture, value);
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0601E80D RID: 124941 RVA: 0x009155E5 File Offset: 0x009137E5
		// (set) Token: 0x0601E80E RID: 124942 RVA: 0x009155F5 File Offset: 0x009137F5
		public unsafe bool HeightMapUpdated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HeightMapUpdated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_HeightMapUpdated) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0601E80F RID: 124943 RVA: 0x00915606 File Offset: 0x00913806
		// (set) Token: 0x0601E810 RID: 124944 RVA: 0x0091561A File Offset: 0x0091381A
		public unsafe FVector SunLightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunLightDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_SunLightDirection) = value;
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0601E811 RID: 124945 RVA: 0x0091562F File Offset: 0x0091382F
		// (set) Token: 0x0601E812 RID: 124946 RVA: 0x0091563F File Offset: 0x0091383F
		public unsafe bool IsComponentsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsComponentsEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_IsComponentsEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0601E813 RID: 124947 RVA: 0x00915650 File Offset: 0x00913850
		// (set) Token: 0x0601E814 RID: 124948 RVA: 0x00915664 File Offset: 0x00913864
		public unsafe UTexture Last_LightFunction_Map
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Last_LightFunction_Map);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Last_LightFunction_Map, value);
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0601E815 RID: 124949 RVA: 0x00915679 File Offset: 0x00913879
		// (set) Token: 0x0601E816 RID: 124950 RVA: 0x0091568D File Offset: 0x0091388D
		public unsafe UTexture InitLightFunctionMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_InitLightFunctionMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_InitLightFunctionMap, value);
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0601E817 RID: 124951 RVA: 0x009156A2 File Offset: 0x009138A2
		// (set) Token: 0x0601E818 RID: 124952 RVA: 0x009156B2 File Offset: 0x009138B2
		public unsafe float TODLightLoadingWait
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TODLightLoadingWait);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TODLightLoadingWait) = value;
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0601E819 RID: 124953 RVA: 0x009156C3 File Offset: 0x009138C3
		// (set) Token: 0x0601E81A RID: 124954 RVA: 0x009156D3 File Offset: 0x009138D3
		public unsafe float DayLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DayLightLoadingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DayLightLoadingTime) = value;
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0601E81B RID: 124955 RVA: 0x009156E4 File Offset: 0x009138E4
		// (set) Token: 0x0601E81C RID: 124956 RVA: 0x009156F4 File Offset: 0x009138F4
		public unsafe float NightLightLoadingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NightLightLoadingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NightLightLoadingTime) = value;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0601E81D RID: 124957 RVA: 0x00915705 File Offset: 0x00913905
		// (set) Token: 0x0601E81E RID: 124958 RVA: 0x00915715 File Offset: 0x00913915
		public unsafe int ComputeLightGridSkipFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ComputeLightGridSkipFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ComputeLightGridSkipFrames) = value;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0601E81F RID: 124959 RVA: 0x00915726 File Offset: 0x00913926
		// (set) Token: 0x0601E820 RID: 124960 RVA: 0x0091573A File Offset: 0x0091393A
		public unsafe UMaterialInstance MilkyWayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MilkyWayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_MilkyWayMaterial, value);
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0601E821 RID: 124961 RVA: 0x0091574F File Offset: 0x0091394F
		// (set) Token: 0x0601E822 RID: 124962 RVA: 0x0091575F File Offset: 0x0091395F
		public unsafe bool 使用主角位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用主角位置) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_使用主角位置) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0601E823 RID: 124963 RVA: 0x00915770 File Offset: 0x00913970
		// (set) Token: 0x0601E824 RID: 124964 RVA: 0x00915780 File Offset: 0x00913980
		public unsafe float DEBUG_角色预览方向光垂直方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_角色预览方向光垂直方向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DEBUG_角色预览方向光垂直方向) = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0601E825 RID: 124965 RVA: 0x00915794 File Offset: 0x00913994
		// (set) Token: 0x0601E826 RID: 124966 RVA: 0x009157CD File Offset: 0x009139CD
		[Nullable(1)]
		public FKuroCurveFloat FogTImeControl
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogTImeControl) == null)
				{
					result = (this._FogTImeControl = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FogTImeControl, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_FogTImeControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0601E827 RID: 124967 RVA: 0x009157EE File Offset: 0x009139EE
		// (set) Token: 0x0601E828 RID: 124968 RVA: 0x009157FE File Offset: 0x009139FE
		public unsafe bool Is_Editor_Update
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Is_Editor_Update) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Is_Editor_Update) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0601E829 RID: 124969 RVA: 0x0091580F File Offset: 0x00913A0F
		// (set) Token: 0x0601E82A RID: 124970 RVA: 0x0091581F File Offset: 0x00913A1F
		public unsafe bool EnableImposterUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableImposterUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableImposterUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0601E82B RID: 124971 RVA: 0x00915830 File Offset: 0x00913A30
		// (set) Token: 0x0601E82C RID: 124972 RVA: 0x00915840 File Offset: 0x00913A40
		public unsafe float Clouds_Change_CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_CD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_CD) = value;
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0601E82D RID: 124973 RVA: 0x00915851 File Offset: 0x00913A51
		// (set) Token: 0x0601E82E RID: 124974 RVA: 0x00915861 File Offset: 0x00913A61
		public unsafe float Clouds_Change_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_Time) = value;
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0601E82F RID: 124975 RVA: 0x00915872 File Offset: 0x00913A72
		// (set) Token: 0x0601E830 RID: 124976 RVA: 0x00915882 File Offset: 0x00913A82
		public unsafe float Clouds_Change_Time_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_Time_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Clouds_Change_Time_0) = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0601E831 RID: 124977 RVA: 0x00915893 File Offset: 0x00913A93
		// (set) Token: 0x0601E832 RID: 124978 RVA: 0x009158A3 File Offset: 0x00913AA3
		public unsafe bool 启用时间参数写入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_启用时间参数写入) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_启用时间参数写入) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0601E833 RID: 124979 RVA: 0x009158B4 File Offset: 0x00913AB4
		// (set) Token: 0x0601E834 RID: 124980 RVA: 0x009158C4 File Offset: 0x00913AC4
		public unsafe bool UINeedLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UINeedLerpData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UINeedLerpData) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0601E835 RID: 124981 RVA: 0x009158D5 File Offset: 0x00913AD5
		// (set) Token: 0x0601E836 RID: 124982 RVA: 0x009158E5 File Offset: 0x00913AE5
		public unsafe bool bEnableLumen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableLumen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableLumen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0601E837 RID: 124983 RVA: 0x009158F6 File Offset: 0x00913AF6
		// (set) Token: 0x0601E838 RID: 124984 RVA: 0x0091590A File Offset: 0x00913B0A
		public unsafe UMaterialInstance LightFunctionMaterial_seq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionMaterial_seq);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_LightFunctionMaterial_seq, value);
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0601E839 RID: 124985 RVA: 0x0091591F File Offset: 0x00913B1F
		// (set) Token: 0x0601E83A RID: 124986 RVA: 0x0091592F File Offset: 0x00913B2F
		public unsafe bool Override_Cloud_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Override_Cloud_Rotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Override_Cloud_Rotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0601E83B RID: 124987 RVA: 0x00915940 File Offset: 0x00913B40
		// (set) Token: 0x0601E83C RID: 124988 RVA: 0x00915950 File Offset: 0x00913B50
		public unsafe float Sequence_Cloud_Time_Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sequence_Cloud_Time_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sequence_Cloud_Time_Control) = value;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0601E83D RID: 124989 RVA: 0x00915961 File Offset: 0x00913B61
		// (set) Token: 0x0601E83E RID: 124990 RVA: 0x00915971 File Offset: 0x00913B71
		public unsafe float Sequence_Cloud_Time_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sequence_Cloud_Time_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Sequence_Cloud_Time_Offset) = value;
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0601E83F RID: 124991 RVA: 0x00915982 File Offset: 0x00913B82
		// (set) Token: 0x0601E840 RID: 124992 RVA: 0x00915996 File Offset: 0x00913B96
		public unsafe UMaterialInstance VolumetricLightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_VolumetricLightFunctionMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_VolumetricLightFunctionMaterial, value);
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0601E841 RID: 124993 RVA: 0x009159AB File Offset: 0x00913BAB
		// (set) Token: 0x0601E842 RID: 124994 RVA: 0x009159BB File Offset: 0x00913BBB
		public unsafe bool PerformanceLightExist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PerformanceLightExist) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PerformanceLightExist) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0601E843 RID: 124995 RVA: 0x009159CC File Offset: 0x00913BCC
		// (set) Token: 0x0601E844 RID: 124996 RVA: 0x009159DC File Offset: 0x00913BDC
		public unsafe bool bEnableAutoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableAutoExposure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableAutoExposure) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0601E845 RID: 124997 RVA: 0x009159ED File Offset: 0x00913BED
		// (set) Token: 0x0601E846 RID: 124998 RVA: 0x009159FD File Offset: 0x00913BFD
		public unsafe bool PerformanceLightExist_MP4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PerformanceLightExist_MP4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_PerformanceLightExist_MP4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0601E847 RID: 124999 RVA: 0x00915A0E File Offset: 0x00913C0E
		// (set) Token: 0x0601E848 RID: 125000 RVA: 0x00915A1E File Offset: 0x00913C1E
		public unsafe bool BPScreenFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_BPScreenFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_BPScreenFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0601E849 RID: 125001 RVA: 0x00915A2F File Offset: 0x00913C2F
		// (set) Token: 0x0601E84A RID: 125002 RVA: 0x00915A43 File Offset: 0x00913C43
		public unsafe UMaterialInstance Star_Material_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Star_Material_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_Star_Material_V2, value);
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0601E84B RID: 125003 RVA: 0x00915A58 File Offset: 0x00913C58
		// (set) Token: 0x0601E84C RID: 125004 RVA: 0x00915A68 File Offset: 0x00913C68
		public unsafe bool bCurrentPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bCurrentPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bCurrentPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0601E84D RID: 125005 RVA: 0x00915A79 File Offset: 0x00913C79
		// (set) Token: 0x0601E84E RID: 125006 RVA: 0x00915A89 File Offset: 0x00913C89
		public unsafe bool bSetDailyRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bSetDailyRandom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bSetDailyRandom) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0601E84F RID: 125007 RVA: 0x00915A9A File Offset: 0x00913C9A
		// (set) Token: 0x0601E850 RID: 125008 RVA: 0x00915AAE File Offset: 0x00913CAE
		public unsafe UMaterialInstance FrozenMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_FrozenMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_FrozenMaterial, value);
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0601E851 RID: 125009 RVA: 0x00915AC3 File Offset: 0x00913CC3
		// (set) Token: 0x0601E852 RID: 125010 RVA: 0x00915AD7 File Offset: 0x00913CD7
		public unsafe UMaterialInstanceDynamic FrozenDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_FrozenDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_C.__PropertyOffset_FrozenDMI, value);
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0601E853 RID: 125011 RVA: 0x00915AEC File Offset: 0x00913CEC
		// (set) Token: 0x0601E854 RID: 125012 RVA: 0x00915AFC File Offset: 0x00913CFC
		public unsafe float TimeTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TimeTotal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_TimeTotal) = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0601E855 RID: 125013 RVA: 0x00915B0D File Offset: 0x00913D0D
		// (set) Token: 0x0601E856 RID: 125014 RVA: 0x00915B1D File Offset: 0x00913D1D
		public unsafe bool ChangeFrozen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ChangeFrozen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_ChangeFrozen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0601E857 RID: 125015 RVA: 0x00915B2E File Offset: 0x00913D2E
		// (set) Token: 0x0601E858 RID: 125016 RVA: 0x00915B3E File Offset: 0x00913D3E
		public unsafe bool Ini
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Ini) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Ini) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0601E859 RID: 125017 RVA: 0x00915B4F File Offset: 0x00913D4F
		// (set) Token: 0x0601E85A RID: 125018 RVA: 0x00915B5F File Offset: 0x00913D5F
		public unsafe bool NeedDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0601E85B RID: 125019 RVA: 0x00915B70 File Offset: 0x00913D70
		// (set) Token: 0x0601E85C RID: 125020 RVA: 0x00915B80 File Offset: 0x00913D80
		public unsafe float Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Change_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_Change_Speed) = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0601E85D RID: 125021 RVA: 0x00915B91 File Offset: 0x00913D91
		// (set) Token: 0x0601E85E RID: 125022 RVA: 0x00915BA1 File Offset: 0x00913DA1
		public unsafe bool CloudControlDoOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CloudControlDoOnce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CloudControlDoOnce) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0601E85F RID: 125023 RVA: 0x00915BB4 File Offset: 0x00913DB4
		// (set) Token: 0x0601E860 RID: 125024 RVA: 0x00915BED File Offset: 0x00913DED
		[Nullable(1)]
		public TArray<string> CommandToolStartArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CommandToolStartArray) == null)
				{
					result = (this._CommandToolStartArray = new TArray<string>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CommandToolStartArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolStartArray.CopyAssign(value);
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0601E861 RID: 125025 RVA: 0x00915BFC File Offset: 0x00913DFC
		// (set) Token: 0x0601E862 RID: 125026 RVA: 0x00915C35 File Offset: 0x00913E35
		[Nullable(1)]
		public TArray<string> CommandToolEndArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CommandToolEndArray) == null)
				{
					result = (this._CommandToolEndArray = new TArray<string>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CommandToolEndArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolEndArray.CopyAssign(value);
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0601E863 RID: 125027 RVA: 0x00915C44 File Offset: 0x00913E44
		// (set) Token: 0x0601E864 RID: 125028 RVA: 0x00915C7D File Offset: 0x00913E7D
		[Nullable(1)]
		public TArray<float> CommandToolOriginalValueArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CommandToolOriginalValueArray) == null)
				{
					result = (this._CommandToolOriginalValueArray = new TArray<float>(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CommandToolOriginalValueArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CommandToolOriginalValueArray.CopyAssign(value);
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0601E865 RID: 125029 RVA: 0x00915C8B File Offset: 0x00913E8B
		// (set) Token: 0x0601E866 RID: 125030 RVA: 0x00915C9B File Offset: 0x00913E9B
		public unsafe bool NeedResetActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedResetActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedResetActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0601E867 RID: 125031 RVA: 0x00915CAC File Offset: 0x00913EAC
		// (set) Token: 0x0601E868 RID: 125032 RVA: 0x00915CBC File Offset: 0x00913EBC
		public unsafe bool NeedRunEndCommand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedRunEndCommand) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_NeedRunEndCommand) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0601E869 RID: 125033 RVA: 0x00915CCD File Offset: 0x00913ECD
		// (set) Token: 0x0601E86A RID: 125034 RVA: 0x00915CDD File Offset: 0x00913EDD
		public unsafe float CloudsCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CloudsCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_CloudsCD) = value;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0601E86B RID: 125035 RVA: 0x00915CEE File Offset: 0x00913EEE
		// (set) Token: 0x0601E86C RID: 125036 RVA: 0x00915CFE File Offset: 0x00913EFE
		public unsafe int UpdateSkylightBlendNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UpdateSkylightBlendNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_UpdateSkylightBlendNum) = value;
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0601E86D RID: 125037 RVA: 0x00915D0F File Offset: 0x00913F0F
		// (set) Token: 0x0601E86E RID: 125038 RVA: 0x00915D1F File Offset: 0x00913F1F
		public unsafe bool EnableSetSkyBlendingSkipCVar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableSetSkyBlendingSkipCVar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_EnableSetSkyBlendingSkipCVar) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0601E86F RID: 125039 RVA: 0x00915D30 File Offset: 0x00913F30
		// (set) Token: 0x0601E870 RID: 125040 RVA: 0x00915D40 File Offset: 0x00913F40
		public unsafe bool DoOnceSetSkyBlendingSkipCVar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DoOnceSetSkyBlendingSkipCVar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_DoOnceSetSkyBlendingSkipCVar) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0601E871 RID: 125041 RVA: 0x00915D51 File Offset: 0x00913F51
		// (set) Token: 0x0601E872 RID: 125042 RVA: 0x00915D61 File Offset: 0x00913F61
		public unsafe bool bEnableUpdateTimeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableUpdateTimeTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_C.__PropertyOffset_bEnableUpdateTimeTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E873 RID: 125043 RVA: 0x00915D72 File Offset: 0x00913F72
		[SkipLocalsInit]
		public virtual void UodateSkylightBlendTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UodateSkylightBlendTick_NativeFunctionPtr, null);
		}

		// Token: 0x0601E874 RID: 125044 RVA: 0x00915D86 File Offset: 0x00913F86
		[SkipLocalsInit]
		public virtual void UpdateVolumeCloudGodRay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateVolumeCloudGodRay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E875 RID: 125045 RVA: 0x00915D9A File Offset: 0x00913F9A
		[SkipLocalsInit]
		public virtual void OnGlobalGITick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnGlobalGITick_NativeFunctionPtr, null);
		}

		// Token: 0x0601E876 RID: 125046 RVA: 0x00915DAE File Offset: 0x00913FAE
		[SkipLocalsInit]
		public virtual void UpdateMeshBlend()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateMeshBlend_NativeFunctionPtr, null);
		}

		// Token: 0x0601E877 RID: 125047 RVA: 0x00915DC2 File Offset: 0x00913FC2
		[SkipLocalsInit]
		public virtual void ToggleShowDynamicSkyPlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__ToggleShowDynamicSkyPlatform_NativeFunctionPtr, null);
		}

		// Token: 0x0601E878 RID: 125048 RVA: 0x00915DD6 File Offset: 0x00913FD6
		[SkipLocalsInit]
		public virtual void UpadteVolumertricCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpadteVolumertricCloud_NativeFunctionPtr, null);
		}

		// Token: 0x0601E879 RID: 125049 RVA: 0x00915DEA File Offset: 0x00913FEA
		[SkipLocalsInit]
		public virtual void UpdateCharacterRootPos()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateCharacterRootPos_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87A RID: 125050 RVA: 0x00915DFE File Offset: 0x00913FFE
		[SkipLocalsInit]
		public virtual void Set_GIControlParamToGlobalShaderParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Set_GIControlParamToGlobalShaderParam_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87B RID: 125051 RVA: 0x00915E12 File Offset: 0x00914012
		[SkipLocalsInit]
		public virtual void UpdateOriginSkyAtmosphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateOriginSkyAtmosphere_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87C RID: 125052 RVA: 0x00915E26 File Offset: 0x00914026
		[SkipLocalsInit]
		public virtual void UpdateVolumeCloudLightWeight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateVolumeCloudLightWeight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87D RID: 125053 RVA: 0x00915E3A File Offset: 0x0091403A
		[SkipLocalsInit]
		public virtual void IsPerformanceLightExist()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__IsPerformanceLightExist_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87E RID: 125054 RVA: 0x00915E4E File Offset: 0x0091404E
		[SkipLocalsInit]
		public virtual void UpdateOcean()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateOcean_NativeFunctionPtr, null);
		}

		// Token: 0x0601E87F RID: 125055 RVA: 0x00915E62 File Offset: 0x00914062
		[SkipLocalsInit]
		public virtual void UpdateFrozen()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFrozen_NativeFunctionPtr, null);
		}

		// Token: 0x0601E880 RID: 125056 RVA: 0x00915E76 File Offset: 0x00914076
		[SkipLocalsInit]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x0601E881 RID: 125057 RVA: 0x00915E8A File Offset: 0x0091408A
		[SkipLocalsInit]
		public virtual void UpdateBigWorld()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateBigWorld_NativeFunctionPtr, null);
		}

		// Token: 0x0601E882 RID: 125058 RVA: 0x00915EA0 File Offset: 0x009140A0
		[SkipLocalsInit]
		public unsafe virtual void GetMilkyWayDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetMilkyWayDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetMilkyWayDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetMilkyWayDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x0601E883 RID: 125059 RVA: 0x00915F04 File Offset: 0x00914104
		[SkipLocalsInit]
		public virtual void updateLightFunctions()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__updateLightFunctions_NativeFunctionPtr, null);
		}

		// Token: 0x0601E884 RID: 125060 RVA: 0x00915F18 File Offset: 0x00914118
		[SkipLocalsInit]
		public unsafe virtual void GetParallaxCorrectCachedCrossFadeShadowDirection(ref FRotator NewParam)
		{
			BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0601E885 RID: 125061 RVA: 0x00915F70 File Offset: 0x00914170
		[SkipLocalsInit]
		public unsafe virtual void GetTODCharacterLighting(FLinearColor mainLight, float mainLightIntensity, FLinearColor skyLight, float skyLightIntensity, ref FLinearColor FrontSideLight, ref FLinearColor BackSideLight)
		{
			BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_GlobalGI_C.__GetTODCharacterLighting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mainLight = mainLight;
			ptr->mainLightIntensity = mainLightIntensity;
			ptr->skyLight = skyLight;
			ptr->skyLightIntensity = skyLightIntensity;
			ptr->FrontSideLight = FrontSideLight;
			ptr->BackSideLight = BackSideLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr);
			FrontSideLight = ptr->FrontSideLight;
			BackSideLight = ptr->BackSideLight;
		}

		// Token: 0x0601E886 RID: 125062 RVA: 0x00916004 File Offset: 0x00914204
		[SkipLocalsInit]
		public unsafe virtual void GetParallaxCorrectCachedShadowDirection(ref FRotator NewParam)
		{
			BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0601E887 RID: 125063 RVA: 0x0091605C File Offset: 0x0091425C
		[SkipLocalsInit]
		public unsafe virtual FLinearColor Clamp_Luminance(FLinearColor InColor, float Min, float Max)
		{
			BP_GlobalGI_C.__Clamp_Luminance_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Clamp_Luminance_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(BP_GlobalGI_C.__Clamp_Luminance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InColor = InColor;
			ptr->Min = Min;
			ptr->Max = Max;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601E888 RID: 125064 RVA: 0x009160B8 File Offset: 0x009142B8
		[SkipLocalsInit]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_GlobalGI_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601E889 RID: 125065 RVA: 0x0091610B File Offset: 0x0091430B
		[SkipLocalsInit]
		public virtual void Update_Dynamic_Clouds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Dynamic_Clouds_NativeFunctionPtr, null);
		}

		// Token: 0x0601E88A RID: 125066 RVA: 0x00916120 File Offset: 0x00914320
		[SkipLocalsInit]
		public unsafe virtual void GetStarsDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetStarsDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetStarsDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetStarsDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetStarsDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetStarsDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x0601E88B RID: 125067 RVA: 0x00916184 File Offset: 0x00914384
		[SkipLocalsInit]
		public virtual void UpdateClusteredStuff()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateClusteredStuff_NativeFunctionPtr, null);
		}

		// Token: 0x0601E88C RID: 125068 RVA: 0x00916198 File Offset: 0x00914398
		[SkipLocalsInit]
		public unsafe virtual void GetSkyboxDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_C.__GetSkyboxDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x0601E88D RID: 125069 RVA: 0x009161FC File Offset: 0x009143FC
		[SkipLocalsInit]
		public virtual void UpdateSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x0601E88E RID: 125070 RVA: 0x00916210 File Offset: 0x00914410
		[SkipLocalsInit]
		public virtual void Update_Misc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Misc_NativeFunctionPtr, null);
		}

		// Token: 0x0601E88F RID: 125071 RVA: 0x00916224 File Offset: 0x00914424
		[SkipLocalsInit]
		public virtual void UpdateFlowmapSkybox()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFlowmapSkybox_NativeFunctionPtr, null);
		}

		// Token: 0x0601E890 RID: 125072 RVA: 0x00916238 File Offset: 0x00914438
		[SkipLocalsInit]
		public virtual void 申时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__申时_NativeFunctionPtr, null);
		}

		// Token: 0x0601E891 RID: 125073 RVA: 0x0091624C File Offset: 0x0091444C
		[SkipLocalsInit]
		public virtual void 下午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__下午_NativeFunctionPtr, null);
		}

		// Token: 0x0601E892 RID: 125074 RVA: 0x00916260 File Offset: 0x00914460
		[SkipLocalsInit]
		public virtual void 上午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__上午_NativeFunctionPtr, null);
		}

		// Token: 0x0601E893 RID: 125075 RVA: 0x00916274 File Offset: 0x00914474
		[SkipLocalsInit]
		public virtual void 辰时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__辰时_NativeFunctionPtr, null);
		}

		// Token: 0x0601E894 RID: 125076 RVA: 0x00916288 File Offset: 0x00914488
		[SkipLocalsInit]
		public virtual void Update_Day_Night_Data_Layer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Day_Night_Data_Layer_NativeFunctionPtr, null);
		}

		// Token: 0x0601E895 RID: 125077 RVA: 0x0091629C File Offset: 0x0091449C
		[SkipLocalsInit]
		public virtual void 夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E896 RID: 125078 RVA: 0x009162B0 File Offset: 0x009144B0
		[SkipLocalsInit]
		public virtual void 夜晚到清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__夜晚到清晨_NativeFunctionPtr, null);
		}

		// Token: 0x0601E897 RID: 125079 RVA: 0x009162C4 File Offset: 0x009144C4
		[SkipLocalsInit]
		public virtual void 黄昏到夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__黄昏到夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x0601E898 RID: 125080 RVA: 0x009162D8 File Offset: 0x009144D8
		[SkipLocalsInit]
		public virtual void 黄昏()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__黄昏_NativeFunctionPtr, null);
		}

		// Token: 0x0601E899 RID: 125081 RVA: 0x009162EC File Offset: 0x009144EC
		[SkipLocalsInit]
		public virtual void 中午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__中午_NativeFunctionPtr, null);
		}

		// Token: 0x0601E89A RID: 125082 RVA: 0x00916300 File Offset: 0x00914500
		[SkipLocalsInit]
		public virtual void 清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__清晨_NativeFunctionPtr, null);
		}

		// Token: 0x0601E89B RID: 125083 RVA: 0x00916314 File Offset: 0x00914514
		[SkipLocalsInit]
		public virtual void UpdateSkyDome()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkyDome_NativeFunctionPtr, null);
		}

		// Token: 0x0601E89C RID: 125084 RVA: 0x00916328 File Offset: 0x00914528
		[SkipLocalsInit]
		public virtual void InitGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitGI_NativeFunctionPtr, null);
		}

		// Token: 0x0601E89D RID: 125085 RVA: 0x0091633C File Offset: 0x0091453C
		[SkipLocalsInit]
		public unsafe virtual void Set_All_Components_States(bool IsEnable)
		{
			BP_GlobalGI_C.__Set_All_Components_States_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Set_All_Components_States_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_GlobalGI_C.__Set_All_Components_States_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEnable = IsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E89E RID: 125086 RVA: 0x00916382 File Offset: 0x00914582
		[SkipLocalsInit]
		public virtual void UpdateLightShaft()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateLightShaft_NativeFunctionPtr, null);
		}

		// Token: 0x0601E89F RID: 125087 RVA: 0x00916398 File Offset: 0x00914598
		[SkipLocalsInit]
		public unsafe virtual void GetLightDirectionFromVH(float Vertical, float Horizontal, ref FRotator Result)
		{
			BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__GetLightDirectionFromVH_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601E8A0 RID: 125088 RVA: 0x009163FD File Offset: 0x009145FD
		[SkipLocalsInit]
		public virtual void UpdatePostProcessVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdatePostProcessVolume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A1 RID: 125089 RVA: 0x00916411 File Offset: 0x00914611
		[SkipLocalsInit]
		public virtual void UpdateLightParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateLightParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A2 RID: 125090 RVA: 0x00916425 File Offset: 0x00914625
		[SkipLocalsInit]
		public virtual void Update_Light_Direction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Light_Direction_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A3 RID: 125091 RVA: 0x00916439 File Offset: 0x00914639
		[SkipLocalsInit]
		public virtual void Update_Main_Light()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Main_Light_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A4 RID: 125092 RVA: 0x0091644D File Offset: 0x0091464D
		[SkipLocalsInit]
		public virtual void Update_UI_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_UI_Env_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A5 RID: 125093 RVA: 0x00916461 File Offset: 0x00914661
		[SkipLocalsInit]
		public virtual void UpdateTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateTime_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A6 RID: 125094 RVA: 0x00916478 File Offset: 0x00914678
		[SkipLocalsInit]
		public unsafe virtual void UpdateTimeOnce(float OverrideTime)
		{
			BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateTimeOnce_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateTimeOnce_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverrideTime = OverrideTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateTimeOnce_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8A7 RID: 125095 RVA: 0x009164C0 File Offset: 0x009146C0
		[SkipLocalsInit]
		public unsafe virtual void GetViewLocation(ref FVector WorldPosition, ref bool Suc)
		{
			BP_GlobalGI_C.__GetViewLocation_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__GetViewLocation_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_C.__GetViewLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr);
			WorldPosition = ptr->WorldPosition;
			Suc = ptr->Suc;
		}

		// Token: 0x0601E8A8 RID: 125096 RVA: 0x00916527 File Offset: 0x00914727
		[SkipLocalsInit]
		public virtual void InitFeature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitFeature_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8A9 RID: 125097 RVA: 0x0091653C File Offset: 0x0091473C
		[SkipLocalsInit]
		public unsafe virtual void CalculateLightDirectionWithLimit(float V, float H, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_GlobalGI_C.__CalculateLightDirectionWithLimit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__CalculateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V = V;
			ptr->H = H;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__CalculateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0601E8AA RID: 125098 RVA: 0x009165B0 File Offset: 0x009147B0
		[SkipLocalsInit]
		public unsafe virtual void CalculateLightDirection(float Vertical, float Horizontal, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_C.__CalculateLightDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__CalculateLightDirection_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_C.__CalculateLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0601E8AB RID: 125099 RVA: 0x0091661E File Offset: 0x0091481E
		[SkipLocalsInit]
		public virtual void UpdateAtmosphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateAtmosphere_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8AC RID: 125100 RVA: 0x00916632 File Offset: 0x00914832
		[SkipLocalsInit]
		public virtual void UpdateSkyLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateSkyLight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8AD RID: 125101 RVA: 0x00916648 File Offset: 0x00914848
		[SkipLocalsInit]
		public unsafe virtual void Get_Scene_Light_Direction(ref FVector LightDir)
		{
			BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__Get_Scene_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LightDir = LightDir;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr);
			LightDir = ptr->LightDir;
		}

		// Token: 0x0601E8AE RID: 125102 RVA: 0x0091669F File Offset: 0x0091489F
		[SkipLocalsInit]
		public virtual void InitGICompoemnt()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitGICompoemnt_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8AF RID: 125103 RVA: 0x009166B3 File Offset: 0x009148B3
		[SkipLocalsInit]
		public virtual void InitMaterials()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__InitMaterials_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B0 RID: 125104 RVA: 0x009166C7 File Offset: 0x009148C7
		[SkipLocalsInit]
		public virtual void UpdateWind()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateWind_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B1 RID: 125105 RVA: 0x009166DC File Offset: 0x009148DC
		[SkipLocalsInit]
		public unsafe virtual void Get2SkyboxLerpWeight(float startSetting, float EndSetting, float CurrentTime, ref float Weight)
		{
			BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_GlobalGI_C.__Get2SkyboxLerpWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->startSetting = startSetting;
			ptr->EndSetting = EndSetting;
			ptr->CurrentTime = CurrentTime;
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Get2SkyboxLerpWeight_NativeFunctionPtr, (void*)ptr);
			Weight = ptr->Weight;
		}

		// Token: 0x0601E8B2 RID: 125106 RVA: 0x00916742 File Offset: 0x00914942
		[SkipLocalsInit]
		public virtual void Update_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__Update_Env_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B3 RID: 125107 RVA: 0x00916756 File Offset: 0x00914956
		[SkipLocalsInit]
		public virtual void UpdateFog()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateFog_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B4 RID: 125108 RVA: 0x0091676C File Offset: 0x0091496C
		[SkipLocalsInit]
		public unsafe virtual void UpdateGIData(bool Skip_Lerp_Data)
		{
			BP_GlobalGI_C.__UpdateGIData_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__UpdateGIData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_C.__UpdateGIData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Skip_Lerp_Data = Skip_Lerp_Data;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8B5 RID: 125109 RVA: 0x009167B2 File Offset: 0x009149B2
		[SkipLocalsInit]
		public virtual void UpdateCharacterGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UpdateCharacterGI_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B6 RID: 125110 RVA: 0x009167C6 File Offset: 0x009149C6
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B7 RID: 125111 RVA: 0x009167DA File Offset: 0x009149DA
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8B8 RID: 125112 RVA: 0x009167F0 File Offset: 0x009149F0
		[SkipLocalsInit]
		public unsafe override void OnKuroTickEditor(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8B9 RID: 125113 RVA: 0x00916838 File Offset: 0x00914A38
		[SkipLocalsInit]
		protected unsafe virtual void OnKuroTickEditor_Implementation(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8BA RID: 125114 RVA: 0x00916880 File Offset: 0x00914A80
		[SkipLocalsInit]
		public unsafe override void OnKuroTick(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8BB RID: 125115 RVA: 0x009168C8 File Offset: 0x00914AC8
		[SkipLocalsInit]
		protected unsafe virtual void OnKuroTick_Implementation(float DeltaTime)
		{
			BP_GlobalGI_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8BC RID: 125116 RVA: 0x0091690E File Offset: 0x00914B0E
		[SkipLocalsInit]
		public override void OnKuroInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8BD RID: 125117 RVA: 0x00916922 File Offset: 0x00914B22
		[SkipLocalsInit]
		protected virtual void OnKuroInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8BE RID: 125118 RVA: 0x00916936 File Offset: 0x00914B36
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8BF RID: 125119 RVA: 0x0091694A File Offset: 0x00914B4A
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8C0 RID: 125120 RVA: 0x0091695E File Offset: 0x00914B5E
		[SkipLocalsInit]
		public override void OnKuroRuntimeDestroy()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8C1 RID: 125121 RVA: 0x00916972 File Offset: 0x00914B72
		[SkipLocalsInit]
		protected virtual void OnKuroRuntimeDestroy_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroRuntimeDestroy_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8C2 RID: 125122 RVA: 0x00916988 File Offset: 0x00914B88
		[SkipLocalsInit]
		public unsafe override void OnKuroSetRuntimeTime(float CurrentTime)
		{
			BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8C3 RID: 125123 RVA: 0x009169D0 File Offset: 0x00914BD0
		[SkipLocalsInit]
		protected unsafe virtual void OnKuroSetRuntimeTime_Implementation(float CurrentTime)
		{
			BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E8C4 RID: 125124 RVA: 0x00916A18 File Offset: 0x00914C18
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override void OnKuroStartUiScene(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E8C5 RID: 125125 RVA: 0x00916A8C File Offset: 0x00914C8C
		[NullableContext(1)]
		[SkipLocalsInit]
		protected unsafe virtual void OnKuroStartUiScene_Implementation(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E8C6 RID: 125126 RVA: 0x00916AFF File Offset: 0x00914CFF
		[SkipLocalsInit]
		public override void OnKuroEndUiScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroEndUiScene_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8C7 RID: 125127 RVA: 0x00916B13 File Offset: 0x00914D13
		[SkipLocalsInit]
		protected virtual void OnKuroEndUiScene_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_C.__OnKuroEndUiScene_NativeFunctionPtr, null);
		}

		// Token: 0x0601E8C8 RID: 125128 RVA: 0x00916B27 File Offset: 0x00914D27
		protected BP_GlobalGI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010211 RID: 66065
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C";

		// Token: 0x04010212 RID: 66066
		private static IntPtr _ClassPtr;

		// Token: 0x04010213 RID: 66067
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010214 RID: 66068
		public static IntPtr __CallCloudChange__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010215 RID: 66069
		internal static int __PropertyOffset_KuroDynamicSky;

		// Token: 0x04010216 RID: 66070
		internal static int __PropertyOffset_ToonBaseFFTPost;

		// Token: 0x04010217 RID: 66071
		internal static int __PropertyOffset_GodRayPostVolume;

		// Token: 0x04010218 RID: 66072
		internal static int __PropertyOffset_KuroVolumeCloudGlobal;

		// Token: 0x04010219 RID: 66073
		internal static int __PropertyOffset_RainOverrider;

		// Token: 0x0401021A RID: 66074
		internal static int __PropertyOffset_CloudOcean;

		// Token: 0x0401021B RID: 66075
		internal static int __PropertyOffset_SM_MilkyWay;

		// Token: 0x0401021C RID: 66076
		internal static int __PropertyOffset_GlobalUiScenePostProcess;

		// Token: 0x0401021D RID: 66077
		internal static int __PropertyOffset_ImposterManager;

		// Token: 0x0401021E RID: 66078
		internal static int __PropertyOffset_SM_Com_Roc_01AS6;

		// Token: 0x0401021F RID: 66079
		internal static int __PropertyOffset_SM_Com_Roc_01AS5;

		// Token: 0x04010220 RID: 66080
		internal static int __PropertyOffset_SM_Com_Roc_01AS4;

		// Token: 0x04010221 RID: 66081
		internal static int __PropertyOffset_SM_Com_Roc_01AS3;

		// Token: 0x04010222 RID: 66082
		internal static int __PropertyOffset_SM_Com_Roc_01AS2;

		// Token: 0x04010223 RID: 66083
		internal static int __PropertyOffset_SM_Com_Roc_01AS1;

		// Token: 0x04010224 RID: 66084
		internal static int __PropertyOffset_SM_Com_Roc_01AS;

		// Token: 0x04010225 RID: 66085
		internal static int __PropertyOffset_LUTPostProcess;

		// Token: 0x04010226 RID: 66086
		internal static int __PropertyOffset_SM_Stars;

		// Token: 0x04010227 RID: 66087
		internal static int __PropertyOffset_Skybox;

		// Token: 0x04010228 RID: 66088
		internal static int __PropertyOffset_GlobalPostProcessVolume;

		// Token: 0x04010229 RID: 66089
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401022A RID: 66090
		internal static int __PropertyOffset_CharacterLightHorizontal;

		// Token: 0x0401022B RID: 66091
		internal static int __PropertyOffset_CurrTimeOfDay;

		// Token: 0x0401022C RID: 66092
		internal static int __PropertyOffset_EnableTODCycle;

		// Token: 0x0401022D RID: 66093
		internal static int __PropertyOffset_PauseTOD;

		// Token: 0x0401022E RID: 66094
		internal static int __PropertyOffset_编辑器下更新;

		// Token: 0x0401022F RID: 66095
		internal static int __PropertyOffset_TODCycleTime;

		// Token: 0x04010230 RID: 66096
		internal static int __PropertyOffset_SenenDirLightRot;

		// Token: 0x04010231 RID: 66097
		internal static int __PropertyOffset_MainLightAngleLimit;

		// Token: 0x04010232 RID: 66098
		internal static int __PropertyOffset_IsGIEnable;

		// Token: 0x04010233 RID: 66099
		internal static int __PropertyOffset_使用随机的昼夜循环天气组;

		// Token: 0x04010234 RID: 66100
		internal static int __PropertyOffset_当前的天气组索引值;

		// Token: 0x04010235 RID: 66101
		internal static int __PropertyOffset_太阳颜色;

		// Token: 0x04010236 RID: 66102
		internal static int __PropertyOffset_SunLightExistTime;

		// Token: 0x04010237 RID: 66103
		private TArray<FVector2D> _SunLightExistTime;

		// Token: 0x04010238 RID: 66104
		internal static int __PropertyOffset_MoonLightExistTime;

		// Token: 0x04010239 RID: 66105
		private TArray<FVector2D> _MoonLightExistTime;

		// Token: 0x0401023A RID: 66106
		internal static int __PropertyOffset_运行时自动开始循环;

		// Token: 0x0401023B RID: 66107
		internal static int __PropertyOffset_UISceneRendering;

		// Token: 0x0401023C RID: 66108
		internal static int __PropertyOffset_IsRootGI;

		// Token: 0x0401023D RID: 66109
		internal static int __PropertyOffset_DEBUG_使用角色预览方向光;

		// Token: 0x0401023E RID: 66110
		internal static int __PropertyOffset_DEBUG_角色预览方向光方向;

		// Token: 0x0401023F RID: 66111
		internal static int __PropertyOffset_TotalDaysElapsed;

		// Token: 0x04010240 RID: 66112
		internal static int __PropertyOffset_MoonFade;

		// Token: 0x04010241 RID: 66113
		internal static int __PropertyOffset_MoonVisibleTime;

		// Token: 0x04010242 RID: 66114
		internal static int __PropertyOffset_编辑器下关闭LensFlare;

		// Token: 0x04010243 RID: 66115
		internal static int __PropertyOffset_关闭雾效;

		// Token: 0x04010244 RID: 66116
		internal static int __PropertyOffset_RuntimeTimeEnable;

		// Token: 0x04010245 RID: 66117
		internal static int __PropertyOffset_MainLightTickSecond;

		// Token: 0x04010246 RID: 66118
		internal static int __PropertyOffset_MainLightTickCounter;

		// Token: 0x04010247 RID: 66119
		internal static int __PropertyOffset_ForceUpdateMainLightDir;

		// Token: 0x04010248 RID: 66120
		internal static int __PropertyOffset_WindDir;

		// Token: 0x04010249 RID: 66121
		internal static int __PropertyOffset_使用临时雾效;

		// Token: 0x0401024A RID: 66122
		internal static int __PropertyOffset_TempFogMaterial;

		// Token: 0x0401024B RID: 66123
		internal static int __PropertyOffset_TempFogDMI;

		// Token: 0x0401024C RID: 66124
		internal static int __PropertyOffset_SkyboxMaterial;

		// Token: 0x0401024D RID: 66125
		internal static int __PropertyOffset_SunDiscColor;

		// Token: 0x0401024E RID: 66126
		internal static int __PropertyOffset_SunScatterColor;

		// Token: 0x0401024F RID: 66127
		internal static int __PropertyOffset_SunSize;

		// Token: 0x04010250 RID: 66128
		internal static int __PropertyOffset_MoonDiscColor;

		// Token: 0x04010251 RID: 66129
		internal static int __PropertyOffset_MoonScatterColor;

		// Token: 0x04010252 RID: 66130
		internal static int __PropertyOffset_MoonSize;

		// Token: 0x04010253 RID: 66131
		internal static int __PropertyOffset_HorizonColor;

		// Token: 0x04010254 RID: 66132
		internal static int __PropertyOffset_HorizonFalloff;

		// Token: 0x04010255 RID: 66133
		internal static int __PropertyOffset_ZenithColor;

		// Token: 0x04010256 RID: 66134
		internal static int __PropertyOffset_ExtremWeatherWeight;

		// Token: 0x04010257 RID: 66135
		internal static int __PropertyOffset_ST_TopColor;

		// Token: 0x04010258 RID: 66136
		internal static int __PropertyOffset_ST_DomeColorTint;

		// Token: 0x04010259 RID: 66137
		internal static int __PropertyOffset_ST_TopWidth;

		// Token: 0x0401025A RID: 66138
		internal static int __PropertyOffset_CharMainLightCurve;

		// Token: 0x0401025B RID: 66139
		internal static int __PropertyOffset_CharSkyLightCurve;

		// Token: 0x0401025C RID: 66140
		internal static int __PropertyOffset_UseCharCustomLighting;

		// Token: 0x0401025D RID: 66141
		internal static int __PropertyOffset_CharAmbientColor;

		// Token: 0x0401025E RID: 66142
		internal static int __PropertyOffset_CharSkinAmbientColor;

		// Token: 0x0401025F RID: 66143
		internal static int __PropertyOffset_CharShadowCurve;

		// Token: 0x04010260 RID: 66144
		internal static int __PropertyOffset_LightFunctionMaterial;

		// Token: 0x04010261 RID: 66145
		internal static int __PropertyOffset_LightFunctionIntensity;

		// Token: 0x04010262 RID: 66146
		internal static int __PropertyOffset_LightFunctionDMI;

		// Token: 0x04010263 RID: 66147
		internal static int __PropertyOffset_DEBUG开启无音区特殊地表;

		// Token: 0x04010264 RID: 66148
		internal static int __PropertyOffset_LensFlareMI;

		// Token: 0x04010265 RID: 66149
		internal static int __PropertyOffset_LensFlareDMI;

		// Token: 0x04010266 RID: 66150
		internal static int __PropertyOffset_MobileLensFlareMI_Ghost;

		// Token: 0x04010267 RID: 66151
		internal static int __PropertyOffset_Nadir_Color;

		// Token: 0x04010268 RID: 66152
		internal static int __PropertyOffset_Nadir_Falloff;

		// Token: 0x04010269 RID: 66153
		internal static int __PropertyOffset_Sun_Scatter_Size;

		// Token: 0x0401026A RID: 66154
		internal static int __PropertyOffset_Moon_Scatter_Size;

		// Token: 0x0401026B RID: 66155
		internal static int __PropertyOffset_StarsMaterial;

		// Token: 0x0401026C RID: 66156
		internal static int __PropertyOffset_MainDirectionLightUpdateThreshold_Mobile;

		// Token: 0x0401026D RID: 66157
		internal static int __PropertyOffset_MainDirectionLightUpdateThreshold;

		// Token: 0x0401026E RID: 66158
		internal static int __PropertyOffset_GlobalWindDirection;

		// Token: 0x0401026F RID: 66159
		internal static int __PropertyOffset_GlobalWindRightDirection;

		// Token: 0x04010270 RID: 66160
		internal static int __PropertyOffset_DEBUG无音区特殊地表强度;

		// Token: 0x04010271 RID: 66161
		internal static int __PropertyOffset_RealTimeOfDay;

		// Token: 0x04010272 RID: 66162
		internal static int __PropertyOffset_DynamicCloudsActor;

		// Token: 0x04010273 RID: 66163
		internal static int __PropertyOffset_RainDensityChangeSpeed;

		// Token: 0x04010274 RID: 66164
		internal static int __PropertyOffset_RainDensity;

		// Token: 0x04010275 RID: 66165
		internal static int __PropertyOffset_SnowDensity;

		// Token: 0x04010276 RID: 66166
		internal static int __PropertyOffset_RainGravity;

		// Token: 0x04010277 RID: 66167
		internal static int __PropertyOffset_RainGravityChangeSpeed;

		// Token: 0x04010278 RID: 66168
		internal static int __PropertyOffset_RainWindPower;

		// Token: 0x04010279 RID: 66169
		internal static int __PropertyOffset_RainWindPowerChangeSpeed;

		// Token: 0x0401027A RID: 66170
		internal static int __PropertyOffset_CanSpawnEffect;

		// Token: 0x0401027B RID: 66171
		internal static int __PropertyOffset_FinalSnowDensity;

		// Token: 0x0401027C RID: 66172
		internal static int __PropertyOffset_FinalRainDensity;

		// Token: 0x0401027D RID: 66173
		internal static int __PropertyOffset_FinalRainGravity;

		// Token: 0x0401027E RID: 66174
		internal static int __PropertyOffset_DefaultSkyLightShadowSupplement;

		// Token: 0x0401027F RID: 66175
		internal static int __PropertyOffset_DefaultSkyLightReflectionAddIntensity;

		// Token: 0x04010280 RID: 66176
		internal static int __PropertyOffset_MobileLensFlareMI_Halo;

		// Token: 0x04010281 RID: 66177
		internal static int __PropertyOffset_MobileLensFlareDMI_Ghost;

		// Token: 0x04010282 RID: 66178
		internal static int __PropertyOffset_MobileLensFlareDMI_Halo;

		// Token: 0x04010283 RID: 66179
		internal static int __PropertyOffset_HeightMapTexture;

		// Token: 0x04010284 RID: 66180
		internal static int __PropertyOffset_HeightMapUpdated;

		// Token: 0x04010285 RID: 66181
		internal static int __PropertyOffset_SunLightDirection;

		// Token: 0x04010286 RID: 66182
		internal static int __PropertyOffset_IsComponentsEnable;

		// Token: 0x04010287 RID: 66183
		internal static int __PropertyOffset_Last_LightFunction_Map;

		// Token: 0x04010288 RID: 66184
		internal static int __PropertyOffset_InitLightFunctionMap;

		// Token: 0x04010289 RID: 66185
		internal static int __PropertyOffset_TODLightLoadingWait;

		// Token: 0x0401028A RID: 66186
		internal static int __PropertyOffset_DayLightLoadingTime;

		// Token: 0x0401028B RID: 66187
		internal static int __PropertyOffset_NightLightLoadingTime;

		// Token: 0x0401028C RID: 66188
		internal static int __PropertyOffset_ComputeLightGridSkipFrames;

		// Token: 0x0401028D RID: 66189
		internal static int __PropertyOffset_MilkyWayMaterial;

		// Token: 0x0401028E RID: 66190
		internal static int __PropertyOffset_使用主角位置;

		// Token: 0x0401028F RID: 66191
		internal static int __PropertyOffset_DEBUG_角色预览方向光垂直方向;

		// Token: 0x04010290 RID: 66192
		internal static int __PropertyOffset_FogTImeControl;

		// Token: 0x04010291 RID: 66193
		private FKuroCurveFloat _FogTImeControl;

		// Token: 0x04010292 RID: 66194
		internal static int __PropertyOffset_Is_Editor_Update;

		// Token: 0x04010293 RID: 66195
		internal static int __PropertyOffset_EnableImposterUpdate;

		// Token: 0x04010294 RID: 66196
		internal static int __PropertyOffset_Clouds_Change_CD;

		// Token: 0x04010295 RID: 66197
		internal static int __PropertyOffset_Clouds_Change_Time;

		// Token: 0x04010296 RID: 66198
		internal static int __PropertyOffset_Clouds_Change_Time_0;

		// Token: 0x04010297 RID: 66199
		internal static int __PropertyOffset_启用时间参数写入;

		// Token: 0x04010298 RID: 66200
		internal static int __PropertyOffset_UINeedLerpData;

		// Token: 0x04010299 RID: 66201
		internal static int __PropertyOffset_bEnableLumen;

		// Token: 0x0401029A RID: 66202
		internal static int __PropertyOffset_LightFunctionMaterial_seq;

		// Token: 0x0401029B RID: 66203
		internal static int __PropertyOffset_Override_Cloud_Rotation;

		// Token: 0x0401029C RID: 66204
		internal static int __PropertyOffset_Sequence_Cloud_Time_Control;

		// Token: 0x0401029D RID: 66205
		internal static int __PropertyOffset_Sequence_Cloud_Time_Offset;

		// Token: 0x0401029E RID: 66206
		internal static int __PropertyOffset_VolumetricLightFunctionMaterial;

		// Token: 0x0401029F RID: 66207
		internal static int __PropertyOffset_PerformanceLightExist;

		// Token: 0x040102A0 RID: 66208
		internal static int __PropertyOffset_bEnableAutoExposure;

		// Token: 0x040102A1 RID: 66209
		internal static int __PropertyOffset_PerformanceLightExist_MP4;

		// Token: 0x040102A2 RID: 66210
		internal static int __PropertyOffset_BPScreenFilter;

		// Token: 0x040102A3 RID: 66211
		internal static int __PropertyOffset_Star_Material_V2;

		// Token: 0x040102A4 RID: 66212
		internal static int __PropertyOffset_bCurrentPC;

		// Token: 0x040102A5 RID: 66213
		internal static int __PropertyOffset_bSetDailyRandom;

		// Token: 0x040102A6 RID: 66214
		internal static int __PropertyOffset_FrozenMaterial;

		// Token: 0x040102A7 RID: 66215
		internal static int __PropertyOffset_FrozenDMI;

		// Token: 0x040102A8 RID: 66216
		internal static int __PropertyOffset_TimeTotal;

		// Token: 0x040102A9 RID: 66217
		internal static int __PropertyOffset_ChangeFrozen;

		// Token: 0x040102AA RID: 66218
		internal static int __PropertyOffset_Ini;

		// Token: 0x040102AB RID: 66219
		internal static int __PropertyOffset_NeedDissolve;

		// Token: 0x040102AC RID: 66220
		internal static int __PropertyOffset_Change_Speed;

		// Token: 0x040102AD RID: 66221
		internal static int __PropertyOffset_CloudControlDoOnce;

		// Token: 0x040102AE RID: 66222
		internal static int __PropertyOffset_CommandToolStartArray;

		// Token: 0x040102AF RID: 66223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CommandToolStartArray;

		// Token: 0x040102B0 RID: 66224
		internal static int __PropertyOffset_CommandToolEndArray;

		// Token: 0x040102B1 RID: 66225
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CommandToolEndArray;

		// Token: 0x040102B2 RID: 66226
		internal static int __PropertyOffset_CommandToolOriginalValueArray;

		// Token: 0x040102B3 RID: 66227
		private TArray<float> _CommandToolOriginalValueArray;

		// Token: 0x040102B4 RID: 66228
		internal static int __PropertyOffset_NeedResetActor;

		// Token: 0x040102B5 RID: 66229
		internal static int __PropertyOffset_NeedRunEndCommand;

		// Token: 0x040102B6 RID: 66230
		internal static int __PropertyOffset_CloudsCD;

		// Token: 0x040102B7 RID: 66231
		internal static int __PropertyOffset_UpdateSkylightBlendNum;

		// Token: 0x040102B8 RID: 66232
		internal static int __PropertyOffset_EnableSetSkyBlendingSkipCVar;

		// Token: 0x040102B9 RID: 66233
		internal static int __PropertyOffset_DoOnceSetSkyBlendingSkipCVar;

		// Token: 0x040102BA RID: 66234
		internal static int __PropertyOffset_bEnableUpdateTimeTick;

		// Token: 0x040102BB RID: 66235
		private static IntPtr __UodateSkylightBlendTick_NativeFunctionPtr;

		// Token: 0x040102BC RID: 66236
		private static IntPtr __UpdateVolumeCloudGodRay_NativeFunctionPtr;

		// Token: 0x040102BD RID: 66237
		private static IntPtr __OnGlobalGITick_NativeFunctionPtr;

		// Token: 0x040102BE RID: 66238
		private static IntPtr __UpdateMeshBlend_NativeFunctionPtr;

		// Token: 0x040102BF RID: 66239
		private static IntPtr __ToggleShowDynamicSkyPlatform_NativeFunctionPtr;

		// Token: 0x040102C0 RID: 66240
		private static IntPtr __UpadteVolumertricCloud_NativeFunctionPtr;

		// Token: 0x040102C1 RID: 66241
		private static IntPtr __UpdateCharacterRootPos_NativeFunctionPtr;

		// Token: 0x040102C2 RID: 66242
		private static IntPtr __Set_GIControlParamToGlobalShaderParam_NativeFunctionPtr;

		// Token: 0x040102C3 RID: 66243
		private static IntPtr __UpdateOriginSkyAtmosphere_NativeFunctionPtr;

		// Token: 0x040102C4 RID: 66244
		private static IntPtr __UpdateVolumeCloudLightWeight_NativeFunctionPtr;

		// Token: 0x040102C5 RID: 66245
		private static IntPtr __IsPerformanceLightExist_NativeFunctionPtr;

		// Token: 0x040102C6 RID: 66246
		private static IntPtr __UpdateOcean_NativeFunctionPtr;

		// Token: 0x040102C7 RID: 66247
		private static IntPtr __UpdateFrozen_NativeFunctionPtr;

		// Token: 0x040102C8 RID: 66248
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x040102C9 RID: 66249
		private static IntPtr __UpdateBigWorld_NativeFunctionPtr;

		// Token: 0x040102CA RID: 66250
		private static IntPtr __GetMilkyWayDMI_NativeFunctionPtr;

		// Token: 0x040102CB RID: 66251
		private static IntPtr __updateLightFunctions_NativeFunctionPtr;

		// Token: 0x040102CC RID: 66252
		private static IntPtr __GetParallaxCorrectCachedCrossFadeShadowDirection_NativeFunctionPtr;

		// Token: 0x040102CD RID: 66253
		private static IntPtr __GetTODCharacterLighting_NativeFunctionPtr;

		// Token: 0x040102CE RID: 66254
		private static IntPtr __GetParallaxCorrectCachedShadowDirection_NativeFunctionPtr;

		// Token: 0x040102CF RID: 66255
		private static IntPtr __Clamp_Luminance_NativeFunctionPtr;

		// Token: 0x040102D0 RID: 66256
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x040102D1 RID: 66257
		private static IntPtr __Update_Dynamic_Clouds_NativeFunctionPtr;

		// Token: 0x040102D2 RID: 66258
		private static IntPtr __GetStarsDMI_NativeFunctionPtr;

		// Token: 0x040102D3 RID: 66259
		private static IntPtr __UpdateClusteredStuff_NativeFunctionPtr;

		// Token: 0x040102D4 RID: 66260
		private static IntPtr __GetSkyboxDMI_NativeFunctionPtr;

		// Token: 0x040102D5 RID: 66261
		private static IntPtr __UpdateSkybox_NativeFunctionPtr;

		// Token: 0x040102D6 RID: 66262
		private static IntPtr __Update_Misc_NativeFunctionPtr;

		// Token: 0x040102D7 RID: 66263
		private static IntPtr __UpdateFlowmapSkybox_NativeFunctionPtr;

		// Token: 0x040102D8 RID: 66264
		private static IntPtr __申时_NativeFunctionPtr;

		// Token: 0x040102D9 RID: 66265
		private static IntPtr __下午_NativeFunctionPtr;

		// Token: 0x040102DA RID: 66266
		private static IntPtr __上午_NativeFunctionPtr;

		// Token: 0x040102DB RID: 66267
		private static IntPtr __辰时_NativeFunctionPtr;

		// Token: 0x040102DC RID: 66268
		private static IntPtr __Update_Day_Night_Data_Layer_NativeFunctionPtr;

		// Token: 0x040102DD RID: 66269
		private static IntPtr __夜晚_NativeFunctionPtr;

		// Token: 0x040102DE RID: 66270
		private static IntPtr __夜晚到清晨_NativeFunctionPtr;

		// Token: 0x040102DF RID: 66271
		private static IntPtr __黄昏到夜晚_NativeFunctionPtr;

		// Token: 0x040102E0 RID: 66272
		private static IntPtr __黄昏_NativeFunctionPtr;

		// Token: 0x040102E1 RID: 66273
		private static IntPtr __中午_NativeFunctionPtr;

		// Token: 0x040102E2 RID: 66274
		private static IntPtr __清晨_NativeFunctionPtr;

		// Token: 0x040102E3 RID: 66275
		private static IntPtr __UpdateSkyDome_NativeFunctionPtr;

		// Token: 0x040102E4 RID: 66276
		private static IntPtr __InitGI_NativeFunctionPtr;

		// Token: 0x040102E5 RID: 66277
		private static IntPtr __Set_All_Components_States_NativeFunctionPtr;

		// Token: 0x040102E6 RID: 66278
		private static IntPtr __UpdateLightShaft_NativeFunctionPtr;

		// Token: 0x040102E7 RID: 66279
		private static IntPtr __GetLightDirectionFromVH_NativeFunctionPtr;

		// Token: 0x040102E8 RID: 66280
		private static IntPtr __UpdatePostProcessVolume_NativeFunctionPtr;

		// Token: 0x040102E9 RID: 66281
		private static IntPtr __UpdateLightParameters_NativeFunctionPtr;

		// Token: 0x040102EA RID: 66282
		private static IntPtr __Update_Light_Direction_NativeFunctionPtr;

		// Token: 0x040102EB RID: 66283
		private static IntPtr __Update_Main_Light_NativeFunctionPtr;

		// Token: 0x040102EC RID: 66284
		private static IntPtr __Update_UI_Env_NativeFunctionPtr;

		// Token: 0x040102ED RID: 66285
		private static IntPtr __UpdateTime_NativeFunctionPtr;

		// Token: 0x040102EE RID: 66286
		private static IntPtr __UpdateTimeOnce_NativeFunctionPtr;

		// Token: 0x040102EF RID: 66287
		private static IntPtr __GetViewLocation_NativeFunctionPtr;

		// Token: 0x040102F0 RID: 66288
		private static IntPtr __InitFeature_NativeFunctionPtr;

		// Token: 0x040102F1 RID: 66289
		private static IntPtr __CalculateLightDirectionWithLimit_NativeFunctionPtr;

		// Token: 0x040102F2 RID: 66290
		private static IntPtr __CalculateLightDirection_NativeFunctionPtr;

		// Token: 0x040102F3 RID: 66291
		private static IntPtr __UpdateAtmosphere_NativeFunctionPtr;

		// Token: 0x040102F4 RID: 66292
		private static IntPtr __UpdateSkyLight_NativeFunctionPtr;

		// Token: 0x040102F5 RID: 66293
		private static IntPtr __Get_Scene_Light_Direction_NativeFunctionPtr;

		// Token: 0x040102F6 RID: 66294
		private static IntPtr __InitGICompoemnt_NativeFunctionPtr;

		// Token: 0x040102F7 RID: 66295
		private static IntPtr __InitMaterials_NativeFunctionPtr;

		// Token: 0x040102F8 RID: 66296
		private static IntPtr __UpdateWind_NativeFunctionPtr;

		// Token: 0x040102F9 RID: 66297
		private static IntPtr __Get2SkyboxLerpWeight_NativeFunctionPtr;

		// Token: 0x040102FA RID: 66298
		private static IntPtr __Update_Env_NativeFunctionPtr;

		// Token: 0x040102FB RID: 66299
		private static IntPtr __UpdateFog_NativeFunctionPtr;

		// Token: 0x040102FC RID: 66300
		private static IntPtr __UpdateGIData_NativeFunctionPtr;

		// Token: 0x040102FD RID: 66301
		private static IntPtr __UpdateCharacterGI_NativeFunctionPtr;

		// Token: 0x040102FE RID: 66302
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040102FF RID: 66303
		private static IntPtr __OnKuroTickEditor_NativeFunctionPtr;

		// Token: 0x04010300 RID: 66304
		private static IntPtr __OnKuroTick_NativeFunctionPtr;

		// Token: 0x04010301 RID: 66305
		private static IntPtr __OnKuroInit_NativeFunctionPtr;

		// Token: 0x04010302 RID: 66306
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010303 RID: 66307
		private static IntPtr __OnKuroRuntimeDestroy_NativeFunctionPtr;

		// Token: 0x04010304 RID: 66308
		private static IntPtr __OnKuroSetRuntimeTime_NativeFunctionPtr;

		// Token: 0x04010305 RID: 66309
		private static IntPtr __OnKuroStartUiScene_NativeFunctionPtr;

		// Token: 0x04010306 RID: 66310
		private static IntPtr __OnKuroEndUiScene_NativeFunctionPtr;

		// Token: 0x02008E82 RID: 36482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetMilkyWayDMI_FunctionParams
		{
			// Token: 0x0402CADA RID: 183002
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x02008E83 RID: 36483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetParallaxCorrectCachedCrossFadeShadowDirection_FunctionParams
		{
			// Token: 0x0402CADB RID: 183003
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x02008E84 RID: 36484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetTODCharacterLighting_FunctionParams
		{
			// Token: 0x0402CADC RID: 183004
			[FieldOffset(0)]
			public FLinearColor mainLight;

			// Token: 0x0402CADD RID: 183005
			[FieldOffset(16)]
			public float mainLightIntensity;

			// Token: 0x0402CADE RID: 183006
			[FieldOffset(20)]
			public FLinearColor skyLight;

			// Token: 0x0402CADF RID: 183007
			[FieldOffset(36)]
			public float skyLightIntensity;

			// Token: 0x0402CAE0 RID: 183008
			[FieldOffset(40)]
			public FLinearColor FrontSideLight;

			// Token: 0x0402CAE1 RID: 183009
			[FieldOffset(56)]
			public FLinearColor BackSideLight;
		}

		// Token: 0x02008E85 RID: 36485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetParallaxCorrectCachedShadowDirection_FunctionParams
		{
			// Token: 0x0402CAE2 RID: 183010
			[FieldOffset(0)]
			public FRotator NewParam;
		}

		// Token: 0x02008E86 RID: 36486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __Clamp_Luminance_FunctionParams
		{
			// Token: 0x0402CAE3 RID: 183011
			[FieldOffset(0)]
			public FLinearColor InColor;

			// Token: 0x0402CAE4 RID: 183012
			[FieldOffset(16)]
			public float Min;

			// Token: 0x0402CAE5 RID: 183013
			[FieldOffset(20)]
			public float Max;

			// Token: 0x0402CAE6 RID: 183014
			[FieldOffset(24)]
			public FLinearColor __Result;
		}

		// Token: 0x02008E87 RID: 36487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x0402CAE7 RID: 183015
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x0402CAE8 RID: 183016
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x0402CAE9 RID: 183017
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x02008E88 RID: 36488
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetStarsDMI_FunctionParams
		{
			// Token: 0x0402CAEA RID: 183018
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x02008E89 RID: 36489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSkyboxDMI_FunctionParams
		{
			// Token: 0x0402CAEB RID: 183019
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x02008E8A RID: 36490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __Set_All_Components_States_FunctionParams
		{
			// Token: 0x0402CAEC RID: 183020
			[FieldOffset(0)]
			public bool IsEnable;
		}

		// Token: 0x02008E8B RID: 36491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetLightDirectionFromVH_FunctionParams
		{
			// Token: 0x0402CAED RID: 183021
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x0402CAEE RID: 183022
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x0402CAEF RID: 183023
			[FieldOffset(8)]
			public FRotator Result;
		}

		// Token: 0x02008E8C RID: 36492
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateTimeOnce_FunctionParams
		{
			// Token: 0x0402CAF0 RID: 183024
			[FieldOffset(0)]
			public float OverrideTime;
		}

		// Token: 0x02008E8D RID: 36493
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetViewLocation_FunctionParams
		{
			// Token: 0x0402CAF1 RID: 183025
			[FieldOffset(0)]
			public FVector WorldPosition;

			// Token: 0x0402CAF2 RID: 183026
			[FieldOffset(12)]
			public bool Suc;
		}

		// Token: 0x02008E8E RID: 36494
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __CalculateLightDirectionWithLimit_FunctionParams
		{
			// Token: 0x0402CAF3 RID: 183027
			[FieldOffset(0)]
			public float V;

			// Token: 0x0402CAF4 RID: 183028
			[FieldOffset(4)]
			public float H;

			// Token: 0x0402CAF5 RID: 183029
			[FieldOffset(8)]
			public float Time;

			// Token: 0x0402CAF6 RID: 183030
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x02008E8F RID: 36495
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CalculateLightDirection_FunctionParams
		{
			// Token: 0x0402CAF7 RID: 183031
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x0402CAF8 RID: 183032
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x0402CAF9 RID: 183033
			[FieldOffset(8)]
			public float Time;

			// Token: 0x0402CAFA RID: 183034
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x02008E90 RID: 36496
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Direction_FunctionParams
		{
			// Token: 0x0402CAFB RID: 183035
			[FieldOffset(0)]
			public FVector LightDir;
		}

		// Token: 0x02008E91 RID: 36497
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __Get2SkyboxLerpWeight_FunctionParams
		{
			// Token: 0x0402CAFC RID: 183036
			[FieldOffset(0)]
			public float startSetting;

			// Token: 0x0402CAFD RID: 183037
			[FieldOffset(4)]
			public float EndSetting;

			// Token: 0x0402CAFE RID: 183038
			[FieldOffset(8)]
			public float CurrentTime;

			// Token: 0x0402CAFF RID: 183039
			[FieldOffset(12)]
			public float Weight;
		}

		// Token: 0x02008E92 RID: 36498
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateGIData_FunctionParams
		{
			// Token: 0x0402CB00 RID: 183040
			[FieldOffset(0)]
			public bool Skip_Lerp_Data;
		}

		// Token: 0x02008E93 RID: 36499
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x0402CB01 RID: 183041
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008E94 RID: 36500
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x0402CB02 RID: 183042
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008E95 RID: 36501
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x0402CB03 RID: 183043
			[FieldOffset(0)]
			public float CurrentTime;
		}

		// Token: 0x02008E96 RID: 36502
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x0402CB04 RID: 183044
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x0402CB05 RID: 183045
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}
	}
}
