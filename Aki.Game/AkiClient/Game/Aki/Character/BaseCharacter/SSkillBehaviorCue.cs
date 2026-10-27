using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004330 RID: 17200
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 9)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct SSkillBehaviorCue : IEqualityOperators<SSkillBehaviorCue, SSkillBehaviorCue, bool>, IEquatable<SSkillBehaviorCue>, IUnrealScriptStruct
	{
		// Token: 0x0602C941 RID: 182593 RVA: 0x00A231D4 File Offset: 0x00A213D4
		public SSkillBehaviorCue(long CueId, bool Stop)
		{
			this.CueId = CueId;
			this.Stop = Stop;
		}

		// Token: 0x0602C942 RID: 182594 RVA: 0x00A231E4 File Offset: 0x00A213E4
		public static bool operator ==(SSkillBehaviorCue left, SSkillBehaviorCue right)
		{
			return left.CueId == right.CueId && left.Stop == right.Stop;
		}

		// Token: 0x0602C943 RID: 182595 RVA: 0x00A23204 File Offset: 0x00A21404
		public static bool operator !=(SSkillBehaviorCue left, SSkillBehaviorCue right)
		{
			return !(left == right);
		}

		// Token: 0x0602C944 RID: 182596 RVA: 0x00A23210 File Offset: 0x00A21410
		public bool Equals(SSkillBehaviorCue other)
		{
			return this == other;
		}

		// Token: 0x0602C945 RID: 182597 RVA: 0x00A23220 File Offset: 0x00A21420
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

		// Token: 0x0602C946 RID: 182598 RVA: 0x00A23245 File Offset: 0x00A21445
		public override int GetHashCode()
		{
			return HashCode.Combine<long, bool>(this.CueId, this.Stop);
		}

		// Token: 0x0602C947 RID: 182599 RVA: 0x00A23258 File Offset: 0x00A21458
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorCue._ScriptStructPtr != 0) ? SSkillBehaviorCue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue", ref SSkillBehaviorCue._ScriptStructPtr);
		}

		// Token: 0x040177F7 RID: 96247
		[FieldOffset(0)]
		public long CueId;

		// Token: 0x040177F8 RID: 96248
		[FieldOffset(8)]
		public bool Stop;

		// Token: 0x040177F9 RID: 96249
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorCue.SSkillBehaviorCue";

		// Token: 0x040177FA RID: 96250
		private static IntPtr _ScriptStructPtr;
	}
}
