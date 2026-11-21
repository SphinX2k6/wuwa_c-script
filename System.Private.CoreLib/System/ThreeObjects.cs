using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000147 RID: 327
	[InlineArray(3)]
	internal struct ThreeObjects
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x0003EC26 File Offset: 0x0003CE26
		public unsafe ThreeObjects(object arg0, object arg1, object arg2)
		{
			this = default(ThreeObjects);
			*<PrivateImplementationDetails>.InlineArrayFirstElementRef<ThreeObjects, object>(ref this) = arg0;
			*<PrivateImplementationDetails>.InlineArrayElementRef<ThreeObjects, object>(ref this, 1) = arg1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<ThreeObjects, object>(ref this, 2) = arg2;
		}

		// Token: 0x040004BA RID: 1210
		private object _arg0;
	}
}
