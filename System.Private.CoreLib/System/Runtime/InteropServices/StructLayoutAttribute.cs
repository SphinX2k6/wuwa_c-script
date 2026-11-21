using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F3 RID: 1523
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public sealed class StructLayoutAttribute : Attribute
	{
		// Token: 0x06007193 RID: 29075 RVA: 0x001106F4 File Offset: 0x0010E8F4
		public StructLayoutAttribute(LayoutKind layoutKind)
		{
			this.Value = layoutKind;
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x001106F4 File Offset: 0x0010E8F4
		public StructLayoutAttribute(short layoutKind)
		{
			this.Value = layoutKind;
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x00110703 File Offset: 0x0010E903
		public LayoutKind Value { get; }

		// Token: 0x040012D2 RID: 4818
		public int Pack;

		// Token: 0x040012D3 RID: 4819
		public int Size;

		// Token: 0x040012D4 RID: 4820
		public CharSet CharSet;
	}
}
