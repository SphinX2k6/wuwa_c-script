using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight
{
	// Token: 0x02004041 RID: 16449
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor.BP_VolumetricConeLightShaft_InMotor_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InMotor_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A36E RID: 172910 RVA: 0x009D9748 File Offset: 0x009D7948
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InMotor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor.BP_VolumetricConeLightShaft_InMotor_C");
			}
			return BP_VolumetricConeLightShaft_InMotor_C._ClassPtr;
		}

		// Token: 0x0602A36F RID: 172911 RVA: 0x009D976C File Offset: 0x009D796C
		public BP_VolumetricConeLightShaft_InMotor_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A370 RID: 172912 RVA: 0x009D9794 File Offset: 0x009D7994
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InMotor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006738 RID: 26424
		// (get) Token: 0x0602A371 RID: 172913 RVA: 0x009D97C7 File Offset: 0x009D79C7
		// (set) Token: 0x0602A372 RID: 172914 RVA: 0x009D97DB File Offset: 0x009D79DB
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006739 RID: 26425
		// (get) Token: 0x0602A373 RID: 172915 RVA: 0x009D97F0 File Offset: 0x009D79F0
		// (set) Token: 0x0602A374 RID: 172916 RVA: 0x009D9804 File Offset: 0x009D7A04
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700673A RID: 26426
		// (get) Token: 0x0602A375 RID: 172917 RVA: 0x009D9819 File Offset: 0x009D7A19
		// (set) Token: 0x0602A376 RID: 172918 RVA: 0x009D982D File Offset: 0x009D7A2D
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700673B RID: 26427
		// (get) Token: 0x0602A377 RID: 172919 RVA: 0x009D9842 File Offset: 0x009D7A42
		// (set) Token: 0x0602A378 RID: 172920 RVA: 0x009D9856 File Offset: 0x009D7A56
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x0602A379 RID: 172921 RVA: 0x009D986B File Offset: 0x009D7A6B
		// (set) Token: 0x0602A37A RID: 172922 RVA: 0x009D987F File Offset: 0x009D7A7F
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x0602A37B RID: 172923 RVA: 0x009D9894 File Offset: 0x009D7A94
		// (set) Token: 0x0602A37C RID: 172924 RVA: 0x009D98A8 File Offset: 0x009D7AA8
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700673E RID: 26430
		// (get) Token: 0x0602A37D RID: 172925 RVA: 0x009D98BD File Offset: 0x009D7ABD
		// (set) Token: 0x0602A37E RID: 172926 RVA: 0x009D98CD File Offset: 0x009D7ACD
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700673F RID: 26431
		// (get) Token: 0x0602A37F RID: 172927 RVA: 0x009D98DE File Offset: 0x009D7ADE
		// (set) Token: 0x0602A380 RID: 172928 RVA: 0x009D98EE File Offset: 0x009D7AEE
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006740 RID: 26432
		// (get) Token: 0x0602A381 RID: 172929 RVA: 0x009D98FF File Offset: 0x009D7AFF
		// (set) Token: 0x0602A382 RID: 172930 RVA: 0x009D990F File Offset: 0x009D7B0F
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006741 RID: 26433
		// (get) Token: 0x0602A383 RID: 172931 RVA: 0x009D9920 File Offset: 0x009D7B20
		// (set) Token: 0x0602A384 RID: 172932 RVA: 0x009D9930 File Offset: 0x009D7B30
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006742 RID: 26434
		// (get) Token: 0x0602A385 RID: 172933 RVA: 0x009D9941 File Offset: 0x009D7B41
		// (set) Token: 0x0602A386 RID: 172934 RVA: 0x009D9951 File Offset: 0x009D7B51
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006743 RID: 26435
		// (get) Token: 0x0602A387 RID: 172935 RVA: 0x009D9962 File Offset: 0x009D7B62
		// (set) Token: 0x0602A388 RID: 172936 RVA: 0x009D9972 File Offset: 0x009D7B72
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006744 RID: 26436
		// (get) Token: 0x0602A389 RID: 172937 RVA: 0x009D9983 File Offset: 0x009D7B83
		// (set) Token: 0x0602A38A RID: 172938 RVA: 0x009D9993 File Offset: 0x009D7B93
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006745 RID: 26437
		// (get) Token: 0x0602A38B RID: 172939 RVA: 0x009D99A4 File Offset: 0x009D7BA4
		// (set) Token: 0x0602A38C RID: 172940 RVA: 0x009D99B8 File Offset: 0x009D7BB8
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006746 RID: 26438
		// (get) Token: 0x0602A38D RID: 172941 RVA: 0x009D99CD File Offset: 0x009D7BCD
		// (set) Token: 0x0602A38E RID: 172942 RVA: 0x009D99E1 File Offset: 0x009D7BE1
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x0602A38F RID: 172943 RVA: 0x009D99F6 File Offset: 0x009D7BF6
		// (set) Token: 0x0602A390 RID: 172944 RVA: 0x009D9A06 File Offset: 0x009D7C06
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x0602A391 RID: 172945 RVA: 0x009D9A17 File Offset: 0x009D7C17
		// (set) Token: 0x0602A392 RID: 172946 RVA: 0x009D9A27 File Offset: 0x009D7C27
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006749 RID: 26441
		// (get) Token: 0x0602A393 RID: 172947 RVA: 0x009D9A38 File Offset: 0x009D7C38
		// (set) Token: 0x0602A394 RID: 172948 RVA: 0x009D9A48 File Offset: 0x009D7C48
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700674A RID: 26442
		// (get) Token: 0x0602A395 RID: 172949 RVA: 0x009D9A59 File Offset: 0x009D7C59
		// (set) Token: 0x0602A396 RID: 172950 RVA: 0x009D9A69 File Offset: 0x009D7C69
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700674B RID: 26443
		// (get) Token: 0x0602A397 RID: 172951 RVA: 0x009D9A7A File Offset: 0x009D7C7A
		// (set) Token: 0x0602A398 RID: 172952 RVA: 0x009D9A8A File Offset: 0x009D7C8A
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700674C RID: 26444
		// (get) Token: 0x0602A399 RID: 172953 RVA: 0x009D9A9B File Offset: 0x009D7C9B
		// (set) Token: 0x0602A39A RID: 172954 RVA: 0x009D9AAB File Offset: 0x009D7CAB
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700674D RID: 26445
		// (get) Token: 0x0602A39B RID: 172955 RVA: 0x009D9ABC File Offset: 0x009D7CBC
		// (set) Token: 0x0602A39C RID: 172956 RVA: 0x009D9AD0 File Offset: 0x009D7CD0
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700674E RID: 26446
		// (get) Token: 0x0602A39D RID: 172957 RVA: 0x009D9AE5 File Offset: 0x009D7CE5
		// (set) Token: 0x0602A39E RID: 172958 RVA: 0x009D9AF9 File Offset: 0x009D7CF9
		public unsafe UStaticMesh LightShaftStaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700674F RID: 26447
		// (get) Token: 0x0602A39F RID: 172959 RVA: 0x009D9B0E File Offset: 0x009D7D0E
		// (set) Token: 0x0602A3A0 RID: 172960 RVA: 0x009D9B22 File Offset: 0x009D7D22
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17006750 RID: 26448
		// (get) Token: 0x0602A3A1 RID: 172961 RVA: 0x009D9B37 File Offset: 0x009D7D37
		// (set) Token: 0x0602A3A2 RID: 172962 RVA: 0x009D9B4B File Offset: 0x009D7D4B
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17006751 RID: 26449
		// (get) Token: 0x0602A3A3 RID: 172963 RVA: 0x009D9B60 File Offset: 0x009D7D60
		// (set) Token: 0x0602A3A4 RID: 172964 RVA: 0x009D9B74 File Offset: 0x009D7D74
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006752 RID: 26450
		// (get) Token: 0x0602A3A5 RID: 172965 RVA: 0x009D9B89 File Offset: 0x009D7D89
		// (set) Token: 0x0602A3A6 RID: 172966 RVA: 0x009D9B99 File Offset: 0x009D7D99
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x0602A3A7 RID: 172967 RVA: 0x009D9BAA File Offset: 0x009D7DAA
		// (set) Token: 0x0602A3A8 RID: 172968 RVA: 0x009D9BBA File Offset: 0x009D7DBA
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x0602A3A9 RID: 172969 RVA: 0x009D9BCB File Offset: 0x009D7DCB
		// (set) Token: 0x0602A3AA RID: 172970 RVA: 0x009D9BDB File Offset: 0x009D7DDB
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x0602A3AB RID: 172971 RVA: 0x009D9BEC File Offset: 0x009D7DEC
		// (set) Token: 0x0602A3AC RID: 172972 RVA: 0x009D9BFC File Offset: 0x009D7DFC
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x0602A3AD RID: 172973 RVA: 0x009D9C0D File Offset: 0x009D7E0D
		// (set) Token: 0x0602A3AE RID: 172974 RVA: 0x009D9C1D File Offset: 0x009D7E1D
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006757 RID: 26455
		// (get) Token: 0x0602A3AF RID: 172975 RVA: 0x009D9C2E File Offset: 0x009D7E2E
		// (set) Token: 0x0602A3B0 RID: 172976 RVA: 0x009D9C42 File Offset: 0x009D7E42
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006758 RID: 26456
		// (get) Token: 0x0602A3B1 RID: 172977 RVA: 0x009D9C57 File Offset: 0x009D7E57
		// (set) Token: 0x0602A3B2 RID: 172978 RVA: 0x009D9C6B File Offset: 0x009D7E6B
		public unsafe UStaticMesh LightMaskStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17006759 RID: 26457
		// (get) Token: 0x0602A3B3 RID: 172979 RVA: 0x009D9C80 File Offset: 0x009D7E80
		// (set) Token: 0x0602A3B4 RID: 172980 RVA: 0x009D9C90 File Offset: 0x009D7E90
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700675A RID: 26458
		// (get) Token: 0x0602A3B5 RID: 172981 RVA: 0x009D9CA1 File Offset: 0x009D7EA1
		// (set) Token: 0x0602A3B6 RID: 172982 RVA: 0x009D9CB5 File Offset: 0x009D7EB5
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x0602A3B7 RID: 172983 RVA: 0x009D9CCA File Offset: 0x009D7ECA
		// (set) Token: 0x0602A3B8 RID: 172984 RVA: 0x009D9CDE File Offset: 0x009D7EDE
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x0602A3B9 RID: 172985 RVA: 0x009D9CF3 File Offset: 0x009D7EF3
		// (set) Token: 0x0602A3BA RID: 172986 RVA: 0x009D9D07 File Offset: 0x009D7F07
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x0602A3BB RID: 172987 RVA: 0x009D9D1C File Offset: 0x009D7F1C
		// (set) Token: 0x0602A3BC RID: 172988 RVA: 0x009D9D30 File Offset: 0x009D7F30
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x0602A3BD RID: 172989 RVA: 0x009D9D45 File Offset: 0x009D7F45
		// (set) Token: 0x0602A3BE RID: 172990 RVA: 0x009D9D55 File Offset: 0x009D7F55
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x1700675F RID: 26463
		// (get) Token: 0x0602A3BF RID: 172991 RVA: 0x009D9D66 File Offset: 0x009D7F66
		// (set) Token: 0x0602A3C0 RID: 172992 RVA: 0x009D9D76 File Offset: 0x009D7F76
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006760 RID: 26464
		// (get) Token: 0x0602A3C1 RID: 172993 RVA: 0x009D9D87 File Offset: 0x009D7F87
		// (set) Token: 0x0602A3C2 RID: 172994 RVA: 0x009D9D97 File Offset: 0x009D7F97
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006761 RID: 26465
		// (get) Token: 0x0602A3C3 RID: 172995 RVA: 0x009D9DA8 File Offset: 0x009D7FA8
		// (set) Token: 0x0602A3C4 RID: 172996 RVA: 0x009D9DB8 File Offset: 0x009D7FB8
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17006762 RID: 26466
		// (get) Token: 0x0602A3C5 RID: 172997 RVA: 0x009D9DC9 File Offset: 0x009D7FC9
		// (set) Token: 0x0602A3C6 RID: 172998 RVA: 0x009D9DD9 File Offset: 0x009D7FD9
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17006763 RID: 26467
		// (get) Token: 0x0602A3C7 RID: 172999 RVA: 0x009D9DEA File Offset: 0x009D7FEA
		// (set) Token: 0x0602A3C8 RID: 173000 RVA: 0x009D9DFA File Offset: 0x009D7FFA
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17006764 RID: 26468
		// (get) Token: 0x0602A3C9 RID: 173001 RVA: 0x009D9E0B File Offset: 0x009D800B
		// (set) Token: 0x0602A3CA RID: 173002 RVA: 0x009D9E1F File Offset: 0x009D801F
		public unsafe FVector CenterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17006765 RID: 26469
		// (get) Token: 0x0602A3CB RID: 173003 RVA: 0x009D9E34 File Offset: 0x009D8034
		// (set) Token: 0x0602A3CC RID: 173004 RVA: 0x009D9E48 File Offset: 0x009D8048
		public unsafe UTexture MainNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_46);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_46, value);
			}
		}

		// Token: 0x17006766 RID: 26470
		// (get) Token: 0x0602A3CD RID: 173005 RVA: 0x009D9E5D File Offset: 0x009D805D
		// (set) Token: 0x0602A3CE RID: 173006 RVA: 0x009D9E71 File Offset: 0x009D8071
		public unsafe UTexture SecondNoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17006767 RID: 26471
		// (get) Token: 0x0602A3CF RID: 173007 RVA: 0x009D9E86 File Offset: 0x009D8086
		// (set) Token: 0x0602A3D0 RID: 173008 RVA: 0x009D9E9A File Offset: 0x009D809A
		public unsafe FLinearColor MainNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17006768 RID: 26472
		// (get) Token: 0x0602A3D1 RID: 173009 RVA: 0x009D9EAF File Offset: 0x009D80AF
		// (set) Token: 0x0602A3D2 RID: 173010 RVA: 0x009D9EC3 File Offset: 0x009D80C3
		public unsafe FLinearColor SecondNoiseTexUVControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17006769 RID: 26473
		// (get) Token: 0x0602A3D3 RID: 173011 RVA: 0x009D9ED8 File Offset: 0x009D80D8
		// (set) Token: 0x0602A3D4 RID: 173012 RVA: 0x009D9EE8 File Offset: 0x009D80E8
		public unsafe float MainUVAddStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x1700676A RID: 26474
		// (get) Token: 0x0602A3D5 RID: 173013 RVA: 0x009D9EF9 File Offset: 0x009D80F9
		// (set) Token: 0x0602A3D6 RID: 173014 RVA: 0x009D9F0D File Offset: 0x009D810D
		public unsafe FLinearColor MainNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x1700676B RID: 26475
		// (get) Token: 0x0602A3D7 RID: 173015 RVA: 0x009D9F22 File Offset: 0x009D8122
		// (set) Token: 0x0602A3D8 RID: 173016 RVA: 0x009D9F36 File Offset: 0x009D8136
		public unsafe FLinearColor SecondNoiseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x1700676C RID: 26476
		// (get) Token: 0x0602A3D9 RID: 173017 RVA: 0x009D9F4C File Offset: 0x009D814C
		// (set) Token: 0x0602A3DA RID: 173018 RVA: 0x009D9F85 File Offset: 0x009D8185
		[Nullable(1)]
		public TMap<FName, float> MaterialInstanceB_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstanceB_Scalars) == null)
				{
					result = (this._MaterialInstanceB_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x1700676D RID: 26477
		// (get) Token: 0x0602A3DB RID: 173019 RVA: 0x009D9F94 File Offset: 0x009D8194
		// (set) Token: 0x0602A3DC RID: 173020 RVA: 0x009D9FCD File Offset: 0x009D81CD
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstanceB_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstanceB_Vectors) == null)
				{
					result = (this._MaterialInstanceB_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_54, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x1700676E RID: 26478
		// (get) Token: 0x0602A3DD RID: 173021 RVA: 0x009D9FDC File Offset: 0x009D81DC
		// (set) Token: 0x0602A3DE RID: 173022 RVA: 0x009DA015 File Offset: 0x009D8215
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstanceB_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstanceB_Textures) == null)
				{
					result = (this._MaterialInstanceB_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_55, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceB_Textures.CopyAssign(value);
			}
		}

		// Token: 0x1700676F RID: 26479
		// (get) Token: 0x0602A3DF RID: 173023 RVA: 0x009DA024 File Offset: 0x009D8224
		// (set) Token: 0x0602A3E0 RID: 173024 RVA: 0x009DA05D File Offset: 0x009D825D
		[Nullable(1)]
		public TMap<FName, float> MaterialInstance_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialInstance_Scalars) == null)
				{
					result = (this._MaterialInstance_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_56, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17006770 RID: 26480
		// (get) Token: 0x0602A3E1 RID: 173025 RVA: 0x009DA06C File Offset: 0x009D826C
		// (set) Token: 0x0602A3E2 RID: 173026 RVA: 0x009DA0A5 File Offset: 0x009D82A5
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialInstance_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialInstance_Vectors) == null)
				{
					result = (this._MaterialInstance_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_57, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x0602A3E3 RID: 173027 RVA: 0x009DA0B4 File Offset: 0x009D82B4
		// (set) Token: 0x0602A3E4 RID: 173028 RVA: 0x009DA0ED File Offset: 0x009D82ED
		[Nullable(1)]
		public TMap<FName, UTexture> MaterialInstance_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._MaterialInstance_Textures) == null)
				{
					result = (this._MaterialInstance_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_58, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstance_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17006772 RID: 26482
		// (get) Token: 0x0602A3E5 RID: 173029 RVA: 0x009DA0FC File Offset: 0x009D82FC
		// (set) Token: 0x0602A3E6 RID: 173030 RVA: 0x009DA135 File Offset: 0x009D8335
		[Nullable(1)]
		public TMap<FName, float> LightShaftCone_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightShaftCone_Scalars) == null)
				{
					result = (this._LightShaftCone_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x0602A3E7 RID: 173031 RVA: 0x009DA144 File Offset: 0x009D8344
		// (set) Token: 0x0602A3E8 RID: 173032 RVA: 0x009DA17D File Offset: 0x009D837D
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightShaftCone_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightShaftCone_Vectors) == null)
				{
					result = (this._LightShaftCone_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_60, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x0602A3E9 RID: 173033 RVA: 0x009DA18C File Offset: 0x009D838C
		// (set) Token: 0x0602A3EA RID: 173034 RVA: 0x009DA1C5 File Offset: 0x009D83C5
		[Nullable(1)]
		public TMap<FName, UTexture> LightShaftCone_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightShaftCone_Textures) == null)
				{
					result = (this._LightShaftCone_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_61, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightShaftCone_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x0602A3EB RID: 173035 RVA: 0x009DA1D4 File Offset: 0x009D83D4
		// (set) Token: 0x0602A3EC RID: 173036 RVA: 0x009DA20D File Offset: 0x009D840D
		[Nullable(1)]
		public TMap<FName, float> LightMaskMaterial_Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._LightMaskMaterial_Scalars) == null)
				{
					result = (this._LightMaskMaterial_Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_62, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17006776 RID: 26486
		// (get) Token: 0x0602A3ED RID: 173037 RVA: 0x009DA21C File Offset: 0x009D841C
		// (set) Token: 0x0602A3EE RID: 173038 RVA: 0x009DA255 File Offset: 0x009D8455
		[Nullable(1)]
		public TMap<FName, FLinearColor> LightMaskMaterial_Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LightMaskMaterial_Vectors) == null)
				{
					result = (this._LightMaskMaterial_Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_63, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Vectors.CopyAssign(value);
			}
		}

		// Token: 0x17006777 RID: 26487
		// (get) Token: 0x0602A3EF RID: 173039 RVA: 0x009DA264 File Offset: 0x009D8464
		// (set) Token: 0x0602A3F0 RID: 173040 RVA: 0x009DA29D File Offset: 0x009D849D
		[Nullable(1)]
		public TMap<FName, UTexture> LightMaskMaterial_Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._LightMaskMaterial_Textures) == null)
				{
					result = (this._LightMaskMaterial_Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_64, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightMaskMaterial_Textures.CopyAssign(value);
			}
		}

		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x0602A3F1 RID: 173041 RVA: 0x009DA2AB File Offset: 0x009D84AB
		// (set) Token: 0x0602A3F2 RID: 173042 RVA: 0x009DA2BF File Offset: 0x009D84BF
		public unsafe UMaterialInstanceDynamic MaterialInstanceBDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x0602A3F3 RID: 173043 RVA: 0x009DA2D4 File Offset: 0x009D84D4
		// (set) Token: 0x0602A3F4 RID: 173044 RVA: 0x009DA2E8 File Offset: 0x009D84E8
		public unsafe UMaterialInstanceDynamic MaterialInstanceDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_66);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_66, value);
			}
		}

		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x0602A3F5 RID: 173045 RVA: 0x009DA2FD File Offset: 0x009D84FD
		// (set) Token: 0x0602A3F6 RID: 173046 RVA: 0x009DA311 File Offset: 0x009D8511
		public unsafe UMaterialInstanceDynamic LightShaftConeDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_67);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_67, value);
			}
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x0602A3F7 RID: 173047 RVA: 0x009DA326 File Offset: 0x009D8526
		// (set) Token: 0x0602A3F8 RID: 173048 RVA: 0x009DA33A File Offset: 0x009D853A
		public unsafe UMaterialInstanceDynamic LightMaskMaterialDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x0602A3F9 RID: 173049 RVA: 0x009DA34F File Offset: 0x009D854F
		// (set) Token: 0x0602A3FA RID: 173050 RVA: 0x009DA35F File Offset: 0x009D855F
		public unsafe bool IsTickUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x0602A3FB RID: 173051 RVA: 0x009DA370 File Offset: 0x009D8570
		// (set) Token: 0x0602A3FC RID: 173052 RVA: 0x009DA380 File Offset: 0x009D8580
		public unsafe bool OptimizeForMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x0602A3FD RID: 173053 RVA: 0x009DA391 File Offset: 0x009D8591
		// (set) Token: 0x0602A3FE RID: 173054 RVA: 0x009DA3A5 File Offset: 0x009D85A5
		public unsafe UStaticMeshComponent VolumetricCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_71);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_C.__PropertyOffset_71, value);
			}
		}

		// Token: 0x0602A3FF RID: 173055 RVA: 0x009DA3BA File Offset: 0x009D85BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x0602A400 RID: 173056 RVA: 0x009DA3CE File Offset: 0x009D85CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602A401 RID: 173057 RVA: 0x009DA3E2 File Offset: 0x009D85E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A402 RID: 173058 RVA: 0x009DA3F7 File Offset: 0x009D85F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A403 RID: 173059 RVA: 0x009DA40B File Offset: 0x009D860B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A404 RID: 173060 RVA: 0x009DA420 File Offset: 0x009D8620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A405 RID: 173061 RVA: 0x009DA468 File Offset: 0x009D8668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A406 RID: 173062 RVA: 0x009DA4B0 File Offset: 0x009D86B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A407 RID: 173063 RVA: 0x009DA4F8 File Offset: 0x009D86F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A408 RID: 173064 RVA: 0x009DA53F File Offset: 0x009D873F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnGameUserSettingsChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__OnGameUserSettingsChange_NativeFunctionPtr, null);
		}

		// Token: 0x0602A409 RID: 173065 RVA: 0x009DA554 File Offset: 0x009D8754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A40A RID: 173066 RVA: 0x009DA5A0 File Offset: 0x009D87A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_InMotor_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A40B RID: 173067 RVA: 0x009DA5EC File Offset: 0x009D87EC
		protected BP_VolumetricConeLightShaft_InMotor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C3D RID: 89149
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor.BP_VolumetricConeLightShaft_InMotor_C";

		// Token: 0x04015C3E RID: 89150
		private static IntPtr _ClassPtr;

		// Token: 0x04015C3F RID: 89151
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C40 RID: 89152
		internal static int __PropertyOffset_1;

		// Token: 0x04015C41 RID: 89153
		internal static int __PropertyOffset_2;

		// Token: 0x04015C42 RID: 89154
		internal static int __PropertyOffset_3;

		// Token: 0x04015C43 RID: 89155
		internal static int __PropertyOffset_4;

		// Token: 0x04015C44 RID: 89156
		internal static int __PropertyOffset_5;

		// Token: 0x04015C45 RID: 89157
		internal static int __PropertyOffset_6;

		// Token: 0x04015C46 RID: 89158
		internal static int __PropertyOffset_7;

		// Token: 0x04015C47 RID: 89159
		internal static int __PropertyOffset_8;

		// Token: 0x04015C48 RID: 89160
		internal static int __PropertyOffset_9;

		// Token: 0x04015C49 RID: 89161
		internal static int __PropertyOffset_10;

		// Token: 0x04015C4A RID: 89162
		internal static int __PropertyOffset_11;

		// Token: 0x04015C4B RID: 89163
		internal static int __PropertyOffset_12;

		// Token: 0x04015C4C RID: 89164
		internal static int __PropertyOffset_13;

		// Token: 0x04015C4D RID: 89165
		internal static int __PropertyOffset_14;

		// Token: 0x04015C4E RID: 89166
		internal static int __PropertyOffset_15;

		// Token: 0x04015C4F RID: 89167
		internal static int __PropertyOffset_16;

		// Token: 0x04015C50 RID: 89168
		internal static int __PropertyOffset_17;

		// Token: 0x04015C51 RID: 89169
		internal static int __PropertyOffset_18;

		// Token: 0x04015C52 RID: 89170
		internal static int __PropertyOffset_19;

		// Token: 0x04015C53 RID: 89171
		internal static int __PropertyOffset_20;

		// Token: 0x04015C54 RID: 89172
		internal static int __PropertyOffset_21;

		// Token: 0x04015C55 RID: 89173
		internal static int __PropertyOffset_22;

		// Token: 0x04015C56 RID: 89174
		internal static int __PropertyOffset_23;

		// Token: 0x04015C57 RID: 89175
		internal static int __PropertyOffset_24;

		// Token: 0x04015C58 RID: 89176
		internal static int __PropertyOffset_25;

		// Token: 0x04015C59 RID: 89177
		internal static int __PropertyOffset_26;

		// Token: 0x04015C5A RID: 89178
		internal static int __PropertyOffset_27;

		// Token: 0x04015C5B RID: 89179
		internal static int __PropertyOffset_28;

		// Token: 0x04015C5C RID: 89180
		internal static int __PropertyOffset_29;

		// Token: 0x04015C5D RID: 89181
		internal static int __PropertyOffset_30;

		// Token: 0x04015C5E RID: 89182
		internal static int __PropertyOffset_31;

		// Token: 0x04015C5F RID: 89183
		internal static int __PropertyOffset_32;

		// Token: 0x04015C60 RID: 89184
		internal static int __PropertyOffset_33;

		// Token: 0x04015C61 RID: 89185
		internal static int __PropertyOffset_34;

		// Token: 0x04015C62 RID: 89186
		internal static int __PropertyOffset_35;

		// Token: 0x04015C63 RID: 89187
		internal static int __PropertyOffset_36;

		// Token: 0x04015C64 RID: 89188
		internal static int __PropertyOffset_37;

		// Token: 0x04015C65 RID: 89189
		internal static int __PropertyOffset_38;

		// Token: 0x04015C66 RID: 89190
		internal static int __PropertyOffset_39;

		// Token: 0x04015C67 RID: 89191
		internal static int __PropertyOffset_40;

		// Token: 0x04015C68 RID: 89192
		internal static int __PropertyOffset_41;

		// Token: 0x04015C69 RID: 89193
		internal static int __PropertyOffset_42;

		// Token: 0x04015C6A RID: 89194
		internal static int __PropertyOffset_43;

		// Token: 0x04015C6B RID: 89195
		internal static int __PropertyOffset_44;

		// Token: 0x04015C6C RID: 89196
		internal static int __PropertyOffset_45;

		// Token: 0x04015C6D RID: 89197
		internal static int __PropertyOffset_46;

		// Token: 0x04015C6E RID: 89198
		internal static int __PropertyOffset_47;

		// Token: 0x04015C6F RID: 89199
		internal static int __PropertyOffset_48;

		// Token: 0x04015C70 RID: 89200
		internal static int __PropertyOffset_49;

		// Token: 0x04015C71 RID: 89201
		internal static int __PropertyOffset_50;

		// Token: 0x04015C72 RID: 89202
		internal static int __PropertyOffset_51;

		// Token: 0x04015C73 RID: 89203
		internal static int __PropertyOffset_52;

		// Token: 0x04015C74 RID: 89204
		internal static int __PropertyOffset_53;

		// Token: 0x04015C75 RID: 89205
		private TMap<FName, float> _MaterialInstanceB_Scalars;

		// Token: 0x04015C76 RID: 89206
		internal static int __PropertyOffset_54;

		// Token: 0x04015C77 RID: 89207
		private TMap<FName, FLinearColor> _MaterialInstanceB_Vectors;

		// Token: 0x04015C78 RID: 89208
		internal static int __PropertyOffset_55;

		// Token: 0x04015C79 RID: 89209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstanceB_Textures;

		// Token: 0x04015C7A RID: 89210
		internal static int __PropertyOffset_56;

		// Token: 0x04015C7B RID: 89211
		private TMap<FName, float> _MaterialInstance_Scalars;

		// Token: 0x04015C7C RID: 89212
		internal static int __PropertyOffset_57;

		// Token: 0x04015C7D RID: 89213
		private TMap<FName, FLinearColor> _MaterialInstance_Vectors;

		// Token: 0x04015C7E RID: 89214
		internal static int __PropertyOffset_58;

		// Token: 0x04015C7F RID: 89215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _MaterialInstance_Textures;

		// Token: 0x04015C80 RID: 89216
		internal static int __PropertyOffset_59;

		// Token: 0x04015C81 RID: 89217
		private TMap<FName, float> _LightShaftCone_Scalars;

		// Token: 0x04015C82 RID: 89218
		internal static int __PropertyOffset_60;

		// Token: 0x04015C83 RID: 89219
		private TMap<FName, FLinearColor> _LightShaftCone_Vectors;

		// Token: 0x04015C84 RID: 89220
		internal static int __PropertyOffset_61;

		// Token: 0x04015C85 RID: 89221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightShaftCone_Textures;

		// Token: 0x04015C86 RID: 89222
		internal static int __PropertyOffset_62;

		// Token: 0x04015C87 RID: 89223
		private TMap<FName, float> _LightMaskMaterial_Scalars;

		// Token: 0x04015C88 RID: 89224
		internal static int __PropertyOffset_63;

		// Token: 0x04015C89 RID: 89225
		private TMap<FName, FLinearColor> _LightMaskMaterial_Vectors;

		// Token: 0x04015C8A RID: 89226
		internal static int __PropertyOffset_64;

		// Token: 0x04015C8B RID: 89227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _LightMaskMaterial_Textures;

		// Token: 0x04015C8C RID: 89228
		internal static int __PropertyOffset_65;

		// Token: 0x04015C8D RID: 89229
		internal static int __PropertyOffset_66;

		// Token: 0x04015C8E RID: 89230
		internal static int __PropertyOffset_67;

		// Token: 0x04015C8F RID: 89231
		internal static int __PropertyOffset_68;

		// Token: 0x04015C90 RID: 89232
		internal static int __PropertyOffset_69;

		// Token: 0x04015C91 RID: 89233
		internal static int __PropertyOffset_70;

		// Token: 0x04015C92 RID: 89234
		internal static int __PropertyOffset_71;

		// Token: 0x04015C93 RID: 89235
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04015C94 RID: 89236
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04015C95 RID: 89237
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04015C96 RID: 89238
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015C97 RID: 89239
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04015C98 RID: 89240
		private static IntPtr __OnGameUserSettingsChange_NativeFunctionPtr;

		// Token: 0x04015C99 RID: 89241
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A34F RID: 41807
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032117 RID: 205079
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A350 RID: 41808
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04032118 RID: 205080
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A351 RID: 41809
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04032119 RID: 205081
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
