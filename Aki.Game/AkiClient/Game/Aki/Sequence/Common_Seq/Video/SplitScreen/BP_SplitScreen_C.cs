using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen
{
	// Token: 0x02003A42 RID: 14914
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class BP_SplitScreen_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F648 RID: 128584 RVA: 0x008B74D7 File Offset: 0x008B56D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C");
			}
			return BP_SplitScreen_C._ClassPtr;
		}

		// Token: 0x0601F649 RID: 128585 RVA: 0x008B74FC File Offset: 0x008B56FC
		public BP_SplitScreen_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F64A RID: 128586 RVA: 0x008B7524 File Offset: 0x008B5724
		[NullableContext(1)]
		public BP_SplitScreen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0601F64B RID: 128587 RVA: 0x008B7557 File Offset: 0x008B5757
		// (set) Token: 0x0601F64C RID: 128588 RVA: 0x008B756B File Offset: 0x008B576B
		public unsafe UPointLightComponent PointLight3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0601F64D RID: 128589 RVA: 0x008B7580 File Offset: 0x008B5780
		// (set) Token: 0x0601F64E RID: 128590 RVA: 0x008B7594 File Offset: 0x008B5794
		public unsafe UPointLightComponent PointLight2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0601F64F RID: 128591 RVA: 0x008B75A9 File Offset: 0x008B57A9
		// (set) Token: 0x0601F650 RID: 128592 RVA: 0x008B75BD File Offset: 0x008B57BD
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0601F651 RID: 128593 RVA: 0x008B75D2 File Offset: 0x008B57D2
		// (set) Token: 0x0601F652 RID: 128594 RVA: 0x008B75E6 File Offset: 0x008B57E6
		public unsafe UChildActorComponent CharacterActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0601F653 RID: 128595 RVA: 0x008B75FB File Offset: 0x008B57FB
		// (set) Token: 0x0601F654 RID: 128596 RVA: 0x008B760F File Offset: 0x008B580F
		public unsafe UChildActorComponent CharacterActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0601F655 RID: 128597 RVA: 0x008B7624 File Offset: 0x008B5824
		// (set) Token: 0x0601F656 RID: 128598 RVA: 0x008B7638 File Offset: 0x008B5838
		public unsafe UChildActorComponent CharacterActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0601F657 RID: 128599 RVA: 0x008B764D File Offset: 0x008B584D
		// (set) Token: 0x0601F658 RID: 128600 RVA: 0x008B7661 File Offset: 0x008B5861
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0601F659 RID: 128601 RVA: 0x008B7676 File Offset: 0x008B5876
		// (set) Token: 0x0601F65A RID: 128602 RVA: 0x008B768A File Offset: 0x008B588A
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0601F65B RID: 128603 RVA: 0x008B769F File Offset: 0x008B589F
		// (set) Token: 0x0601F65C RID: 128604 RVA: 0x008B76B3 File Offset: 0x008B58B3
		public unsafe FName Angle_LinePosition__LineDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0601F65D RID: 128605 RVA: 0x008B76C8 File Offset: 0x008B58C8
		// (set) Token: 0x0601F65E RID: 128606 RVA: 0x008B76D8 File Offset: 0x008B58D8
		public unsafe float E_LinkPos_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0601F65F RID: 128607 RVA: 0x008B76E9 File Offset: 0x008B58E9
		// (set) Token: 0x0601F660 RID: 128608 RVA: 0x008B76F9 File Offset: 0x008B58F9
		public unsafe float E_LinkPos_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0601F661 RID: 128609 RVA: 0x008B770A File Offset: 0x008B590A
		// (set) Token: 0x0601F662 RID: 128610 RVA: 0x008B771A File Offset: 0x008B591A
		public unsafe float E_LinkPos_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0601F663 RID: 128611 RVA: 0x008B772B File Offset: 0x008B592B
		// (set) Token: 0x0601F664 RID: 128612 RVA: 0x008B773F File Offset: 0x008B593F
		public unsafe FVector PointLight1_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0601F665 RID: 128613 RVA: 0x008B7754 File Offset: 0x008B5954
		// (set) Token: 0x0601F666 RID: 128614 RVA: 0x008B7768 File Offset: 0x008B5968
		public unsafe FVector PointLight2_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0601F667 RID: 128615 RVA: 0x008B777D File Offset: 0x008B597D
		// (set) Token: 0x0601F668 RID: 128616 RVA: 0x008B7791 File Offset: 0x008B5991
		public unsafe FVector PointLight3_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0601F669 RID: 128617 RVA: 0x008B77A6 File Offset: 0x008B59A6
		// (set) Token: 0x0601F66A RID: 128618 RVA: 0x008B77BA File Offset: 0x008B59BA
		public unsafe FLinearColor PointLight1_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0601F66B RID: 128619 RVA: 0x008B77CF File Offset: 0x008B59CF
		// (set) Token: 0x0601F66C RID: 128620 RVA: 0x008B77E3 File Offset: 0x008B59E3
		public unsafe FLinearColor PointLight2_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0601F66D RID: 128621 RVA: 0x008B77F8 File Offset: 0x008B59F8
		// (set) Token: 0x0601F66E RID: 128622 RVA: 0x008B780C File Offset: 0x008B5A0C
		public unsafe FLinearColor PointLight3_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0601F66F RID: 128623 RVA: 0x008B7821 File Offset: 0x008B5A21
		// (set) Token: 0x0601F670 RID: 128624 RVA: 0x008B7835 File Offset: 0x008B5A35
		public unsafe FLinearColor EyeLightSimulation_TongKong1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0601F671 RID: 128625 RVA: 0x008B784A File Offset: 0x008B5A4A
		// (set) Token: 0x0601F672 RID: 128626 RVA: 0x008B785E File Offset: 0x008B5A5E
		public unsafe FLinearColor EyeLightSimulation_TongKong2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0601F673 RID: 128627 RVA: 0x008B7873 File Offset: 0x008B5A73
		// (set) Token: 0x0601F674 RID: 128628 RVA: 0x008B7887 File Offset: 0x008B5A87
		public unsafe FLinearColor EyeLightSimulation_TongKong3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0601F675 RID: 128629 RVA: 0x008B789C File Offset: 0x008B5A9C
		// (set) Token: 0x0601F676 RID: 128630 RVA: 0x008B78B0 File Offset: 0x008B5AB0
		public unsafe FLinearColor EyeLightSimulation_YanBai1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0601F677 RID: 128631 RVA: 0x008B78C5 File Offset: 0x008B5AC5
		// (set) Token: 0x0601F678 RID: 128632 RVA: 0x008B78D9 File Offset: 0x008B5AD9
		public unsafe FLinearColor EyeLightSimulation_YanBai2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0601F679 RID: 128633 RVA: 0x008B78EE File Offset: 0x008B5AEE
		// (set) Token: 0x0601F67A RID: 128634 RVA: 0x008B7902 File Offset: 0x008B5B02
		public unsafe FLinearColor EyeLightSimulation_YanBai3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0601F67B RID: 128635 RVA: 0x008B7917 File Offset: 0x008B5B17
		// (set) Token: 0x0601F67C RID: 128636 RVA: 0x008B792B File Offset: 0x008B5B2B
		public unsafe FLinearColor EyeLightSimulation_Color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0601F67D RID: 128637 RVA: 0x008B7940 File Offset: 0x008B5B40
		// (set) Token: 0x0601F67E RID: 128638 RVA: 0x008B7954 File Offset: 0x008B5B54
		public unsafe FLinearColor EyeLightSimulation_Color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0601F67F RID: 128639 RVA: 0x008B7969 File Offset: 0x008B5B69
		// (set) Token: 0x0601F680 RID: 128640 RVA: 0x008B797D File Offset: 0x008B5B7D
		public unsafe FLinearColor EyeLightSimulation_Color3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0601F681 RID: 128641 RVA: 0x008B7992 File Offset: 0x008B5B92
		// (set) Token: 0x0601F682 RID: 128642 RVA: 0x008B79A2 File Offset: 0x008B5BA2
		public unsafe byte MeshPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0601F683 RID: 128643 RVA: 0x008B79B3 File Offset: 0x008B5BB3
		// (set) Token: 0x0601F684 RID: 128644 RVA: 0x008B79C3 File Offset: 0x008B5BC3
		public unsafe int Handle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0601F685 RID: 128645 RVA: 0x008B79D4 File Offset: 0x008B5BD4
		// (set) Token: 0x0601F686 RID: 128646 RVA: 0x008B79E4 File Offset: 0x008B5BE4
		public unsafe int Handle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0601F687 RID: 128647 RVA: 0x008B79F5 File Offset: 0x008B5BF5
		// (set) Token: 0x0601F688 RID: 128648 RVA: 0x008B7A05 File Offset: 0x008B5C05
		public unsafe int Handle3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0601F689 RID: 128649 RVA: 0x008B7A16 File Offset: 0x008B5C16
		// (set) Token: 0x0601F68A RID: 128650 RVA: 0x008B7A2A File Offset: 0x008B5C2A
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0601F68B RID: 128651 RVA: 0x008B7A3F File Offset: 0x008B5C3F
		// (set) Token: 0x0601F68C RID: 128652 RVA: 0x008B7A53 File Offset: 0x008B5C53
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0601F68D RID: 128653 RVA: 0x008B7A68 File Offset: 0x008B5C68
		// (set) Token: 0x0601F68E RID: 128654 RVA: 0x008B7A7C File Offset: 0x008B5C7C
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x0601F68F RID: 128655 RVA: 0x008B7A91 File Offset: 0x008B5C91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601F690 RID: 128656 RVA: 0x008B7AA8 File Offset: 0x008B5CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitKuroMaterialController(UKuroMaterialControllerComponent KuroMaterialControllerComponent, UChildActorComponent CharacterActorComponent, UPointLightComponent PointLightComponent, FVector PointLight_Location, FLinearColor PointLight_ToonLightColor, FLinearColor EyeLightSimulation_TongKong, FLinearColor EyeLightSimulation_YanBai, FLinearColor EyeLightSimulation_Color, float E_LinkPos, bool Channel0, bool Channel1, bool Channel2, ref int returnHandle)
		{
			BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KuroMaterialControllerComponent = ((KuroMaterialControllerComponent != null) ? KuroMaterialControllerComponent.NativePtr : IntPtr.Zero);
			ptr->CharacterActorComponent = ((CharacterActorComponent != null) ? CharacterActorComponent.NativePtr : IntPtr.Zero);
			ptr->PointLightComponent = ((PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
			ptr->PointLight_Location = PointLight_Location;
			ptr->PointLight_ToonLightColor = PointLight_ToonLightColor;
			ptr->EyeLightSimulation_TongKong = EyeLightSimulation_TongKong;
			ptr->EyeLightSimulation_YanBai = EyeLightSimulation_YanBai;
			ptr->EyeLightSimulation_Color = EyeLightSimulation_Color;
			ptr->E_LinkPos = E_LinkPos;
			ptr->Channel0 = Channel0;
			ptr->Channel1 = Channel1;
			ptr->Channel2 = Channel2;
			ptr->returnHandle = returnHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr);
			returnHandle = ptr->returnHandle;
		}

		// Token: 0x0601F691 RID: 128657 RVA: 0x008B7B86 File Offset: 0x008B5D86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void End()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__End_NativeFunctionPtr, null);
		}

		// Token: 0x0601F692 RID: 128658 RVA: 0x008B7B9A File Offset: 0x008B5D9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601F693 RID: 128659 RVA: 0x008B7BAE File Offset: 0x008B5DAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F694 RID: 128660 RVA: 0x008B7BC2 File Offset: 0x008B5DC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F695 RID: 128661 RVA: 0x008B7BD8 File Offset: 0x008B5DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplitScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F696 RID: 128662 RVA: 0x008B7C20 File Offset: 0x008B5E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F697 RID: 128663 RVA: 0x008B7C67 File Offset: 0x008B5E67
		protected BP_SplitScreen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F13B RID: 61755
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C";

		// Token: 0x0400F13C RID: 61756
		private static IntPtr _ClassPtr;

		// Token: 0x0400F13D RID: 61757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F13E RID: 61758
		internal static int __PropertyOffset_1;

		// Token: 0x0400F13F RID: 61759
		internal static int __PropertyOffset_2;

		// Token: 0x0400F140 RID: 61760
		internal static int __PropertyOffset_3;

		// Token: 0x0400F141 RID: 61761
		internal static int __PropertyOffset_4;

		// Token: 0x0400F142 RID: 61762
		internal static int __PropertyOffset_5;

		// Token: 0x0400F143 RID: 61763
		internal static int __PropertyOffset_6;

		// Token: 0x0400F144 RID: 61764
		internal static int __PropertyOffset_7;

		// Token: 0x0400F145 RID: 61765
		internal static int __PropertyOffset_8;

		// Token: 0x0400F146 RID: 61766
		internal static int __PropertyOffset_9;

		// Token: 0x0400F147 RID: 61767
		internal static int __PropertyOffset_10;

		// Token: 0x0400F148 RID: 61768
		internal static int __PropertyOffset_11;

		// Token: 0x0400F149 RID: 61769
		internal static int __PropertyOffset_12;

		// Token: 0x0400F14A RID: 61770
		internal static int __PropertyOffset_13;

		// Token: 0x0400F14B RID: 61771
		internal static int __PropertyOffset_14;

		// Token: 0x0400F14C RID: 61772
		internal static int __PropertyOffset_15;

		// Token: 0x0400F14D RID: 61773
		internal static int __PropertyOffset_16;

		// Token: 0x0400F14E RID: 61774
		internal static int __PropertyOffset_17;

		// Token: 0x0400F14F RID: 61775
		internal static int __PropertyOffset_18;

		// Token: 0x0400F150 RID: 61776
		internal static int __PropertyOffset_19;

		// Token: 0x0400F151 RID: 61777
		internal static int __PropertyOffset_20;

		// Token: 0x0400F152 RID: 61778
		internal static int __PropertyOffset_21;

		// Token: 0x0400F153 RID: 61779
		internal static int __PropertyOffset_22;

		// Token: 0x0400F154 RID: 61780
		internal static int __PropertyOffset_23;

		// Token: 0x0400F155 RID: 61781
		internal static int __PropertyOffset_24;

		// Token: 0x0400F156 RID: 61782
		internal static int __PropertyOffset_25;

		// Token: 0x0400F157 RID: 61783
		internal static int __PropertyOffset_26;

		// Token: 0x0400F158 RID: 61784
		internal static int __PropertyOffset_27;

		// Token: 0x0400F159 RID: 61785
		internal static int __PropertyOffset_28;

		// Token: 0x0400F15A RID: 61786
		internal static int __PropertyOffset_29;

		// Token: 0x0400F15B RID: 61787
		internal static int __PropertyOffset_30;

		// Token: 0x0400F15C RID: 61788
		internal static int __PropertyOffset_31;

		// Token: 0x0400F15D RID: 61789
		internal static int __PropertyOffset_32;

		// Token: 0x0400F15E RID: 61790
		internal static int __PropertyOffset_33;

		// Token: 0x0400F15F RID: 61791
		internal static int __PropertyOffset_34;

		// Token: 0x0400F160 RID: 61792
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400F161 RID: 61793
		private static IntPtr __InitKuroMaterialController_NativeFunctionPtr;

		// Token: 0x0400F162 RID: 61794
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400F163 RID: 61795
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400F164 RID: 61796
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F165 RID: 61797
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009AD8 RID: 39640
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __InitKuroMaterialController_FunctionParams
		{
			// Token: 0x04031081 RID: 200833
			[FieldOffset(0)]
			public IntPtr KuroMaterialControllerComponent;

			// Token: 0x04031082 RID: 200834
			[FieldOffset(8)]
			public IntPtr CharacterActorComponent;

			// Token: 0x04031083 RID: 200835
			[FieldOffset(16)]
			public IntPtr PointLightComponent;

			// Token: 0x04031084 RID: 200836
			[FieldOffset(24)]
			public FVector PointLight_Location;

			// Token: 0x04031085 RID: 200837
			[FieldOffset(36)]
			public FLinearColor PointLight_ToonLightColor;

			// Token: 0x04031086 RID: 200838
			[FieldOffset(52)]
			public FLinearColor EyeLightSimulation_TongKong;

			// Token: 0x04031087 RID: 200839
			[FieldOffset(68)]
			public FLinearColor EyeLightSimulation_YanBai;

			// Token: 0x04031088 RID: 200840
			[FieldOffset(84)]
			public FLinearColor EyeLightSimulation_Color;

			// Token: 0x04031089 RID: 200841
			[FieldOffset(100)]
			public float E_LinkPos;

			// Token: 0x0403108A RID: 200842
			[FieldOffset(104)]
			public bool Channel0;

			// Token: 0x0403108B RID: 200843
			[FieldOffset(105)]
			public bool Channel1;

			// Token: 0x0403108C RID: 200844
			[FieldOffset(106)]
			public bool Channel2;

			// Token: 0x0403108D RID: 200845
			[FieldOffset(108)]
			public int returnHandle;
		}

		// Token: 0x02009AD9 RID: 39641
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403108E RID: 200846
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
