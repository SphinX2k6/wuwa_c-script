using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CB RID: 1483
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x06007018 RID: 28696 RVA: 0x0010DA11 File Offset: 0x0010BC11
		public DllImportAttribute(string dllName)
		{
			this.Value = dllName;
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x0010DA20 File Offset: 0x0010BC20
		public string Value { get; }

		// Token: 0x0400128C RID: 4748
		[Nullable(2)]
		public string EntryPoint;

		// Token: 0x0400128D RID: 4749
		public CharSet CharSet;

		// Token: 0x0400128E RID: 4750
		public bool SetLastError;

		// Token: 0x0400128F RID: 4751
		public bool ExactSpelling;

		// Token: 0x04001290 RID: 4752
		public CallingConvention CallingConvention;

		// Token: 0x04001291 RID: 4753
		public bool BestFitMapping;

		// Token: 0x04001292 RID: 4754
		public bool PreserveSig;

		// Token: 0x04001293 RID: 4755
		public bool ThrowOnUnmappableChar;
	}
}
