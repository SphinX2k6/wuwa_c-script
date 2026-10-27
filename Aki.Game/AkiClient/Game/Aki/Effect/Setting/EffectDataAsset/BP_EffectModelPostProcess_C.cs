using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E76 RID: 15990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelPostProcess.BP_EffectModelPostProcess_C")]
	[UnrealStructLayout(7632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7632)]
	public class BP_EffectModelPostProcess_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602846D RID: 164973 RVA: 0x009A84BC File Offset: 0x009A66BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelPostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelPostProcess.BP_EffectModelPostProcess_C");
			}
			return BP_EffectModelPostProcess_C._ClassPtr;
		}

		// Token: 0x0602846E RID: 164974 RVA: 0x009A84E0 File Offset: 0x009A66E0
		public BP_EffectModelPostProcess_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelPostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602846F RID: 164975 RVA: 0x009A8508 File Offset: 0x009A6708
		public BP_EffectModelPostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelPostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x06028470 RID: 164976 RVA: 0x009A853C File Offset: 0x009A673C
		// (set) Token: 0x06028471 RID: 164977 RVA: 0x009A8575 File Offset: 0x009A6775
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x06028472 RID: 164978 RVA: 0x009A8598 File Offset: 0x009A6798
		// (set) Token: 0x06028473 RID: 164979 RVA: 0x009A85D1 File Offset: 0x009A67D1
		public FKuroCurveFloat BlurIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlurIntensity) == null)
				{
					result = (this._BlurIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x06028474 RID: 164980 RVA: 0x009A85F2 File Offset: 0x009A67F2
		// (set) Token: 0x06028475 RID: 164981 RVA: 0x009A8602 File Offset: 0x009A6802
		public unsafe bool EnableVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x06028476 RID: 164982 RVA: 0x009A8613 File Offset: 0x009A6813
		// (set) Token: 0x06028477 RID: 164983 RVA: 0x009A8623 File Offset: 0x009A6823
		public unsafe float VolumeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x06028478 RID: 164984 RVA: 0x009A8634 File Offset: 0x009A6834
		// (set) Token: 0x06028479 RID: 164985 RVA: 0x009A8644 File Offset: 0x009A6844
		public unsafe float VolumeHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0602847A RID: 164986 RVA: 0x009A8655 File Offset: 0x009A6855
		// (set) Token: 0x0602847B RID: 164987 RVA: 0x009A8665 File Offset: 0x009A6865
		public unsafe bool UseWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0602847C RID: 164988 RVA: 0x009A8676 File Offset: 0x009A6876
		// (set) Token: 0x0602847D RID: 164989 RVA: 0x009A868A File Offset: 0x009A688A
		public unsafe FVector2D ScreenPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x0602847E RID: 164990 RVA: 0x009A869F File Offset: 0x009A689F
		// (set) Token: 0x0602847F RID: 164991 RVA: 0x009A86AF File Offset: 0x009A68AF
		public unsafe bool BlurIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x06028480 RID: 164992 RVA: 0x009A86C0 File Offset: 0x009A68C0
		// (set) Token: 0x06028481 RID: 164993 RVA: 0x009A86D0 File Offset: 0x009A68D0
		public unsafe bool MainLightIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x06028482 RID: 164994 RVA: 0x009A86E4 File Offset: 0x009A68E4
		// (set) Token: 0x06028483 RID: 164995 RVA: 0x009A871D File Offset: 0x009A691D
		public FKuroCurveFloat MainLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MainLightIntensity) == null)
				{
					result = (this._MainLightIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x06028484 RID: 164996 RVA: 0x009A873E File Offset: 0x009A693E
		// (set) Token: 0x06028485 RID: 164997 RVA: 0x009A874E File Offset: 0x009A694E
		public unsafe bool MainLightColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x06028486 RID: 164998 RVA: 0x009A8760 File Offset: 0x009A6960
		// (set) Token: 0x06028487 RID: 164999 RVA: 0x009A8799 File Offset: 0x009A6999
		public FKuroCurveLinearColor MainLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._MainLightColor) == null)
				{
					result = (this._MainLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x06028488 RID: 165000 RVA: 0x009A87BA File Offset: 0x009A69BA
		// (set) Token: 0x06028489 RID: 165001 RVA: 0x009A87CA File Offset: 0x009A69CA
		public unsafe bool SkyLightIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x0602848A RID: 165002 RVA: 0x009A87DC File Offset: 0x009A69DC
		// (set) Token: 0x0602848B RID: 165003 RVA: 0x009A8815 File Offset: 0x009A6A15
		public FKuroCurveFloat SkyLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SkyLightIntensity) == null)
				{
					result = (this._SkyLightIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x0602848C RID: 165004 RVA: 0x009A8836 File Offset: 0x009A6A36
		// (set) Token: 0x0602848D RID: 165005 RVA: 0x009A8846 File Offset: 0x009A6A46
		public unsafe bool SkyLightColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x0602848E RID: 165006 RVA: 0x009A8858 File Offset: 0x009A6A58
		// (set) Token: 0x0602848F RID: 165007 RVA: 0x009A8891 File Offset: 0x009A6A91
		public FKuroCurveLinearColor SkyLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SkyLightColor) == null)
				{
					result = (this._SkyLightColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x06028490 RID: 165008 RVA: 0x009A88B2 File Offset: 0x009A6AB2
		// (set) Token: 0x06028491 RID: 165009 RVA: 0x009A88C2 File Offset: 0x009A6AC2
		public unsafe bool FogDensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x06028492 RID: 165010 RVA: 0x009A88D4 File Offset: 0x009A6AD4
		// (set) Token: 0x06028493 RID: 165011 RVA: 0x009A890D File Offset: 0x009A6B0D
		public FKuroCurveFloat FogDensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogDensity) == null)
				{
					result = (this._FogDensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x06028494 RID: 165012 RVA: 0x009A892E File Offset: 0x009A6B2E
		// (set) Token: 0x06028495 RID: 165013 RVA: 0x009A893E File Offset: 0x009A6B3E
		public unsafe bool FogColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x06028496 RID: 165014 RVA: 0x009A8950 File Offset: 0x009A6B50
		// (set) Token: 0x06028497 RID: 165015 RVA: 0x009A8989 File Offset: 0x009A6B89
		public FKuroCurveLinearColor FogColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._FogColor) == null)
				{
					result = (this._FogColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x06028498 RID: 165016 RVA: 0x009A89AA File Offset: 0x009A6BAA
		// (set) Token: 0x06028499 RID: 165017 RVA: 0x009A89BA File Offset: 0x009A6BBA
		public unsafe bool FogStartDistanceOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x0602849A RID: 165018 RVA: 0x009A89CC File Offset: 0x009A6BCC
		// (set) Token: 0x0602849B RID: 165019 RVA: 0x009A8A05 File Offset: 0x009A6C05
		public FKuroCurveFloat FogStartDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FogStartDistance) == null)
				{
					result = (this._FogStartDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_21, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x0602849C RID: 165020 RVA: 0x009A8A26 File Offset: 0x009A6C26
		// (set) Token: 0x0602849D RID: 165021 RVA: 0x009A8A36 File Offset: 0x009A6C36
		public unsafe bool VolumetricFogColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0602849E RID: 165022 RVA: 0x009A8A48 File Offset: 0x009A6C48
		// (set) Token: 0x0602849F RID: 165023 RVA: 0x009A8A81 File Offset: 0x009A6C81
		public FKuroCurveLinearColor VolumetricFogColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._VolumetricFogColor) == null)
				{
					result = (this._VolumetricFogColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_23, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x060284A0 RID: 165024 RVA: 0x009A8AA2 File Offset: 0x009A6CA2
		// (set) Token: 0x060284A1 RID: 165025 RVA: 0x009A8AB2 File Offset: 0x009A6CB2
		public unsafe bool VolumetricFogFalloffOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x060284A2 RID: 165026 RVA: 0x009A8AC4 File Offset: 0x009A6CC4
		// (set) Token: 0x060284A3 RID: 165027 RVA: 0x009A8AFD File Offset: 0x009A6CFD
		public FKuroCurveFloat VolumetricFogFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VolumetricFogFalloff) == null)
				{
					result = (this._VolumetricFogFalloff = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_25, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x060284A4 RID: 165028 RVA: 0x009A8B1E File Offset: 0x009A6D1E
		// (set) Token: 0x060284A5 RID: 165029 RVA: 0x009A8B2E File Offset: 0x009A6D2E
		public unsafe bool VolumetricFogDistanceOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x060284A6 RID: 165030 RVA: 0x009A8B40 File Offset: 0x009A6D40
		// (set) Token: 0x060284A7 RID: 165031 RVA: 0x009A8B79 File Offset: 0x009A6D79
		public FKuroCurveFloat VolumetricFogDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VolumetricFogDistance) == null)
				{
					result = (this._VolumetricFogDistance = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_27, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x060284A8 RID: 165032 RVA: 0x009A8B9A File Offset: 0x009A6D9A
		// (set) Token: 0x060284A9 RID: 165033 RVA: 0x009A8BAA File Offset: 0x009A6DAA
		public unsafe bool KuroBloomIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x060284AA RID: 165034 RVA: 0x009A8BBC File Offset: 0x009A6DBC
		// (set) Token: 0x060284AB RID: 165035 RVA: 0x009A8BF5 File Offset: 0x009A6DF5
		public FKuroCurveFloat KuroBloomIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroBloomIntensity) == null)
				{
					result = (this._KuroBloomIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_29, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_29, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x060284AC RID: 165036 RVA: 0x009A8C16 File Offset: 0x009A6E16
		// (set) Token: 0x060284AD RID: 165037 RVA: 0x009A8C26 File Offset: 0x009A6E26
		public unsafe bool KuroThresholdOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x060284AE RID: 165038 RVA: 0x009A8C38 File Offset: 0x009A6E38
		// (set) Token: 0x060284AF RID: 165039 RVA: 0x009A8C71 File Offset: 0x009A6E71
		public FKuroCurveFloat KuroThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._KuroThreshold) == null)
				{
					result = (this._KuroThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_31, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x060284B0 RID: 165040 RVA: 0x009A8C92 File Offset: 0x009A6E92
		// (set) Token: 0x060284B1 RID: 165041 RVA: 0x009A8CA2 File Offset: 0x009A6EA2
		public unsafe bool SceneFringeIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x060284B2 RID: 165042 RVA: 0x009A8CB4 File Offset: 0x009A6EB4
		// (set) Token: 0x060284B3 RID: 165043 RVA: 0x009A8CED File Offset: 0x009A6EED
		public FKuroCurveFloat SceneFringeIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SceneFringeIntensity) == null)
				{
					result = (this._SceneFringeIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_33, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x060284B4 RID: 165044 RVA: 0x009A8D0E File Offset: 0x009A6F0E
		// (set) Token: 0x060284B5 RID: 165045 RVA: 0x009A8D1E File Offset: 0x009A6F1E
		public unsafe bool StartOffsetOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x060284B6 RID: 165046 RVA: 0x009A8D30 File Offset: 0x009A6F30
		// (set) Token: 0x060284B7 RID: 165047 RVA: 0x009A8D69 File Offset: 0x009A6F69
		public FKuroCurveFloat StartOffset
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StartOffset) == null)
				{
					result = (this._StartOffset = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_35, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_35, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x060284B8 RID: 165048 RVA: 0x009A8D8A File Offset: 0x009A6F8A
		// (set) Token: 0x060284B9 RID: 165049 RVA: 0x009A8D9A File Offset: 0x009A6F9A
		public unsafe bool VignetteIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x060284BA RID: 165050 RVA: 0x009A8DAC File Offset: 0x009A6FAC
		// (set) Token: 0x060284BB RID: 165051 RVA: 0x009A8DE5 File Offset: 0x009A6FE5
		public FKuroCurveFloat VignetteIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VignetteIntensity) == null)
				{
					result = (this._VignetteIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_37, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x060284BC RID: 165052 RVA: 0x009A8E06 File Offset: 0x009A7006
		// (set) Token: 0x060284BD RID: 165053 RVA: 0x009A8E16 File Offset: 0x009A7016
		public unsafe bool GrainJitterOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x060284BE RID: 165054 RVA: 0x009A8E28 File Offset: 0x009A7028
		// (set) Token: 0x060284BF RID: 165055 RVA: 0x009A8E61 File Offset: 0x009A7061
		public FKuroCurveFloat GrainJitter
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrainJitter) == null)
				{
					result = (this._GrainJitter = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_39, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_39, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x060284C0 RID: 165056 RVA: 0x009A8E82 File Offset: 0x009A7082
		// (set) Token: 0x060284C1 RID: 165057 RVA: 0x009A8E92 File Offset: 0x009A7092
		public unsafe bool GrainIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x060284C2 RID: 165058 RVA: 0x009A8EA4 File Offset: 0x009A70A4
		// (set) Token: 0x060284C3 RID: 165059 RVA: 0x009A8EDD File Offset: 0x009A70DD
		public FKuroCurveFloat GrainIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GrainIntensity) == null)
				{
					result = (this._GrainIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_41, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_41, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x060284C4 RID: 165060 RVA: 0x009A8EFE File Offset: 0x009A70FE
		// (set) Token: 0x060284C5 RID: 165061 RVA: 0x009A8F0E File Offset: 0x009A710E
		public unsafe bool LutIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x060284C6 RID: 165062 RVA: 0x009A8F20 File Offset: 0x009A7120
		// (set) Token: 0x060284C7 RID: 165063 RVA: 0x009A8F59 File Offset: 0x009A7159
		public FKuroCurveFloat LutIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LutIntensity) == null)
				{
					result = (this._LutIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_43, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_43, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x060284C8 RID: 165064 RVA: 0x009A8F7A File Offset: 0x009A717A
		// (set) Token: 0x060284C9 RID: 165065 RVA: 0x009A8F8A File Offset: 0x009A718A
		public unsafe bool LutTextureOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x060284CA RID: 165066 RVA: 0x009A8F9B File Offset: 0x009A719B
		// (set) Token: 0x060284CB RID: 165067 RVA: 0x009A8FAF File Offset: 0x009A71AF
		[Nullable(2)]
		public unsafe UTexture2D LutTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_45);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x060284CC RID: 165068 RVA: 0x009A8FC4 File Offset: 0x009A71C4
		// (set) Token: 0x060284CD RID: 165069 RVA: 0x009A8FD4 File Offset: 0x009A71D4
		public unsafe bool SceneColorTintOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x060284CE RID: 165070 RVA: 0x009A8FE8 File Offset: 0x009A71E8
		// (set) Token: 0x060284CF RID: 165071 RVA: 0x009A9021 File Offset: 0x009A7221
		public FKuroCurveLinearColor SceneColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SceneColorTint) == null)
				{
					result = (this._SceneColorTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_47, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_47, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x060284D0 RID: 165072 RVA: 0x009A9042 File Offset: 0x009A7242
		// (set) Token: 0x060284D1 RID: 165073 RVA: 0x009A9052 File Offset: 0x009A7252
		public unsafe bool BlackWhiteFlashIntensityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x060284D2 RID: 165074 RVA: 0x009A9064 File Offset: 0x009A7264
		// (set) Token: 0x060284D3 RID: 165075 RVA: 0x009A909D File Offset: 0x009A729D
		public FKuroCurveFloat BlackWhiteFlashIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashIntensity) == null)
				{
					result = (this._BlackWhiteFlashIntensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_49, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_49, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x060284D4 RID: 165076 RVA: 0x009A90BE File Offset: 0x009A72BE
		// (set) Token: 0x060284D5 RID: 165077 RVA: 0x009A90CE File Offset: 0x009A72CE
		public unsafe bool BlackWhiteFlashFactorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x060284D6 RID: 165078 RVA: 0x009A90E0 File Offset: 0x009A72E0
		// (set) Token: 0x060284D7 RID: 165079 RVA: 0x009A9119 File Offset: 0x009A7319
		public FKuroCurveFloat BlackWhiteFlashFactor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashFactor) == null)
				{
					result = (this._BlackWhiteFlashFactor = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_51, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_51, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x060284D8 RID: 165080 RVA: 0x009A913A File Offset: 0x009A733A
		// (set) Token: 0x060284D9 RID: 165081 RVA: 0x009A914A File Offset: 0x009A734A
		public unsafe bool BlackWhiteFlashThresholdOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x060284DA RID: 165082 RVA: 0x009A915C File Offset: 0x009A735C
		// (set) Token: 0x060284DB RID: 165083 RVA: 0x009A9195 File Offset: 0x009A7395
		public FKuroCurveFloat BlackWhiteFlashThreshold
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._BlackWhiteFlashThreshold) == null)
				{
					result = (this._BlackWhiteFlashThreshold = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_53, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_53, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x060284DC RID: 165084 RVA: 0x009A91B6 File Offset: 0x009A73B6
		// (set) Token: 0x060284DD RID: 165085 RVA: 0x009A91C6 File Offset: 0x009A73C6
		public unsafe bool BlackWhiteFlashBlackAreaColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x060284DE RID: 165086 RVA: 0x009A91D8 File Offset: 0x009A73D8
		// (set) Token: 0x060284DF RID: 165087 RVA: 0x009A9211 File Offset: 0x009A7411
		public FKuroCurveLinearColor BlackWhiteFlashBlackAreaColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._BlackWhiteFlashBlackAreaColor) == null)
				{
					result = (this._BlackWhiteFlashBlackAreaColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_55, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_55, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x060284E0 RID: 165088 RVA: 0x009A9232 File Offset: 0x009A7432
		// (set) Token: 0x060284E1 RID: 165089 RVA: 0x009A9242 File Offset: 0x009A7442
		public unsafe bool BlackWhiteFlashWhiteAreaColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x060284E2 RID: 165090 RVA: 0x009A9254 File Offset: 0x009A7454
		// (set) Token: 0x060284E3 RID: 165091 RVA: 0x009A928D File Offset: 0x009A748D
		public FKuroCurveLinearColor BlackWhiteFlashWhiteAreaColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._BlackWhiteFlashWhiteAreaColor) == null)
				{
					result = (this._BlackWhiteFlashWhiteAreaColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_57, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_57, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x060284E4 RID: 165092 RVA: 0x009A92AE File Offset: 0x009A74AE
		// (set) Token: 0x060284E5 RID: 165093 RVA: 0x009A92C2 File Offset: 0x009A74C2
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_58);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_58, value);
			}
		}

		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x060284E6 RID: 165094 RVA: 0x009A92D7 File Offset: 0x009A74D7
		// (set) Token: 0x060284E7 RID: 165095 RVA: 0x009A92E7 File Offset: 0x009A74E7
		public unsafe float WeatherPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x060284E8 RID: 165096 RVA: 0x009A92F8 File Offset: 0x009A74F8
		// (set) Token: 0x060284E9 RID: 165097 RVA: 0x009A9308 File Offset: 0x009A7508
		public unsafe bool UseVolumeHardnessCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_60) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_60) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x060284EA RID: 165098 RVA: 0x009A931C File Offset: 0x009A751C
		// (set) Token: 0x060284EB RID: 165099 RVA: 0x009A9355 File Offset: 0x009A7555
		public FKuroCurveFloat VolumeHardnessCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._VolumeHardnessCurve) == null)
				{
					result = (this._VolumeHardnessCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_61, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_61, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x060284EC RID: 165100 RVA: 0x009A9378 File Offset: 0x009A7578
		// (set) Token: 0x060284ED RID: 165101 RVA: 0x009A93B1 File Offset: 0x009A75B1
		public FKuroCurveFloat RadialBlurHardness
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RadialBlurHardness) == null)
				{
					result = (this._RadialBlurHardness = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_62, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_62, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x060284EE RID: 165102 RVA: 0x009A93D4 File Offset: 0x009A75D4
		// (set) Token: 0x060284EF RID: 165103 RVA: 0x009A940D File Offset: 0x009A760D
		public FKuroCurveFloat RadialBlurRadius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._RadialBlurRadius) == null)
				{
					result = (this._RadialBlurRadius = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_63, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_63, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x060284F0 RID: 165104 RVA: 0x009A942E File Offset: 0x009A762E
		// (set) Token: 0x060284F1 RID: 165105 RVA: 0x009A9442 File Offset: 0x009A7642
		[Nullable(2)]
		public unsafe UTexture RadialBlurMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_64);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelPostProcess_C.__PropertyOffset_64, value);
			}
		}

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x060284F2 RID: 165106 RVA: 0x009A9457 File Offset: 0x009A7657
		// (set) Token: 0x060284F3 RID: 165107 RVA: 0x009A946B File Offset: 0x009A766B
		public unsafe FVector2D RadialBlurMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelPostProcess_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x060284F4 RID: 165108 RVA: 0x009A9480 File Offset: 0x009A7680
		protected BP_EffectModelPostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014830 RID: 84016
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelPostProcess.BP_EffectModelPostProcess_C";

		// Token: 0x04014831 RID: 84017
		private static IntPtr _ClassPtr;

		// Token: 0x04014832 RID: 84018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014833 RID: 84019
		internal new static int __PropertyOffset_0;

		// Token: 0x04014834 RID: 84020
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04014835 RID: 84021
		internal new static int __PropertyOffset_1;

		// Token: 0x04014836 RID: 84022
		[Nullable(2)]
		private FKuroCurveFloat _BlurIntensity;

		// Token: 0x04014837 RID: 84023
		internal new static int __PropertyOffset_2;

		// Token: 0x04014838 RID: 84024
		internal new static int __PropertyOffset_3;

		// Token: 0x04014839 RID: 84025
		internal new static int __PropertyOffset_4;

		// Token: 0x0401483A RID: 84026
		internal new static int __PropertyOffset_5;

		// Token: 0x0401483B RID: 84027
		internal new static int __PropertyOffset_6;

		// Token: 0x0401483C RID: 84028
		internal new static int __PropertyOffset_7;

		// Token: 0x0401483D RID: 84029
		internal new static int __PropertyOffset_8;

		// Token: 0x0401483E RID: 84030
		internal new static int __PropertyOffset_9;

		// Token: 0x0401483F RID: 84031
		[Nullable(2)]
		private FKuroCurveFloat _MainLightIntensity;

		// Token: 0x04014840 RID: 84032
		internal new static int __PropertyOffset_10;

		// Token: 0x04014841 RID: 84033
		internal new static int __PropertyOffset_11;

		// Token: 0x04014842 RID: 84034
		[Nullable(2)]
		private FKuroCurveLinearColor _MainLightColor;

		// Token: 0x04014843 RID: 84035
		internal new static int __PropertyOffset_12;

		// Token: 0x04014844 RID: 84036
		internal static int __PropertyOffset_13;

		// Token: 0x04014845 RID: 84037
		[Nullable(2)]
		private FKuroCurveFloat _SkyLightIntensity;

		// Token: 0x04014846 RID: 84038
		internal static int __PropertyOffset_14;

		// Token: 0x04014847 RID: 84039
		internal static int __PropertyOffset_15;

		// Token: 0x04014848 RID: 84040
		[Nullable(2)]
		private FKuroCurveLinearColor _SkyLightColor;

		// Token: 0x04014849 RID: 84041
		internal static int __PropertyOffset_16;

		// Token: 0x0401484A RID: 84042
		internal static int __PropertyOffset_17;

		// Token: 0x0401484B RID: 84043
		[Nullable(2)]
		private FKuroCurveFloat _FogDensity;

		// Token: 0x0401484C RID: 84044
		internal static int __PropertyOffset_18;

		// Token: 0x0401484D RID: 84045
		internal static int __PropertyOffset_19;

		// Token: 0x0401484E RID: 84046
		[Nullable(2)]
		private FKuroCurveLinearColor _FogColor;

		// Token: 0x0401484F RID: 84047
		internal static int __PropertyOffset_20;

		// Token: 0x04014850 RID: 84048
		internal static int __PropertyOffset_21;

		// Token: 0x04014851 RID: 84049
		[Nullable(2)]
		private FKuroCurveFloat _FogStartDistance;

		// Token: 0x04014852 RID: 84050
		internal static int __PropertyOffset_22;

		// Token: 0x04014853 RID: 84051
		internal static int __PropertyOffset_23;

		// Token: 0x04014854 RID: 84052
		[Nullable(2)]
		private FKuroCurveLinearColor _VolumetricFogColor;

		// Token: 0x04014855 RID: 84053
		internal static int __PropertyOffset_24;

		// Token: 0x04014856 RID: 84054
		internal static int __PropertyOffset_25;

		// Token: 0x04014857 RID: 84055
		[Nullable(2)]
		private FKuroCurveFloat _VolumetricFogFalloff;

		// Token: 0x04014858 RID: 84056
		internal static int __PropertyOffset_26;

		// Token: 0x04014859 RID: 84057
		internal static int __PropertyOffset_27;

		// Token: 0x0401485A RID: 84058
		[Nullable(2)]
		private FKuroCurveFloat _VolumetricFogDistance;

		// Token: 0x0401485B RID: 84059
		internal static int __PropertyOffset_28;

		// Token: 0x0401485C RID: 84060
		internal static int __PropertyOffset_29;

		// Token: 0x0401485D RID: 84061
		[Nullable(2)]
		private FKuroCurveFloat _KuroBloomIntensity;

		// Token: 0x0401485E RID: 84062
		internal static int __PropertyOffset_30;

		// Token: 0x0401485F RID: 84063
		internal static int __PropertyOffset_31;

		// Token: 0x04014860 RID: 84064
		[Nullable(2)]
		private FKuroCurveFloat _KuroThreshold;

		// Token: 0x04014861 RID: 84065
		internal static int __PropertyOffset_32;

		// Token: 0x04014862 RID: 84066
		internal static int __PropertyOffset_33;

		// Token: 0x04014863 RID: 84067
		[Nullable(2)]
		private FKuroCurveFloat _SceneFringeIntensity;

		// Token: 0x04014864 RID: 84068
		internal static int __PropertyOffset_34;

		// Token: 0x04014865 RID: 84069
		internal static int __PropertyOffset_35;

		// Token: 0x04014866 RID: 84070
		[Nullable(2)]
		private FKuroCurveFloat _StartOffset;

		// Token: 0x04014867 RID: 84071
		internal static int __PropertyOffset_36;

		// Token: 0x04014868 RID: 84072
		internal static int __PropertyOffset_37;

		// Token: 0x04014869 RID: 84073
		[Nullable(2)]
		private FKuroCurveFloat _VignetteIntensity;

		// Token: 0x0401486A RID: 84074
		internal static int __PropertyOffset_38;

		// Token: 0x0401486B RID: 84075
		internal static int __PropertyOffset_39;

		// Token: 0x0401486C RID: 84076
		[Nullable(2)]
		private FKuroCurveFloat _GrainJitter;

		// Token: 0x0401486D RID: 84077
		internal static int __PropertyOffset_40;

		// Token: 0x0401486E RID: 84078
		internal static int __PropertyOffset_41;

		// Token: 0x0401486F RID: 84079
		[Nullable(2)]
		private FKuroCurveFloat _GrainIntensity;

		// Token: 0x04014870 RID: 84080
		internal static int __PropertyOffset_42;

		// Token: 0x04014871 RID: 84081
		internal static int __PropertyOffset_43;

		// Token: 0x04014872 RID: 84082
		[Nullable(2)]
		private FKuroCurveFloat _LutIntensity;

		// Token: 0x04014873 RID: 84083
		internal static int __PropertyOffset_44;

		// Token: 0x04014874 RID: 84084
		internal static int __PropertyOffset_45;

		// Token: 0x04014875 RID: 84085
		internal static int __PropertyOffset_46;

		// Token: 0x04014876 RID: 84086
		internal static int __PropertyOffset_47;

		// Token: 0x04014877 RID: 84087
		[Nullable(2)]
		private FKuroCurveLinearColor _SceneColorTint;

		// Token: 0x04014878 RID: 84088
		internal static int __PropertyOffset_48;

		// Token: 0x04014879 RID: 84089
		internal static int __PropertyOffset_49;

		// Token: 0x0401487A RID: 84090
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashIntensity;

		// Token: 0x0401487B RID: 84091
		internal static int __PropertyOffset_50;

		// Token: 0x0401487C RID: 84092
		internal static int __PropertyOffset_51;

		// Token: 0x0401487D RID: 84093
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashFactor;

		// Token: 0x0401487E RID: 84094
		internal static int __PropertyOffset_52;

		// Token: 0x0401487F RID: 84095
		internal static int __PropertyOffset_53;

		// Token: 0x04014880 RID: 84096
		[Nullable(2)]
		private FKuroCurveFloat _BlackWhiteFlashThreshold;

		// Token: 0x04014881 RID: 84097
		internal static int __PropertyOffset_54;

		// Token: 0x04014882 RID: 84098
		internal static int __PropertyOffset_55;

		// Token: 0x04014883 RID: 84099
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashBlackAreaColor;

		// Token: 0x04014884 RID: 84100
		internal static int __PropertyOffset_56;

		// Token: 0x04014885 RID: 84101
		internal static int __PropertyOffset_57;

		// Token: 0x04014886 RID: 84102
		[Nullable(2)]
		private FKuroCurveLinearColor _BlackWhiteFlashWhiteAreaColor;

		// Token: 0x04014887 RID: 84103
		internal static int __PropertyOffset_58;

		// Token: 0x04014888 RID: 84104
		internal static int __PropertyOffset_59;

		// Token: 0x04014889 RID: 84105
		internal static int __PropertyOffset_60;

		// Token: 0x0401488A RID: 84106
		internal static int __PropertyOffset_61;

		// Token: 0x0401488B RID: 84107
		[Nullable(2)]
		private FKuroCurveFloat _VolumeHardnessCurve;

		// Token: 0x0401488C RID: 84108
		internal static int __PropertyOffset_62;

		// Token: 0x0401488D RID: 84109
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurHardness;

		// Token: 0x0401488E RID: 84110
		internal static int __PropertyOffset_63;

		// Token: 0x0401488F RID: 84111
		[Nullable(2)]
		private FKuroCurveFloat _RadialBlurRadius;

		// Token: 0x04014890 RID: 84112
		internal static int __PropertyOffset_64;

		// Token: 0x04014891 RID: 84113
		internal static int __PropertyOffset_65;
	}
}
