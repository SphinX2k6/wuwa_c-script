using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C7 RID: 22983
	public readonly struct SolarSchoolBehaviorDoneAttrData : IEquatable<SolarSchoolBehaviorDoneAttrData>
	{
		// Token: 0x06038A51 RID: 232017 RVA: 0x00FD9F3B File Offset: 0x00FD813B
		public SolarSchoolBehaviorDoneAttrData(ESolarSchoolSecondAttr Attr, int OldValue, int NewValue)
		{
			this.Attr = Attr;
			this.OldValue = OldValue;
			this.NewValue = NewValue;
		}

		// Token: 0x17006C44 RID: 27716
		// (get) Token: 0x06038A52 RID: 232018 RVA: 0x00FD9F52 File Offset: 0x00FD8152
		// (set) Token: 0x06038A53 RID: 232019 RVA: 0x00FD9F5A File Offset: 0x00FD815A
		public ESolarSchoolSecondAttr Attr { get; set; }

		// Token: 0x17006C45 RID: 27717
		// (get) Token: 0x06038A54 RID: 232020 RVA: 0x00FD9F63 File Offset: 0x00FD8163
		// (set) Token: 0x06038A55 RID: 232021 RVA: 0x00FD9F6B File Offset: 0x00FD816B
		public int OldValue { get; set; }

		// Token: 0x17006C46 RID: 27718
		// (get) Token: 0x06038A56 RID: 232022 RVA: 0x00FD9F74 File Offset: 0x00FD8174
		// (set) Token: 0x06038A57 RID: 232023 RVA: 0x00FD9F7C File Offset: 0x00FD817C
		public int NewValue { get; set; }

		// Token: 0x06038A58 RID: 232024 RVA: 0x00FD9F88 File Offset: 0x00FD8188
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolBehaviorDoneAttrData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038A59 RID: 232025 RVA: 0x00FD9FD4 File Offset: 0x00FD81D4
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Attr = ");
			builder.Append(this.Attr.ToString());
			builder.Append(", OldValue = ");
			builder.Append(this.OldValue.ToString());
			builder.Append(", NewValue = ");
			builder.Append(this.NewValue.ToString());
			return true;
		}

		// Token: 0x06038A5A RID: 232026 RVA: 0x00FDA057 File Offset: 0x00FD8257
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolBehaviorDoneAttrData left, SolarSchoolBehaviorDoneAttrData right)
		{
			return !(left == right);
		}

		// Token: 0x06038A5B RID: 232027 RVA: 0x00FDA063 File Offset: 0x00FD8263
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolBehaviorDoneAttrData left, SolarSchoolBehaviorDoneAttrData right)
		{
			return left.Equals(right);
		}

		// Token: 0x06038A5C RID: 232028 RVA: 0x00FDA06D File Offset: 0x00FD826D
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<ESolarSchoolSecondAttr>.Default.GetHashCode(this.<Attr>k__BackingField) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<OldValue>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<NewValue>k__BackingField);
		}

		// Token: 0x06038A5D RID: 232029 RVA: 0x00FDA0AD File Offset: 0x00FD82AD
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is SolarSchoolBehaviorDoneAttrData && this.Equals((SolarSchoolBehaviorDoneAttrData)obj);
		}

		// Token: 0x06038A5E RID: 232030 RVA: 0x00FDA0C8 File Offset: 0x00FD82C8
		[CompilerGenerated]
		public bool Equals(SolarSchoolBehaviorDoneAttrData other)
		{
			return EqualityComparer<ESolarSchoolSecondAttr>.Default.Equals(this.<Attr>k__BackingField, other.<Attr>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<OldValue>k__BackingField, other.<OldValue>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<NewValue>k__BackingField, other.<NewValue>k__BackingField);
		}

		// Token: 0x06038A5F RID: 232031 RVA: 0x00FDA11D File Offset: 0x00FD831D
		[CompilerGenerated]
		public void Deconstruct(out ESolarSchoolSecondAttr Attr, out int OldValue, out int NewValue)
		{
			Attr = this.Attr;
			OldValue = this.OldValue;
			NewValue = this.NewValue;
		}
	}
}
