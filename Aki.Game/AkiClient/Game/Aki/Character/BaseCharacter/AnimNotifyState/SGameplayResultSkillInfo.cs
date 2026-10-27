using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState
{
	// Token: 0x020043E6 RID: 17382
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SGameplayResultSkillInfo : IEqualityOperators<SGameplayResultSkillInfo, SGameplayResultSkillInfo, bool>, IEquatable<SGameplayResultSkillInfo>, IUnrealScriptStruct
	{
		// Token: 0x0602D08B RID: 184459 RVA: 0x00A2EF5E File Offset: 0x00A2D15E
		public SGameplayResultSkillInfo(int SkillId, bool IsWinResult, bool IsCheckStartTimeStamp, float TimeStampDelta)
		{
			this.SkillId = SkillId;
			this.IsWinResult = IsWinResult;
			this.IsCheckStartTimeStamp = IsCheckStartTimeStamp;
			this.TimeStampDelta = TimeStampDelta;
		}

		// Token: 0x0602D08C RID: 184460 RVA: 0x00A2EF7D File Offset: 0x00A2D17D
		public static bool operator ==(SGameplayResultSkillInfo left, SGameplayResultSkillInfo right)
		{
			return left.SkillId == right.SkillId && left.IsWinResult == right.IsWinResult && left.IsCheckStartTimeStamp == right.IsCheckStartTimeStamp && left.TimeStampDelta == right.TimeStampDelta;
		}

		// Token: 0x0602D08D RID: 184461 RVA: 0x00A2EFB9 File Offset: 0x00A2D1B9
		public static bool operator !=(SGameplayResultSkillInfo left, SGameplayResultSkillInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0602D08E RID: 184462 RVA: 0x00A2EFC5 File Offset: 0x00A2D1C5
		public bool Equals(SGameplayResultSkillInfo other)
		{
			return this == other;
		}

		// Token: 0x0602D08F RID: 184463 RVA: 0x00A2EFD4 File Offset: 0x00A2D1D4
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

		// Token: 0x0602D090 RID: 184464 RVA: 0x00A2EFF9 File Offset: 0x00A2D1F9
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool, bool, float>(this.SkillId, this.IsWinResult, this.IsCheckStartTimeStamp, this.TimeStampDelta);
		}

		// Token: 0x0602D091 RID: 184465 RVA: 0x00A2F018 File Offset: 0x00A2D218
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayResultSkillInfo._ScriptStructPtr != 0) ? SGameplayResultSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo", ref SGameplayResultSkillInfo._ScriptStructPtr);
		}

		// Token: 0x04017E60 RID: 97888
		[FieldOffset(0)]
		public int SkillId;

		// Token: 0x04017E61 RID: 97889
		[FieldOffset(4)]
		public bool IsWinResult;

		// Token: 0x04017E62 RID: 97890
		[FieldOffset(5)]
		public bool IsCheckStartTimeStamp;

		// Token: 0x04017E63 RID: 97891
		[FieldOffset(8)]
		public float TimeStampDelta;

		// Token: 0x04017E64 RID: 97892
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/AnimNotifyState/SGameplayResultSkillInfo.SGameplayResultSkillInfo";

		// Token: 0x04017E65 RID: 97893
		private static IntPtr _ScriptStructPtr;
	}
}
