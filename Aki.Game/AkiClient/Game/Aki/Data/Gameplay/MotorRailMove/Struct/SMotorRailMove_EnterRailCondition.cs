using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031ED RID: 12781
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SMotorRailMove_EnterRailCondition : IEqualityOperators<SMotorRailMove_EnterRailCondition, SMotorRailMove_EnterRailCondition, bool>, IEquatable<SMotorRailMove_EnterRailCondition>, IUnrealScriptStruct
	{
		// Token: 0x0601FCA0 RID: 130208 RVA: 0x00935BD7 File Offset: 0x00933DD7
		public SMotorRailMove_EnterRailCondition(float MaxAngleBetweenForwardAndRailTangent, float MaxAngleBetweenUpAndRailUp, float MaxAngleBetweenVelocityAndRailTangent, float MinRailLenLeftAfterEnterRail, float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent)
		{
			this.MaxAngleBetweenForwardAndRailTangent = MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0601FCA1 RID: 130209 RVA: 0x00935C00 File Offset: 0x00933E00
		public static bool operator ==(SMotorRailMove_EnterRailCondition left, SMotorRailMove_EnterRailCondition right)
		{
			return left.MaxAngleBetweenForwardAndRailTangent == right.MaxAngleBetweenForwardAndRailTangent && left.MaxAngleBetweenUpAndRailUp == right.MaxAngleBetweenUpAndRailUp && left.MaxAngleBetweenVelocityAndRailTangent == right.MaxAngleBetweenVelocityAndRailTangent && left.MinRailLenLeftAfterEnterRail == right.MinRailLenLeftAfterEnterRail && left.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent == right.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0601FCA2 RID: 130210 RVA: 0x00935C55 File Offset: 0x00933E55
		public static bool operator !=(SMotorRailMove_EnterRailCondition left, SMotorRailMove_EnterRailCondition right)
		{
			return !(left == right);
		}

		// Token: 0x0601FCA3 RID: 130211 RVA: 0x00935C61 File Offset: 0x00933E61
		public bool Equals(SMotorRailMove_EnterRailCondition other)
		{
			return this == other;
		}

		// Token: 0x0601FCA4 RID: 130212 RVA: 0x00935C70 File Offset: 0x00933E70
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMotorRailMove_EnterRailCondition)
			{
				SMotorRailMove_EnterRailCondition other = (SMotorRailMove_EnterRailCondition)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FCA5 RID: 130213 RVA: 0x00935C95 File Offset: 0x00933E95
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.MaxAngleBetweenForwardAndRailTangent, this.MaxAngleBetweenUpAndRailUp, this.MaxAngleBetweenVelocityAndRailTangent, this.MinRailLenLeftAfterEnterRail, this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent);
		}

		// Token: 0x0601FCA6 RID: 130214 RVA: 0x00935CBA File Offset: 0x00933EBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_EnterRailCondition._ScriptStructPtr != 0) ? SMotorRailMove_EnterRailCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition", ref SMotorRailMove_EnterRailCondition._ScriptStructPtr);
		}

		// Token: 0x040110EF RID: 69871
		[FieldOffset(0)]
		public float MaxAngleBetweenForwardAndRailTangent;

		// Token: 0x040110F0 RID: 69872
		[FieldOffset(4)]
		public float MaxAngleBetweenUpAndRailUp;

		// Token: 0x040110F1 RID: 69873
		[FieldOffset(8)]
		public float MaxAngleBetweenVelocityAndRailTangent;

		// Token: 0x040110F2 RID: 69874
		[FieldOffset(12)]
		public float MinRailLenLeftAfterEnterRail;

		// Token: 0x040110F3 RID: 69875
		[FieldOffset(16)]
		public float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;

		// Token: 0x040110F4 RID: 69876
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition";

		// Token: 0x040110F5 RID: 69877
		private static IntPtr _ScriptStructPtr;
	}
}
