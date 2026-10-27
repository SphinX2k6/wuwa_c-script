using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager.Structures
{
	// Token: 0x02003A35 RID: 14901
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/Structures/SSeqJumpWithOption.SSeqJumpWithOption")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SSeqJumpWithOption : IEqualityOperators<SSeqJumpWithOption, SSeqJumpWithOption, bool>, IEquatable<SSeqJumpWithOption>, IUnrealScriptStruct
	{
		// Token: 0x0601F62C RID: 128556 RVA: 0x008B7004 File Offset: 0x008B5204
		public SSeqJumpWithOption(int OptionIndex, FName SeqNodeID)
		{
			this.OptionIndex = OptionIndex;
			this.SeqNodeID = SeqNodeID;
		}

		// Token: 0x0601F62D RID: 128557 RVA: 0x008B7014 File Offset: 0x008B5214
		public static bool operator ==(SSeqJumpWithOption left, SSeqJumpWithOption right)
		{
			return left.OptionIndex == right.OptionIndex && left.SeqNodeID == right.SeqNodeID;
		}

		// Token: 0x0601F62E RID: 128558 RVA: 0x008B7037 File Offset: 0x008B5237
		public static bool operator !=(SSeqJumpWithOption left, SSeqJumpWithOption right)
		{
			return !(left == right);
		}

		// Token: 0x0601F62F RID: 128559 RVA: 0x008B7043 File Offset: 0x008B5243
		public bool Equals(SSeqJumpWithOption other)
		{
			return this == other;
		}

		// Token: 0x0601F630 RID: 128560 RVA: 0x008B7054 File Offset: 0x008B5254
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSeqJumpWithOption)
			{
				SSeqJumpWithOption other = (SSeqJumpWithOption)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F631 RID: 128561 RVA: 0x008B7079 File Offset: 0x008B5279
		public override int GetHashCode()
		{
			return HashCode.Combine<int, FName>(this.OptionIndex, this.SeqNodeID);
		}

		// Token: 0x0601F632 RID: 128562 RVA: 0x008B708C File Offset: 0x008B528C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSeqJumpWithOption._ScriptStructPtr != 0) ? SSeqJumpWithOption._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/Structures/SSeqJumpWithOption.SSeqJumpWithOption", ref SSeqJumpWithOption._ScriptStructPtr);
		}

		// Token: 0x0400F11F RID: 61727
		[FieldOffset(0)]
		public int OptionIndex;

		// Token: 0x0400F120 RID: 61728
		[FieldOffset(4)]
		public FName SeqNodeID;

		// Token: 0x0400F121 RID: 61729
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/Structures/SSeqJumpWithOption.SSeqJumpWithOption";

		// Token: 0x0400F122 RID: 61730
		private static IntPtr _ScriptStructPtr;
	}
}
