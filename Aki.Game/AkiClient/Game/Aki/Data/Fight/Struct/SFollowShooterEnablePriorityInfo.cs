using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F65 RID: 16229
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 13)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SFollowShooterEnablePriorityInfo : IEqualityOperators<SFollowShooterEnablePriorityInfo, SFollowShooterEnablePriorityInfo, bool>, IEquatable<SFollowShooterEnablePriorityInfo>, IUnrealScriptStruct
	{
		// Token: 0x060295C0 RID: 169408 RVA: 0x009C24FC File Offset: 0x009C06FC
		public SFollowShooterEnablePriorityInfo(TEnumAsByte<BPEEnableFollowShooter> EnableType, int EnterSkillId, int ExitSkillId, bool EnterSkillReentrant)
		{
			this.EnableType = EnableType;
			this.EnterSkillId = EnterSkillId;
			this.ExitSkillId = ExitSkillId;
			this.EnterSkillReentrant = EnterSkillReentrant;
		}

		// Token: 0x060295C1 RID: 169409 RVA: 0x009C251C File Offset: 0x009C071C
		public static bool operator ==(SFollowShooterEnablePriorityInfo left, SFollowShooterEnablePriorityInfo right)
		{
			return left.EnableType == right.EnableType && left.EnterSkillId == right.EnterSkillId && left.ExitSkillId == right.ExitSkillId && left.EnterSkillReentrant == right.EnterSkillReentrant;
		}

		// Token: 0x060295C2 RID: 169410 RVA: 0x009C2568 File Offset: 0x009C0768
		public static bool operator !=(SFollowShooterEnablePriorityInfo left, SFollowShooterEnablePriorityInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060295C3 RID: 169411 RVA: 0x009C2574 File Offset: 0x009C0774
		public bool Equals(SFollowShooterEnablePriorityInfo other)
		{
			return this == other;
		}

		// Token: 0x060295C4 RID: 169412 RVA: 0x009C2584 File Offset: 0x009C0784
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFollowShooterEnablePriorityInfo)
			{
				SFollowShooterEnablePriorityInfo other = (SFollowShooterEnablePriorityInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060295C5 RID: 169413 RVA: 0x009C25A9 File Offset: 0x009C07A9
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<BPEEnableFollowShooter>, int, int, bool>(this.EnableType, this.EnterSkillId, this.ExitSkillId, this.EnterSkillReentrant);
		}

		// Token: 0x060295C6 RID: 169414 RVA: 0x009C25C8 File Offset: 0x009C07C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowShooterEnablePriorityInfo._ScriptStructPtr != 0) ? SFollowShooterEnablePriorityInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo", ref SFollowShooterEnablePriorityInfo._ScriptStructPtr);
		}

		// Token: 0x04015315 RID: 86805
		[FieldOffset(0)]
		public TEnumAsByte<BPEEnableFollowShooter> EnableType;

		// Token: 0x04015316 RID: 86806
		[FieldOffset(4)]
		public int EnterSkillId;

		// Token: 0x04015317 RID: 86807
		[FieldOffset(8)]
		public int ExitSkillId;

		// Token: 0x04015318 RID: 86808
		[FieldOffset(12)]
		public bool EnterSkillReentrant;

		// Token: 0x04015319 RID: 86809
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo";

		// Token: 0x0401531A RID: 86810
		private static IntPtr _ScriptStructPtr;
	}
}
