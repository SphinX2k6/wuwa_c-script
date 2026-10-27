using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE5 RID: 15589
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 52)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsSetup.S_BalloonsSetup")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 52)]
	public struct S_BalloonsSetup : IEqualityOperators<S_BalloonsSetup, S_BalloonsSetup, bool>, IEquatable<S_BalloonsSetup>, IUnrealScriptStruct
	{
		// Token: 0x0602510C RID: 151820 RVA: 0x009503E8 File Offset: 0x0094E5E8
		public S_BalloonsSetup(int ptnum, float Px, float Py, float Pz, int up, int down, float upDis, float downDis, int ID_X, int ID_Y, int isStart, int isEnd, int isPivot)
		{
			this.ptnum = ptnum;
			this.Px = Px;
			this.Py = Py;
			this.Pz = Pz;
			this.up = up;
			this.down = down;
			this.upDis = upDis;
			this.downDis = downDis;
			this.ID_X = ID_X;
			this.ID_Y = ID_Y;
			this.isStart = isStart;
			this.isEnd = isEnd;
			this.isPivot = isPivot;
		}

		// Token: 0x0602510D RID: 151821 RVA: 0x0095045C File Offset: 0x0094E65C
		public static bool operator ==(S_BalloonsSetup left, S_BalloonsSetup right)
		{
			return left.ptnum == right.ptnum && left.Px == right.Px && left.Py == right.Py && left.Pz == right.Pz && left.up == right.up && left.down == right.down && left.upDis == right.upDis && left.downDis == right.downDis && left.ID_X == right.ID_X && left.ID_Y == right.ID_Y && left.isStart == right.isStart && left.isEnd == right.isEnd && left.isPivot == right.isPivot;
		}

		// Token: 0x0602510E RID: 151822 RVA: 0x0095052A File Offset: 0x0094E72A
		public static bool operator !=(S_BalloonsSetup left, S_BalloonsSetup right)
		{
			return !(left == right);
		}

		// Token: 0x0602510F RID: 151823 RVA: 0x00950536 File Offset: 0x0094E736
		public bool Equals(S_BalloonsSetup other)
		{
			return this == other;
		}

		// Token: 0x06025110 RID: 151824 RVA: 0x00950544 File Offset: 0x0094E744
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is S_BalloonsSetup)
			{
				S_BalloonsSetup other = (S_BalloonsSetup)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06025111 RID: 151825 RVA: 0x0095056C File Offset: 0x0094E76C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.ptnum);
			hashCode.Add<float>(this.Px);
			hashCode.Add<float>(this.Py);
			hashCode.Add<float>(this.Pz);
			hashCode.Add<int>(this.up);
			hashCode.Add<int>(this.down);
			hashCode.Add<float>(this.upDis);
			hashCode.Add<float>(this.downDis);
			hashCode.Add<int>(this.ID_X);
			hashCode.Add<int>(this.ID_Y);
			hashCode.Add<int>(this.isStart);
			hashCode.Add<int>(this.isEnd);
			hashCode.Add<int>(this.isPivot);
			return hashCode.ToHashCode();
		}

		// Token: 0x06025112 RID: 151826 RVA: 0x00950631 File Offset: 0x0094E831
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BalloonsSetup._ScriptStructPtr != 0) ? S_BalloonsSetup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsSetup.S_BalloonsSetup", ref S_BalloonsSetup._ScriptStructPtr);
		}

		// Token: 0x04012719 RID: 75545
		[FieldOffset(0)]
		public int ptnum;

		// Token: 0x0401271A RID: 75546
		[FieldOffset(4)]
		public float Px;

		// Token: 0x0401271B RID: 75547
		[FieldOffset(8)]
		public float Py;

		// Token: 0x0401271C RID: 75548
		[FieldOffset(12)]
		public float Pz;

		// Token: 0x0401271D RID: 75549
		[FieldOffset(16)]
		public int up;

		// Token: 0x0401271E RID: 75550
		[FieldOffset(20)]
		public int down;

		// Token: 0x0401271F RID: 75551
		[FieldOffset(24)]
		public float upDis;

		// Token: 0x04012720 RID: 75552
		[FieldOffset(28)]
		public float downDis;

		// Token: 0x04012721 RID: 75553
		[FieldOffset(32)]
		public int ID_X;

		// Token: 0x04012722 RID: 75554
		[FieldOffset(36)]
		public int ID_Y;

		// Token: 0x04012723 RID: 75555
		[FieldOffset(40)]
		public int isStart;

		// Token: 0x04012724 RID: 75556
		[FieldOffset(44)]
		public int isEnd;

		// Token: 0x04012725 RID: 75557
		[FieldOffset(48)]
		public int isPivot;

		// Token: 0x04012726 RID: 75558
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsSetup.S_BalloonsSetup";

		// Token: 0x04012727 RID: 75559
		private static IntPtr _ScriptStructPtr;
	}
}
