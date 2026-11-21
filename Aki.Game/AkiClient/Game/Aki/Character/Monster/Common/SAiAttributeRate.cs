using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032C8 RID: 13000
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SAiAttributeRate : IEqualityOperators<SAiAttributeRate, SAiAttributeRate, bool>, IEquatable<SAiAttributeRate>, IUnrealScriptStruct
	{
		// Token: 0x06020ED8 RID: 134872 RVA: 0x00952B32 File Offset: 0x00950D32
		public SAiAttributeRate(TEnumAsByte<EAttributeType> Numerator, TEnumAsByte<EAttributeType> Denominator, FFloatRange Range)
		{
			this.Numerator = Numerator;
			this.Denominator = Denominator;
			this.Range = Range;
		}

		// Token: 0x06020ED9 RID: 134873 RVA: 0x00952B49 File Offset: 0x00950D49
		public static bool operator ==(SAiAttributeRate left, SAiAttributeRate right)
		{
			return left.Numerator == right.Numerator && left.Denominator == right.Denominator && left.Range == right.Range;
		}

		// Token: 0x06020EDA RID: 134874 RVA: 0x00952B84 File Offset: 0x00950D84
		public static bool operator !=(SAiAttributeRate left, SAiAttributeRate right)
		{
			return !(left == right);
		}

		// Token: 0x06020EDB RID: 134875 RVA: 0x00952B90 File Offset: 0x00950D90
		public bool Equals(SAiAttributeRate other)
		{
			return this == other;
		}

		// Token: 0x06020EDC RID: 134876 RVA: 0x00952BA0 File Offset: 0x00950DA0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SAiAttributeRate)
			{
				SAiAttributeRate other = (SAiAttributeRate)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06020EDD RID: 134877 RVA: 0x00952BC5 File Offset: 0x00950DC5
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EAttributeType>, TEnumAsByte<EAttributeType>, FFloatRange>(this.Numerator, this.Denominator, this.Range);
		}

		// Token: 0x06020EDE RID: 134878 RVA: 0x00952BDE File Offset: 0x00950DDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiAttributeRate._ScriptStructPtr != 0) ? SAiAttributeRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate", ref SAiAttributeRate._ScriptStructPtr);
		}

		// Token: 0x04011D5F RID: 73055
		[FieldOffset(0)]
		public TEnumAsByte<EAttributeType> Numerator;

		// Token: 0x04011D60 RID: 73056
		[FieldOffset(1)]
		public TEnumAsByte<EAttributeType> Denominator;

		// Token: 0x04011D61 RID: 73057
		[FieldOffset(4)]
		public FFloatRange Range;

		// Token: 0x04011D62 RID: 73058
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate";

		// Token: 0x04011D63 RID: 73059
		private static IntPtr _ScriptStructPtr;
	}
}
