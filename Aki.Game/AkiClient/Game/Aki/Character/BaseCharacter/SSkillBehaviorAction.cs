using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432C RID: 17196
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction")]
	[UnrealStructLayout(840, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 836)]
	public class SSkillBehaviorAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C889 RID: 182409 RVA: 0x00A2206B File Offset: 0x00A2026B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorAction._ScriptStructPtr != 0) ? SSkillBehaviorAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction", ref SSkillBehaviorAction._ScriptStructPtr);
		}

		// Token: 0x17006FB1 RID: 28593
		// (get) Token: 0x0602C88A RID: 182410 RVA: 0x00A2208F File Offset: 0x00A2028F
		// (set) Token: 0x0602C88B RID: 182411 RVA: 0x00A220A3 File Offset: 0x00A202A3
		public unsafe TEnumAsByte<ESkillBehaviorActionType> ActionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006FB2 RID: 28594
		// (get) Token: 0x0602C88C RID: 182412 RVA: 0x00A220B8 File Offset: 0x00A202B8
		// (set) Token: 0x0602C88D RID: 182413 RVA: 0x00A220CC File Offset: 0x00A202CC
		public unsafe TEnumAsByte<ESkillBehaviorLocationType> LocationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006FB3 RID: 28595
		// (get) Token: 0x0602C88E RID: 182414 RVA: 0x00A220E1 File Offset: 0x00A202E1
		// (set) Token: 0x0602C88F RID: 182415 RVA: 0x00A220F5 File Offset: 0x00A202F5
		[Nullable(1)]
		public unsafe string BlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_2)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006FB4 RID: 28596
		// (get) Token: 0x0602C890 RID: 182416 RVA: 0x00A2210A File Offset: 0x00A2030A
		// (set) Token: 0x0602C891 RID: 182417 RVA: 0x00A2211E File Offset: 0x00A2031E
		public unsafe TEnumAsByte<ESkillBehaviorLocationForwardType> LocationForwardType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006FB5 RID: 28597
		// (get) Token: 0x0602C892 RID: 182418 RVA: 0x00A22133 File Offset: 0x00A20333
		// (set) Token: 0x0602C893 RID: 182419 RVA: 0x00A22147 File Offset: 0x00A20347
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006FB6 RID: 28598
		// (get) Token: 0x0602C894 RID: 182420 RVA: 0x00A2215C File Offset: 0x00A2035C
		// (set) Token: 0x0602C895 RID: 182421 RVA: 0x00A2216C File Offset: 0x00A2036C
		public unsafe bool Restrict
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FB7 RID: 28599
		// (get) Token: 0x0602C896 RID: 182422 RVA: 0x00A2217D File Offset: 0x00A2037D
		// (set) Token: 0x0602C897 RID: 182423 RVA: 0x00A22191 File Offset: 0x00A20391
		public unsafe TEnumAsByte<ESkillBehaviorRestrictType> RestrictType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006FB8 RID: 28600
		// (get) Token: 0x0602C898 RID: 182424 RVA: 0x00A221A6 File Offset: 0x00A203A6
		// (set) Token: 0x0602C899 RID: 182425 RVA: 0x00A221B6 File Offset: 0x00A203B6
		public unsafe int RestrictDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006FB9 RID: 28601
		// (get) Token: 0x0602C89A RID: 182426 RVA: 0x00A221C7 File Offset: 0x00A203C7
		// (set) Token: 0x0602C89B RID: 182427 RVA: 0x00A221D7 File Offset: 0x00A203D7
		public unsafe bool BestSpot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FBA RID: 28602
		// (get) Token: 0x0602C89C RID: 182428 RVA: 0x00A221E8 File Offset: 0x00A203E8
		// (set) Token: 0x0602C89D RID: 182429 RVA: 0x00A221FC File Offset: 0x00A203FC
		public unsafe TEnumAsByte<ESkillBehaviorRotationType> RotationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006FBB RID: 28603
		// (get) Token: 0x0602C89E RID: 182430 RVA: 0x00A22211 File Offset: 0x00A20411
		// (set) Token: 0x0602C89F RID: 182431 RVA: 0x00A22221 File Offset: 0x00A20421
		public unsafe float DirectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006FBC RID: 28604
		// (get) Token: 0x0602C8A0 RID: 182432 RVA: 0x00A22234 File Offset: 0x00A20434
		// (set) Token: 0x0602C8A1 RID: 182433 RVA: 0x00A22277 File Offset: 0x00A20477
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
					result = (this._Cues = new TArray<SSkillBehaviorCue>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Cues.CopyAssign(value);
			}
		}

		// Token: 0x17006FBD RID: 28605
		// (get) Token: 0x0602C8A2 RID: 182434 RVA: 0x00A22288 File Offset: 0x00A20488
		// (set) Token: 0x0602C8A3 RID: 182435 RVA: 0x00A222CB File Offset: 0x00A204CB
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
					result = (this._Bullets = new TArray<SSkillBehaviorBullet>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Bullets.CopyAssign(value);
			}
		}

		// Token: 0x17006FBE RID: 28606
		// (get) Token: 0x0602C8A4 RID: 182436 RVA: 0x00A222D9 File Offset: 0x00A204D9
		// (set) Token: 0x0602C8A5 RID: 182437 RVA: 0x00A222ED File Offset: 0x00A204ED
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006FBF RID: 28607
		// (get) Token: 0x0602C8A6 RID: 182438 RVA: 0x00A22302 File Offset: 0x00A20502
		// (set) Token: 0x0602C8A7 RID: 182439 RVA: 0x00A22312 File Offset: 0x00A20512
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006FC0 RID: 28608
		// (get) Token: 0x0602C8A8 RID: 182440 RVA: 0x00A22323 File Offset: 0x00A20523
		// (set) Token: 0x0602C8A9 RID: 182441 RVA: 0x00A22333 File Offset: 0x00A20533
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006FC1 RID: 28609
		// (get) Token: 0x0602C8AA RID: 182442 RVA: 0x00A22344 File Offset: 0x00A20544
		// (set) Token: 0x0602C8AB RID: 182443 RVA: 0x00A22354 File Offset: 0x00A20554
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006FC2 RID: 28610
		// (get) Token: 0x0602C8AC RID: 182444 RVA: 0x00A22365 File Offset: 0x00A20565
		// (set) Token: 0x0602C8AD RID: 182445 RVA: 0x00A22375 File Offset: 0x00A20575
		public unsafe float BreakBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006FC3 RID: 28611
		// (get) Token: 0x0602C8AE RID: 182446 RVA: 0x00A22388 File Offset: 0x00A20588
		// (set) Token: 0x0602C8AF RID: 182447 RVA: 0x00A223CB File Offset: 0x00A205CB
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
					result = (this._BlendInCurve = new SBaseCurve(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_18, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FC4 RID: 28612
		// (get) Token: 0x0602C8B0 RID: 182448 RVA: 0x00A223EC File Offset: 0x00A205EC
		// (set) Token: 0x0602C8B1 RID: 182449 RVA: 0x00A2242F File Offset: 0x00A2062F
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
					result = (this._BlendOutCurve = new SBaseCurve(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_19, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FC5 RID: 28613
		// (get) Token: 0x0602C8B2 RID: 182450 RVA: 0x00A22450 File Offset: 0x00A20650
		// (set) Token: 0x0602C8B3 RID: 182451 RVA: 0x00A22464 File Offset: 0x00A20664
		public unsafe TEnumAsByte<ECameraAnsEffectiveClientType> CameraEffectiveClientType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006FC6 RID: 28614
		// (get) Token: 0x0602C8B4 RID: 182452 RVA: 0x00A2247C File Offset: 0x00A2067C
		// (set) Token: 0x0602C8B5 RID: 182453 RVA: 0x00A224BF File Offset: 0x00A206BF
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
					result = (this._CameraModifierConditions = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_21, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraModifierConditions.CopyAssign(value);
			}
		}

		// Token: 0x17006FC7 RID: 28615
		// (get) Token: 0x0602C8B6 RID: 182454 RVA: 0x00A224D0 File Offset: 0x00A206D0
		// (set) Token: 0x0602C8B7 RID: 182455 RVA: 0x00A22513 File Offset: 0x00A20713
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
					result = (this._CameraModifierSettings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_22, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_22, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FC8 RID: 28616
		// (get) Token: 0x0602C8B8 RID: 182456 RVA: 0x00A22534 File Offset: 0x00A20734
		// (set) Token: 0x0602C8B9 RID: 182457 RVA: 0x00A22577 File Offset: 0x00A20777
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
					result = (this._CameraSequenceSettings = new SSequenceCamera_Settings(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_23, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSequenceCamera_Settings.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_23, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FC9 RID: 28617
		// (get) Token: 0x0602C8BA RID: 182458 RVA: 0x00A22598 File Offset: 0x00A20798
		// (set) Token: 0x0602C8BB RID: 182459 RVA: 0x00A225A8 File Offset: 0x00A207A8
		public unsafe bool ResetLockOnCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FCA RID: 28618
		// (get) Token: 0x0602C8BC RID: 182460 RVA: 0x00A225B9 File Offset: 0x00A207B9
		// (set) Token: 0x0602C8BD RID: 182461 RVA: 0x00A225CD File Offset: 0x00A207CD
		public unsafe FRotator AdditiveRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17006FCB RID: 28619
		// (get) Token: 0x0602C8BE RID: 182462 RVA: 0x00A225E2 File Offset: 0x00A207E2
		// (set) Token: 0x0602C8BF RID: 182463 RVA: 0x00A225F6 File Offset: 0x00A207F6
		public unsafe FName CameraAttachSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17006FCC RID: 28620
		// (get) Token: 0x0602C8C0 RID: 182464 RVA: 0x00A2260B File Offset: 0x00A2080B
		// (set) Token: 0x0602C8C1 RID: 182465 RVA: 0x00A2261F File Offset: 0x00A2081F
		public unsafe FName CameraDetectSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17006FCD RID: 28621
		// (get) Token: 0x0602C8C2 RID: 182466 RVA: 0x00A22634 File Offset: 0x00A20834
		// (set) Token: 0x0602C8C3 RID: 182467 RVA: 0x00A22644 File Offset: 0x00A20844
		public unsafe float ExtraDetectSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17006FCE RID: 28622
		// (get) Token: 0x0602C8C4 RID: 182468 RVA: 0x00A22655 File Offset: 0x00A20855
		// (set) Token: 0x0602C8C5 RID: 182469 RVA: 0x00A22669 File Offset: 0x00A20869
		public unsafe FVector ExtraSphereLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17006FCF RID: 28623
		// (get) Token: 0x0602C8C6 RID: 182470 RVA: 0x00A2267E File Offset: 0x00A2087E
		// (set) Token: 0x0602C8C7 RID: 182471 RVA: 0x00A2268E File Offset: 0x00A2088E
		public unsafe bool IsShowExtraSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FD0 RID: 28624
		// (get) Token: 0x0602C8C8 RID: 182472 RVA: 0x00A2269F File Offset: 0x00A2089F
		// (set) Token: 0x0602C8C9 RID: 182473 RVA: 0x00A226B3 File Offset: 0x00A208B3
		public unsafe TEnumAsByte<EMovementMode> BeginMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17006FD1 RID: 28625
		// (get) Token: 0x0602C8CA RID: 182474 RVA: 0x00A226C8 File Offset: 0x00A208C8
		// (set) Token: 0x0602C8CB RID: 182475 RVA: 0x00A226DC File Offset: 0x00A208DC
		public unsafe TEnumAsByte<EMovementMode> EndMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17006FD2 RID: 28626
		// (get) Token: 0x0602C8CC RID: 182476 RVA: 0x00A226F1 File Offset: 0x00A208F1
		// (set) Token: 0x0602C8CD RID: 182477 RVA: 0x00A22705 File Offset: 0x00A20905
		public unsafe TEnumAsByte<ECollisionResponse> CollisionResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006FD3 RID: 28627
		// (get) Token: 0x0602C8CE RID: 182478 RVA: 0x00A2271A File Offset: 0x00A2091A
		// (set) Token: 0x0602C8CF RID: 182479 RVA: 0x00A2272E File Offset: 0x00A2092E
		public unsafe TEnumAsByte<ECollisionChannel> CollisionChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17006FD4 RID: 28628
		// (get) Token: 0x0602C8D0 RID: 182480 RVA: 0x00A22743 File Offset: 0x00A20943
		// (set) Token: 0x0602C8D1 RID: 182481 RVA: 0x00A22753 File Offset: 0x00A20953
		public unsafe bool CollisionRestore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FD5 RID: 28629
		// (get) Token: 0x0602C8D2 RID: 182482 RVA: 0x00A22764 File Offset: 0x00A20964
		// (set) Token: 0x0602C8D3 RID: 182483 RVA: 0x00A22774 File Offset: 0x00A20974
		public unsafe int FollowIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006FD6 RID: 28630
		// (get) Token: 0x0602C8D4 RID: 182484 RVA: 0x00A22785 File Offset: 0x00A20985
		// (set) Token: 0x0602C8D5 RID: 182485 RVA: 0x00A22795 File Offset: 0x00A20995
		public unsafe int SummonSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006FD7 RID: 28631
		// (get) Token: 0x0602C8D6 RID: 182486 RVA: 0x00A227A6 File Offset: 0x00A209A6
		// (set) Token: 0x0602C8D7 RID: 182487 RVA: 0x00A227B6 File Offset: 0x00A209B6
		public unsafe bool StopSummonSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FD8 RID: 28632
		// (get) Token: 0x0602C8D8 RID: 182488 RVA: 0x00A227C7 File Offset: 0x00A209C7
		// (set) Token: 0x0602C8D9 RID: 182489 RVA: 0x00A227DB File Offset: 0x00A209DB
		public unsafe TEnumAsByte<ESkillBehaviorBestSpotType> Strategy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17006FD9 RID: 28633
		// (get) Token: 0x0602C8DA RID: 182490 RVA: 0x00A227F0 File Offset: 0x00A209F0
		// (set) Token: 0x0602C8DB RID: 182491 RVA: 0x00A22833 File Offset: 0x00A20A33
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
					result = (this._AngleOffsets = new TArray<float>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_40, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AngleOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17006FDA RID: 28634
		// (get) Token: 0x0602C8DC RID: 182492 RVA: 0x00A22841 File Offset: 0x00A20A41
		// (set) Token: 0x0602C8DD RID: 182493 RVA: 0x00A22851 File Offset: 0x00A20A51
		public unsafe bool OnGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FDB RID: 28635
		// (get) Token: 0x0602C8DE RID: 182494 RVA: 0x00A22862 File Offset: 0x00A20A62
		// (set) Token: 0x0602C8DF RID: 182495 RVA: 0x00A22872 File Offset: 0x00A20A72
		public unsafe int GroundOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17006FDC RID: 28636
		// (get) Token: 0x0602C8E0 RID: 182496 RVA: 0x00A22883 File Offset: 0x00A20A83
		// (set) Token: 0x0602C8E1 RID: 182497 RVA: 0x00A22893 File Offset: 0x00A20A93
		public unsafe bool DebugTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FDD RID: 28637
		// (get) Token: 0x0602C8E2 RID: 182498 RVA: 0x00A228A4 File Offset: 0x00A20AA4
		// (set) Token: 0x0602C8E3 RID: 182499 RVA: 0x00A228B4 File Offset: 0x00A20AB4
		public unsafe int Navigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17006FDE RID: 28638
		// (get) Token: 0x0602C8E4 RID: 182500 RVA: 0x00A228C5 File Offset: 0x00A20AC5
		// (set) Token: 0x0602C8E5 RID: 182501 RVA: 0x00A228D5 File Offset: 0x00A20AD5
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17006FDF RID: 28639
		// (get) Token: 0x0602C8E6 RID: 182502 RVA: 0x00A228E6 File Offset: 0x00A20AE6
		// (set) Token: 0x0602C8E7 RID: 182503 RVA: 0x00A228FA File Offset: 0x00A20AFA
		public unsafe TEnumAsByte<ESkillBehaviorBuffTargetType> BuffTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17006FE0 RID: 28640
		// (get) Token: 0x0602C8E8 RID: 182504 RVA: 0x00A2290F File Offset: 0x00A20B0F
		// (set) Token: 0x0602C8E9 RID: 182505 RVA: 0x00A2291F File Offset: 0x00A20B1F
		public unsafe bool Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FE1 RID: 28641
		// (get) Token: 0x0602C8EA RID: 182506 RVA: 0x00A22930 File Offset: 0x00A20B30
		// (set) Token: 0x0602C8EB RID: 182507 RVA: 0x00A22940 File Offset: 0x00A20B40
		public unsafe int MontageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17006FE2 RID: 28642
		// (get) Token: 0x0602C8EC RID: 182508 RVA: 0x00A22951 File Offset: 0x00A20B51
		// (set) Token: 0x0602C8ED RID: 182509 RVA: 0x00A22965 File Offset: 0x00A20B65
		[Nullable(1)]
		public unsafe string StartSection
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_49)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorAction.__PropertyOffset_49)), value);
			}
		}

		// Token: 0x17006FE3 RID: 28643
		// (get) Token: 0x0602C8EE RID: 182510 RVA: 0x00A2297A File Offset: 0x00A20B7A
		// (set) Token: 0x0602C8EF RID: 182511 RVA: 0x00A2298A File Offset: 0x00A20B8A
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17006FE4 RID: 28644
		// (get) Token: 0x0602C8F0 RID: 182512 RVA: 0x00A2299C File Offset: 0x00A20B9C
		// (set) Token: 0x0602C8F1 RID: 182513 RVA: 0x00A229DF File Offset: 0x00A20BDF
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
					result = (this._UpdateCustomValue = new SSkillBehaviorUpdateCustomValue(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_51, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorUpdateCustomValue.StaticStruct(), base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_51, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FE5 RID: 28645
		// (get) Token: 0x0602C8F2 RID: 182514 RVA: 0x00A22A00 File Offset: 0x00A20C00
		// (set) Token: 0x0602C8F3 RID: 182515 RVA: 0x00A22A1F File Offset: 0x00A20C1F
		[Nullable(1)]
		public TSoftObjectPtr<UPrimaryDataAsset> CommonConf
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_52, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_52, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006FE6 RID: 28646
		// (get) Token: 0x0602C8F4 RID: 182516 RVA: 0x00A22A44 File Offset: 0x00A20C44
		// (set) Token: 0x0602C8F5 RID: 182517 RVA: 0x00A22A58 File Offset: 0x00A20C58
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorAction.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x0602C8F6 RID: 182518 RVA: 0x00A22A6D File Offset: 0x00A20C6D
		public SSkillBehaviorAction()
		{
		}

		// Token: 0x0602C8F7 RID: 182519 RVA: 0x00A22A78 File Offset: 0x00A20C78
		public SSkillBehaviorAction(TEnumAsByte<ESkillBehaviorActionType> ActionType, TEnumAsByte<ESkillBehaviorLocationType> LocationType, [Nullable(1)] string BlackboardKey, TEnumAsByte<ESkillBehaviorLocationForwardType> LocationForwardType, FVector LocationOffset, bool Restrict, TEnumAsByte<ESkillBehaviorRestrictType> RestrictType, int RestrictDistance, bool BestSpot, TEnumAsByte<ESkillBehaviorRotationType> RotationType, float DirectionOffset, [Nullable(1)] TArray<SSkillBehaviorCue> Cues, [Nullable(1)] TArray<SSkillBehaviorBullet> Bullets, FGameplayTag Tag, float Duration, float BlendInTime, float BlendOutTime, float BreakBlendOutTime, [Nullable(1)] SBaseCurve BlendInCurve, [Nullable(1)] SBaseCurve BlendOutCurve, TEnumAsByte<ECameraAnsEffectiveClientType> CameraEffectiveClientType, [Nullable(1)] TArray<SCameraModifier_Condition> CameraModifierConditions, [Nullable(1)] SCameraModifier_Settings CameraModifierSettings, [Nullable(1)] SSequenceCamera_Settings CameraSequenceSettings, bool ResetLockOnCamera, FRotator AdditiveRotation, FName CameraAttachSocket, FName CameraDetectSocket, float ExtraDetectSphereRadius, FVector ExtraSphereLocation, bool IsShowExtraSphere, TEnumAsByte<EMovementMode> BeginMovementMode, TEnumAsByte<EMovementMode> EndMovementMode, TEnumAsByte<ECollisionResponse> CollisionResponse, TEnumAsByte<ECollisionChannel> CollisionChannel, bool CollisionRestore, int FollowIndex, int SummonSkillId, bool StopSummonSkill, TEnumAsByte<ESkillBehaviorBestSpotType> Strategy, [Nullable(1)] TArray<float> AngleOffsets, bool OnGround, int GroundOffset, bool DebugTrace, int Navigation, long BuffId, TEnumAsByte<ESkillBehaviorBuffTargetType> BuffTarget, bool Add, int MontageIndex, [Nullable(1)] string StartSection, float StartTime, [Nullable(1)] SSkillBehaviorUpdateCustomValue UpdateCustomValue, [Nullable(1)] TSoftObjectPtr<UPrimaryDataAsset> CommonConf, FName BoneName)
		{
			this.ActionType = ActionType;
			this.LocationType = LocationType;
			this.BlackboardKey = BlackboardKey;
			this.LocationForwardType = LocationForwardType;
			this.LocationOffset = LocationOffset;
			this.Restrict = Restrict;
			this.RestrictType = RestrictType;
			this.RestrictDistance = RestrictDistance;
			this.BestSpot = BestSpot;
			this.RotationType = RotationType;
			this.DirectionOffset = DirectionOffset;
			this.Cues = Cues;
			this.Bullets = Bullets;
			this.Tag = Tag;
			this.Duration = Duration;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.BreakBlendOutTime = BreakBlendOutTime;
			this.BlendInCurve = BlendInCurve;
			this.BlendOutCurve = BlendOutCurve;
			this.CameraEffectiveClientType = CameraEffectiveClientType;
			this.CameraModifierConditions = CameraModifierConditions;
			this.CameraModifierSettings = CameraModifierSettings;
			this.CameraSequenceSettings = CameraSequenceSettings;
			this.ResetLockOnCamera = ResetLockOnCamera;
			this.AdditiveRotation = AdditiveRotation;
			this.CameraAttachSocket = CameraAttachSocket;
			this.CameraDetectSocket = CameraDetectSocket;
			this.ExtraDetectSphereRadius = ExtraDetectSphereRadius;
			this.ExtraSphereLocation = ExtraSphereLocation;
			this.IsShowExtraSphere = IsShowExtraSphere;
			this.BeginMovementMode = BeginMovementMode;
			this.EndMovementMode = EndMovementMode;
			this.CollisionResponse = CollisionResponse;
			this.CollisionChannel = CollisionChannel;
			this.CollisionRestore = CollisionRestore;
			this.FollowIndex = FollowIndex;
			this.SummonSkillId = SummonSkillId;
			this.StopSummonSkill = StopSummonSkill;
			this.Strategy = Strategy;
			this.AngleOffsets = AngleOffsets;
			this.OnGround = OnGround;
			this.GroundOffset = GroundOffset;
			this.DebugTrace = DebugTrace;
			this.Navigation = Navigation;
			this.BuffId = BuffId;
			this.BuffTarget = BuffTarget;
			this.Add = Add;
			this.MontageIndex = MontageIndex;
			this.StartSection = StartSection;
			this.StartTime = StartTime;
			this.UpdateCustomValue = UpdateCustomValue;
			this.CommonConf = CommonConf;
			this.BoneName = BoneName;
		}

		// Token: 0x0602C8F8 RID: 182520 RVA: 0x00A22C38 File Offset: 0x00A20E38
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorAction.StaticStruct();
		}

		// Token: 0x0602C8F9 RID: 182521 RVA: 0x00A22C44 File Offset: 0x00A20E44
		[NullableContext(2)]
		public SSkillBehaviorAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C8FA RID: 182522 RVA: 0x00A22C4E File Offset: 0x00A20E4E
		public SSkillBehaviorAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C8FB RID: 182523 RVA: 0x00A22C59 File Offset: 0x00A20E59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorAction(Pointer, false, true);
		}

		// Token: 0x0602C8FC RID: 182524 RVA: 0x00A22C63 File Offset: 0x00A20E63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorAction(Pointer, MemoryOwner);
		}

		// Token: 0x04017798 RID: 96152
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorAction.SSkillBehaviorAction";

		// Token: 0x04017799 RID: 96153
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401779A RID: 96154
		internal static int __PropertyOffset_0;

		// Token: 0x0401779B RID: 96155
		internal static int __PropertyOffset_1;

		// Token: 0x0401779C RID: 96156
		internal static int __PropertyOffset_2;

		// Token: 0x0401779D RID: 96157
		internal static int __PropertyOffset_3;

		// Token: 0x0401779E RID: 96158
		internal static int __PropertyOffset_4;

		// Token: 0x0401779F RID: 96159
		internal static int __PropertyOffset_5;

		// Token: 0x040177A0 RID: 96160
		internal static int __PropertyOffset_6;

		// Token: 0x040177A1 RID: 96161
		internal static int __PropertyOffset_7;

		// Token: 0x040177A2 RID: 96162
		internal static int __PropertyOffset_8;

		// Token: 0x040177A3 RID: 96163
		internal static int __PropertyOffset_9;

		// Token: 0x040177A4 RID: 96164
		internal static int __PropertyOffset_10;

		// Token: 0x040177A5 RID: 96165
		internal static int __PropertyOffset_11;

		// Token: 0x040177A6 RID: 96166
		[Nullable(2)]
		private TArray<SSkillBehaviorCue> _Cues;

		// Token: 0x040177A7 RID: 96167
		internal static int __PropertyOffset_12;

		// Token: 0x040177A8 RID: 96168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorBullet> _Bullets;

		// Token: 0x040177A9 RID: 96169
		internal static int __PropertyOffset_13;

		// Token: 0x040177AA RID: 96170
		internal static int __PropertyOffset_14;

		// Token: 0x040177AB RID: 96171
		internal static int __PropertyOffset_15;

		// Token: 0x040177AC RID: 96172
		internal static int __PropertyOffset_16;

		// Token: 0x040177AD RID: 96173
		internal static int __PropertyOffset_17;

		// Token: 0x040177AE RID: 96174
		internal static int __PropertyOffset_18;

		// Token: 0x040177AF RID: 96175
		[Nullable(2)]
		private SBaseCurve _BlendInCurve;

		// Token: 0x040177B0 RID: 96176
		internal static int __PropertyOffset_19;

		// Token: 0x040177B1 RID: 96177
		[Nullable(2)]
		private SBaseCurve _BlendOutCurve;

		// Token: 0x040177B2 RID: 96178
		internal static int __PropertyOffset_20;

		// Token: 0x040177B3 RID: 96179
		internal static int __PropertyOffset_21;

		// Token: 0x040177B4 RID: 96180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Condition> _CameraModifierConditions;

		// Token: 0x040177B5 RID: 96181
		internal static int __PropertyOffset_22;

		// Token: 0x040177B6 RID: 96182
		[Nullable(2)]
		private SCameraModifier_Settings _CameraModifierSettings;

		// Token: 0x040177B7 RID: 96183
		internal static int __PropertyOffset_23;

		// Token: 0x040177B8 RID: 96184
		[Nullable(2)]
		private SSequenceCamera_Settings _CameraSequenceSettings;

		// Token: 0x040177B9 RID: 96185
		internal static int __PropertyOffset_24;

		// Token: 0x040177BA RID: 96186
		internal static int __PropertyOffset_25;

		// Token: 0x040177BB RID: 96187
		internal static int __PropertyOffset_26;

		// Token: 0x040177BC RID: 96188
		internal static int __PropertyOffset_27;

		// Token: 0x040177BD RID: 96189
		internal static int __PropertyOffset_28;

		// Token: 0x040177BE RID: 96190
		internal static int __PropertyOffset_29;

		// Token: 0x040177BF RID: 96191
		internal static int __PropertyOffset_30;

		// Token: 0x040177C0 RID: 96192
		internal static int __PropertyOffset_31;

		// Token: 0x040177C1 RID: 96193
		internal static int __PropertyOffset_32;

		// Token: 0x040177C2 RID: 96194
		internal static int __PropertyOffset_33;

		// Token: 0x040177C3 RID: 96195
		internal static int __PropertyOffset_34;

		// Token: 0x040177C4 RID: 96196
		internal static int __PropertyOffset_35;

		// Token: 0x040177C5 RID: 96197
		internal static int __PropertyOffset_36;

		// Token: 0x040177C6 RID: 96198
		internal static int __PropertyOffset_37;

		// Token: 0x040177C7 RID: 96199
		internal static int __PropertyOffset_38;

		// Token: 0x040177C8 RID: 96200
		internal static int __PropertyOffset_39;

		// Token: 0x040177C9 RID: 96201
		internal static int __PropertyOffset_40;

		// Token: 0x040177CA RID: 96202
		[Nullable(2)]
		private TArray<float> _AngleOffsets;

		// Token: 0x040177CB RID: 96203
		internal static int __PropertyOffset_41;

		// Token: 0x040177CC RID: 96204
		internal static int __PropertyOffset_42;

		// Token: 0x040177CD RID: 96205
		internal static int __PropertyOffset_43;

		// Token: 0x040177CE RID: 96206
		internal static int __PropertyOffset_44;

		// Token: 0x040177CF RID: 96207
		internal static int __PropertyOffset_45;

		// Token: 0x040177D0 RID: 96208
		internal static int __PropertyOffset_46;

		// Token: 0x040177D1 RID: 96209
		internal static int __PropertyOffset_47;

		// Token: 0x040177D2 RID: 96210
		internal static int __PropertyOffset_48;

		// Token: 0x040177D3 RID: 96211
		internal static int __PropertyOffset_49;

		// Token: 0x040177D4 RID: 96212
		internal static int __PropertyOffset_50;

		// Token: 0x040177D5 RID: 96213
		internal static int __PropertyOffset_51;

		// Token: 0x040177D6 RID: 96214
		[Nullable(2)]
		private SSkillBehaviorUpdateCustomValue _UpdateCustomValue;

		// Token: 0x040177D7 RID: 96215
		internal static int __PropertyOffset_52;

		// Token: 0x040177D8 RID: 96216
		internal static int __PropertyOffset_53;
	}
}
