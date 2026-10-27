using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.SeqSubtitle
{
	// Token: 0x02003A26 RID: 14886
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Sequence/SeqSubtitle/SSubtitleSettings.SSubtitleSettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SSubtitleSettings : IEqualityOperators<SSubtitleSettings, SSubtitleSettings, bool>, IEquatable<SSubtitleSettings>, IUnrealScriptStruct
	{
		// Token: 0x0601F506 RID: 128262 RVA: 0x008B4D0C File Offset: 0x008B2F0C
		public SSubtitleSettings(float Duration, float FadeInSpeed, float FadeOutSpeed, FName SubtitleID)
		{
			this.Duration = Duration;
			this.FadeInSpeed = FadeInSpeed;
			this.FadeOutSpeed = FadeOutSpeed;
			this.SubtitleID = SubtitleID;
		}

		// Token: 0x0601F507 RID: 128263 RVA: 0x008B4D2B File Offset: 0x008B2F2B
		public static bool operator ==(SSubtitleSettings left, SSubtitleSettings right)
		{
			return left.Duration == right.Duration && left.FadeInSpeed == right.FadeInSpeed && left.FadeOutSpeed == right.FadeOutSpeed && left.SubtitleID == right.SubtitleID;
		}

		// Token: 0x0601F508 RID: 128264 RVA: 0x008B4D6A File Offset: 0x008B2F6A
		public static bool operator !=(SSubtitleSettings left, SSubtitleSettings right)
		{
			return !(left == right);
		}

		// Token: 0x0601F509 RID: 128265 RVA: 0x008B4D76 File Offset: 0x008B2F76
		public bool Equals(SSubtitleSettings other)
		{
			return this == other;
		}

		// Token: 0x0601F50A RID: 128266 RVA: 0x008B4D84 File Offset: 0x008B2F84
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSubtitleSettings)
			{
				SSubtitleSettings other = (SSubtitleSettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F50B RID: 128267 RVA: 0x008B4DA9 File Offset: 0x008B2FA9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, FName>(this.Duration, this.FadeInSpeed, this.FadeOutSpeed, this.SubtitleID);
		}

		// Token: 0x0601F50C RID: 128268 RVA: 0x008B4DC8 File Offset: 0x008B2FC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSubtitleSettings._ScriptStructPtr != 0) ? SSubtitleSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/SeqSubtitle/SSubtitleSettings.SSubtitleSettings", ref SSubtitleSettings._ScriptStructPtr);
		}

		// Token: 0x0400F05E RID: 61534
		[FieldOffset(0)]
		public float Duration;

		// Token: 0x0400F05F RID: 61535
		[FieldOffset(4)]
		public float FadeInSpeed;

		// Token: 0x0400F060 RID: 61536
		[FieldOffset(8)]
		public float FadeOutSpeed;

		// Token: 0x0400F061 RID: 61537
		[FieldOffset(12)]
		public FName SubtitleID;

		// Token: 0x0400F062 RID: 61538
		public const string __ObjectPath = "/Game/Aki/Sequence/SeqSubtitle/SSubtitleSettings.SSubtitleSettings";

		// Token: 0x0400F063 RID: 61539
		private static IntPtr _ScriptStructPtr;
	}
}
