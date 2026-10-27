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
	// Token: 0x02004250 RID: 16976
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SAiAttributeRate : IEqualityOperators<SAiAttributeRate, SAiAttributeRate, bool>, IEquatable<SAiAttributeRate>, IUnrealScriptStruct
	{
		// Token: 0x0602BFA2 RID: 180130 RVA: 0x00A10CF2 File Offset: 0x00A0EEF2
		public SAiAttributeRate(TEnumAsByte<EAttributeType> Numerator, TEnumAsByte<EAttributeType> Denominator, FFloatRange Range)
		{
			this.Numerator = Numerator;
			this.Denominator = Denominator;
			this.Range = Range;
		}

		// Token: 0x0602BFA3 RID: 180131 RVA: 0x00A10D09 File Offset: 0x00A0EF09
		public static bool operator ==(SAiAttributeRate left, SAiAttributeRate right)
		{
			return left.Numerator == right.Numerator && left.Denominator == right.Denominator && left.Range == right.Range;
		}

		// Token: 0x0602BFA4 RID: 180132 RVA: 0x00A10D44 File Offset: 0x00A0EF44
		public static bool operator !=(SAiAttributeRate left, SAiAttributeRate right)
		{
			return !(left == right);
		}

		// Token: 0x0602BFA5 RID: 180133 RVA: 0x00A10D50 File Offset: 0x00A0EF50
		public bool Equals(SAiAttributeRate other)
		{
			return this == other;
		}

		// Token: 0x0602BFA6 RID: 180134 RVA: 0x00A10D60 File Offset: 0x00A0EF60
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

		// Token: 0x0602BFA7 RID: 180135 RVA: 0x00A10D85 File Offset: 0x00A0EF85
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EAttributeType>, TEnumAsByte<EAttributeType>, FFloatRange>(this.Numerator, this.Denominator, this.Range);
		}

		// Token: 0x0602BFA8 RID: 180136 RVA: 0x00A10D9E File Offset: 0x00A0EF9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiAttributeRate._ScriptStructPtr != 0) ? SAiAttributeRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate", ref SAiAttributeRate._ScriptStructPtr);
		}

		// Token: 0x04016F81 RID: 94081
		[FieldOffset(0)]
		public TEnumAsByte<EAttributeType> Numerator;

		// Token: 0x04016F82 RID: 94082
		[FieldOffset(1)]
		public TEnumAsByte<EAttributeType> Denominator;

		// Token: 0x04016F83 RID: 94083
		[FieldOffset(4)]
		public FFloatRange Range;

		// Token: 0x04016F84 RID: 94084
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiAttributeRate.SAiAttributeRate";

		// Token: 0x04016F85 RID: 94085
		private static IntPtr _ScriptStructPtr;
	}
}
