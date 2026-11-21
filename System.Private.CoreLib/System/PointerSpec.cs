using System;
using System.Text;

namespace System
{
	// Token: 0x020000AA RID: 170
	internal sealed class PointerSpec : IModifierSpec
	{
		// Token: 0x060008BB RID: 2235 RVA: 0x0001C0CA File Offset: 0x0001A2CA
		internal PointerSpec(int pointer_level)
		{
			this.pointer_level = pointer_level;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0001C0DC File Offset: 0x0001A2DC
		public Type Resolve(Type type)
		{
			for (int i = 0; i < this.pointer_level; i++)
			{
				type = type.MakePointerType();
			}
			return type;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0001C103 File Offset: 0x0001A303
		public StringBuilder Append(StringBuilder sb)
		{
			return sb.Append('*', this.pointer_level);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0001C113 File Offset: 0x0001A313
		public override string ToString()
		{
			return this.Append(new StringBuilder()).ToString();
		}

		// Token: 0x040002B5 RID: 693
		private readonly int pointer_level;
	}
}
