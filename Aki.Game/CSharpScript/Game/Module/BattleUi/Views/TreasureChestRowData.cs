using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D91 RID: 19857
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureChestRowData : IEquatable<TreasureChestRowData>
	{
		// Token: 0x06031DF0 RID: 204272 RVA: 0x00DF2640 File Offset: 0x00DF0840
		public TreasureChestRowData(TreasureChestCountData Count, bool IsLast, bool Gained)
		{
			this.Count = Count;
			this.IsLast = IsLast;
			this.Gained = Gained;
			base..ctor();
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x06031DF1 RID: 204273 RVA: 0x00DF265D File Offset: 0x00DF085D
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TreasureChestRowData);
			}
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x06031DF2 RID: 204274 RVA: 0x00DF2669 File Offset: 0x00DF0869
		// (set) Token: 0x06031DF3 RID: 204275 RVA: 0x00DF2671 File Offset: 0x00DF0871
		public TreasureChestCountData Count { get; set; }

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x06031DF4 RID: 204276 RVA: 0x00DF267A File Offset: 0x00DF087A
		// (set) Token: 0x06031DF5 RID: 204277 RVA: 0x00DF2682 File Offset: 0x00DF0882
		public bool IsLast { get; set; }

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x06031DF6 RID: 204278 RVA: 0x00DF268B File Offset: 0x00DF088B
		// (set) Token: 0x06031DF7 RID: 204279 RVA: 0x00DF2693 File Offset: 0x00DF0893
		public bool Gained { get; set; }

		// Token: 0x06031DF8 RID: 204280 RVA: 0x00DF269C File Offset: 0x00DF089C
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

		// Token: 0x06031DF9 RID: 204281 RVA: 0x00DF26E8 File Offset: 0x00DF08E8
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

		// Token: 0x06031DFA RID: 204282 RVA: 0x00DF2762 File Offset: 0x00DF0962
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TreasureChestRowData left, TreasureChestRowData right)
		{
			return !(left == right);
		}

		// Token: 0x06031DFB RID: 204283 RVA: 0x00DF276E File Offset: 0x00DF096E
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TreasureChestRowData left, TreasureChestRowData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06031DFC RID: 204284 RVA: 0x00DF2784 File Offset: 0x00DF0984
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<TreasureChestCountData>.Default.GetHashCode(this.<Count>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsLast>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<Gained>k__BackingField);
		}

		// Token: 0x06031DFD RID: 204285 RVA: 0x00DF27E6 File Offset: 0x00DF09E6
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TreasureChestRowData);
		}

		// Token: 0x06031DFE RID: 204286 RVA: 0x00DF27F4 File Offset: 0x00DF09F4
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TreasureChestRowData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<TreasureChestCountData>.Default.Equals(this.<Count>k__BackingField, other.<Count>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsLast>k__BackingField, other.<IsLast>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<Gained>k__BackingField, other.<Gained>k__BackingField));
		}

		// Token: 0x06031E00 RID: 204288 RVA: 0x00DF286D File Offset: 0x00DF0A6D
		[CompilerGenerated]
		protected TreasureChestRowData(TreasureChestRowData original)
		{
			this.Count = original.<Count>k__BackingField;
			this.IsLast = original.<IsLast>k__BackingField;
			this.Gained = original.<Gained>k__BackingField;
		}

		// Token: 0x06031E01 RID: 204289 RVA: 0x00DF2899 File Offset: 0x00DF0A99
		[CompilerGenerated]
		public void Deconstruct(out TreasureChestCountData Count, out bool IsLast, out bool Gained)
		{
			Count = this.Count;
			IsLast = this.IsLast;
			Gained = this.Gained;
		}
	}
}
