using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000745 RID: 1861
	[NullableContext(1)]
	public interface ICustomAttributeProvider
	{
		// Token: 0x0600790B RID: 30987
		object[] GetCustomAttributes(bool inherit);

		// Token: 0x0600790C RID: 30988
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		// Token: 0x0600790D RID: 30989
		bool IsDefined(Type attributeType, bool inherit);
	}
}
