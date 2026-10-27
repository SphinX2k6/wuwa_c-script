using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F41 RID: 16193
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SMotorRailMove_EnterRailCondition : IEqualityOperators<SMotorRailMove_EnterRailCondition, SMotorRailMove_EnterRailCondition, bool>, IEquatable<SMotorRailMove_EnterRailCondition>, IUnrealScriptStruct
	{
		// Token: 0x0602937C RID: 168828 RVA: 0x009BEAF8 File Offset: 0x009BCCF8
		public SMotorRailMove_EnterRailCondition(float MaxAngleBetweenForwardAndRailTangent, float MaxAngleBetweenUpAndRailUp, float MaxAngleBetweenVelocityAndRailTangent, float MinRailLenLeftAfterEnterRail, float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent)
		{
			this.MaxAngleBetweenForwardAndRailTangent = MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0602937D RID: 168829 RVA: 0x009BEB20 File Offset: 0x009BCD20
		public static bool operator ==(SMotorRailMove_EnterRailCondition left, SMotorRailMove_EnterRailCondition right)
		{
			return left.MaxAngleBetweenForwardAndRailTangent == right.MaxAngleBetweenForwardAndRailTangent && left.MaxAngleBetweenUpAndRailUp == right.MaxAngleBetweenUpAndRailUp && left.MaxAngleBetweenVelocityAndRailTangent == right.MaxAngleBetweenVelocityAndRailTangent && left.MinRailLenLeftAfterEnterRail == right.MinRailLenLeftAfterEnterRail && left.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent == right.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0602937E RID: 168830 RVA: 0x009BEB75 File Offset: 0x009BCD75
		public static bool operator !=(SMotorRailMove_EnterRailCondition left, SMotorRailMove_EnterRailCondition right)
		{
			return !(left == right);
		}

		// Token: 0x0602937F RID: 168831 RVA: 0x009BEB81 File Offset: 0x009BCD81
		public bool Equals(SMotorRailMove_EnterRailCondition other)
		{
			return this == other;
		}

		// Token: 0x06029380 RID: 168832 RVA: 0x009BEB90 File Offset: 0x009BCD90
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

		// Token: 0x06029381 RID: 168833 RVA: 0x009BEBB5 File Offset: 0x009BCDB5
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.MaxAngleBetweenForwardAndRailTangent, this.MaxAngleBetweenUpAndRailUp, this.MaxAngleBetweenVelocityAndRailTangent, this.MinRailLenLeftAfterEnterRail, this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent);
		}

		// Token: 0x06029382 RID: 168834 RVA: 0x009BEBDA File Offset: 0x009BCDDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_EnterRailCondition._ScriptStructPtr != 0) ? SMotorRailMove_EnterRailCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition", ref SMotorRailMove_EnterRailCondition._ScriptStructPtr);
		}

		// Token: 0x040151B3 RID: 86451
		[FieldOffset(0)]
		public float MaxAngleBetweenForwardAndRailTangent;

		// Token: 0x040151B4 RID: 86452
		[FieldOffset(4)]
		public float MaxAngleBetweenUpAndRailUp;

		// Token: 0x040151B5 RID: 86453
		[FieldOffset(8)]
		public float MaxAngleBetweenVelocityAndRailTangent;

		// Token: 0x040151B6 RID: 86454
		[FieldOffset(12)]
		public float MinRailLenLeftAfterEnterRail;

		// Token: 0x040151B7 RID: 86455
		[FieldOffset(16)]
		public float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;

		// Token: 0x040151B8 RID: 86456
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EnterRailCondition.SMotorRailMove_EnterRailCondition";

		// Token: 0x040151B9 RID: 86457
		private static IntPtr _ScriptStructPtr;
	}
}
