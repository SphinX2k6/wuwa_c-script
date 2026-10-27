using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B22 RID: 15138
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft.BP_VolumetricConeLightShaft_C")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1401)]
	public class BP_VolumetricConeLightShaft_C : AActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602140A RID: 136202 RVA: 0x008E83C4 File Offset: 0x008E65C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft.BP_VolumetricConeLightShaft_C");
			}
			return BP_VolumetricConeLightShaft_C._ClassPtr;
		}

		// Token: 0x0602140B RID: 136203 RVA: 0x008E83E8 File Offset: 0x008E65E8
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_VolumetricConeLightShaft_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x0602140C RID: 136204 RVA: 0x008E83F0 File Offset: 0x008E65F0
		public BP_VolumetricConeLightShaft_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602140D RID: 136205 RVA: 0x008E8418 File Offset: 0x008E6618
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0602140E RID: 136206 RVA: 0x008E844B File Offset: 0x008E664B
		// (set) Token: 0x0602140F RID: 136207 RVA: 0x008E845F File Offset: 0x008E665F
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x06021410 RID: 136208 RVA: 0x008E8474 File Offset: 0x008E6674
		// (set) Token: 0x06021411 RID: 136209 RVA: 0x008E8488 File Offset: 0x008E6688
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x06021412 RID: 136210 RVA: 0x008E849D File Offset: 0x008E669D
		// (set) Token: 0x06021413 RID: 136211 RVA: 0x008E84B1 File Offset: 0x008E66B1
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x06021414 RID: 136212 RVA: 0x008E84C6 File Offset: 0x008E66C6
		// (set) Token: 0x06021415 RID: 136213 RVA: 0x008E84DA File Offset: 0x008E66DA
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x06021416 RID: 136214 RVA: 0x008E84EF File Offset: 0x008E66EF
		// (set) Token: 0x06021417 RID: 136215 RVA: 0x008E8503 File Offset: 0x008E6703
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x06021418 RID: 136216 RVA: 0x008E8518 File Offset: 0x008E6718
		// (set) Token: 0x06021419 RID: 136217 RVA: 0x008E852C File Offset: 0x008E672C
		public unsafe UMaterialInstance MaterialInstanceBT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0602141A RID: 136218 RVA: 0x008E8541 File Offset: 0x008E6741
		// (set) Token: 0x0602141B RID: 136219 RVA: 0x008E8555 File Offset: 0x008E6755
		public unsafe UMaterialInstance MaterialInstanceT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0602141C RID: 136220 RVA: 0x008E856A File Offset: 0x008E676A
		// (set) Token: 0x0602141D RID: 136221 RVA: 0x008E857E File Offset: 0x008E677E
		public unsafe FVector VolumetriConeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0602141E RID: 136222 RVA: 0x008E8593 File Offset: 0x008E6793
		// (set) Token: 0x0602141F RID: 136223 RVA: 0x008E85A3 File Offset: 0x008E67A3
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x06021420 RID: 136224 RVA: 0x008E85B4 File Offset: 0x008E67B4
		// (set) Token: 0x06021421 RID: 136225 RVA: 0x008E85C4 File Offset: 0x008E67C4
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x06021422 RID: 136226 RVA: 0x008E85D5 File Offset: 0x008E67D5
		// (set) Token: 0x06021423 RID: 136227 RVA: 0x008E85E5 File Offset: 0x008E67E5
		public unsafe bool EnableFlickent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x06021424 RID: 136228 RVA: 0x008E85F6 File Offset: 0x008E67F6
		// (set) Token: 0x06021425 RID: 136229 RVA: 0x008E8606 File Offset: 0x008E6806
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x06021426 RID: 136230 RVA: 0x008E8617 File Offset: 0x008E6817
		// (set) Token: 0x06021427 RID: 136231 RVA: 0x008E8627 File Offset: 0x008E6827
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x06021428 RID: 136232 RVA: 0x008E8638 File Offset: 0x008E6838
		// (set) Token: 0x06021429 RID: 136233 RVA: 0x008E8648 File Offset: 0x008E6848
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0602142A RID: 136234 RVA: 0x008E8659 File Offset: 0x008E6859
		// (set) Token: 0x0602142B RID: 136235 RVA: 0x008E8669 File Offset: 0x008E6869
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0602142C RID: 136236 RVA: 0x008E867A File Offset: 0x008E687A
		// (set) Token: 0x0602142D RID: 136237 RVA: 0x008E868E File Offset: 0x008E688E
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0602142E RID: 136238 RVA: 0x008E86A3 File Offset: 0x008E68A3
		// (set) Token: 0x0602142F RID: 136239 RVA: 0x008E86B7 File Offset: 0x008E68B7
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x06021430 RID: 136240 RVA: 0x008E86CC File Offset: 0x008E68CC
		// (set) Token: 0x06021431 RID: 136241 RVA: 0x008E86DC File Offset: 0x008E68DC
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x06021432 RID: 136242 RVA: 0x008E86ED File Offset: 0x008E68ED
		// (set) Token: 0x06021433 RID: 136243 RVA: 0x008E86FD File Offset: 0x008E68FD
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x06021434 RID: 136244 RVA: 0x008E870E File Offset: 0x008E690E
		// (set) Token: 0x06021435 RID: 136245 RVA: 0x008E871E File Offset: 0x008E691E
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x06021436 RID: 136246 RVA: 0x008E872F File Offset: 0x008E692F
		// (set) Token: 0x06021437 RID: 136247 RVA: 0x008E873F File Offset: 0x008E693F
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x06021438 RID: 136248 RVA: 0x008E8750 File Offset: 0x008E6950
		// (set) Token: 0x06021439 RID: 136249 RVA: 0x008E8760 File Offset: 0x008E6960
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0602143A RID: 136250 RVA: 0x008E8771 File Offset: 0x008E6971
		// (set) Token: 0x0602143B RID: 136251 RVA: 0x008E8781 File Offset: 0x008E6981
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0602143C RID: 136252 RVA: 0x008E8792 File Offset: 0x008E6992
		// (set) Token: 0x0602143D RID: 136253 RVA: 0x008E87A6 File Offset: 0x008E69A6
		public unsafe FVector LightShaftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0602143E RID: 136254 RVA: 0x008E87BB File Offset: 0x008E69BB
		// (set) Token: 0x0602143F RID: 136255 RVA: 0x008E87CF File Offset: 0x008E69CF
		public unsafe UStaticMesh LightShaftStaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x06021440 RID: 136256 RVA: 0x008E87E4 File Offset: 0x008E69E4
		// (set) Token: 0x06021441 RID: 136257 RVA: 0x008E87F8 File Offset: 0x008E69F8
		public unsafe UMaterialInstance LightShaftCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x06021442 RID: 136258 RVA: 0x008E880D File Offset: 0x008E6A0D
		// (set) Token: 0x06021443 RID: 136259 RVA: 0x008E8821 File Offset: 0x008E6A21
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x06021444 RID: 136260 RVA: 0x008E8836 File Offset: 0x008E6A36
		// (set) Token: 0x06021445 RID: 136261 RVA: 0x008E884A File Offset: 0x008E6A4A
		public unsafe FLinearColor FallOff_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x06021446 RID: 136262 RVA: 0x008E885F File Offset: 0x008E6A5F
		// (set) Token: 0x06021447 RID: 136263 RVA: 0x008E886F File Offset: 0x008E6A6F
		public unsafe float FallOff_DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x06021448 RID: 136264 RVA: 0x008E8880 File Offset: 0x008E6A80
		// (set) Token: 0x06021449 RID: 136265 RVA: 0x008E8890 File Offset: 0x008E6A90
		public unsafe float ScreenFadeFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0602144A RID: 136266 RVA: 0x008E88A1 File Offset: 0x008E6AA1
		// (set) Token: 0x0602144B RID: 136267 RVA: 0x008E88B1 File Offset: 0x008E6AB1
		public unsafe float Opacity_CenterPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0602144C RID: 136268 RVA: 0x008E88C2 File Offset: 0x008E6AC2
		// (set) Token: 0x0602144D RID: 136269 RVA: 0x008E88D2 File Offset: 0x008E6AD2
		public unsafe float ScreenFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0602144E RID: 136270 RVA: 0x008E88E3 File Offset: 0x008E6AE3
		// (set) Token: 0x0602144F RID: 136271 RVA: 0x008E88F3 File Offset: 0x008E6AF3
		public unsafe float ShaftTopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x06021450 RID: 136272 RVA: 0x008E8904 File Offset: 0x008E6B04
		// (set) Token: 0x06021451 RID: 136273 RVA: 0x008E8918 File Offset: 0x008E6B18
		public unsafe FLinearColor UVScaleAndAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x06021452 RID: 136274 RVA: 0x008E892D File Offset: 0x008E6B2D
		// (set) Token: 0x06021453 RID: 136275 RVA: 0x008E8941 File Offset: 0x008E6B41
		public unsafe UStaticMesh LightMaskStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x06021454 RID: 136276 RVA: 0x008E8956 File Offset: 0x008E6B56
		// (set) Token: 0x06021455 RID: 136277 RVA: 0x008E8966 File Offset: 0x008E6B66
		public unsafe float LightMaskZaxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x06021456 RID: 136278 RVA: 0x008E8977 File Offset: 0x008E6B77
		// (set) Token: 0x06021457 RID: 136279 RVA: 0x008E898B File Offset: 0x008E6B8B
		public unsafe UMaterialInstance LightMaskMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x06021458 RID: 136280 RVA: 0x008E89A0 File Offset: 0x008E6BA0
		// (set) Token: 0x06021459 RID: 136281 RVA: 0x008E89B4 File Offset: 0x008E6BB4
		public unsafe FVector LightMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0602145A RID: 136282 RVA: 0x008E89C9 File Offset: 0x008E6BC9
		// (set) Token: 0x0602145B RID: 136283 RVA: 0x008E89DD File Offset: 0x008E6BDD
		public unsafe FLinearColor LightMaskColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0602145C RID: 136284 RVA: 0x008E89F2 File Offset: 0x008E6BF2
		// (set) Token: 0x0602145D RID: 136285 RVA: 0x008E8A06 File Offset: 0x008E6C06
		public unsafe UTexture2D LightMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0602145E RID: 136286 RVA: 0x008E8A1B File Offset: 0x008E6C1B
		// (set) Token: 0x0602145F RID: 136287 RVA: 0x008E8A2B File Offset: 0x008E6C2B
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x06021460 RID: 136288 RVA: 0x008E8A3C File Offset: 0x008E6C3C
		// (set) Token: 0x06021461 RID: 136289 RVA: 0x008E8A4C File Offset: 0x008E6C4C
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x06021462 RID: 136290 RVA: 0x008E8A5D File Offset: 0x008E6C5D
		// (set) Token: 0x06021463 RID: 136291 RVA: 0x008E8A6D File Offset: 0x008E6C6D
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x06021464 RID: 136292 RVA: 0x008E8A7E File Offset: 0x008E6C7E
		// (set) Token: 0x06021465 RID: 136293 RVA: 0x008E8A8E File Offset: 0x008E6C8E
		public unsafe float FlankInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x06021466 RID: 136294 RVA: 0x008E8A9F File Offset: 0x008E6C9F
		// (set) Token: 0x06021467 RID: 136295 RVA: 0x008E8AAF File Offset: 0x008E6CAF
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x06021468 RID: 136296 RVA: 0x008E8AC0 File Offset: 0x008E6CC0
		// (set) Token: 0x06021469 RID: 136297 RVA: 0x008E8AD0 File Offset: 0x008E6CD0
		public unsafe float RightSideInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0602146A RID: 136298 RVA: 0x008E8AE1 File Offset: 0x008E6CE1
		// (set) Token: 0x0602146B RID: 136299 RVA: 0x008E8AF5 File Offset: 0x008E6CF5
		public unsafe UStaticMeshComponent VolumetricCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0602146C RID: 136300 RVA: 0x008E8B0A File Offset: 0x008E6D0A
		// (set) Token: 0x0602146D RID: 136301 RVA: 0x008E8B1E File Offset: 0x008E6D1E
		public unsafe UStaticMeshComponent LightShaft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0602146E RID: 136302 RVA: 0x008E8B33 File Offset: 0x008E6D33
		// (set) Token: 0x0602146F RID: 136303 RVA: 0x008E8B43 File Offset: 0x008E6D43
		public unsafe bool OptimizeForMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumetricConeLightShaft_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021470 RID: 136304 RVA: 0x008E8B54 File Offset: 0x008E6D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021471 RID: 136305 RVA: 0x008E8B9C File Offset: 0x008E6D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021472 RID: 136306 RVA: 0x008E8BE2 File Offset: 0x008E6DE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021473 RID: 136307 RVA: 0x008E8BF6 File Offset: 0x008E6DF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021474 RID: 136308 RVA: 0x008E8C0B File Offset: 0x008E6E0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021475 RID: 136309 RVA: 0x008E8C1F File Offset: 0x008E6E1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021476 RID: 136310 RVA: 0x008E8C34 File Offset: 0x008E6E34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnGameUserSettingsChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__OnGameUserSettingsChange_NativeFunctionPtr, null);
		}

		// Token: 0x06021477 RID: 136311 RVA: 0x008E8C48 File Offset: 0x008E6E48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021478 RID: 136312 RVA: 0x008E8C94 File Offset: 0x008E6E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumetricConeLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021479 RID: 136313 RVA: 0x008E8CE0 File Offset: 0x008E6EE0
		protected BP_VolumetricConeLightShaft_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010300 RID: 66304
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010301 RID: 66305
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_VolumetricConeLightShaft.BP_VolumetricConeLightShaft_C";

		// Token: 0x04010302 RID: 66306
		private static IntPtr _ClassPtr;

		// Token: 0x04010303 RID: 66307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010304 RID: 66308
		internal static int __PropertyOffset_1;

		// Token: 0x04010305 RID: 66309
		internal static int __PropertyOffset_2;

		// Token: 0x04010306 RID: 66310
		internal static int __PropertyOffset_3;

		// Token: 0x04010307 RID: 66311
		internal static int __PropertyOffset_4;

		// Token: 0x04010308 RID: 66312
		internal static int __PropertyOffset_5;

		// Token: 0x04010309 RID: 66313
		internal static int __PropertyOffset_6;

		// Token: 0x0401030A RID: 66314
		internal static int __PropertyOffset_7;

		// Token: 0x0401030B RID: 66315
		internal static int __PropertyOffset_8;

		// Token: 0x0401030C RID: 66316
		internal static int __PropertyOffset_9;

		// Token: 0x0401030D RID: 66317
		internal static int __PropertyOffset_10;

		// Token: 0x0401030E RID: 66318
		internal static int __PropertyOffset_11;

		// Token: 0x0401030F RID: 66319
		internal static int __PropertyOffset_12;

		// Token: 0x04010310 RID: 66320
		internal static int __PropertyOffset_13;

		// Token: 0x04010311 RID: 66321
		internal static int __PropertyOffset_14;

		// Token: 0x04010312 RID: 66322
		internal static int __PropertyOffset_15;

		// Token: 0x04010313 RID: 66323
		internal static int __PropertyOffset_16;

		// Token: 0x04010314 RID: 66324
		internal static int __PropertyOffset_17;

		// Token: 0x04010315 RID: 66325
		internal static int __PropertyOffset_18;

		// Token: 0x04010316 RID: 66326
		internal static int __PropertyOffset_19;

		// Token: 0x04010317 RID: 66327
		internal static int __PropertyOffset_20;

		// Token: 0x04010318 RID: 66328
		internal static int __PropertyOffset_21;

		// Token: 0x04010319 RID: 66329
		internal static int __PropertyOffset_22;

		// Token: 0x0401031A RID: 66330
		internal static int __PropertyOffset_23;

		// Token: 0x0401031B RID: 66331
		internal static int __PropertyOffset_24;

		// Token: 0x0401031C RID: 66332
		internal static int __PropertyOffset_25;

		// Token: 0x0401031D RID: 66333
		internal static int __PropertyOffset_26;

		// Token: 0x0401031E RID: 66334
		internal static int __PropertyOffset_27;

		// Token: 0x0401031F RID: 66335
		internal static int __PropertyOffset_28;

		// Token: 0x04010320 RID: 66336
		internal static int __PropertyOffset_29;

		// Token: 0x04010321 RID: 66337
		internal static int __PropertyOffset_30;

		// Token: 0x04010322 RID: 66338
		internal static int __PropertyOffset_31;

		// Token: 0x04010323 RID: 66339
		internal static int __PropertyOffset_32;

		// Token: 0x04010324 RID: 66340
		internal static int __PropertyOffset_33;

		// Token: 0x04010325 RID: 66341
		internal static int __PropertyOffset_34;

		// Token: 0x04010326 RID: 66342
		internal static int __PropertyOffset_35;

		// Token: 0x04010327 RID: 66343
		internal static int __PropertyOffset_36;

		// Token: 0x04010328 RID: 66344
		internal static int __PropertyOffset_37;

		// Token: 0x04010329 RID: 66345
		internal static int __PropertyOffset_38;

		// Token: 0x0401032A RID: 66346
		internal static int __PropertyOffset_39;

		// Token: 0x0401032B RID: 66347
		internal static int __PropertyOffset_40;

		// Token: 0x0401032C RID: 66348
		internal static int __PropertyOffset_41;

		// Token: 0x0401032D RID: 66349
		internal static int __PropertyOffset_42;

		// Token: 0x0401032E RID: 66350
		internal static int __PropertyOffset_43;

		// Token: 0x0401032F RID: 66351
		internal static int __PropertyOffset_44;

		// Token: 0x04010330 RID: 66352
		internal static int __PropertyOffset_45;

		// Token: 0x04010331 RID: 66353
		internal static int __PropertyOffset_46;

		// Token: 0x04010332 RID: 66354
		internal static int __PropertyOffset_47;

		// Token: 0x04010333 RID: 66355
		internal static int __PropertyOffset_48;

		// Token: 0x04010334 RID: 66356
		internal static int __PropertyOffset_49;

		// Token: 0x04010335 RID: 66357
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04010336 RID: 66358
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010337 RID: 66359
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010338 RID: 66360
		private static IntPtr __OnGameUserSettingsChange_NativeFunctionPtr;

		// Token: 0x04010339 RID: 66361
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C7D RID: 40061
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0403133B RID: 201531
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C7E RID: 40062
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403133C RID: 201532
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
