using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000748 RID: 1864
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class IntrospectionExtensions
	{
		// Token: 0x0600790E RID: 30990 RVA: 0x0011F530 File Offset: 0x0011D730
		[NullableContext(1)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static TypeInfo GetTypeInfo(this Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			IReflectableType reflectableType = type as IReflectableType;
			if (reflectableType != null)
			{
				return reflectableType.GetTypeInfo();
			}
			return new TypeDelegator(type);
		}
	}
}
