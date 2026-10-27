using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Sequence.Seq_BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E0C RID: 15884
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C")]
	[UnrealStructLayout(2008, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2002)]
	public class BP_Cinematics_Tick_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BDC RID: 162780 RVA: 0x0099A382 File Offset: 0x00998582
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cinematics_Tick_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C");
			}
			return BP_Cinematics_Tick_C._ClassPtr;
		}

		// Token: 0x06027BDD RID: 162781 RVA: 0x0099A3A8 File Offset: 0x009985A8
		public BP_Cinematics_Tick_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cinematics_Tick_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BDE RID: 162782 RVA: 0x0099A3D0 File Offset: 0x009985D0
		[NullableContext(1)]
		public BP_Cinematics_Tick_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cinematics_Tick_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x06027BDF RID: 162783 RVA: 0x0099A403 File Offset: 0x00998603
		// (set) Token: 0x06027BE0 RID: 162784 RVA: 0x0099A417 File Offset: 0x00998617
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x06027BE1 RID: 162785 RVA: 0x0099A42C File Offset: 0x0099862C
		// (set) Token: 0x06027BE2 RID: 162786 RVA: 0x0099A43C File Offset: 0x0099863C
		public unsafe int Is_Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x06027BE3 RID: 162787 RVA: 0x0099A44D File Offset: 0x0099864D
		// (set) Token: 0x06027BE4 RID: 162788 RVA: 0x0099A461 File Offset: 0x00998661
		public unsafe ABaseCharacter BP_Character_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x06027BE5 RID: 162789 RVA: 0x0099A476 File Offset: 0x00998676
		// (set) Token: 0x06027BE6 RID: 162790 RVA: 0x0099A486 File Offset: 0x00998686
		public unsafe float Character_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x06027BE7 RID: 162791 RVA: 0x0099A497 File Offset: 0x00998697
		// (set) Token: 0x06027BE8 RID: 162792 RVA: 0x0099A4A7 File Offset: 0x009986A7
		public unsafe float Character_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x06027BE9 RID: 162793 RVA: 0x0099A4B8 File Offset: 0x009986B8
		// (set) Token: 0x06027BEA RID: 162794 RVA: 0x0099A4CC File Offset: 0x009986CC
		public unsafe ABaseCharacter BP_Character_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x06027BEB RID: 162795 RVA: 0x0099A4E1 File Offset: 0x009986E1
		// (set) Token: 0x06027BEC RID: 162796 RVA: 0x0099A4F1 File Offset: 0x009986F1
		public unsafe float Character_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x06027BED RID: 162797 RVA: 0x0099A502 File Offset: 0x00998702
		// (set) Token: 0x06027BEE RID: 162798 RVA: 0x0099A512 File Offset: 0x00998712
		public unsafe float Character_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x06027BEF RID: 162799 RVA: 0x0099A523 File Offset: 0x00998723
		// (set) Token: 0x06027BF0 RID: 162800 RVA: 0x0099A537 File Offset: 0x00998737
		public unsafe ABaseCharacter BP_Character_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x06027BF1 RID: 162801 RVA: 0x0099A54C File Offset: 0x0099874C
		// (set) Token: 0x06027BF2 RID: 162802 RVA: 0x0099A55C File Offset: 0x0099875C
		public unsafe float Character_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x06027BF3 RID: 162803 RVA: 0x0099A56D File Offset: 0x0099876D
		// (set) Token: 0x06027BF4 RID: 162804 RVA: 0x0099A57D File Offset: 0x0099877D
		public unsafe float Character_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x06027BF5 RID: 162805 RVA: 0x0099A58E File Offset: 0x0099878E
		// (set) Token: 0x06027BF6 RID: 162806 RVA: 0x0099A5A2 File Offset: 0x009987A2
		public unsafe ABaseCharacter BP_Character_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x06027BF7 RID: 162807 RVA: 0x0099A5B7 File Offset: 0x009987B7
		// (set) Token: 0x06027BF8 RID: 162808 RVA: 0x0099A5C7 File Offset: 0x009987C7
		public unsafe float Character_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x06027BF9 RID: 162809 RVA: 0x0099A5D8 File Offset: 0x009987D8
		// (set) Token: 0x06027BFA RID: 162810 RVA: 0x0099A5E8 File Offset: 0x009987E8
		public unsafe float Character_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x06027BFB RID: 162811 RVA: 0x0099A5F9 File Offset: 0x009987F9
		// (set) Token: 0x06027BFC RID: 162812 RVA: 0x0099A60D File Offset: 0x0099880D
		public unsafe ASkeletalMeshActor SkeletalMesh_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x06027BFD RID: 162813 RVA: 0x0099A622 File Offset: 0x00998822
		// (set) Token: 0x06027BFE RID: 162814 RVA: 0x0099A632 File Offset: 0x00998832
		public unsafe float SkeletalMesh_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x06027BFF RID: 162815 RVA: 0x0099A643 File Offset: 0x00998843
		// (set) Token: 0x06027C00 RID: 162816 RVA: 0x0099A653 File Offset: 0x00998853
		public unsafe float SkeletalMesh_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x06027C01 RID: 162817 RVA: 0x0099A664 File Offset: 0x00998864
		// (set) Token: 0x06027C02 RID: 162818 RVA: 0x0099A678 File Offset: 0x00998878
		public unsafe ASkeletalMeshActor SkeletalMesh_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x06027C03 RID: 162819 RVA: 0x0099A68D File Offset: 0x0099888D
		// (set) Token: 0x06027C04 RID: 162820 RVA: 0x0099A69D File Offset: 0x0099889D
		public unsafe float SkeletalMesh_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x06027C05 RID: 162821 RVA: 0x0099A6AE File Offset: 0x009988AE
		// (set) Token: 0x06027C06 RID: 162822 RVA: 0x0099A6BE File Offset: 0x009988BE
		public unsafe float SkeletalMesh_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x06027C07 RID: 162823 RVA: 0x0099A6CF File Offset: 0x009988CF
		// (set) Token: 0x06027C08 RID: 162824 RVA: 0x0099A6E3 File Offset: 0x009988E3
		public unsafe ASkeletalMeshActor SkeletalMesh_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x06027C09 RID: 162825 RVA: 0x0099A6F8 File Offset: 0x009988F8
		// (set) Token: 0x06027C0A RID: 162826 RVA: 0x0099A708 File Offset: 0x00998908
		public unsafe float SkeletalMesh_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x06027C0B RID: 162827 RVA: 0x0099A719 File Offset: 0x00998919
		// (set) Token: 0x06027C0C RID: 162828 RVA: 0x0099A729 File Offset: 0x00998929
		public unsafe float SkeletalMesh_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x06027C0D RID: 162829 RVA: 0x0099A73A File Offset: 0x0099893A
		// (set) Token: 0x06027C0E RID: 162830 RVA: 0x0099A74E File Offset: 0x0099894E
		public unsafe ASkeletalMeshActor SkeletalMesh_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x06027C0F RID: 162831 RVA: 0x0099A763 File Offset: 0x00998963
		// (set) Token: 0x06027C10 RID: 162832 RVA: 0x0099A773 File Offset: 0x00998973
		public unsafe float SkeletalMesh_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x06027C11 RID: 162833 RVA: 0x0099A784 File Offset: 0x00998984
		// (set) Token: 0x06027C12 RID: 162834 RVA: 0x0099A794 File Offset: 0x00998994
		public unsafe float SkeletalMesh_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x06027C13 RID: 162835 RVA: 0x0099A7A5 File Offset: 0x009989A5
		// (set) Token: 0x06027C14 RID: 162836 RVA: 0x0099A7B9 File Offset: 0x009989B9
		public unsafe ASkeletalMeshActor SkeletalMesh_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x06027C15 RID: 162837 RVA: 0x0099A7CE File Offset: 0x009989CE
		// (set) Token: 0x06027C16 RID: 162838 RVA: 0x0099A7DE File Offset: 0x009989DE
		public unsafe float SkeletalMesh_5_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x06027C17 RID: 162839 RVA: 0x0099A7EF File Offset: 0x009989EF
		// (set) Token: 0x06027C18 RID: 162840 RVA: 0x0099A7FF File Offset: 0x009989FF
		public unsafe float SkeletalMesh_5_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x06027C19 RID: 162841 RVA: 0x0099A810 File Offset: 0x00998A10
		// (set) Token: 0x06027C1A RID: 162842 RVA: 0x0099A824 File Offset: 0x00998A24
		public unsafe ASkeletalMeshActor SkeletalMesh_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x06027C1B RID: 162843 RVA: 0x0099A839 File Offset: 0x00998A39
		// (set) Token: 0x06027C1C RID: 162844 RVA: 0x0099A849 File Offset: 0x00998A49
		public unsafe float SkeletalMesh_6_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x06027C1D RID: 162845 RVA: 0x0099A85A File Offset: 0x00998A5A
		// (set) Token: 0x06027C1E RID: 162846 RVA: 0x0099A86A File Offset: 0x00998A6A
		public unsafe float SkeletalMesh_6_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x06027C1F RID: 162847 RVA: 0x0099A87B File Offset: 0x00998A7B
		// (set) Token: 0x06027C20 RID: 162848 RVA: 0x0099A88F File Offset: 0x00998A8F
		public unsafe USkeletalMeshComponent UISceneRole
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x06027C21 RID: 162849 RVA: 0x0099A8A4 File Offset: 0x00998AA4
		// (set) Token: 0x06027C22 RID: 162850 RVA: 0x0099A8B8 File Offset: 0x00998AB8
		public unsafe USkeletalMeshComponent UISceneRole_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x06027C23 RID: 162851 RVA: 0x0099A8CD File Offset: 0x00998ACD
		// (set) Token: 0x06027C24 RID: 162852 RVA: 0x0099A8E1 File Offset: 0x00998AE1
		public unsafe AActor BP_NanzhuSeqV2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x06027C25 RID: 162853 RVA: 0x0099A8F6 File Offset: 0x00998AF6
		// (set) Token: 0x06027C26 RID: 162854 RVA: 0x0099A906 File Offset: 0x00998B06
		public unsafe float BP_NanzhuSeqV2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x06027C27 RID: 162855 RVA: 0x0099A917 File Offset: 0x00998B17
		// (set) Token: 0x06027C28 RID: 162856 RVA: 0x0099A927 File Offset: 0x00998B27
		public unsafe float BP_NanzhuSeqV2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x06027C29 RID: 162857 RVA: 0x0099A938 File Offset: 0x00998B38
		// (set) Token: 0x06027C2A RID: 162858 RVA: 0x0099A948 File Offset: 0x00998B48
		public unsafe float BP_NanzhuSeqV2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x06027C2B RID: 162859 RVA: 0x0099A959 File Offset: 0x00998B59
		// (set) Token: 0x06027C2C RID: 162860 RVA: 0x0099A969 File Offset: 0x00998B69
		public unsafe bool BP_NanzhuSeqV2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x06027C2D RID: 162861 RVA: 0x0099A97A File Offset: 0x00998B7A
		// (set) Token: 0x06027C2E RID: 162862 RVA: 0x0099A98E File Offset: 0x00998B8E
		public unsafe AActor BP_NvzhuSeqV2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_40);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x06027C2F RID: 162863 RVA: 0x0099A9A3 File Offset: 0x00998BA3
		// (set) Token: 0x06027C30 RID: 162864 RVA: 0x0099A9B3 File Offset: 0x00998BB3
		public unsafe float BP_NvzhuSeqV2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x06027C31 RID: 162865 RVA: 0x0099A9C4 File Offset: 0x00998BC4
		// (set) Token: 0x06027C32 RID: 162866 RVA: 0x0099A9D4 File Offset: 0x00998BD4
		public unsafe float BP_NvzhuSeqV2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x06027C33 RID: 162867 RVA: 0x0099A9E5 File Offset: 0x00998BE5
		// (set) Token: 0x06027C34 RID: 162868 RVA: 0x0099A9F5 File Offset: 0x00998BF5
		public unsafe float BP_NvzhuSeqV2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x06027C35 RID: 162869 RVA: 0x0099AA06 File Offset: 0x00998C06
		// (set) Token: 0x06027C36 RID: 162870 RVA: 0x0099AA16 File Offset: 0x00998C16
		public unsafe bool BP_NvzhuSeqV2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x06027C37 RID: 162871 RVA: 0x0099AA27 File Offset: 0x00998C27
		// (set) Token: 0x06027C38 RID: 162872 RVA: 0x0099AA3B File Offset: 0x00998C3B
		public unsafe AActor Target_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_45);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x06027C39 RID: 162873 RVA: 0x0099AA50 File Offset: 0x00998C50
		// (set) Token: 0x06027C3A RID: 162874 RVA: 0x0099AA60 File Offset: 0x00998C60
		public unsafe float Target_1_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x06027C3B RID: 162875 RVA: 0x0099AA71 File Offset: 0x00998C71
		// (set) Token: 0x06027C3C RID: 162876 RVA: 0x0099AA81 File Offset: 0x00998C81
		public unsafe float Target_1_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x06027C3D RID: 162877 RVA: 0x0099AA92 File Offset: 0x00998C92
		// (set) Token: 0x06027C3E RID: 162878 RVA: 0x0099AAA2 File Offset: 0x00998CA2
		public unsafe float Target_1_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x06027C3F RID: 162879 RVA: 0x0099AAB3 File Offset: 0x00998CB3
		// (set) Token: 0x06027C40 RID: 162880 RVA: 0x0099AAC3 File Offset: 0x00998CC3
		public unsafe bool Target_1_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x06027C41 RID: 162881 RVA: 0x0099AAD4 File Offset: 0x00998CD4
		// (set) Token: 0x06027C42 RID: 162882 RVA: 0x0099AAE8 File Offset: 0x00998CE8
		public unsafe AActor Target_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x06027C43 RID: 162883 RVA: 0x0099AAFD File Offset: 0x00998CFD
		// (set) Token: 0x06027C44 RID: 162884 RVA: 0x0099AB0D File Offset: 0x00998D0D
		public unsafe float Target_2_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x06027C45 RID: 162885 RVA: 0x0099AB1E File Offset: 0x00998D1E
		// (set) Token: 0x06027C46 RID: 162886 RVA: 0x0099AB2E File Offset: 0x00998D2E
		public unsafe float Target_2_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x06027C47 RID: 162887 RVA: 0x0099AB3F File Offset: 0x00998D3F
		// (set) Token: 0x06027C48 RID: 162888 RVA: 0x0099AB4F File Offset: 0x00998D4F
		public unsafe float Target_2_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x06027C49 RID: 162889 RVA: 0x0099AB60 File Offset: 0x00998D60
		// (set) Token: 0x06027C4A RID: 162890 RVA: 0x0099AB70 File Offset: 0x00998D70
		public unsafe bool Target_2_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x06027C4B RID: 162891 RVA: 0x0099AB81 File Offset: 0x00998D81
		// (set) Token: 0x06027C4C RID: 162892 RVA: 0x0099AB95 File Offset: 0x00998D95
		public unsafe AActor Target_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_55);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x06027C4D RID: 162893 RVA: 0x0099ABAA File Offset: 0x00998DAA
		// (set) Token: 0x06027C4E RID: 162894 RVA: 0x0099ABBA File Offset: 0x00998DBA
		public unsafe float Target_3_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x06027C4F RID: 162895 RVA: 0x0099ABCB File Offset: 0x00998DCB
		// (set) Token: 0x06027C50 RID: 162896 RVA: 0x0099ABDB File Offset: 0x00998DDB
		public unsafe float Target_3_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x06027C51 RID: 162897 RVA: 0x0099ABEC File Offset: 0x00998DEC
		// (set) Token: 0x06027C52 RID: 162898 RVA: 0x0099ABFC File Offset: 0x00998DFC
		public unsafe float Target_3_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x06027C53 RID: 162899 RVA: 0x0099AC0D File Offset: 0x00998E0D
		// (set) Token: 0x06027C54 RID: 162900 RVA: 0x0099AC1D File Offset: 0x00998E1D
		public unsafe bool Target_3_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x06027C55 RID: 162901 RVA: 0x0099AC2E File Offset: 0x00998E2E
		// (set) Token: 0x06027C56 RID: 162902 RVA: 0x0099AC42 File Offset: 0x00998E42
		public unsafe AActor Target_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_60);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_60, value);
			}
		}

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x06027C57 RID: 162903 RVA: 0x0099AC57 File Offset: 0x00998E57
		// (set) Token: 0x06027C58 RID: 162904 RVA: 0x0099AC67 File Offset: 0x00998E67
		public unsafe float Target_4_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x06027C59 RID: 162905 RVA: 0x0099AC78 File Offset: 0x00998E78
		// (set) Token: 0x06027C5A RID: 162906 RVA: 0x0099AC88 File Offset: 0x00998E88
		public unsafe float Target_4_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x06027C5B RID: 162907 RVA: 0x0099AC99 File Offset: 0x00998E99
		// (set) Token: 0x06027C5C RID: 162908 RVA: 0x0099ACA9 File Offset: 0x00998EA9
		public unsafe float Target_4_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_63);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_63) = value;
			}
		}

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x06027C5D RID: 162909 RVA: 0x0099ACBA File Offset: 0x00998EBA
		// (set) Token: 0x06027C5E RID: 162910 RVA: 0x0099ACCA File Offset: 0x00998ECA
		public unsafe bool Target_4_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_64) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_64) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x06027C5F RID: 162911 RVA: 0x0099ACDB File Offset: 0x00998EDB
		// (set) Token: 0x06027C60 RID: 162912 RVA: 0x0099ACEF File Offset: 0x00998EEF
		public unsafe AActor Target_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_65);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_65, value);
			}
		}

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x06027C61 RID: 162913 RVA: 0x0099AD04 File Offset: 0x00998F04
		// (set) Token: 0x06027C62 RID: 162914 RVA: 0x0099AD14 File Offset: 0x00998F14
		public unsafe float Target_5_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x06027C63 RID: 162915 RVA: 0x0099AD25 File Offset: 0x00998F25
		// (set) Token: 0x06027C64 RID: 162916 RVA: 0x0099AD35 File Offset: 0x00998F35
		public unsafe float Target_5_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_67);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_67) = value;
			}
		}

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x06027C65 RID: 162917 RVA: 0x0099AD46 File Offset: 0x00998F46
		// (set) Token: 0x06027C66 RID: 162918 RVA: 0x0099AD56 File Offset: 0x00998F56
		public unsafe float Target_5_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x06027C67 RID: 162919 RVA: 0x0099AD67 File Offset: 0x00998F67
		// (set) Token: 0x06027C68 RID: 162920 RVA: 0x0099AD77 File Offset: 0x00998F77
		public unsafe bool Target_5_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x06027C69 RID: 162921 RVA: 0x0099AD88 File Offset: 0x00998F88
		// (set) Token: 0x06027C6A RID: 162922 RVA: 0x0099AD9C File Offset: 0x00998F9C
		public unsafe AActor Target_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cinematics_Tick_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x06027C6B RID: 162923 RVA: 0x0099ADB1 File Offset: 0x00998FB1
		// (set) Token: 0x06027C6C RID: 162924 RVA: 0x0099ADC1 File Offset: 0x00998FC1
		public unsafe float Target_6_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_71);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x06027C6D RID: 162925 RVA: 0x0099ADD2 File Offset: 0x00998FD2
		// (set) Token: 0x06027C6E RID: 162926 RVA: 0x0099ADE2 File Offset: 0x00998FE2
		public unsafe float Target_6_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x06027C6F RID: 162927 RVA: 0x0099ADF3 File Offset: 0x00998FF3
		// (set) Token: 0x06027C70 RID: 162928 RVA: 0x0099AE03 File Offset: 0x00999003
		public unsafe float Target_6_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x06027C71 RID: 162929 RVA: 0x0099AE14 File Offset: 0x00999014
		// (set) Token: 0x06027C72 RID: 162930 RVA: 0x0099AE24 File Offset: 0x00999024
		public unsafe bool IsHideMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x06027C73 RID: 162931 RVA: 0x0099AE35 File Offset: 0x00999035
		// (set) Token: 0x06027C74 RID: 162932 RVA: 0x0099AE45 File Offset: 0x00999045
		public unsafe bool IsHideEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_75) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_75) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x06027C75 RID: 162933 RVA: 0x0099AE56 File Offset: 0x00999056
		// (set) Token: 0x06027C76 RID: 162934 RVA: 0x0099AE66 File Offset: 0x00999066
		public unsafe float LightShakeSpeed_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x06027C77 RID: 162935 RVA: 0x0099AE77 File Offset: 0x00999077
		// (set) Token: 0x06027C78 RID: 162936 RVA: 0x0099AE87 File Offset: 0x00999087
		public unsafe float LightShakeSpeed_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x06027C79 RID: 162937 RVA: 0x0099AE98 File Offset: 0x00999098
		// (set) Token: 0x06027C7A RID: 162938 RVA: 0x0099AEA8 File Offset: 0x009990A8
		public unsafe float LightShakePositionX_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x06027C7B RID: 162939 RVA: 0x0099AEB9 File Offset: 0x009990B9
		// (set) Token: 0x06027C7C RID: 162940 RVA: 0x0099AEC9 File Offset: 0x009990C9
		public unsafe float LightShakePositionX_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x06027C7D RID: 162941 RVA: 0x0099AEDA File Offset: 0x009990DA
		// (set) Token: 0x06027C7E RID: 162942 RVA: 0x0099AEEA File Offset: 0x009990EA
		public unsafe float LightShakePositionY_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_80);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_80) = value;
			}
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x06027C7F RID: 162943 RVA: 0x0099AEFB File Offset: 0x009990FB
		// (set) Token: 0x06027C80 RID: 162944 RVA: 0x0099AF0B File Offset: 0x0099910B
		public unsafe float LightShakePositionY_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x06027C81 RID: 162945 RVA: 0x0099AF1C File Offset: 0x0099911C
		// (set) Token: 0x06027C82 RID: 162946 RVA: 0x0099AF2C File Offset: 0x0099912C
		public unsafe float LightShakeScale_Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x06027C83 RID: 162947 RVA: 0x0099AF3D File Offset: 0x0099913D
		// (set) Token: 0x06027C84 RID: 162948 RVA: 0x0099AF4D File Offset: 0x0099914D
		public unsafe float LightShakeScale_Float_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x06027C85 RID: 162949 RVA: 0x0099AF5E File Offset: 0x0099915E
		// (set) Token: 0x06027C86 RID: 162950 RVA: 0x0099AF72 File Offset: 0x00999172
		public unsafe FVector MainTexColorTint_Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x06027C87 RID: 162951 RVA: 0x0099AF87 File Offset: 0x00999187
		// (set) Token: 0x06027C88 RID: 162952 RVA: 0x0099AF9B File Offset: 0x0099919B
		public unsafe FVector MainTexColorTint_Vector_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x06027C89 RID: 162953 RVA: 0x0099AFB0 File Offset: 0x009991B0
		// (set) Token: 0x06027C8A RID: 162954 RVA: 0x0099AFC0 File Offset: 0x009991C0
		public unsafe bool MaterialControllerToggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_86) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_86) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x06027C8B RID: 162955 RVA: 0x0099AFD1 File Offset: 0x009991D1
		// (set) Token: 0x06027C8C RID: 162956 RVA: 0x0099AFE1 File Offset: 0x009991E1
		public unsafe bool ReceiveRoleLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_87) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_87) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x06027C8D RID: 162957 RVA: 0x0099AFF2 File Offset: 0x009991F2
		// (set) Token: 0x06027C8E RID: 162958 RVA: 0x0099B002 File Offset: 0x00999202
		public unsafe bool IsDisableCameraCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_88) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_88) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x06027C8F RID: 162959 RVA: 0x0099B013 File Offset: 0x00999213
		// (set) Token: 0x06027C90 RID: 162960 RVA: 0x0099B023 File Offset: 0x00999223
		public unsafe bool IsAutonomousHideMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_89) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_89) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x06027C91 RID: 162961 RVA: 0x0099B034 File Offset: 0x00999234
		// (set) Token: 0x06027C92 RID: 162962 RVA: 0x0099B044 File Offset: 0x00999244
		public unsafe bool IsAutonomousHideEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_90) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_90) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x06027C93 RID: 162963 RVA: 0x0099B055 File Offset: 0x00999255
		// (set) Token: 0x06027C94 RID: 162964 RVA: 0x0099B065 File Offset: 0x00999265
		public unsafe bool IsAutonomousHideNpcMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_91) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_91) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x06027C95 RID: 162965 RVA: 0x0099B076 File Offset: 0x00999276
		// (set) Token: 0x06027C96 RID: 162966 RVA: 0x0099B086 File Offset: 0x00999286
		public unsafe bool IsAutonomousHideNpcEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_92) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_92) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x06027C97 RID: 162967 RVA: 0x0099B097 File Offset: 0x00999297
		// (set) Token: 0x06027C98 RID: 162968 RVA: 0x0099B0A7 File Offset: 0x009992A7
		public unsafe bool IsHideNpcMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_93) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_93) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x06027C99 RID: 162969 RVA: 0x0099B0B8 File Offset: 0x009992B8
		// (set) Token: 0x06027C9A RID: 162970 RVA: 0x0099B0C8 File Offset: 0x009992C8
		public unsafe bool IsHideNpcEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_94) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_94) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x06027C9B RID: 162971 RVA: 0x0099B0D9 File Offset: 0x009992D9
		// (set) Token: 0x06027C9C RID: 162972 RVA: 0x0099B0E9 File Offset: 0x009992E9
		public unsafe float HideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x06027C9D RID: 162973 RVA: 0x0099B0FA File Offset: 0x009992FA
		// (set) Token: 0x06027C9E RID: 162974 RVA: 0x0099B10E File Offset: 0x0099930E
		[Nullable(1)]
		public unsafe string BasisBoneName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_96)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_96)), value);
			}
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x06027C9F RID: 162975 RVA: 0x0099B123 File Offset: 0x00999323
		// (set) Token: 0x06027CA0 RID: 162976 RVA: 0x0099B133 File Offset: 0x00999333
		public unsafe bool Target_6_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_97) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_97) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x06027CA1 RID: 162977 RVA: 0x0099B144 File Offset: 0x00999344
		// (set) Token: 0x06027CA2 RID: 162978 RVA: 0x0099B154 File Offset: 0x00999354
		public unsafe bool LightYawNotAddRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_98) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_98) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x06027CA3 RID: 162979 RVA: 0x0099B165 File Offset: 0x00999365
		// (set) Token: 0x06027CA4 RID: 162980 RVA: 0x0099B179 File Offset: 0x00999379
		public unsafe FVector2D SubCameraSize1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x06027CA5 RID: 162981 RVA: 0x0099B18E File Offset: 0x0099938E
		// (set) Token: 0x06027CA6 RID: 162982 RVA: 0x0099B1A2 File Offset: 0x009993A2
		[Nullable(1)]
		public unsafe string SubCameraName1
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_100)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_100)), value);
			}
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x06027CA7 RID: 162983 RVA: 0x0099B1B7 File Offset: 0x009993B7
		// (set) Token: 0x06027CA8 RID: 162984 RVA: 0x0099B1CB File Offset: 0x009993CB
		public unsafe FVector2D SubCameraLocation1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x06027CA9 RID: 162985 RVA: 0x0099B1E0 File Offset: 0x009993E0
		// (set) Token: 0x06027CAA RID: 162986 RVA: 0x0099B1F4 File Offset: 0x009993F4
		public unsafe FVector2D SubCameraSize2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x06027CAB RID: 162987 RVA: 0x0099B209 File Offset: 0x00999409
		// (set) Token: 0x06027CAC RID: 162988 RVA: 0x0099B21D File Offset: 0x0099941D
		[Nullable(1)]
		public unsafe string SubCameraName2
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_103)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_103)), value);
			}
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x06027CAD RID: 162989 RVA: 0x0099B232 File Offset: 0x00999432
		// (set) Token: 0x06027CAE RID: 162990 RVA: 0x0099B246 File Offset: 0x00999446
		public unsafe FVector2D SubCameraLocation2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x06027CAF RID: 162991 RVA: 0x0099B25B File Offset: 0x0099945B
		// (set) Token: 0x06027CB0 RID: 162992 RVA: 0x0099B26B File Offset: 0x0099946B
		public unsafe bool SeamlessSubCamera1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_105) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_105) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x06027CB1 RID: 162993 RVA: 0x0099B27C File Offset: 0x0099947C
		// (set) Token: 0x06027CB2 RID: 162994 RVA: 0x0099B28C File Offset: 0x0099948C
		public unsafe bool SeamlessSubCamera2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_106) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cinematics_Tick_C.__PropertyOffset_106) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027CB3 RID: 162995 RVA: 0x0099B29D File Offset: 0x0099949D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSeparateCamera()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateSeparateCamera_NativeFunctionPtr, null);
		}

		// Token: 0x06027CB4 RID: 162996 RVA: 0x0099B2B4 File Offset: 0x009994B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCameraCollision(AActor InActor, bool IsDisableCameraCollision)
		{
			BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__UpdateCameraCollision_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__UpdateCameraCollision_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsDisableCameraCollision = IsDisableCameraCollision;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateCameraCollision_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CB5 RID: 162997 RVA: 0x0099B310 File Offset: 0x00999510
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_Cinematics_Tick_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EulerToForward_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027CB6 RID: 162998 RVA: 0x0099B364 File Offset: 0x00999564
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMeshAndEffectState([Nullable(2)] AActor InActor, bool IsHideMesh, bool IsHideEffect, bool isDestroyed, bool IsHideNpcMesh, bool IsHideNpcEffect, float HideDistance, string BasisBoneName)
		{
			BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsHideMesh = IsHideMesh;
			ptr->IsHideEffect = IsHideEffect;
			ptr->isDestroyed = isDestroyed;
			ptr->IsHideNpcMesh = IsHideNpcMesh;
			ptr->IsHideNpcEffect = IsHideNpcEffect;
			ptr->HideDistance = HideDistance;
			FString.CopyFrom((void*)(&ptr->BasisBoneName), BasisBoneName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_Cinematics_Tick_C.__UpdateMeshAndEffectState_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027CB7 RID: 162999 RVA: 0x0099B408 File Offset: 0x00999608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetActorLight(AActor InActor, float LightYaw, float LightPitch, float FaceLightYaw, bool IsRevert, bool UsePointLight)
		{
			BP_Cinematics_Tick_C.__SetActorLight_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__SetActorLight_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__SetActorLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__SetActorLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->IsRevert = IsRevert;
			ptr->UsePointLight = UsePointLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__SetActorLight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CB8 RID: 163000 RVA: 0x0099B488 File Offset: 0x00999688
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProcessCombinNPC(BP_SeqNPC_C Mesh, float LightYaw, float FaceLightYaw)
		{
			BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ProcessCombinNPC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ProcessCombinNPC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ProcessCombinNPC_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CB9 RID: 163001 RVA: 0x0099B4EC File Offset: 0x009996EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RevertLightDirection(USkeletalMeshComponent Mesh)
		{
			BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__RevertLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CBA RID: 163002 RVA: 0x0099B544 File Offset: 0x00999744
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLightDirection(USkeletalMeshComponent Mesh, float LightYaw, float LightPitch, float FaceLightYaw, bool UsePointLight)
		{
			BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__SetLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->UsePointLight = UsePointLight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CBB RID: 163003 RVA: 0x0099B5B7 File Offset: 0x009997B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027CBC RID: 163004 RVA: 0x0099B5CB File Offset: 0x009997CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027CBD RID: 163005 RVA: 0x0099B5E0 File Offset: 0x009997E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CBE RID: 163006 RVA: 0x0099B628 File Offset: 0x00999828
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027CBF RID: 163007 RVA: 0x0099B670 File Offset: 0x00999870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027CC0 RID: 163008 RVA: 0x0099B6B8 File Offset: 0x009998B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cinematics_Tick_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cinematics_Tick_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cinematics_Tick_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027CC1 RID: 163009 RVA: 0x0099B6FF File Offset: 0x009998FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06027CC2 RID: 163010 RVA: 0x0099B713 File Offset: 0x00999913
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027CC3 RID: 163011 RVA: 0x0099B728 File Offset: 0x00999928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027CC4 RID: 163012 RVA: 0x0099B73C File Offset: 0x0099993C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cinematics_Tick_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027CC5 RID: 163013 RVA: 0x0099B751 File Offset: 0x00999951
		protected BP_Cinematics_Tick_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040141F2 RID: 82418
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_Cinematics_Tick.BP_Cinematics_Tick_C";

		// Token: 0x040141F3 RID: 82419
		private static IntPtr _ClassPtr;

		// Token: 0x040141F4 RID: 82420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040141F5 RID: 82421
		internal static int __PropertyOffset_1;

		// Token: 0x040141F6 RID: 82422
		internal static int __PropertyOffset_2;

		// Token: 0x040141F7 RID: 82423
		internal static int __PropertyOffset_3;

		// Token: 0x040141F8 RID: 82424
		internal static int __PropertyOffset_4;

		// Token: 0x040141F9 RID: 82425
		internal static int __PropertyOffset_5;

		// Token: 0x040141FA RID: 82426
		internal static int __PropertyOffset_6;

		// Token: 0x040141FB RID: 82427
		internal static int __PropertyOffset_7;

		// Token: 0x040141FC RID: 82428
		internal static int __PropertyOffset_8;

		// Token: 0x040141FD RID: 82429
		internal static int __PropertyOffset_9;

		// Token: 0x040141FE RID: 82430
		internal static int __PropertyOffset_10;

		// Token: 0x040141FF RID: 82431
		internal static int __PropertyOffset_11;

		// Token: 0x04014200 RID: 82432
		internal static int __PropertyOffset_12;

		// Token: 0x04014201 RID: 82433
		internal static int __PropertyOffset_13;

		// Token: 0x04014202 RID: 82434
		internal static int __PropertyOffset_14;

		// Token: 0x04014203 RID: 82435
		internal static int __PropertyOffset_15;

		// Token: 0x04014204 RID: 82436
		internal static int __PropertyOffset_16;

		// Token: 0x04014205 RID: 82437
		internal static int __PropertyOffset_17;

		// Token: 0x04014206 RID: 82438
		internal static int __PropertyOffset_18;

		// Token: 0x04014207 RID: 82439
		internal static int __PropertyOffset_19;

		// Token: 0x04014208 RID: 82440
		internal static int __PropertyOffset_20;

		// Token: 0x04014209 RID: 82441
		internal static int __PropertyOffset_21;

		// Token: 0x0401420A RID: 82442
		internal static int __PropertyOffset_22;

		// Token: 0x0401420B RID: 82443
		internal static int __PropertyOffset_23;

		// Token: 0x0401420C RID: 82444
		internal static int __PropertyOffset_24;

		// Token: 0x0401420D RID: 82445
		internal static int __PropertyOffset_25;

		// Token: 0x0401420E RID: 82446
		internal static int __PropertyOffset_26;

		// Token: 0x0401420F RID: 82447
		internal static int __PropertyOffset_27;

		// Token: 0x04014210 RID: 82448
		internal static int __PropertyOffset_28;

		// Token: 0x04014211 RID: 82449
		internal static int __PropertyOffset_29;

		// Token: 0x04014212 RID: 82450
		internal static int __PropertyOffset_30;

		// Token: 0x04014213 RID: 82451
		internal static int __PropertyOffset_31;

		// Token: 0x04014214 RID: 82452
		internal static int __PropertyOffset_32;

		// Token: 0x04014215 RID: 82453
		internal static int __PropertyOffset_33;

		// Token: 0x04014216 RID: 82454
		internal static int __PropertyOffset_34;

		// Token: 0x04014217 RID: 82455
		internal static int __PropertyOffset_35;

		// Token: 0x04014218 RID: 82456
		internal static int __PropertyOffset_36;

		// Token: 0x04014219 RID: 82457
		internal static int __PropertyOffset_37;

		// Token: 0x0401421A RID: 82458
		internal static int __PropertyOffset_38;

		// Token: 0x0401421B RID: 82459
		internal static int __PropertyOffset_39;

		// Token: 0x0401421C RID: 82460
		internal static int __PropertyOffset_40;

		// Token: 0x0401421D RID: 82461
		internal static int __PropertyOffset_41;

		// Token: 0x0401421E RID: 82462
		internal static int __PropertyOffset_42;

		// Token: 0x0401421F RID: 82463
		internal static int __PropertyOffset_43;

		// Token: 0x04014220 RID: 82464
		internal static int __PropertyOffset_44;

		// Token: 0x04014221 RID: 82465
		internal static int __PropertyOffset_45;

		// Token: 0x04014222 RID: 82466
		internal static int __PropertyOffset_46;

		// Token: 0x04014223 RID: 82467
		internal static int __PropertyOffset_47;

		// Token: 0x04014224 RID: 82468
		internal static int __PropertyOffset_48;

		// Token: 0x04014225 RID: 82469
		internal static int __PropertyOffset_49;

		// Token: 0x04014226 RID: 82470
		internal static int __PropertyOffset_50;

		// Token: 0x04014227 RID: 82471
		internal static int __PropertyOffset_51;

		// Token: 0x04014228 RID: 82472
		internal static int __PropertyOffset_52;

		// Token: 0x04014229 RID: 82473
		internal static int __PropertyOffset_53;

		// Token: 0x0401422A RID: 82474
		internal static int __PropertyOffset_54;

		// Token: 0x0401422B RID: 82475
		internal static int __PropertyOffset_55;

		// Token: 0x0401422C RID: 82476
		internal static int __PropertyOffset_56;

		// Token: 0x0401422D RID: 82477
		internal static int __PropertyOffset_57;

		// Token: 0x0401422E RID: 82478
		internal static int __PropertyOffset_58;

		// Token: 0x0401422F RID: 82479
		internal static int __PropertyOffset_59;

		// Token: 0x04014230 RID: 82480
		internal static int __PropertyOffset_60;

		// Token: 0x04014231 RID: 82481
		internal static int __PropertyOffset_61;

		// Token: 0x04014232 RID: 82482
		internal static int __PropertyOffset_62;

		// Token: 0x04014233 RID: 82483
		internal static int __PropertyOffset_63;

		// Token: 0x04014234 RID: 82484
		internal static int __PropertyOffset_64;

		// Token: 0x04014235 RID: 82485
		internal static int __PropertyOffset_65;

		// Token: 0x04014236 RID: 82486
		internal static int __PropertyOffset_66;

		// Token: 0x04014237 RID: 82487
		internal static int __PropertyOffset_67;

		// Token: 0x04014238 RID: 82488
		internal static int __PropertyOffset_68;

		// Token: 0x04014239 RID: 82489
		internal static int __PropertyOffset_69;

		// Token: 0x0401423A RID: 82490
		internal static int __PropertyOffset_70;

		// Token: 0x0401423B RID: 82491
		internal static int __PropertyOffset_71;

		// Token: 0x0401423C RID: 82492
		internal static int __PropertyOffset_72;

		// Token: 0x0401423D RID: 82493
		internal static int __PropertyOffset_73;

		// Token: 0x0401423E RID: 82494
		internal static int __PropertyOffset_74;

		// Token: 0x0401423F RID: 82495
		internal static int __PropertyOffset_75;

		// Token: 0x04014240 RID: 82496
		internal static int __PropertyOffset_76;

		// Token: 0x04014241 RID: 82497
		internal static int __PropertyOffset_77;

		// Token: 0x04014242 RID: 82498
		internal static int __PropertyOffset_78;

		// Token: 0x04014243 RID: 82499
		internal static int __PropertyOffset_79;

		// Token: 0x04014244 RID: 82500
		internal static int __PropertyOffset_80;

		// Token: 0x04014245 RID: 82501
		internal static int __PropertyOffset_81;

		// Token: 0x04014246 RID: 82502
		internal static int __PropertyOffset_82;

		// Token: 0x04014247 RID: 82503
		internal static int __PropertyOffset_83;

		// Token: 0x04014248 RID: 82504
		internal static int __PropertyOffset_84;

		// Token: 0x04014249 RID: 82505
		internal static int __PropertyOffset_85;

		// Token: 0x0401424A RID: 82506
		internal static int __PropertyOffset_86;

		// Token: 0x0401424B RID: 82507
		internal static int __PropertyOffset_87;

		// Token: 0x0401424C RID: 82508
		internal static int __PropertyOffset_88;

		// Token: 0x0401424D RID: 82509
		internal static int __PropertyOffset_89;

		// Token: 0x0401424E RID: 82510
		internal static int __PropertyOffset_90;

		// Token: 0x0401424F RID: 82511
		internal static int __PropertyOffset_91;

		// Token: 0x04014250 RID: 82512
		internal static int __PropertyOffset_92;

		// Token: 0x04014251 RID: 82513
		internal static int __PropertyOffset_93;

		// Token: 0x04014252 RID: 82514
		internal static int __PropertyOffset_94;

		// Token: 0x04014253 RID: 82515
		internal static int __PropertyOffset_95;

		// Token: 0x04014254 RID: 82516
		internal static int __PropertyOffset_96;

		// Token: 0x04014255 RID: 82517
		internal static int __PropertyOffset_97;

		// Token: 0x04014256 RID: 82518
		internal static int __PropertyOffset_98;

		// Token: 0x04014257 RID: 82519
		internal static int __PropertyOffset_99;

		// Token: 0x04014258 RID: 82520
		internal static int __PropertyOffset_100;

		// Token: 0x04014259 RID: 82521
		internal static int __PropertyOffset_101;

		// Token: 0x0401425A RID: 82522
		internal static int __PropertyOffset_102;

		// Token: 0x0401425B RID: 82523
		internal static int __PropertyOffset_103;

		// Token: 0x0401425C RID: 82524
		internal static int __PropertyOffset_104;

		// Token: 0x0401425D RID: 82525
		internal static int __PropertyOffset_105;

		// Token: 0x0401425E RID: 82526
		internal static int __PropertyOffset_106;

		// Token: 0x0401425F RID: 82527
		private static IntPtr __UpdateSeparateCamera_NativeFunctionPtr;

		// Token: 0x04014260 RID: 82528
		private static IntPtr __UpdateCameraCollision_NativeFunctionPtr;

		// Token: 0x04014261 RID: 82529
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x04014262 RID: 82530
		private static IntPtr __UpdateMeshAndEffectState_NativeFunctionPtr;

		// Token: 0x04014263 RID: 82531
		private static IntPtr __SetActorLight_NativeFunctionPtr;

		// Token: 0x04014264 RID: 82532
		private static IntPtr __ProcessCombinNPC_NativeFunctionPtr;

		// Token: 0x04014265 RID: 82533
		private static IntPtr __RevertLightDirection_NativeFunctionPtr;

		// Token: 0x04014266 RID: 82534
		private static IntPtr __SetLightDirection_NativeFunctionPtr;

		// Token: 0x04014267 RID: 82535
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014268 RID: 82536
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014269 RID: 82537
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401426A RID: 82538
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401426B RID: 82539
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A284 RID: 41604
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateCameraCollision_FunctionParams
		{
			// Token: 0x04031F62 RID: 204642
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031F63 RID: 204643
			[FieldOffset(8)]
			public bool IsDisableCameraCollision;
		}

		// Token: 0x0200A285 RID: 41605
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031F64 RID: 204644
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031F65 RID: 204645
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031F66 RID: 204646
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x0200A286 RID: 41606
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __UpdateMeshAndEffectState_FunctionParams
		{
			// Token: 0x04031F67 RID: 204647
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031F68 RID: 204648
			[FieldOffset(8)]
			public bool IsHideMesh;

			// Token: 0x04031F69 RID: 204649
			[FieldOffset(9)]
			public bool IsHideEffect;

			// Token: 0x04031F6A RID: 204650
			[FieldOffset(10)]
			public bool isDestroyed;

			// Token: 0x04031F6B RID: 204651
			[FieldOffset(11)]
			public bool IsHideNpcMesh;

			// Token: 0x04031F6C RID: 204652
			[FieldOffset(12)]
			public bool IsHideNpcEffect;

			// Token: 0x04031F6D RID: 204653
			[FieldOffset(16)]
			public float HideDistance;

			// Token: 0x04031F6E RID: 204654
			[FieldOffset(24)]
			public FString BasisBoneName;
		}

		// Token: 0x0200A287 RID: 41607
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __SetActorLight_FunctionParams
		{
			// Token: 0x04031F6F RID: 204655
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031F70 RID: 204656
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x04031F71 RID: 204657
			[FieldOffset(12)]
			public float LightPitch;

			// Token: 0x04031F72 RID: 204658
			[FieldOffset(16)]
			public float FaceLightYaw;

			// Token: 0x04031F73 RID: 204659
			[FieldOffset(20)]
			public bool IsRevert;

			// Token: 0x04031F74 RID: 204660
			[FieldOffset(21)]
			public bool UsePointLight;
		}

		// Token: 0x0200A288 RID: 41608
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ProcessCombinNPC_FunctionParams
		{
			// Token: 0x04031F75 RID: 204661
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031F76 RID: 204662
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x04031F77 RID: 204663
			[FieldOffset(12)]
			public float FaceLightYaw;
		}

		// Token: 0x0200A289 RID: 41609
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RevertLightDirection_FunctionParams
		{
			// Token: 0x04031F78 RID: 204664
			[FieldOffset(0)]
			public IntPtr Mesh;
		}

		// Token: 0x0200A28A RID: 41610
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetLightDirection_FunctionParams
		{
			// Token: 0x04031F79 RID: 204665
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031F7A RID: 204666
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x04031F7B RID: 204667
			[FieldOffset(12)]
			public float LightPitch;

			// Token: 0x04031F7C RID: 204668
			[FieldOffset(16)]
			public float FaceLightYaw;

			// Token: 0x04031F7D RID: 204669
			[FieldOffset(20)]
			public bool UsePointLight;
		}

		// Token: 0x0200A28B RID: 41611
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031F7E RID: 204670
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A28C RID: 41612
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031F7F RID: 204671
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
