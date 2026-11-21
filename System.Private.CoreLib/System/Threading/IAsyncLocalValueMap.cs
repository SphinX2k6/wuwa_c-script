using System;

namespace System.Threading
{
	// Token: 0x020003CA RID: 970
	internal interface IAsyncLocalValueMap
	{
		// Token: 0x06003F78 RID: 16248
		bool TryGetValue(IAsyncLocal key, out object value);

		// Token: 0x06003F79 RID: 16249
		IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent);
	}
}
