using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.UI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2D RID: 15661
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_LaunchScene.BP_GlobalGI_LaunchScene_C")]
	[UnrealStructLayout(16992, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16984)]
	public class BP_GlobalGI_LaunchScene_C : AKuroGlobalGI, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025CD1 RID: 154833 RVA: 0x009633A6 File Offset: 0x009615A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalGI_LaunchScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_LaunchScene.BP_GlobalGI_LaunchScene_C");
			}
			return BP_GlobalGI_LaunchScene_C._ClassPtr;
		}

		// Token: 0x06025CD2 RID: 154834 RVA: 0x009633CC File Offset: 0x009615CC
		public BP_GlobalGI_LaunchScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_LaunchScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025CD3 RID: 154835 RVA: 0x009633F4 File Offset: 0x009615F4
		[NullableContext(1)]
		public BP_GlobalGI_LaunchScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGI_LaunchScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x06025CD4 RID: 154836 RVA: 0x00963427 File Offset: 0x00961627
		// (set) Token: 0x06025CD5 RID: 154837 RVA: 0x0096343B File Offset: 0x0096163B
		public unsafe USceneRayTracingGICaptureComponentCube SceneRayTracingGICaptureComponentCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneRayTracingGICaptureComponentCube>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x06025CD6 RID: 154838 RVA: 0x00963450 File Offset: 0x00961650
		// (set) Token: 0x06025CD7 RID: 154839 RVA: 0x00963464 File Offset: 0x00961664
		public unsafe UChildActorComponent KuroVolumeCloudGlobal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x06025CD8 RID: 154840 RVA: 0x00963479 File Offset: 0x00961679
		// (set) Token: 0x06025CD9 RID: 154841 RVA: 0x0096348D File Offset: 0x0096168D
		public unsafe UKuroPostProcessComponent LUTPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x06025CDA RID: 154842 RVA: 0x009634A2 File Offset: 0x009616A2
		// (set) Token: 0x06025CDB RID: 154843 RVA: 0x009634B6 File Offset: 0x009616B6
		public unsafe UStaticMeshComponent Skybox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x06025CDC RID: 154844 RVA: 0x009634CB File Offset: 0x009616CB
		// (set) Token: 0x06025CDD RID: 154845 RVA: 0x009634DF File Offset: 0x009616DF
		public unsafe UKuroPostProcessComponent GlobalUiKuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x06025CDE RID: 154846 RVA: 0x009634F4 File Offset: 0x009616F4
		// (set) Token: 0x06025CDF RID: 154847 RVA: 0x00963508 File Offset: 0x00961708
		public unsafe UPostProcessComponent GlobalPostProcessVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x06025CE0 RID: 154848 RVA: 0x0096351D File Offset: 0x0096171D
		// (set) Token: 0x06025CE1 RID: 154849 RVA: 0x00963531 File Offset: 0x00961731
		public unsafe UDirectionalLightComponent SceneLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x06025CE2 RID: 154850 RVA: 0x00963546 File Offset: 0x00961746
		// (set) Token: 0x06025CE3 RID: 154851 RVA: 0x0096355A File Offset: 0x0096175A
		public unsafe UDirectionalLightComponent AtmoMoonLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x06025CE4 RID: 154852 RVA: 0x0096356F File Offset: 0x0096176F
		// (set) Token: 0x06025CE5 RID: 154853 RVA: 0x00963583 File Offset: 0x00961783
		public unsafe UDirectionalLightComponent AtmoSunLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x06025CE6 RID: 154854 RVA: 0x00963598 File Offset: 0x00961798
		// (set) Token: 0x06025CE7 RID: 154855 RVA: 0x009635AC File Offset: 0x009617AC
		public unsafe USkyLightComponent SkyLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x06025CE8 RID: 154856 RVA: 0x009635C1 File Offset: 0x009617C1
		// (set) Token: 0x06025CE9 RID: 154857 RVA: 0x009635D5 File Offset: 0x009617D5
		public unsafe UExponentialHeightFogComponent HeightFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x06025CEA RID: 154858 RVA: 0x009635EA File Offset: 0x009617EA
		// (set) Token: 0x06025CEB RID: 154859 RVA: 0x009635FE File Offset: 0x009617FE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x06025CEC RID: 154860 RVA: 0x00963613 File Offset: 0x00961813
		// (set) Token: 0x06025CED RID: 154861 RVA: 0x00963623 File Offset: 0x00961823
		public unsafe float CharacterLightHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x06025CEE RID: 154862 RVA: 0x00963634 File Offset: 0x00961834
		// (set) Token: 0x06025CEF RID: 154863 RVA: 0x00963644 File Offset: 0x00961844
		public unsafe float CurrTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x06025CF0 RID: 154864 RVA: 0x00963655 File Offset: 0x00961855
		// (set) Token: 0x06025CF1 RID: 154865 RVA: 0x00963665 File Offset: 0x00961865
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x06025CF2 RID: 154866 RVA: 0x00963676 File Offset: 0x00961876
		// (set) Token: 0x06025CF3 RID: 154867 RVA: 0x00963686 File Offset: 0x00961886
		public unsafe bool EnableTODCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x06025CF4 RID: 154868 RVA: 0x00963697 File Offset: 0x00961897
		// (set) Token: 0x06025CF5 RID: 154869 RVA: 0x009636A7 File Offset: 0x009618A7
		public unsafe bool PauseTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x06025CF6 RID: 154870 RVA: 0x009636B8 File Offset: 0x009618B8
		// (set) Token: 0x06025CF7 RID: 154871 RVA: 0x009636C8 File Offset: 0x009618C8
		public unsafe bool 编辑器下更新
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x06025CF8 RID: 154872 RVA: 0x009636D9 File Offset: 0x009618D9
		// (set) Token: 0x06025CF9 RID: 154873 RVA: 0x009636E9 File Offset: 0x009618E9
		public unsafe float TODCycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x06025CFA RID: 154874 RVA: 0x009636FA File Offset: 0x009618FA
		// (set) Token: 0x06025CFB RID: 154875 RVA: 0x0096370E File Offset: 0x0096190E
		public unsafe FRotator AtmosphereSunRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x06025CFC RID: 154876 RVA: 0x00963723 File Offset: 0x00961923
		// (set) Token: 0x06025CFD RID: 154877 RVA: 0x00963737 File Offset: 0x00961937
		public unsafe FRotator SenenDirLightRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x06025CFE RID: 154878 RVA: 0x0096374C File Offset: 0x0096194C
		// (set) Token: 0x06025CFF RID: 154879 RVA: 0x0096375C File Offset: 0x0096195C
		public unsafe float BP_SunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x06025D00 RID: 154880 RVA: 0x0096376D File Offset: 0x0096196D
		// (set) Token: 0x06025D01 RID: 154881 RVA: 0x0096377D File Offset: 0x0096197D
		public unsafe float BP_SunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x06025D02 RID: 154882 RVA: 0x0096378E File Offset: 0x0096198E
		// (set) Token: 0x06025D03 RID: 154883 RVA: 0x0096379E File Offset: 0x0096199E
		public unsafe float MainLightHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x06025D04 RID: 154884 RVA: 0x009637AF File Offset: 0x009619AF
		// (set) Token: 0x06025D05 RID: 154885 RVA: 0x009637BF File Offset: 0x009619BF
		public unsafe float MainLightVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x06025D06 RID: 154886 RVA: 0x009637D0 File Offset: 0x009619D0
		// (set) Token: 0x06025D07 RID: 154887 RVA: 0x009637E0 File Offset: 0x009619E0
		public unsafe float MainLightAngleLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x06025D08 RID: 154888 RVA: 0x009637F1 File Offset: 0x009619F1
		// (set) Token: 0x06025D09 RID: 154889 RVA: 0x00963801 File Offset: 0x00961A01
		public unsafe bool IsGIEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x06025D0A RID: 154890 RVA: 0x00963812 File Offset: 0x00961A12
		// (set) Token: 0x06025D0B RID: 154891 RVA: 0x00963822 File Offset: 0x00961A22
		public unsafe bool 使用随机的昼夜循环天气组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x06025D0C RID: 154892 RVA: 0x00963833 File Offset: 0x00961A33
		// (set) Token: 0x06025D0D RID: 154893 RVA: 0x00963843 File Offset: 0x00961A43
		public unsafe int 当前的天气组索引值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x06025D0E RID: 154894 RVA: 0x00963854 File Offset: 0x00961A54
		// (set) Token: 0x06025D0F RID: 154895 RVA: 0x00963868 File Offset: 0x00961A68
		public unsafe FLinearColor 太阳颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x06025D10 RID: 154896 RVA: 0x00963880 File Offset: 0x00961A80
		// (set) Token: 0x06025D11 RID: 154897 RVA: 0x009638B9 File Offset: 0x00961AB9
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
					result = (this._SunLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SunLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x06025D12 RID: 154898 RVA: 0x009638C8 File Offset: 0x00961AC8
		// (set) Token: 0x06025D13 RID: 154899 RVA: 0x00963901 File Offset: 0x00961B01
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
					result = (this._MoonLightExistTime = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_32, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoonLightExistTime.CopyAssign(value);
			}
		}

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x06025D14 RID: 154900 RVA: 0x0096390F File Offset: 0x00961B0F
		// (set) Token: 0x06025D15 RID: 154901 RVA: 0x0096391F File Offset: 0x00961B1F
		public unsafe bool 运行时自动开始循环
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x06025D16 RID: 154902 RVA: 0x00963930 File Offset: 0x00961B30
		// (set) Token: 0x06025D17 RID: 154903 RVA: 0x00963940 File Offset: 0x00961B40
		public unsafe bool UISceneRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x06025D18 RID: 154904 RVA: 0x00963951 File Offset: 0x00961B51
		// (set) Token: 0x06025D19 RID: 154905 RVA: 0x00963965 File Offset: 0x00961B65
		public unsafe PDA_GIUIData_C UIData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_GIUIData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x06025D1A RID: 154906 RVA: 0x0096397A File Offset: 0x00961B7A
		// (set) Token: 0x06025D1B RID: 154907 RVA: 0x0096398A File Offset: 0x00961B8A
		public unsafe bool DEBUG_UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x06025D1C RID: 154908 RVA: 0x0096399B File Offset: 0x00961B9B
		// (set) Token: 0x06025D1D RID: 154909 RVA: 0x009639AB File Offset: 0x00961BAB
		public unsafe bool IsRootGI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x06025D1E RID: 154910 RVA: 0x009639BC File Offset: 0x00961BBC
		// (set) Token: 0x06025D1F RID: 154911 RVA: 0x009639CC File Offset: 0x00961BCC
		public unsafe bool IsEditorUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x06025D20 RID: 154912 RVA: 0x009639DD File Offset: 0x00961BDD
		// (set) Token: 0x06025D21 RID: 154913 RVA: 0x009639ED File Offset: 0x00961BED
		public unsafe bool 更新角色光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x06025D22 RID: 154914 RVA: 0x009639FE File Offset: 0x00961BFE
		// (set) Token: 0x06025D23 RID: 154915 RVA: 0x00963A0E File Offset: 0x00961C0E
		public unsafe bool 根据光源方向自动更新角色光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x06025D24 RID: 154916 RVA: 0x00963A1F File Offset: 0x00961C1F
		// (set) Token: 0x06025D25 RID: 154917 RVA: 0x00963A2F File Offset: 0x00961C2F
		public unsafe bool DEBUG_使用角色预览方向光
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x06025D26 RID: 154918 RVA: 0x00963A40 File Offset: 0x00961C40
		// (set) Token: 0x06025D27 RID: 154919 RVA: 0x00963A50 File Offset: 0x00961C50
		public unsafe float DEBUG_角色预览方向光方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x06025D28 RID: 154920 RVA: 0x00963A61 File Offset: 0x00961C61
		// (set) Token: 0x06025D29 RID: 154921 RVA: 0x00963A71 File Offset: 0x00961C71
		public unsafe int TotalDaysElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x06025D2A RID: 154922 RVA: 0x00963A82 File Offset: 0x00961C82
		// (set) Token: 0x06025D2B RID: 154923 RVA: 0x00963A92 File Offset: 0x00961C92
		public unsafe float MoonFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x06025D2C RID: 154924 RVA: 0x00963AA3 File Offset: 0x00961CA3
		// (set) Token: 0x06025D2D RID: 154925 RVA: 0x00963AB7 File Offset: 0x00961CB7
		public unsafe FVector2D MoonVisibleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x06025D2E RID: 154926 RVA: 0x00963ACC File Offset: 0x00961CCC
		// (set) Token: 0x06025D2F RID: 154927 RVA: 0x00963ADC File Offset: 0x00961CDC
		public unsafe bool 关闭雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x06025D30 RID: 154928 RVA: 0x00963AED File Offset: 0x00961CED
		// (set) Token: 0x06025D31 RID: 154929 RVA: 0x00963AFD File Offset: 0x00961CFD
		public unsafe bool RuntimeTimeEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x06025D32 RID: 154930 RVA: 0x00963B0E File Offset: 0x00961D0E
		// (set) Token: 0x06025D33 RID: 154931 RVA: 0x00963B1E File Offset: 0x00961D1E
		public unsafe float MainLightTickSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x06025D34 RID: 154932 RVA: 0x00963B2F File Offset: 0x00961D2F
		// (set) Token: 0x06025D35 RID: 154933 RVA: 0x00963B3F File Offset: 0x00961D3F
		public unsafe float MainLightTickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x06025D36 RID: 154934 RVA: 0x00963B50 File Offset: 0x00961D50
		// (set) Token: 0x06025D37 RID: 154935 RVA: 0x00963B60 File Offset: 0x00961D60
		public unsafe bool ForceUpdateMainLightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x06025D38 RID: 154936 RVA: 0x00963B71 File Offset: 0x00961D71
		// (set) Token: 0x06025D39 RID: 154937 RVA: 0x00963B81 File Offset: 0x00961D81
		public unsafe float WindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x06025D3A RID: 154938 RVA: 0x00963B92 File Offset: 0x00961D92
		// (set) Token: 0x06025D3B RID: 154939 RVA: 0x00963BA2 File Offset: 0x00961DA2
		public unsafe bool 使用临时雾效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x06025D3C RID: 154940 RVA: 0x00963BB3 File Offset: 0x00961DB3
		// (set) Token: 0x06025D3D RID: 154941 RVA: 0x00963BC3 File Offset: 0x00961DC3
		public unsafe bool 开启集群特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06025D3E RID: 154942 RVA: 0x00963BD4 File Offset: 0x00961DD4
		// (set) Token: 0x06025D3F RID: 154943 RVA: 0x00963BE8 File Offset: 0x00961DE8
		public unsafe UMaterialInstance TempFogMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_54);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_54, value);
			}
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x06025D40 RID: 154944 RVA: 0x00963BFD File Offset: 0x00961DFD
		// (set) Token: 0x06025D41 RID: 154945 RVA: 0x00963C11 File Offset: 0x00961E11
		public unsafe UMaterialInstanceDynamic TempFogDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x06025D42 RID: 154946 RVA: 0x00963C26 File Offset: 0x00961E26
		// (set) Token: 0x06025D43 RID: 154947 RVA: 0x00963C3A File Offset: 0x00961E3A
		public unsafe UMaterialInstanceDynamic SkyboxDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_56);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_56, value);
			}
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x06025D44 RID: 154948 RVA: 0x00963C4F File Offset: 0x00961E4F
		// (set) Token: 0x06025D45 RID: 154949 RVA: 0x00963C63 File Offset: 0x00961E63
		public unsafe UMaterialInstance SkyboxMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_57);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_57, value);
			}
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x06025D46 RID: 154950 RVA: 0x00963C78 File Offset: 0x00961E78
		// (set) Token: 0x06025D47 RID: 154951 RVA: 0x00963C8C File Offset: 0x00961E8C
		public unsafe FLinearColor SunDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06025D48 RID: 154952 RVA: 0x00963CA1 File Offset: 0x00961EA1
		// (set) Token: 0x06025D49 RID: 154953 RVA: 0x00963CB5 File Offset: 0x00961EB5
		public unsafe FLinearColor SunScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x06025D4A RID: 154954 RVA: 0x00963CCA File Offset: 0x00961ECA
		// (set) Token: 0x06025D4B RID: 154955 RVA: 0x00963CDA File Offset: 0x00961EDA
		public unsafe float SunSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x06025D4C RID: 154956 RVA: 0x00963CEB File Offset: 0x00961EEB
		// (set) Token: 0x06025D4D RID: 154957 RVA: 0x00963CFF File Offset: 0x00961EFF
		public unsafe FLinearColor MoonDiscColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x06025D4E RID: 154958 RVA: 0x00963D14 File Offset: 0x00961F14
		// (set) Token: 0x06025D4F RID: 154959 RVA: 0x00963D28 File Offset: 0x00961F28
		public unsafe FLinearColor MoonScatterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06025D50 RID: 154960 RVA: 0x00963D3D File Offset: 0x00961F3D
		// (set) Token: 0x06025D51 RID: 154961 RVA: 0x00963D4D File Offset: 0x00961F4D
		public unsafe float MoonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x06025D52 RID: 154962 RVA: 0x00963D5E File Offset: 0x00961F5E
		// (set) Token: 0x06025D53 RID: 154963 RVA: 0x00963D72 File Offset: 0x00961F72
		public unsafe FLinearColor HorizonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x06025D54 RID: 154964 RVA: 0x00963D87 File Offset: 0x00961F87
		// (set) Token: 0x06025D55 RID: 154965 RVA: 0x00963D97 File Offset: 0x00961F97
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x06025D56 RID: 154966 RVA: 0x00963DA8 File Offset: 0x00961FA8
		// (set) Token: 0x06025D57 RID: 154967 RVA: 0x00963DBC File Offset: 0x00961FBC
		public unsafe FLinearColor ZenithColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x06025D58 RID: 154968 RVA: 0x00963DD1 File Offset: 0x00961FD1
		// (set) Token: 0x06025D59 RID: 154969 RVA: 0x00963DE1 File Offset: 0x00961FE1
		public unsafe float ExtremWeatherWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x06025D5A RID: 154970 RVA: 0x00963DF2 File Offset: 0x00961FF2
		// (set) Token: 0x06025D5B RID: 154971 RVA: 0x00963E06 File Offset: 0x00962006
		public unsafe FLinearColor ST_TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x06025D5C RID: 154972 RVA: 0x00963E1B File Offset: 0x0096201B
		// (set) Token: 0x06025D5D RID: 154973 RVA: 0x00963E2F File Offset: 0x0096202F
		public unsafe FLinearColor ST_DomeColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x06025D5E RID: 154974 RVA: 0x00963E44 File Offset: 0x00962044
		// (set) Token: 0x06025D5F RID: 154975 RVA: 0x00963E54 File Offset: 0x00962054
		public unsafe float ST_TopWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_70);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_70) = value;
			}
		}

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x06025D60 RID: 154976 RVA: 0x00963E65 File Offset: 0x00962065
		// (set) Token: 0x06025D61 RID: 154977 RVA: 0x00963E79 File Offset: 0x00962079
		public unsafe UCurveFloat CharMainLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x06025D62 RID: 154978 RVA: 0x00963E8E File Offset: 0x0096208E
		// (set) Token: 0x06025D63 RID: 154979 RVA: 0x00963EA2 File Offset: 0x009620A2
		public unsafe UCurveFloat CharSkyLightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_72);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_72, value);
			}
		}

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x06025D64 RID: 154980 RVA: 0x00963EB7 File Offset: 0x009620B7
		// (set) Token: 0x06025D65 RID: 154981 RVA: 0x00963EC7 File Offset: 0x009620C7
		public unsafe bool UseCharCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_73) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_73) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x06025D66 RID: 154982 RVA: 0x00963ED8 File Offset: 0x009620D8
		// (set) Token: 0x06025D67 RID: 154983 RVA: 0x00963EEC File Offset: 0x009620EC
		public unsafe FLinearColor CharAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x06025D68 RID: 154984 RVA: 0x00963F01 File Offset: 0x00962101
		// (set) Token: 0x06025D69 RID: 154985 RVA: 0x00963F15 File Offset: 0x00962115
		public unsafe FLinearColor CharSkinAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06025D6A RID: 154986 RVA: 0x00963F2A File Offset: 0x0096212A
		// (set) Token: 0x06025D6B RID: 154987 RVA: 0x00963F3E File Offset: 0x0096213E
		public unsafe UCurveFloat CharShadowCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_76);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_76, value);
			}
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06025D6C RID: 154988 RVA: 0x00963F53 File Offset: 0x00962153
		// (set) Token: 0x06025D6D RID: 154989 RVA: 0x00963F67 File Offset: 0x00962167
		public unsafe UMaterialInstance LightFunctionMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_77);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_77, value);
			}
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06025D6E RID: 154990 RVA: 0x00963F7C File Offset: 0x0096217C
		// (set) Token: 0x06025D6F RID: 154991 RVA: 0x00963F8C File Offset: 0x0096218C
		public unsafe float LightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06025D70 RID: 154992 RVA: 0x00963F9D File Offset: 0x0096219D
		// (set) Token: 0x06025D71 RID: 154993 RVA: 0x00963FB1 File Offset: 0x009621B1
		public unsafe UMaterialInstanceDynamic LightFunctionDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_79);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_79, value);
			}
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06025D72 RID: 154994 RVA: 0x00963FC6 File Offset: 0x009621C6
		// (set) Token: 0x06025D73 RID: 154995 RVA: 0x00963FD6 File Offset: 0x009621D6
		public unsafe bool DEBUG开启无音区特殊地表
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_80) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_80) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06025D74 RID: 154996 RVA: 0x00963FE7 File Offset: 0x009621E7
		// (set) Token: 0x06025D75 RID: 154997 RVA: 0x00963FFB File Offset: 0x009621FB
		public unsafe UMaterialInstance LensFlareMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_81);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_81, value);
			}
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06025D76 RID: 154998 RVA: 0x00964010 File Offset: 0x00962210
		// (set) Token: 0x06025D77 RID: 154999 RVA: 0x00964024 File Offset: 0x00962224
		public unsafe UMaterialInstanceDynamic LensFlareDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_82);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_82, value);
			}
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06025D78 RID: 155000 RVA: 0x00964039 File Offset: 0x00962239
		// (set) Token: 0x06025D79 RID: 155001 RVA: 0x0096404D File Offset: 0x0096224D
		public unsafe FLinearColor Nadir_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06025D7A RID: 155002 RVA: 0x00964062 File Offset: 0x00962262
		// (set) Token: 0x06025D7B RID: 155003 RVA: 0x00964072 File Offset: 0x00962272
		public unsafe float Nadir_Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06025D7C RID: 155004 RVA: 0x00964083 File Offset: 0x00962283
		// (set) Token: 0x06025D7D RID: 155005 RVA: 0x00964093 File Offset: 0x00962293
		public unsafe float Sun_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06025D7E RID: 155006 RVA: 0x009640A4 File Offset: 0x009622A4
		// (set) Token: 0x06025D7F RID: 155007 RVA: 0x009640B4 File Offset: 0x009622B4
		public unsafe float Moon_Scatter_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_86);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_86) = value;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x06025D80 RID: 155008 RVA: 0x009640C5 File Offset: 0x009622C5
		// (set) Token: 0x06025D81 RID: 155009 RVA: 0x009640D5 File Offset: 0x009622D5
		public unsafe float MainDirectionLightUpdateThreshold_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x06025D82 RID: 155010 RVA: 0x009640E6 File Offset: 0x009622E6
		// (set) Token: 0x06025D83 RID: 155011 RVA: 0x009640F6 File Offset: 0x009622F6
		public unsafe float MainDirectionLightUpdateThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06025D84 RID: 155012 RVA: 0x00964107 File Offset: 0x00962307
		// (set) Token: 0x06025D85 RID: 155013 RVA: 0x0096411B File Offset: 0x0096231B
		public unsafe FVector GlobalWindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x06025D86 RID: 155014 RVA: 0x00964130 File Offset: 0x00962330
		// (set) Token: 0x06025D87 RID: 155015 RVA: 0x00964144 File Offset: 0x00962344
		public unsafe FVector GlobalWindRightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x06025D88 RID: 155016 RVA: 0x00964159 File Offset: 0x00962359
		// (set) Token: 0x06025D89 RID: 155017 RVA: 0x00964169 File Offset: 0x00962369
		public unsafe float DEBUG无音区特殊地表强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x06025D8A RID: 155018 RVA: 0x0096417A File Offset: 0x0096237A
		// (set) Token: 0x06025D8B RID: 155019 RVA: 0x0096418E File Offset: 0x0096238E
		public unsafe FLinearColor Character_Rim_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x06025D8C RID: 155020 RVA: 0x009641A3 File Offset: 0x009623A3
		// (set) Token: 0x06025D8D RID: 155021 RVA: 0x009641B3 File Offset: 0x009623B3
		public unsafe float RealTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x06025D8E RID: 155022 RVA: 0x009641C4 File Offset: 0x009623C4
		// (set) Token: 0x06025D8F RID: 155023 RVA: 0x009641D8 File Offset: 0x009623D8
		public unsafe FRotator SunRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x06025D90 RID: 155024 RVA: 0x009641ED File Offset: 0x009623ED
		// (set) Token: 0x06025D91 RID: 155025 RVA: 0x009641FD File Offset: 0x009623FD
		public unsafe float DEBUG_角色预览方向光垂直方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x06025D92 RID: 155026 RVA: 0x0096420E File Offset: 0x0096240E
		// (set) Token: 0x06025D93 RID: 155027 RVA: 0x0096421E File Offset: 0x0096241E
		public unsafe float UIWorldZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x06025D94 RID: 155028 RVA: 0x0096422F File Offset: 0x0096242F
		// (set) Token: 0x06025D95 RID: 155029 RVA: 0x0096423F File Offset: 0x0096243F
		public unsafe bool UINeedLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_97) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_97) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x06025D96 RID: 155030 RVA: 0x00964250 File Offset: 0x00962450
		// (set) Token: 0x06025D97 RID: 155031 RVA: 0x00964260 File Offset: 0x00962460
		public unsafe bool CanSpawnEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_98) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_98) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x06025D98 RID: 155032 RVA: 0x00964271 File Offset: 0x00962471
		// (set) Token: 0x06025D99 RID: 155033 RVA: 0x00964281 File Offset: 0x00962481
		public unsafe bool 编辑器下关闭LensFlare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_99) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_99) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x06025D9A RID: 155034 RVA: 0x00964292 File Offset: 0x00962492
		// (set) Token: 0x06025D9B RID: 155035 RVA: 0x009642A6 File Offset: 0x009624A6
		public unsafe UKuroGlobalColorMapComponent KuroGlobalColorMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalColorMapComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_100);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_100, value);
			}
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x06025D9C RID: 155036 RVA: 0x009642BB File Offset: 0x009624BB
		// (set) Token: 0x06025D9D RID: 155037 RVA: 0x009642CF File Offset: 0x009624CF
		public unsafe UKuroGlobalHeightMapComponent KuroGlobalHeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalHeightMapComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_101);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_101, value);
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x06025D9E RID: 155038 RVA: 0x009642E4 File Offset: 0x009624E4
		// (set) Token: 0x06025D9F RID: 155039 RVA: 0x009642F4 File Offset: 0x009624F4
		public unsafe bool IsComponentsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_102) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_102) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x06025DA0 RID: 155040 RVA: 0x00964305 File Offset: 0x00962505
		// (set) Token: 0x06025DA1 RID: 155041 RVA: 0x00964315 File Offset: 0x00962515
		public unsafe float DefaultSkyLightShadowSupplement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x06025DA2 RID: 155042 RVA: 0x00964326 File Offset: 0x00962526
		// (set) Token: 0x06025DA3 RID: 155043 RVA: 0x00964336 File Offset: 0x00962536
		public unsafe float DefaultSkyLightReflectionAddIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x06025DA4 RID: 155044 RVA: 0x00964347 File Offset: 0x00962547
		// (set) Token: 0x06025DA5 RID: 155045 RVA: 0x0096435B File Offset: 0x0096255B
		public unsafe UChildActorComponent RainOverrider
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_105);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_105, value);
			}
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x06025DA6 RID: 155046 RVA: 0x00964370 File Offset: 0x00962570
		// (set) Token: 0x06025DA7 RID: 155047 RVA: 0x00964384 File Offset: 0x00962584
		public unsafe BP_Clouds_C DynamicCloudsActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Clouds_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_106);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_106, value);
			}
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x06025DA8 RID: 155048 RVA: 0x00964399 File Offset: 0x00962599
		// (set) Token: 0x06025DA9 RID: 155049 RVA: 0x009643A9 File Offset: 0x009625A9
		public unsafe float Clouds_Change_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_107);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_107) = value;
			}
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x06025DAA RID: 155050 RVA: 0x009643BA File Offset: 0x009625BA
		// (set) Token: 0x06025DAB RID: 155051 RVA: 0x009643CE File Offset: 0x009625CE
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroDynamicCloudType> LocalDynamicCloudsType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_108);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_108) = value;
			}
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x06025DAC RID: 155052 RVA: 0x009643E3 File Offset: 0x009625E3
		// (set) Token: 0x06025DAD RID: 155053 RVA: 0x009643F3 File Offset: 0x009625F3
		public unsafe float Clouds_Change_CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_109);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_109) = value;
			}
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x06025DAE RID: 155054 RVA: 0x00964404 File Offset: 0x00962604
		// (set) Token: 0x06025DAF RID: 155055 RVA: 0x00964414 File Offset: 0x00962614
		public unsafe bool Is_Editor_Update
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_110) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_110) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x06025DB0 RID: 155056 RVA: 0x00964425 File Offset: 0x00962625
		// (set) Token: 0x06025DB1 RID: 155057 RVA: 0x00964435 File Offset: 0x00962635
		public unsafe bool 启用时间参数写入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_111) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_111) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x06025DB2 RID: 155058 RVA: 0x00964446 File Offset: 0x00962646
		// (set) Token: 0x06025DB3 RID: 155059 RVA: 0x0096445A File Offset: 0x0096265A
		public unsafe UTexture InitLightFunctionMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_112);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_112, value);
			}
		}

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x06025DB4 RID: 155060 RVA: 0x0096446F File Offset: 0x0096266F
		// (set) Token: 0x06025DB5 RID: 155061 RVA: 0x00964483 File Offset: 0x00962683
		public unsafe UMaterialInstance StarsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_113);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_113, value);
			}
		}

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x06025DB6 RID: 155062 RVA: 0x00964498 File Offset: 0x00962698
		// (set) Token: 0x06025DB7 RID: 155063 RVA: 0x009644AC File Offset: 0x009626AC
		public unsafe UStaticMeshComponent SM_Stars
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_114);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_114, value);
			}
		}

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06025DB8 RID: 155064 RVA: 0x009644C1 File Offset: 0x009626C1
		// (set) Token: 0x06025DB9 RID: 155065 RVA: 0x009644D5 File Offset: 0x009626D5
		public unsafe UMaterialInstance MilkyWayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_115);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_115, value);
			}
		}

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x06025DBA RID: 155066 RVA: 0x009644EA File Offset: 0x009626EA
		// (set) Token: 0x06025DBB RID: 155067 RVA: 0x009644FE File Offset: 0x009626FE
		public unsafe UStaticMeshComponent SM_MilkyWay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_116);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_116, value);
			}
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x06025DBC RID: 155068 RVA: 0x00964513 File Offset: 0x00962713
		// (set) Token: 0x06025DBD RID: 155069 RVA: 0x00964527 File Offset: 0x00962727
		public unsafe UStaticMeshComponent CloudOcean
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_117);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGI_LaunchScene_C.__PropertyOffset_117, value);
			}
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x06025DBE RID: 155070 RVA: 0x0096453C File Offset: 0x0096273C
		// (set) Token: 0x06025DBF RID: 155071 RVA: 0x00964575 File Offset: 0x00962775
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
					result = (this._FogTImeControl = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_118, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_GlobalGI_LaunchScene_C.__PropertyOffset_118, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025DC0 RID: 155072 RVA: 0x00964596 File Offset: 0x00962796
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Dynamic_Clouds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Update_Dynamic_Clouds_NativeFunctionPtr, null);
		}

		// Token: 0x06025DC1 RID: 155073 RVA: 0x009645AA File Offset: 0x009627AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Big_World()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Update_Big_World_NativeFunctionPtr, null);
		}

		// Token: 0x06025DC2 RID: 155074 RVA: 0x009645BE File Offset: 0x009627BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void On_Global_GITick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__On_Global_GITick_NativeFunctionPtr, null);
		}

		// Token: 0x06025DC3 RID: 155075 RVA: 0x009645D2 File Offset: 0x009627D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06025DC4 RID: 155076 RVA: 0x009645E8 File Offset: 0x009627E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloudCard(ref FKuroCloudCardSetting CloudCardSetting)
		{
			BP_GlobalGI_LaunchScene_C.__UpdateCloudCard_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__UpdateCloudCard_FunctionParams[(UIntPtr)179] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__UpdateCloudCard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr, 1);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), &ptr->CloudCardSetting, CloudCardSetting.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateCloudCard_NativeFunctionPtr, (void*)ptr);
			if (CloudCardSetting != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), CloudCardSetting.NativePtr, &ptr->CloudCardSetting, 1, false);
			}
		}

		// Token: 0x06025DC5 RID: 155077 RVA: 0x00964674 File Offset: 0x00962874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTODCharacterLighting(FLinearColor mainLight, float mainLightIntensity, FLinearColor skyLight, float skyLightIntensity, ref FLinearColor FrontSideLight, ref FLinearColor BackSideLight)
		{
			BP_GlobalGI_LaunchScene_C.__GetTODCharacterLighting_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__GetTODCharacterLighting_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__GetTODCharacterLighting_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mainLight = mainLight;
			ptr->mainLightIntensity = mainLightIntensity;
			ptr->skyLight = skyLight;
			ptr->skyLightIntensity = skyLightIntensity;
			ptr->FrontSideLight = FrontSideLight;
			ptr->BackSideLight = BackSideLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetTODCharacterLighting_NativeFunctionPtr, (void*)ptr);
			FrontSideLight = ptr->FrontSideLight;
			BackSideLight = ptr->BackSideLight;
		}

		// Token: 0x06025DC6 RID: 155078 RVA: 0x00964708 File Offset: 0x00962908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FLinearColor Clamp_Luminance(FLinearColor InColor, float Min, float Max)
		{
			BP_GlobalGI_LaunchScene_C.__Clamp_Luminance_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Clamp_Luminance_FunctionParams[(UIntPtr)123] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Clamp_Luminance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InColor = InColor;
			ptr->Min = Min;
			ptr->Max = Max;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Clamp_Luminance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025DC7 RID: 155079 RVA: 0x00964764 File Offset: 0x00962964
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_GlobalGI_LaunchScene_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06025DC8 RID: 155080 RVA: 0x009647B8 File Offset: 0x009629B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSkyboxDMI(ref UMaterialInstanceDynamic DMIRet)
		{
			BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMIRet;
			ptr2.DMIRet = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetSkyboxDMI_NativeFunctionPtr, (void*)ptr);
			DMIRet = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMIRet);
		}

		// Token: 0x06025DC9 RID: 155081 RVA: 0x0096481C File Offset: 0x00962A1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMisc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateMisc_NativeFunctionPtr, null);
		}

		// Token: 0x06025DCA RID: 155082 RVA: 0x00964830 File Offset: 0x00962A30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTrulyTime(ref float CurTime)
		{
			BP_GlobalGI_LaunchScene_C.__GetTrulyTime_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__GetTrulyTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__GetTrulyTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__GetTrulyTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurTime = CurTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetTrulyTime_NativeFunctionPtr, (void*)ptr);
			CurTime = ptr->CurTime;
		}

		// Token: 0x06025DCB RID: 155083 RVA: 0x0096487F File Offset: 0x00962A7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 申时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__申时_NativeFunctionPtr, null);
		}

		// Token: 0x06025DCC RID: 155084 RVA: 0x00964893 File Offset: 0x00962A93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 下午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__下午_NativeFunctionPtr, null);
		}

		// Token: 0x06025DCD RID: 155085 RVA: 0x009648A7 File Offset: 0x00962AA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 上午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__上午_NativeFunctionPtr, null);
		}

		// Token: 0x06025DCE RID: 155086 RVA: 0x009648BB File Offset: 0x00962ABB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 辰时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__辰时_NativeFunctionPtr, null);
		}

		// Token: 0x06025DCF RID: 155087 RVA: 0x009648CF File Offset: 0x00962ACF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDayNightDataLayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateDayNightDataLayer_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD0 RID: 155088 RVA: 0x009648E3 File Offset: 0x00962AE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD1 RID: 155089 RVA: 0x009648F7 File Offset: 0x00962AF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 夜晚到清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__夜晚到清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD2 RID: 155090 RVA: 0x0096490B File Offset: 0x00962B0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏到夜晚()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__黄昏到夜晚_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD3 RID: 155091 RVA: 0x0096491F File Offset: 0x00962B1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 黄昏()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__黄昏_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD4 RID: 155092 RVA: 0x00964933 File Offset: 0x00962B33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 中午()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__中午_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD5 RID: 155093 RVA: 0x00964947 File Offset: 0x00962B47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清晨()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__清晨_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD6 RID: 155094 RVA: 0x0096495B File Offset: 0x00962B5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetSkyDomeActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetSkyDomeActor_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD7 RID: 155095 RVA: 0x00964970 File Offset: 0x00962B70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Total_TOD_Time_Elapsed(ref float Time)
		{
			BP_GlobalGI_LaunchScene_C.__Get_Total_TOD_Time_Elapsed_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Get_Total_TOD_Time_Elapsed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Get_Total_TOD_Time_Elapsed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Get_Total_TOD_Time_Elapsed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Get_Total_TOD_Time_Elapsed_NativeFunctionPtr, (void*)ptr);
			Time = ptr->Time;
		}

		// Token: 0x06025DD8 RID: 155096 RVA: 0x009649BF File Offset: 0x00962BBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSkyDome()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateSkyDome_NativeFunctionPtr, null);
		}

		// Token: 0x06025DD9 RID: 155097 RVA: 0x009649D3 File Offset: 0x00962BD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__InitGI_NativeFunctionPtr, null);
		}

		// Token: 0x06025DDA RID: 155098 RVA: 0x009649E8 File Offset: 0x00962BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_All_Components_States(bool IsEnable)
		{
			BP_GlobalGI_LaunchScene_C.__Set_All_Components_States_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Set_All_Components_States_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Set_All_Components_States_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEnable = IsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Set_All_Components_States_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DDB RID: 155099 RVA: 0x00964A30 File Offset: 0x00962C30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetUIComponentsVisibility(bool IsVisible)
		{
			BP_GlobalGI_LaunchScene_C.__SetUIComponentsVisibility_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__SetUIComponentsVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__SetUIComponentsVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__SetUIComponentsVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsVisible = IsVisible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__SetUIComponentsVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DDC RID: 155100 RVA: 0x00964A78 File Offset: 0x00962C78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLightDirectionFromVH(float Vertical, float Horizontal, ref FRotator Result)
		{
			BP_GlobalGI_LaunchScene_C.__GetLightDirectionFromVH_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__GetLightDirectionFromVH_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__GetLightDirectionFromVH_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetLightDirectionFromVH_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06025DDD RID: 155101 RVA: 0x00964ADD File Offset: 0x00962CDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Main_Light_Direction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Update_Main_Light_Direction_NativeFunctionPtr, null);
		}

		// Token: 0x06025DDE RID: 155102 RVA: 0x00964AF1 File Offset: 0x00962CF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMainLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateMainLight_NativeFunctionPtr, null);
		}

		// Token: 0x06025DDF RID: 155103 RVA: 0x00964B05 File Offset: 0x00962D05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateTime_NativeFunctionPtr, null);
		}

		// Token: 0x06025DE0 RID: 155104 RVA: 0x00964B1C File Offset: 0x00962D1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetViewLocation(ref FVector WorldPosition, ref bool Suc)
		{
			BP_GlobalGI_LaunchScene_C.__GetViewLocation_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__GetViewLocation_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__GetViewLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPosition = WorldPosition;
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__GetViewLocation_NativeFunctionPtr, (void*)ptr);
			WorldPosition = ptr->WorldPosition;
			Suc = ptr->Suc;
		}

		// Token: 0x06025DE1 RID: 155105 RVA: 0x00964B83 File Offset: 0x00962D83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitFeature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__InitFeature_NativeFunctionPtr, null);
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x00964B98 File Offset: 0x00962D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalulateLightDirectionWithLimit(float V, float H, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_LaunchScene_C.__CalulateLightDirectionWithLimit_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__CalulateLightDirectionWithLimit_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__CalulateLightDirectionWithLimit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__CalulateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V = V;
			ptr->H = H;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__CalulateLightDirectionWithLimit_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025DE3 RID: 155107 RVA: 0x00964C0C File Offset: 0x00962E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateLightDirection(float Vertical, float Horizontal, float Time, ref FRotator NewParam)
		{
			BP_GlobalGI_LaunchScene_C.__CalculateLightDirection_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__CalculateLightDirection_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__CalculateLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vertical = Vertical;
			ptr->Horizontal = Horizontal;
			ptr->Time = Time;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__CalculateLightDirection_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x00964C7C File Offset: 0x00962E7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Scene_Light_Rotator(ref FRotator SunLight, ref FRotator NightLight)
		{
			BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Rotator_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Rotator_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Rotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Rotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Rotator_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025DE5 RID: 155109 RVA: 0x00964CEC File Offset: 0x00962EEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Scene_Light_Direction(ref FVector LightDir)
		{
			BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Direction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LightDir = LightDir;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Get_Scene_Light_Direction_NativeFunctionPtr, (void*)ptr);
			LightDir = ptr->LightDir;
		}

		// Token: 0x06025DE6 RID: 155110 RVA: 0x00964D43 File Offset: 0x00962F43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGICompoemnt()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__InitGICompoemnt_NativeFunctionPtr, null);
		}

		// Token: 0x06025DE7 RID: 155111 RVA: 0x00964D58 File Offset: 0x00962F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Light_Rotator(ref FRotator SunLight, ref FRotator NightLight)
		{
			BP_GlobalGI_LaunchScene_C.__Get_Light_Rotator_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Get_Light_Rotator_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Get_Light_Rotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Get_Light_Rotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Get_Light_Rotator_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025DE8 RID: 155112 RVA: 0x00964DC8 File Offset: 0x00962FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Light_Direction(ref FVector SunLight, ref FVector NightLight)
		{
			BP_GlobalGI_LaunchScene_C.__Get_Light_Direction_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Get_Light_Direction_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Get_Light_Direction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Get_Light_Direction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SunLight = SunLight;
			ptr->NightLight = NightLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Get_Light_Direction_NativeFunctionPtr, (void*)ptr);
			SunLight = ptr->SunLight;
			NightLight = ptr->NightLight;
		}

		// Token: 0x06025DE9 RID: 155113 RVA: 0x00964E37 File Offset: 0x00963037
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMaterials()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__InitMaterials_NativeFunctionPtr, null);
		}

		// Token: 0x06025DEA RID: 155114 RVA: 0x00964E4C File Offset: 0x0096304C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Is_Day(ref bool Result)
		{
			BP_GlobalGI_LaunchScene_C.__Is_Day_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__Is_Day_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__Is_Day_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__Is_Day_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Is_Day_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06025DEB RID: 155115 RVA: 0x00964E9B File Offset: 0x0096309B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Env()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Update_Env_NativeFunctionPtr, null);
		}

		// Token: 0x06025DEC RID: 155116 RVA: 0x00964EAF File Offset: 0x009630AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Fog()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__Update_Fog_NativeFunctionPtr, null);
		}

		// Token: 0x06025DED RID: 155117 RVA: 0x00964EC4 File Offset: 0x009630C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateGIData(bool SkipLerpData)
		{
			BP_GlobalGI_LaunchScene_C.__UpdateGIData_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__UpdateGIData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__UpdateGIData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkipLerpData = SkipLerpData;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UpdateGIData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DEE RID: 155118 RVA: 0x00964F0A File Offset: 0x0096310A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025DEF RID: 155119 RVA: 0x00964F1E File Offset: 0x0096311E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025DF0 RID: 155120 RVA: 0x00964F34 File Offset: 0x00963134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTickEditor(float DeltaTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DF1 RID: 155121 RVA: 0x00964F7C File Offset: 0x0096317C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTickEditor_Implementation(float DeltaTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroTickEditor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025DF2 RID: 155122 RVA: 0x00964FC4 File Offset: 0x009631C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroTick(float DeltaTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DF3 RID: 155123 RVA: 0x0096500C File Offset: 0x0096320C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroTick_Implementation(float DeltaTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025DF4 RID: 155124 RVA: 0x00965053 File Offset: 0x00963253
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025DF5 RID: 155125 RVA: 0x00965067 File Offset: 0x00963267
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025DF6 RID: 155126 RVA: 0x0096507C File Offset: 0x0096327C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroSetRuntimeTime(float CurrentTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025DF7 RID: 155127 RVA: 0x009650C4 File Offset: 0x009632C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroSetRuntimeTime_Implementation(float CurrentTime)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentTime = CurrentTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroSetRuntimeTime_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025DF8 RID: 155128 RVA: 0x0096510C File Offset: 0x0096330C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnKuroStartUiScene(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025DF9 RID: 155129 RVA: 0x00965180 File Offset: 0x00963380
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnKuroStartUiScene_Implementation(string InName, [Nullable(2)] ULevel InUILevel)
		{
			BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InName), InName);
			ptr->InUILevel = ((InUILevel != null) ? InUILevel.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(BP_GlobalGI_LaunchScene_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025DFA RID: 155130 RVA: 0x009651F4 File Offset: 0x009633F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnKuroEndUiScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroEndUiScene_NativeFunctionPtr, null);
		}

		// Token: 0x06025DFB RID: 155131 RVA: 0x00965208 File Offset: 0x00963408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnKuroEndUiScene_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalGI_LaunchScene_C.__OnKuroEndUiScene_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025DFC RID: 155132 RVA: 0x0096521D File Offset: 0x0096341D
		protected BP_GlobalGI_LaunchScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012E51 RID: 77393
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI_LaunchScene.BP_GlobalGI_LaunchScene_C";

		// Token: 0x04012E52 RID: 77394
		private static IntPtr _ClassPtr;

		// Token: 0x04012E53 RID: 77395
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012E54 RID: 77396
		internal static int __PropertyOffset_1;

		// Token: 0x04012E55 RID: 77397
		internal static int __PropertyOffset_2;

		// Token: 0x04012E56 RID: 77398
		internal static int __PropertyOffset_3;

		// Token: 0x04012E57 RID: 77399
		internal static int __PropertyOffset_4;

		// Token: 0x04012E58 RID: 77400
		internal static int __PropertyOffset_5;

		// Token: 0x04012E59 RID: 77401
		internal static int __PropertyOffset_6;

		// Token: 0x04012E5A RID: 77402
		internal static int __PropertyOffset_7;

		// Token: 0x04012E5B RID: 77403
		internal static int __PropertyOffset_8;

		// Token: 0x04012E5C RID: 77404
		internal static int __PropertyOffset_9;

		// Token: 0x04012E5D RID: 77405
		internal static int __PropertyOffset_10;

		// Token: 0x04012E5E RID: 77406
		internal static int __PropertyOffset_11;

		// Token: 0x04012E5F RID: 77407
		internal static int __PropertyOffset_12;

		// Token: 0x04012E60 RID: 77408
		internal static int __PropertyOffset_13;

		// Token: 0x04012E61 RID: 77409
		internal static int __PropertyOffset_14;

		// Token: 0x04012E62 RID: 77410
		internal static int __PropertyOffset_15;

		// Token: 0x04012E63 RID: 77411
		internal static int __PropertyOffset_16;

		// Token: 0x04012E64 RID: 77412
		internal static int __PropertyOffset_17;

		// Token: 0x04012E65 RID: 77413
		internal static int __PropertyOffset_18;

		// Token: 0x04012E66 RID: 77414
		internal static int __PropertyOffset_19;

		// Token: 0x04012E67 RID: 77415
		internal static int __PropertyOffset_20;

		// Token: 0x04012E68 RID: 77416
		internal static int __PropertyOffset_21;

		// Token: 0x04012E69 RID: 77417
		internal static int __PropertyOffset_22;

		// Token: 0x04012E6A RID: 77418
		internal static int __PropertyOffset_23;

		// Token: 0x04012E6B RID: 77419
		internal static int __PropertyOffset_24;

		// Token: 0x04012E6C RID: 77420
		internal static int __PropertyOffset_25;

		// Token: 0x04012E6D RID: 77421
		internal static int __PropertyOffset_26;

		// Token: 0x04012E6E RID: 77422
		internal static int __PropertyOffset_27;

		// Token: 0x04012E6F RID: 77423
		internal static int __PropertyOffset_28;

		// Token: 0x04012E70 RID: 77424
		internal static int __PropertyOffset_29;

		// Token: 0x04012E71 RID: 77425
		internal static int __PropertyOffset_30;

		// Token: 0x04012E72 RID: 77426
		internal static int __PropertyOffset_31;

		// Token: 0x04012E73 RID: 77427
		private TArray<FVector2D> _SunLightExistTime;

		// Token: 0x04012E74 RID: 77428
		internal static int __PropertyOffset_32;

		// Token: 0x04012E75 RID: 77429
		private TArray<FVector2D> _MoonLightExistTime;

		// Token: 0x04012E76 RID: 77430
		internal static int __PropertyOffset_33;

		// Token: 0x04012E77 RID: 77431
		internal static int __PropertyOffset_34;

		// Token: 0x04012E78 RID: 77432
		internal static int __PropertyOffset_35;

		// Token: 0x04012E79 RID: 77433
		internal static int __PropertyOffset_36;

		// Token: 0x04012E7A RID: 77434
		internal static int __PropertyOffset_37;

		// Token: 0x04012E7B RID: 77435
		internal static int __PropertyOffset_38;

		// Token: 0x04012E7C RID: 77436
		internal static int __PropertyOffset_39;

		// Token: 0x04012E7D RID: 77437
		internal static int __PropertyOffset_40;

		// Token: 0x04012E7E RID: 77438
		internal static int __PropertyOffset_41;

		// Token: 0x04012E7F RID: 77439
		internal static int __PropertyOffset_42;

		// Token: 0x04012E80 RID: 77440
		internal static int __PropertyOffset_43;

		// Token: 0x04012E81 RID: 77441
		internal static int __PropertyOffset_44;

		// Token: 0x04012E82 RID: 77442
		internal static int __PropertyOffset_45;

		// Token: 0x04012E83 RID: 77443
		internal static int __PropertyOffset_46;

		// Token: 0x04012E84 RID: 77444
		internal static int __PropertyOffset_47;

		// Token: 0x04012E85 RID: 77445
		internal static int __PropertyOffset_48;

		// Token: 0x04012E86 RID: 77446
		internal static int __PropertyOffset_49;

		// Token: 0x04012E87 RID: 77447
		internal static int __PropertyOffset_50;

		// Token: 0x04012E88 RID: 77448
		internal static int __PropertyOffset_51;

		// Token: 0x04012E89 RID: 77449
		internal static int __PropertyOffset_52;

		// Token: 0x04012E8A RID: 77450
		internal static int __PropertyOffset_53;

		// Token: 0x04012E8B RID: 77451
		internal static int __PropertyOffset_54;

		// Token: 0x04012E8C RID: 77452
		internal static int __PropertyOffset_55;

		// Token: 0x04012E8D RID: 77453
		internal static int __PropertyOffset_56;

		// Token: 0x04012E8E RID: 77454
		internal static int __PropertyOffset_57;

		// Token: 0x04012E8F RID: 77455
		internal static int __PropertyOffset_58;

		// Token: 0x04012E90 RID: 77456
		internal static int __PropertyOffset_59;

		// Token: 0x04012E91 RID: 77457
		internal static int __PropertyOffset_60;

		// Token: 0x04012E92 RID: 77458
		internal static int __PropertyOffset_61;

		// Token: 0x04012E93 RID: 77459
		internal static int __PropertyOffset_62;

		// Token: 0x04012E94 RID: 77460
		internal static int __PropertyOffset_63;

		// Token: 0x04012E95 RID: 77461
		internal static int __PropertyOffset_64;

		// Token: 0x04012E96 RID: 77462
		internal static int __PropertyOffset_65;

		// Token: 0x04012E97 RID: 77463
		internal static int __PropertyOffset_66;

		// Token: 0x04012E98 RID: 77464
		internal static int __PropertyOffset_67;

		// Token: 0x04012E99 RID: 77465
		internal static int __PropertyOffset_68;

		// Token: 0x04012E9A RID: 77466
		internal static int __PropertyOffset_69;

		// Token: 0x04012E9B RID: 77467
		internal static int __PropertyOffset_70;

		// Token: 0x04012E9C RID: 77468
		internal static int __PropertyOffset_71;

		// Token: 0x04012E9D RID: 77469
		internal static int __PropertyOffset_72;

		// Token: 0x04012E9E RID: 77470
		internal static int __PropertyOffset_73;

		// Token: 0x04012E9F RID: 77471
		internal static int __PropertyOffset_74;

		// Token: 0x04012EA0 RID: 77472
		internal static int __PropertyOffset_75;

		// Token: 0x04012EA1 RID: 77473
		internal static int __PropertyOffset_76;

		// Token: 0x04012EA2 RID: 77474
		internal static int __PropertyOffset_77;

		// Token: 0x04012EA3 RID: 77475
		internal static int __PropertyOffset_78;

		// Token: 0x04012EA4 RID: 77476
		internal static int __PropertyOffset_79;

		// Token: 0x04012EA5 RID: 77477
		internal static int __PropertyOffset_80;

		// Token: 0x04012EA6 RID: 77478
		internal static int __PropertyOffset_81;

		// Token: 0x04012EA7 RID: 77479
		internal static int __PropertyOffset_82;

		// Token: 0x04012EA8 RID: 77480
		internal static int __PropertyOffset_83;

		// Token: 0x04012EA9 RID: 77481
		internal static int __PropertyOffset_84;

		// Token: 0x04012EAA RID: 77482
		internal static int __PropertyOffset_85;

		// Token: 0x04012EAB RID: 77483
		internal static int __PropertyOffset_86;

		// Token: 0x04012EAC RID: 77484
		internal static int __PropertyOffset_87;

		// Token: 0x04012EAD RID: 77485
		internal static int __PropertyOffset_88;

		// Token: 0x04012EAE RID: 77486
		internal static int __PropertyOffset_89;

		// Token: 0x04012EAF RID: 77487
		internal static int __PropertyOffset_90;

		// Token: 0x04012EB0 RID: 77488
		internal static int __PropertyOffset_91;

		// Token: 0x04012EB1 RID: 77489
		internal static int __PropertyOffset_92;

		// Token: 0x04012EB2 RID: 77490
		internal static int __PropertyOffset_93;

		// Token: 0x04012EB3 RID: 77491
		internal static int __PropertyOffset_94;

		// Token: 0x04012EB4 RID: 77492
		internal static int __PropertyOffset_95;

		// Token: 0x04012EB5 RID: 77493
		internal static int __PropertyOffset_96;

		// Token: 0x04012EB6 RID: 77494
		internal static int __PropertyOffset_97;

		// Token: 0x04012EB7 RID: 77495
		internal static int __PropertyOffset_98;

		// Token: 0x04012EB8 RID: 77496
		internal static int __PropertyOffset_99;

		// Token: 0x04012EB9 RID: 77497
		internal static int __PropertyOffset_100;

		// Token: 0x04012EBA RID: 77498
		internal static int __PropertyOffset_101;

		// Token: 0x04012EBB RID: 77499
		internal static int __PropertyOffset_102;

		// Token: 0x04012EBC RID: 77500
		internal static int __PropertyOffset_103;

		// Token: 0x04012EBD RID: 77501
		internal static int __PropertyOffset_104;

		// Token: 0x04012EBE RID: 77502
		internal static int __PropertyOffset_105;

		// Token: 0x04012EBF RID: 77503
		internal static int __PropertyOffset_106;

		// Token: 0x04012EC0 RID: 77504
		internal static int __PropertyOffset_107;

		// Token: 0x04012EC1 RID: 77505
		internal static int __PropertyOffset_108;

		// Token: 0x04012EC2 RID: 77506
		internal static int __PropertyOffset_109;

		// Token: 0x04012EC3 RID: 77507
		internal static int __PropertyOffset_110;

		// Token: 0x04012EC4 RID: 77508
		internal static int __PropertyOffset_111;

		// Token: 0x04012EC5 RID: 77509
		internal static int __PropertyOffset_112;

		// Token: 0x04012EC6 RID: 77510
		internal static int __PropertyOffset_113;

		// Token: 0x04012EC7 RID: 77511
		internal static int __PropertyOffset_114;

		// Token: 0x04012EC8 RID: 77512
		internal static int __PropertyOffset_115;

		// Token: 0x04012EC9 RID: 77513
		internal static int __PropertyOffset_116;

		// Token: 0x04012ECA RID: 77514
		internal static int __PropertyOffset_117;

		// Token: 0x04012ECB RID: 77515
		internal static int __PropertyOffset_118;

		// Token: 0x04012ECC RID: 77516
		private FKuroCurveFloat _FogTImeControl;

		// Token: 0x04012ECD RID: 77517
		private static IntPtr __Update_Dynamic_Clouds_NativeFunctionPtr;

		// Token: 0x04012ECE RID: 77518
		private static IntPtr __Update_Big_World_NativeFunctionPtr;

		// Token: 0x04012ECF RID: 77519
		private static IntPtr __On_Global_GITick_NativeFunctionPtr;

		// Token: 0x04012ED0 RID: 77520
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x04012ED1 RID: 77521
		private static IntPtr __UpdateCloudCard_NativeFunctionPtr;

		// Token: 0x04012ED2 RID: 77522
		private static IntPtr __GetTODCharacterLighting_NativeFunctionPtr;

		// Token: 0x04012ED3 RID: 77523
		private static IntPtr __Clamp_Luminance_NativeFunctionPtr;

		// Token: 0x04012ED4 RID: 77524
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x04012ED5 RID: 77525
		private static IntPtr __GetSkyboxDMI_NativeFunctionPtr;

		// Token: 0x04012ED6 RID: 77526
		private static IntPtr __UpdateMisc_NativeFunctionPtr;

		// Token: 0x04012ED7 RID: 77527
		private static IntPtr __GetTrulyTime_NativeFunctionPtr;

		// Token: 0x04012ED8 RID: 77528
		private static IntPtr __申时_NativeFunctionPtr;

		// Token: 0x04012ED9 RID: 77529
		private static IntPtr __下午_NativeFunctionPtr;

		// Token: 0x04012EDA RID: 77530
		private static IntPtr __上午_NativeFunctionPtr;

		// Token: 0x04012EDB RID: 77531
		private static IntPtr __辰时_NativeFunctionPtr;

		// Token: 0x04012EDC RID: 77532
		private static IntPtr __UpdateDayNightDataLayer_NativeFunctionPtr;

		// Token: 0x04012EDD RID: 77533
		private static IntPtr __夜晚_NativeFunctionPtr;

		// Token: 0x04012EDE RID: 77534
		private static IntPtr __夜晚到清晨_NativeFunctionPtr;

		// Token: 0x04012EDF RID: 77535
		private static IntPtr __黄昏到夜晚_NativeFunctionPtr;

		// Token: 0x04012EE0 RID: 77536
		private static IntPtr __黄昏_NativeFunctionPtr;

		// Token: 0x04012EE1 RID: 77537
		private static IntPtr __中午_NativeFunctionPtr;

		// Token: 0x04012EE2 RID: 77538
		private static IntPtr __清晨_NativeFunctionPtr;

		// Token: 0x04012EE3 RID: 77539
		private static IntPtr __GetSkyDomeActor_NativeFunctionPtr;

		// Token: 0x04012EE4 RID: 77540
		private static IntPtr __Get_Total_TOD_Time_Elapsed_NativeFunctionPtr;

		// Token: 0x04012EE5 RID: 77541
		private static IntPtr __UpdateSkyDome_NativeFunctionPtr;

		// Token: 0x04012EE6 RID: 77542
		private static IntPtr __InitGI_NativeFunctionPtr;

		// Token: 0x04012EE7 RID: 77543
		private static IntPtr __Set_All_Components_States_NativeFunctionPtr;

		// Token: 0x04012EE8 RID: 77544
		private static IntPtr __SetUIComponentsVisibility_NativeFunctionPtr;

		// Token: 0x04012EE9 RID: 77545
		private static IntPtr __GetLightDirectionFromVH_NativeFunctionPtr;

		// Token: 0x04012EEA RID: 77546
		private static IntPtr __Update_Main_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012EEB RID: 77547
		private static IntPtr __UpdateMainLight_NativeFunctionPtr;

		// Token: 0x04012EEC RID: 77548
		private static IntPtr __UpdateTime_NativeFunctionPtr;

		// Token: 0x04012EED RID: 77549
		private static IntPtr __GetViewLocation_NativeFunctionPtr;

		// Token: 0x04012EEE RID: 77550
		private static IntPtr __InitFeature_NativeFunctionPtr;

		// Token: 0x04012EEF RID: 77551
		private static IntPtr __CalulateLightDirectionWithLimit_NativeFunctionPtr;

		// Token: 0x04012EF0 RID: 77552
		private static IntPtr __CalculateLightDirection_NativeFunctionPtr;

		// Token: 0x04012EF1 RID: 77553
		private static IntPtr __Get_Scene_Light_Rotator_NativeFunctionPtr;

		// Token: 0x04012EF2 RID: 77554
		private static IntPtr __Get_Scene_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012EF3 RID: 77555
		private static IntPtr __InitGICompoemnt_NativeFunctionPtr;

		// Token: 0x04012EF4 RID: 77556
		private static IntPtr __Get_Light_Rotator_NativeFunctionPtr;

		// Token: 0x04012EF5 RID: 77557
		private static IntPtr __Get_Light_Direction_NativeFunctionPtr;

		// Token: 0x04012EF6 RID: 77558
		private static IntPtr __InitMaterials_NativeFunctionPtr;

		// Token: 0x04012EF7 RID: 77559
		private static IntPtr __Is_Day_NativeFunctionPtr;

		// Token: 0x04012EF8 RID: 77560
		private static IntPtr __Update_Env_NativeFunctionPtr;

		// Token: 0x04012EF9 RID: 77561
		private static IntPtr __Update_Fog_NativeFunctionPtr;

		// Token: 0x04012EFA RID: 77562
		private static IntPtr __UpdateGIData_NativeFunctionPtr;

		// Token: 0x04012EFB RID: 77563
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012EFC RID: 77564
		private static IntPtr __OnKuroTickEditor_NativeFunctionPtr;

		// Token: 0x04012EFD RID: 77565
		private static IntPtr __OnKuroTick_NativeFunctionPtr;

		// Token: 0x04012EFE RID: 77566
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012EFF RID: 77567
		private static IntPtr __OnKuroSetRuntimeTime_NativeFunctionPtr;

		// Token: 0x04012F00 RID: 77568
		private static IntPtr __OnKuroStartUiScene_NativeFunctionPtr;

		// Token: 0x04012F01 RID: 77569
		private static IntPtr __OnKuroEndUiScene_NativeFunctionPtr;

		// Token: 0x0200A03E RID: 41022
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 164)]
		protected ref struct __UpdateCloudCard_FunctionParams
		{
			// Token: 0x04031AFF RID: 203519
			[FieldOffset(0)]
			public byte CloudCardSetting;
		}

		// Token: 0x0200A03F RID: 41023
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetTODCharacterLighting_FunctionParams
		{
			// Token: 0x04031B00 RID: 203520
			[FieldOffset(0)]
			public FLinearColor mainLight;

			// Token: 0x04031B01 RID: 203521
			[FieldOffset(16)]
			public float mainLightIntensity;

			// Token: 0x04031B02 RID: 203522
			[FieldOffset(20)]
			public FLinearColor skyLight;

			// Token: 0x04031B03 RID: 203523
			[FieldOffset(36)]
			public float skyLightIntensity;

			// Token: 0x04031B04 RID: 203524
			[FieldOffset(40)]
			public FLinearColor FrontSideLight;

			// Token: 0x04031B05 RID: 203525
			[FieldOffset(56)]
			public FLinearColor BackSideLight;
		}

		// Token: 0x0200A040 RID: 41024
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 108)]
		protected ref struct __Clamp_Luminance_FunctionParams
		{
			// Token: 0x04031B06 RID: 203526
			[FieldOffset(0)]
			public FLinearColor InColor;

			// Token: 0x04031B07 RID: 203527
			[FieldOffset(16)]
			public float Min;

			// Token: 0x04031B08 RID: 203528
			[FieldOffset(20)]
			public float Max;

			// Token: 0x04031B09 RID: 203529
			[FieldOffset(24)]
			public FLinearColor __Result;
		}

		// Token: 0x0200A041 RID: 41025
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031B0A RID: 203530
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031B0B RID: 203531
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031B0C RID: 203532
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x0200A042 RID: 41026
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSkyboxDMI_FunctionParams
		{
			// Token: 0x04031B0D RID: 203533
			[FieldOffset(0)]
			public IntPtr DMIRet;
		}

		// Token: 0x0200A043 RID: 41027
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetTrulyTime_FunctionParams
		{
			// Token: 0x04031B0E RID: 203534
			[FieldOffset(0)]
			public float CurTime;
		}

		// Token: 0x0200A044 RID: 41028
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Get_Total_TOD_Time_Elapsed_FunctionParams
		{
			// Token: 0x04031B0F RID: 203535
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x0200A045 RID: 41029
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __Set_All_Components_States_FunctionParams
		{
			// Token: 0x04031B10 RID: 203536
			[FieldOffset(0)]
			public bool IsEnable;
		}

		// Token: 0x0200A046 RID: 41030
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetUIComponentsVisibility_FunctionParams
		{
			// Token: 0x04031B11 RID: 203537
			[FieldOffset(0)]
			public bool IsVisible;
		}

		// Token: 0x0200A047 RID: 41031
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetLightDirectionFromVH_FunctionParams
		{
			// Token: 0x04031B12 RID: 203538
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031B13 RID: 203539
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031B14 RID: 203540
			[FieldOffset(8)]
			public FRotator Result;
		}

		// Token: 0x0200A048 RID: 41032
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetViewLocation_FunctionParams
		{
			// Token: 0x04031B15 RID: 203541
			[FieldOffset(0)]
			public FVector WorldPosition;

			// Token: 0x04031B16 RID: 203542
			[FieldOffset(12)]
			public bool Suc;
		}

		// Token: 0x0200A049 RID: 41033
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __CalulateLightDirectionWithLimit_FunctionParams
		{
			// Token: 0x04031B17 RID: 203543
			[FieldOffset(0)]
			public float V;

			// Token: 0x04031B18 RID: 203544
			[FieldOffset(4)]
			public float H;

			// Token: 0x04031B19 RID: 203545
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031B1A RID: 203546
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A04A RID: 41034
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CalculateLightDirection_FunctionParams
		{
			// Token: 0x04031B1B RID: 203547
			[FieldOffset(0)]
			public float Vertical;

			// Token: 0x04031B1C RID: 203548
			[FieldOffset(4)]
			public float Horizontal;

			// Token: 0x04031B1D RID: 203549
			[FieldOffset(8)]
			public float Time;

			// Token: 0x04031B1E RID: 203550
			[FieldOffset(12)]
			public FRotator NewParam;
		}

		// Token: 0x0200A04B RID: 41035
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Rotator_FunctionParams
		{
			// Token: 0x04031B1F RID: 203551
			[FieldOffset(0)]
			public FRotator SunLight;

			// Token: 0x04031B20 RID: 203552
			[FieldOffset(12)]
			public FRotator NightLight;
		}

		// Token: 0x0200A04C RID: 41036
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_Scene_Light_Direction_FunctionParams
		{
			// Token: 0x04031B21 RID: 203553
			[FieldOffset(0)]
			public FVector LightDir;
		}

		// Token: 0x0200A04D RID: 41037
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __Get_Light_Rotator_FunctionParams
		{
			// Token: 0x04031B22 RID: 203554
			[FieldOffset(0)]
			public FRotator SunLight;

			// Token: 0x04031B23 RID: 203555
			[FieldOffset(12)]
			public FRotator NightLight;
		}

		// Token: 0x0200A04E RID: 41038
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __Get_Light_Direction_FunctionParams
		{
			// Token: 0x04031B24 RID: 203556
			[FieldOffset(0)]
			public FVector SunLight;

			// Token: 0x04031B25 RID: 203557
			[FieldOffset(12)]
			public FVector NightLight;
		}

		// Token: 0x0200A04F RID: 41039
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Is_Day_FunctionParams
		{
			// Token: 0x04031B26 RID: 203558
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A050 RID: 41040
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateGIData_FunctionParams
		{
			// Token: 0x04031B27 RID: 203559
			[FieldOffset(0)]
			public bool SkipLerpData;
		}

		// Token: 0x0200A051 RID: 41041
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTickEditor_FunctionParams
		{
			// Token: 0x04031B28 RID: 203560
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A052 RID: 41042
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroTick_FunctionParams
		{
			// Token: 0x04031B29 RID: 203561
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A053 RID: 41043
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnKuroSetRuntimeTime_FunctionParams
		{
			// Token: 0x04031B2A RID: 203562
			[FieldOffset(0)]
			public float CurrentTime;
		}

		// Token: 0x0200A054 RID: 41044
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x04031B2B RID: 203563
			[FieldOffset(0)]
			public FString InName;

			// Token: 0x04031B2C RID: 203564
			[FieldOffset(16)]
			public IntPtr InUILevel;
		}
	}
}
