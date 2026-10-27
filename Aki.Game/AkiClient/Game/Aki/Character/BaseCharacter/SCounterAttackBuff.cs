using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004305 RID: 17157
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SCounterAttackBuff : IEqualityOperators<SCounterAttackBuff, SCounterAttackBuff, bool>, IEquatable<SCounterAttackBuff>, IUnrealScriptStruct
	{
		// Token: 0x0602C5D0 RID: 181712 RVA: 0x00A1E194 File Offset: 0x00A1C394
		public SCounterAttackBuff(long BuffID, int 层数)
		{
			this.BuffID = BuffID;
			this.层数 = 层数;
		}

		// Token: 0x0602C5D1 RID: 181713 RVA: 0x00A1E1A4 File Offset: 0x00A1C3A4
		public static bool operator ==(SCounterAttackBuff left, SCounterAttackBuff right)
		{
			return left.BuffID == right.BuffID && left.层数 == right.层数;
		}

		// Token: 0x0602C5D2 RID: 181714 RVA: 0x00A1E1C4 File Offset: 0x00A1C3C4
		public static bool operator !=(SCounterAttackBuff left, SCounterAttackBuff right)
		{
			return !(left == right);
		}

		// Token: 0x0602C5D3 RID: 181715 RVA: 0x00A1E1D0 File Offset: 0x00A1C3D0
		public bool Equals(SCounterAttackBuff other)
		{
			return this == other;
		}

		// Token: 0x0602C5D4 RID: 181716 RVA: 0x00A1E1E0 File Offset: 0x00A1C3E0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SCounterAttackBuff)
			{
				SCounterAttackBuff other = (SCounterAttackBuff)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C5D5 RID: 181717 RVA: 0x00A1E205 File Offset: 0x00A1C405
		public override int GetHashCode()
		{
			return HashCode.Combine<long, int>(this.BuffID, this.层数);
		}

		// Token: 0x0602C5D6 RID: 181718 RVA: 0x00A1E218 File Offset: 0x00A1C418
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackBuff._ScriptStructPtr != 0) ? SCounterAttackBuff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff", ref SCounterAttackBuff._ScriptStructPtr);
		}

		// Token: 0x04017649 RID: 95817
		[FieldOffset(0)]
		public long BuffID;

		// Token: 0x0401764A RID: 95818
		[FieldOffset(8)]
		public int 层数;

		// Token: 0x0401764B RID: 95819
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff";

		// Token: 0x0401764C RID: 95820
		private static IntPtr _ScriptStructPtr;
	}
}
