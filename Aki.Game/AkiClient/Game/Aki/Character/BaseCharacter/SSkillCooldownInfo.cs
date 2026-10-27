using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004332 RID: 17202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SSkillCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C952 RID: 182610 RVA: 0x00A2333C File Offset: 0x00A2153C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillCooldownInfo._ScriptStructPtr != 0) ? SSkillCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo", ref SSkillCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x17006FFE RID: 28670
		// (get) Token: 0x0602C953 RID: 182611 RVA: 0x00A23360 File Offset: 0x00A21560
		// (set) Token: 0x0602C954 RID: 182612 RVA: 0x00A23370 File Offset: 0x00A21570
		public unsafe float CdTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006FFF RID: 28671
		// (get) Token: 0x0602C955 RID: 182613 RVA: 0x00A23381 File Offset: 0x00A21581
		// (set) Token: 0x0602C956 RID: 182614 RVA: 0x00A23391 File Offset: 0x00A21591
		public unsafe float CdDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007000 RID: 28672
		// (get) Token: 0x0602C957 RID: 182615 RVA: 0x00A233A2 File Offset: 0x00A215A2
		// (set) Token: 0x0602C958 RID: 182616 RVA: 0x00A233B2 File Offset: 0x00A215B2
		public unsafe bool IsShareAllCdSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007001 RID: 28673
		// (get) Token: 0x0602C959 RID: 182617 RVA: 0x00A233C3 File Offset: 0x00A215C3
		// (set) Token: 0x0602C95A RID: 182618 RVA: 0x00A233D3 File Offset: 0x00A215D3
		public unsafe int MaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007002 RID: 28674
		// (get) Token: 0x0602C95B RID: 182619 RVA: 0x00A233E4 File Offset: 0x00A215E4
		// (set) Token: 0x0602C95C RID: 182620 RVA: 0x00A233F4 File Offset: 0x00A215F4
		public unsafe int ShareGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007003 RID: 28675
		// (get) Token: 0x0602C95D RID: 182621 RVA: 0x00A23405 File Offset: 0x00A21605
		// (set) Token: 0x0602C95E RID: 182622 RVA: 0x00A23415 File Offset: 0x00A21615
		public unsafe int SectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17007004 RID: 28676
		// (get) Token: 0x0602C95F RID: 182623 RVA: 0x00A23426 File Offset: 0x00A21626
		// (set) Token: 0x0602C960 RID: 182624 RVA: 0x00A23436 File Offset: 0x00A21636
		public unsafe int SectionRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17007005 RID: 28677
		// (get) Token: 0x0602C961 RID: 182625 RVA: 0x00A23447 File Offset: 0x00A21647
		// (set) Token: 0x0602C962 RID: 182626 RVA: 0x00A23457 File Offset: 0x00A21657
		public unsafe long NextSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17007006 RID: 28678
		// (get) Token: 0x0602C963 RID: 182627 RVA: 0x00A23468 File Offset: 0x00A21668
		// (set) Token: 0x0602C964 RID: 182628 RVA: 0x00A23478 File Offset: 0x00A21678
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17007007 RID: 28679
		// (get) Token: 0x0602C965 RID: 182629 RVA: 0x00A23489 File Offset: 0x00A21689
		// (set) Token: 0x0602C966 RID: 182630 RVA: 0x00A23499 File Offset: 0x00A21699
		public unsafe float StopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007008 RID: 28680
		// (get) Token: 0x0602C967 RID: 182631 RVA: 0x00A234AA File Offset: 0x00A216AA
		// (set) Token: 0x0602C968 RID: 182632 RVA: 0x00A234BA File Offset: 0x00A216BA
		public unsafe bool IsReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007009 RID: 28681
		// (get) Token: 0x0602C969 RID: 182633 RVA: 0x00A234CB File Offset: 0x00A216CB
		// (set) Token: 0x0602C96A RID: 182634 RVA: 0x00A234DB File Offset: 0x00A216DB
		public unsafe bool IsResetOnChangeRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700700A RID: 28682
		// (get) Token: 0x0602C96B RID: 182635 RVA: 0x00A234EC File Offset: 0x00A216EC
		// (set) Token: 0x0602C96C RID: 182636 RVA: 0x00A2352F File Offset: 0x00A2172F
		public TArray<FGameplayTag> CdTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._CdTags) == null)
				{
					result = (this._CdTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SSkillCooldownInfo.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CdTags.CopyAssign(value);
			}
		}

		// Token: 0x0602C96D RID: 182637 RVA: 0x00A2353D File Offset: 0x00A2173D
		public SSkillCooldownInfo()
		{
		}

		// Token: 0x0602C96E RID: 182638 RVA: 0x00A23548 File Offset: 0x00A21748
		public SSkillCooldownInfo(float CdTime, float CdDelay, bool IsShareAllCdSkill, int MaxCount, int ShareGroupId, int SectionCount, int SectionRemaining, long NextSkillId, float StartTime, float StopTime, bool IsReset, bool IsResetOnChangeRole, TArray<FGameplayTag> CdTags)
		{
			this.CdTime = CdTime;
			this.CdDelay = CdDelay;
			this.IsShareAllCdSkill = IsShareAllCdSkill;
			this.MaxCount = MaxCount;
			this.ShareGroupId = ShareGroupId;
			this.SectionCount = SectionCount;
			this.SectionRemaining = SectionRemaining;
			this.NextSkillId = NextSkillId;
			this.StartTime = StartTime;
			this.StopTime = StopTime;
			this.IsReset = IsReset;
			this.IsResetOnChangeRole = IsResetOnChangeRole;
			this.CdTags = CdTags;
		}

		// Token: 0x0602C96F RID: 182639 RVA: 0x00A235C0 File Offset: 0x00A217C0
		protected override IntPtr GetUStructPtr()
		{
			return SSkillCooldownInfo.StaticStruct();
		}

		// Token: 0x0602C970 RID: 182640 RVA: 0x00A235CC File Offset: 0x00A217CC
		[NullableContext(2)]
		public SSkillCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C971 RID: 182641 RVA: 0x00A235D6 File Offset: 0x00A217D6
		public SSkillCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C972 RID: 182642 RVA: 0x00A235E1 File Offset: 0x00A217E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillCooldownInfo(Pointer, false, true);
		}

		// Token: 0x0602C973 RID: 182643 RVA: 0x00A235EB File Offset: 0x00A217EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040177FF RID: 96255
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillCooldownInfo.SSkillCooldownInfo";

		// Token: 0x04017800 RID: 96256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017801 RID: 96257
		internal static int __PropertyOffset_0;

		// Token: 0x04017802 RID: 96258
		internal static int __PropertyOffset_1;

		// Token: 0x04017803 RID: 96259
		internal static int __PropertyOffset_2;

		// Token: 0x04017804 RID: 96260
		internal static int __PropertyOffset_3;

		// Token: 0x04017805 RID: 96261
		internal static int __PropertyOffset_4;

		// Token: 0x04017806 RID: 96262
		internal static int __PropertyOffset_5;

		// Token: 0x04017807 RID: 96263
		internal static int __PropertyOffset_6;

		// Token: 0x04017808 RID: 96264
		internal static int __PropertyOffset_7;

		// Token: 0x04017809 RID: 96265
		internal static int __PropertyOffset_8;

		// Token: 0x0401780A RID: 96266
		internal static int __PropertyOffset_9;

		// Token: 0x0401780B RID: 96267
		internal static int __PropertyOffset_10;

		// Token: 0x0401780C RID: 96268
		internal static int __PropertyOffset_11;

		// Token: 0x0401780D RID: 96269
		internal static int __PropertyOffset_12;

		// Token: 0x0401780E RID: 96270
		[Nullable(2)]
		private TArray<FGameplayTag> _CdTags;
	}
}
