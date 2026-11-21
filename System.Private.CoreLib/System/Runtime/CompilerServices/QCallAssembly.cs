using System;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006E9 RID: 1769
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct QCallAssembly
	{
		// Token: 0x06007515 RID: 29973 RVA: 0x00116674 File Offset: 0x00114874
		internal QCallAssembly(ref RuntimeAssembly assembly)
		{
			this._ptr = Unsafe.AsPointer<RuntimeAssembly>(ref assembly);
			RuntimeAssembly runtimeAssembly = assembly;
			this._assembly = ((runtimeAssembly != null) ? runtimeAssembly.GetUnderlyingNativeHandle() : IntPtr.Zero);
		}

		// Token: 0x04001513 RID: 5395
		private unsafe void* _ptr;

		// Token: 0x04001514 RID: 5396
		private IntPtr _assembly;
	}
}
