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
	// Token: 0x02003206 RID: 12806
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 13)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SFollowShooterEnablePriorityInfo : IEqualityOperators<SFollowShooterEnablePriorityInfo, SFollowShooterEnablePriorityInfo, bool>, IEquatable<SFollowShooterEnablePriorityInfo>, IUnrealScriptStruct
	{
		// Token: 0x0601FE49 RID: 130633 RVA: 0x0093863D File Offset: 0x0093683D
		public SFollowShooterEnablePriorityInfo(TEnumAsByte<BPEEnableFollowShooter> EnableType, int EnterSkillId, int ExitSkillId, bool EnterSkillReentrant)
		{
			this.EnableType = EnableType;
			this.EnterSkillId = EnterSkillId;
			this.ExitSkillId = ExitSkillId;
			this.EnterSkillReentrant = EnterSkillReentrant;
		}

		// Token: 0x0601FE4A RID: 130634 RVA: 0x0093865C File Offset: 0x0093685C
		public static bool operator ==(SFollowShooterEnablePriorityInfo left, SFollowShooterEnablePriorityInfo right)
		{
			return left.EnableType == right.EnableType && left.EnterSkillId == right.EnterSkillId && left.ExitSkillId == right.ExitSkillId && left.EnterSkillReentrant == right.EnterSkillReentrant;
		}

		// Token: 0x0601FE4B RID: 130635 RVA: 0x009386A8 File Offset: 0x009368A8
		public static bool operator !=(SFollowShooterEnablePriorityInfo left, SFollowShooterEnablePriorityInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0601FE4C RID: 130636 RVA: 0x009386B4 File Offset: 0x009368B4
		public bool Equals(SFollowShooterEnablePriorityInfo other)
		{
			return this == other;
		}

		// Token: 0x0601FE4D RID: 130637 RVA: 0x009386C4 File Offset: 0x009368C4
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

		// Token: 0x0601FE4E RID: 130638 RVA: 0x009386E9 File Offset: 0x009368E9
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<BPEEnableFollowShooter>, int, int, bool>(this.EnableType, this.EnterSkillId, this.ExitSkillId, this.EnterSkillReentrant);
		}

		// Token: 0x0601FE4F RID: 130639 RVA: 0x00938708 File Offset: 0x00936908
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowShooterEnablePriorityInfo._ScriptStructPtr != 0) ? SFollowShooterEnablePriorityInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo", ref SFollowShooterEnablePriorityInfo._ScriptStructPtr);
		}

		// Token: 0x04011209 RID: 70153
		[FieldOffset(0)]
		public TEnumAsByte<BPEEnableFollowShooter> EnableType;

		// Token: 0x0401120A RID: 70154
		[FieldOffset(4)]
		public int EnterSkillId;

		// Token: 0x0401120B RID: 70155
		[FieldOffset(8)]
		public int ExitSkillId;

		// Token: 0x0401120C RID: 70156
		[FieldOffset(12)]
		public bool EnterSkillReentrant;

		// Token: 0x0401120D RID: 70157
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SFollowShooterEnablePriorityInfo.SFollowShooterEnablePriorityInfo";

		// Token: 0x0401120E RID: 70158
		private static IntPtr _ScriptStructPtr;
	}
}
