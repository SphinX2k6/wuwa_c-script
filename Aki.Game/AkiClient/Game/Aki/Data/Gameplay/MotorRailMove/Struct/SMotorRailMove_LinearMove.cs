using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F43 RID: 16195
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SMotorRailMove_LinearMove : IEqualityOperators<SMotorRailMove_LinearMove, SMotorRailMove_LinearMove, bool>, IEquatable<SMotorRailMove_LinearMove>, IUnrealScriptStruct
	{
		// Token: 0x0602938D RID: 168845 RVA: 0x009BECC0 File Offset: 0x009BCEC0
		public SMotorRailMove_LinearMove(float MinSpeed, float MaxSpeed)
		{
			this.MinSpeed = MinSpeed;
			this.MaxSpeed = MaxSpeed;
		}

		// Token: 0x0602938E RID: 168846 RVA: 0x009BECD0 File Offset: 0x009BCED0
		public static bool operator ==(SMotorRailMove_LinearMove left, SMotorRailMove_LinearMove right)
		{
			return left.MinSpeed == right.MinSpeed && left.MaxSpeed == right.MaxSpeed;
		}

		// Token: 0x0602938F RID: 168847 RVA: 0x009BECF0 File Offset: 0x009BCEF0
		public static bool operator !=(SMotorRailMove_LinearMove left, SMotorRailMove_LinearMove right)
		{
			return !(left == right);
		}

		// Token: 0x06029390 RID: 168848 RVA: 0x009BECFC File Offset: 0x009BCEFC
		public bool Equals(SMotorRailMove_LinearMove other)
		{
			return this == other;
		}

		// Token: 0x06029391 RID: 168849 RVA: 0x009BED0C File Offset: 0x009BCF0C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMotorRailMove_LinearMove)
			{
				SMotorRailMove_LinearMove other = (SMotorRailMove_LinearMove)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029392 RID: 168850 RVA: 0x009BED31 File Offset: 0x009BCF31
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.MinSpeed, this.MaxSpeed);
		}

		// Token: 0x06029393 RID: 168851 RVA: 0x009BED44 File Offset: 0x009BCF44
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_LinearMove._ScriptStructPtr != 0) ? SMotorRailMove_LinearMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove", ref SMotorRailMove_LinearMove._ScriptStructPtr);
		}

		// Token: 0x040151BE RID: 86462
		[FieldOffset(0)]
		public float MinSpeed;

		// Token: 0x040151BF RID: 86463
		[FieldOffset(4)]
		public float MaxSpeed;

		// Token: 0x040151C0 RID: 86464
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove";

		// Token: 0x040151C1 RID: 86465
		private static IntPtr _ScriptStructPtr;
	}
}
