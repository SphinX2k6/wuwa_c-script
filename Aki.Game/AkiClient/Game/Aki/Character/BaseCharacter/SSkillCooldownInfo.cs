using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336A RID: 13162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SSkillCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602164C RID: 136780 RVA: 0x0095F931 File Offset: 0x0095DB31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillCooldownInfo._ScriptStructPtr != 0) ? SSkillCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo", ref SSkillCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x0602164D RID: 136781 RVA: 0x0095F955 File Offset: 0x0095DB55
		// (set) Token: 0x0602164E RID: 136782 RVA: 0x0095F965 File Offset: 0x0095DB65
		public unsafe float CdTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_CdTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_CdTime) = value;
			}
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x0602164F RID: 136783 RVA: 0x0095F976 File Offset: 0x0095DB76
		// (set) Token: 0x06021650 RID: 136784 RVA: 0x0095F986 File Offset: 0x0095DB86
		public unsafe float CdDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_CdDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_CdDelay) = value;
			}
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x06021651 RID: 136785 RVA: 0x0095F997 File Offset: 0x0095DB97
		// (set) Token: 0x06021652 RID: 136786 RVA: 0x0095F9A7 File Offset: 0x0095DBA7
		public unsafe bool IsShareAllCdSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsShareAllCdSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsShareAllCdSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x06021653 RID: 136787 RVA: 0x0095F9B8 File Offset: 0x0095DBB8
		// (set) Token: 0x06021654 RID: 136788 RVA: 0x0095F9C8 File Offset: 0x0095DBC8
		public unsafe int MaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_MaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_MaxCount) = value;
			}
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x06021655 RID: 136789 RVA: 0x0095F9D9 File Offset: 0x0095DBD9
		// (set) Token: 0x06021656 RID: 136790 RVA: 0x0095F9E9 File Offset: 0x0095DBE9
		public unsafe int ShareGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_ShareGroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_ShareGroupId) = value;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x06021657 RID: 136791 RVA: 0x0095F9FA File Offset: 0x0095DBFA
		// (set) Token: 0x06021658 RID: 136792 RVA: 0x0095FA0A File Offset: 0x0095DC0A
		public unsafe int SectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_SectionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_SectionCount) = value;
			}
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x06021659 RID: 136793 RVA: 0x0095FA1B File Offset: 0x0095DC1B
		// (set) Token: 0x0602165A RID: 136794 RVA: 0x0095FA2B File Offset: 0x0095DC2B
		public unsafe int SectionRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_SectionRemaining);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_SectionRemaining) = value;
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x0602165B RID: 136795 RVA: 0x0095FA3C File Offset: 0x0095DC3C
		// (set) Token: 0x0602165C RID: 136796 RVA: 0x0095FA4C File Offset: 0x0095DC4C
		public unsafe long NextSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_NextSkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_NextSkillId) = value;
			}
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x0602165D RID: 136797 RVA: 0x0095FA5D File Offset: 0x0095DC5D
		// (set) Token: 0x0602165E RID: 136798 RVA: 0x0095FA6D File Offset: 0x0095DC6D
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x0602165F RID: 136799 RVA: 0x0095FA7E File Offset: 0x0095DC7E
		// (set) Token: 0x06021660 RID: 136800 RVA: 0x0095FA8E File Offset: 0x0095DC8E
		public unsafe float StopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_StopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_StopTime) = value;
			}
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x06021661 RID: 136801 RVA: 0x0095FA9F File Offset: 0x0095DC9F
		// (set) Token: 0x06021662 RID: 136802 RVA: 0x0095FAAF File Offset: 0x0095DCAF
		public unsafe bool IsReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x06021663 RID: 136803 RVA: 0x0095FAC0 File Offset: 0x0095DCC0
		// (set) Token: 0x06021664 RID: 136804 RVA: 0x0095FAD0 File Offset: 0x0095DCD0
		public unsafe bool IsResetOnChangeRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsResetOnChangeRole) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_IsResetOnChangeRole) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x06021665 RID: 136805 RVA: 0x0095FAE4 File Offset: 0x0095DCE4
		// (set) Token: 0x06021666 RID: 136806 RVA: 0x0095FB27 File Offset: 0x0095DD27
		public TArray<FGameplayTag> CdTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._CdTags) == null)
				{
					result = (this._CdTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_CdTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CdTags.CopyAssign(value);
			}
		}

		// Token: 0x06021667 RID: 136807 RVA: 0x0095FB35 File Offset: 0x0095DD35
		public SSkillCooldownInfo()
		{
		}

		// Token: 0x06021668 RID: 136808 RVA: 0x0095FB3D File Offset: 0x0095DD3D
		protected override IntPtr GetUStructPtr()
		{
			return SSkillCooldownInfo.StaticStruct();
		}

		// Token: 0x06021669 RID: 136809 RVA: 0x0095FB49 File Offset: 0x0095DD49
		[NullableContext(2)]
		public SSkillCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602166A RID: 136810 RVA: 0x0095FB53 File Offset: 0x0095DD53
		public SSkillCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602166B RID: 136811 RVA: 0x0095FB5E File Offset: 0x0095DD5E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillCooldownInfo(Pointer, false, true);
		}

		// Token: 0x0602166C RID: 136812 RVA: 0x0095FB68 File Offset: 0x0095DD68
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012400 RID: 74752
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo";

		// Token: 0x04012401 RID: 74753
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012402 RID: 74754
		internal static int __PropertyOffset_CdTime;

		// Token: 0x04012403 RID: 74755
		internal static int __PropertyOffset_CdDelay;

		// Token: 0x04012404 RID: 74756
		internal static int __PropertyOffset_IsShareAllCdSkill;

		// Token: 0x04012405 RID: 74757
		internal static int __PropertyOffset_MaxCount;

		// Token: 0x04012406 RID: 74758
		internal static int __PropertyOffset_ShareGroupId;

		// Token: 0x04012407 RID: 74759
		internal static int __PropertyOffset_SectionCount;

		// Token: 0x04012408 RID: 74760
		internal static int __PropertyOffset_SectionRemaining;

		// Token: 0x04012409 RID: 74761
		internal static int __PropertyOffset_NextSkillId;

		// Token: 0x0401240A RID: 74762
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0401240B RID: 74763
		internal static int __PropertyOffset_StopTime;

		// Token: 0x0401240C RID: 74764
		internal static int __PropertyOffset_IsReset;

		// Token: 0x0401240D RID: 74765
		internal static int __PropertyOffset_IsResetOnChangeRole;

		// Token: 0x0401240E RID: 74766
		internal static int __PropertyOffset_CdTags;

		// Token: 0x0401240F RID: 74767
		[Nullable(2)]
		private TArray<FGameplayTag> _CdTags;
	}
}
