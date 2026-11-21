using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E1 RID: 1505
	// (Invoke) Token: 0x06007056 RID: 28758
	public delegate IntPtr DllImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath);
}
