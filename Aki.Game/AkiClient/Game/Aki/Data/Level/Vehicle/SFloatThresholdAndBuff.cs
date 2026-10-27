using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFE RID: 16126
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SFloatThresholdAndBuff : IEqualityOperators<SFloatThresholdAndBuff, SFloatThresholdAndBuff, bool>, IEquatable<SFloatThresholdAndBuff>, IUnrealScriptStruct
	{
		// Token: 0x06028E0E RID: 167438 RVA: 0x009B6A43 File Offset: 0x009B4C43
		public SFloatThresholdAndBuff(float Threshold, long BuffId)
		{
			this.Threshold = Threshold;
			this.BuffId = BuffId;
		}

		// Token: 0x06028E0F RID: 167439 RVA: 0x009B6A53 File Offset: 0x009B4C53
		public static bool operator ==(SFloatThresholdAndBuff left, SFloatThresholdAndBuff right)
		{
			return left.Threshold == right.Threshold && left.BuffId == right.BuffId;
		}

		// Token: 0x06028E10 RID: 167440 RVA: 0x009B6A73 File Offset: 0x009B4C73
		public static bool operator !=(SFloatThresholdAndBuff left, SFloatThresholdAndBuff right)
		{
			return !(left == right);
		}

		// Token: 0x06028E11 RID: 167441 RVA: 0x009B6A7F File Offset: 0x009B4C7F
		public bool Equals(SFloatThresholdAndBuff other)
		{
			return this == other;
		}

		// Token: 0x06028E12 RID: 167442 RVA: 0x009B6A90 File Offset: 0x009B4C90
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

		// Token: 0x06028E13 RID: 167443 RVA: 0x009B6AB5 File Offset: 0x009B4CB5
		public override int GetHashCode()
		{
			return HashCode.Combine<float, long>(this.Threshold, this.BuffId);
		}

		// Token: 0x06028E14 RID: 167444 RVA: 0x009B6AC8 File Offset: 0x009B4CC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatThresholdAndBuff._ScriptStructPtr != 0) ? SFloatThresholdAndBuff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff", ref SFloatThresholdAndBuff._ScriptStructPtr);
		}

		// Token: 0x04014E7F RID: 85631
		[FieldOffset(0)]
		public float Threshold;

		// Token: 0x04014E80 RID: 85632
		[FieldOffset(8)]
		public long BuffId;

		// Token: 0x04014E81 RID: 85633
		public const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndBuff.SFloatThresholdAndBuff";

		// Token: 0x04014E82 RID: 85634
		private static IntPtr _ScriptStructPtr;
	}
}
