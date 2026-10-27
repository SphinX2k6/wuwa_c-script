using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004011 RID: 16401
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SReBulletDataEntity : IEqualityOperators<SReBulletDataEntity, SReBulletDataEntity, bool>, IEquatable<SReBulletDataEntity>, IUnrealScriptStruct
	{
		// Token: 0x0602A058 RID: 172120 RVA: 0x009D383B File Offset: 0x009D1A3B
		public SReBulletDataEntity(int 实体ID, bool 是否随子弹销毁而销毁)
		{
			this.实体ID = 实体ID;
			this.是否随子弹销毁而销毁 = 是否随子弹销毁而销毁;
		}

		// Token: 0x0602A059 RID: 172121 RVA: 0x009D384B File Offset: 0x009D1A4B
		public static bool operator ==(SReBulletDataEntity left, SReBulletDataEntity right)
		{
			return left.实体ID == right.实体ID && left.是否随子弹销毁而销毁 == right.是否随子弹销毁而销毁;
		}

		// Token: 0x0602A05A RID: 172122 RVA: 0x009D386B File Offset: 0x009D1A6B
		public static bool operator !=(SReBulletDataEntity left, SReBulletDataEntity right)
		{
			return !(left == right);
		}

		// Token: 0x0602A05B RID: 172123 RVA: 0x009D3877 File Offset: 0x009D1A77
		public bool Equals(SReBulletDataEntity other)
		{
			return this == other;
		}

		// Token: 0x0602A05C RID: 172124 RVA: 0x009D3888 File Offset: 0x009D1A88
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SReBulletDataEntity)
			{
				SReBulletDataEntity other = (SReBulletDataEntity)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A05D RID: 172125 RVA: 0x009D38AD File Offset: 0x009D1AAD
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool>(this.实体ID, this.是否随子弹销毁而销毁);
		}

		// Token: 0x0602A05E RID: 172126 RVA: 0x009D38C0 File Offset: 0x009D1AC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataEntity._ScriptStructPtr != 0) ? SReBulletDataEntity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity", ref SReBulletDataEntity._ScriptStructPtr);
		}

		// Token: 0x04015A3B RID: 88635
		[FieldOffset(0)]
		public int 实体ID;

		// Token: 0x04015A3C RID: 88636
		[FieldOffset(4)]
		public bool 是否随子弹销毁而销毁;

		// Token: 0x04015A3D RID: 88637
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity";

		// Token: 0x04015A3E RID: 88638
		private static IntPtr _ScriptStructPtr;
	}
}
