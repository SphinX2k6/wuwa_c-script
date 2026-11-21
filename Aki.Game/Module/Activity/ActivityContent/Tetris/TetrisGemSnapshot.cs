using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB7 RID: 12215
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrisGemSnapshot : IEquatable<TetrisGemSnapshot>
	{
		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0601CFE7 RID: 118759 RVA: 0x008DAF3D File Offset: 0x008D913D
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisGemSnapshot);
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0601CFE8 RID: 118760 RVA: 0x008DAF49 File Offset: 0x008D9149
		// (set) Token: 0x0601CFE9 RID: 118761 RVA: 0x008DAF51 File Offset: 0x008D9151
		[RequiredMember]
		public Dictionary<EGemType, int> CollectedGems { get; set; }

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0601CFEA RID: 118762 RVA: 0x008DAF5A File Offset: 0x008D915A
		// (set) Token: 0x0601CFEB RID: 118763 RVA: 0x008DAF62 File Offset: 0x008D9162
		[RequiredMember]
		public List<EGemType> CurrentGemBag { get; set; }

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0601CFEC RID: 118764 RVA: 0x008DAF6B File Offset: 0x008D916B
		// (set) Token: 0x0601CFED RID: 118765 RVA: 0x008DAF73 File Offset: 0x008D9173
		[RequiredMember]
		public Dictionary<EGemType, int> SpawnCounts { get; set; }

		// Token: 0x0601CFEE RID: 118766 RVA: 0x008DAF7C File Offset: 0x008D917C
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisGemSnapshot");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CFEF RID: 118767 RVA: 0x008DAFC8 File Offset: 0x008D91C8
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("CollectedGems = ");
			builder.Append(this.CollectedGems);
			builder.Append(", CurrentGemBag = ");
			builder.Append(this.CurrentGemBag);
			builder.Append(", SpawnCounts = ");
			builder.Append(this.SpawnCounts);
			return true;
		}

		// Token: 0x0601CFF0 RID: 118768 RVA: 0x008DB026 File Offset: 0x008D9226
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisGemSnapshot left, TetrisGemSnapshot right)
		{
			return !(left == right);
		}

		// Token: 0x0601CFF1 RID: 118769 RVA: 0x008DB032 File Offset: 0x008D9232
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisGemSnapshot left, TetrisGemSnapshot right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CFF2 RID: 118770 RVA: 0x008DB048 File Offset: 0x008D9248
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<Dictionary<EGemType, int>>.Default.GetHashCode(this.<CollectedGems>k__BackingField)) * -1521134295 + EqualityComparer<List<EGemType>>.Default.GetHashCode(this.<CurrentGemBag>k__BackingField)) * -1521134295 + EqualityComparer<Dictionary<EGemType, int>>.Default.GetHashCode(this.<SpawnCounts>k__BackingField);
		}

		// Token: 0x0601CFF3 RID: 118771 RVA: 0x008DB0AA File Offset: 0x008D92AA
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisGemSnapshot);
		}

		// Token: 0x0601CFF4 RID: 118772 RVA: 0x008DB0B8 File Offset: 0x008D92B8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisGemSnapshot other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<Dictionary<EGemType, int>>.Default.Equals(this.<CollectedGems>k__BackingField, other.<CollectedGems>k__BackingField) && EqualityComparer<List<EGemType>>.Default.Equals(this.<CurrentGemBag>k__BackingField, other.<CurrentGemBag>k__BackingField) && EqualityComparer<Dictionary<EGemType, int>>.Default.Equals(this.<SpawnCounts>k__BackingField, other.<SpawnCounts>k__BackingField));
		}

		// Token: 0x0601CFF6 RID: 118774 RVA: 0x008DB131 File Offset: 0x008D9331
		[CompilerGenerated]
		[SetsRequiredMembers]
		protected TetrisGemSnapshot(TetrisGemSnapshot original)
		{
			this.CollectedGems = original.<CollectedGems>k__BackingField;
			this.CurrentGemBag = original.<CurrentGemBag>k__BackingField;
			this.SpawnCounts = original.<SpawnCounts>k__BackingField;
		}

		// Token: 0x0601CFF7 RID: 118775 RVA: 0x008DB15D File Offset: 0x008D935D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrisGemSnapshot()
		{
		}
	}
}
