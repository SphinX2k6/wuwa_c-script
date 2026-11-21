using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003364 RID: 13156
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction")]
	[UnrealStructLayout(840, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 836)]
	public class SSkillBehaviorAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021588 RID: 136584 RVA: 0x0095E8FE File Offset: 0x0095CAFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorAction._ScriptStructPtr != 0) ? SSkillBehaviorAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction", ref SSkillBehaviorAction._ScriptStructPtr);
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x06021589 RID: 136585 RVA: 0x0095E922 File Offset: 0x0095CB22
		// (set) Token: 0x0602158A RID: 136586 RVA: 0x0095E936 File Offset: 0x0095CB36
		public unsafe TEnumAsByte<ESkillBehaviorActionType> ActionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ActionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ActionType) = value;
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x0602158B RID: 136587 RVA: 0x0095E94B File Offset: 0x0095CB4B
		// (set) Token: 0x0602158C RID: 136588 RVA: 0x0095E95F File Offset: 0x0095CB5F
		public unsafe TEnumAsByte<ESkillBehaviorLocationType> LocationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationType) = value;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x0602158D RID: 136589 RVA: 0x0095E974 File Offset: 0x0095CB74
		// (set) Token: 0x0602158E RID: 136590 RVA: 0x0095E988 File Offset: 0x0095CB88
		[Nullable(1)]
		public unsafe string BlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_BlackboardKey)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_BlackboardKey)), value);
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0602158F RID: 136591 RVA: 0x0095E99D File Offset: 0x0095CB9D
		// (set) Token: 0x06021590 RID: 136592 RVA: 0x0095E9B1 File Offset: 0x0095CBB1
		public unsafe TEnumAsByte<ESkillBehaviorLocationForwardType> LocationForwardType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationForwardType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationForwardType) = value;
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x06021591 RID: 136593 RVA: 0x0095E9C6 File Offset: 0x0095CBC6
		// (set) Token: 0x06021592 RID: 136594 RVA: 0x0095E9DA File Offset: 0x0095CBDA
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x06021593 RID: 136595 RVA: 0x0095E9EF File Offset: 0x0095CBEF
		// (set) Token: 0x06021594 RID: 136596 RVA: 0x0095E9FF File Offset: 0x0095CBFF
		public unsafe bool Restrict
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Restrict) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Restrict) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x06021595 RID: 136597 RVA: 0x0095EA10 File Offset: 0x0095CC10
		// (set) Token: 0x06021596 RID: 136598 RVA: 0x0095EA24 File Offset: 0x0095CC24
		public unsafe TEnumAsByte<ESkillBehaviorRestrictType> RestrictType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RestrictType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RestrictType) = value;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x06021597 RID: 136599 RVA: 0x0095EA39 File Offset: 0x0095CC39
		// (set) Token: 0x06021598 RID: 136600 RVA: 0x0095EA49 File Offset: 0x0095CC49
		public unsafe int RestrictDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RestrictDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RestrictDistance) = value;
			}
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x06021599 RID: 136601 RVA: 0x0095EA5A File Offset: 0x0095CC5A
		// (set) Token: 0x0602159A RID: 136602 RVA: 0x0095EA6A File Offset: 0x0095CC6A
		public unsafe bool BestSpot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BestSpot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BestSpot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x0602159B RID: 136603 RVA: 0x0095EA7B File Offset: 0x0095CC7B
		// (set) Token: 0x0602159C RID: 136604 RVA: 0x0095EA8F File Offset: 0x0095CC8F
		public unsafe TEnumAsByte<ESkillBehaviorRotationType> RotationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RotationType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_RotationType) = value;
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x0602159D RID: 136605 RVA: 0x0095EAA4 File Offset: 0x0095CCA4
		// (set) Token: 0x0602159E RID: 136606 RVA: 0x0095EAB4 File Offset: 0x0095CCB4
		public unsafe float DirectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_DirectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_DirectionOffset) = value;
			}
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x0602159F RID: 136607 RVA: 0x0095EAC8 File Offset: 0x0095CCC8
		// (set) Token: 0x060215A0 RID: 136608 RVA: 0x0095EB0B File Offset: 0x0095CD0B
		[Nullable(1)]
		public TArray<SSkillBehaviorCue> Cues
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorCue> result;
				if ((result = this._Cues) == null)
				{
					result = (this._Cues = new TArray<SSkillBehaviorCue>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Cues, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Cues.CopyAssign(value);
			}
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x060215A1 RID: 136609 RVA: 0x0095EB1C File Offset: 0x0095CD1C
		// (set) Token: 0x060215A2 RID: 136610 RVA: 0x0095EB5F File Offset: 0x0095CD5F
		[Nullable(1)]
		public TArray<SSkillBehaviorBullet> Bullets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorBullet> result;
				if ((result = this._Bullets) == null)
				{
					result = (this._Bullets = new TArray<SSkillBehaviorBullet>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Bullets, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Bullets.CopyAssign(value);
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x060215A3 RID: 136611 RVA: 0x0095EB6D File Offset: 0x0095CD6D
		// (set) Token: 0x060215A4 RID: 136612 RVA: 0x0095EB81 File Offset: 0x0095CD81
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x060215A5 RID: 136613 RVA: 0x0095EB96 File Offset: 0x0095CD96
		// (set) Token: 0x060215A6 RID: 136614 RVA: 0x0095EBA6 File Offset: 0x0095CDA6
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x060215A7 RID: 136615 RVA: 0x0095EBB7 File Offset: 0x0095CDB7
		// (set) Token: 0x060215A8 RID: 136616 RVA: 0x0095EBC7 File Offset: 0x0095CDC7
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x060215A9 RID: 136617 RVA: 0x0095EBD8 File Offset: 0x0095CDD8
		// (set) Token: 0x060215AA RID: 136618 RVA: 0x0095EBE8 File Offset: 0x0095CDE8
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x060215AB RID: 136619 RVA: 0x0095EBF9 File Offset: 0x0095CDF9
		// (set) Token: 0x060215AC RID: 136620 RVA: 0x0095EC09 File Offset: 0x0095CE09
		public unsafe float BreakBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BreakBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BreakBlendOutTime) = value;
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x060215AD RID: 136621 RVA: 0x0095EC1C File Offset: 0x0095CE1C
		// (set) Token: 0x060215AE RID: 136622 RVA: 0x0095EC5F File Offset: 0x0095CE5F
		[Nullable(1)]
		public SBaseCurve BlendInCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendInCurve) == null)
				{
					result = (this._BlendInCurve = new SBaseCurve(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendInCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendInCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x060215AF RID: 136623 RVA: 0x0095EC80 File Offset: 0x0095CE80
		// (set) Token: 0x060215B0 RID: 136624 RVA: 0x0095ECC3 File Offset: 0x0095CEC3
		[Nullable(1)]
		public SBaseCurve BlendOutCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendOutCurve) == null)
				{
					result = (this._BlendOutCurve = new SBaseCurve(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendOutCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BlendOutCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x060215B1 RID: 136625 RVA: 0x0095ECE4 File Offset: 0x0095CEE4
		// (set) Token: 0x060215B2 RID: 136626 RVA: 0x0095ECF8 File Offset: 0x0095CEF8
		public unsafe TEnumAsByte<ECameraAnsEffectiveClientType> CameraEffectiveClientType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraEffectiveClientType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraEffectiveClientType) = value;
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x060215B3 RID: 136627 RVA: 0x0095ED10 File Offset: 0x0095CF10
		// (set) Token: 0x060215B4 RID: 136628 RVA: 0x0095ED53 File Offset: 0x0095CF53
		[Nullable(1)]
		public TArray<SCameraModifier_Condition> CameraModifierConditions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraModifier_Condition> result;
				if ((result = this._CameraModifierConditions) == null)
				{
					result = (this._CameraModifierConditions = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraModifierConditions, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraModifierConditions.CopyAssign(value);
			}
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x060215B5 RID: 136629 RVA: 0x0095ED64 File Offset: 0x0095CF64
		// (set) Token: 0x060215B6 RID: 136630 RVA: 0x0095EDA7 File Offset: 0x0095CFA7
		[Nullable(1)]
		public SCameraModifier_Settings CameraModifierSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._CameraModifierSettings) == null)
				{
					result = (this._CameraModifierSettings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraModifierSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraModifierSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x060215B7 RID: 136631 RVA: 0x0095EDC8 File Offset: 0x0095CFC8
		// (set) Token: 0x060215B8 RID: 136632 RVA: 0x0095EE0B File Offset: 0x0095D00B
		[Nullable(1)]
		public SSequenceCamera_Settings CameraSequenceSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SSequenceCamera_Settings result;
				if ((result = this._CameraSequenceSettings) == null)
				{
					result = (this._CameraSequenceSettings = new SSequenceCamera_Settings(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraSequenceSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSequenceCamera_Settings.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraSequenceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x060215B9 RID: 136633 RVA: 0x0095EE2C File Offset: 0x0095D02C
		// (set) Token: 0x060215BA RID: 136634 RVA: 0x0095EE3C File Offset: 0x0095D03C
		public unsafe bool ResetLockOnCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ResetLockOnCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ResetLockOnCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x060215BB RID: 136635 RVA: 0x0095EE4D File Offset: 0x0095D04D
		// (set) Token: 0x060215BC RID: 136636 RVA: 0x0095EE61 File Offset: 0x0095D061
		public unsafe FRotator AdditiveRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_AdditiveRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_AdditiveRotation) = value;
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x060215BD RID: 136637 RVA: 0x0095EE76 File Offset: 0x0095D076
		// (set) Token: 0x060215BE RID: 136638 RVA: 0x0095EE8A File Offset: 0x0095D08A
		public unsafe FName CameraAttachSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraAttachSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraAttachSocket) = value;
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x060215BF RID: 136639 RVA: 0x0095EE9F File Offset: 0x0095D09F
		// (set) Token: 0x060215C0 RID: 136640 RVA: 0x0095EEB3 File Offset: 0x0095D0B3
		public unsafe FName CameraDetectSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraDetectSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CameraDetectSocket) = value;
			}
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x060215C1 RID: 136641 RVA: 0x0095EEC8 File Offset: 0x0095D0C8
		// (set) Token: 0x060215C2 RID: 136642 RVA: 0x0095EED8 File Offset: 0x0095D0D8
		public unsafe float ExtraDetectSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ExtraDetectSphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ExtraDetectSphereRadius) = value;
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x060215C3 RID: 136643 RVA: 0x0095EEE9 File Offset: 0x0095D0E9
		// (set) Token: 0x060215C4 RID: 136644 RVA: 0x0095EEFD File Offset: 0x0095D0FD
		public unsafe FVector ExtraSphereLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ExtraSphereLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_ExtraSphereLocation) = value;
			}
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x060215C5 RID: 136645 RVA: 0x0095EF12 File Offset: 0x0095D112
		// (set) Token: 0x060215C6 RID: 136646 RVA: 0x0095EF22 File Offset: 0x0095D122
		public unsafe bool IsShowExtraSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_IsShowExtraSphere) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_IsShowExtraSphere) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x060215C7 RID: 136647 RVA: 0x0095EF33 File Offset: 0x0095D133
		// (set) Token: 0x060215C8 RID: 136648 RVA: 0x0095EF47 File Offset: 0x0095D147
		public unsafe TEnumAsByte<EMovementMode> BeginMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BeginMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BeginMovementMode) = value;
			}
		}

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x060215C9 RID: 136649 RVA: 0x0095EF5C File Offset: 0x0095D15C
		// (set) Token: 0x060215CA RID: 136650 RVA: 0x0095EF70 File Offset: 0x0095D170
		public unsafe TEnumAsByte<EMovementMode> EndMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_EndMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_EndMovementMode) = value;
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x060215CB RID: 136651 RVA: 0x0095EF85 File Offset: 0x0095D185
		// (set) Token: 0x060215CC RID: 136652 RVA: 0x0095EF99 File Offset: 0x0095D199
		public unsafe TEnumAsByte<ECollisionResponse> CollisionResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionResponse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionResponse) = value;
			}
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x060215CD RID: 136653 RVA: 0x0095EFAE File Offset: 0x0095D1AE
		// (set) Token: 0x060215CE RID: 136654 RVA: 0x0095EFC2 File Offset: 0x0095D1C2
		public unsafe TEnumAsByte<ECollisionChannel> CollisionChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionChannel) = value;
			}
		}

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x060215CF RID: 136655 RVA: 0x0095EFD7 File Offset: 0x0095D1D7
		// (set) Token: 0x060215D0 RID: 136656 RVA: 0x0095EFE7 File Offset: 0x0095D1E7
		public unsafe bool CollisionRestore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionRestore) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CollisionRestore) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x060215D1 RID: 136657 RVA: 0x0095EFF8 File Offset: 0x0095D1F8
		// (set) Token: 0x060215D2 RID: 136658 RVA: 0x0095F008 File Offset: 0x0095D208
		public unsafe int FollowIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_FollowIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_FollowIndex) = value;
			}
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x060215D3 RID: 136659 RVA: 0x0095F019 File Offset: 0x0095D219
		// (set) Token: 0x060215D4 RID: 136660 RVA: 0x0095F029 File Offset: 0x0095D229
		public unsafe int SummonSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_SummonSkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_SummonSkillId) = value;
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x060215D5 RID: 136661 RVA: 0x0095F03A File Offset: 0x0095D23A
		// (set) Token: 0x060215D6 RID: 136662 RVA: 0x0095F04A File Offset: 0x0095D24A
		public unsafe bool StopSummonSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_StopSummonSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_StopSummonSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x060215D7 RID: 136663 RVA: 0x0095F05B File Offset: 0x0095D25B
		// (set) Token: 0x060215D8 RID: 136664 RVA: 0x0095F06F File Offset: 0x0095D26F
		public unsafe TEnumAsByte<ESkillBehaviorBestSpotType> Strategy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Strategy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Strategy) = value;
			}
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x060215D9 RID: 136665 RVA: 0x0095F084 File Offset: 0x0095D284
		// (set) Token: 0x060215DA RID: 136666 RVA: 0x0095F0C7 File Offset: 0x0095D2C7
		[Nullable(1)]
		public TArray<float> AngleOffsets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AngleOffsets) == null)
				{
					result = (this._AngleOffsets = new TArray<float>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_AngleOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AngleOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x060215DB RID: 136667 RVA: 0x0095F0D5 File Offset: 0x0095D2D5
		// (set) Token: 0x060215DC RID: 136668 RVA: 0x0095F0E5 File Offset: 0x0095D2E5
		public unsafe bool OnGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_OnGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_OnGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x060215DD RID: 136669 RVA: 0x0095F0F6 File Offset: 0x0095D2F6
		// (set) Token: 0x060215DE RID: 136670 RVA: 0x0095F106 File Offset: 0x0095D306
		public unsafe int GroundOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_GroundOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_GroundOffset) = value;
			}
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x060215DF RID: 136671 RVA: 0x0095F117 File Offset: 0x0095D317
		// (set) Token: 0x060215E0 RID: 136672 RVA: 0x0095F127 File Offset: 0x0095D327
		public unsafe bool DebugTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_DebugTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_DebugTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x060215E1 RID: 136673 RVA: 0x0095F138 File Offset: 0x0095D338
		// (set) Token: 0x060215E2 RID: 136674 RVA: 0x0095F148 File Offset: 0x0095D348
		public unsafe int Navigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Navigation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Navigation) = value;
			}
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x060215E3 RID: 136675 RVA: 0x0095F159 File Offset: 0x0095D359
		// (set) Token: 0x060215E4 RID: 136676 RVA: 0x0095F169 File Offset: 0x0095D369
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x060215E5 RID: 136677 RVA: 0x0095F17A File Offset: 0x0095D37A
		// (set) Token: 0x060215E6 RID: 136678 RVA: 0x0095F18E File Offset: 0x0095D38E
		public unsafe TEnumAsByte<ESkillBehaviorBuffTargetType> BuffTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BuffTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BuffTarget) = value;
			}
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x060215E7 RID: 136679 RVA: 0x0095F1A3 File Offset: 0x0095D3A3
		// (set) Token: 0x060215E8 RID: 136680 RVA: 0x0095F1B3 File Offset: 0x0095D3B3
		public unsafe bool Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x060215E9 RID: 136681 RVA: 0x0095F1C4 File Offset: 0x0095D3C4
		// (set) Token: 0x060215EA RID: 136682 RVA: 0x0095F1D4 File Offset: 0x0095D3D4
		public unsafe int MontageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_MontageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_MontageIndex) = value;
			}
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x060215EB RID: 136683 RVA: 0x0095F1E5 File Offset: 0x0095D3E5
		// (set) Token: 0x060215EC RID: 136684 RVA: 0x0095F1F9 File Offset: 0x0095D3F9
		[Nullable(1)]
		public unsafe string StartSection
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_StartSection)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_StartSection)), value);
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x060215ED RID: 136685 RVA: 0x0095F20E File Offset: 0x0095D40E
		// (set) Token: 0x060215EE RID: 136686 RVA: 0x0095F21E File Offset: 0x0095D41E
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x060215EF RID: 136687 RVA: 0x0095F230 File Offset: 0x0095D430
		// (set) Token: 0x060215F0 RID: 136688 RVA: 0x0095F273 File Offset: 0x0095D473
		[Nullable(1)]
		public SSkillBehaviorUpdateCustomValue UpdateCustomValue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SSkillBehaviorUpdateCustomValue result;
				if ((result = this._UpdateCustomValue) == null)
				{
					result = (this._UpdateCustomValue = new SSkillBehaviorUpdateCustomValue(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_UpdateCustomValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorUpdateCustomValue.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_UpdateCustomValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x060215F1 RID: 136689 RVA: 0x0095F294 File Offset: 0x0095D494
		// (set) Token: 0x060215F2 RID: 136690 RVA: 0x0095F2B3 File Offset: 0x0095D4B3
		[Nullable(1)]
		public TSoftObjectPtr<UPrimaryDataAsset> CommonConf
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CommonConf, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_CommonConf, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x060215F3 RID: 136691 RVA: 0x0095F2D8 File Offset: 0x0095D4D8
		// (set) Token: 0x060215F4 RID: 136692 RVA: 0x0095F2EC File Offset: 0x0095D4EC
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x060215F5 RID: 136693 RVA: 0x0095F301 File Offset: 0x0095D501
		public SSkillBehaviorAction()
		{
		}

		// Token: 0x060215F6 RID: 136694 RVA: 0x0095F309 File Offset: 0x0095D509
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorAction.StaticStruct();
		}

		// Token: 0x060215F7 RID: 136695 RVA: 0x0095F315 File Offset: 0x0095D515
		[NullableContext(2)]
		public SSkillBehaviorAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060215F8 RID: 136696 RVA: 0x0095F31F File Offset: 0x0095D51F
		public SSkillBehaviorAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060215F9 RID: 136697 RVA: 0x0095F32A File Offset: 0x0095D52A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorAction(Pointer, false, true);
		}

		// Token: 0x060215FA RID: 136698 RVA: 0x0095F334 File Offset: 0x0095D534
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorAction(Pointer, MemoryOwner);
		}

		// Token: 0x04012399 RID: 74649
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction";

		// Token: 0x0401239A RID: 74650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401239B RID: 74651
		internal static int __PropertyOffset_ActionType;

		// Token: 0x0401239C RID: 74652
		internal static int __PropertyOffset_LocationType;

		// Token: 0x0401239D RID: 74653
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x0401239E RID: 74654
		internal static int __PropertyOffset_LocationForwardType;

		// Token: 0x0401239F RID: 74655
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x040123A0 RID: 74656
		internal static int __PropertyOffset_Restrict;

		// Token: 0x040123A1 RID: 74657
		internal static int __PropertyOffset_RestrictType;

		// Token: 0x040123A2 RID: 74658
		internal static int __PropertyOffset_RestrictDistance;

		// Token: 0x040123A3 RID: 74659
		internal static int __PropertyOffset_BestSpot;

		// Token: 0x040123A4 RID: 74660
		internal static int __PropertyOffset_RotationType;

		// Token: 0x040123A5 RID: 74661
		internal static int __PropertyOffset_DirectionOffset;

		// Token: 0x040123A6 RID: 74662
		internal static int __PropertyOffset_Cues;

		// Token: 0x040123A7 RID: 74663
		[Nullable(2)]
		private TArray<SSkillBehaviorCue> _Cues;

		// Token: 0x040123A8 RID: 74664
		internal static int __PropertyOffset_Bullets;

		// Token: 0x040123A9 RID: 74665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorBullet> _Bullets;

		// Token: 0x040123AA RID: 74666
		internal static int __PropertyOffset_Tag;

		// Token: 0x040123AB RID: 74667
		internal static int __PropertyOffset_Duration;

		// Token: 0x040123AC RID: 74668
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040123AD RID: 74669
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x040123AE RID: 74670
		internal static int __PropertyOffset_BreakBlendOutTime;

		// Token: 0x040123AF RID: 74671
		internal static int __PropertyOffset_BlendInCurve;

		// Token: 0x040123B0 RID: 74672
		[Nullable(2)]
		private SBaseCurve _BlendInCurve;

		// Token: 0x040123B1 RID: 74673
		internal static int __PropertyOffset_BlendOutCurve;

		// Token: 0x040123B2 RID: 74674
		[Nullable(2)]
		private SBaseCurve _BlendOutCurve;

		// Token: 0x040123B3 RID: 74675
		internal static int __PropertyOffset_CameraEffectiveClientType;

		// Token: 0x040123B4 RID: 74676
		internal static int __PropertyOffset_CameraModifierConditions;

		// Token: 0x040123B5 RID: 74677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Condition> _CameraModifierConditions;

		// Token: 0x040123B6 RID: 74678
		internal static int __PropertyOffset_CameraModifierSettings;

		// Token: 0x040123B7 RID: 74679
		[Nullable(2)]
		private SCameraModifier_Settings _CameraModifierSettings;

		// Token: 0x040123B8 RID: 74680
		internal static int __PropertyOffset_CameraSequenceSettings;

		// Token: 0x040123B9 RID: 74681
		[Nullable(2)]
		private SSequenceCamera_Settings _CameraSequenceSettings;

		// Token: 0x040123BA RID: 74682
		internal static int __PropertyOffset_ResetLockOnCamera;

		// Token: 0x040123BB RID: 74683
		internal static int __PropertyOffset_AdditiveRotation;

		// Token: 0x040123BC RID: 74684
		internal static int __PropertyOffset_CameraAttachSocket;

		// Token: 0x040123BD RID: 74685
		internal static int __PropertyOffset_CameraDetectSocket;

		// Token: 0x040123BE RID: 74686
		internal static int __PropertyOffset_ExtraDetectSphereRadius;

		// Token: 0x040123BF RID: 74687
		internal static int __PropertyOffset_ExtraSphereLocation;

		// Token: 0x040123C0 RID: 74688
		internal static int __PropertyOffset_IsShowExtraSphere;

		// Token: 0x040123C1 RID: 74689
		internal static int __PropertyOffset_BeginMovementMode;

		// Token: 0x040123C2 RID: 74690
		internal static int __PropertyOffset_EndMovementMode;

		// Token: 0x040123C3 RID: 74691
		internal static int __PropertyOffset_CollisionResponse;

		// Token: 0x040123C4 RID: 74692
		internal static int __PropertyOffset_CollisionChannel;

		// Token: 0x040123C5 RID: 74693
		internal static int __PropertyOffset_CollisionRestore;

		// Token: 0x040123C6 RID: 74694
		internal static int __PropertyOffset_FollowIndex;

		// Token: 0x040123C7 RID: 74695
		internal static int __PropertyOffset_SummonSkillId;

		// Token: 0x040123C8 RID: 74696
		internal static int __PropertyOffset_StopSummonSkill;

		// Token: 0x040123C9 RID: 74697
		internal static int __PropertyOffset_Strategy;

		// Token: 0x040123CA RID: 74698
		internal static int __PropertyOffset_AngleOffsets;

		// Token: 0x040123CB RID: 74699
		[Nullable(2)]
		private TArray<float> _AngleOffsets;

		// Token: 0x040123CC RID: 74700
		internal static int __PropertyOffset_OnGround;

		// Token: 0x040123CD RID: 74701
		internal static int __PropertyOffset_GroundOffset;

		// Token: 0x040123CE RID: 74702
		internal static int __PropertyOffset_DebugTrace;

		// Token: 0x040123CF RID: 74703
		internal static int __PropertyOffset_Navigation;

		// Token: 0x040123D0 RID: 74704
		internal static int __PropertyOffset_BuffId;

		// Token: 0x040123D1 RID: 74705
		internal static int __PropertyOffset_BuffTarget;

		// Token: 0x040123D2 RID: 74706
		internal static int __PropertyOffset_Add;

		// Token: 0x040123D3 RID: 74707
		internal static int __PropertyOffset_MontageIndex;

		// Token: 0x040123D4 RID: 74708
		internal static int __PropertyOffset_StartSection;

		// Token: 0x040123D5 RID: 74709
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040123D6 RID: 74710
		internal static int __PropertyOffset_UpdateCustomValue;

		// Token: 0x040123D7 RID: 74711
		[Nullable(2)]
		private SSkillBehaviorUpdateCustomValue _UpdateCustomValue;

		// Token: 0x040123D8 RID: 74712
		internal static int __PropertyOffset_CommonConf;

		// Token: 0x040123D9 RID: 74713
		internal static int __PropertyOffset_BoneName;
	}
}
