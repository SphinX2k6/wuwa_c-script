using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003350 RID: 13136
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SFrameAbstractData : IEqualityOperators<SFrameAbstractData, SFrameAbstractData, bool>, IEquatable<SFrameAbstractData>, IUnrealScriptStruct
	{
		// Token: 0x060213E8 RID: 136168 RVA: 0x0095C655 File Offset: 0x0095A855
		public SFrameAbstractData(bool EnableFrameAbstract, float EnableFrameAbstractDelta)
		{
			this.EnableFrameAbstract = EnableFrameAbstract;
			this.EnableFrameAbstractDelta = EnableFrameAbstractDelta;
		}

		// Token: 0x060213E9 RID: 136169 RVA: 0x0095C665 File Offset: 0x0095A865
		public static bool operator ==(SFrameAbstractData left, SFrameAbstractData right)
		{
			return left.EnableFrameAbstract == right.EnableFrameAbstract && left.EnableFrameAbstractDelta == right.EnableFrameAbstractDelta;
		}

		// Token: 0x060213EA RID: 136170 RVA: 0x0095C685 File Offset: 0x0095A885
		public static bool operator !=(SFrameAbstractData left, SFrameAbstractData right)
		{
			return !(left == right);
		}

		// Token: 0x060213EB RID: 136171 RVA: 0x0095C691 File Offset: 0x0095A891
		public bool Equals(SFrameAbstractData other)
		{
			return this == other;
		}

		// Token: 0x060213EC RID: 136172 RVA: 0x0095C6A0 File Offset: 0x0095A8A0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFrameAbstractData)
			{
				SFrameAbstractData other = (SFrameAbstractData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060213ED RID: 136173 RVA: 0x0095C6C5 File Offset: 0x0095A8C5
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, float>(this.EnableFrameAbstract, this.EnableFrameAbstractDelta);
		}

		// Token: 0x060213EE RID: 136174 RVA: 0x0095C6D8 File Offset: 0x0095A8D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFrameAbstractData._ScriptStructPtr != 0) ? SFrameAbstractData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData", ref SFrameAbstractData._ScriptStructPtr);
		}

		// Token: 0x040122C7 RID: 74439
		[FieldOffset(0)]
		public bool EnableFrameAbstract;

		// Token: 0x040122C8 RID: 74440
		[FieldOffset(4)]
		public float EnableFrameAbstractDelta;

		// Token: 0x040122C9 RID: 74441
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData";

		// Token: 0x040122CA RID: 74442
		private static IntPtr _ScriptStructPtr;
	}
}
