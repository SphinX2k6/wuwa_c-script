using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004328 RID: 17192
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 17)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMutiSectionSkillInfo.SMutiSectionSkillInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SMutiSectionSkillInfo : IEqualityOperators<SMutiSectionSkillInfo, SMutiSectionSkillInfo, bool>, IEquatable<SMutiSectionSkillInfo>, IUnrealScriptStruct
	{
		// Token: 0x0602C85A RID: 182362 RVA: 0x00A21BF4 File Offset: 0x00A1FDF4
		public SMutiSectionSkillInfo(float StartTime, float StopTime, int SectionRemaining, int SectionCount, bool IsReset)
		{
			this.StartTime = StartTime;
			this.StopTime = StopTime;
			this.SectionRemaining = SectionRemaining;
			this.SectionCount = SectionCount;
			this.IsReset = IsReset;
		}

		// Token: 0x0602C85B RID: 182363 RVA: 0x00A21C1C File Offset: 0x00A1FE1C
		public static bool operator ==(SMutiSectionSkillInfo left, SMutiSectionSkillInfo right)
		{
			return left.StartTime == right.StartTime && left.StopTime == right.StopTime && left.SectionRemaining == right.SectionRemaining && left.SectionCount == right.SectionCount && left.IsReset == right.IsReset;
		}

		// Token: 0x0602C85C RID: 182364 RVA: 0x00A21C71 File Offset: 0x00A1FE71
		public static bool operator !=(SMutiSectionSkillInfo left, SMutiSectionSkillInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0602C85D RID: 182365 RVA: 0x00A21C7D File Offset: 0x00A1FE7D
		public bool Equals(SMutiSectionSkillInfo other)
		{
			return this == other;
		}

		// Token: 0x0602C85E RID: 182366 RVA: 0x00A21C8C File Offset: 0x00A1FE8C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMutiSectionSkillInfo)
			{
				SMutiSectionSkillInfo other = (SMutiSectionSkillInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C85F RID: 182367 RVA: 0x00A21CB1 File Offset: 0x00A1FEB1
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, int, int, bool>(this.StartTime, this.StopTime, this.SectionRemaining, this.SectionCount, this.IsReset);
		}

		// Token: 0x0602C860 RID: 182368 RVA: 0x00A21CD6 File Offset: 0x00A1FED6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMutiSectionSkillInfo._ScriptStructPtr != 0) ? SMutiSectionSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMutiSectionSkillInfo.SMutiSectionSkillInfo", ref SMutiSectionSkillInfo._ScriptStructPtr);
		}

		// Token: 0x04017781 RID: 96129
		[FieldOffset(0)]
		public float StartTime;

		// Token: 0x04017782 RID: 96130
		[FieldOffset(4)]
		public float StopTime;

		// Token: 0x04017783 RID: 96131
		[FieldOffset(8)]
		public int SectionRemaining;

		// Token: 0x04017784 RID: 96132
		[FieldOffset(12)]
		public int SectionCount;

		// Token: 0x04017785 RID: 96133
		[FieldOffset(16)]
		public bool IsReset;

		// Token: 0x04017786 RID: 96134
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMutiSectionSkillInfo.SMutiSectionSkillInfo";

		// Token: 0x04017787 RID: 96135
		private static IntPtr _ScriptStructPtr;
	}
}
