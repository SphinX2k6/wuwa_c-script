using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F7 RID: 1527
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class UnmanagedCallConvAttribute : Attribute
	{
		// Token: 0x040012D8 RID: 4824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Type[] CallConvs;
	}
}
