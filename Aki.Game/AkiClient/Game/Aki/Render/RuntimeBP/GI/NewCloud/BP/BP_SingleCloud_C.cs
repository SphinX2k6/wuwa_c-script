using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5F RID: 15711
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud.BP_SingleCloud_C")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class BP_SingleCloud_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026743 RID: 157507 RVA: 0x00975920 File Offset: 0x00973B20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SingleCloud_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud.BP_SingleCloud_C");
			}
			return BP_SingleCloud_C._ClassPtr;
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x00975944 File Offset: 0x00973B44
		public BP_SingleCloud_C() : this(BuiltinUtils.AllocNativeUObject(BP_SingleCloud_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026745 RID: 157509 RVA: 0x0097596C File Offset: 0x00973B6C
		[NullableContext(1)]
		public BP_SingleCloud_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SingleCloud_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x06026746 RID: 157510 RVA: 0x0097599F File Offset: 0x00973B9F
		// (set) Token: 0x06026747 RID: 157511 RVA: 0x009759B3 File Offset: 0x00973BB3
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x06026748 RID: 157512 RVA: 0x009759C8 File Offset: 0x00973BC8
		// (set) Token: 0x06026749 RID: 157513 RVA: 0x009759DC File Offset: 0x00973BDC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x0602674A RID: 157514 RVA: 0x009759F1 File Offset: 0x00973BF1
		// (set) Token: 0x0602674B RID: 157515 RVA: 0x00975A05 File Offset: 0x00973C05
		public unsafe UTexture2D CloudMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x0602674C RID: 157516 RVA: 0x00975A1A File Offset: 0x00973C1A
		// (set) Token: 0x0602674D RID: 157517 RVA: 0x00975A2A File Offset: 0x00973C2A
		public unsafe float CloudHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x0602674E RID: 157518 RVA: 0x00975A3B File Offset: 0x00973C3B
		// (set) Token: 0x0602674F RID: 157519 RVA: 0x00975A4F File Offset: 0x00973C4F
		public unsafe UMaterialInstanceConstant MaterialNoRotate_CustomLighting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x06026750 RID: 157520 RVA: 0x00975A64 File Offset: 0x00973C64
		// (set) Token: 0x06026751 RID: 157521 RVA: 0x00975A78 File Offset: 0x00973C78
		public unsafe UMaterialInstanceConstant MaterialNoRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x06026752 RID: 157522 RVA: 0x00975A8D File Offset: 0x00973C8D
		// (set) Token: 0x06026753 RID: 157523 RVA: 0x00975A9D File Offset: 0x00973C9D
		public unsafe bool bTowardCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x06026754 RID: 157524 RVA: 0x00975AAE File Offset: 0x00973CAE
		// (set) Token: 0x06026755 RID: 157525 RVA: 0x00975ABE File Offset: 0x00973CBE
		public unsafe float FadeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x06026756 RID: 157526 RVA: 0x00975ACF File Offset: 0x00973CCF
		// (set) Token: 0x06026757 RID: 157527 RVA: 0x00975ADF File Offset: 0x00973CDF
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x06026758 RID: 157528 RVA: 0x00975AF0 File Offset: 0x00973CF0
		// (set) Token: 0x06026759 RID: 157529 RVA: 0x00975B00 File Offset: 0x00973D00
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x0602675A RID: 157530 RVA: 0x00975B11 File Offset: 0x00973D11
		// (set) Token: 0x0602675B RID: 157531 RVA: 0x00975B25 File Offset: 0x00973D25
		public unsafe UStaticMesh CustomMesh_Y_Aix
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x0602675C RID: 157532 RVA: 0x00975B3A File Offset: 0x00973D3A
		// (set) Token: 0x0602675D RID: 157533 RVA: 0x00975B4A File Offset: 0x00973D4A
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x0602675E RID: 157534 RVA: 0x00975B5B File Offset: 0x00973D5B
		// (set) Token: 0x0602675F RID: 157535 RVA: 0x00975B6B File Offset: 0x00973D6B
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x06026760 RID: 157536 RVA: 0x00975B7C File Offset: 0x00973D7C
		// (set) Token: 0x06026761 RID: 157537 RVA: 0x00975B8C File Offset: 0x00973D8C
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x06026762 RID: 157538 RVA: 0x00975B9D File Offset: 0x00973D9D
		// (set) Token: 0x06026763 RID: 157539 RVA: 0x00975BAD File Offset: 0x00973DAD
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x06026764 RID: 157540 RVA: 0x00975BBE File Offset: 0x00973DBE
		// (set) Token: 0x06026765 RID: 157541 RVA: 0x00975BD2 File Offset: 0x00973DD2
		public unsafe UMaterialInstanceConstant MaterialNoRotateFog_CustomLighting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x06026766 RID: 157542 RVA: 0x00975BE7 File Offset: 0x00973DE7
		// (set) Token: 0x06026767 RID: 157543 RVA: 0x00975BFB File Offset: 0x00973DFB
		public unsafe UMaterialInstanceConstant MaterialNoRotateFog
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x06026768 RID: 157544 RVA: 0x00975C10 File Offset: 0x00973E10
		// (set) Token: 0x06026769 RID: 157545 RVA: 0x00975C20 File Offset: 0x00973E20
		public unsafe bool bWithFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x0602676A RID: 157546 RVA: 0x00975C31 File Offset: 0x00973E31
		// (set) Token: 0x0602676B RID: 157547 RVA: 0x00975C41 File Offset: 0x00973E41
		public unsafe bool bInverseFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x0602676C RID: 157548 RVA: 0x00975C52 File Offset: 0x00973E52
		// (set) Token: 0x0602676D RID: 157549 RVA: 0x00975C62 File Offset: 0x00973E62
		public unsafe bool bEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x0602676E RID: 157550 RVA: 0x00975C73 File Offset: 0x00973E73
		// (set) Token: 0x0602676F RID: 157551 RVA: 0x00975C83 File Offset: 0x00973E83
		public unsafe bool bTowardCameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x06026770 RID: 157552 RVA: 0x00975C94 File Offset: 0x00973E94
		// (set) Token: 0x06026771 RID: 157553 RVA: 0x00975CA8 File Offset: 0x00973EA8
		public unsafe FVector boundCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x06026772 RID: 157554 RVA: 0x00975CBD File Offset: 0x00973EBD
		// (set) Token: 0x06026773 RID: 157555 RVA: 0x00975CD1 File Offset: 0x00973ED1
		public unsafe FVectorDouble CameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x06026774 RID: 157556 RVA: 0x00975CE6 File Offset: 0x00973EE6
		// (set) Token: 0x06026775 RID: 157557 RVA: 0x00975CFA File Offset: 0x00973EFA
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x06026776 RID: 157558 RVA: 0x00975D0F File Offset: 0x00973F0F
		// (set) Token: 0x06026777 RID: 157559 RVA: 0x00975D1F File Offset: 0x00973F1F
		public unsafe double DistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x06026778 RID: 157560 RVA: 0x00975D30 File Offset: 0x00973F30
		// (set) Token: 0x06026779 RID: 157561 RVA: 0x00975D44 File Offset: 0x00973F44
		public unsafe FRotator CloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x0602677A RID: 157562 RVA: 0x00975D59 File Offset: 0x00973F59
		// (set) Token: 0x0602677B RID: 157563 RVA: 0x00975D6D File Offset: 0x00973F6D
		public unsafe FVectorDouble ToBoundDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x0602677C RID: 157564 RVA: 0x00975D82 File Offset: 0x00973F82
		// (set) Token: 0x0602677D RID: 157565 RVA: 0x00975D92 File Offset: 0x00973F92
		public unsafe bool bCustomLighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x0602677E RID: 157566 RVA: 0x00975DA3 File Offset: 0x00973FA3
		// (set) Token: 0x0602677F RID: 157567 RVA: 0x00975DB7 File Offset: 0x00973FB7
		public unsafe FLinearColor BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x06026780 RID: 157568 RVA: 0x00975DCC File Offset: 0x00973FCC
		// (set) Token: 0x06026781 RID: 157569 RVA: 0x00975DE0 File Offset: 0x00973FE0
		public unsafe FLinearColor DarkColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x06026782 RID: 157570 RVA: 0x00975DF5 File Offset: 0x00973FF5
		// (set) Token: 0x06026783 RID: 157571 RVA: 0x00975E09 File Offset: 0x00974009
		public unsafe FLinearColor EmissiveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x06026784 RID: 157572 RVA: 0x00975E1E File Offset: 0x0097401E
		// (set) Token: 0x06026785 RID: 157573 RVA: 0x00975E32 File Offset: 0x00974032
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x06026786 RID: 157574 RVA: 0x00975E47 File Offset: 0x00974047
		// (set) Token: 0x06026787 RID: 157575 RVA: 0x00975E57 File Offset: 0x00974057
		public unsafe float AtmoLightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x06026788 RID: 157576 RVA: 0x00975E68 File Offset: 0x00974068
		// (set) Token: 0x06026789 RID: 157577 RVA: 0x00975E78 File Offset: 0x00974078
		public unsafe float CloudUseFogFarColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x0602678A RID: 157578 RVA: 0x00975E89 File Offset: 0x00974089
		// (set) Token: 0x0602678B RID: 157579 RVA: 0x00975E99 File Offset: 0x00974099
		public unsafe float Exp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x0602678C RID: 157580 RVA: 0x00975EAA File Offset: 0x009740AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudRotation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__UpdateCloudRotation_NativeFunctionPtr, null);
		}

		// Token: 0x0602678D RID: 157581 RVA: 0x00975EBE File Offset: 0x009740BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDistanceFade()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__UpdateDistanceFade_NativeFunctionPtr, null);
		}

		// Token: 0x0602678E RID: 157582 RVA: 0x00975ED2 File Offset: 0x009740D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCameraPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__UpdateCameraPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0602678F RID: 157583 RVA: 0x00975EE8 File Offset: 0x009740E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMaterialParams(UMaterialInstanceDynamic MID)
		{
			BP_SingleCloud_C.__UpdateMaterialParams_FunctionParams* ptr = stackalloc BP_SingleCloud_C.__UpdateMaterialParams_FunctionParams[(UIntPtr)599] + 15L / (long)sizeof(BP_SingleCloud_C.__UpdateMaterialParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_C.__UpdateMaterialParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MID = ((MID != null) ? MID.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__UpdateMaterialParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026790 RID: 157584 RVA: 0x00975F40 File Offset: 0x00974140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026791 RID: 157585 RVA: 0x00975F54 File Offset: 0x00974154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026792 RID: 157586 RVA: 0x00975F6C File Offset: 0x0097416C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SingleCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SingleCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026793 RID: 157587 RVA: 0x00975FB4 File Offset: 0x009741B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SingleCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SingleCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026794 RID: 157588 RVA: 0x00975FFB File Offset: 0x009741FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026795 RID: 157589 RVA: 0x0097600F File Offset: 0x0097420F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026796 RID: 157590 RVA: 0x00976024 File Offset: 0x00974224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SingleCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SingleCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026797 RID: 157591 RVA: 0x0097606C File Offset: 0x0097426C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SingleCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SingleCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026798 RID: 157592 RVA: 0x009760B3 File Offset: 0x009742B3
		protected BP_SingleCloud_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134AE RID: 79022
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud.BP_SingleCloud_C";

		// Token: 0x040134AF RID: 79023
		private static IntPtr _ClassPtr;

		// Token: 0x040134B0 RID: 79024
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134B1 RID: 79025
		internal static int __PropertyOffset_1;

		// Token: 0x040134B2 RID: 79026
		internal static int __PropertyOffset_2;

		// Token: 0x040134B3 RID: 79027
		internal static int __PropertyOffset_3;

		// Token: 0x040134B4 RID: 79028
		internal static int __PropertyOffset_4;

		// Token: 0x040134B5 RID: 79029
		internal static int __PropertyOffset_5;

		// Token: 0x040134B6 RID: 79030
		internal static int __PropertyOffset_6;

		// Token: 0x040134B7 RID: 79031
		internal static int __PropertyOffset_7;

		// Token: 0x040134B8 RID: 79032
		internal static int __PropertyOffset_8;

		// Token: 0x040134B9 RID: 79033
		internal static int __PropertyOffset_9;

		// Token: 0x040134BA RID: 79034
		internal static int __PropertyOffset_10;

		// Token: 0x040134BB RID: 79035
		internal static int __PropertyOffset_11;

		// Token: 0x040134BC RID: 79036
		internal static int __PropertyOffset_12;

		// Token: 0x040134BD RID: 79037
		internal static int __PropertyOffset_13;

		// Token: 0x040134BE RID: 79038
		internal static int __PropertyOffset_14;

		// Token: 0x040134BF RID: 79039
		internal static int __PropertyOffset_15;

		// Token: 0x040134C0 RID: 79040
		internal static int __PropertyOffset_16;

		// Token: 0x040134C1 RID: 79041
		internal static int __PropertyOffset_17;

		// Token: 0x040134C2 RID: 79042
		internal static int __PropertyOffset_18;

		// Token: 0x040134C3 RID: 79043
		internal static int __PropertyOffset_19;

		// Token: 0x040134C4 RID: 79044
		internal static int __PropertyOffset_20;

		// Token: 0x040134C5 RID: 79045
		internal static int __PropertyOffset_21;

		// Token: 0x040134C6 RID: 79046
		internal static int __PropertyOffset_22;

		// Token: 0x040134C7 RID: 79047
		internal static int __PropertyOffset_23;

		// Token: 0x040134C8 RID: 79048
		internal static int __PropertyOffset_24;

		// Token: 0x040134C9 RID: 79049
		internal static int __PropertyOffset_25;

		// Token: 0x040134CA RID: 79050
		internal static int __PropertyOffset_26;

		// Token: 0x040134CB RID: 79051
		internal static int __PropertyOffset_27;

		// Token: 0x040134CC RID: 79052
		internal static int __PropertyOffset_28;

		// Token: 0x040134CD RID: 79053
		internal static int __PropertyOffset_29;

		// Token: 0x040134CE RID: 79054
		internal static int __PropertyOffset_30;

		// Token: 0x040134CF RID: 79055
		internal static int __PropertyOffset_31;

		// Token: 0x040134D0 RID: 79056
		internal static int __PropertyOffset_32;

		// Token: 0x040134D1 RID: 79057
		internal static int __PropertyOffset_33;

		// Token: 0x040134D2 RID: 79058
		internal static int __PropertyOffset_34;

		// Token: 0x040134D3 RID: 79059
		internal static int __PropertyOffset_35;

		// Token: 0x040134D4 RID: 79060
		private static IntPtr __UpdateCloudRotation_NativeFunctionPtr;

		// Token: 0x040134D5 RID: 79061
		private static IntPtr __UpdateDistanceFade_NativeFunctionPtr;

		// Token: 0x040134D6 RID: 79062
		private static IntPtr __UpdateCameraPosition_NativeFunctionPtr;

		// Token: 0x040134D7 RID: 79063
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x040134D8 RID: 79064
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040134D9 RID: 79065
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040134DA RID: 79066
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040134DB RID: 79067
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A117 RID: 41239
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 584)]
		protected ref struct __UpdateMaterialParams_FunctionParams
		{
			// Token: 0x04031C8D RID: 203917
			[FieldOffset(0)]
			public IntPtr MID;
		}

		// Token: 0x0200A118 RID: 41240
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C8E RID: 203918
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A119 RID: 41241
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C8F RID: 203919
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
