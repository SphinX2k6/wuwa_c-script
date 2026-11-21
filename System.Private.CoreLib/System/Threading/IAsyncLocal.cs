using System;

namespace System.Threading
{
	// Token: 0x020003C8 RID: 968
	internal interface IAsyncLocal
	{
		// Token: 0x06003F73 RID: 16243
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
