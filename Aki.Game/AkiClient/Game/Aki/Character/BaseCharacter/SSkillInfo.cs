using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336B RID: 13163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 484)]
	public class SSkillInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602166D RID: 136813 RVA: 0x0095FB71 File Offset: 0x0095DD71
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillInfo._ScriptStructPtr != 0) ? SSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo", ref SSkillInfo._ScriptStructPtr);
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x0602166E RID: 136814 RVA: 0x0095FB95 File Offset: 0x0095DD95
		// (set) Token: 0x0602166F RID: 136815 RVA: 0x0095FBA9 File Offset: 0x0095DDA9
		public unsafe FName SkillName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillName) = value;
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x06021670 RID: 136816 RVA: 0x0095FBC0 File Offset: 0x0095DDC0
		// (set) Token: 0x06021671 RID: 136817 RVA: 0x0095FC03 File Offset: 0x0095DE03
		public FSoftObjectPath SkillIcon
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SkillIcon) == null)
				{
					result = (this._SkillIcon = new FSoftObjectPath(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillIcon, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillIcon, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x06021672 RID: 136818 RVA: 0x0095FC24 File Offset: 0x0095DE24
		// (set) Token: 0x06021673 RID: 136819 RVA: 0x0095FC38 File Offset: 0x0095DE38
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillMode> SkillMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillMode) = value;
			}
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x06021674 RID: 136820 RVA: 0x0095FC50 File Offset: 0x0095DE50
		// (set) Token: 0x06021675 RID: 136821 RVA: 0x0095FC93 File Offset: 0x0095DE93
		public TArray<SSkillTrigger> SkillTriggers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillTrigger> result;
				if ((result = this._SkillTriggers) == null)
				{
					result = (this._SkillTriggers = new TArray<SSkillTrigger>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillTriggers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillTriggers.CopyAssign(value);
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x06021676 RID: 136822 RVA: 0x0095FCA4 File Offset: 0x0095DEA4
		// (set) Token: 0x06021677 RID: 136823 RVA: 0x0095FCE7 File Offset: 0x0095DEE7
		public TArray<SSkillBehavior> SkillBehaviorGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehavior> result;
				if ((result = this._SkillBehaviorGroup) == null)
				{
					result = (this._SkillBehaviorGroup = new TArray<SSkillBehavior>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillBehaviorGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorGroup.CopyAssign(value);
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x06021678 RID: 136824 RVA: 0x0095FCF8 File Offset: 0x0095DEF8
		// (set) Token: 0x06021679 RID: 136825 RVA: 0x0095FD3B File Offset: 0x0095DF3B
		public FSoftClassPath SkillGA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._SkillGA) == null)
				{
					result = (this._SkillGA = new FSoftClassPath(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillGA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillGA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0602167A RID: 136826 RVA: 0x0095FD5C File Offset: 0x0095DF5C
		// (set) Token: 0x0602167B RID: 136827 RVA: 0x0095FD9F File Offset: 0x0095DF9F
		public TArray<FSoftObjectPath> Animations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._Animations) == null)
				{
					result = (this._Animations = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_Animations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Animations.CopyAssign(value);
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0602167C RID: 136828 RVA: 0x0095FDB0 File Offset: 0x0095DFB0
		// (set) Token: 0x0602167D RID: 136829 RVA: 0x0095FDF3 File Offset: 0x0095DFF3
		public TArray<string> MontagePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontagePaths) == null)
				{
					result = (this._MontagePaths = new TArray<string>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MontagePaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MontagePaths.CopyAssign(value);
			}
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x0602167E RID: 136830 RVA: 0x0095FE04 File Offset: 0x0095E004
		// (set) Token: 0x0602167F RID: 136831 RVA: 0x0095FE47 File Offset: 0x0095E047
		public TArray<FGameplayTag> SkillTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._SkillTag) == null)
				{
					result = (this._SkillTag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillTag.CopyAssign(value);
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x06021680 RID: 136832 RVA: 0x0095FE55 File Offset: 0x0095E055
		// (set) Token: 0x06021681 RID: 136833 RVA: 0x0095FE65 File Offset: 0x0095E065
		public unsafe int GroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_GroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_GroupId) = value;
			}
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x06021682 RID: 136834 RVA: 0x0095FE76 File Offset: 0x0095E076
		// (set) Token: 0x06021683 RID: 136835 RVA: 0x0095FE86 File Offset: 0x0095E086
		public unsafe int InterruptLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_InterruptLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_InterruptLevel) = value;
			}
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x06021684 RID: 136836 RVA: 0x0095FE97 File Offset: 0x0095E097
		// (set) Token: 0x06021685 RID: 136837 RVA: 0x0095FEAB File Offset: 0x0095E0AB
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillGenre> SkillGenre
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillGenre);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillGenre) = value;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x06021686 RID: 136838 RVA: 0x0095FEC0 File Offset: 0x0095E0C0
		// (set) Token: 0x06021687 RID: 136839 RVA: 0x0095FF03 File Offset: 0x0095E103
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
					result = (this._SkillGenreGroup = new TArray<TEnumAsByte<ESkillGenre>>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillGenreGroup, base.MemoryOwner ?? this));
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

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x06021688 RID: 136840 RVA: 0x0095FF11 File Offset: 0x0095E111
		// (set) Token: 0x06021689 RID: 136841 RVA: 0x0095FF21 File Offset: 0x0095E121
		public unsafe bool IsLockOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_IsLockOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_IsLockOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x0602168A RID: 136842 RVA: 0x0095FF34 File Offset: 0x0095E134
		// (set) Token: 0x0602168B RID: 136843 RVA: 0x0095FF77 File Offset: 0x0095E177
		public SSkillTarget SkillTarget
		{
			get
			{
				base.FastCheckIsValid();
				SSkillTarget result;
				if ((result = this._SkillTarget) == null)
				{
					result = (this._SkillTarget = new SSkillTarget(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillTarget.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x0602168C RID: 136844 RVA: 0x0095FF98 File Offset: 0x0095E198
		// (set) Token: 0x0602168D RID: 136845 RVA: 0x0095FFAC File Offset: 0x0095E1AC
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillTargetDirection> SkillDirection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillDirection);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillDirection) = value;
			}
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x0602168E RID: 136846 RVA: 0x0095FFC4 File Offset: 0x0095E1C4
		// (set) Token: 0x0602168F RID: 136847 RVA: 0x00960007 File Offset: 0x0095E207
		public SSkillCooldownInfo CooldownConfig
		{
			get
			{
				base.FastCheckIsValid();
				SSkillCooldownInfo result;
				if ((result = this._CooldownConfig) == null)
				{
					result = (this._CooldownConfig = new SSkillCooldownInfo(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_CooldownConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillCooldownInfo.StaticStruct(), base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_CooldownConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x06021690 RID: 136848 RVA: 0x00960028 File Offset: 0x0095E228
		// (set) Token: 0x06021691 RID: 136849 RVA: 0x00960038 File Offset: 0x0095E238
		public unsafe bool WalkOffLedge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_WalkOffLedge) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_WalkOffLedge) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x06021692 RID: 136850 RVA: 0x0096004C File Offset: 0x0095E24C
		// (set) Token: 0x06021693 RID: 136851 RVA: 0x0096008F File Offset: 0x0095E28F
		public TArray<long> SkillBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillBuff) == null)
				{
					result = (this._SkillBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillBuff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBuff.CopyAssign(value);
			}
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x06021694 RID: 136852 RVA: 0x009600A0 File Offset: 0x0095E2A0
		// (set) Token: 0x06021695 RID: 136853 RVA: 0x009600E3 File Offset: 0x0095E2E3
		public TArray<long> SkillStartBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillStartBuff) == null)
				{
					result = (this._SkillStartBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillStartBuff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillStartBuff.CopyAssign(value);
			}
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x06021696 RID: 136854 RVA: 0x009600F4 File Offset: 0x0095E2F4
		// (set) Token: 0x06021697 RID: 136855 RVA: 0x00960137 File Offset: 0x0095E337
		public TArray<long> StartRemoveBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._StartRemoveBuffIds) == null)
				{
					result = (this._StartRemoveBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_StartRemoveBuffIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StartRemoveBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x06021698 RID: 136856 RVA: 0x00960148 File Offset: 0x0095E348
		// (set) Token: 0x06021699 RID: 136857 RVA: 0x0096018B File Offset: 0x0095E38B
		public TArray<long> SkillEndBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SkillEndBuff) == null)
				{
					result = (this._SkillEndBuff = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillEndBuff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillEndBuff.CopyAssign(value);
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x0602169A RID: 136858 RVA: 0x0096019C File Offset: 0x0095E39C
		// (set) Token: 0x0602169B RID: 136859 RVA: 0x009601DF File Offset: 0x0095E3DF
		public TArray<long> EndRemoveBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._EndRemoveBuffIds) == null)
				{
					result = (this._EndRemoveBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_EndRemoveBuffIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndRemoveBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0602169C RID: 136860 RVA: 0x009601ED File Offset: 0x0095E3ED
		// (set) Token: 0x0602169D RID: 136861 RVA: 0x009601FD File Offset: 0x0095E3FD
		public unsafe float ToughRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_ToughRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_ToughRatio) = value;
			}
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x0602169E RID: 136862 RVA: 0x0096020E File Offset: 0x0095E40E
		// (set) Token: 0x0602169F RID: 136863 RVA: 0x0096021E File Offset: 0x0095E41E
		public unsafe float StrengthCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_StrengthCost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_StrengthCost) = value;
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x060216A0 RID: 136864 RVA: 0x0096022F File Offset: 0x0095E42F
		// (set) Token: 0x060216A1 RID: 136865 RVA: 0x0096023F File Offset: 0x0095E43F
		public unsafe bool IsFullBodySkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_IsFullBodySkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_IsFullBodySkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x060216A2 RID: 136866 RVA: 0x00960250 File Offset: 0x0095E450
		// (set) Token: 0x060216A3 RID: 136867 RVA: 0x00960260 File Offset: 0x0095E460
		public unsafe bool AutonomouslyBySimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_AutonomouslyBySimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_AutonomouslyBySimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x060216A4 RID: 136868 RVA: 0x00960271 File Offset: 0x0095E471
		// (set) Token: 0x060216A5 RID: 136869 RVA: 0x00960281 File Offset: 0x0095E481
		public unsafe float MoveControllerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MoveControllerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MoveControllerTime) = value;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x060216A6 RID: 136870 RVA: 0x00960292 File Offset: 0x0095E492
		// (set) Token: 0x060216A7 RID: 136871 RVA: 0x009602A2 File Offset: 0x0095E4A2
		public unsafe float ImmuneFallDamageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_ImmuneFallDamageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_ImmuneFallDamageTime) = value;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x060216A8 RID: 136872 RVA: 0x009602B3 File Offset: 0x0095E4B3
		// (set) Token: 0x060216A9 RID: 136873 RVA: 0x009602C3 File Offset: 0x0095E4C3
		public unsafe bool OverrideHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_OverrideHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_OverrideHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x060216AA RID: 136874 RVA: 0x009602D4 File Offset: 0x0095E4D4
		// (set) Token: 0x060216AB RID: 136875 RVA: 0x009602E8 File Offset: 0x0095E4E8
		[Nullable(0)]
		public unsafe TEnumAsByte<ESkillOverrideType> OverrideType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_OverrideType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_OverrideType) = value;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x060216AC RID: 136876 RVA: 0x00960300 File Offset: 0x0095E500
		// (set) Token: 0x060216AD RID: 136877 RVA: 0x00960343 File Offset: 0x0095E543
		public TArray<FSoftObjectPath> ExportSpecialAnim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ExportSpecialAnim) == null)
				{
					result = (this._ExportSpecialAnim = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_ExportSpecialAnim, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExportSpecialAnim.CopyAssign(value);
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x060216AE RID: 136878 RVA: 0x00960351 File Offset: 0x0095E551
		// (set) Token: 0x060216AF RID: 136879 RVA: 0x00960361 File Offset: 0x0095E561
		public unsafe bool MontageDelayOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MontageDelayOneFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MontageDelayOneFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x060216B0 RID: 136880 RVA: 0x00960372 File Offset: 0x0095E572
		// (set) Token: 0x060216B1 RID: 136881 RVA: 0x00960382 File Offset: 0x0095E582
		public unsafe bool SkillStepUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillStepUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillStepUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x060216B2 RID: 136882 RVA: 0x00960393 File Offset: 0x0095E593
		// (set) Token: 0x060216B3 RID: 136883 RVA: 0x009603A3 File Offset: 0x0095E5A3
		public unsafe bool SkillCanBeginWithoutControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillCanBeginWithoutControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SkillCanBeginWithoutControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x060216B4 RID: 136884 RVA: 0x009603B4 File Offset: 0x0095E5B4
		// (set) Token: 0x060216B5 RID: 136885 RVA: 0x009603C4 File Offset: 0x0095E5C4
		public unsafe int MaxCounterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MaxCounterCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_MaxCounterCount) = value;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x060216B6 RID: 136886 RVA: 0x009603D8 File Offset: 0x0095E5D8
		// (set) Token: 0x060216B7 RID: 136887 RVA: 0x0096041B File Offset: 0x0095E61B
		public TArray<long> SpecialBuffInCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SpecialBuffInCode) == null)
				{
					result = (this._SpecialBuffInCode = new TArray<long>(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_SpecialBuffInCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecialBuffInCode.CopyAssign(value);
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x060216B8 RID: 136888 RVA: 0x00960429 File Offset: 0x0095E629
		// (set) Token: 0x060216B9 RID: 136889 RVA: 0x00960439 File Offset: 0x0095E639
		public unsafe float BurstLockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_BurstLockTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillInfo.__PropertyOffset_BurstLockTime) = value;
			}
		}

		// Token: 0x060216BA RID: 136890 RVA: 0x0096044A File Offset: 0x0095E64A
		public SSkillInfo()
		{
		}

		// Token: 0x060216BB RID: 136891 RVA: 0x00960452 File Offset: 0x0095E652
		protected override IntPtr GetUStructPtr()
		{
			return SSkillInfo.StaticStruct();
		}

		// Token: 0x060216BC RID: 136892 RVA: 0x0096045E File Offset: 0x0095E65E
		[NullableContext(2)]
		public SSkillInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216BD RID: 136893 RVA: 0x00960468 File Offset: 0x0095E668
		public SSkillInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216BE RID: 136894 RVA: 0x00960473 File Offset: 0x0095E673
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillInfo(Pointer, false, true);
		}

		// Token: 0x060216BF RID: 136895 RVA: 0x0096047D File Offset: 0x0095E67D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012410 RID: 74768
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillInfo.SSkillInfo";

		// Token: 0x04012411 RID: 74769
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012412 RID: 74770
		internal static int __PropertyOffset_SkillName;

		// Token: 0x04012413 RID: 74771
		internal static int __PropertyOffset_SkillIcon;

		// Token: 0x04012414 RID: 74772
		[Nullable(2)]
		private FSoftObjectPath _SkillIcon;

		// Token: 0x04012415 RID: 74773
		internal static int __PropertyOffset_SkillMode;

		// Token: 0x04012416 RID: 74774
		internal static int __PropertyOffset_SkillTriggers;

		// Token: 0x04012417 RID: 74775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillTrigger> _SkillTriggers;

		// Token: 0x04012418 RID: 74776
		internal static int __PropertyOffset_SkillBehaviorGroup;

		// Token: 0x04012419 RID: 74777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehavior> _SkillBehaviorGroup;

		// Token: 0x0401241A RID: 74778
		internal static int __PropertyOffset_SkillGA;

		// Token: 0x0401241B RID: 74779
		[Nullable(2)]
		private FSoftClassPath _SkillGA;

		// Token: 0x0401241C RID: 74780
		internal static int __PropertyOffset_Animations;

		// Token: 0x0401241D RID: 74781
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _Animations;

		// Token: 0x0401241E RID: 74782
		internal static int __PropertyOffset_MontagePaths;

		// Token: 0x0401241F RID: 74783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontagePaths;

		// Token: 0x04012420 RID: 74784
		internal static int __PropertyOffset_SkillTag;

		// Token: 0x04012421 RID: 74785
		[Nullable(2)]
		private TArray<FGameplayTag> _SkillTag;

		// Token: 0x04012422 RID: 74786
		internal static int __PropertyOffset_GroupId;

		// Token: 0x04012423 RID: 74787
		internal static int __PropertyOffset_InterruptLevel;

		// Token: 0x04012424 RID: 74788
		internal static int __PropertyOffset_SkillGenre;

		// Token: 0x04012425 RID: 74789
		internal static int __PropertyOffset_SkillGenreGroup;

		// Token: 0x04012426 RID: 74790
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ESkillGenre>> _SkillGenreGroup;

		// Token: 0x04012427 RID: 74791
		internal static int __PropertyOffset_IsLockOn;

		// Token: 0x04012428 RID: 74792
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x04012429 RID: 74793
		[Nullable(2)]
		private SSkillTarget _SkillTarget;

		// Token: 0x0401242A RID: 74794
		internal static int __PropertyOffset_SkillDirection;

		// Token: 0x0401242B RID: 74795
		internal static int __PropertyOffset_CooldownConfig;

		// Token: 0x0401242C RID: 74796
		[Nullable(2)]
		private SSkillCooldownInfo _CooldownConfig;

		// Token: 0x0401242D RID: 74797
		internal static int __PropertyOffset_WalkOffLedge;

		// Token: 0x0401242E RID: 74798
		internal static int __PropertyOffset_SkillBuff;

		// Token: 0x0401242F RID: 74799
		[Nullable(2)]
		private TArray<long> _SkillBuff;

		// Token: 0x04012430 RID: 74800
		internal static int __PropertyOffset_SkillStartBuff;

		// Token: 0x04012431 RID: 74801
		[Nullable(2)]
		private TArray<long> _SkillStartBuff;

		// Token: 0x04012432 RID: 74802
		internal static int __PropertyOffset_StartRemoveBuffIds;

		// Token: 0x04012433 RID: 74803
		[Nullable(2)]
		private TArray<long> _StartRemoveBuffIds;

		// Token: 0x04012434 RID: 74804
		internal static int __PropertyOffset_SkillEndBuff;

		// Token: 0x04012435 RID: 74805
		[Nullable(2)]
		private TArray<long> _SkillEndBuff;

		// Token: 0x04012436 RID: 74806
		internal static int __PropertyOffset_EndRemoveBuffIds;

		// Token: 0x04012437 RID: 74807
		[Nullable(2)]
		private TArray<long> _EndRemoveBuffIds;

		// Token: 0x04012438 RID: 74808
		internal static int __PropertyOffset_ToughRatio;

		// Token: 0x04012439 RID: 74809
		internal static int __PropertyOffset_StrengthCost;

		// Token: 0x0401243A RID: 74810
		internal static int __PropertyOffset_IsFullBodySkill;

		// Token: 0x0401243B RID: 74811
		internal static int __PropertyOffset_AutonomouslyBySimulate;

		// Token: 0x0401243C RID: 74812
		internal static int __PropertyOffset_MoveControllerTime;

		// Token: 0x0401243D RID: 74813
		internal static int __PropertyOffset_ImmuneFallDamageTime;

		// Token: 0x0401243E RID: 74814
		internal static int __PropertyOffset_OverrideHit;

		// Token: 0x0401243F RID: 74815
		internal static int __PropertyOffset_OverrideType;

		// Token: 0x04012440 RID: 74816
		internal static int __PropertyOffset_ExportSpecialAnim;

		// Token: 0x04012441 RID: 74817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ExportSpecialAnim;

		// Token: 0x04012442 RID: 74818
		internal static int __PropertyOffset_MontageDelayOneFrame;

		// Token: 0x04012443 RID: 74819
		internal static int __PropertyOffset_SkillStepUp;

		// Token: 0x04012444 RID: 74820
		internal static int __PropertyOffset_SkillCanBeginWithoutControl;

		// Token: 0x04012445 RID: 74821
		internal static int __PropertyOffset_MaxCounterCount;

		// Token: 0x04012446 RID: 74822
		internal static int __PropertyOffset_SpecialBuffInCode;

		// Token: 0x04012447 RID: 74823
		[Nullable(2)]
		private TArray<long> _SpecialBuffInCode;

		// Token: 0x04012448 RID: 74824
		internal static int __PropertyOffset_BurstLockTime;
	}
}
