using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen
{
	// Token: 0x02003A43 RID: 14915
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C")]
	[UnrealStructLayout(1920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1916)]
	public class BP_SplitScreen_New_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F698 RID: 128664 RVA: 0x008B7C70 File Offset: 0x008B5E70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreen_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C");
			}
			return BP_SplitScreen_New_C._ClassPtr;
		}

		// Token: 0x0601F699 RID: 128665 RVA: 0x008B7C94 File Offset: 0x008B5E94
		public BP_SplitScreen_New_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F69A RID: 128666 RVA: 0x008B7CBC File Offset: 0x008B5EBC
		[NullableContext(1)]
		public BP_SplitScreen_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0601F69B RID: 128667 RVA: 0x008B7CEF File Offset: 0x008B5EEF
		// (set) Token: 0x0601F69C RID: 128668 RVA: 0x008B7D03 File Offset: 0x008B5F03
		public unsafe UChildActorComponent CharacterActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0601F69D RID: 128669 RVA: 0x008B7D18 File Offset: 0x008B5F18
		// (set) Token: 0x0601F69E RID: 128670 RVA: 0x008B7D2C File Offset: 0x008B5F2C
		public unsafe USceneComponent Character3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0601F69F RID: 128671 RVA: 0x008B7D41 File Offset: 0x008B5F41
		// (set) Token: 0x0601F6A0 RID: 128672 RVA: 0x008B7D55 File Offset: 0x008B5F55
		public unsafe UChildActorComponent CharacterActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0601F6A1 RID: 128673 RVA: 0x008B7D6A File Offset: 0x008B5F6A
		// (set) Token: 0x0601F6A2 RID: 128674 RVA: 0x008B7D7E File Offset: 0x008B5F7E
		public unsafe USceneComponent Character2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0601F6A3 RID: 128675 RVA: 0x008B7D93 File Offset: 0x008B5F93
		// (set) Token: 0x0601F6A4 RID: 128676 RVA: 0x008B7DA7 File Offset: 0x008B5FA7
		public unsafe UChildActorComponent CharacterActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0601F6A5 RID: 128677 RVA: 0x008B7DBC File Offset: 0x008B5FBC
		// (set) Token: 0x0601F6A6 RID: 128678 RVA: 0x008B7DD0 File Offset: 0x008B5FD0
		public unsafe USceneComponent Character1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0601F6A7 RID: 128679 RVA: 0x008B7DE5 File Offset: 0x008B5FE5
		// (set) Token: 0x0601F6A8 RID: 128680 RVA: 0x008B7DF9 File Offset: 0x008B5FF9
		public unsafe UPointLightComponent PointLight3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0601F6A9 RID: 128681 RVA: 0x008B7E0E File Offset: 0x008B600E
		// (set) Token: 0x0601F6AA RID: 128682 RVA: 0x008B7E22 File Offset: 0x008B6022
		public unsafe UPointLightComponent PointLight2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0601F6AB RID: 128683 RVA: 0x008B7E37 File Offset: 0x008B6037
		// (set) Token: 0x0601F6AC RID: 128684 RVA: 0x008B7E4B File Offset: 0x008B604B
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0601F6AD RID: 128685 RVA: 0x008B7E60 File Offset: 0x008B6060
		// (set) Token: 0x0601F6AE RID: 128686 RVA: 0x008B7E74 File Offset: 0x008B6074
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0601F6AF RID: 128687 RVA: 0x008B7E89 File Offset: 0x008B6089
		// (set) Token: 0x0601F6B0 RID: 128688 RVA: 0x008B7E9D File Offset: 0x008B609D
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0601F6B1 RID: 128689 RVA: 0x008B7EB2 File Offset: 0x008B60B2
		// (set) Token: 0x0601F6B2 RID: 128690 RVA: 0x008B7EC6 File Offset: 0x008B60C6
		public unsafe FName Angle_LinePosition__LineDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0601F6B3 RID: 128691 RVA: 0x008B7EDB File Offset: 0x008B60DB
		// (set) Token: 0x0601F6B4 RID: 128692 RVA: 0x008B7EEB File Offset: 0x008B60EB
		public unsafe float E_LinkPos_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0601F6B5 RID: 128693 RVA: 0x008B7EFC File Offset: 0x008B60FC
		// (set) Token: 0x0601F6B6 RID: 128694 RVA: 0x008B7F0C File Offset: 0x008B610C
		public unsafe float E_LinkPos_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0601F6B7 RID: 128695 RVA: 0x008B7F1D File Offset: 0x008B611D
		// (set) Token: 0x0601F6B8 RID: 128696 RVA: 0x008B7F2D File Offset: 0x008B612D
		public unsafe float E_LinkPos_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0601F6B9 RID: 128697 RVA: 0x008B7F3E File Offset: 0x008B613E
		// (set) Token: 0x0601F6BA RID: 128698 RVA: 0x008B7F4E File Offset: 0x008B614E
		public unsafe float LightYaw1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0601F6BB RID: 128699 RVA: 0x008B7F5F File Offset: 0x008B615F
		// (set) Token: 0x0601F6BC RID: 128700 RVA: 0x008B7F6F File Offset: 0x008B616F
		public unsafe float LightYaw2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0601F6BD RID: 128701 RVA: 0x008B7F80 File Offset: 0x008B6180
		// (set) Token: 0x0601F6BE RID: 128702 RVA: 0x008B7F90 File Offset: 0x008B6190
		public unsafe float LightYaw3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0601F6BF RID: 128703 RVA: 0x008B7FA1 File Offset: 0x008B61A1
		// (set) Token: 0x0601F6C0 RID: 128704 RVA: 0x008B7FB1 File Offset: 0x008B61B1
		public unsafe float FaceLightYaw1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0601F6C1 RID: 128705 RVA: 0x008B7FC2 File Offset: 0x008B61C2
		// (set) Token: 0x0601F6C2 RID: 128706 RVA: 0x008B7FD2 File Offset: 0x008B61D2
		public unsafe float FaceLightYaw2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0601F6C3 RID: 128707 RVA: 0x008B7FE3 File Offset: 0x008B61E3
		// (set) Token: 0x0601F6C4 RID: 128708 RVA: 0x008B7FF3 File Offset: 0x008B61F3
		public unsafe float FaceLightYaw3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0601F6C5 RID: 128709 RVA: 0x008B8004 File Offset: 0x008B6204
		// (set) Token: 0x0601F6C6 RID: 128710 RVA: 0x008B8018 File Offset: 0x008B6218
		public unsafe FVector PointLight1_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0601F6C7 RID: 128711 RVA: 0x008B802D File Offset: 0x008B622D
		// (set) Token: 0x0601F6C8 RID: 128712 RVA: 0x008B8041 File Offset: 0x008B6241
		public unsafe FVector PointLight2_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0601F6C9 RID: 128713 RVA: 0x008B8056 File Offset: 0x008B6256
		// (set) Token: 0x0601F6CA RID: 128714 RVA: 0x008B806A File Offset: 0x008B626A
		public unsafe FVector PointLight3_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0601F6CB RID: 128715 RVA: 0x008B807F File Offset: 0x008B627F
		// (set) Token: 0x0601F6CC RID: 128716 RVA: 0x008B8093 File Offset: 0x008B6293
		public unsafe FLinearColor PointLight1_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0601F6CD RID: 128717 RVA: 0x008B80A8 File Offset: 0x008B62A8
		// (set) Token: 0x0601F6CE RID: 128718 RVA: 0x008B80BC File Offset: 0x008B62BC
		public unsafe FLinearColor PointLight2_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0601F6CF RID: 128719 RVA: 0x008B80D1 File Offset: 0x008B62D1
		// (set) Token: 0x0601F6D0 RID: 128720 RVA: 0x008B80E5 File Offset: 0x008B62E5
		public unsafe FLinearColor PointLight3_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0601F6D1 RID: 128721 RVA: 0x008B80FA File Offset: 0x008B62FA
		// (set) Token: 0x0601F6D2 RID: 128722 RVA: 0x008B810E File Offset: 0x008B630E
		public unsafe FLinearColor EyeLightSimulation_TongKong1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0601F6D3 RID: 128723 RVA: 0x008B8123 File Offset: 0x008B6323
		// (set) Token: 0x0601F6D4 RID: 128724 RVA: 0x008B8137 File Offset: 0x008B6337
		public unsafe FLinearColor EyeLightSimulation_TongKong2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0601F6D5 RID: 128725 RVA: 0x008B814C File Offset: 0x008B634C
		// (set) Token: 0x0601F6D6 RID: 128726 RVA: 0x008B8160 File Offset: 0x008B6360
		public unsafe FLinearColor EyeLightSimulation_TongKong3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0601F6D7 RID: 128727 RVA: 0x008B8175 File Offset: 0x008B6375
		// (set) Token: 0x0601F6D8 RID: 128728 RVA: 0x008B8189 File Offset: 0x008B6389
		public unsafe FLinearColor EyeLightSimulation_YanBai1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0601F6D9 RID: 128729 RVA: 0x008B819E File Offset: 0x008B639E
		// (set) Token: 0x0601F6DA RID: 128730 RVA: 0x008B81B2 File Offset: 0x008B63B2
		public unsafe FLinearColor EyeLightSimulation_YanBai2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0601F6DB RID: 128731 RVA: 0x008B81C7 File Offset: 0x008B63C7
		// (set) Token: 0x0601F6DC RID: 128732 RVA: 0x008B81DB File Offset: 0x008B63DB
		public unsafe FLinearColor EyeLightSimulation_YanBai3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0601F6DD RID: 128733 RVA: 0x008B81F0 File Offset: 0x008B63F0
		// (set) Token: 0x0601F6DE RID: 128734 RVA: 0x008B8204 File Offset: 0x008B6404
		public unsafe FLinearColor EyeLightSimulation_Color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0601F6DF RID: 128735 RVA: 0x008B8219 File Offset: 0x008B6419
		// (set) Token: 0x0601F6E0 RID: 128736 RVA: 0x008B822D File Offset: 0x008B642D
		public unsafe FLinearColor EyeLightSimulation_Color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0601F6E1 RID: 128737 RVA: 0x008B8242 File Offset: 0x008B6442
		// (set) Token: 0x0601F6E2 RID: 128738 RVA: 0x008B8256 File Offset: 0x008B6456
		public unsafe FLinearColor EyeLightSimulation_Color3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0601F6E3 RID: 128739 RVA: 0x008B826B File Offset: 0x008B646B
		// (set) Token: 0x0601F6E4 RID: 128740 RVA: 0x008B827B File Offset: 0x008B647B
		public unsafe byte MeshPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0601F6E5 RID: 128741 RVA: 0x008B828C File Offset: 0x008B648C
		// (set) Token: 0x0601F6E6 RID: 128742 RVA: 0x008B829C File Offset: 0x008B649C
		public unsafe int Handle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0601F6E7 RID: 128743 RVA: 0x008B82AD File Offset: 0x008B64AD
		// (set) Token: 0x0601F6E8 RID: 128744 RVA: 0x008B82BD File Offset: 0x008B64BD
		public unsafe int Handle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0601F6E9 RID: 128745 RVA: 0x008B82CE File Offset: 0x008B64CE
		// (set) Token: 0x0601F6EA RID: 128746 RVA: 0x008B82DE File Offset: 0x008B64DE
		public unsafe int Handle3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0601F6EB RID: 128747 RVA: 0x008B82EF File Offset: 0x008B64EF
		// (set) Token: 0x0601F6EC RID: 128748 RVA: 0x008B8303 File Offset: 0x008B6503
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0601F6ED RID: 128749 RVA: 0x008B8318 File Offset: 0x008B6518
		// (set) Token: 0x0601F6EE RID: 128750 RVA: 0x008B832C File Offset: 0x008B652C
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_42);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0601F6EF RID: 128751 RVA: 0x008B8341 File Offset: 0x008B6541
		// (set) Token: 0x0601F6F0 RID: 128752 RVA: 0x008B8355 File Offset: 0x008B6555
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_43);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_43, value);
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0601F6F1 RID: 128753 RVA: 0x008B836A File Offset: 0x008B656A
		// (set) Token: 0x0601F6F2 RID: 128754 RVA: 0x008B837A File Offset: 0x008B657A
		public unsafe float textX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0601F6F3 RID: 128755 RVA: 0x008B838B File Offset: 0x008B658B
		// (set) Token: 0x0601F6F4 RID: 128756 RVA: 0x008B839B File Offset: 0x008B659B
		public unsafe float textY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0601F6F5 RID: 128757 RVA: 0x008B83AC File Offset: 0x008B65AC
		// (set) Token: 0x0601F6F6 RID: 128758 RVA: 0x008B83BC File Offset: 0x008B65BC
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0601F6F7 RID: 128759 RVA: 0x008B83CD File Offset: 0x008B65CD
		// (set) Token: 0x0601F6F8 RID: 128760 RVA: 0x008B83E1 File Offset: 0x008B65E1
		public unsafe FVector LinkCameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0601F6F9 RID: 128761 RVA: 0x008B83F6 File Offset: 0x008B65F6
		// (set) Token: 0x0601F6FA RID: 128762 RVA: 0x008B840A File Offset: 0x008B660A
		public unsafe FVector LinkCameraRelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0601F6FB RID: 128763 RVA: 0x008B841F File Offset: 0x008B661F
		// (set) Token: 0x0601F6FC RID: 128764 RVA: 0x008B842F File Offset: 0x008B662F
		public unsafe bool IsThree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0601F6FD RID: 128765 RVA: 0x008B8440 File Offset: 0x008B6640
		// (set) Token: 0x0601F6FE RID: 128766 RVA: 0x008B8450 File Offset: 0x008B6650
		public unsafe int RoleId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0601F6FF RID: 128767 RVA: 0x008B8461 File Offset: 0x008B6661
		// (set) Token: 0x0601F700 RID: 128768 RVA: 0x008B8471 File Offset: 0x008B6671
		public unsafe int RoleId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0601F701 RID: 128769 RVA: 0x008B8482 File Offset: 0x008B6682
		// (set) Token: 0x0601F702 RID: 128770 RVA: 0x008B8492 File Offset: 0x008B6692
		public unsafe int RoleId3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x0601F703 RID: 128771 RVA: 0x008B84A4 File Offset: 0x008B66A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLightDirection(USkeletalMeshComponent Mesh, float LightYaw, float FaceLightYaw)
		{
			BP_SplitScreen_New_C.__SetLightDirection_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__SetLightDirection_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_SplitScreen_New_C.__SetLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F704 RID: 128772 RVA: 0x008B8508 File Offset: 0x008B6708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_SplitScreen_New_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EulerToForward_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601F705 RID: 128773 RVA: 0x008B855B File Offset: 0x008B675B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPosByViewSize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__SetPosByViewSize_NativeFunctionPtr, null);
		}

		// Token: 0x0601F706 RID: 128774 RVA: 0x008B856F File Offset: 0x008B676F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601F707 RID: 128775 RVA: 0x008B8584 File Offset: 0x008B6784
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitKuroMaterialController(UKuroMaterialControllerComponent KuroMaterialControllerComponent, UChildActorComponent CharacterActorComponent, UPointLightComponent PointLightComponent, FVector PointLight_Location, FLinearColor PointLight_ToonLightColor, FLinearColor EyeLightSimulation_TongKong, FLinearColor EyeLightSimulation_YanBai, FLinearColor EyeLightSimulation_Color, float E_LinkPos, bool Channel0, bool Channel1, bool Channel2, float LightYaw, float FaceLightYaw, int RoleId, ref int returnHandle)
		{
			BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams[(UIntPtr)359] + 15L / (long)sizeof(BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr, 1);
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
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->RoleId = RoleId;
			ptr->returnHandle = returnHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr);
			returnHandle = ptr->returnHandle;
		}

		// Token: 0x0601F708 RID: 128776 RVA: 0x008B867A File Offset: 0x008B687A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void End()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__End_NativeFunctionPtr, null);
		}

		// Token: 0x0601F709 RID: 128777 RVA: 0x008B868E File Offset: 0x008B688E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601F70A RID: 128778 RVA: 0x008B86A2 File Offset: 0x008B68A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F70B RID: 128779 RVA: 0x008B86B6 File Offset: 0x008B68B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F70C RID: 128780 RVA: 0x008B86CC File Offset: 0x008B68CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F70D RID: 128781 RVA: 0x008B8714 File Offset: 0x008B6914
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F70E RID: 128782 RVA: 0x008B875C File Offset: 0x008B695C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F70F RID: 128783 RVA: 0x008B87A4 File Offset: 0x008B69A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F710 RID: 128784 RVA: 0x008B87EB File Offset: 0x008B69EB
		protected BP_SplitScreen_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F166 RID: 61798
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C";

		// Token: 0x0400F167 RID: 61799
		private static IntPtr _ClassPtr;

		// Token: 0x0400F168 RID: 61800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F169 RID: 61801
		internal static int __PropertyOffset_1;

		// Token: 0x0400F16A RID: 61802
		internal static int __PropertyOffset_2;

		// Token: 0x0400F16B RID: 61803
		internal static int __PropertyOffset_3;

		// Token: 0x0400F16C RID: 61804
		internal static int __PropertyOffset_4;

		// Token: 0x0400F16D RID: 61805
		internal static int __PropertyOffset_5;

		// Token: 0x0400F16E RID: 61806
		internal static int __PropertyOffset_6;

		// Token: 0x0400F16F RID: 61807
		internal static int __PropertyOffset_7;

		// Token: 0x0400F170 RID: 61808
		internal static int __PropertyOffset_8;

		// Token: 0x0400F171 RID: 61809
		internal static int __PropertyOffset_9;

		// Token: 0x0400F172 RID: 61810
		internal static int __PropertyOffset_10;

		// Token: 0x0400F173 RID: 61811
		internal static int __PropertyOffset_11;

		// Token: 0x0400F174 RID: 61812
		internal static int __PropertyOffset_12;

		// Token: 0x0400F175 RID: 61813
		internal static int __PropertyOffset_13;

		// Token: 0x0400F176 RID: 61814
		internal static int __PropertyOffset_14;

		// Token: 0x0400F177 RID: 61815
		internal static int __PropertyOffset_15;

		// Token: 0x0400F178 RID: 61816
		internal static int __PropertyOffset_16;

		// Token: 0x0400F179 RID: 61817
		internal static int __PropertyOffset_17;

		// Token: 0x0400F17A RID: 61818
		internal static int __PropertyOffset_18;

		// Token: 0x0400F17B RID: 61819
		internal static int __PropertyOffset_19;

		// Token: 0x0400F17C RID: 61820
		internal static int __PropertyOffset_20;

		// Token: 0x0400F17D RID: 61821
		internal static int __PropertyOffset_21;

		// Token: 0x0400F17E RID: 61822
		internal static int __PropertyOffset_22;

		// Token: 0x0400F17F RID: 61823
		internal static int __PropertyOffset_23;

		// Token: 0x0400F180 RID: 61824
		internal static int __PropertyOffset_24;

		// Token: 0x0400F181 RID: 61825
		internal static int __PropertyOffset_25;

		// Token: 0x0400F182 RID: 61826
		internal static int __PropertyOffset_26;

		// Token: 0x0400F183 RID: 61827
		internal static int __PropertyOffset_27;

		// Token: 0x0400F184 RID: 61828
		internal static int __PropertyOffset_28;

		// Token: 0x0400F185 RID: 61829
		internal static int __PropertyOffset_29;

		// Token: 0x0400F186 RID: 61830
		internal static int __PropertyOffset_30;

		// Token: 0x0400F187 RID: 61831
		internal static int __PropertyOffset_31;

		// Token: 0x0400F188 RID: 61832
		internal static int __PropertyOffset_32;

		// Token: 0x0400F189 RID: 61833
		internal static int __PropertyOffset_33;

		// Token: 0x0400F18A RID: 61834
		internal static int __PropertyOffset_34;

		// Token: 0x0400F18B RID: 61835
		internal static int __PropertyOffset_35;

		// Token: 0x0400F18C RID: 61836
		internal static int __PropertyOffset_36;

		// Token: 0x0400F18D RID: 61837
		internal static int __PropertyOffset_37;

		// Token: 0x0400F18E RID: 61838
		internal static int __PropertyOffset_38;

		// Token: 0x0400F18F RID: 61839
		internal static int __PropertyOffset_39;

		// Token: 0x0400F190 RID: 61840
		internal static int __PropertyOffset_40;

		// Token: 0x0400F191 RID: 61841
		internal static int __PropertyOffset_41;

		// Token: 0x0400F192 RID: 61842
		internal static int __PropertyOffset_42;

		// Token: 0x0400F193 RID: 61843
		internal static int __PropertyOffset_43;

		// Token: 0x0400F194 RID: 61844
		internal static int __PropertyOffset_44;

		// Token: 0x0400F195 RID: 61845
		internal static int __PropertyOffset_45;

		// Token: 0x0400F196 RID: 61846
		internal static int __PropertyOffset_46;

		// Token: 0x0400F197 RID: 61847
		internal static int __PropertyOffset_47;

		// Token: 0x0400F198 RID: 61848
		internal static int __PropertyOffset_48;

		// Token: 0x0400F199 RID: 61849
		internal static int __PropertyOffset_49;

		// Token: 0x0400F19A RID: 61850
		internal static int __PropertyOffset_50;

		// Token: 0x0400F19B RID: 61851
		internal static int __PropertyOffset_51;

		// Token: 0x0400F19C RID: 61852
		internal static int __PropertyOffset_52;

		// Token: 0x0400F19D RID: 61853
		private static IntPtr __SetLightDirection_NativeFunctionPtr;

		// Token: 0x0400F19E RID: 61854
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x0400F19F RID: 61855
		private static IntPtr __SetPosByViewSize_NativeFunctionPtr;

		// Token: 0x0400F1A0 RID: 61856
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400F1A1 RID: 61857
		private static IntPtr __InitKuroMaterialController_NativeFunctionPtr;

		// Token: 0x0400F1A2 RID: 61858
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400F1A3 RID: 61859
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400F1A4 RID: 61860
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F1A5 RID: 61861
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F1A6 RID: 61862
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ADA RID: 39642
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetLightDirection_FunctionParams
		{
			// Token: 0x0403108F RID: 200847
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031090 RID: 200848
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x04031091 RID: 200849
			[FieldOffset(12)]
			public float FaceLightYaw;
		}

		// Token: 0x02009ADB RID: 39643
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031092 RID: 200850
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031093 RID: 200851
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031094 RID: 200852
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x02009ADC RID: 39644
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 344)]
		protected ref struct __InitKuroMaterialController_FunctionParams
		{
			// Token: 0x04031095 RID: 200853
			[FieldOffset(0)]
			public IntPtr KuroMaterialControllerComponent;

			// Token: 0x04031096 RID: 200854
			[FieldOffset(8)]
			public IntPtr CharacterActorComponent;

			// Token: 0x04031097 RID: 200855
			[FieldOffset(16)]
			public IntPtr PointLightComponent;

			// Token: 0x04031098 RID: 200856
			[FieldOffset(24)]
			public FVector PointLight_Location;

			// Token: 0x04031099 RID: 200857
			[FieldOffset(36)]
			public FLinearColor PointLight_ToonLightColor;

			// Token: 0x0403109A RID: 200858
			[FieldOffset(52)]
			public FLinearColor EyeLightSimulation_TongKong;

			// Token: 0x0403109B RID: 200859
			[FieldOffset(68)]
			public FLinearColor EyeLightSimulation_YanBai;

			// Token: 0x0403109C RID: 200860
			[FieldOffset(84)]
			public FLinearColor EyeLightSimulation_Color;

			// Token: 0x0403109D RID: 200861
			[FieldOffset(100)]
			public float E_LinkPos;

			// Token: 0x0403109E RID: 200862
			[FieldOffset(104)]
			public bool Channel0;

			// Token: 0x0403109F RID: 200863
			[FieldOffset(105)]
			public bool Channel1;

			// Token: 0x040310A0 RID: 200864
			[FieldOffset(106)]
			public bool Channel2;

			// Token: 0x040310A1 RID: 200865
			[FieldOffset(108)]
			public float LightYaw;

			// Token: 0x040310A2 RID: 200866
			[FieldOffset(112)]
			public float FaceLightYaw;

			// Token: 0x040310A3 RID: 200867
			[FieldOffset(116)]
			public int RoleId;

			// Token: 0x040310A4 RID: 200868
			[FieldOffset(120)]
			public int returnHandle;
		}

		// Token: 0x02009ADD RID: 39645
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040310A5 RID: 200869
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009ADE RID: 39646
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040310A6 RID: 200870
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
