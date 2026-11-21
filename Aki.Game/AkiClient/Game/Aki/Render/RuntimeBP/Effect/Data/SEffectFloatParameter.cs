using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003112 RID: 12562
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SEffectFloatParameter : IEqualityOperators<SEffectFloatParameter, SEffectFloatParameter, bool>, IEquatable<SEffectFloatParameter>, IUnrealScriptStruct
	{
		// Token: 0x0601EC6B RID: 126059 RVA: 0x0091D0A0 File Offset: 0x0091B2A0
		public SEffectFloatParameter(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601EC6C RID: 126060 RVA: 0x0091D0B0 File Offset: 0x0091B2B0
		public static bool operator ==(SEffectFloatParameter left, SEffectFloatParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x0601EC6D RID: 126061 RVA: 0x0091D0D5 File Offset: 0x0091B2D5
		public static bool operator !=(SEffectFloatParameter left, SEffectFloatParameter right)
		{
			return !(left == right);
		}

		// Token: 0x0601EC6E RID: 126062 RVA: 0x0091D0E1 File Offset: 0x0091B2E1
		public bool Equals(SEffectFloatParameter other)
		{
			return this == other;
		}

		// Token: 0x0601EC6F RID: 126063 RVA: 0x0091D0F0 File Offset: 0x0091B2F0
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

		// Token: 0x0601EC70 RID: 126064 RVA: 0x0091D115 File Offset: 0x0091B315
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, float>(this.Name, this.Value);
		}

		// Token: 0x0601EC71 RID: 126065 RVA: 0x0091D128 File Offset: 0x0091B328
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectFloatParameter._ScriptStructPtr != 0) ? SEffectFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter", ref SEffectFloatParameter._ScriptStructPtr);
		}

		// Token: 0x04010597 RID: 66967
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04010598 RID: 66968
		[FieldOffset(12)]
		public float Value;

		// Token: 0x04010599 RID: 66969
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectFloatParameter.SEffectFloatParameter";

		// Token: 0x0401059A RID: 66970
		private static IntPtr _ScriptStructPtr;
	}
}
