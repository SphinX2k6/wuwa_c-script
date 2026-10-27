using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F44 RID: 16196
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_ParabolaMove.SMotorRailMove_ParabolaMove")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SMotorRailMove_ParabolaMove : IEqualityOperators<SMotorRailMove_ParabolaMove, SMotorRailMove_ParabolaMove, bool>, IEquatable<SMotorRailMove_ParabolaMove>, IUnrealScriptStruct
	{
		// Token: 0x06029394 RID: 168852 RVA: 0x009BED68 File Offset: 0x009BCF68
		public SMotorRailMove_ParabolaMove(float GravityAccelerationAbs, float Duration, float MinSpeedAlongRail, float MaxSpeedAlongRail)
		{
			this.GravityAccelerationAbs = GravityAccelerationAbs;
			this.Duration = Duration;
			this.MinSpeedAlongRail = MinSpeedAlongRail;
			this.MaxSpeedAlongRail = MaxSpeedAlongRail;
		}

		// Token: 0x06029395 RID: 168853 RVA: 0x009BED87 File Offset: 0x009BCF87
		public static bool operator ==(SMotorRailMove_ParabolaMove left, SMotorRailMove_ParabolaMove right)
		{
			return left.GravityAccelerationAbs == right.GravityAccelerationAbs && left.Duration == right.Duration && left.MinSpeedAlongRail == right.MinSpeedAlongRail && left.MaxSpeedAlongRail == right.MaxSpeedAlongRail;
		}

		// Token: 0x06029396 RID: 168854 RVA: 0x009BEDC3 File Offset: 0x009BCFC3
		public static bool operator !=(SMotorRailMove_ParabolaMove left, SMotorRailMove_ParabolaMove right)
		{
			return !(left == right);
		}

		// Token: 0x06029397 RID: 168855 RVA: 0x009BEDCF File Offset: 0x009BCFCF
		public bool Equals(SMotorRailMove_ParabolaMove other)
		{
			return this == other;
		}

		// Token: 0x06029398 RID: 168856 RVA: 0x009BEDE0 File Offset: 0x009BCFE0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMotorRailMove_ParabolaMove)
			{
				SMotorRailMove_ParabolaMove other = (SMotorRailMove_ParabolaMove)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029399 RID: 168857 RVA: 0x009BEE05 File Offset: 0x009BD005
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.GravityAccelerationAbs, this.Duration, this.MinSpeedAlongRail, this.MaxSpeedAlongRail);
		}

		// Token: 0x0602939A RID: 168858 RVA: 0x009BEE24 File Offset: 0x009BD024
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_ParabolaMove._ScriptStructPtr != 0) ? SMotorRailMove_ParabolaMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_ParabolaMove.SMotorRailMove_ParabolaMove", ref SMotorRailMove_ParabolaMove._ScriptStructPtr);
		}

		// Token: 0x040151C2 RID: 86466
		[FieldOffset(0)]
		public float GravityAccelerationAbs;

		// Token: 0x040151C3 RID: 86467
		[FieldOffset(4)]
		public float Duration;

		// Token: 0x040151C4 RID: 86468
		[FieldOffset(8)]
		public float MinSpeedAlongRail;

		// Token: 0x040151C5 RID: 86469
		[FieldOffset(12)]
		public float MaxSpeedAlongRail;

		// Token: 0x040151C6 RID: 86470
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_ParabolaMove.SMotorRailMove_ParabolaMove";

		// Token: 0x040151C7 RID: 86471
		private static IntPtr _ScriptStructPtr;
	}
}
