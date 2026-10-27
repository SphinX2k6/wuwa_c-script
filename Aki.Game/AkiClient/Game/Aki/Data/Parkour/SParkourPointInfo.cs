using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Parkour
{
	// Token: 0x02003EEC RID: 16108
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Data/Parkour/SParkourPointInfo.SParkourPointInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SParkourPointInfo : IEqualityOperators<SParkourPointInfo, SParkourPointInfo, bool>, IEquatable<SParkourPointInfo>, IUnrealScriptStruct
	{
		// Token: 0x06028CAF RID: 167087 RVA: 0x009B4BF0 File Offset: 0x009B2DF0
		public SParkourPointInfo(FVector Location, float Radius, float ModifiedTime, int BuffId)
		{
			this.Location = Location;
			this.Radius = Radius;
			this.ModifiedTime = ModifiedTime;
			this.BuffId = BuffId;
		}

		// Token: 0x06028CB0 RID: 167088 RVA: 0x009B4C10 File Offset: 0x009B2E10
		public static bool operator ==(SParkourPointInfo left, SParkourPointInfo right)
		{
			return left.Location == right.Location && left.Radius == right.Radius && left.ModifiedTime == right.ModifiedTime && left.BuffId == right.BuffId;
		}

		// Token: 0x06028CB1 RID: 167089 RVA: 0x009B4C5C File Offset: 0x009B2E5C
		public static bool operator !=(SParkourPointInfo left, SParkourPointInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06028CB2 RID: 167090 RVA: 0x009B4C68 File Offset: 0x009B2E68
		public bool Equals(SParkourPointInfo other)
		{
			return this == other;
		}

		// Token: 0x06028CB3 RID: 167091 RVA: 0x009B4C78 File Offset: 0x009B2E78
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SParkourPointInfo)
			{
				SParkourPointInfo other = (SParkourPointInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028CB4 RID: 167092 RVA: 0x009B4C9D File Offset: 0x009B2E9D
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float, float, int>(this.Location, this.Radius, this.ModifiedTime, this.BuffId);
		}

		// Token: 0x06028CB5 RID: 167093 RVA: 0x009B4CBC File Offset: 0x009B2EBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SParkourPointInfo._ScriptStructPtr != 0) ? SParkourPointInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Parkour/SParkourPointInfo.SParkourPointInfo", ref SParkourPointInfo._ScriptStructPtr);
		}

		// Token: 0x04014D9F RID: 85407
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x04014DA0 RID: 85408
		[FieldOffset(12)]
		public float Radius;

		// Token: 0x04014DA1 RID: 85409
		[FieldOffset(16)]
		public float ModifiedTime;

		// Token: 0x04014DA2 RID: 85410
		[FieldOffset(20)]
		public int BuffId;

		// Token: 0x04014DA3 RID: 85411
		public const string __ObjectPath = "/Game/Aki/Data/Parkour/SParkourPointInfo.SParkourPointInfo";

		// Token: 0x04014DA4 RID: 85412
		private static IntPtr _ScriptStructPtr;
	}
}
