using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAD RID: 23981
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureChestRowData : IEquatable<TreasureChestRowData>
	{
		// Token: 0x0603CE79 RID: 249465 RVA: 0x00EA176C File Offset: 0x00E9F96C
		public TreasureChestRowData(TreasureChestCountData Count, bool IsLast, bool Gained)
		{
			this.Count = Count;
			this.IsLast = IsLast;
			this.Gained = Gained;
			base..ctor();
		}

		// Token: 0x17008E67 RID: 36455
		// (get) Token: 0x0603CE7A RID: 249466 RVA: 0x00EA1789 File Offset: 0x00E9F989
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TreasureChestRowData);
			}
		}

		// Token: 0x17008E68 RID: 36456
		// (get) Token: 0x0603CE7B RID: 249467 RVA: 0x00EA1795 File Offset: 0x00E9F995
		// (set) Token: 0x0603CE7C RID: 249468 RVA: 0x00EA179D File Offset: 0x00E9F99D
		public TreasureChestCountData Count { get; set; }

		// Token: 0x17008E69 RID: 36457
		// (get) Token: 0x0603CE7D RID: 249469 RVA: 0x00EA17A6 File Offset: 0x00E9F9A6
		// (set) Token: 0x0603CE7E RID: 249470 RVA: 0x00EA17AE File Offset: 0x00E9F9AE
		public bool IsLast { get; set; }

		// Token: 0x17008E6A RID: 36458
		// (get) Token: 0x0603CE7F RID: 249471 RVA: 0x00EA17B7 File Offset: 0x00E9F9B7
		// (set) Token: 0x0603CE80 RID: 249472 RVA: 0x00EA17BF File Offset: 0x00E9F9BF
		public bool Gained { get; set; }

		// Token: 0x0603CE81 RID: 249473 RVA: 0x00EA17C8 File Offset: 0x00E9F9C8
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TreasureChestRowData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0603CE82 RID: 249474 RVA: 0x00EA1814 File Offset: 0x00E9FA14
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Count = ");
			builder.Append(this.Count);
			builder.Append(", IsLast = ");
			builder.Append(this.IsLast.ToString());
			builder.Append(", Gained = ");
			builder.Append(this.Gained.ToString());
			return true;
		}

		// Token: 0x0603CE83 RID: 249475 RVA: 0x00EA188E File Offset: 0x00E9FA8E
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TreasureChestRowData left, TreasureChestRowData right)
		{
			return !(left == right);
		}

		// Token: 0x0603CE84 RID: 249476 RVA: 0x00EA189A File Offset: 0x00E9FA9A
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TreasureChestRowData left, TreasureChestRowData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0603CE85 RID: 249477 RVA: 0x00EA18B0 File Offset: 0x00E9FAB0
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<TreasureChestCountData>.Default.GetHashCode(this.<Count>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsLast>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<Gained>k__BackingField);
		}

		// Token: 0x0603CE86 RID: 249478 RVA: 0x00EA1912 File Offset: 0x00E9FB12
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TreasureChestRowData);
		}

		// Token: 0x0603CE87 RID: 249479 RVA: 0x00EA1920 File Offset: 0x00E9FB20
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TreasureChestRowData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<TreasureChestCountData>.Default.Equals(this.<Count>k__BackingField, other.<Count>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsLast>k__BackingField, other.<IsLast>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<Gained>k__BackingField, other.<Gained>k__BackingField));
		}

		// Token: 0x0603CE89 RID: 249481 RVA: 0x00EA1999 File Offset: 0x00E9FB99
		[CompilerGenerated]
		protected TreasureChestRowData(TreasureChestRowData original)
		{
			this.Count = original.<Count>k__BackingField;
			this.IsLast = original.<IsLast>k__BackingField;
			this.Gained = original.<Gained>k__BackingField;
		}

		// Token: 0x0603CE8A RID: 249482 RVA: 0x00EA19C5 File Offset: 0x00E9FBC5
		[CompilerGenerated]
		public void Deconstruct(out TreasureChestCountData Count, out bool IsLast, out bool Gained)
		{
			Count = this.Count;
			IsLast = this.IsLast;
			Gained = this.Gained;
		}
	}
}
