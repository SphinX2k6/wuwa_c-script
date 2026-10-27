using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.LevelGamePlay.StrikeResponse.Stuct
{
	// Token: 0x02003F17 RID: 16151
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 10)]
	[UnrealObjectPath("/Game/Aki/Data/LevelGamePlay/StrikeResponse/Stuct/SStrikeInfo.SStrikeInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SStrikeInfo : IEqualityOperators<SStrikeInfo, SStrikeInfo, bool>, IEquatable<SStrikeInfo>, IUnrealScriptStruct
	{
		// Token: 0x06029038 RID: 167992 RVA: 0x009B99D3 File Offset: 0x009B7BD3
		public SStrikeInfo(TEnumAsByte<ECamp> Striker, float SrikeDirection, TEnumAsByte<SrikeElement> Element, TEnumAsByte<StrikeType> SrikeType)
		{
			this.Striker = Striker;
			this.SrikeDirection = SrikeDirection;
			this.Element = Element;
			this.SrikeType = SrikeType;
		}

		// Token: 0x06029039 RID: 167993 RVA: 0x009B99F4 File Offset: 0x009B7BF4
		public static bool operator ==(SStrikeInfo left, SStrikeInfo right)
		{
			return left.Striker == right.Striker && left.SrikeDirection == right.SrikeDirection && left.Element == right.Element && left.SrikeType == right.SrikeType;
		}

		// Token: 0x0602903A RID: 167994 RVA: 0x009B9A48 File Offset: 0x009B7C48
		public static bool operator !=(SStrikeInfo left, SStrikeInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0602903B RID: 167995 RVA: 0x009B9A54 File Offset: 0x009B7C54
		public bool Equals(SStrikeInfo other)
		{
			return this == other;
		}

		// Token: 0x0602903C RID: 167996 RVA: 0x009B9A64 File Offset: 0x009B7C64
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SStrikeInfo)
			{
				SStrikeInfo other = (SStrikeInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602903D RID: 167997 RVA: 0x009B9A89 File Offset: 0x009B7C89
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<ECamp>, float, TEnumAsByte<SrikeElement>, TEnumAsByte<StrikeType>>(this.Striker, this.SrikeDirection, this.Element, this.SrikeType);
		}

		// Token: 0x0602903E RID: 167998 RVA: 0x009B9AA8 File Offset: 0x009B7CA8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SStrikeInfo._ScriptStructPtr != 0) ? SStrikeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/LevelGamePlay/StrikeResponse/Stuct/SStrikeInfo.SStrikeInfo", ref SStrikeInfo._ScriptStructPtr);
		}

		// Token: 0x04014FBE RID: 85950
		[FieldOffset(0)]
		public TEnumAsByte<ECamp> Striker;

		// Token: 0x04014FBF RID: 85951
		[FieldOffset(4)]
		public float SrikeDirection;

		// Token: 0x04014FC0 RID: 85952
		[FieldOffset(8)]
		public TEnumAsByte<SrikeElement> Element;

		// Token: 0x04014FC1 RID: 85953
		[FieldOffset(9)]
		public TEnumAsByte<StrikeType> SrikeType;

		// Token: 0x04014FC2 RID: 85954
		public const string __ObjectPath = "/Game/Aki/Data/LevelGamePlay/StrikeResponse/Stuct/SStrikeInfo.SStrikeInfo";

		// Token: 0x04014FC3 RID: 85955
		private static IntPtr _ScriptStructPtr;
	}
}
