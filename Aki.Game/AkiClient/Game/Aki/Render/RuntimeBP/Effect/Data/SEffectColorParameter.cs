using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data
{
	// Token: 0x02003111 RID: 12561
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct SEffectColorParameter : IEqualityOperators<SEffectColorParameter, SEffectColorParameter, bool>, IEquatable<SEffectColorParameter>, IUnrealScriptStruct
	{
		// Token: 0x0601EC64 RID: 126052 RVA: 0x0091CFF0 File Offset: 0x0091B1F0
		public SEffectColorParameter(FName Name, FLinearColor Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601EC65 RID: 126053 RVA: 0x0091D000 File Offset: 0x0091B200
		public static bool operator ==(SEffectColorParameter left, SEffectColorParameter right)
		{
			return left.Name == right.Name && left.Value == right.Value;
		}

		// Token: 0x0601EC66 RID: 126054 RVA: 0x0091D028 File Offset: 0x0091B228
		public static bool operator !=(SEffectColorParameter left, SEffectColorParameter right)
		{
			return !(left == right);
		}

		// Token: 0x0601EC67 RID: 126055 RVA: 0x0091D034 File Offset: 0x0091B234
		public bool Equals(SEffectColorParameter other)
		{
			return this == other;
		}

		// Token: 0x0601EC68 RID: 126056 RVA: 0x0091D044 File Offset: 0x0091B244
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

		// Token: 0x0601EC69 RID: 126057 RVA: 0x0091D069 File Offset: 0x0091B269
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FLinearColor>(this.Name, this.Value);
		}

		// Token: 0x0601EC6A RID: 126058 RVA: 0x0091D07C File Offset: 0x0091B27C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectColorParameter._ScriptStructPtr != 0) ? SEffectColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter", ref SEffectColorParameter._ScriptStructPtr);
		}

		// Token: 0x04010593 RID: 66963
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04010594 RID: 66964
		[FieldOffset(12)]
		public FLinearColor Value;

		// Token: 0x04010595 RID: 66965
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Data/SEffectColorParameter.SEffectColorParameter";

		// Token: 0x04010596 RID: 66966
		private static IntPtr _ScriptStructPtr;
	}
}
