using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059EE RID: 23022
	public readonly struct SolarSchoolQuestPresentationState : IEquatable<SolarSchoolQuestPresentationState>
	{
		// Token: 0x06038B41 RID: 232257 RVA: 0x00FDEB5E File Offset: 0x00FDCD5E
		public SolarSchoolQuestPresentationState(int QuestId, bool IsShowing, bool IsExpired, bool InShowTime, bool IsUnlocked, bool FirstShowCompleted, bool FirstUnlockCompleted)
		{
			this.QuestId = QuestId;
			this.IsShowing = IsShowing;
			this.IsExpired = IsExpired;
			this.InShowTime = InShowTime;
			this.IsUnlocked = IsUnlocked;
			this.FirstShowCompleted = FirstShowCompleted;
			this.FirstUnlockCompleted = FirstUnlockCompleted;
		}

		// Token: 0x17006C4D RID: 27725
		// (get) Token: 0x06038B42 RID: 232258 RVA: 0x00FDEB95 File Offset: 0x00FDCD95
		// (set) Token: 0x06038B43 RID: 232259 RVA: 0x00FDEB9D File Offset: 0x00FDCD9D
		public int QuestId { get; set; }

		// Token: 0x17006C4E RID: 27726
		// (get) Token: 0x06038B44 RID: 232260 RVA: 0x00FDEBA6 File Offset: 0x00FDCDA6
		// (set) Token: 0x06038B45 RID: 232261 RVA: 0x00FDEBAE File Offset: 0x00FDCDAE
		public bool IsShowing { get; set; }

		// Token: 0x17006C4F RID: 27727
		// (get) Token: 0x06038B46 RID: 232262 RVA: 0x00FDEBB7 File Offset: 0x00FDCDB7
		// (set) Token: 0x06038B47 RID: 232263 RVA: 0x00FDEBBF File Offset: 0x00FDCDBF
		public bool IsExpired { get; set; }

		// Token: 0x17006C50 RID: 27728
		// (get) Token: 0x06038B48 RID: 232264 RVA: 0x00FDEBC8 File Offset: 0x00FDCDC8
		// (set) Token: 0x06038B49 RID: 232265 RVA: 0x00FDEBD0 File Offset: 0x00FDCDD0
		public bool InShowTime { get; set; }

		// Token: 0x17006C51 RID: 27729
		// (get) Token: 0x06038B4A RID: 232266 RVA: 0x00FDEBD9 File Offset: 0x00FDCDD9
		// (set) Token: 0x06038B4B RID: 232267 RVA: 0x00FDEBE1 File Offset: 0x00FDCDE1
		public bool IsUnlocked { get; set; }

		// Token: 0x17006C52 RID: 27730
		// (get) Token: 0x06038B4C RID: 232268 RVA: 0x00FDEBEA File Offset: 0x00FDCDEA
		// (set) Token: 0x06038B4D RID: 232269 RVA: 0x00FDEBF2 File Offset: 0x00FDCDF2
		public bool FirstShowCompleted { get; set; }

		// Token: 0x17006C53 RID: 27731
		// (get) Token: 0x06038B4E RID: 232270 RVA: 0x00FDEBFB File Offset: 0x00FDCDFB
		// (set) Token: 0x06038B4F RID: 232271 RVA: 0x00FDEC03 File Offset: 0x00FDCE03
		public bool FirstUnlockCompleted { get; set; }

		// Token: 0x06038B50 RID: 232272 RVA: 0x00FDEC0C File Offset: 0x00FDCE0C
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolQuestPresentationState");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038B51 RID: 232273 RVA: 0x00FDEC58 File Offset: 0x00FDCE58
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("QuestId = ");
			builder.Append(this.QuestId.ToString());
			builder.Append(", IsShowing = ");
			builder.Append(this.IsShowing.ToString());
			builder.Append(", IsExpired = ");
			builder.Append(this.IsExpired.ToString());
			builder.Append(", InShowTime = ");
			builder.Append(this.InShowTime.ToString());
			builder.Append(", IsUnlocked = ");
			builder.Append(this.IsUnlocked.ToString());
			builder.Append(", FirstShowCompleted = ");
			builder.Append(this.FirstShowCompleted.ToString());
			builder.Append(", FirstUnlockCompleted = ");
			builder.Append(this.FirstUnlockCompleted.ToString());
			return true;
		}

		// Token: 0x06038B52 RID: 232274 RVA: 0x00FDED77 File Offset: 0x00FDCF77
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolQuestPresentationState left, SolarSchoolQuestPresentationState right)
		{
			return !(left == right);
		}

		// Token: 0x06038B53 RID: 232275 RVA: 0x00FDED83 File Offset: 0x00FDCF83
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolQuestPresentationState left, SolarSchoolQuestPresentationState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06038B54 RID: 232276 RVA: 0x00FDED90 File Offset: 0x00FDCF90
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((EqualityComparer<int>.Default.GetHashCode(this.<QuestId>k__BackingField) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsShowing>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsExpired>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<InShowTime>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsUnlocked>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<FirstShowCompleted>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<FirstUnlockCompleted>k__BackingField);
		}

		// Token: 0x06038B55 RID: 232277 RVA: 0x00FDEE37 File Offset: 0x00FDD037
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is SolarSchoolQuestPresentationState && this.Equals((SolarSchoolQuestPresentationState)obj);
		}

		// Token: 0x06038B56 RID: 232278 RVA: 0x00FDEE50 File Offset: 0x00FDD050
		[CompilerGenerated]
		public bool Equals(SolarSchoolQuestPresentationState other)
		{
			return EqualityComparer<int>.Default.Equals(this.<QuestId>k__BackingField, other.<QuestId>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsShowing>k__BackingField, other.<IsShowing>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsExpired>k__BackingField, other.<IsExpired>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<InShowTime>k__BackingField, other.<InShowTime>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsUnlocked>k__BackingField, other.<IsUnlocked>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<FirstShowCompleted>k__BackingField, other.<FirstShowCompleted>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<FirstUnlockCompleted>k__BackingField, other.<FirstUnlockCompleted>k__BackingField);
		}

		// Token: 0x06038B57 RID: 232279 RVA: 0x00FDEF08 File Offset: 0x00FDD108
		[CompilerGenerated]
		public void Deconstruct(out int QuestId, out bool IsShowing, out bool IsExpired, out bool InShowTime, out bool IsUnlocked, out bool FirstShowCompleted, out bool FirstUnlockCompleted)
		{
			QuestId = this.QuestId;
			IsShowing = this.IsShowing;
			IsExpired = this.IsExpired;
			InShowTime = this.InShowTime;
			IsUnlocked = this.IsUnlocked;
			FirstShowCompleted = this.FirstShowCompleted;
			FirstUnlockCompleted = this.FirstUnlockCompleted;
		}
	}
}
