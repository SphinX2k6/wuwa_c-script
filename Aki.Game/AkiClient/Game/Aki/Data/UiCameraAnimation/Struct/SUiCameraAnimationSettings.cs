using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003166 RID: 12646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 446)]
	public class SUiCameraAnimationSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F289 RID: 127625 RVA: 0x00927A81 File Offset: 0x00925C81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraAnimationSettings._ScriptStructPtr != 0) ? SUiCameraAnimationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings", ref SUiCameraAnimationSettings._ScriptStructPtr);
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0601F28A RID: 127626 RVA: 0x00927AA5 File Offset: 0x00925CA5
		// (set) Token: 0x0601F28B RID: 127627 RVA: 0x00927AB5 File Offset: 0x00925CB5
		public unsafe bool IsEmptyState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsEmptyState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsEmptyState) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0601F28C RID: 127628 RVA: 0x00927AC6 File Offset: 0x00925CC6
		// (set) Token: 0x0601F28D RID: 127629 RVA: 0x00927ADA File Offset: 0x00925CDA
		public unsafe string ReplaceCameraTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ReplaceCameraTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ReplaceCameraTag)), value);
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0601F28E RID: 127630 RVA: 0x00927AEF File Offset: 0x00925CEF
		// (set) Token: 0x0601F28F RID: 127631 RVA: 0x00927B03 File Offset: 0x00925D03
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0601F290 RID: 127632 RVA: 0x00927B18 File Offset: 0x00925D18
		// (set) Token: 0x0601F291 RID: 127633 RVA: 0x00927B2C File Offset: 0x00925D2C
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_SocketName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_SocketName)), value);
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0601F292 RID: 127634 RVA: 0x00927B41 File Offset: 0x00925D41
		// (set) Token: 0x0601F293 RID: 127635 RVA: 0x00927B55 File Offset: 0x00925D55
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationTargetType> TargetType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TargetType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TargetType) = value;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0601F294 RID: 127636 RVA: 0x00927B6A File Offset: 0x00925D6A
		// (set) Token: 0x0601F295 RID: 127637 RVA: 0x00927B7E File Offset: 0x00925D7E
		public unsafe string TargetActorTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TargetActorTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TargetActorTag)), value);
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0601F296 RID: 127638 RVA: 0x00927B93 File Offset: 0x00925D93
		// (set) Token: 0x0601F297 RID: 127639 RVA: 0x00927BA7 File Offset: 0x00925DA7
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationLocationType> LocationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_LocationType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_LocationType) = value;
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0601F298 RID: 127640 RVA: 0x00927BBC File Offset: 0x00925DBC
		// (set) Token: 0x0601F299 RID: 127641 RVA: 0x00927BD0 File Offset: 0x00925DD0
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0601F29A RID: 127642 RVA: 0x00927BE5 File Offset: 0x00925DE5
		// (set) Token: 0x0601F29B RID: 127643 RVA: 0x00927BF9 File Offset: 0x00925DF9
		[Nullable(0)]
		public unsafe TEnumAsByte<EUiCameraAnimationRotationType> RotationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_RotationType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_RotationType) = value;
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0601F29C RID: 127644 RVA: 0x00927C0E File Offset: 0x00925E0E
		// (set) Token: 0x0601F29D RID: 127645 RVA: 0x00927C22 File Offset: 0x00925E22
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0601F29E RID: 127646 RVA: 0x00927C37 File Offset: 0x00925E37
		// (set) Token: 0x0601F29F RID: 127647 RVA: 0x00927C47 File Offset: 0x00925E47
		public unsafe bool IsTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0601F2A0 RID: 127648 RVA: 0x00927C58 File Offset: 0x00925E58
		// (set) Token: 0x0601F2A1 RID: 127649 RVA: 0x00927C68 File Offset: 0x00925E68
		public unsafe bool IsTrackWorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsTrackWorldLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsTrackWorldLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0601F2A2 RID: 127650 RVA: 0x00927C79 File Offset: 0x00925E79
		// (set) Token: 0x0601F2A3 RID: 127651 RVA: 0x00927C89 File Offset: 0x00925E89
		public unsafe bool bOverrideTrackPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bOverrideTrackPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bOverrideTrackPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0601F2A4 RID: 127652 RVA: 0x00927C9A File Offset: 0x00925E9A
		// (set) Token: 0x0601F2A5 RID: 127653 RVA: 0x00927CAA File Offset: 0x00925EAA
		public unsafe float TrackPitchOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TrackPitchOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TrackPitchOverride) = value;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0601F2A6 RID: 127654 RVA: 0x00927CBB File Offset: 0x00925EBB
		// (set) Token: 0x0601F2A7 RID: 127655 RVA: 0x00927CCB File Offset: 0x00925ECB
		public unsafe bool bTargetActorAsCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bTargetActorAsCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bTargetActorAsCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0601F2A8 RID: 127656 RVA: 0x00927CDC File Offset: 0x00925EDC
		// (set) Token: 0x0601F2A9 RID: 127657 RVA: 0x00927CF0 File Offset: 0x00925EF0
		public unsafe FVector TrackLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TrackLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_TrackLocation) = value;
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0601F2AA RID: 127658 RVA: 0x00927D05 File Offset: 0x00925F05
		// (set) Token: 0x0601F2AB RID: 127659 RVA: 0x00927D15 File Offset: 0x00925F15
		public unsafe float ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmLength) = value;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0601F2AC RID: 127660 RVA: 0x00927D26 File Offset: 0x00925F26
		// (set) Token: 0x0601F2AD RID: 127661 RVA: 0x00927D3A File Offset: 0x00925F3A
		public unsafe FVector ArmOffsetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmOffsetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmOffsetLocation) = value;
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0601F2AE RID: 127662 RVA: 0x00927D4F File Offset: 0x00925F4F
		// (set) Token: 0x0601F2AF RID: 127663 RVA: 0x00927D63 File Offset: 0x00925F63
		public unsafe FRotator ArmOffsetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmOffsetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmOffsetRotation) = value;
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0601F2B0 RID: 127664 RVA: 0x00927D78 File Offset: 0x00925F78
		// (set) Token: 0x0601F2B1 RID: 127665 RVA: 0x00927D88 File Offset: 0x00925F88
		public unsafe bool IsDynamicFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsDynamicFov) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_IsDynamicFov) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0601F2B2 RID: 127666 RVA: 0x00927D99 File Offset: 0x00925F99
		// (set) Token: 0x0601F2B3 RID: 127667 RVA: 0x00927DAD File Offset: 0x00925FAD
		public unsafe FIntPoint DynamicBaseResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_DynamicBaseResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_DynamicBaseResolution) = value;
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0601F2B4 RID: 127668 RVA: 0x00927DC2 File Offset: 0x00925FC2
		// (set) Token: 0x0601F2B5 RID: 127669 RVA: 0x00927DD2 File Offset: 0x00925FD2
		public unsafe float CameraFieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_CameraFieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_CameraFieldOfView) = value;
			}
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0601F2B6 RID: 127670 RVA: 0x00927DE3 File Offset: 0x00925FE3
		// (set) Token: 0x0601F2B7 RID: 127671 RVA: 0x00927DF3 File Offset: 0x00925FF3
		public unsafe bool ArmCollisionTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmCollisionTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_ArmCollisionTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0601F2B8 RID: 127672 RVA: 0x00927E04 File Offset: 0x00926004
		// (set) Token: 0x0601F2B9 RID: 127673 RVA: 0x00927E14 File Offset: 0x00926014
		public unsafe float FocalDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_FocalDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_FocalDistance) = value;
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0601F2BA RID: 127674 RVA: 0x00927E25 File Offset: 0x00926025
		// (set) Token: 0x0601F2BB RID: 127675 RVA: 0x00927E35 File Offset: 0x00926035
		public unsafe float Aperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Aperture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_Aperture) = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0601F2BC RID: 127676 RVA: 0x00927E46 File Offset: 0x00926046
		// (set) Token: 0x0601F2BD RID: 127677 RVA: 0x00927E56 File Offset: 0x00926056
		public unsafe float FocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_FocalRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_FocalRegion) = value;
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0601F2BE RID: 127678 RVA: 0x00927E67 File Offset: 0x00926067
		// (set) Token: 0x0601F2BF RID: 127679 RVA: 0x00927E77 File Offset: 0x00926077
		public unsafe float PostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_PostProcessBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_PostProcessBlendWeight) = value;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0601F2C0 RID: 127680 RVA: 0x00927E88 File Offset: 0x00926088
		// (set) Token: 0x0601F2C1 RID: 127681 RVA: 0x00927E98 File Offset: 0x00926098
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0601F2C2 RID: 127682 RVA: 0x00927EA9 File Offset: 0x009260A9
		// (set) Token: 0x0601F2C3 RID: 127683 RVA: 0x00927EB9 File Offset: 0x009260B9
		public unsafe float BlendInExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInExp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInExp) = value;
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0601F2C4 RID: 127684 RVA: 0x00927ECA File Offset: 0x009260CA
		// (set) Token: 0x0601F2C5 RID: 127685 RVA: 0x00927EE9 File Offset: 0x009260E9
		public TSoftObjectPtr<ULevelSequence> BlendInCameraSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInCameraSequence, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInCameraSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0601F2C6 RID: 127686 RVA: 0x00927F0E File Offset: 0x0092610E
		// (set) Token: 0x0601F2C7 RID: 127687 RVA: 0x00927F1E File Offset: 0x0092611E
		public unsafe float BlendInCameraSequencePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInCameraSequencePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInCameraSequencePlayRate) = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0601F2C8 RID: 127688 RVA: 0x00927F2F File Offset: 0x0092612F
		// (set) Token: 0x0601F2C9 RID: 127689 RVA: 0x00927F3F File Offset: 0x0092613F
		public unsafe bool bRevertBlendInCameraSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bRevertBlendInCameraSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bRevertBlendInCameraSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0601F2CA RID: 127690 RVA: 0x00927F50 File Offset: 0x00926150
		// (set) Token: 0x0601F2CB RID: 127691 RVA: 0x00927F6F File Offset: 0x0092616F
		public TSoftObjectPtr<ULevelSequence> BlendOutCameraSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutCameraSequence, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutCameraSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0601F2CC RID: 127692 RVA: 0x00927F94 File Offset: 0x00926194
		// (set) Token: 0x0601F2CD RID: 127693 RVA: 0x00927FA4 File Offset: 0x009261A4
		public unsafe float BlendOutCameraSequencePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutCameraSequencePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutCameraSequencePlayRate) = value;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0601F2CE RID: 127694 RVA: 0x00927FB5 File Offset: 0x009261B5
		// (set) Token: 0x0601F2CF RID: 127695 RVA: 0x00927FC5 File Offset: 0x009261C5
		public unsafe bool bRevertBlendOutCameraSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bRevertBlendOutCameraSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bRevertBlendOutCameraSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0601F2D0 RID: 127696 RVA: 0x00927FD6 File Offset: 0x009261D6
		// (set) Token: 0x0601F2D1 RID: 127697 RVA: 0x00927FEA File Offset: 0x009261EA
		[Nullable(0)]
		public unsafe TEnumAsByte<EViewTargetBlendFunction> BlendInFunction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInFunction);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInFunction) = value;
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0601F2D2 RID: 127698 RVA: 0x00927FFF File Offset: 0x009261FF
		// (set) Token: 0x0601F2D3 RID: 127699 RVA: 0x0092801E File Offset: 0x0092621E
		public TSoftObjectPtr<ULevelSequence> BlendInSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInSequence, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0601F2D4 RID: 127700 RVA: 0x00928043 File Offset: 0x00926243
		// (set) Token: 0x0601F2D5 RID: 127701 RVA: 0x00928053 File Offset: 0x00926253
		public unsafe bool bBlendInSequenceReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bBlendInSequenceReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bBlendInSequenceReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0601F2D6 RID: 127702 RVA: 0x00928064 File Offset: 0x00926264
		// (set) Token: 0x0601F2D7 RID: 127703 RVA: 0x00928074 File Offset: 0x00926274
		public unsafe float BlendInPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendInPlayRate) = value;
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0601F2D8 RID: 127704 RVA: 0x00928085 File Offset: 0x00926285
		// (set) Token: 0x0601F2D9 RID: 127705 RVA: 0x00928095 File Offset: 0x00926295
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0601F2DA RID: 127706 RVA: 0x009280A6 File Offset: 0x009262A6
		// (set) Token: 0x0601F2DB RID: 127707 RVA: 0x009280B6 File Offset: 0x009262B6
		public unsafe float BlendOutExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutExp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutExp) = value;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0601F2DC RID: 127708 RVA: 0x009280C7 File Offset: 0x009262C7
		// (set) Token: 0x0601F2DD RID: 127709 RVA: 0x009280DB File Offset: 0x009262DB
		[Nullable(0)]
		public unsafe TEnumAsByte<EViewTargetBlendFunction> BlendOutFunction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutFunction);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutFunction) = value;
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0601F2DE RID: 127710 RVA: 0x009280F0 File Offset: 0x009262F0
		// (set) Token: 0x0601F2DF RID: 127711 RVA: 0x0092810F File Offset: 0x0092630F
		public TSoftObjectPtr<ULevelSequence> BlendOutSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutSequence, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0601F2E0 RID: 127712 RVA: 0x00928134 File Offset: 0x00926334
		// (set) Token: 0x0601F2E1 RID: 127713 RVA: 0x00928144 File Offset: 0x00926344
		public unsafe float BlendOutPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_BlendOutPlayRate) = value;
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0601F2E2 RID: 127714 RVA: 0x00928155 File Offset: 0x00926355
		// (set) Token: 0x0601F2E3 RID: 127715 RVA: 0x00928165 File Offset: 0x00926365
		public unsafe bool bBlendOutSequenceReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bBlendOutSequenceReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bBlendOutSequenceReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0601F2E4 RID: 127716 RVA: 0x00928176 File Offset: 0x00926376
		// (set) Token: 0x0601F2E5 RID: 127717 RVA: 0x00928186 File Offset: 0x00926386
		public unsafe bool bResetCameraTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bResetCameraTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationSettings.__PropertyOffset_bResetCameraTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F2E6 RID: 127718 RVA: 0x00928197 File Offset: 0x00926397
		public SUiCameraAnimationSettings()
		{
		}

		// Token: 0x0601F2E7 RID: 127719 RVA: 0x0092819F File Offset: 0x0092639F
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraAnimationSettings.StaticStruct();
		}

		// Token: 0x0601F2E8 RID: 127720 RVA: 0x009281AB File Offset: 0x009263AB
		[NullableContext(2)]
		public SUiCameraAnimationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F2E9 RID: 127721 RVA: 0x009281B5 File Offset: 0x009263B5
		public SUiCameraAnimationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F2EA RID: 127722 RVA: 0x009281C0 File Offset: 0x009263C0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraAnimationSettings(Pointer, false, true);
		}

		// Token: 0x0601F2EB RID: 127723 RVA: 0x009281CA File Offset: 0x009263CA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraAnimationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010A77 RID: 68215
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationSettings.SUiCameraAnimationSettings";

		// Token: 0x04010A78 RID: 68216
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A79 RID: 68217
		internal static int __PropertyOffset_IsEmptyState;

		// Token: 0x04010A7A RID: 68218
		internal static int __PropertyOffset_ReplaceCameraTag;

		// Token: 0x04010A7B RID: 68219
		internal static int __PropertyOffset_Description;

		// Token: 0x04010A7C RID: 68220
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04010A7D RID: 68221
		internal static int __PropertyOffset_TargetType;

		// Token: 0x04010A7E RID: 68222
		internal static int __PropertyOffset_TargetActorTag;

		// Token: 0x04010A7F RID: 68223
		internal static int __PropertyOffset_LocationType;

		// Token: 0x04010A80 RID: 68224
		internal static int __PropertyOffset_Location;

		// Token: 0x04010A81 RID: 68225
		internal static int __PropertyOffset_RotationType;

		// Token: 0x04010A82 RID: 68226
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04010A83 RID: 68227
		internal static int __PropertyOffset_IsTrack;

		// Token: 0x04010A84 RID: 68228
		internal static int __PropertyOffset_IsTrackWorldLocation;

		// Token: 0x04010A85 RID: 68229
		internal static int __PropertyOffset_bOverrideTrackPitch;

		// Token: 0x04010A86 RID: 68230
		internal static int __PropertyOffset_TrackPitchOverride;

		// Token: 0x04010A87 RID: 68231
		internal static int __PropertyOffset_bTargetActorAsCenter;

		// Token: 0x04010A88 RID: 68232
		internal static int __PropertyOffset_TrackLocation;

		// Token: 0x04010A89 RID: 68233
		internal static int __PropertyOffset_ArmLength;

		// Token: 0x04010A8A RID: 68234
		internal static int __PropertyOffset_ArmOffsetLocation;

		// Token: 0x04010A8B RID: 68235
		internal static int __PropertyOffset_ArmOffsetRotation;

		// Token: 0x04010A8C RID: 68236
		internal static int __PropertyOffset_IsDynamicFov;

		// Token: 0x04010A8D RID: 68237
		internal static int __PropertyOffset_DynamicBaseResolution;

		// Token: 0x04010A8E RID: 68238
		internal static int __PropertyOffset_CameraFieldOfView;

		// Token: 0x04010A8F RID: 68239
		internal static int __PropertyOffset_ArmCollisionTest;

		// Token: 0x04010A90 RID: 68240
		internal static int __PropertyOffset_FocalDistance;

		// Token: 0x04010A91 RID: 68241
		internal static int __PropertyOffset_Aperture;

		// Token: 0x04010A92 RID: 68242
		internal static int __PropertyOffset_FocalRegion;

		// Token: 0x04010A93 RID: 68243
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x04010A94 RID: 68244
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x04010A95 RID: 68245
		internal static int __PropertyOffset_BlendInExp;

		// Token: 0x04010A96 RID: 68246
		internal static int __PropertyOffset_BlendInCameraSequence;

		// Token: 0x04010A97 RID: 68247
		internal static int __PropertyOffset_BlendInCameraSequencePlayRate;

		// Token: 0x04010A98 RID: 68248
		internal static int __PropertyOffset_bRevertBlendInCameraSequence;

		// Token: 0x04010A99 RID: 68249
		internal static int __PropertyOffset_BlendOutCameraSequence;

		// Token: 0x04010A9A RID: 68250
		internal static int __PropertyOffset_BlendOutCameraSequencePlayRate;

		// Token: 0x04010A9B RID: 68251
		internal static int __PropertyOffset_bRevertBlendOutCameraSequence;

		// Token: 0x04010A9C RID: 68252
		internal static int __PropertyOffset_BlendInFunction;

		// Token: 0x04010A9D RID: 68253
		internal static int __PropertyOffset_BlendInSequence;

		// Token: 0x04010A9E RID: 68254
		internal static int __PropertyOffset_bBlendInSequenceReverse;

		// Token: 0x04010A9F RID: 68255
		internal static int __PropertyOffset_BlendInPlayRate;

		// Token: 0x04010AA0 RID: 68256
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x04010AA1 RID: 68257
		internal static int __PropertyOffset_BlendOutExp;

		// Token: 0x04010AA2 RID: 68258
		internal static int __PropertyOffset_BlendOutFunction;

		// Token: 0x04010AA3 RID: 68259
		internal static int __PropertyOffset_BlendOutSequence;

		// Token: 0x04010AA4 RID: 68260
		internal static int __PropertyOffset_BlendOutPlayRate;

		// Token: 0x04010AA5 RID: 68261
		internal static int __PropertyOffset_bBlendOutSequenceReverse;

		// Token: 0x04010AA6 RID: 68262
		internal static int __PropertyOffset_bResetCameraTransform;
	}
}
