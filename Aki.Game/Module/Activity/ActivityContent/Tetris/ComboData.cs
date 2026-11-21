using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FAB RID: 12203
	[NullableContext(1)]
	[Nullable(0)]
	public class ComboData : IEquatable<ComboData>
	{
		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0601CF07 RID: 118535 RVA: 0x008D5F99 File Offset: 0x008D4199
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ComboData);
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0601CF08 RID: 118536 RVA: 0x008D5FA5 File Offset: 0x008D41A5
		// (set) Token: 0x0601CF09 RID: 118537 RVA: 0x008D5FAD File Offset: 0x008D41AD
		public TetrisClearInfo ClearInfo { get; set; }

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0601CF0A RID: 118538 RVA: 0x008D5FB6 File Offset: 0x008D41B6
		// (set) Token: 0x0601CF0B RID: 118539 RVA: 0x008D5FBE File Offset: 0x008D41BE
		public int ComboCount { get; set; }

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0601CF0C RID: 118540 RVA: 0x008D5FC7 File Offset: 0x008D41C7
		// (set) Token: 0x0601CF0D RID: 118541 RVA: 0x008D5FCF File Offset: 0x008D41CF
		public int Score { get; set; }

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0601CF0E RID: 118542 RVA: 0x008D5FD8 File Offset: 0x008D41D8
		// (set) Token: 0x0601CF0F RID: 118543 RVA: 0x008D5FE0 File Offset: 0x008D41E0
		public EGameMode GameMode { get; set; }

		// Token: 0x0601CF10 RID: 118544 RVA: 0x008D5FEC File Offset: 0x008D41EC
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ComboData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CF11 RID: 118545 RVA: 0x008D6038 File Offset: 0x008D4238
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ClearInfo = ");
			builder.Append(this.ClearInfo.ToString());
			builder.Append(", ComboCount = ");
			builder.Append(this.ComboCount.ToString());
			builder.Append(", Score = ");
			builder.Append(this.Score.ToString());
			builder.Append(", GameMode = ");
			builder.Append(this.GameMode.ToString());
			return true;
		}

		// Token: 0x0601CF12 RID: 118546 RVA: 0x008D60E7 File Offset: 0x008D42E7
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(ComboData left, ComboData right)
		{
			return !(left == right);
		}

		// Token: 0x0601CF13 RID: 118547 RVA: 0x008D60F3 File Offset: 0x008D42F3
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(ComboData left, ComboData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CF14 RID: 118548 RVA: 0x008D6108 File Offset: 0x008D4308
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<TetrisClearInfo>.Default.GetHashCode(this.<ClearInfo>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<ComboCount>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Score>k__BackingField)) * -1521134295 + EqualityComparer<EGameMode>.Default.GetHashCode(this.<GameMode>k__BackingField);
		}

		// Token: 0x0601CF15 RID: 118549 RVA: 0x008D6181 File Offset: 0x008D4381
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ComboData);
		}

		// Token: 0x0601CF16 RID: 118550 RVA: 0x008D6190 File Offset: 0x008D4390
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(ComboData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<TetrisClearInfo>.Default.Equals(this.<ClearInfo>k__BackingField, other.<ClearInfo>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<ComboCount>k__BackingField, other.<ComboCount>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Score>k__BackingField, other.<Score>k__BackingField) && EqualityComparer<EGameMode>.Default.Equals(this.<GameMode>k__BackingField, other.<GameMode>k__BackingField));
		}

		// Token: 0x0601CF18 RID: 118552 RVA: 0x008D6221 File Offset: 0x008D4421
		[CompilerGenerated]
		protected ComboData(ComboData original)
		{
			this.ClearInfo = original.<ClearInfo>k__BackingField;
			this.ComboCount = original.<ComboCount>k__BackingField;
			this.Score = original.<Score>k__BackingField;
			this.GameMode = original.<GameMode>k__BackingField;
		}

		// Token: 0x0601CF19 RID: 118553 RVA: 0x008D6259 File Offset: 0x008D4459
		public ComboData()
		{
		}
	}
}
