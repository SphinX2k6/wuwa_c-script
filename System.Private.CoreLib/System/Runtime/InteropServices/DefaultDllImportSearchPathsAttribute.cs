using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C7 RID: 1479
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x06007010 RID: 28688 RVA: 0x0010D9A6 File Offset: 0x0010BBA6
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			this.Paths = paths;
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x0010D9B5 File Offset: 0x0010BBB5
		public DllImportSearchPath Paths { get; }
	}
}
