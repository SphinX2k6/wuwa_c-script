using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004321 RID: 17185
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SLeanAmount.SLeanAmount")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SLeanAmount : IEqualityOperators<SLeanAmount, SLeanAmount, bool>, IEquatable<SLeanAmount>, IUnrealScriptStruct
	{
		// Token: 0x0602C7CF RID: 182223 RVA: 0x00A20DD4 File Offset: 0x00A1EFD4
		public SLeanAmount(float 前后, float 左右)
		{
			this.前后 = 前后;
			this.左右 = 左右;
		}

		// Token: 0x0602C7D0 RID: 182224 RVA: 0x00A20DE4 File Offset: 0x00A1EFE4
		public static bool operator ==(SLeanAmount left, SLeanAmount right)
		{
			return left.前后 == right.前后 && left.左右 == right.左右;
		}

		// Token: 0x0602C7D1 RID: 182225 RVA: 0x00A20E04 File Offset: 0x00A1F004
		public static bool operator !=(SLeanAmount left, SLeanAmount right)
		{
			return !(left == right);
		}

		// Token: 0x0602C7D2 RID: 182226 RVA: 0x00A20E10 File Offset: 0x00A1F010
		public bool Equals(SLeanAmount other)
		{
			return this == other;
		}

		// Token: 0x0602C7D3 RID: 182227 RVA: 0x00A20E20 File Offset: 0x00A1F020
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SLeanAmount)
			{
				SLeanAmount other = (SLeanAmount)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C7D4 RID: 182228 RVA: 0x00A20E45 File Offset: 0x00A1F045
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.前后, this.左右);
		}

		// Token: 0x0602C7D5 RID: 182229 RVA: 0x00A20E58 File Offset: 0x00A1F058
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLeanAmount._ScriptStructPtr != 0) ? SLeanAmount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SLeanAmount.SLeanAmount", ref SLeanAmount._ScriptStructPtr);
		}

		// Token: 0x04017738 RID: 96056
		[FieldOffset(0)]
		public float 前后;

		// Token: 0x04017739 RID: 96057
		[FieldOffset(4)]
		public float 左右;

		// Token: 0x0401773A RID: 96058
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SLeanAmount.SLeanAmount";

		// Token: 0x0401773B RID: 96059
		private static IntPtr _ScriptStructPtr;
	}
}
