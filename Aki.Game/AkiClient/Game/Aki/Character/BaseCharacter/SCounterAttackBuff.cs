using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003343 RID: 13123
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SCounterAttackBuff : IEqualityOperators<SCounterAttackBuff, SCounterAttackBuff, bool>, IEquatable<SCounterAttackBuff>, IUnrealScriptStruct
	{
		// Token: 0x060212FB RID: 135931 RVA: 0x0095B2DC File Offset: 0x009594DC
		public SCounterAttackBuff(long BuffID, int 层数)
		{
			this.BuffID = BuffID;
			this.层数 = 层数;
		}

		// Token: 0x060212FC RID: 135932 RVA: 0x0095B2EC File Offset: 0x009594EC
		public static bool operator ==(SCounterAttackBuff left, SCounterAttackBuff right)
		{
			return left.BuffID == right.BuffID && left.层数 == right.层数;
		}

		// Token: 0x060212FD RID: 135933 RVA: 0x0095B30C File Offset: 0x0095950C
		public static bool operator !=(SCounterAttackBuff left, SCounterAttackBuff right)
		{
			return !(left == right);
		}

		// Token: 0x060212FE RID: 135934 RVA: 0x0095B318 File Offset: 0x00959518
		public bool Equals(SCounterAttackBuff other)
		{
			return this == other;
		}

		// Token: 0x060212FF RID: 135935 RVA: 0x0095B328 File Offset: 0x00959528
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

		// Token: 0x06021300 RID: 135936 RVA: 0x0095B34D File Offset: 0x0095954D
		public override int GetHashCode()
		{
			return HashCode.Combine<long, int>(this.BuffID, this.层数);
		}

		// Token: 0x06021301 RID: 135937 RVA: 0x0095B360 File Offset: 0x00959560
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackBuff._ScriptStructPtr != 0) ? SCounterAttackBuff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff", ref SCounterAttackBuff._ScriptStructPtr);
		}

		// Token: 0x04012252 RID: 74322
		[FieldOffset(0)]
		public long BuffID;

		// Token: 0x04012253 RID: 74323
		[FieldOffset(8)]
		public int 层数;

		// Token: 0x04012254 RID: 74324
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackBuff.SCounterAttackBuff";

		// Token: 0x04012255 RID: 74325
		private static IntPtr _ScriptStructPtr;
	}
}
