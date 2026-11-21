using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FAA RID: 12202
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGemGetData : IEquatable<TetrisGemGetData>
	{
		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0601CEF8 RID: 118520 RVA: 0x008D5DC5 File Offset: 0x008D3FC5
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisGemGetData);
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0601CEF9 RID: 118521 RVA: 0x008D5DD1 File Offset: 0x008D3FD1
		// (set) Token: 0x0601CEFA RID: 118522 RVA: 0x008D5DD9 File Offset: 0x008D3FD9
		public int GemId { get; set; }

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0601CEFB RID: 118523 RVA: 0x008D5DE2 File Offset: 0x008D3FE2
		// (set) Token: 0x0601CEFC RID: 118524 RVA: 0x008D5DEA File Offset: 0x008D3FEA
		public int GetGemCount { get; set; }

		// Token: 0x0601CEFD RID: 118525 RVA: 0x008D5DF4 File Offset: 0x008D3FF4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisGemGetData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CEFE RID: 118526 RVA: 0x008D5E40 File Offset: 0x008D4040
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("GemId = ");
			builder.Append(this.GemId.ToString());
			builder.Append(", GetGemCount = ");
			builder.Append(this.GetGemCount.ToString());
			return true;
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x008D5EA1 File Offset: 0x008D40A1
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisGemGetData left, TetrisGemGetData right)
		{
			return !(left == right);
		}

		// Token: 0x0601CF00 RID: 118528 RVA: 0x008D5EAD File Offset: 0x008D40AD
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisGemGetData left, TetrisGemGetData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CF01 RID: 118529 RVA: 0x008D5EC1 File Offset: 0x008D40C1
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GemId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GetGemCount>k__BackingField);
		}

		// Token: 0x0601CF02 RID: 118530 RVA: 0x008D5F01 File Offset: 0x008D4101
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisGemGetData);
		}

		// Token: 0x0601CF03 RID: 118531 RVA: 0x008D5F10 File Offset: 0x008D4110
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisGemGetData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<GemId>k__BackingField, other.<GemId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<GetGemCount>k__BackingField, other.<GetGemCount>k__BackingField));
		}

		// Token: 0x0601CF05 RID: 118533 RVA: 0x008D5F71 File Offset: 0x008D4171
		[CompilerGenerated]
		protected TetrisGemGetData(TetrisGemGetData original)
		{
			this.GemId = original.<GemId>k__BackingField;
			this.GetGemCount = original.<GetGemCount>k__BackingField;
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x008D5F91 File Offset: 0x008D4191
		public TetrisGemGetData()
		{
		}
	}
}
