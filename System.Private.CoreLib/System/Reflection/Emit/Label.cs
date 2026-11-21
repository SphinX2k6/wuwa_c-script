using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007C5 RID: 1989
	public readonly struct Label : IEquatable<Label>
	{
		// Token: 0x06007FDB RID: 32731 RVA: 0x0012DD2A File Offset: 0x0012BF2A
		internal Label(int label)
		{
			this.m_label = label;
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06007FDC RID: 32732 RVA: 0x0012DD33 File Offset: 0x0012BF33
		public int Id
		{
			get
			{
				return this.m_label;
			}
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x0012DD33 File Offset: 0x0012BF33
		public override int GetHashCode()
		{
			return this.m_label;
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x0012DD3C File Offset: 0x0012BF3C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Label)
			{
				Label obj2 = (Label)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x0012DD61 File Offset: 0x0012BF61
		public bool Equals(Label obj)
		{
			return obj.m_label == this.m_label;
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x0012DD71 File Offset: 0x0012BF71
		public static bool operator ==(Label a, Label b)
		{
			return a.Equals(b);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x0012DD7B File Offset: 0x0012BF7B
		public static bool operator !=(Label a, Label b)
		{
			return !(a == b);
		}

		// Token: 0x040018B1 RID: 6321
		internal readonly int m_label;
	}
}
