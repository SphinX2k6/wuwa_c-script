using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003272 RID: 12914
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SReBulletDataEntity : IEqualityOperators<SReBulletDataEntity, SReBulletDataEntity, bool>, IEquatable<SReBulletDataEntity>, IUnrealScriptStruct
	{
		// Token: 0x06020409 RID: 132105 RVA: 0x009410D0 File Offset: 0x0093F2D0
		public SReBulletDataEntity(int 实体ID, bool 是否随子弹销毁而销毁)
		{
			this.实体ID = 实体ID;
			this.是否随子弹销毁而销毁 = 是否随子弹销毁而销毁;
		}

		// Token: 0x0602040A RID: 132106 RVA: 0x009410E0 File Offset: 0x0093F2E0
		public static bool operator ==(SReBulletDataEntity left, SReBulletDataEntity right)
		{
			return left.实体ID == right.实体ID && left.是否随子弹销毁而销毁 == right.是否随子弹销毁而销毁;
		}

		// Token: 0x0602040B RID: 132107 RVA: 0x00941100 File Offset: 0x0093F300
		public static bool operator !=(SReBulletDataEntity left, SReBulletDataEntity right)
		{
			return !(left == right);
		}

		// Token: 0x0602040C RID: 132108 RVA: 0x0094110C File Offset: 0x0093F30C
		public bool Equals(SReBulletDataEntity other)
		{
			return this == other;
		}

		// Token: 0x0602040D RID: 132109 RVA: 0x0094111C File Offset: 0x0093F31C
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

		// Token: 0x0602040E RID: 132110 RVA: 0x00941141 File Offset: 0x0093F341
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool>(this.实体ID, this.是否随子弹销毁而销毁);
		}

		// Token: 0x0602040F RID: 132111 RVA: 0x00941154 File Offset: 0x0093F354
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataEntity._ScriptStructPtr != 0) ? SReBulletDataEntity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity", ref SReBulletDataEntity._ScriptStructPtr);
		}

		// Token: 0x0401168E RID: 71310
		[FieldOffset(0)]
		public int 实体ID;

		// Token: 0x0401168F RID: 71311
		[FieldOffset(4)]
		public bool 是否随子弹销毁而销毁;

		// Token: 0x04011690 RID: 71312
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataEntity.SReBulletDataEntity";

		// Token: 0x04011691 RID: 71313
		private static IntPtr _ScriptStructPtr;
	}
}
