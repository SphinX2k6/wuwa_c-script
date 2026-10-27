using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003DDE RID: 15838
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SEffectFloatParameter : IEqualityOperators<SEffectFloatParameter, SEffectFloatParameter, bool>, IEquatable<SEffectFloatParameter>, IUnrealScriptStruct
	{
		// Token: 0x060277E6 RID: 161766 RVA: 0x00992FFC File Offset: 0x009911FC
		public SEffectFloatParameter(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x060277E7 RID: 161767 RVA: 0x0099300C File Offset: 0x0099120C
		public static bool operator ==(SEffectFloatParameter left, SEffectFloatParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x060277E8 RID: 161768 RVA: 0x00993031 File Offset: 0x00991231
		public static bool operator !=(SEffectFloatParameter left, SEffectFloatParameter right)
		{
			return !(left == right);
		}

		// Token: 0x060277E9 RID: 161769 RVA: 0x0099303D File Offset: 0x0099123D
		public bool Equals(SEffectFloatParameter other)
		{
			return this == other;
		}

		// Token: 0x060277EA RID: 161770 RVA: 0x0099304C File Offset: 0x0099124C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEffectFloatParameter)
			{
				SEffectFloatParameter other = (SEffectFloatParameter)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060277EB RID: 161771 RVA: 0x00993071 File Offset: 0x00991271
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, float>(this.Name, this.Value);
		}

		// Token: 0x060277EC RID: 161772 RVA: 0x00993084 File Offset: 0x00991284
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectFloatParameter._ScriptStructPtr != 0) ? SEffectFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter", ref SEffectFloatParameter._ScriptStructPtr);
		}

		// Token: 0x04013F67 RID: 81767
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04013F68 RID: 81768
		[FieldOffset(12)]
		public float Value;

		// Token: 0x04013F69 RID: 81769
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter";

		// Token: 0x04013F6A RID: 81770
		private static IntPtr _ScriptStructPtr;
	}
}
