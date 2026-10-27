using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiRoleCamera.Struct
{
	// Token: 0x02003E86 RID: 16006
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 84)]
	[UnrealObjectPath("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 84)]
	public struct SUiRoleCameraSetting : IEqualityOperators<SUiRoleCameraSetting, SUiRoleCameraSetting, bool>, IEquatable<SUiRoleCameraSetting>, IUnrealScriptStruct
	{
		// Token: 0x0602868A RID: 165514 RVA: 0x009ABC04 File Offset: 0x009A9E04
		public SUiRoleCameraSetting(float 镜头Yaw灵敏度系数, float 镜头Pitch灵敏度系数, float 镜头缩放灵敏度系数, float 角色开始虚化仰视角, float 角色最大虚化仰视角, float Yaw限制Min, float Yaw限制Max, float Pitch限制Min, float Pitch限制Max, float 最小臂长, float 最大臂长, float 倍化手柄输入倍率, float 角色开始虚化距离, float 角色最大虚化距离, float 相机动画过程中角色开始虚化距离, float 相机动画过程中角色最大虚化距离, float 相机相对角色的最低高度, float 移动端旋转输入倍率, float 移动端缩放输入倍率, float 最大臂长时的光圈, float 最小臂长时的光圈)
		{
			this.镜头Yaw灵敏度系数 = 镜头Yaw灵敏度系数;
			this.镜头Pitch灵敏度系数 = 镜头Pitch灵敏度系数;
			this.镜头缩放灵敏度系数 = 镜头缩放灵敏度系数;
			this.角色开始虚化仰视角 = 角色开始虚化仰视角;
			this.角色最大虚化仰视角 = 角色最大虚化仰视角;
			this.Yaw限制Min = Yaw限制Min;
			this.Yaw限制Max = Yaw限制Max;
			this.Pitch限制Min = Pitch限制Min;
			this.Pitch限制Max = Pitch限制Max;
			this.最小臂长 = 最小臂长;
			this.最大臂长 = 最大臂长;
			this.倍化手柄输入倍率 = 倍化手柄输入倍率;
			this.角色开始虚化距离 = 角色开始虚化距离;
			this.角色最大虚化距离 = 角色最大虚化距离;
			this.相机动画过程中角色开始虚化距离 = 相机动画过程中角色开始虚化距离;
			this.相机动画过程中角色最大虚化距离 = 相机动画过程中角色最大虚化距离;
			this.相机相对角色的最低高度 = 相机相对角色的最低高度;
			this.移动端旋转输入倍率 = 移动端旋转输入倍率;
			this.移动端缩放输入倍率 = 移动端缩放输入倍率;
			this.最大臂长时的光圈 = 最大臂长时的光圈;
			this.最小臂长时的光圈 = 最小臂长时的光圈;
		}

		// Token: 0x0602868B RID: 165515 RVA: 0x009ABCB8 File Offset: 0x009A9EB8
		public static bool operator ==(SUiRoleCameraSetting left, SUiRoleCameraSetting right)
		{
			return left.镜头Yaw灵敏度系数 == right.镜头Yaw灵敏度系数 && left.镜头Pitch灵敏度系数 == right.镜头Pitch灵敏度系数 && left.镜头缩放灵敏度系数 == right.镜头缩放灵敏度系数 && left.角色开始虚化仰视角 == right.角色开始虚化仰视角 && left.角色最大虚化仰视角 == right.角色最大虚化仰视角 && left.Yaw限制Min == right.Yaw限制Min && left.Yaw限制Max == right.Yaw限制Max && left.Pitch限制Min == right.Pitch限制Min && left.Pitch限制Max == right.Pitch限制Max && left.最小臂长 == right.最小臂长 && left.最大臂长 == right.最大臂长 && left.倍化手柄输入倍率 == right.倍化手柄输入倍率 && left.角色开始虚化距离 == right.角色开始虚化距离 && left.角色最大虚化距离 == right.角色最大虚化距离 && left.相机动画过程中角色开始虚化距离 == right.相机动画过程中角色开始虚化距离 && left.相机动画过程中角色最大虚化距离 == right.相机动画过程中角色最大虚化距离 && left.相机相对角色的最低高度 == right.相机相对角色的最低高度 && left.移动端旋转输入倍率 == right.移动端旋转输入倍率 && left.移动端缩放输入倍率 == right.移动端缩放输入倍率 && left.最大臂长时的光圈 == right.最大臂长时的光圈 && left.最小臂长时的光圈 == right.最小臂长时的光圈;
		}

		// Token: 0x0602868C RID: 165516 RVA: 0x009ABE0E File Offset: 0x009AA00E
		public static bool operator !=(SUiRoleCameraSetting left, SUiRoleCameraSetting right)
		{
			return !(left == right);
		}

		// Token: 0x0602868D RID: 165517 RVA: 0x009ABE1A File Offset: 0x009AA01A
		public bool Equals(SUiRoleCameraSetting other)
		{
			return this == other;
		}

		// Token: 0x0602868E RID: 165518 RVA: 0x009ABE28 File Offset: 0x009AA028
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SUiRoleCameraSetting)
			{
				SUiRoleCameraSetting other = (SUiRoleCameraSetting)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602868F RID: 165519 RVA: 0x009ABE50 File Offset: 0x009AA050
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<float>(this.镜头Yaw灵敏度系数);
			hashCode.Add<float>(this.镜头Pitch灵敏度系数);
			hashCode.Add<float>(this.镜头缩放灵敏度系数);
			hashCode.Add<float>(this.角色开始虚化仰视角);
			hashCode.Add<float>(this.角色最大虚化仰视角);
			hashCode.Add<float>(this.Yaw限制Min);
			hashCode.Add<float>(this.Yaw限制Max);
			hashCode.Add<float>(this.Pitch限制Min);
			hashCode.Add<float>(this.Pitch限制Max);
			hashCode.Add<float>(this.最小臂长);
			hashCode.Add<float>(this.最大臂长);
			hashCode.Add<float>(this.倍化手柄输入倍率);
			hashCode.Add<float>(this.角色开始虚化距离);
			hashCode.Add<float>(this.角色最大虚化距离);
			hashCode.Add<float>(this.相机动画过程中角色开始虚化距离);
			hashCode.Add<float>(this.相机动画过程中角色最大虚化距离);
			hashCode.Add<float>(this.相机相对角色的最低高度);
			hashCode.Add<float>(this.移动端旋转输入倍率);
			hashCode.Add<float>(this.移动端缩放输入倍率);
			hashCode.Add<float>(this.最大臂长时的光圈);
			hashCode.Add<float>(this.最小臂长时的光圈);
			return hashCode.ToHashCode();
		}

		// Token: 0x06028690 RID: 165520 RVA: 0x009ABF7D File Offset: 0x009AA17D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiRoleCameraSetting._ScriptStructPtr != 0) ? SUiRoleCameraSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting", ref SUiRoleCameraSetting._ScriptStructPtr);
		}

		// Token: 0x04014992 RID: 84370
		[FieldOffset(0)]
		public float 镜头Yaw灵敏度系数;

		// Token: 0x04014993 RID: 84371
		[FieldOffset(4)]
		public float 镜头Pitch灵敏度系数;

		// Token: 0x04014994 RID: 84372
		[FieldOffset(8)]
		public float 镜头缩放灵敏度系数;

		// Token: 0x04014995 RID: 84373
		[FieldOffset(12)]
		public float 角色开始虚化仰视角;

		// Token: 0x04014996 RID: 84374
		[FieldOffset(16)]
		public float 角色最大虚化仰视角;

		// Token: 0x04014997 RID: 84375
		[FieldOffset(20)]
		public float Yaw限制Min;

		// Token: 0x04014998 RID: 84376
		[FieldOffset(24)]
		public float Yaw限制Max;

		// Token: 0x04014999 RID: 84377
		[FieldOffset(28)]
		public float Pitch限制Min;

		// Token: 0x0401499A RID: 84378
		[FieldOffset(32)]
		public float Pitch限制Max;

		// Token: 0x0401499B RID: 84379
		[FieldOffset(36)]
		public float 最小臂长;

		// Token: 0x0401499C RID: 84380
		[FieldOffset(40)]
		public float 最大臂长;

		// Token: 0x0401499D RID: 84381
		[FieldOffset(44)]
		public float 倍化手柄输入倍率;

		// Token: 0x0401499E RID: 84382
		[FieldOffset(48)]
		public float 角色开始虚化距离;

		// Token: 0x0401499F RID: 84383
		[FieldOffset(52)]
		public float 角色最大虚化距离;

		// Token: 0x040149A0 RID: 84384
		[FieldOffset(56)]
		public float 相机动画过程中角色开始虚化距离;

		// Token: 0x040149A1 RID: 84385
		[FieldOffset(60)]
		public float 相机动画过程中角色最大虚化距离;

		// Token: 0x040149A2 RID: 84386
		[FieldOffset(64)]
		public float 相机相对角色的最低高度;

		// Token: 0x040149A3 RID: 84387
		[FieldOffset(68)]
		public float 移动端旋转输入倍率;

		// Token: 0x040149A4 RID: 84388
		[FieldOffset(72)]
		public float 移动端缩放输入倍率;

		// Token: 0x040149A5 RID: 84389
		[FieldOffset(76)]
		public float 最大臂长时的光圈;

		// Token: 0x040149A6 RID: 84390
		[FieldOffset(80)]
		public float 最小臂长时的光圈;

		// Token: 0x040149A7 RID: 84391
		public const string __ObjectPath = "/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting";

		// Token: 0x040149A8 RID: 84392
		private static IntPtr _ScriptStructPtr;
	}
}
