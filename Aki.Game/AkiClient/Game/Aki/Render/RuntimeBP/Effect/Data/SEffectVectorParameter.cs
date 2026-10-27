using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003DDF RID: 15839
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SEffectVectorParameter : IEqualityOperators<SEffectVectorParameter, SEffectVectorParameter, bool>, IEquatable<SEffectVectorParameter>, IUnrealScriptStruct
	{
		// Token: 0x060277ED RID: 161773 RVA: 0x009930A8 File Offset: 0x009912A8
		public SEffectVectorParameter(FName Name, FVector Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x060277EE RID: 161774 RVA: 0x009930B8 File Offset: 0x009912B8
		public static bool operator ==(SEffectVectorParameter left, SEffectVectorParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x060277EF RID: 161775 RVA: 0x009930E0 File Offset: 0x009912E0
		public static bool operator !=(SEffectVectorParameter left, SEffectVectorParameter right)
		{
			return !(left == right);
		}

		// Token: 0x060277F0 RID: 161776 RVA: 0x009930EC File Offset: 0x009912EC
		public bool Equals(SEffectVectorParameter other)
		{
			return this == other;
		}

		// Token: 0x060277F1 RID: 161777 RVA: 0x009930FC File Offset: 0x009912FC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEffectVectorParameter)
			{
				SEffectVectorParameter other = (SEffectVectorParameter)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060277F2 RID: 161778 RVA: 0x00993121 File Offset: 0x00991321
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FVector>(this.Name, this.Value);
		}

		// Token: 0x060277F3 RID: 161779 RVA: 0x00993134 File Offset: 0x00991334
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectVectorParameter._ScriptStructPtr != 0) ? SEffectVectorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter", ref SEffectVectorParameter._ScriptStructPtr);
		}

		// Token: 0x04013F6B RID: 81771
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04013F6C RID: 81772
		[FieldOffset(12)]
		public FVector Value;

		// Token: 0x04013F6D RID: 81773
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter";

		// Token: 0x04013F6E RID: 81774
		private static IntPtr _ScriptStructPtr;
	}
}
