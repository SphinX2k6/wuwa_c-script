using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F5C RID: 16220
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarOffset.SSpecialEnergyBarOffset")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SSpecialEnergyBarOffset : IEqualityOperators<SSpecialEnergyBarOffset, SSpecialEnergyBarOffset, bool>, IEquatable<SSpecialEnergyBarOffset>, IUnrealScriptStruct
	{
		// Token: 0x06029517 RID: 169239 RVA: 0x009C1254 File Offset: 0x009BF454
		public SSpecialEnergyBarOffset(int MinPercent, int MaxPercent, int MinOffsetX, int MinOffsetY, int MaxOffsetX, int MaxOffsetY)
		{
			this.MinPercent = MinPercent;
			this.MaxPercent = MaxPercent;
			this.MinOffsetX = MinOffsetX;
			this.MinOffsetY = MinOffsetY;
			this.MaxOffsetX = MaxOffsetX;
			this.MaxOffsetY = MaxOffsetY;
		}

		// Token: 0x06029518 RID: 169240 RVA: 0x009C1284 File Offset: 0x009BF484
		public static bool operator ==(SSpecialEnergyBarOffset left, SSpecialEnergyBarOffset right)
		{
			return left.MinPercent == right.MinPercent && left.MaxPercent == right.MaxPercent && left.MinOffsetX == right.MinOffsetX && left.MinOffsetY == right.MinOffsetY && left.MaxOffsetX == right.MaxOffsetX && left.MaxOffsetY == right.MaxOffsetY;
		}

		// Token: 0x06029519 RID: 169241 RVA: 0x009C12E7 File Offset: 0x009BF4E7
		public static bool operator !=(SSpecialEnergyBarOffset left, SSpecialEnergyBarOffset right)
		{
			return !(left == right);
		}

		// Token: 0x0602951A RID: 169242 RVA: 0x009C12F3 File Offset: 0x009BF4F3
		public bool Equals(SSpecialEnergyBarOffset other)
		{
			return this == other;
		}

		// Token: 0x0602951B RID: 169243 RVA: 0x009C1304 File Offset: 0x009BF504
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSpecialEnergyBarOffset)
			{
				SSpecialEnergyBarOffset other = (SSpecialEnergyBarOffset)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602951C RID: 169244 RVA: 0x009C1329 File Offset: 0x009BF529
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int, int, int>(this.MinPercent, this.MaxPercent, this.MinOffsetX, this.MinOffsetY, this.MaxOffsetX, this.MaxOffsetY);
		}

		// Token: 0x0602951D RID: 169245 RVA: 0x009C1354 File Offset: 0x009BF554
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBarOffset._ScriptStructPtr != 0) ? SSpecialEnergyBarOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarOffset.SSpecialEnergyBarOffset", ref SSpecialEnergyBarOffset._ScriptStructPtr);
		}

		// Token: 0x040152B2 RID: 86706
		[FieldOffset(0)]
		public int MinPercent;

		// Token: 0x040152B3 RID: 86707
		[FieldOffset(4)]
		public int MaxPercent;

		// Token: 0x040152B4 RID: 86708
		[FieldOffset(8)]
		public int MinOffsetX;

		// Token: 0x040152B5 RID: 86709
		[FieldOffset(12)]
		public int MinOffsetY;

		// Token: 0x040152B6 RID: 86710
		[FieldOffset(16)]
		public int MaxOffsetX;

		// Token: 0x040152B7 RID: 86711
		[FieldOffset(20)]
		public int MaxOffsetY;

		// Token: 0x040152B8 RID: 86712
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBarOffset.SSpecialEnergyBarOffset";

		// Token: 0x040152B9 RID: 86713
		private static IntPtr _ScriptStructPtr;
	}
}
