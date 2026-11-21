using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA7 RID: 12199
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrisSelectGroupData : IEquatable<TetrisSelectGroupData>
	{
		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0601CEC7 RID: 118471 RVA: 0x008D5777 File Offset: 0x008D3977
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisSelectGroupData);
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0601CEC8 RID: 118472 RVA: 0x008D5783 File Offset: 0x008D3983
		// (set) Token: 0x0601CEC9 RID: 118473 RVA: 0x008D578B File Offset: 0x008D398B
		public int GroupId { get; set; }

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0601CECA RID: 118474 RVA: 0x008D5794 File Offset: 0x008D3994
		// (set) Token: 0x0601CECB RID: 118475 RVA: 0x008D579C File Offset: 0x008D399C
		[RequiredMember]
		public List<int> ChallengeIds { get; set; }

		// Token: 0x0601CECC RID: 118476 RVA: 0x008D57A8 File Offset: 0x008D39A8
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisSelectGroupData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CECD RID: 118477 RVA: 0x008D57F4 File Offset: 0x008D39F4
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("GroupId = ");
			builder.Append(this.GroupId.ToString());
			builder.Append(", ChallengeIds = ");
			builder.Append(this.ChallengeIds);
			return true;
		}

		// Token: 0x0601CECE RID: 118478 RVA: 0x008D5847 File Offset: 0x008D3A47
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisSelectGroupData left, TetrisSelectGroupData right)
		{
			return !(left == right);
		}

		// Token: 0x0601CECF RID: 118479 RVA: 0x008D5853 File Offset: 0x008D3A53
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisSelectGroupData left, TetrisSelectGroupData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CED0 RID: 118480 RVA: 0x008D5867 File Offset: 0x008D3A67
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GroupId>k__BackingField)) * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(this.<ChallengeIds>k__BackingField);
		}

		// Token: 0x0601CED1 RID: 118481 RVA: 0x008D58A7 File Offset: 0x008D3AA7
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisSelectGroupData);
		}

		// Token: 0x0601CED2 RID: 118482 RVA: 0x008D58B8 File Offset: 0x008D3AB8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisSelectGroupData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<GroupId>k__BackingField, other.<GroupId>k__BackingField) && EqualityComparer<List<int>>.Default.Equals(this.<ChallengeIds>k__BackingField, other.<ChallengeIds>k__BackingField));
		}

		// Token: 0x0601CED4 RID: 118484 RVA: 0x008D5919 File Offset: 0x008D3B19
		[CompilerGenerated]
		[SetsRequiredMembers]
		protected TetrisSelectGroupData(TetrisSelectGroupData original)
		{
			this.GroupId = original.<GroupId>k__BackingField;
			this.ChallengeIds = original.<ChallengeIds>k__BackingField;
		}

		// Token: 0x0601CED5 RID: 118485 RVA: 0x008D5939 File Offset: 0x008D3B39
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrisSelectGroupData()
		{
		}
	}
}
