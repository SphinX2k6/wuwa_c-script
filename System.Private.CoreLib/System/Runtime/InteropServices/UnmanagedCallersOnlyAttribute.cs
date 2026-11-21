using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F8 RID: 1528
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class UnmanagedCallersOnlyAttribute : Attribute
	{
		// Token: 0x040012D9 RID: 4825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Type[] CallConvs;

		// Token: 0x040012DA RID: 4826
		[Nullable(2)]
		public string EntryPoint;
	}
}
