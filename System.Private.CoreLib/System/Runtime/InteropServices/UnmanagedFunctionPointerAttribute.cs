using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F9 RID: 1529
	[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		// Token: 0x0600719F RID: 29087 RVA: 0x00110748 File Offset: 0x0010E948
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
			this.CallingConvention = callingConvention;
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x00110757 File Offset: 0x0010E957
		public CallingConvention CallingConvention { get; }

		// Token: 0x040012DC RID: 4828
		public bool BestFitMapping;

		// Token: 0x040012DD RID: 4829
		public bool SetLastError;

		// Token: 0x040012DE RID: 4830
		public bool ThrowOnUnmappableChar;

		// Token: 0x040012DF RID: 4831
		public CharSet CharSet;
	}
}
