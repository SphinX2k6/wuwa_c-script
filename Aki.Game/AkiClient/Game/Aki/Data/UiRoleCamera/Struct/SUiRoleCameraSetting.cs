using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiRoleCamera.Struct
{
	// Token: 0x0200315D RID: 12637
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 84)]
	[UnrealObjectPath("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 84)]
	public struct SUiRoleCameraSetting : IEqualityOperators<SUiRoleCameraSetting, SUiRoleCameraSetting, bool>, IEquatable<SUiRoleCameraSetting>, IUnrealScriptStruct
	{
		// Token: 0x0601F1F2 RID: 127474 RVA: 0x00926CD4 File Offset: 0x00924ED4
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

		// Token: 0x0601F1F3 RID: 127475 RVA: 0x00926D88 File Offset: 0x00924F88
		public static bool operator ==(SUiRoleCameraSetting left, SUiRoleCameraSetting right)
		{
			return left.镜头Yaw灵敏度系数 == right.镜头Yaw灵敏度系数 && left.镜头Pitch灵敏度系数 == right.镜头Pitch灵敏度系数 && left.镜头缩放灵敏度系数 == right.镜头缩放灵敏度系数 && left.角色开始虚化仰视角 == right.角色开始虚化仰视角 && left.角色最大虚化仰视角 == right.角色最大虚化仰视角 && left.Yaw限制Min == right.Yaw限制Min && left.Yaw限制Max == right.Yaw限制Max && left.Pitch限制Min == right.Pitch限制Min && left.Pitch限制Max == right.Pitch限制Max && left.最小臂长 == right.最小臂长 && left.最大臂长 == right.最大臂长 && left.倍化手柄输入倍率 == right.倍化手柄输入倍率 && left.角色开始虚化距离 == right.角色开始虚化距离 && left.角色最大虚化距离 == right.角色最大虚化距离 && left.相机动画过程中角色开始虚化距离 == right.相机动画过程中角色开始虚化距离 && left.相机动画过程中角色最大虚化距离 == right.相机动画过程中角色最大虚化距离 && left.相机相对角色的最低高度 == right.相机相对角色的最低高度 && left.移动端旋转输入倍率 == right.移动端旋转输入倍率 && left.移动端缩放输入倍率 == right.移动端缩放输入倍率 && left.最大臂长时的光圈 == right.最大臂长时的光圈 && left.最小臂长时的光圈 == right.最小臂长时的光圈;
		}

		// Token: 0x0601F1F4 RID: 127476 RVA: 0x00926EDE File Offset: 0x009250DE
		public static bool operator !=(SUiRoleCameraSetting left, SUiRoleCameraSetting right)
		{
			return !(left == right);
		}

		// Token: 0x0601F1F5 RID: 127477 RVA: 0x00926EEA File Offset: 0x009250EA
		public bool Equals(SUiRoleCameraSetting other)
		{
			return this == other;
		}

		// Token: 0x0601F1F6 RID: 127478 RVA: 0x00926EF8 File Offset: 0x009250F8
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

		// Token: 0x0601F1F7 RID: 127479 RVA: 0x00926F20 File Offset: 0x00925120
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

		// Token: 0x0601F1F8 RID: 127480 RVA: 0x0092704D File Offset: 0x0092524D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiRoleCameraSetting._ScriptStructPtr != 0) ? SUiRoleCameraSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting", ref SUiRoleCameraSetting._ScriptStructPtr);
		}

		// Token: 0x04010A13 RID: 68115
		[FieldOffset(0)]
		public float 镜头Yaw灵敏度系数;

		// Token: 0x04010A14 RID: 68116
		[FieldOffset(4)]
		public float 镜头Pitch灵敏度系数;

		// Token: 0x04010A15 RID: 68117
		[FieldOffset(8)]
		public float 镜头缩放灵敏度系数;

		// Token: 0x04010A16 RID: 68118
		[FieldOffset(12)]
		public float 角色开始虚化仰视角;

		// Token: 0x04010A17 RID: 68119
		[FieldOffset(16)]
		public float 角色最大虚化仰视角;

		// Token: 0x04010A18 RID: 68120
		[FieldOffset(20)]
		public float Yaw限制Min;

		// Token: 0x04010A19 RID: 68121
		[FieldOffset(24)]
		public float Yaw限制Max;

		// Token: 0x04010A1A RID: 68122
		[FieldOffset(28)]
		public float Pitch限制Min;

		// Token: 0x04010A1B RID: 68123
		[FieldOffset(32)]
		public float Pitch限制Max;

		// Token: 0x04010A1C RID: 68124
		[FieldOffset(36)]
		public float 最小臂长;

		// Token: 0x04010A1D RID: 68125
		[FieldOffset(40)]
		public float 最大臂长;

		// Token: 0x04010A1E RID: 68126
		[FieldOffset(44)]
		public float 倍化手柄输入倍率;

		// Token: 0x04010A1F RID: 68127
		[FieldOffset(48)]
		public float 角色开始虚化距离;

		// Token: 0x04010A20 RID: 68128
		[FieldOffset(52)]
		public float 角色最大虚化距离;

		// Token: 0x04010A21 RID: 68129
		[FieldOffset(56)]
		public float 相机动画过程中角色开始虚化距离;

		// Token: 0x04010A22 RID: 68130
		[FieldOffset(60)]
		public float 相机动画过程中角色最大虚化距离;

		// Token: 0x04010A23 RID: 68131
		[FieldOffset(64)]
		public float 相机相对角色的最低高度;

		// Token: 0x04010A24 RID: 68132
		[FieldOffset(68)]
		public float 移动端旋转输入倍率;

		// Token: 0x04010A25 RID: 68133
		[FieldOffset(72)]
		public float 移动端缩放输入倍率;

		// Token: 0x04010A26 RID: 68134
		[FieldOffset(76)]
		public float 最大臂长时的光圈;

		// Token: 0x04010A27 RID: 68135
		[FieldOffset(80)]
		public float 最小臂长时的光圈;

		// Token: 0x04010A28 RID: 68136
		public const string __ObjectPath = "/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraSetting.SUiRoleCameraSetting";

		// Token: 0x04010A29 RID: 68137
		private static IntPtr _ScriptStructPtr;
	}
}
