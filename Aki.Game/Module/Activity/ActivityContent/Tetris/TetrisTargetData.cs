using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FA8 RID: 12200
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrisTargetData : IEquatable<TetrisTargetData>
	{
		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0601CED6 RID: 118486 RVA: 0x008D5941 File Offset: 0x008D3B41
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisTargetData);
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0601CED7 RID: 118487 RVA: 0x008D594D File Offset: 0x008D3B4D
		// (set) Token: 0x0601CED8 RID: 118488 RVA: 0x008D5955 File Offset: 0x008D3B55
		[RequiredMember]
		public string Icon { get; set; }

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0601CED9 RID: 118489 RVA: 0x008D595E File Offset: 0x008D3B5E
		// (set) Token: 0x0601CEDA RID: 118490 RVA: 0x008D5966 File Offset: 0x008D3B66
		public int Num { get; set; }

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0601CEDB RID: 118491 RVA: 0x008D596F File Offset: 0x008D3B6F
		// (set) Token: 0x0601CEDC RID: 118492 RVA: 0x008D5977 File Offset: 0x008D3B77
		[RequiredMember]
		public string Tip { get; set; }

		// Token: 0x0601CEDD RID: 118493 RVA: 0x008D5980 File Offset: 0x008D3B80
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisTargetData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CEDE RID: 118494 RVA: 0x008D59CC File Offset: 0x008D3BCC
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Icon = ");
			builder.Append(this.Icon);
			builder.Append(", Num = ");
			builder.Append(this.Num.ToString());
			builder.Append(", Tip = ");
			builder.Append(this.Tip);
			return true;
		}

		// Token: 0x0601CEDF RID: 118495 RVA: 0x008D5A38 File Offset: 0x008D3C38
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisTargetData left, TetrisTargetData right)
		{
			return !(left == right);
		}

		// Token: 0x0601CEE0 RID: 118496 RVA: 0x008D5A44 File Offset: 0x008D3C44
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisTargetData left, TetrisTargetData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CEE1 RID: 118497 RVA: 0x008D5A58 File Offset: 0x008D3C58
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Icon>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Num>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.<Tip>k__BackingField);
		}

		// Token: 0x0601CEE2 RID: 118498 RVA: 0x008D5ABA File Offset: 0x008D3CBA
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisTargetData);
		}

		// Token: 0x0601CEE3 RID: 118499 RVA: 0x008D5AC8 File Offset: 0x008D3CC8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisTargetData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(this.<Icon>k__BackingField, other.<Icon>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Num>k__BackingField, other.<Num>k__BackingField) && EqualityComparer<string>.Default.Equals(this.<Tip>k__BackingField, other.<Tip>k__BackingField));
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x008D5B41 File Offset: 0x008D3D41
		[CompilerGenerated]
		[SetsRequiredMembers]
		protected TetrisTargetData(TetrisTargetData original)
		{
			this.Icon = original.<Icon>k__BackingField;
			this.Num = original.<Num>k__BackingField;
			this.Tip = original.<Tip>k__BackingField;
		}

		// Token: 0x0601CEE6 RID: 118502 RVA: 0x008D5B6D File Offset: 0x008D3D6D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrisTargetData()
		{
		}
	}
}
