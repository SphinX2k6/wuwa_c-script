using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003DDD RID: 15837
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct SEffectColorParameter : IEqualityOperators<SEffectColorParameter, SEffectColorParameter, bool>, IEquatable<SEffectColorParameter>, IUnrealScriptStruct
	{
		// Token: 0x060277DF RID: 161759 RVA: 0x00992F4C File Offset: 0x0099114C
		public SEffectColorParameter(FName Name, FLinearColor Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x060277E0 RID: 161760 RVA: 0x00992F5C File Offset: 0x0099115C
		public static bool operator ==(SEffectColorParameter left, SEffectColorParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x060277E1 RID: 161761 RVA: 0x00992F84 File Offset: 0x00991184
		public static bool operator !=(SEffectColorParameter left, SEffectColorParameter right)
		{
			return !(left == right);
		}

		// Token: 0x060277E2 RID: 161762 RVA: 0x00992F90 File Offset: 0x00991190
		public bool Equals(SEffectColorParameter other)
		{
			return this == other;
		}

		// Token: 0x060277E3 RID: 161763 RVA: 0x00992FA0 File Offset: 0x009911A0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEffectColorParameter)
			{
				SEffectColorParameter other = (SEffectColorParameter)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060277E4 RID: 161764 RVA: 0x00992FC5 File Offset: 0x009911C5
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FLinearColor>(this.Name, this.Value);
		}

		// Token: 0x060277E5 RID: 161765 RVA: 0x00992FD8 File Offset: 0x009911D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectColorParameter._ScriptStructPtr != 0) ? SEffectColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter", ref SEffectColorParameter._ScriptStructPtr);
		}

		// Token: 0x04013F63 RID: 81763
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04013F64 RID: 81764
		[FieldOffset(12)]
		public FLinearColor Value;

		// Token: 0x04013F65 RID: 81765
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter";

		// Token: 0x04013F66 RID: 81766
		private static IntPtr _ScriptStructPtr;
	}
}
