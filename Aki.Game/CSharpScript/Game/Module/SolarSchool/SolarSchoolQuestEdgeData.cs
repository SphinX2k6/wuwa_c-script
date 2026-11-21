using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A48 RID: 23112
	public readonly struct SolarSchoolQuestEdgeData : IEquatable<SolarSchoolQuestEdgeData>
	{
		// Token: 0x06038F6D RID: 233325 RVA: 0x00FF5EB9 File Offset: 0x00FF40B9
		public SolarSchoolQuestEdgeData(int ChildQuestId, ESolarSchoolQuestLineMask Direction)
		{
			this.ChildQuestId = ChildQuestId;
			this.Direction = Direction;
		}

		// Token: 0x17006C86 RID: 27782
		// (get) Token: 0x06038F6E RID: 233326 RVA: 0x00FF5EC9 File Offset: 0x00FF40C9
		// (set) Token: 0x06038F6F RID: 233327 RVA: 0x00FF5ED1 File Offset: 0x00FF40D1
		public int ChildQuestId { get; set; }

		// Token: 0x17006C87 RID: 27783
		// (get) Token: 0x06038F70 RID: 233328 RVA: 0x00FF5EDA File Offset: 0x00FF40DA
		// (set) Token: 0x06038F71 RID: 233329 RVA: 0x00FF5EE2 File Offset: 0x00FF40E2
		public ESolarSchoolQuestLineMask Direction { get; set; }

		// Token: 0x06038F72 RID: 233330 RVA: 0x00FF5EEC File Offset: 0x00FF40EC
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolQuestEdgeData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038F73 RID: 233331 RVA: 0x00FF5F38 File Offset: 0x00FF4138
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("ChildQuestId = ");
			builder.Append(this.ChildQuestId.ToString());
			builder.Append(", Direction = ");
			builder.Append(this.Direction.ToString());
			return true;
		}

		// Token: 0x06038F74 RID: 233332 RVA: 0x00FF5F94 File Offset: 0x00FF4194
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolQuestEdgeData left, SolarSchoolQuestEdgeData right)
		{
			return !(left == right);
		}

		// Token: 0x06038F75 RID: 233333 RVA: 0x00FF5FA0 File Offset: 0x00FF41A0
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolQuestEdgeData left, SolarSchoolQuestEdgeData right)
		{
			return left.Equals(right);
		}

		// Token: 0x06038F76 RID: 233334 RVA: 0x00FF5FAA File Offset: 0x00FF41AA
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<int>.Default.GetHashCode(this.<ChildQuestId>k__BackingField) * -1521134295 + EqualityComparer<ESolarSchoolQuestLineMask>.Default.GetHashCode(this.<Direction>k__BackingField);
		}

		// Token: 0x06038F77 RID: 233335 RVA: 0x00FF5FD3 File Offset: 0x00FF41D3
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is SolarSchoolQuestEdgeData && this.Equals((SolarSchoolQuestEdgeData)obj);
		}

		// Token: 0x06038F78 RID: 233336 RVA: 0x00FF5FEB File Offset: 0x00FF41EB
		[CompilerGenerated]
		public bool Equals(SolarSchoolQuestEdgeData other)
		{
			return EqualityComparer<int>.Default.Equals(this.<ChildQuestId>k__BackingField, other.<ChildQuestId>k__BackingField) && EqualityComparer<ESolarSchoolQuestLineMask>.Default.Equals(this.<Direction>k__BackingField, other.<Direction>k__BackingField);
		}

		// Token: 0x06038F79 RID: 233337 RVA: 0x00FF601D File Offset: 0x00FF421D
		[CompilerGenerated]
		public void Deconstruct(out int ChildQuestId, out ESolarSchoolQuestLineMask Direction)
		{
			ChildQuestId = this.ChildQuestId;
			Direction = this.Direction;
		}
	}
}
