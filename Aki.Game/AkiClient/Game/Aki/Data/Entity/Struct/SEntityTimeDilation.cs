using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8C RID: 16268
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SEntityTimeDilation : IEqualityOperators<SEntityTimeDilation, SEntityTimeDilation, bool>, IEquatable<SEntityTimeDilation>, IUnrealScriptStruct
	{
		// Token: 0x060298E9 RID: 170217 RVA: 0x009C7230 File Offset: 0x009C5430
		public SEntityTimeDilation(int SourceType, float TimeDilation)
		{
			this.SourceType = SourceType;
			this.TimeDilation = TimeDilation;
		}

		// Token: 0x060298EA RID: 170218 RVA: 0x009C7240 File Offset: 0x009C5440
		public static bool operator ==(SEntityTimeDilation left, SEntityTimeDilation right)
		{
			return left.SourceType == right.SourceType && left.TimeDilation == right.TimeDilation;
		}

		// Token: 0x060298EB RID: 170219 RVA: 0x009C7260 File Offset: 0x009C5460
		public static bool operator !=(SEntityTimeDilation left, SEntityTimeDilation right)
		{
			return !(left == right);
		}

		// Token: 0x060298EC RID: 170220 RVA: 0x009C726C File Offset: 0x009C546C
		public bool Equals(SEntityTimeDilation other)
		{
			return this == other;
		}

		// Token: 0x060298ED RID: 170221 RVA: 0x009C727C File Offset: 0x009C547C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEntityTimeDilation)
			{
				SEntityTimeDilation other = (SEntityTimeDilation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060298EE RID: 170222 RVA: 0x009C72A1 File Offset: 0x009C54A1
		public override int GetHashCode()
		{
			return HashCode.Combine<int, float>(this.SourceType, this.TimeDilation);
		}

		// Token: 0x060298EF RID: 170223 RVA: 0x009C72B4 File Offset: 0x009C54B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityTimeDilation._ScriptStructPtr != 0) ? SEntityTimeDilation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation", ref SEntityTimeDilation._ScriptStructPtr);
		}

		// Token: 0x040154DF RID: 87263
		[FieldOffset(0)]
		public int SourceType;

		// Token: 0x040154E0 RID: 87264
		[FieldOffset(4)]
		public float TimeDilation;

		// Token: 0x040154E1 RID: 87265
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation";

		// Token: 0x040154E2 RID: 87266
		private static IntPtr _ScriptStructPtr;
	}
}
