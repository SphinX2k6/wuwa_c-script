using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CF RID: 1487
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x06007025 RID: 28709 RVA: 0x0010DBAC File Offset: 0x0010BDAC
		public FieldOffsetAttribute(int offset)
		{
			this.Value = offset;
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06007026 RID: 28710 RVA: 0x0010DBBB File Offset: 0x0010BDBB
		public int Value { get; }
	}
}
