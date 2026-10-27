using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE4 RID: 15588
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 88)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsAlreadyBaked.S_BalloonsAlreadyBaked")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 88)]
	public struct S_BalloonsAlreadyBaked : IEqualityOperators<S_BalloonsAlreadyBaked, S_BalloonsAlreadyBaked, bool>, IEquatable<S_BalloonsAlreadyBaked>, IUnrealScriptStruct
	{
		// Token: 0x06025105 RID: 151813 RVA: 0x00950020 File Offset: 0x0094E220
		public S_BalloonsAlreadyBaked(int index, float pos_x, float pos_y, float pos_z, float vel_x, float vel_y, float vel_z, float pos_old_x, float pos_old_y, float pos_old_z, int up, int down, float upDis, float downDis, int ID_X, int ID_Y, int isStart, int isEnd, float pos_bind_x, float pos_bind_y, float pos_bind_z, int isPivot)
		{
			this.index = index;
			this.pos_x = pos_x;
			this.pos_y = pos_y;
			this.pos_z = pos_z;
			this.vel_x = vel_x;
			this.vel_y = vel_y;
			this.vel_z = vel_z;
			this.pos_old_x = pos_old_x;
			this.pos_old_y = pos_old_y;
			this.pos_old_z = pos_old_z;
			this.up = up;
			this.down = down;
			this.upDis = upDis;
			this.downDis = downDis;
			this.ID_X = ID_X;
			this.ID_Y = ID_Y;
			this.isStart = isStart;
			this.isEnd = isEnd;
			this.pos_bind_x = pos_bind_x;
			this.pos_bind_y = pos_bind_y;
			this.pos_bind_z = pos_bind_z;
			this.isPivot = isPivot;
		}

		// Token: 0x06025106 RID: 151814 RVA: 0x009500DC File Offset: 0x0094E2DC
		public static bool operator ==(S_BalloonsAlreadyBaked left, S_BalloonsAlreadyBaked right)
		{
			return left.index == right.index && left.pos_x == right.pos_x && left.pos_y == right.pos_y && left.pos_z == right.pos_z && left.vel_x == right.vel_x && left.vel_y == right.vel_y && left.vel_z == right.vel_z && left.pos_old_x == right.pos_old_x && left.pos_old_y == right.pos_old_y && left.pos_old_z == right.pos_old_z && left.up == right.up && left.down == right.down && left.upDis == right.upDis && left.downDis == right.downDis && left.ID_X == right.ID_X && left.ID_Y == right.ID_Y && left.isStart == right.isStart && left.isEnd == right.isEnd && left.pos_bind_x == right.pos_bind_x && left.pos_bind_y == right.pos_bind_y && left.pos_bind_z == right.pos_bind_z && left.isPivot == right.isPivot;
		}

		// Token: 0x06025107 RID: 151815 RVA: 0x00950243 File Offset: 0x0094E443
		public static bool operator !=(S_BalloonsAlreadyBaked left, S_BalloonsAlreadyBaked right)
		{
			return !(left == right);
		}

		// Token: 0x06025108 RID: 151816 RVA: 0x0095024F File Offset: 0x0094E44F
		public bool Equals(S_BalloonsAlreadyBaked other)
		{
			return this == other;
		}

		// Token: 0x06025109 RID: 151817 RVA: 0x00950260 File Offset: 0x0094E460
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is S_BalloonsAlreadyBaked)
			{
				S_BalloonsAlreadyBaked other = (S_BalloonsAlreadyBaked)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602510A RID: 151818 RVA: 0x00950288 File Offset: 0x0094E488
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.index);
			hashCode.Add<float>(this.pos_x);
			hashCode.Add<float>(this.pos_y);
			hashCode.Add<float>(this.pos_z);
			hashCode.Add<float>(this.vel_x);
			hashCode.Add<float>(this.vel_y);
			hashCode.Add<float>(this.vel_z);
			hashCode.Add<float>(this.pos_old_x);
			hashCode.Add<float>(this.pos_old_y);
			hashCode.Add<float>(this.pos_old_z);
			hashCode.Add<int>(this.up);
			hashCode.Add<int>(this.down);
			hashCode.Add<float>(this.upDis);
			hashCode.Add<float>(this.downDis);
			hashCode.Add<int>(this.ID_X);
			hashCode.Add<int>(this.ID_Y);
			hashCode.Add<int>(this.isStart);
			hashCode.Add<int>(this.isEnd);
			hashCode.Add<float>(this.pos_bind_x);
			hashCode.Add<float>(this.pos_bind_y);
			hashCode.Add<float>(this.pos_bind_z);
			hashCode.Add<int>(this.isPivot);
			return hashCode.ToHashCode();
		}

		// Token: 0x0602510B RID: 151819 RVA: 0x009503C2 File Offset: 0x0094E5C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BalloonsAlreadyBaked._ScriptStructPtr != 0) ? S_BalloonsAlreadyBaked._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsAlreadyBaked.S_BalloonsAlreadyBaked", ref S_BalloonsAlreadyBaked._ScriptStructPtr);
		}

		// Token: 0x04012701 RID: 75521
		[FieldOffset(0)]
		public int index;

		// Token: 0x04012702 RID: 75522
		[FieldOffset(4)]
		public float pos_x;

		// Token: 0x04012703 RID: 75523
		[FieldOffset(8)]
		public float pos_y;

		// Token: 0x04012704 RID: 75524
		[FieldOffset(12)]
		public float pos_z;

		// Token: 0x04012705 RID: 75525
		[FieldOffset(16)]
		public float vel_x;

		// Token: 0x04012706 RID: 75526
		[FieldOffset(20)]
		public float vel_y;

		// Token: 0x04012707 RID: 75527
		[FieldOffset(24)]
		public float vel_z;

		// Token: 0x04012708 RID: 75528
		[FieldOffset(28)]
		public float pos_old_x;

		// Token: 0x04012709 RID: 75529
		[FieldOffset(32)]
		public float pos_old_y;

		// Token: 0x0401270A RID: 75530
		[FieldOffset(36)]
		public float pos_old_z;

		// Token: 0x0401270B RID: 75531
		[FieldOffset(40)]
		public int up;

		// Token: 0x0401270C RID: 75532
		[FieldOffset(44)]
		public int down;

		// Token: 0x0401270D RID: 75533
		[FieldOffset(48)]
		public float upDis;

		// Token: 0x0401270E RID: 75534
		[FieldOffset(52)]
		public float downDis;

		// Token: 0x0401270F RID: 75535
		[FieldOffset(56)]
		public int ID_X;

		// Token: 0x04012710 RID: 75536
		[FieldOffset(60)]
		public int ID_Y;

		// Token: 0x04012711 RID: 75537
		[FieldOffset(64)]
		public int isStart;

		// Token: 0x04012712 RID: 75538
		[FieldOffset(68)]
		public int isEnd;

		// Token: 0x04012713 RID: 75539
		[FieldOffset(72)]
		public float pos_bind_x;

		// Token: 0x04012714 RID: 75540
		[FieldOffset(76)]
		public float pos_bind_y;

		// Token: 0x04012715 RID: 75541
		[FieldOffset(80)]
		public float pos_bind_z;

		// Token: 0x04012716 RID: 75542
		[FieldOffset(84)]
		public int isPivot;

		// Token: 0x04012717 RID: 75543
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BalloonsAlreadyBaked.S_BalloonsAlreadyBaked";

		// Token: 0x04012718 RID: 75544
		private static IntPtr _ScriptStructPtr;
	}
}
