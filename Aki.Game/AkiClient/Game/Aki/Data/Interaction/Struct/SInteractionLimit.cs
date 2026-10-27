using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Interaction.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x02003F1B RID: 16155
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionLimit.SInteractionLimit")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SInteractionLimit : IEqualityOperators<SInteractionLimit, SInteractionLimit, bool>, IEquatable<SInteractionLimit>, IUnrealScriptStruct
	{
		// Token: 0x06029061 RID: 168033 RVA: 0x009B9E34 File Offset: 0x009B8034
		public SInteractionLimit(TEnumAsByte<EInteractOptionLimit> LimitType, int Times, float Duration)
		{
			this.LimitType = LimitType;
			this.Times = Times;
			this.Duration = Duration;
		}

		// Token: 0x06029062 RID: 168034 RVA: 0x009B9E4B File Offset: 0x009B804B
		public static bool operator ==(SInteractionLimit left, SInteractionLimit right)
		{
			return left.LimitType == right.LimitType && left.Times == right.Times && left.Duration == right.Duration;
		}

		// Token: 0x06029063 RID: 168035 RVA: 0x009B9E7E File Offset: 0x009B807E
		public static bool operator !=(SInteractionLimit left, SInteractionLimit right)
		{
			return !(left == right);
		}

		// Token: 0x06029064 RID: 168036 RVA: 0x009B9E8A File Offset: 0x009B808A
		public bool Equals(SInteractionLimit other)
		{
			return this == other;
		}

		// Token: 0x06029065 RID: 168037 RVA: 0x009B9E98 File Offset: 0x009B8098
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SInteractionLimit)
			{
				SInteractionLimit other = (SInteractionLimit)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029066 RID: 168038 RVA: 0x009B9EBD File Offset: 0x009B80BD
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EInteractOptionLimit>, int, float>(this.LimitType, this.Times, this.Duration);
		}

		// Token: 0x06029067 RID: 168039 RVA: 0x009B9ED6 File Offset: 0x009B80D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionLimit._ScriptStructPtr != 0) ? SInteractionLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionLimit.SInteractionLimit", ref SInteractionLimit._ScriptStructPtr);
		}

		// Token: 0x04014FE0 RID: 85984
		[FieldOffset(0)]
		public TEnumAsByte<EInteractOptionLimit> LimitType;

		// Token: 0x04014FE1 RID: 85985
		[FieldOffset(4)]
		public int Times;

		// Token: 0x04014FE2 RID: 85986
		[FieldOffset(8)]
		public float Duration;

		// Token: 0x04014FE3 RID: 85987
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionLimit.SInteractionLimit";

		// Token: 0x04014FE4 RID: 85988
		private static IntPtr _ScriptStructPtr;
	}
}
