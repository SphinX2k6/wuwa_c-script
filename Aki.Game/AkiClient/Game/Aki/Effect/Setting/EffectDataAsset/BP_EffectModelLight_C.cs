using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E73 RID: 15987
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelLight.BP_EffectModelLight_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1764)]
	public class BP_EffectModelLight_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602840D RID: 164877 RVA: 0x009A7AFF File Offset: 0x009A5CFF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelLight.BP_EffectModelLight_C");
			}
			return BP_EffectModelLight_C._ClassPtr;
		}

		// Token: 0x0602840E RID: 164878 RVA: 0x009A7B24 File Offset: 0x009A5D24
		public BP_EffectModelLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602840F RID: 164879 RVA: 0x009A7B4C File Offset: 0x009A5D4C
		public BP_EffectModelLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x06028410 RID: 164880 RVA: 0x009A7B80 File Offset: 0x009A5D80
		// (set) Token: 0x06028411 RID: 164881 RVA: 0x009A7BB9 File Offset: 0x009A5DB9
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x06028412 RID: 164882 RVA: 0x009A7BDC File Offset: 0x009A5DDC
		// (set) Token: 0x06028413 RID: 164883 RVA: 0x009A7C15 File Offset: 0x009A5E15
		public FKuroCurveFloat Intensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Intensity) == null)
				{
					result = (this._Intensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x06028414 RID: 164884 RVA: 0x009A7C38 File Offset: 0x009A5E38
		// (set) Token: 0x06028415 RID: 164885 RVA: 0x009A7C71 File Offset: 0x009A5E71
		public FKuroCurveLinearColor Color
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Color) == null)
				{
					result = (this._Color = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x06028416 RID: 164886 RVA: 0x009A7C92 File Offset: 0x009A5E92
		// (set) Token: 0x06028417 RID: 164887 RVA: 0x009A7CA2 File Offset: 0x009A5EA2
		public unsafe float CharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x06028418 RID: 164888 RVA: 0x009A7CB3 File Offset: 0x009A5EB3
		// (set) Token: 0x06028419 RID: 164889 RVA: 0x009A7CC7 File Offset: 0x009A5EC7
		public unsafe FLinearColor CharacterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0602841A RID: 164890 RVA: 0x009A7CDC File Offset: 0x009A5EDC
		// (set) Token: 0x0602841B RID: 164891 RVA: 0x009A7D15 File Offset: 0x009A5F15
		public FKuroCurveFloat Radius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Radius) == null)
				{
					result = (this._Radius = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0602841C RID: 164892 RVA: 0x009A7D38 File Offset: 0x009A5F38
		// (set) Token: 0x0602841D RID: 164893 RVA: 0x009A7D71 File Offset: 0x009A5F71
		public FKuroCurveFloat FalloffExponent
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FalloffExponent) == null)
				{
					result = (this._FalloffExponent = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0602841E RID: 164894 RVA: 0x009A7D92 File Offset: 0x009A5F92
		// (set) Token: 0x0602841F RID: 164895 RVA: 0x009A7DA2 File Offset: 0x009A5FA2
		public unsafe float CharacterFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x06028420 RID: 164896 RVA: 0x009A7DB3 File Offset: 0x009A5FB3
		// (set) Token: 0x06028421 RID: 164897 RVA: 0x009A7DC3 File Offset: 0x009A5FC3
		public unsafe float CharacterBlendAtten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x06028422 RID: 164898 RVA: 0x009A7DD4 File Offset: 0x009A5FD4
		// (set) Token: 0x06028423 RID: 164899 RVA: 0x009A7DE4 File Offset: 0x009A5FE4
		public unsafe int CharacterPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x06028424 RID: 164900 RVA: 0x009A7DF5 File Offset: 0x009A5FF5
		// (set) Token: 0x06028425 RID: 164901 RVA: 0x009A7E05 File Offset: 0x009A6005
		public unsafe float CharacterShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x06028426 RID: 164902 RVA: 0x009A7E16 File Offset: 0x009A6016
		// (set) Token: 0x06028427 RID: 164903 RVA: 0x009A7E26 File Offset: 0x009A6026
		public unsafe float CharacterBaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x06028428 RID: 164904 RVA: 0x009A7E37 File Offset: 0x009A6037
		// (set) Token: 0x06028429 RID: 164905 RVA: 0x009A7E47 File Offset: 0x009A6047
		public unsafe float CharacterHardIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0602842A RID: 164906 RVA: 0x009A7E58 File Offset: 0x009A6058
		// (set) Token: 0x0602842B RID: 164907 RVA: 0x009A7E6C File Offset: 0x009A606C
		public unsafe FLinearColor CharacterHardColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0602842C RID: 164908 RVA: 0x009A7E81 File Offset: 0x009A6081
		// (set) Token: 0x0602842D RID: 164909 RVA: 0x009A7E95 File Offset: 0x009A6095
		public unsafe FLinearColor CharacterHardShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0602842E RID: 164910 RVA: 0x009A7EAA File Offset: 0x009A60AA
		// (set) Token: 0x0602842F RID: 164911 RVA: 0x009A7EBA File Offset: 0x009A60BA
		public unsafe float CharacterHardBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x06028430 RID: 164912 RVA: 0x009A7ECC File Offset: 0x009A60CC
		// (set) Token: 0x06028431 RID: 164913 RVA: 0x009A7F05 File Offset: 0x009A6105
		public FKuroCurveFloat CharacterLightAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._CharacterLightAlpha) == null)
				{
					result = (this._CharacterLightAlpha = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x06028432 RID: 164914 RVA: 0x009A7F26 File Offset: 0x009A6126
		// (set) Token: 0x06028433 RID: 164915 RVA: 0x009A7F36 File Offset: 0x009A6136
		public unsafe bool CachedLocationHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x06028434 RID: 164916 RVA: 0x009A7F47 File Offset: 0x009A6147
		// (set) Token: 0x06028435 RID: 164917 RVA: 0x009A7F57 File Offset: 0x009A6157
		public unsafe bool CachedIntensityHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x06028436 RID: 164918 RVA: 0x009A7F68 File Offset: 0x009A6168
		// (set) Token: 0x06028437 RID: 164919 RVA: 0x009A7F78 File Offset: 0x009A6178
		public unsafe bool CachedColorHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x06028438 RID: 164920 RVA: 0x009A7F89 File Offset: 0x009A6189
		// (set) Token: 0x06028439 RID: 164921 RVA: 0x009A7F99 File Offset: 0x009A6199
		public unsafe bool CachedRadiusHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x0602843A RID: 164922 RVA: 0x009A7FAA File Offset: 0x009A61AA
		// (set) Token: 0x0602843B RID: 164923 RVA: 0x009A7FBA File Offset: 0x009A61BA
		public unsafe bool CachedFallofffExponentHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x0602843C RID: 164924 RVA: 0x009A7FCB File Offset: 0x009A61CB
		// (set) Token: 0x0602843D RID: 164925 RVA: 0x009A7FDB File Offset: 0x009A61DB
		public unsafe bool CachedCharacterLightAlphaHasCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x0602843E RID: 164926 RVA: 0x009A7FEC File Offset: 0x009A61EC
		// (set) Token: 0x0602843F RID: 164927 RVA: 0x009A7FFC File Offset: 0x009A61FC
		public unsafe bool IsCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x06028440 RID: 164928 RVA: 0x009A800D File Offset: 0x009A620D
		// (set) Token: 0x06028441 RID: 164929 RVA: 0x009A801D File Offset: 0x009A621D
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x06028442 RID: 164930 RVA: 0x009A802E File Offset: 0x009A622E
		// (set) Token: 0x06028443 RID: 164931 RVA: 0x009A803E File Offset: 0x009A623E
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x06028444 RID: 164932 RVA: 0x009A804F File Offset: 0x009A624F
		// (set) Token: 0x06028445 RID: 164933 RVA: 0x009A805F File Offset: 0x009A625F
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelLight_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x06028446 RID: 164934 RVA: 0x009A8070 File Offset: 0x009A6270
		protected BP_EffectModelLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147F1 RID: 83953
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelLight.BP_EffectModelLight_C";

		// Token: 0x040147F2 RID: 83954
		private static IntPtr _ClassPtr;

		// Token: 0x040147F3 RID: 83955
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147F4 RID: 83956
		internal new static int __PropertyOffset_0;

		// Token: 0x040147F5 RID: 83957
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040147F6 RID: 83958
		internal new static int __PropertyOffset_1;

		// Token: 0x040147F7 RID: 83959
		[Nullable(2)]
		private FKuroCurveFloat _Intensity;

		// Token: 0x040147F8 RID: 83960
		internal new static int __PropertyOffset_2;

		// Token: 0x040147F9 RID: 83961
		[Nullable(2)]
		private FKuroCurveLinearColor _Color;

		// Token: 0x040147FA RID: 83962
		internal new static int __PropertyOffset_3;

		// Token: 0x040147FB RID: 83963
		internal new static int __PropertyOffset_4;

		// Token: 0x040147FC RID: 83964
		internal new static int __PropertyOffset_5;

		// Token: 0x040147FD RID: 83965
		[Nullable(2)]
		private FKuroCurveFloat _Radius;

		// Token: 0x040147FE RID: 83966
		internal new static int __PropertyOffset_6;

		// Token: 0x040147FF RID: 83967
		[Nullable(2)]
		private FKuroCurveFloat _FalloffExponent;

		// Token: 0x04014800 RID: 83968
		internal new static int __PropertyOffset_7;

		// Token: 0x04014801 RID: 83969
		internal new static int __PropertyOffset_8;

		// Token: 0x04014802 RID: 83970
		internal new static int __PropertyOffset_9;

		// Token: 0x04014803 RID: 83971
		internal new static int __PropertyOffset_10;

		// Token: 0x04014804 RID: 83972
		internal new static int __PropertyOffset_11;

		// Token: 0x04014805 RID: 83973
		internal new static int __PropertyOffset_12;

		// Token: 0x04014806 RID: 83974
		internal static int __PropertyOffset_13;

		// Token: 0x04014807 RID: 83975
		internal static int __PropertyOffset_14;

		// Token: 0x04014808 RID: 83976
		internal static int __PropertyOffset_15;

		// Token: 0x04014809 RID: 83977
		internal static int __PropertyOffset_16;

		// Token: 0x0401480A RID: 83978
		[Nullable(2)]
		private FKuroCurveFloat _CharacterLightAlpha;

		// Token: 0x0401480B RID: 83979
		internal static int __PropertyOffset_17;

		// Token: 0x0401480C RID: 83980
		internal static int __PropertyOffset_18;

		// Token: 0x0401480D RID: 83981
		internal static int __PropertyOffset_19;

		// Token: 0x0401480E RID: 83982
		internal static int __PropertyOffset_20;

		// Token: 0x0401480F RID: 83983
		internal static int __PropertyOffset_21;

		// Token: 0x04014810 RID: 83984
		internal static int __PropertyOffset_22;

		// Token: 0x04014811 RID: 83985
		internal static int __PropertyOffset_23;

		// Token: 0x04014812 RID: 83986
		internal static int __PropertyOffset_24;

		// Token: 0x04014813 RID: 83987
		internal static int __PropertyOffset_25;

		// Token: 0x04014814 RID: 83988
		internal static int __PropertyOffset_26;
	}
}
