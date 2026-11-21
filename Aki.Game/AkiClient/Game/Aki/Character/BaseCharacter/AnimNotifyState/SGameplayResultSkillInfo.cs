using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState
{
	// Token: 0x020033F9 RID: 13305
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SGameplayResultSkillInfo : IEqualityOperators<SGameplayResultSkillInfo, SGameplayResultSkillInfo, bool>, IEquatable<SGameplayResultSkillInfo>, IUnrealScriptStruct
	{
		// Token: 0x06021C06 RID: 138246 RVA: 0x00968351 File Offset: 0x00966551
		public SGameplayResultSkillInfo(int SkillId, bool IsWinResult, bool IsCheckStartTimeStamp, float TimeStampDelta)
		{
			this.SkillId = SkillId;
			this.IsWinResult = IsWinResult;
			this.IsCheckStartTimeStamp = IsCheckStartTimeStamp;
			this.TimeStampDelta = TimeStampDelta;
		}

		// Token: 0x06021C07 RID: 138247 RVA: 0x00968370 File Offset: 0x00966570
		public static bool operator ==(SGameplayResultSkillInfo left, SGameplayResultSkillInfo right)
		{
			return left.SkillId == right.SkillId && left.IsWinResult == right.IsWinResult && left.IsCheckStartTimeStamp == right.IsCheckStartTimeStamp && left.TimeStampDelta == right.TimeStampDelta;
		}

		// Token: 0x06021C08 RID: 138248 RVA: 0x009683AC File Offset: 0x009665AC
		public static bool operator !=(SGameplayResultSkillInfo left, SGameplayResultSkillInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06021C09 RID: 138249 RVA: 0x009683B8 File Offset: 0x009665B8
		public bool Equals(SGameplayResultSkillInfo other)
		{
			return this == other;
		}

		// Token: 0x06021C0A RID: 138250 RVA: 0x009683C8 File Offset: 0x009665C8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SGameplayResultSkillInfo)
			{
				SGameplayResultSkillInfo other = (SGameplayResultSkillInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06021C0B RID: 138251 RVA: 0x009683ED File Offset: 0x009665ED
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool, bool, float>(this.SkillId, this.IsWinResult, this.IsCheckStartTimeStamp, this.TimeStampDelta);
		}

		// Token: 0x06021C0C RID: 138252 RVA: 0x0096840C File Offset: 0x0096660C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayResultSkillInfo._ScriptStructPtr != 0) ? SGameplayResultSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo", ref SGameplayResultSkillInfo._ScriptStructPtr);
		}

		// Token: 0x04012980 RID: 76160
		[FieldOffset(0)]
		public int SkillId;

		// Token: 0x04012981 RID: 76161
		[FieldOffset(4)]
		public bool IsWinResult;

		// Token: 0x04012982 RID: 76162
		[FieldOffset(5)]
		public bool IsCheckStartTimeStamp;

		// Token: 0x04012983 RID: 76163
		[FieldOffset(8)]
		public float TimeStampDelta;

		// Token: 0x04012984 RID: 76164
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo";

		// Token: 0x04012985 RID: 76165
		private static IntPtr _ScriptStructPtr;
	}
}
