using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1F RID: 15135
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ToonShadowDecal.BP_ToonShadowDecal_C")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1260)]
	public class BP_ToonShadowDecal_C : ADecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060212A5 RID: 135845 RVA: 0x008E6688 File Offset: 0x008E4888
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ToonShadowDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ToonShadowDecal.BP_ToonShadowDecal_C");
			}
			return BP_ToonShadowDecal_C._ClassPtr;
		}

		// Token: 0x060212A6 RID: 135846 RVA: 0x008E66AC File Offset: 0x008E48AC
		public BP_ToonShadowDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_ToonShadowDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212A7 RID: 135847 RVA: 0x008E66D4 File Offset: 0x008E48D4
		[NullableContext(1)]
		public BP_ToonShadowDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ToonShadowDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x060212A8 RID: 135848 RVA: 0x008E6707 File Offset: 0x008E4907
		// (set) Token: 0x060212A9 RID: 135849 RVA: 0x008E671B File Offset: 0x008E491B
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x060212AA RID: 135850 RVA: 0x008E6730 File Offset: 0x008E4930
		// (set) Token: 0x060212AB RID: 135851 RVA: 0x008E6744 File Offset: 0x008E4944
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x060212AC RID: 135852 RVA: 0x008E6759 File Offset: 0x008E4959
		// (set) Token: 0x060212AD RID: 135853 RVA: 0x008E676D File Offset: 0x008E496D
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x060212AE RID: 135854 RVA: 0x008E6782 File Offset: 0x008E4982
		// (set) Token: 0x060212AF RID: 135855 RVA: 0x008E6796 File Offset: 0x008E4996
		public unsafe UTexture2D ShadowTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x060212B0 RID: 135856 RVA: 0x008E67AB File Offset: 0x008E49AB
		// (set) Token: 0x060212B1 RID: 135857 RVA: 0x008E67BB File Offset: 0x008E49BB
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x060212B2 RID: 135858 RVA: 0x008E67CC File Offset: 0x008E49CC
		// (set) Token: 0x060212B3 RID: 135859 RVA: 0x008E67DC File Offset: 0x008E49DC
		public unsafe float InvShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x060212B4 RID: 135860 RVA: 0x008E67ED File Offset: 0x008E49ED
		// (set) Token: 0x060212B5 RID: 135861 RVA: 0x008E67FD File Offset: 0x008E49FD
		public unsafe float MobileShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x060212B6 RID: 135862 RVA: 0x008E680E File Offset: 0x008E4A0E
		// (set) Token: 0x060212B7 RID: 135863 RVA: 0x008E681E File Offset: 0x008E4A1E
		public unsafe float WindIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x060212B8 RID: 135864 RVA: 0x008E682F File Offset: 0x008E4A2F
		// (set) Token: 0x060212B9 RID: 135865 RVA: 0x008E683F File Offset: 0x008E4A3F
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x060212BA RID: 135866 RVA: 0x008E6850 File Offset: 0x008E4A50
		// (set) Token: 0x060212BB RID: 135867 RVA: 0x008E6860 File Offset: 0x008E4A60
		public unsafe float WindDir_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x060212BC RID: 135868 RVA: 0x008E6871 File Offset: 0x008E4A71
		// (set) Token: 0x060212BD RID: 135869 RVA: 0x008E6881 File Offset: 0x008E4A81
		public unsafe float WindDir_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x060212BE RID: 135870 RVA: 0x008E6892 File Offset: 0x008E4A92
		// (set) Token: 0x060212BF RID: 135871 RVA: 0x008E68A2 File Offset: 0x008E4AA2
		public unsafe float StrenghtAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x060212C0 RID: 135872 RVA: 0x008E68B3 File Offset: 0x008E4AB3
		// (set) Token: 0x060212C1 RID: 135873 RVA: 0x008E68C3 File Offset: 0x008E4AC3
		public unsafe float WindRandomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x060212C2 RID: 135874 RVA: 0x008E68D4 File Offset: 0x008E4AD4
		// (set) Token: 0x060212C3 RID: 135875 RVA: 0x008E68E4 File Offset: 0x008E4AE4
		public unsafe float WindRandomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x060212C4 RID: 135876 RVA: 0x008E68F5 File Offset: 0x008E4AF5
		// (set) Token: 0x060212C5 RID: 135877 RVA: 0x008E6905 File Offset: 0x008E4B05
		public unsafe bool DEBUG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x060212C6 RID: 135878 RVA: 0x008E6916 File Offset: 0x008E4B16
		// (set) Token: 0x060212C7 RID: 135879 RVA: 0x008E6926 File Offset: 0x008E4B26
		public unsafe bool PreMulColorMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x060212C8 RID: 135880 RVA: 0x008E6937 File Offset: 0x008E4B37
		// (set) Token: 0x060212C9 RID: 135881 RVA: 0x008E694B File Offset: 0x008E4B4B
		public unsafe FLinearColor PreMulColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x060212CA RID: 135882 RVA: 0x008E6960 File Offset: 0x008E4B60
		// (set) Token: 0x060212CB RID: 135883 RVA: 0x008E6970 File Offset: 0x008E4B70
		public unsafe float PreMulBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x060212CC RID: 135884 RVA: 0x008E6981 File Offset: 0x008E4B81
		// (set) Token: 0x060212CD RID: 135885 RVA: 0x008E6991 File Offset: 0x008E4B91
		public unsafe float UVPosition_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x060212CE RID: 135886 RVA: 0x008E69A2 File Offset: 0x008E4BA2
		// (set) Token: 0x060212CF RID: 135887 RVA: 0x008E69B2 File Offset: 0x008E4BB2
		public unsafe float UVPosition_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x060212D0 RID: 135888 RVA: 0x008E69C3 File Offset: 0x008E4BC3
		// (set) Token: 0x060212D1 RID: 135889 RVA: 0x008E69D3 File Offset: 0x008E4BD3
		public unsafe float UVScale_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x060212D2 RID: 135890 RVA: 0x008E69E4 File Offset: 0x008E4BE4
		// (set) Token: 0x060212D3 RID: 135891 RVA: 0x008E69F4 File Offset: 0x008E4BF4
		public unsafe float UVScale_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x060212D4 RID: 135892 RVA: 0x008E6A05 File Offset: 0x008E4C05
		// (set) Token: 0x060212D5 RID: 135893 RVA: 0x008E6A15 File Offset: 0x008E4C15
		public unsafe float Only_R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x060212D6 RID: 135894 RVA: 0x008E6A26 File Offset: 0x008E4C26
		// (set) Token: 0x060212D7 RID: 135895 RVA: 0x008E6A36 File Offset: 0x008E4C36
		public unsafe float hard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x060212D8 RID: 135896 RVA: 0x008E6A47 File Offset: 0x008E4C47
		// (set) Token: 0x060212D9 RID: 135897 RVA: 0x008E6A57 File Offset: 0x008E4C57
		public unsafe float Desaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x060212DA RID: 135898 RVA: 0x008E6A68 File Offset: 0x008E4C68
		// (set) Token: 0x060212DB RID: 135899 RVA: 0x008E6A78 File Offset: 0x008E4C78
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x060212DC RID: 135900 RVA: 0x008E6A89 File Offset: 0x008E4C89
		// (set) Token: 0x060212DD RID: 135901 RVA: 0x008E6A99 File Offset: 0x008E4C99
		public unsafe float ShadowUVPosition_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x060212DE RID: 135902 RVA: 0x008E6AAA File Offset: 0x008E4CAA
		// (set) Token: 0x060212DF RID: 135903 RVA: 0x008E6ABA File Offset: 0x008E4CBA
		public unsafe float ShadowUVPosition_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x060212E0 RID: 135904 RVA: 0x008E6ACB File Offset: 0x008E4CCB
		// (set) Token: 0x060212E1 RID: 135905 RVA: 0x008E6ADB File Offset: 0x008E4CDB
		public unsafe float ShadowUVScale_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x060212E2 RID: 135906 RVA: 0x008E6AEC File Offset: 0x008E4CEC
		// (set) Token: 0x060212E3 RID: 135907 RVA: 0x008E6AFC File Offset: 0x008E4CFC
		public unsafe float ShadowUVScale_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x060212E4 RID: 135908 RVA: 0x008E6B0D File Offset: 0x008E4D0D
		// (set) Token: 0x060212E5 RID: 135909 RVA: 0x008E6B1D File Offset: 0x008E4D1D
		public unsafe float hard_Shadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x060212E6 RID: 135910 RVA: 0x008E6B2E File Offset: 0x008E4D2E
		// (set) Token: 0x060212E7 RID: 135911 RVA: 0x008E6B3E File Offset: 0x008E4D3E
		public unsafe bool UseScreenUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x060212E8 RID: 135912 RVA: 0x008E6B4F File Offset: 0x008E4D4F
		// (set) Token: 0x060212E9 RID: 135913 RVA: 0x008E6B63 File Offset: 0x008E4D63
		public unsafe UMaterialInstanceDynamic DebugDYM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ToonShadowDecal_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x060212EA RID: 135914 RVA: 0x008E6B78 File Offset: 0x008E4D78
		// (set) Token: 0x060212EB RID: 135915 RVA: 0x008E6B88 File Offset: 0x008E4D88
		public unsafe float ShadowOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x060212EC RID: 135916 RVA: 0x008E6B99 File Offset: 0x008E4D99
		// (set) Token: 0x060212ED RID: 135917 RVA: 0x008E6BA9 File Offset: 0x008E4DA9
		public unsafe int MaskChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x060212EE RID: 135918 RVA: 0x008E6BBA File Offset: 0x008E4DBA
		// (set) Token: 0x060212EF RID: 135919 RVA: 0x008E6BCA File Offset: 0x008E4DCA
		public unsafe float Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ToonShadowDecal_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x060212F0 RID: 135920 RVA: 0x008E6BDB File Offset: 0x008E4DDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ToonShadowDecal_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x060212F1 RID: 135921 RVA: 0x008E6BEF File Offset: 0x008E4DEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUGPlane()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ToonShadowDecal_C.__DEBUGPlane_NativeFunctionPtr, null);
		}

		// Token: 0x060212F2 RID: 135922 RVA: 0x008E6C03 File Offset: 0x008E4E03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ToonShadowDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060212F3 RID: 135923 RVA: 0x008E6C17 File Offset: 0x008E4E17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ToonShadowDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060212F4 RID: 135924 RVA: 0x008E6C2C File Offset: 0x008E4E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ToonShadowDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060212F5 RID: 135925 RVA: 0x008E6C40 File Offset: 0x008E4E40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ToonShadowDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060212F6 RID: 135926 RVA: 0x008E6C58 File Offset: 0x008E4E58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ToonShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ToonShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060212F7 RID: 135927 RVA: 0x008E6CA0 File Offset: 0x008E4EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ToonShadowDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ToonShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ToonShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060212F8 RID: 135928 RVA: 0x008E6CE7 File Offset: 0x008E4EE7
		protected BP_ToonShadowDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010244 RID: 66116
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ToonShadowDecal.BP_ToonShadowDecal_C";

		// Token: 0x04010245 RID: 66117
		private static IntPtr _ClassPtr;

		// Token: 0x04010246 RID: 66118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010247 RID: 66119
		internal static int __PropertyOffset_1;

		// Token: 0x04010248 RID: 66120
		internal static int __PropertyOffset_2;

		// Token: 0x04010249 RID: 66121
		internal static int __PropertyOffset_3;

		// Token: 0x0401024A RID: 66122
		internal static int __PropertyOffset_4;

		// Token: 0x0401024B RID: 66123
		internal static int __PropertyOffset_5;

		// Token: 0x0401024C RID: 66124
		internal static int __PropertyOffset_6;

		// Token: 0x0401024D RID: 66125
		internal static int __PropertyOffset_7;

		// Token: 0x0401024E RID: 66126
		internal static int __PropertyOffset_8;

		// Token: 0x0401024F RID: 66127
		internal static int __PropertyOffset_9;

		// Token: 0x04010250 RID: 66128
		internal static int __PropertyOffset_10;

		// Token: 0x04010251 RID: 66129
		internal static int __PropertyOffset_11;

		// Token: 0x04010252 RID: 66130
		internal static int __PropertyOffset_12;

		// Token: 0x04010253 RID: 66131
		internal static int __PropertyOffset_13;

		// Token: 0x04010254 RID: 66132
		internal static int __PropertyOffset_14;

		// Token: 0x04010255 RID: 66133
		internal static int __PropertyOffset_15;

		// Token: 0x04010256 RID: 66134
		internal static int __PropertyOffset_16;

		// Token: 0x04010257 RID: 66135
		internal static int __PropertyOffset_17;

		// Token: 0x04010258 RID: 66136
		internal static int __PropertyOffset_18;

		// Token: 0x04010259 RID: 66137
		internal static int __PropertyOffset_19;

		// Token: 0x0401025A RID: 66138
		internal static int __PropertyOffset_20;

		// Token: 0x0401025B RID: 66139
		internal static int __PropertyOffset_21;

		// Token: 0x0401025C RID: 66140
		internal static int __PropertyOffset_22;

		// Token: 0x0401025D RID: 66141
		internal static int __PropertyOffset_23;

		// Token: 0x0401025E RID: 66142
		internal static int __PropertyOffset_24;

		// Token: 0x0401025F RID: 66143
		internal static int __PropertyOffset_25;

		// Token: 0x04010260 RID: 66144
		internal static int __PropertyOffset_26;

		// Token: 0x04010261 RID: 66145
		internal static int __PropertyOffset_27;

		// Token: 0x04010262 RID: 66146
		internal static int __PropertyOffset_28;

		// Token: 0x04010263 RID: 66147
		internal static int __PropertyOffset_29;

		// Token: 0x04010264 RID: 66148
		internal static int __PropertyOffset_30;

		// Token: 0x04010265 RID: 66149
		internal static int __PropertyOffset_31;

		// Token: 0x04010266 RID: 66150
		internal static int __PropertyOffset_32;

		// Token: 0x04010267 RID: 66151
		internal static int __PropertyOffset_33;

		// Token: 0x04010268 RID: 66152
		internal static int __PropertyOffset_34;

		// Token: 0x04010269 RID: 66153
		internal static int __PropertyOffset_35;

		// Token: 0x0401026A RID: 66154
		internal static int __PropertyOffset_36;

		// Token: 0x0401026B RID: 66155
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x0401026C RID: 66156
		private static IntPtr __DEBUGPlane_NativeFunctionPtr;

		// Token: 0x0401026D RID: 66157
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401026E RID: 66158
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401026F RID: 66159
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C77 RID: 40055
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031335 RID: 201525
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
