using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Liushu
{
	// Token: 0x02003C8B RID: 15499
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 25)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_KuroCS_Pos.S_KuroCS_Pos")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct S_KuroCS_Pos : IEqualityOperators<S_KuroCS_Pos, S_KuroCS_Pos, bool>, IEquatable<S_KuroCS_Pos>, IUnrealScriptStruct
	{
		// Token: 0x06024343 RID: 148291 RVA: 0x00937CE4 File Offset: 0x00935EE4
		public S_KuroCS_Pos(float X, float Y, float Z, int IDA, int IDB, float percent, bool hardPoint)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.IDA = IDA;
			this.IDB = IDB;
			this.percent = percent;
			this.hardPoint = hardPoint;
		}

		// Token: 0x06024344 RID: 148292 RVA: 0x00937D1C File Offset: 0x00935F1C
		public static bool operator ==(S_KuroCS_Pos left, S_KuroCS_Pos right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.IDA == right.IDA && left.IDB == right.IDB && left.percent == right.percent && left.hardPoint == right.hardPoint;
		}

		// Token: 0x06024345 RID: 148293 RVA: 0x00937D8D File Offset: 0x00935F8D
		public static bool operator !=(S_KuroCS_Pos left, S_KuroCS_Pos right)
		{
			return !(left == right);
		}

		// Token: 0x06024346 RID: 148294 RVA: 0x00937D99 File Offset: 0x00935F99
		public bool Equals(S_KuroCS_Pos other)
		{
			return this == other;
		}

		// Token: 0x06024347 RID: 148295 RVA: 0x00937DA8 File Offset: 0x00935FA8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is S_KuroCS_Pos)
			{
				S_KuroCS_Pos other = (S_KuroCS_Pos)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024348 RID: 148296 RVA: 0x00937DCD File Offset: 0x00935FCD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, int, int, float, bool>(this.X, this.Y, this.Z, this.IDA, this.IDB, this.percent, this.hardPoint);
		}

		// Token: 0x06024349 RID: 148297 RVA: 0x00937DFE File Offset: 0x00935FFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_KuroCS_Pos._ScriptStructPtr != 0) ? S_KuroCS_Pos._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_KuroCS_Pos.S_KuroCS_Pos", ref S_KuroCS_Pos._ScriptStructPtr);
		}

		// Token: 0x04011EF7 RID: 73463
		[FieldOffset(0)]
		public float X;

		// Token: 0x04011EF8 RID: 73464
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04011EF9 RID: 73465
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04011EFA RID: 73466
		[FieldOffset(12)]
		public int IDA;

		// Token: 0x04011EFB RID: 73467
		[FieldOffset(16)]
		public int IDB;

		// Token: 0x04011EFC RID: 73468
		[FieldOffset(20)]
		public float percent;

		// Token: 0x04011EFD RID: 73469
		[FieldOffset(24)]
		public bool hardPoint;

		// Token: 0x04011EFE RID: 73470
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_KuroCS_Pos.S_KuroCS_Pos";

		// Token: 0x04011EFF RID: 73471
		private static IntPtr _ScriptStructPtr;
	}
}
