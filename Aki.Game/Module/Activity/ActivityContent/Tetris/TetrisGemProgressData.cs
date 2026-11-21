using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA9 RID: 12201
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGemProgressData : IEquatable<TetrisGemProgressData>
	{
		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0601CEE7 RID: 118503 RVA: 0x008D5B75 File Offset: 0x008D3D75
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisGemProgressData);
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0601CEE8 RID: 118504 RVA: 0x008D5B81 File Offset: 0x008D3D81
		// (set) Token: 0x0601CEE9 RID: 118505 RVA: 0x008D5B89 File Offset: 0x008D3D89
		public int GemId { get; set; }

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0601CEEA RID: 118506 RVA: 0x008D5B92 File Offset: 0x008D3D92
		// (set) Token: 0x0601CEEB RID: 118507 RVA: 0x008D5B9A File Offset: 0x008D3D9A
		public int CurrentGemCount { get; set; }

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0601CEEC RID: 118508 RVA: 0x008D5BA3 File Offset: 0x008D3DA3
		// (set) Token: 0x0601CEED RID: 118509 RVA: 0x008D5BAB File Offset: 0x008D3DAB
		public int TargetGemCount { get; set; }

		// Token: 0x0601CEEE RID: 118510 RVA: 0x008D5BB4 File Offset: 0x008D3DB4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisGemProgressData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CEEF RID: 118511 RVA: 0x008D5C00 File Offset: 0x008D3E00
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("GemId = ");
			builder.Append(this.GemId.ToString());
			builder.Append(", CurrentGemCount = ");
			builder.Append(this.CurrentGemCount.ToString());
			builder.Append(", TargetGemCount = ");
			builder.Append(this.TargetGemCount.ToString());
			return true;
		}

		// Token: 0x0601CEF0 RID: 118512 RVA: 0x008D5C88 File Offset: 0x008D3E88
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisGemProgressData left, TetrisGemProgressData right)
		{
			return !(left == right);
		}

		// Token: 0x0601CEF1 RID: 118513 RVA: 0x008D5C94 File Offset: 0x008D3E94
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisGemProgressData left, TetrisGemProgressData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CEF2 RID: 118514 RVA: 0x008D5CA8 File Offset: 0x008D3EA8
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<GemId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<CurrentGemCount>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<TargetGemCount>k__BackingField);
		}

		// Token: 0x0601CEF3 RID: 118515 RVA: 0x008D5D0A File Offset: 0x008D3F0A
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisGemProgressData);
		}

		// Token: 0x0601CEF4 RID: 118516 RVA: 0x008D5D18 File Offset: 0x008D3F18
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisGemProgressData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<GemId>k__BackingField, other.<GemId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<CurrentGemCount>k__BackingField, other.<CurrentGemCount>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<TargetGemCount>k__BackingField, other.<TargetGemCount>k__BackingField));
		}

		// Token: 0x0601CEF6 RID: 118518 RVA: 0x008D5D91 File Offset: 0x008D3F91
		[CompilerGenerated]
		protected TetrisGemProgressData(TetrisGemProgressData original)
		{
			this.GemId = original.<GemId>k__BackingField;
			this.CurrentGemCount = original.<CurrentGemCount>k__BackingField;
			this.TargetGemCount = original.<TargetGemCount>k__BackingField;
		}

		// Token: 0x0601CEF7 RID: 118519 RVA: 0x008D5DBD File Offset: 0x008D3FBD
		public TetrisGemProgressData()
		{
		}
	}
}
