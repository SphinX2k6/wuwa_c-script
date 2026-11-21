using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA6 RID: 12198
	[NullableContext(1)]
	[Nullable(0)]
	public class RoundConfig : IEquatable<RoundConfig>
	{
		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0601CEAE RID: 118446 RVA: 0x008D5341 File Offset: 0x008D3541
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RoundConfig);
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0601CEAF RID: 118447 RVA: 0x008D534D File Offset: 0x008D354D
		// (set) Token: 0x0601CEB0 RID: 118448 RVA: 0x008D5355 File Offset: 0x008D3555
		public int Id { get; set; }

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0601CEB1 RID: 118449 RVA: 0x008D535E File Offset: 0x008D355E
		// (set) Token: 0x0601CEB2 RID: 118450 RVA: 0x008D5366 File Offset: 0x008D3566
		public int LevelId { get; set; }

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0601CEB3 RID: 118451 RVA: 0x008D536F File Offset: 0x008D356F
		// (set) Token: 0x0601CEB4 RID: 118452 RVA: 0x008D5377 File Offset: 0x008D3577
		public int Round { get; set; }

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0601CEB5 RID: 118453 RVA: 0x008D5380 File Offset: 0x008D3580
		// (set) Token: 0x0601CEB6 RID: 118454 RVA: 0x008D5388 File Offset: 0x008D3588
		public int ShapeId { get; set; }

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0601CEB7 RID: 118455 RVA: 0x008D5391 File Offset: 0x008D3591
		// (set) Token: 0x0601CEB8 RID: 118456 RVA: 0x008D5399 File Offset: 0x008D3599
		public int Color { get; set; }

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0601CEB9 RID: 118457 RVA: 0x008D53A2 File Offset: 0x008D35A2
		// (set) Token: 0x0601CEBA RID: 118458 RVA: 0x008D53AA File Offset: 0x008D35AA
		public int Gem { get; set; }

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0601CEBB RID: 118459 RVA: 0x008D53B3 File Offset: 0x008D35B3
		// (set) Token: 0x0601CEBC RID: 118460 RVA: 0x008D53BB File Offset: 0x008D35BB
		public int GemFill { get; set; }

		// Token: 0x0601CEBD RID: 118461 RVA: 0x008D53C4 File Offset: 0x008D35C4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RoundConfig");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CEBE RID: 118462 RVA: 0x008D5410 File Offset: 0x008D3610
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Id = ");
			builder.Append(this.Id.ToString());
			builder.Append(", LevelId = ");
			builder.Append(this.LevelId.ToString());
			builder.Append(", Round = ");
			builder.Append(this.Round.ToString());
			builder.Append(", ShapeId = ");
			builder.Append(this.ShapeId.ToString());
			builder.Append(", Color = ");
			builder.Append(this.Color.ToString());
			builder.Append(", Gem = ");
			builder.Append(this.Gem.ToString());
			builder.Append(", GemFill = ");
			builder.Append(this.GemFill.ToString());
			return true;
		}

		// Token: 0x0601CEBF RID: 118463 RVA: 0x008D5534 File Offset: 0x008D3734
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(RoundConfig left, RoundConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601CEC0 RID: 118464 RVA: 0x008D5540 File Offset: 0x008D3740
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(RoundConfig left, RoundConfig right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CEC1 RID: 118465 RVA: 0x008D5554 File Offset: 0x008D3754
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Id>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<LevelId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Round>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<ShapeId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Color>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Gem>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GemFill>k__BackingField);
		}

		// Token: 0x0601CEC2 RID: 118466 RVA: 0x008D5612 File Offset: 0x008D3812
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as RoundConfig);
		}

		// Token: 0x0601CEC3 RID: 118467 RVA: 0x008D5620 File Offset: 0x008D3820
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(RoundConfig other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<Id>k__BackingField, other.<Id>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<LevelId>k__BackingField, other.<LevelId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Round>k__BackingField, other.<Round>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<ShapeId>k__BackingField, other.<ShapeId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Color>k__BackingField, other.<Color>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Gem>k__BackingField, other.<Gem>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<GemFill>k__BackingField, other.<GemFill>k__BackingField));
		}

		// Token: 0x0601CEC5 RID: 118469 RVA: 0x008D5708 File Offset: 0x008D3908
		[CompilerGenerated]
		protected RoundConfig(RoundConfig original)
		{
			this.Id = original.<Id>k__BackingField;
			this.LevelId = original.<LevelId>k__BackingField;
			this.Round = original.<Round>k__BackingField;
			this.ShapeId = original.<ShapeId>k__BackingField;
			this.Color = original.<Color>k__BackingField;
			this.Gem = original.<Gem>k__BackingField;
			this.GemFill = original.<GemFill>k__BackingField;
		}

		// Token: 0x0601CEC6 RID: 118470 RVA: 0x008D576F File Offset: 0x008D396F
		public RoundConfig()
		{
		}
	}
}
