using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003278 RID: 12920
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SReBulletDataObstacles : IEqualityOperators<SReBulletDataObstacles, SReBulletDataObstacles, bool>, IEquatable<SReBulletDataObstacles>, IUnrealScriptStruct
	{
		// Token: 0x06020497 RID: 132247 RVA: 0x00941F16 File Offset: 0x00940116
		public SReBulletDataObstacles(FVector 检测位置, float 检测距离)
		{
			this.检测位置 = 检测位置;
			this.检测距离 = 检测距离;
		}

		// Token: 0x06020498 RID: 132248 RVA: 0x00941F26 File Offset: 0x00940126
		public static bool operator ==(SReBulletDataObstacles left, SReBulletDataObstacles right)
		{
			return left.检测位置 == right.检测位置 && left.检测距离 == right.检测距离;
		}

		// Token: 0x06020499 RID: 132249 RVA: 0x00941F4B File Offset: 0x0094014B
		public static bool operator !=(SReBulletDataObstacles left, SReBulletDataObstacles right)
		{
			return !(left == right);
		}

		// Token: 0x0602049A RID: 132250 RVA: 0x00941F57 File Offset: 0x00940157
		public bool Equals(SReBulletDataObstacles other)
		{
			return this == other;
		}

		// Token: 0x0602049B RID: 132251 RVA: 0x00941F68 File Offset: 0x00940168
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SReBulletDataObstacles)
			{
				SReBulletDataObstacles other = (SReBulletDataObstacles)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602049C RID: 132252 RVA: 0x00941F8D File Offset: 0x0094018D
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float>(this.检测位置, this.检测距离);
		}

		// Token: 0x0602049D RID: 132253 RVA: 0x00941FA0 File Offset: 0x009401A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataObstacles._ScriptStructPtr != 0) ? SReBulletDataObstacles._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles", ref SReBulletDataObstacles._ScriptStructPtr);
		}

		// Token: 0x040116E0 RID: 71392
		[FieldOffset(0)]
		public FVector 检测位置;

		// Token: 0x040116E1 RID: 71393
		[FieldOffset(12)]
		public float 检测距离;

		// Token: 0x040116E2 RID: 71394
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles";

		// Token: 0x040116E3 RID: 71395
		private static IntPtr _ScriptStructPtr;
	}
}
