using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004311 RID: 17169
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SEffectType.SEffectType")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SEffectType : IEqualityOperators<SEffectType, SEffectType, bool>, IEquatable<SEffectType>, IUnrealScriptStruct
	{
		// Token: 0x0602C698 RID: 181912 RVA: 0x00A1F318 File Offset: 0x00A1D518
		public SEffectType(TEnumAsByte<EAttributeEffectType> 类型, int Id)
		{
			this.类型 = 类型;
			this.Id = Id;
		}

		// Token: 0x0602C699 RID: 181913 RVA: 0x00A1F328 File Offset: 0x00A1D528
		public static bool operator ==(SEffectType left, SEffectType right)
		{
			return left.类型 == right.类型 && left.Id == right.Id;
		}

		// Token: 0x0602C69A RID: 181914 RVA: 0x00A1F34D File Offset: 0x00A1D54D
		public static bool operator !=(SEffectType left, SEffectType right)
		{
			return !(left == right);
		}

		// Token: 0x0602C69B RID: 181915 RVA: 0x00A1F359 File Offset: 0x00A1D559
		public bool Equals(SEffectType other)
		{
			return this == other;
		}

		// Token: 0x0602C69C RID: 181916 RVA: 0x00A1F368 File Offset: 0x00A1D568
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEffectType)
			{
				SEffectType other = (SEffectType)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C69D RID: 181917 RVA: 0x00A1F38D File Offset: 0x00A1D58D
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EAttributeEffectType>, int>(this.类型, this.Id);
		}

		// Token: 0x0602C69E RID: 181918 RVA: 0x00A1F3A0 File Offset: 0x00A1D5A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectType._ScriptStructPtr != 0) ? SEffectType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SEffectType.SEffectType", ref SEffectType._ScriptStructPtr);
		}

		// Token: 0x040176A6 RID: 95910
		[FieldOffset(0)]
		public TEnumAsByte<EAttributeEffectType> 类型;

		// Token: 0x040176A7 RID: 95911
		[FieldOffset(4)]
		public int Id;

		// Token: 0x040176A8 RID: 95912
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SEffectType.SEffectType";

		// Token: 0x040176A9 RID: 95913
		private static IntPtr _ScriptStructPtr;
	}
}
