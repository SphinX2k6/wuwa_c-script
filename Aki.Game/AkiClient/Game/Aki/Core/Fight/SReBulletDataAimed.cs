using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400E RID: 16398
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SReBulletDataAimed : IEqualityOperators<SReBulletDataAimed, SReBulletDataAimed, bool>, IEquatable<SReBulletDataAimed>, IUnrealScriptStruct
	{
		// Token: 0x06029FD5 RID: 171989 RVA: 0x009D2BA8 File Offset: 0x009D0DA8
		public SReBulletDataAimed(bool 跟随骨骼发射, bool 初始旋转是否面向目标, bool 瞄准发射, float 瞄准子弹最大偏转角度, float 瞄准子弹最大射程)
		{
			this.跟随骨骼发射 = 跟随骨骼发射;
			this.初始旋转是否面向目标 = 初始旋转是否面向目标;
			this.瞄准发射 = 瞄准发射;
			this.瞄准子弹最大偏转角度 = 瞄准子弹最大偏转角度;
			this.瞄准子弹最大射程 = 瞄准子弹最大射程;
		}

		// Token: 0x06029FD6 RID: 171990 RVA: 0x009D2BD0 File Offset: 0x009D0DD0
		public static bool operator ==(SReBulletDataAimed left, SReBulletDataAimed right)
		{
			return left.跟随骨骼发射 == right.跟随骨骼发射 && left.初始旋转是否面向目标 == right.初始旋转是否面向目标 && left.瞄准发射 == right.瞄准发射 && left.瞄准子弹最大偏转角度 == right.瞄准子弹最大偏转角度 && left.瞄准子弹最大射程 == right.瞄准子弹最大射程;
		}

		// Token: 0x06029FD7 RID: 171991 RVA: 0x009D2C25 File Offset: 0x009D0E25
		public static bool operator !=(SReBulletDataAimed left, SReBulletDataAimed right)
		{
			return !(left == right);
		}

		// Token: 0x06029FD8 RID: 171992 RVA: 0x009D2C31 File Offset: 0x009D0E31
		public bool Equals(SReBulletDataAimed other)
		{
			return this == other;
		}

		// Token: 0x06029FD9 RID: 171993 RVA: 0x009D2C40 File Offset: 0x009D0E40
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SReBulletDataAimed)
			{
				SReBulletDataAimed other = (SReBulletDataAimed)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029FDA RID: 171994 RVA: 0x009D2C65 File Offset: 0x009D0E65
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, bool, bool, float, float>(this.跟随骨骼发射, this.初始旋转是否面向目标, this.瞄准发射, this.瞄准子弹最大偏转角度, this.瞄准子弹最大射程);
		}

		// Token: 0x06029FDB RID: 171995 RVA: 0x009D2C8A File Offset: 0x009D0E8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataAimed._ScriptStructPtr != 0) ? SReBulletDataAimed._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed", ref SReBulletDataAimed._ScriptStructPtr);
		}

		// Token: 0x040159F4 RID: 88564
		[FieldOffset(0)]
		public bool 跟随骨骼发射;

		// Token: 0x040159F5 RID: 88565
		[FieldOffset(1)]
		public bool 初始旋转是否面向目标;

		// Token: 0x040159F6 RID: 88566
		[FieldOffset(2)]
		public bool 瞄准发射;

		// Token: 0x040159F7 RID: 88567
		[FieldOffset(4)]
		public float 瞄准子弹最大偏转角度;

		// Token: 0x040159F8 RID: 88568
		[FieldOffset(8)]
		public float 瞄准子弹最大射程;

		// Token: 0x040159F9 RID: 88569
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed";

		// Token: 0x040159FA RID: 88570
		private static IntPtr _ScriptStructPtr;
	}
}
