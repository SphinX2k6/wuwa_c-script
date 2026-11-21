using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003368 RID: 13160
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 9)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SSkillBehaviorCue : IEqualityOperators<SSkillBehaviorCue, SSkillBehaviorCue, bool>, IEquatable<SSkillBehaviorCue>, IUnrealScriptStruct
	{
		// Token: 0x0602163C RID: 136764 RVA: 0x0095F7DA File Offset: 0x0095D9DA
		public SSkillBehaviorCue(long CueId, bool Stop)
		{
			this.CueId = CueId;
			this.Stop = Stop;
		}

		// Token: 0x0602163D RID: 136765 RVA: 0x0095F7EA File Offset: 0x0095D9EA
		public static bool operator ==(SSkillBehaviorCue left, SSkillBehaviorCue right)
		{
			return left.CueId == right.CueId && left.Stop == right.Stop;
		}

		// Token: 0x0602163E RID: 136766 RVA: 0x0095F80A File Offset: 0x0095DA0A
		public static bool operator !=(SSkillBehaviorCue left, SSkillBehaviorCue right)
		{
			return !(left == right);
		}

		// Token: 0x0602163F RID: 136767 RVA: 0x0095F816 File Offset: 0x0095DA16
		public bool Equals(SSkillBehaviorCue other)
		{
			return this == other;
		}

		// Token: 0x06021640 RID: 136768 RVA: 0x0095F824 File Offset: 0x0095DA24
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSkillBehaviorCue)
			{
				SSkillBehaviorCue other = (SSkillBehaviorCue)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06021641 RID: 136769 RVA: 0x0095F849 File Offset: 0x0095DA49
		public override int GetHashCode()
		{
			return HashCode.Combine<long, bool>(this.CueId, this.Stop);
		}

		// Token: 0x06021642 RID: 136770 RVA: 0x0095F85C File Offset: 0x0095DA5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorCue._ScriptStructPtr != 0) ? SSkillBehaviorCue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue", ref SSkillBehaviorCue._ScriptStructPtr);
		}

		// Token: 0x040123F8 RID: 74744
		[FieldOffset(0)]
		public long CueId;

		// Token: 0x040123F9 RID: 74745
		[FieldOffset(8)]
		public bool Stop;

		// Token: 0x040123FA RID: 74746
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue";

		// Token: 0x040123FB RID: 74747
		private static IntPtr _ScriptStructPtr;
	}
}
