using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003113 RID: 12563
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SEffectVectorParameter : IEqualityOperators<SEffectVectorParameter, SEffectVectorParameter, bool>, IEquatable<SEffectVectorParameter>, IUnrealScriptStruct
	{
		// Token: 0x0601EC72 RID: 126066 RVA: 0x0091D14C File Offset: 0x0091B34C
		public SEffectVectorParameter(FName Name, FVector Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601EC73 RID: 126067 RVA: 0x0091D15C File Offset: 0x0091B35C
		public static bool operator ==(SEffectVectorParameter left, SEffectVectorParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x0601EC74 RID: 126068 RVA: 0x0091D184 File Offset: 0x0091B384
		public static bool operator !=(SEffectVectorParameter left, SEffectVectorParameter right)
		{
			return !(left == right);
		}

		// Token: 0x0601EC75 RID: 126069 RVA: 0x0091D190 File Offset: 0x0091B390
		public bool Equals(SEffectVectorParameter other)
		{
			return this == other;
		}

		// Token: 0x0601EC76 RID: 126070 RVA: 0x0091D1A0 File Offset: 0x0091B3A0
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

		// Token: 0x0601EC77 RID: 126071 RVA: 0x0091D1C5 File Offset: 0x0091B3C5
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FVector>(this.Name, this.Value);
		}

		// Token: 0x0601EC78 RID: 126072 RVA: 0x0091D1D8 File Offset: 0x0091B3D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectVectorParameter._ScriptStructPtr != 0) ? SEffectVectorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter", ref SEffectVectorParameter._ScriptStructPtr);
		}

		// Token: 0x0401059B RID: 66971
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x0401059C RID: 66972
		[FieldOffset(12)]
		public FVector Value;

		// Token: 0x0401059D RID: 66973
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectVectorParameter.SEffectVectorParameter";

		// Token: 0x0401059E RID: 66974
		private static IntPtr _ScriptStructPtr;
	}
}
