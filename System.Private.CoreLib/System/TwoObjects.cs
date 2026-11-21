using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000146 RID: 326
	[InlineArray(2)]
	internal struct TwoObjects
	{
		// Token: 0x060013E9 RID: 5097 RVA: 0x0003EC0C File Offset: 0x0003CE0C
		public unsafe TwoObjects(object arg0, object arg1)
		{
			this = default(TwoObjects);
			*<PrivateImplementationDetails>.InlineArrayFirstElementRef<TwoObjects, object>(ref this) = arg0;
			*<PrivateImplementationDetails>.InlineArrayElementRef<TwoObjects, object>(ref this, 1) = arg1;
		}

		// Token: 0x040004B9 RID: 1209
		private object _arg0;
	}
}
