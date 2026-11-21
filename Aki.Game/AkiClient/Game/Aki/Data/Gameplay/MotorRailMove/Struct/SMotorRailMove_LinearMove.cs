using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031EF RID: 12783
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SMotorRailMove_LinearMove : IEqualityOperators<SMotorRailMove_LinearMove, SMotorRailMove_LinearMove, bool>, IEquatable<SMotorRailMove_LinearMove>, IUnrealScriptStruct
	{
		// Token: 0x0601FCB0 RID: 130224 RVA: 0x00935D91 File Offset: 0x00933F91
		public SMotorRailMove_LinearMove(float MinSpeed, float MaxSpeed)
		{
			this.MinSpeed = MinSpeed;
			this.MaxSpeed = MaxSpeed;
		}

		// Token: 0x0601FCB1 RID: 130225 RVA: 0x00935DA1 File Offset: 0x00933FA1
		public static bool operator ==(SMotorRailMove_LinearMove left, SMotorRailMove_LinearMove right)
		{
			return left.MinSpeed == right.MinSpeed && left.MaxSpeed == right.MaxSpeed;
		}

		// Token: 0x0601FCB2 RID: 130226 RVA: 0x00935DC1 File Offset: 0x00933FC1
		public static bool operator !=(SMotorRailMove_LinearMove left, SMotorRailMove_LinearMove right)
		{
			return !(left == right);
		}

		// Token: 0x0601FCB3 RID: 130227 RVA: 0x00935DCD File Offset: 0x00933FCD
		public bool Equals(SMotorRailMove_LinearMove other)
		{
			return this == other;
		}

		// Token: 0x0601FCB4 RID: 130228 RVA: 0x00935DDC File Offset: 0x00933FDC
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

		// Token: 0x0601FCB5 RID: 130229 RVA: 0x00935E01 File Offset: 0x00934001
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.MinSpeed, this.MaxSpeed);
		}

		// Token: 0x0601FCB6 RID: 130230 RVA: 0x00935E14 File Offset: 0x00934014
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_LinearMove._ScriptStructPtr != 0) ? SMotorRailMove_LinearMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove", ref SMotorRailMove_LinearMove._ScriptStructPtr);
		}

		// Token: 0x040110FA RID: 69882
		[FieldOffset(0)]
		public float MinSpeed;

		// Token: 0x040110FB RID: 69883
		[FieldOffset(4)]
		public float MaxSpeed;

		// Token: 0x040110FC RID: 69884
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_LinearMove.SMotorRailMove_LinearMove";

		// Token: 0x040110FD RID: 69885
		private static IntPtr _ScriptStructPtr;
	}
}
