using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059EF RID: 23023
	public readonly struct SolarSchoolQuestLinePlan : IEquatable<SolarSchoolQuestLinePlan>
	{
		// Token: 0x06038B58 RID: 232280 RVA: 0x00FDEF46 File Offset: 0x00FDD146
		public SolarSchoolQuestLinePlan(int QuestId, ESolarSchoolQuestLineMask Existing, ESolarSchoolQuestLineMask Appearing)
		{
			this.QuestId = QuestId;
			this.Existing = Existing;
			this.Appearing = Appearing;
		}

		// Token: 0x17006C54 RID: 27732
		// (get) Token: 0x06038B59 RID: 232281 RVA: 0x00FDEF5D File Offset: 0x00FDD15D
		// (set) Token: 0x06038B5A RID: 232282 RVA: 0x00FDEF65 File Offset: 0x00FDD165
		public int QuestId { get; set; }

		// Token: 0x17006C55 RID: 27733
		// (get) Token: 0x06038B5B RID: 232283 RVA: 0x00FDEF6E File Offset: 0x00FDD16E
		// (set) Token: 0x06038B5C RID: 232284 RVA: 0x00FDEF76 File Offset: 0x00FDD176
		public ESolarSchoolQuestLineMask Existing { get; set; }

		// Token: 0x17006C56 RID: 27734
		// (get) Token: 0x06038B5D RID: 232285 RVA: 0x00FDEF7F File Offset: 0x00FDD17F
		// (set) Token: 0x06038B5E RID: 232286 RVA: 0x00FDEF87 File Offset: 0x00FDD187
		public ESolarSchoolQuestLineMask Appearing { get; set; }

		// Token: 0x06038B5F RID: 232287 RVA: 0x00FDEF90 File Offset: 0x00FDD190
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolQuestLinePlan");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038B60 RID: 232288 RVA: 0x00FDEFDC File Offset: 0x00FDD1DC
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("QuestId = ");
			builder.Append(this.QuestId.ToString());
			builder.Append(", Existing = ");
			builder.Append(this.Existing.ToString());
			builder.Append(", Appearing = ");
			builder.Append(this.Appearing.ToString());
			return true;
		}

		// Token: 0x06038B61 RID: 232289 RVA: 0x00FDF05F File Offset: 0x00FDD25F
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolQuestLinePlan left, SolarSchoolQuestLinePlan right)
		{
			return !(left == right);
		}

		// Token: 0x06038B62 RID: 232290 RVA: 0x00FDF06B File Offset: 0x00FDD26B
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolQuestLinePlan left, SolarSchoolQuestLinePlan right)
		{
			return left.Equals(right);
		}

		// Token: 0x06038B63 RID: 232291 RVA: 0x00FDF075 File Offset: 0x00FDD275
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<int>.Default.GetHashCode(this.<QuestId>k__BackingField) * -1521134295 + EqualityComparer<ESolarSchoolQuestLineMask>.Default.GetHashCode(this.<Existing>k__BackingField)) * -1521134295 + EqualityComparer<ESolarSchoolQuestLineMask>.Default.GetHashCode(this.<Appearing>k__BackingField);
		}

		// Token: 0x06038B64 RID: 232292 RVA: 0x00FDF0B5 File Offset: 0x00FDD2B5
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is SolarSchoolQuestLinePlan && this.Equals((SolarSchoolQuestLinePlan)obj);
		}

		// Token: 0x06038B65 RID: 232293 RVA: 0x00FDF0D0 File Offset: 0x00FDD2D0
		[CompilerGenerated]
		public bool Equals(SolarSchoolQuestLinePlan other)
		{
			return EqualityComparer<int>.Default.Equals(this.<QuestId>k__BackingField, other.<QuestId>k__BackingField) && EqualityComparer<ESolarSchoolQuestLineMask>.Default.Equals(this.<Existing>k__BackingField, other.<Existing>k__BackingField) && EqualityComparer<ESolarSchoolQuestLineMask>.Default.Equals(this.<Appearing>k__BackingField, other.<Appearing>k__BackingField);
		}

		// Token: 0x06038B66 RID: 232294 RVA: 0x00FDF125 File Offset: 0x00FDD325
		[CompilerGenerated]
		public void Deconstruct(out int QuestId, out ESolarSchoolQuestLineMask Existing, out ESolarSchoolQuestLineMask Appearing)
		{
			QuestId = this.QuestId;
			Existing = this.Existing;
			Appearing = this.Appearing;
		}
	}
}
