using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326F RID: 12911
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SReBulletDataAimed : IEqualityOperators<SReBulletDataAimed, SReBulletDataAimed, bool>, IEquatable<SReBulletDataAimed>, IUnrealScriptStruct
	{
		// Token: 0x06020386 RID: 131974 RVA: 0x009405E4 File Offset: 0x0093E7E4
		public SReBulletDataAimed(bool 跟随骨骼发射, bool 初始旋转是否面向目标, bool 瞄准发射, float 瞄准子弹最大偏转角度, float 瞄准子弹最大射程)
		{
			this.跟随骨骼发射 = 跟随骨骼发射;
			this.初始旋转是否面向目标 = 初始旋转是否面向目标;
			this.瞄准发射 = 瞄准发射;
			this.瞄准子弹最大偏转角度 = 瞄准子弹最大偏转角度;
			this.瞄准子弹最大射程 = 瞄准子弹最大射程;
		}

		// Token: 0x06020387 RID: 131975 RVA: 0x0094060C File Offset: 0x0093E80C
		public static bool operator ==(SReBulletDataAimed left, SReBulletDataAimed right)
		{
			return left.跟随骨骼发射 == right.跟随骨骼发射 && left.初始旋转是否面向目标 == right.初始旋转是否面向目标 && left.瞄准发射 == right.瞄准发射 && left.瞄准子弹最大偏转角度 == right.瞄准子弹最大偏转角度 && left.瞄准子弹最大射程 == right.瞄准子弹最大射程;
		}

		// Token: 0x06020388 RID: 131976 RVA: 0x00940661 File Offset: 0x0093E861
		public static bool operator !=(SReBulletDataAimed left, SReBulletDataAimed right)
		{
			return !(left == right);
		}

		// Token: 0x06020389 RID: 131977 RVA: 0x0094066D File Offset: 0x0093E86D
		public bool Equals(SReBulletDataAimed other)
		{
			return this == other;
		}

		// Token: 0x0602038A RID: 131978 RVA: 0x0094067C File Offset: 0x0093E87C
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

		// Token: 0x0602038B RID: 131979 RVA: 0x009406A1 File Offset: 0x0093E8A1
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, bool, bool, float, float>(this.跟随骨骼发射, this.初始旋转是否面向目标, this.瞄准发射, this.瞄准子弹最大偏转角度, this.瞄准子弹最大射程);
		}

		// Token: 0x0602038C RID: 131980 RVA: 0x009406C6 File Offset: 0x0093E8C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataAimed._ScriptStructPtr != 0) ? SReBulletDataAimed._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed", ref SReBulletDataAimed._ScriptStructPtr);
		}

		// Token: 0x04011646 RID: 71238
		[FieldOffset(0)]
		public bool 跟随骨骼发射;

		// Token: 0x04011647 RID: 71239
		[FieldOffset(1)]
		public bool 初始旋转是否面向目标;

		// Token: 0x04011648 RID: 71240
		[FieldOffset(2)]
		public bool 瞄准发射;

		// Token: 0x04011649 RID: 71241
		[FieldOffset(4)]
		public float 瞄准子弹最大偏转角度;

		// Token: 0x0401164A RID: 71242
		[FieldOffset(8)]
		public float 瞄准子弹最大射程;

		// Token: 0x0401164B RID: 71243
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataAimed.SReBulletDataAimed";

		// Token: 0x0401164C RID: 71244
		private static IntPtr _ScriptStructPtr;
	}
}
