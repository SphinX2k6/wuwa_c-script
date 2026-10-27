using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004317 RID: 17175
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SFrameAbstractData : IEqualityOperators<SFrameAbstractData, SFrameAbstractData, bool>, IEquatable<SFrameAbstractData>, IUnrealScriptStruct
	{
		// Token: 0x0602C6FD RID: 182013 RVA: 0x00A1FBCA File Offset: 0x00A1DDCA
		public SFrameAbstractData(bool EnableFrameAbstract, float EnableFrameAbstractDelta)
		{
			this.EnableFrameAbstract = EnableFrameAbstract;
			this.EnableFrameAbstractDelta = EnableFrameAbstractDelta;
		}

		// Token: 0x0602C6FE RID: 182014 RVA: 0x00A1FBDA File Offset: 0x00A1DDDA
		public static bool operator ==(SFrameAbstractData left, SFrameAbstractData right)
		{
			return left.EnableFrameAbstract == right.EnableFrameAbstract && left.EnableFrameAbstractDelta == right.EnableFrameAbstractDelta;
		}

		// Token: 0x0602C6FF RID: 182015 RVA: 0x00A1FBFA File Offset: 0x00A1DDFA
		public static bool operator !=(SFrameAbstractData left, SFrameAbstractData right)
		{
			return !(left == right);
		}

		// Token: 0x0602C700 RID: 182016 RVA: 0x00A1FC06 File Offset: 0x00A1DE06
		public bool Equals(SFrameAbstractData other)
		{
			return this == other;
		}

		// Token: 0x0602C701 RID: 182017 RVA: 0x00A1FC14 File Offset: 0x00A1DE14
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

		// Token: 0x0602C702 RID: 182018 RVA: 0x00A1FC39 File Offset: 0x00A1DE39
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, float>(this.EnableFrameAbstract, this.EnableFrameAbstractDelta);
		}

		// Token: 0x0602C703 RID: 182019 RVA: 0x00A1FC4C File Offset: 0x00A1DE4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFrameAbstractData._ScriptStructPtr != 0) ? SFrameAbstractData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData", ref SFrameAbstractData._ScriptStructPtr);
		}

		// Token: 0x040176D5 RID: 95957
		[FieldOffset(0)]
		public bool EnableFrameAbstract;

		// Token: 0x040176D6 RID: 95958
		[FieldOffset(4)]
		public float EnableFrameAbstractDelta;

		// Token: 0x040176D7 RID: 95959
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFrameAbstractData.SFrameAbstractData";

		// Token: 0x040176D8 RID: 95960
		private static IntPtr _ScriptStructPtr;
	}
}
