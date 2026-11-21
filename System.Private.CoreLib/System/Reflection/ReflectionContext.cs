using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000772 RID: 1906
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ReflectionContext
	{
		// Token: 0x06007A1F RID: 31263
		public abstract Assembly MapAssembly(Assembly assembly);

		// Token: 0x06007A20 RID: 31264
		public abstract TypeInfo MapType(TypeInfo type);

		// Token: 0x06007A21 RID: 31265 RVA: 0x001217C9 File Offset: 0x0011F9C9
		public virtual TypeInfo GetTypeForObject(object value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			return this.MapType(value.GetType().GetTypeInfo());
		}
	}
}
