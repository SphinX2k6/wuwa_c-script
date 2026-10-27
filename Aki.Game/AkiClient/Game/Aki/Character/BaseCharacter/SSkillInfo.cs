using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004334 RID: 17204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 484)]
	public class SSkillInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C984 RID: 182660 RVA: 0x00A237C6 File Offset: 0x00A219C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillInfo._ScriptStructPtr != 0) ? SSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo", ref SSkillInfo._ScriptStructPtr);
		}

		// Token: 0x1700700F RID: 28687
		// (get) Token: 0x0602C985 RID: 182661 RVA: 0x00A237EA File Offset: 0x00A219EA
		// (set) Token: 0x0602C986 RID: 182662 RVA: 0x00A237FE File Offset: 0x00A219FE
		public unsafe FName SkillName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007010 RID: 28688
		// (get) Token: 0x0602C987 RID: 182663 RVA: 0x00A23814 File Offset: 0x00A21A14
		// (set) Token: 0x0602C988 RID: 182664 RVA: 0x00A23857 File Offset: 0x00A21A57
		public FSoftObjectPath SkillIcon
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SkillIcon) == null)
				{
					result = (this._SkillIcon = new FSoftObjectPath(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007011 RID: 28689
		// (get) Token: 0x0602C989 RID: 182665 RVA: 0x00A23878 File Offset: 0x00A21A78
		// (set) Token: 0x0602C98A RID: 182666 RVA: 0x00A2388C File Offset: 0x00A21A8C
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillMode> SkillMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_2);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007012 RID: 28690
		// (get) Token: 0x0602C98B RID: 182667 RVA: 0x00A238A4 File Offset: 0x00A21AA4
		// (set) Token: 0x0602C98C RID: 182668 RVA: 0x00A238E7 File Offset: 0x00A21AE7
		public TArray<SSkillTrigger> SkillTriggers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillTrigger> result;
				if ((result = this._SkillTriggers) == null)
				{
					result = (this._SkillTriggers = new TArray<SSkillTrigger>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillTriggers.CopyAssign(value);
			}
		}

		// Token: 0x17007013 RID: 28691
		// (get) Token: 0x0602C98D RID: 182669 RVA: 0x00A238F8 File Offset: 0x00A21AF8
		// (set) Token: 0x0602C98E RID: 182670 RVA: 0x00A2393B File Offset: 0x00A21B3B
		public TArray<SSkillBehavior> SkillBehaviorGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehavior> result;
				if ((result = this._SkillBehaviorGroup) == null)
				{
					result = (this._SkillBehaviorGroup = new TArray<SSkillBehavior>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorGroup.CopyAssign(value);
			}
		}

		// Token: 0x17007014 RID: 28692
		// (get) Token: 0x0602C98F RID: 182671 RVA: 0x00A2394C File Offset: 0x00A21B4C
		// (set) Token: 0x0602C990 RID: 182672 RVA: 0x00A2398F File Offset: 0x00A21B8F
		public FSoftClassPath SkillGA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._SkillGA) == null)
				{
					result = (this._SkillGA = new FSoftClassPath(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007015 RID: 28693
		// (get) Token: 0x0602C991 RID: 182673 RVA: 0x00A239B0 File Offset: 0x00A21BB0
		// (set) Token: 0x0602C992 RID: 182674 RVA: 0x00A239F3 File Offset: 0x00A21BF3
		public TArray<FSoftObjectPath> Animations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._Animations) == null)
				{
					result = (this._Animations = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Animations.CopyAssign(value);
			}
		}

		// Token: 0x17007016 RID: 28694
		// (get) Token: 0x0602C993 RID: 182675 RVA: 0x00A23A04 File Offset: 0x00A21C04
		// (set) Token: 0x0602C994 RID: 182676 RVA: 0x00A23A47 File Offset: 0x00A21C47
		public TArray<string> MontagePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontagePaths) == null)
				{
					result = (this._MontagePaths = new TArray<string>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MontagePaths.CopyAssign(value);
			}
		}

		// Token: 0x17007017 RID: 28695
		// (get) Token: 0x0602C995 RID: 182677 RVA: 0x00A23A58 File Offset: 0x00A21C58
		// (set) Token: 0x0602C996 RID: 182678 RVA: 0x00A23A9B File Offset: 0x00A21C9B
		public TArray<FGameplayTag> SkillTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._SkillTag) == null)
				{
					result = (this._SkillTag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillTag.CopyAssign(value);
			}
		}

		// Token: 0x17007018 RID: 28696
		// (get) Token: 0x0602C997 RID: 182679 RVA: 0x00A23AA9 File Offset: 0x00A21CA9
		// (set) Token: 0x0602C998 RID: 182680 RVA: 0x00A23AB9 File Offset: 0x00A21CB9
		public unsafe int GroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007019 RID: 28697
		// (get) Token: 0x0602C999 RID: 182681 RVA: 0x00A23ACA File Offset: 0x00A21CCA
		// (set) Token: 0x0602C99A RID: 182682 RVA: 0x00A23ADA File Offset: 0x00A21CDA
		public unsafe int InterruptLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700701A RID: 28698
		// (get) Token: 0x0602C99B RID: 182683 RVA: 0x00A23AEB File Offset: 0x00A21CEB
		// (set) Token: 0x0602C99C RID: 182684 RVA: 0x00A23AFF File Offset: 0x00A21CFF
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillGenre> SkillGenre
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700701B RID: 28699
		// (get) Token: 0x0602C99D RID: 182685 RVA: 0x00A23B14 File Offset: 0x00A21D14
		// (set) Token: 0x0602C99E RID: 182686 RVA: 0x00A23B57 File Offset: 0x00A21D57
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ESkillGenre>> SkillGenreGroup
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ESkillGenre>> result;
				if ((result = this._SkillGenreGroup) == null)
				{
					result = (this._SkillGenreGroup = new TArray<TEnumAsByte<ESkillGenre>>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.SkillGenreGroup.CopyAssign(value);
			}
		}

		// Token: 0x1700701C RID: 28700
		// (get) Token: 0x0602C99F RID: 182687 RVA: 0x00A23B65 File Offset: 0x00A21D65
		// (set) Token: 0x0602C9A0 RID: 182688 RVA: 0x00A23B75 File Offset: 0x00A21D75
		public unsafe bool IsLockOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700701D RID: 28701
		// (get) Token: 0x0602C9A1 RID: 182689 RVA: 0x00A23B88 File Offset: 0x00A21D88
		// (set) Token: 0x0602C9A2 RID: 182690 RVA: 0x00A23BCB File Offset: 0x00A21DCB
		public SSkillTarget SkillTarget
		{
			get
			{
				base.FastCheckIsValid();
				SSkillTarget result;
				if ((result = this._SkillTarget) == null)
				{
					result = (this._SkillTarget = new SSkillTarget(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_14, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillTarget.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700701E RID: 28702
		// (get) Token: 0x0602C9A3 RID: 182691 RVA: 0x00A23BEC File Offset: 0x00A21DEC
		// (set) Token: 0x0602C9A4 RID: 182692 RVA: 0x00A23C00 File Offset: 0x00A21E00
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillTargetDirection> SkillDirection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700701F RID: 28703
		// (get) Token: 0x0602C9A5 RID: 182693 RVA: 0x00A23C18 File Offset: 0x00A21E18
		// (set) Token: 0x0602C9A6 RID: 182694 RVA: 0x00A23C5B File Offset: 0x00A21E5B
		public SSkillCooldownInfo CooldownConfig
		{
			get
			{
				base.FastCheckIsValid();
				SSkillCooldownInfo result;
				if ((result = this._CooldownConfig) == null)
				{
					result = (this._CooldownConfig = new SSkillCooldownInfo(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillCooldownInfo.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007020 RID: 28704
		// (get) Token: 0x0602C9A7 RID: 182695 RVA: 0x00A23C7C File Offset: 0x00A21E7C
		// (set) Token: 0x0602C9A8 RID: 182696 RVA: 0x00A23C8C File Offset: 0x00A21E8C
		public unsafe bool WalkOffLedge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007021 RID: 28705
		// (get) Token: 0x0602C9A9 RID: 182697 RVA: 0x00A23CA0 File Offset: 0x00A21EA0
		// (set) Token: 0x0602C9AA RID: 182698 RVA: 0x00A23CE3 File Offset: 0x00A21EE3
		public TArray<long> SkillBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillBuff) == null)
				{
					result = (this._SkillBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBuff.CopyAssign(value);
			}
		}

		// Token: 0x17007022 RID: 28706
		// (get) Token: 0x0602C9AB RID: 182699 RVA: 0x00A23CF4 File Offset: 0x00A21EF4
		// (set) Token: 0x0602C9AC RID: 182700 RVA: 0x00A23D37 File Offset: 0x00A21F37
		public TArray<long> SkillStartBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillStartBuff) == null)
				{
					result = (this._SkillStartBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_19, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillStartBuff.CopyAssign(value);
			}
		}

		// Token: 0x17007023 RID: 28707
		// (get) Token: 0x0602C9AD RID: 182701 RVA: 0x00A23D48 File Offset: 0x00A21F48
		// (set) Token: 0x0602C9AE RID: 182702 RVA: 0x00A23D8B File Offset: 0x00A21F8B
		public TArray<long> StartRemoveBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._StartRemoveBuffIds) == null)
				{
					result = (this._StartRemoveBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StartRemoveBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x17007024 RID: 28708
		// (get) Token: 0x0602C9AF RID: 182703 RVA: 0x00A23D9C File Offset: 0x00A21F9C
		// (set) Token: 0x0602C9B0 RID: 182704 RVA: 0x00A23DDF File Offset: 0x00A21FDF
		public TArray<long> SkillEndBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillEndBuff) == null)
				{
					result = (this._SkillEndBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_21, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillEndBuff.CopyAssign(value);
			}
		}

		// Token: 0x17007025 RID: 28709
		// (get) Token: 0x0602C9B1 RID: 182705 RVA: 0x00A23DF0 File Offset: 0x00A21FF0
		// (set) Token: 0x0602C9B2 RID: 182706 RVA: 0x00A23E33 File Offset: 0x00A22033
		public TArray<long> EndRemoveBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._EndRemoveBuffIds) == null)
				{
					result = (this._EndRemoveBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_22, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndRemoveBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x17007026 RID: 28710
		// (get) Token: 0x0602C9B3 RID: 182707 RVA: 0x00A23E41 File Offset: 0x00A22041
		// (set) Token: 0x0602C9B4 RID: 182708 RVA: 0x00A23E51 File Offset: 0x00A22051
		public unsafe float ToughRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17007027 RID: 28711
		// (get) Token: 0x0602C9B5 RID: 182709 RVA: 0x00A23E62 File Offset: 0x00A22062
		// (set) Token: 0x0602C9B6 RID: 182710 RVA: 0x00A23E72 File Offset: 0x00A22072
		public unsafe float StrengthCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17007028 RID: 28712
		// (get) Token: 0x0602C9B7 RID: 182711 RVA: 0x00A23E83 File Offset: 0x00A22083
		// (set) Token: 0x0602C9B8 RID: 182712 RVA: 0x00A23E93 File Offset: 0x00A22093
		public unsafe bool IsFullBodySkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007029 RID: 28713
		// (get) Token: 0x0602C9B9 RID: 182713 RVA: 0x00A23EA4 File Offset: 0x00A220A4
		// (set) Token: 0x0602C9BA RID: 182714 RVA: 0x00A23EB4 File Offset: 0x00A220B4
		public unsafe bool AutonomouslyBySimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700702A RID: 28714
		// (get) Token: 0x0602C9BB RID: 182715 RVA: 0x00A23EC5 File Offset: 0x00A220C5
		// (set) Token: 0x0602C9BC RID: 182716 RVA: 0x00A23ED5 File Offset: 0x00A220D5
		public unsafe float MoveControllerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700702B RID: 28715
		// (get) Token: 0x0602C9BD RID: 182717 RVA: 0x00A23EE6 File Offset: 0x00A220E6
		// (set) Token: 0x0602C9BE RID: 182718 RVA: 0x00A23EF6 File Offset: 0x00A220F6
		public unsafe float ImmuneFallDamageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700702C RID: 28716
		// (get) Token: 0x0602C9BF RID: 182719 RVA: 0x00A23F07 File Offset: 0x00A22107
		// (set) Token: 0x0602C9C0 RID: 182720 RVA: 0x00A23F17 File Offset: 0x00A22117
		public unsafe bool OverrideHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700702D RID: 28717
		// (get) Token: 0x0602C9C1 RID: 182721 RVA: 0x00A23F28 File Offset: 0x00A22128
		// (set) Token: 0x0602C9C2 RID: 182722 RVA: 0x00A23F3C File Offset: 0x00A2213C
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillOverrideType> OverrideType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_30);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700702E RID: 28718
		// (get) Token: 0x0602C9C3 RID: 182723 RVA: 0x00A23F54 File Offset: 0x00A22154
		// (set) Token: 0x0602C9C4 RID: 182724 RVA: 0x00A23F97 File Offset: 0x00A22197
		public TArray<FSoftObjectPath> ExportSpecialAnim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ExportSpecialAnim) == null)
				{
					result = (this._ExportSpecialAnim = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_31, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExportSpecialAnim.CopyAssign(value);
			}
		}

		// Token: 0x1700702F RID: 28719
		// (get) Token: 0x0602C9C5 RID: 182725 RVA: 0x00A23FA5 File Offset: 0x00A221A5
		// (set) Token: 0x0602C9C6 RID: 182726 RVA: 0x00A23FB5 File Offset: 0x00A221B5
		public unsafe bool MontageDelayOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007030 RID: 28720
		// (get) Token: 0x0602C9C7 RID: 182727 RVA: 0x00A23FC6 File Offset: 0x00A221C6
		// (set) Token: 0x0602C9C8 RID: 182728 RVA: 0x00A23FD6 File Offset: 0x00A221D6
		public unsafe bool SkillStepUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007031 RID: 28721
		// (get) Token: 0x0602C9C9 RID: 182729 RVA: 0x00A23FE7 File Offset: 0x00A221E7
		// (set) Token: 0x0602C9CA RID: 182730 RVA: 0x00A23FF7 File Offset: 0x00A221F7
		public unsafe bool SkillCanBeginWithoutControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007032 RID: 28722
		// (get) Token: 0x0602C9CB RID: 182731 RVA: 0x00A24008 File Offset: 0x00A22208
		// (set) Token: 0x0602C9CC RID: 182732 RVA: 0x00A24018 File Offset: 0x00A22218
		public unsafe int MaxCounterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17007033 RID: 28723
		// (get) Token: 0x0602C9CD RID: 182733 RVA: 0x00A2402C File Offset: 0x00A2222C
		// (set) Token: 0x0602C9CE RID: 182734 RVA: 0x00A2406F File Offset: 0x00A2226F
		public TArray<long> SpecialBuffInCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SpecialBuffInCode) == null)
				{
					result = (this._SpecialBuffInCode = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_36, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecialBuffInCode.CopyAssign(value);
			}
		}

		// Token: 0x17007034 RID: 28724
		// (get) Token: 0x0602C9CF RID: 182735 RVA: 0x00A2407D File Offset: 0x00A2227D
		// (set) Token: 0x0602C9D0 RID: 182736 RVA: 0x00A2408D File Offset: 0x00A2228D
		public unsafe float BurstLockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x0602C9D1 RID: 182737 RVA: 0x00A2409E File Offset: 0x00A2229E
		public SSkillInfo()
		{
		}

		// Token: 0x0602C9D2 RID: 182738 RVA: 0x00A240A8 File Offset: 0x00A222A8
		public SSkillInfo(FName SkillName, FSoftObjectPath SkillIcon, [Nullable(0)] TEnumAsByte<ESkillMode> SkillMode, TArray<SSkillTrigger> SkillTriggers, TArray<SSkillBehavior> SkillBehaviorGroup, FSoftClassPath SkillGA, TArray<FSoftObjectPath> Animations, TArray<string> MontagePaths, TArray<FGameplayTag> SkillTag, int GroupId, int InterruptLevel, [Nullable(0)] TEnumAsByte<ESkillGenre> SkillGenre, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ESkillGenre>> SkillGenreGroup, bool IsLockOn, SSkillTarget SkillTarget, [Nullable(0)] TEnumAsByte<ESkillTargetDirection> SkillDirection, SSkillCooldownInfo CooldownConfig, bool WalkOffLedge, TArray<long> SkillBuff, TArray<long> SkillStartBuff, TArray<long> StartRemoveBuffIds, TArray<long> SkillEndBuff, TArray<long> EndRemoveBuffIds, float ToughRatio, float StrengthCost, bool IsFullBodySkill, bool AutonomouslyBySimulate, float MoveControllerTime, float ImmuneFallDamageTime, bool OverrideHit, [Nullable(0)] TEnumAsByte<ESkillOverrideType> OverrideType, TArray<FSoftObjectPath> ExportSpecialAnim, bool MontageDelayOneFrame, bool SkillStepUp, bool SkillCanBeginWithoutControl, int MaxCounterCount, TArray<long> SpecialBuffInCode, float BurstLockTime)
		{
			this.SkillName = SkillName;
			this.SkillIcon = SkillIcon;
			this.SkillMode = SkillMode;
			this.SkillTriggers = SkillTriggers;
			this.SkillBehaviorGroup = SkillBehaviorGroup;
			this.SkillGA = SkillGA;
			this.Animations = Animations;
			this.MontagePaths = MontagePaths;
			this.SkillTag = SkillTag;
			this.GroupId = GroupId;
			this.InterruptLevel = InterruptLevel;
			this.SkillGenre = SkillGenre;
			this.SkillGenreGroup = SkillGenreGroup;
			this.IsLockOn = IsLockOn;
			this.SkillTarget = SkillTarget;
			this.SkillDirection = SkillDirection;
			this.CooldownConfig = CooldownConfig;
			this.WalkOffLedge = WalkOffLedge;
			this.SkillBuff = SkillBuff;
			this.SkillStartBuff = SkillStartBuff;
			this.StartRemoveBuffIds = StartRemoveBuffIds;
			this.SkillEndBuff = SkillEndBuff;
			this.EndRemoveBuffIds = EndRemoveBuffIds;
			this.ToughRatio = ToughRatio;
			this.StrengthCost = StrengthCost;
			this.IsFullBodySkill = IsFullBodySkill;
			this.AutonomouslyBySimulate = AutonomouslyBySimulate;
			this.MoveControllerTime = MoveControllerTime;
			this.ImmuneFallDamageTime = ImmuneFallDamageTime;
			this.OverrideHit = OverrideHit;
			this.OverrideType = OverrideType;
			this.ExportSpecialAnim = ExportSpecialAnim;
			this.MontageDelayOneFrame = MontageDelayOneFrame;
			this.SkillStepUp = SkillStepUp;
			this.SkillCanBeginWithoutControl = SkillCanBeginWithoutControl;
			this.MaxCounterCount = MaxCounterCount;
			this.SpecialBuffInCode = SpecialBuffInCode;
			this.BurstLockTime = BurstLockTime;
		}

		// Token: 0x0602C9D3 RID: 182739 RVA: 0x00A241E8 File Offset: 0x00A223E8
		protected override IntPtr GetUStructPtr()
		{
			return SSkillInfo.StaticStruct();
		}

		// Token: 0x0602C9D4 RID: 182740 RVA: 0x00A241F4 File Offset: 0x00A223F4
		[NullableContext(2)]
		public SSkillInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C9D5 RID: 182741 RVA: 0x00A241FE File Offset: 0x00A223FE
		public SSkillInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C9D6 RID: 182742 RVA: 0x00A24209 File Offset: 0x00A22409
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillInfo(Pointer, false, true);
		}

		// Token: 0x0602C9D7 RID: 182743 RVA: 0x00A24213 File Offset: 0x00A22413
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04017819 RID: 96281
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo";

		// Token: 0x0401781A RID: 96282
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401781B RID: 96283
		internal static int __PropertyOffset_0;

		// Token: 0x0401781C RID: 96284
		internal static int __PropertyOffset_1;

		// Token: 0x0401781D RID: 96285
		[Nullable(2)]
		private FSoftObjectPath _SkillIcon;

		// Token: 0x0401781E RID: 96286
		internal static int __PropertyOffset_2;

		// Token: 0x0401781F RID: 96287
		internal static int __PropertyOffset_3;

		// Token: 0x04017820 RID: 96288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillTrigger> _SkillTriggers;

		// Token: 0x04017821 RID: 96289
		internal static int __PropertyOffset_4;

		// Token: 0x04017822 RID: 96290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehavior> _SkillBehaviorGroup;

		// Token: 0x04017823 RID: 96291
		internal static int __PropertyOffset_5;

		// Token: 0x04017824 RID: 96292
		[Nullable(2)]
		private FSoftClassPath _SkillGA;

		// Token: 0x04017825 RID: 96293
		internal static int __PropertyOffset_6;

		// Token: 0x04017826 RID: 96294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _Animations;

		// Token: 0x04017827 RID: 96295
		internal static int __PropertyOffset_7;

		// Token: 0x04017828 RID: 96296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontagePaths;

		// Token: 0x04017829 RID: 96297
		internal static int __PropertyOffset_8;

		// Token: 0x0401782A RID: 96298
		[Nullable(2)]
		private TArray<FGameplayTag> _SkillTag;

		// Token: 0x0401782B RID: 96299
		internal static int __PropertyOffset_9;

		// Token: 0x0401782C RID: 96300
		internal static int __PropertyOffset_10;

		// Token: 0x0401782D RID: 96301
		internal static int __PropertyOffset_11;

		// Token: 0x0401782E RID: 96302
		internal static int __PropertyOffset_12;

		// Token: 0x0401782F RID: 96303
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ESkillGenre>> _SkillGenreGroup;

		// Token: 0x04017830 RID: 96304
		internal static int __PropertyOffset_13;

		// Token: 0x04017831 RID: 96305
		internal static int __PropertyOffset_14;

		// Token: 0x04017832 RID: 96306
		[Nullable(2)]
		private SSkillTarget _SkillTarget;

		// Token: 0x04017833 RID: 96307
		internal static int __PropertyOffset_15;

		// Token: 0x04017834 RID: 96308
		internal static int __PropertyOffset_16;

		// Token: 0x04017835 RID: 96309
		[Nullable(2)]
		private SSkillCooldownInfo _CooldownConfig;

		// Token: 0x04017836 RID: 96310
		internal static int __PropertyOffset_17;

		// Token: 0x04017837 RID: 96311
		internal static int __PropertyOffset_18;

		// Token: 0x04017838 RID: 96312
		[Nullable(2)]
		private TArray<long> _SkillBuff;

		// Token: 0x04017839 RID: 96313
		internal static int __PropertyOffset_19;

		// Token: 0x0401783A RID: 96314
		[Nullable(2)]
		private TArray<long> _SkillStartBuff;

		// Token: 0x0401783B RID: 96315
		internal static int __PropertyOffset_20;

		// Token: 0x0401783C RID: 96316
		[Nullable(2)]
		private TArray<long> _StartRemoveBuffIds;

		// Token: 0x0401783D RID: 96317
		internal static int __PropertyOffset_21;

		// Token: 0x0401783E RID: 96318
		[Nullable(2)]
		private TArray<long> _SkillEndBuff;

		// Token: 0x0401783F RID: 96319
		internal static int __PropertyOffset_22;

		// Token: 0x04017840 RID: 96320
		[Nullable(2)]
		private TArray<long> _EndRemoveBuffIds;

		// Token: 0x04017841 RID: 96321
		internal static int __PropertyOffset_23;

		// Token: 0x04017842 RID: 96322
		internal static int __PropertyOffset_24;

		// Token: 0x04017843 RID: 96323
		internal static int __PropertyOffset_25;

		// Token: 0x04017844 RID: 96324
		internal static int __PropertyOffset_26;

		// Token: 0x04017845 RID: 96325
		internal static int __PropertyOffset_27;

		// Token: 0x04017846 RID: 96326
		internal static int __PropertyOffset_28;

		// Token: 0x04017847 RID: 96327
		internal static int __PropertyOffset_29;

		// Token: 0x04017848 RID: 96328
		internal static int __PropertyOffset_30;

		// Token: 0x04017849 RID: 96329
		internal static int __PropertyOffset_31;

		// Token: 0x0401784A RID: 96330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ExportSpecialAnim;

		// Token: 0x0401784B RID: 96331
		internal static int __PropertyOffset_32;

		// Token: 0x0401784C RID: 96332
		internal static int __PropertyOffset_33;

		// Token: 0x0401784D RID: 96333
		internal static int __PropertyOffset_34;

		// Token: 0x0401784E RID: 96334
		internal static int __PropertyOffset_35;

		// Token: 0x0401784F RID: 96335
		internal static int __PropertyOffset_36;

		// Token: 0x04017850 RID: 96336
		[Nullable(2)]
		private TArray<long> _SpecialBuffInCode;

		// Token: 0x04017851 RID: 96337
		internal static int __PropertyOffset_37;
	}
}
