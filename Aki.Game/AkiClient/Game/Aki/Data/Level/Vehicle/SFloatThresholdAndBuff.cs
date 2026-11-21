using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031BB RID: 12731
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SFloatThresholdAndBuff : IEqualityOperators<SFloatThresholdAndBuff, SFloatThresholdAndBuff, bool>, IEquatable<SFloatThresholdAndBuff>, IUnrealScriptStruct
	{
		// Token: 0x0601F7AB RID: 128939 RVA: 0x0092EB0B File Offset: 0x0092CD0B
		public SFloatThresholdAndBuff(float Threshold, long BuffId)
		{
			this.Threshold = Threshold;
			this.BuffId = BuffId;
		}

		// Token: 0x0601F7AC RID: 128940 RVA: 0x0092EB1B File Offset: 0x0092CD1B
		public static bool operator ==(SFloatThresholdAndBuff left, SFloatThresholdAndBuff right)
		{
			return left.Threshold == right.Threshold && left.BuffId == right.BuffId;
		}

		// Token: 0x0601F7AD RID: 128941 RVA: 0x0092EB3B File Offset: 0x0092CD3B
		public static bool operator !=(SFloatThresholdAndBuff left, SFloatThresholdAndBuff right)
		{
			return !(left == right);
		}

		// Token: 0x0601F7AE RID: 128942 RVA: 0x0092EB47 File Offset: 0x0092CD47
		public bool Equals(SFloatThresholdAndBuff other)
		{
			return this == other;
		}

		// Token: 0x0601F7AF RID: 128943 RVA: 0x0092EB58 File Offset: 0x0092CD58
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFloatThresholdAndBuff)
			{
				SFloatThresholdAndBuff other = (SFloatThresholdAndBuff)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F7B0 RID: 128944 RVA: 0x0092EB7D File Offset: 0x0092CD7D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, long>(this.Threshold, this.BuffId);
		}

		// Token: 0x0601F7B1 RID: 128945 RVA: 0x0092EB90 File Offset: 0x0092CD90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatThresholdAndBuff._ScriptStructPtr != 0) ? SFloatThresholdAndBuff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff", ref SFloatThresholdAndBuff._ScriptStructPtr);
		}

		// Token: 0x04010E24 RID: 69156
		[FieldOffset(0)]
		public float Threshold;

		// Token: 0x04010E25 RID: 69157
		[FieldOffset(8)]
		public long BuffId;

		// Token: 0x04010E26 RID: 69158
		public const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff";

		// Token: 0x04010E27 RID: 69159
		private static IntPtr _ScriptStructPtr;
	}
}
