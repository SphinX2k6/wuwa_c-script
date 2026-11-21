using System;
using System.Text;

namespace System
{
	// Token: 0x020000A9 RID: 169
	internal sealed class IArraySpec : IModifierSpec
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x0001C030 File Offset: 0x0001A230
		internal IArraySpec(int dimensions, bool bound)
		{
			this.dimensions = dimensions;
			this.bound = bound;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0001C046 File Offset: 0x0001A246
		public Type Resolve(Type type)
		{
			if (this.bound)
			{
				return type.MakeArrayType(1);
			}
			if (this.dimensions == 1)
			{
				return type.MakeArrayType();
			}
			return type.MakeArrayType(this.dimensions);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001C074 File Offset: 0x0001A274
		public StringBuilder Append(StringBuilder sb)
		{
			if (this.bound)
			{
				return sb.Append("[*]");
			}
			return sb.Append('[').Append(',', this.dimensions - 1).Append(']');
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0001C0A8 File Offset: 0x0001A2A8
		public override string ToString()
		{
			return this.Append(new StringBuilder()).ToString();
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0001C0BA File Offset: 0x0001A2BA
		public int Rank
		{
			get
			{
				return this.dimensions;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0001C0C2 File Offset: 0x0001A2C2
		public bool IsBound
		{
			get
			{
				return this.bound;
			}
		}

		// Token: 0x040002B3 RID: 691
		private readonly int dimensions;

		// Token: 0x040002B4 RID: 692
		private readonly bool bound;
	}
}
