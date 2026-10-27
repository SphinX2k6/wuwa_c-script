using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004017 RID: 16407
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SReBulletDataObstacles : IEqualityOperators<SReBulletDataObstacles, SReBulletDataObstacles, bool>, IEquatable<SReBulletDataObstacles>, IUnrealScriptStruct
	{
		// Token: 0x0602A0ED RID: 172269 RVA: 0x009D489C File Offset: 0x009D2A9C
		public SReBulletDataObstacles(FVector 检测位置, float 检测距离)
		{
			this.检测位置 = 检测位置;
			this.检测距离 = 检测距离;
		}

		// Token: 0x0602A0EE RID: 172270 RVA: 0x009D48AC File Offset: 0x009D2AAC
		public static bool operator ==(SReBulletDataObstacles left, SReBulletDataObstacles right)
		{
			return left.检测位置 == right.检测位置 && left.检测距离 == right.检测距离;
		}

		// Token: 0x0602A0EF RID: 172271 RVA: 0x009D48D1 File Offset: 0x009D2AD1
		public static bool operator !=(SReBulletDataObstacles left, SReBulletDataObstacles right)
		{
			return !(left == right);
		}

		// Token: 0x0602A0F0 RID: 172272 RVA: 0x009D48DD File Offset: 0x009D2ADD
		public bool Equals(SReBulletDataObstacles other)
		{
			return this == other;
		}

		// Token: 0x0602A0F1 RID: 172273 RVA: 0x009D48EC File Offset: 0x009D2AEC
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

		// Token: 0x0602A0F2 RID: 172274 RVA: 0x009D4911 File Offset: 0x009D2B11
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float>(this.检测位置, this.检测距离);
		}

		// Token: 0x0602A0F3 RID: 172275 RVA: 0x009D4924 File Offset: 0x009D2B24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataObstacles._ScriptStructPtr != 0) ? SReBulletDataObstacles._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles", ref SReBulletDataObstacles._ScriptStructPtr);
		}

		// Token: 0x04015A8E RID: 88718
		[FieldOffset(0)]
		public FVector 检测位置;

		// Token: 0x04015A8F RID: 88719
		[FieldOffset(12)]
		public float 检测距离;

		// Token: 0x04015A90 RID: 88720
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataObstacles.SReBulletDataObstacles";

		// Token: 0x04015A91 RID: 88721
		private static IntPtr _ScriptStructPtr;
	}
}
