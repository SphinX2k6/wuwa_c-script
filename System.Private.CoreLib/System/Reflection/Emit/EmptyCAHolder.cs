using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007BE RID: 1982
	internal sealed class EmptyCAHolder : ICustomAttributeProvider
	{
		// Token: 0x06007F7F RID: 32639 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal EmptyCAHolder()
		{
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x001214D6 File Offset: 0x0011F6D6
		object[] ICustomAttributeProvider.GetCustomAttributes(Type attributeType, bool inherit)
		{
			return Array.Empty<object>();
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x001214D6 File Offset: 0x0011F6D6
		object[] ICustomAttributeProvider.GetCustomAttributes(bool inherit)
		{
			return Array.Empty<object>();
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICustomAttributeProvider.IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}
	}
}
