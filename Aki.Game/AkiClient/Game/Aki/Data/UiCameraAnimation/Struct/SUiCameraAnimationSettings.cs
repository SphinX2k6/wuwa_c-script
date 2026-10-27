using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003E8F RID: 16015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 446)]
	public class SUiCameraAnimationSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028727 RID: 165671 RVA: 0x009ACB86 File Offset: 0x009AAD86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraAnimationSettings._ScriptStructPtr != 0) ? SUiCameraAnimationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings", ref SUiCameraAnimationSettings._ScriptStructPtr);
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x06028728 RID: 165672 RVA: 0x009ACBAA File Offset: 0x009AADAA
		// (set) Token: 0x06028729 RID: 165673 RVA: 0x009ACBBA File Offset: 0x009AADBA
		public unsafe bool IsEmptyState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0602872A RID: 165674 RVA: 0x009ACBCB File Offset: 0x009AADCB
		// (set) Token: 0x0602872B RID: 165675 RVA: 0x009ACBDF File Offset: 0x009AADDF
		public unsafe string ReplaceCameraTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0602872C RID: 165676 RVA: 0x009ACBF4 File Offset: 0x009AADF4
		// (set) Token: 0x0602872D RID: 165677 RVA: 0x009ACC08 File Offset: 0x009AAE08
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x0602872E RID: 165678 RVA: 0x009ACC1D File Offset: 0x009AAE1D
		// (set) Token: 0x0602872F RID: 165679 RVA: 0x009ACC31 File Offset: 0x009AAE31
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x06028730 RID: 165680 RVA: 0x009ACC46 File Offset: 0x009AAE46
		// (set) Token: 0x06028731 RID: 165681 RVA: 0x009ACC5A File Offset: 0x009AAE5A
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationTargetType> TargetType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x06028732 RID: 165682 RVA: 0x009ACC6F File Offset: 0x009AAE6F
		// (set) Token: 0x06028733 RID: 165683 RVA: 0x009ACC83 File Offset: 0x009AAE83
		public unsafe string TargetActorTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x06028734 RID: 165684 RVA: 0x009ACC98 File Offset: 0x009AAE98
		// (set) Token: 0x06028735 RID: 165685 RVA: 0x009ACCAC File Offset: 0x009AAEAC
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationLocationType> LocationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x06028736 RID: 165686 RVA: 0x009ACCC1 File Offset: 0x009AAEC1
		// (set) Token: 0x06028737 RID: 165687 RVA: 0x009ACCD5 File Offset: 0x009AAED5
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x06028738 RID: 165688 RVA: 0x009ACCEA File Offset: 0x009AAEEA
		// (set) Token: 0x06028739 RID: 165689 RVA: 0x009ACCFE File Offset: 0x009AAEFE
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationRotationType> RotationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_8);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0602873A RID: 165690 RVA: 0x009ACD13 File Offset: 0x009AAF13
		// (set) Token: 0x0602873B RID: 165691 RVA: 0x009ACD27 File Offset: 0x009AAF27
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x0602873C RID: 165692 RVA: 0x009ACD3C File Offset: 0x009AAF3C
		// (set) Token: 0x0602873D RID: 165693 RVA: 0x009ACD4C File Offset: 0x009AAF4C
		public unsafe bool IsTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x0602873E RID: 165694 RVA: 0x009ACD5D File Offset: 0x009AAF5D
		// (set) Token: 0x0602873F RID: 165695 RVA: 0x009ACD6D File Offset: 0x009AAF6D
		public unsafe bool IsTrackWorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x06028740 RID: 165696 RVA: 0x009ACD7E File Offset: 0x009AAF7E
		// (set) Token: 0x06028741 RID: 165697 RVA: 0x009ACD8E File Offset: 0x009AAF8E
		public unsafe bool bOverrideTrackPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x06028742 RID: 165698 RVA: 0x009ACD9F File Offset: 0x009AAF9F
		// (set) Token: 0x06028743 RID: 165699 RVA: 0x009ACDAF File Offset: 0x009AAFAF
		public unsafe float TrackPitchOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x06028744 RID: 165700 RVA: 0x009ACDC0 File Offset: 0x009AAFC0
		// (set) Token: 0x06028745 RID: 165701 RVA: 0x009ACDD0 File Offset: 0x009AAFD0
		public unsafe bool bTargetActorAsCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DDB RID: 24027
		// (get) Token: 0x06028746 RID: 165702 RVA: 0x009ACDE1 File Offset: 0x009AAFE1
		// (set) Token: 0x06028747 RID: 165703 RVA: 0x009ACDF5 File Offset: 0x009AAFF5
		public unsafe FVector TrackLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005DDC RID: 24028
		// (get) Token: 0x06028748 RID: 165704 RVA: 0x009ACE0A File Offset: 0x009AB00A
		// (set) Token: 0x06028749 RID: 165705 RVA: 0x009ACE1A File Offset: 0x009AB01A
		public unsafe float ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x0602874A RID: 165706 RVA: 0x009ACE2B File Offset: 0x009AB02B
		// (set) Token: 0x0602874B RID: 165707 RVA: 0x009ACE3F File Offset: 0x009AB03F
		public unsafe FVector ArmOffsetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x0602874C RID: 165708 RVA: 0x009ACE54 File Offset: 0x009AB054
		// (set) Token: 0x0602874D RID: 165709 RVA: 0x009ACE68 File Offset: 0x009AB068
		public unsafe FRotator ArmOffsetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x0602874E RID: 165710 RVA: 0x009ACE7D File Offset: 0x009AB07D
		// (set) Token: 0x0602874F RID: 165711 RVA: 0x009ACE8D File Offset: 0x009AB08D
		public unsafe bool IsDynamicFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x06028750 RID: 165712 RVA: 0x009ACE9E File Offset: 0x009AB09E
		// (set) Token: 0x06028751 RID: 165713 RVA: 0x009ACEB2 File Offset: 0x009AB0B2
		public unsafe FIntPoint DynamicBaseResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x06028752 RID: 165714 RVA: 0x009ACEC7 File Offset: 0x009AB0C7
		// (set) Token: 0x06028753 RID: 165715 RVA: 0x009ACED7 File Offset: 0x009AB0D7
		public unsafe float CameraFieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x06028754 RID: 165716 RVA: 0x009ACEE8 File Offset: 0x009AB0E8
		// (set) Token: 0x06028755 RID: 165717 RVA: 0x009ACEF8 File Offset: 0x009AB0F8
		public unsafe bool ArmCollisionTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x06028756 RID: 165718 RVA: 0x009ACF09 File Offset: 0x009AB109
		// (set) Token: 0x06028757 RID: 165719 RVA: 0x009ACF19 File Offset: 0x009AB119
		public unsafe float FocalDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x06028758 RID: 165720 RVA: 0x009ACF2A File Offset: 0x009AB12A
		// (set) Token: 0x06028759 RID: 165721 RVA: 0x009ACF3A File Offset: 0x009AB13A
		public unsafe float Aperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x0602875A RID: 165722 RVA: 0x009ACF4B File Offset: 0x009AB14B
		// (set) Token: 0x0602875B RID: 165723 RVA: 0x009ACF5B File Offset: 0x009AB15B
		public unsafe float FocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x0602875C RID: 165724 RVA: 0x009ACF6C File Offset: 0x009AB16C
		// (set) Token: 0x0602875D RID: 165725 RVA: 0x009ACF7C File Offset: 0x009AB17C
		public unsafe float PostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x0602875E RID: 165726 RVA: 0x009ACF8D File Offset: 0x009AB18D
		// (set) Token: 0x0602875F RID: 165727 RVA: 0x009ACF9D File Offset: 0x009AB19D
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x06028760 RID: 165728 RVA: 0x009ACFAE File Offset: 0x009AB1AE
		// (set) Token: 0x06028761 RID: 165729 RVA: 0x009ACFBE File Offset: 0x009AB1BE
		public unsafe float BlendInExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x06028762 RID: 165730 RVA: 0x009ACFCF File Offset: 0x009AB1CF
		// (set) Token: 0x06028763 RID: 165731 RVA: 0x009ACFEE File Offset: 0x009AB1EE
		public TSoftObjectPtr<ULevelSequence> BlendInCameraSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_29, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_29, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x06028764 RID: 165732 RVA: 0x009AD013 File Offset: 0x009AB213
		// (set) Token: 0x06028765 RID: 165733 RVA: 0x009AD023 File Offset: 0x009AB223
		public unsafe float BlendInCameraSequencePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x06028766 RID: 165734 RVA: 0x009AD034 File Offset: 0x009AB234
		// (set) Token: 0x06028767 RID: 165735 RVA: 0x009AD044 File Offset: 0x009AB244
		public unsafe bool bRevertBlendInCameraSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x06028768 RID: 165736 RVA: 0x009AD055 File Offset: 0x009AB255
		// (set) Token: 0x06028769 RID: 165737 RVA: 0x009AD074 File Offset: 0x009AB274
		public TSoftObjectPtr<ULevelSequence> BlendOutCameraSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_32, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_32, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x0602876A RID: 165738 RVA: 0x009AD099 File Offset: 0x009AB299
		// (set) Token: 0x0602876B RID: 165739 RVA: 0x009AD0A9 File Offset: 0x009AB2A9
		public unsafe float BlendOutCameraSequencePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x0602876C RID: 165740 RVA: 0x009AD0BA File Offset: 0x009AB2BA
		// (set) Token: 0x0602876D RID: 165741 RVA: 0x009AD0CA File Offset: 0x009AB2CA
		public unsafe bool bRevertBlendOutCameraSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x0602876E RID: 165742 RVA: 0x009AD0DB File Offset: 0x009AB2DB
		// (set) Token: 0x0602876F RID: 165743 RVA: 0x009AD0EF File Offset: 0x009AB2EF
		[Nullable(0)]
		public unsafe TEnumAsByte<EViewTargetBlendFunction> BlendInFunction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_35);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x06028770 RID: 165744 RVA: 0x009AD104 File Offset: 0x009AB304
		// (set) Token: 0x06028771 RID: 165745 RVA: 0x009AD123 File Offset: 0x009AB323
		public TSoftObjectPtr<ULevelSequence> BlendInSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_36, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_36, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x06028772 RID: 165746 RVA: 0x009AD148 File Offset: 0x009AB348
		// (set) Token: 0x06028773 RID: 165747 RVA: 0x009AD158 File Offset: 0x009AB358
		public unsafe bool bBlendInSequenceReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x06028774 RID: 165748 RVA: 0x009AD169 File Offset: 0x009AB369
		// (set) Token: 0x06028775 RID: 165749 RVA: 0x009AD179 File Offset: 0x009AB379
		public unsafe float BlendInPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x06028776 RID: 165750 RVA: 0x009AD18A File Offset: 0x009AB38A
		// (set) Token: 0x06028777 RID: 165751 RVA: 0x009AD19A File Offset: 0x009AB39A
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x06028778 RID: 165752 RVA: 0x009AD1AB File Offset: 0x009AB3AB
		// (set) Token: 0x06028779 RID: 165753 RVA: 0x009AD1BB File Offset: 0x009AB3BB
		public unsafe float BlendOutExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x0602877A RID: 165754 RVA: 0x009AD1CC File Offset: 0x009AB3CC
		// (set) Token: 0x0602877B RID: 165755 RVA: 0x009AD1E0 File Offset: 0x009AB3E0
		[Nullable(0)]
		public unsafe TEnumAsByte<EViewTargetBlendFunction> BlendOutFunction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_41);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x0602877C RID: 165756 RVA: 0x009AD1F5 File Offset: 0x009AB3F5
		// (set) Token: 0x0602877D RID: 165757 RVA: 0x009AD214 File Offset: 0x009AB414
		public TSoftObjectPtr<ULevelSequence> BlendOutSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_42, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_42, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x0602877E RID: 165758 RVA: 0x009AD239 File Offset: 0x009AB439
		// (set) Token: 0x0602877F RID: 165759 RVA: 0x009AD249 File Offset: 0x009AB449
		public unsafe float BlendOutPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x06028780 RID: 165760 RVA: 0x009AD25A File Offset: 0x009AB45A
		// (set) Token: 0x06028781 RID: 165761 RVA: 0x009AD26A File Offset: 0x009AB46A
		public unsafe bool bBlendOutSequenceReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x06028782 RID: 165762 RVA: 0x009AD27B File Offset: 0x009AB47B
		// (set) Token: 0x06028783 RID: 165763 RVA: 0x009AD28B File Offset: 0x009AB48B
		public unsafe bool bResetCameraTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028784 RID: 165764 RVA: 0x009AD29C File Offset: 0x009AB49C
		public SUiCameraAnimationSettings()
		{
		}

		// Token: 0x06028785 RID: 165765 RVA: 0x009AD2A4 File Offset: 0x009AB4A4
		public SUiCameraAnimationSettings(bool IsEmptyState, string ReplaceCameraTag, string Description, string SocketName, [Nullable(0)] TEnumAsByte<EUiCameraAnimationTargetType> TargetType, string TargetActorTag, [Nullable(0)] TEnumAsByte<EUiCameraAnimationLocationType> LocationType, FVector Location, [Nullable(0)] TEnumAsByte<EUiCameraAnimationRotationType> RotationType, FRotator Rotation, bool IsTrack, bool IsTrackWorldLocation, bool bOverrideTrackPitch, float TrackPitchOverride, bool bTargetActorAsCenter, FVector TrackLocation, float ArmLength, FVector ArmOffsetLocation, FRotator ArmOffsetRotation, bool IsDynamicFov, FIntPoint DynamicBaseResolution, float CameraFieldOfView, bool ArmCollisionTest, float FocalDistance, float Aperture, float FocalRegion, float PostProcessBlendWeight, float BlendInTime, float BlendInExp, TSoftObjectPtr<ULevelSequence> BlendInCameraSequence, float BlendInCameraSequencePlayRate, bool bRevertBlendInCameraSequence, TSoftObjectPtr<ULevelSequence> BlendOutCameraSequence, float BlendOutCameraSequencePlayRate, bool bRevertBlendOutCameraSequence, [Nullable(0)] TEnumAsByte<EViewTargetBlendFunction> BlendInFunction, TSoftObjectPtr<ULevelSequence> BlendInSequence, bool bBlendInSequenceReverse, float BlendInPlayRate, float BlendOutTime, float BlendOutExp, [Nullable(0)] TEnumAsByte<EViewTargetBlendFunction> BlendOutFunction, TSoftObjectPtr<ULevelSequence> BlendOutSequence, float BlendOutPlayRate, bool bBlendOutSequenceReverse, bool bResetCameraTransform)
		{
			this.IsEmptyState = IsEmptyState;
			this.ReplaceCameraTag = ReplaceCameraTag;
			this.Description = Description;
			this.SocketName = SocketName;
			this.TargetType = TargetType;
			this.TargetActorTag = TargetActorTag;
			this.LocationType = LocationType;
			this.Location = Location;
			this.RotationType = RotationType;
			this.Rotation = Rotation;
			this.IsTrack = IsTrack;
			this.IsTrackWorldLocation = IsTrackWorldLocation;
			this.bOverrideTrackPitch = bOverrideTrackPitch;
			this.TrackPitchOverride = TrackPitchOverride;
			this.bTargetActorAsCenter = bTargetActorAsCenter;
			this.TrackLocation = TrackLocation;
			this.ArmLength = ArmLength;
			this.ArmOffsetLocation = ArmOffsetLocation;
			this.ArmOffsetRotation = ArmOffsetRotation;
			this.IsDynamicFov = IsDynamicFov;
			this.DynamicBaseResolution = DynamicBaseResolution;
			this.CameraFieldOfView = CameraFieldOfView;
			this.ArmCollisionTest = ArmCollisionTest;
			this.FocalDistance = FocalDistance;
			this.Aperture = Aperture;
			this.FocalRegion = FocalRegion;
			this.PostProcessBlendWeight = PostProcessBlendWeight;
			this.BlendInTime = BlendInTime;
			this.BlendInExp = BlendInExp;
			this.BlendInCameraSequence = BlendInCameraSequence;
			this.BlendInCameraSequencePlayRate = BlendInCameraSequencePlayRate;
			this.bRevertBlendInCameraSequence = bRevertBlendInCameraSequence;
			this.BlendOutCameraSequence = BlendOutCameraSequence;
			this.BlendOutCameraSequencePlayRate = BlendOutCameraSequencePlayRate;
			this.bRevertBlendOutCameraSequence = bRevertBlendOutCameraSequence;
			this.BlendInFunction = BlendInFunction;
			this.BlendInSequence = BlendInSequence;
			this.bBlendInSequenceReverse = bBlendInSequenceReverse;
			this.BlendInPlayRate = BlendInPlayRate;
			this.BlendOutTime = BlendOutTime;
			this.BlendOutExp = BlendOutExp;
			this.BlendOutFunction = BlendOutFunction;
			this.BlendOutSequence = BlendOutSequence;
			this.BlendOutPlayRate = BlendOutPlayRate;
			this.bBlendOutSequenceReverse = bBlendOutSequenceReverse;
			this.bResetCameraTransform = bResetCameraTransform;
		}

		// Token: 0x06028786 RID: 165766 RVA: 0x009AD424 File Offset: 0x009AB624
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraAnimationSettings.StaticStruct();
		}

		// Token: 0x06028787 RID: 165767 RVA: 0x009AD430 File Offset: 0x009AB630
		[NullableContext(2)]
		public SUiCameraAnimationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028788 RID: 165768 RVA: 0x009AD43A File Offset: 0x009AB63A
		public SUiCameraAnimationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028789 RID: 165769 RVA: 0x009AD445 File Offset: 0x009AB645
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraAnimationSettings(Pointer, false, true);
		}

		// Token: 0x0602878A RID: 165770 RVA: 0x009AD44F File Offset: 0x009AB64F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraAnimationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040149F6 RID: 84470
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings";

		// Token: 0x040149F7 RID: 84471
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149F8 RID: 84472
		internal static int __PropertyOffset_0;

		// Token: 0x040149F9 RID: 84473
		internal static int __PropertyOffset_1;

		// Token: 0x040149FA RID: 84474
		internal static int __PropertyOffset_2;

		// Token: 0x040149FB RID: 84475
		internal static int __PropertyOffset_3;

		// Token: 0x040149FC RID: 84476
		internal static int __PropertyOffset_4;

		// Token: 0x040149FD RID: 84477
		internal static int __PropertyOffset_5;

		// Token: 0x040149FE RID: 84478
		internal static int __PropertyOffset_6;

		// Token: 0x040149FF RID: 84479
		internal static int __PropertyOffset_7;

		// Token: 0x04014A00 RID: 84480
		internal static int __PropertyOffset_8;

		// Token: 0x04014A01 RID: 84481
		internal static int __PropertyOffset_9;

		// Token: 0x04014A02 RID: 84482
		internal static int __PropertyOffset_10;

		// Token: 0x04014A03 RID: 84483
		internal static int __PropertyOffset_11;

		// Token: 0x04014A04 RID: 84484
		internal static int __PropertyOffset_12;

		// Token: 0x04014A05 RID: 84485
		internal static int __PropertyOffset_13;

		// Token: 0x04014A06 RID: 84486
		internal static int __PropertyOffset_14;

		// Token: 0x04014A07 RID: 84487
		internal static int __PropertyOffset_15;

		// Token: 0x04014A08 RID: 84488
		internal static int __PropertyOffset_16;

		// Token: 0x04014A09 RID: 84489
		internal static int __PropertyOffset_17;

		// Token: 0x04014A0A RID: 84490
		internal static int __PropertyOffset_18;

		// Token: 0x04014A0B RID: 84491
		internal static int __PropertyOffset_19;

		// Token: 0x04014A0C RID: 84492
		internal static int __PropertyOffset_20;

		// Token: 0x04014A0D RID: 84493
		internal static int __PropertyOffset_21;

		// Token: 0x04014A0E RID: 84494
		internal static int __PropertyOffset_22;

		// Token: 0x04014A0F RID: 84495
		internal static int __PropertyOffset_23;

		// Token: 0x04014A10 RID: 84496
		internal static int __PropertyOffset_24;

		// Token: 0x04014A11 RID: 84497
		internal static int __PropertyOffset_25;

		// Token: 0x04014A12 RID: 84498
		internal static int __PropertyOffset_26;

		// Token: 0x04014A13 RID: 84499
		internal static int __PropertyOffset_27;

		// Token: 0x04014A14 RID: 84500
		internal static int __PropertyOffset_28;

		// Token: 0x04014A15 RID: 84501
		internal static int __PropertyOffset_29;

		// Token: 0x04014A16 RID: 84502
		internal static int __PropertyOffset_30;

		// Token: 0x04014A17 RID: 84503
		internal static int __PropertyOffset_31;

		// Token: 0x04014A18 RID: 84504
		internal static int __PropertyOffset_32;

		// Token: 0x04014A19 RID: 84505
		internal static int __PropertyOffset_33;

		// Token: 0x04014A1A RID: 84506
		internal static int __PropertyOffset_34;

		// Token: 0x04014A1B RID: 84507
		internal static int __PropertyOffset_35;

		// Token: 0x04014A1C RID: 84508
		internal static int __PropertyOffset_36;

		// Token: 0x04014A1D RID: 84509
		internal static int __PropertyOffset_37;

		// Token: 0x04014A1E RID: 84510
		internal static int __PropertyOffset_38;

		// Token: 0x04014A1F RID: 84511
		internal static int __PropertyOffset_39;

		// Token: 0x04014A20 RID: 84512
		internal static int __PropertyOffset_40;

		// Token: 0x04014A21 RID: 84513
		internal static int __PropertyOffset_41;

		// Token: 0x04014A22 RID: 84514
		internal static int __PropertyOffset_42;

		// Token: 0x04014A23 RID: 84515
		internal static int __PropertyOffset_43;

		// Token: 0x04014A24 RID: 84516
		internal static int __PropertyOffset_44;

		// Token: 0x04014A25 RID: 84517
		internal static int __PropertyOffset_45;
	}
}
