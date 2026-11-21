using System;
using System.Reflection;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200092B RID: 2347
	internal sealed class PropertyAnalysis
	{
		// Token: 0x06008DC3 RID: 36291 RVA: 0x0015DC28 File Offset: 0x0015BE28
		public PropertyAnalysis(string name, PropertyInfo propertyInfo, TraceLoggingTypeInfo typeInfo, EventFieldAttribute fieldAttribute)
		{
			this.name = name;
			this.propertyInfo = propertyInfo;
			this.getter = PropertyValue.GetPropertyGetter(propertyInfo);
			this.typeInfo = typeInfo;
			this.fieldAttribute = fieldAttribute;
		}

		// Token: 0x04002109 RID: 8457
		internal readonly string name;

		// Token: 0x0400210A RID: 8458
		internal readonly PropertyInfo propertyInfo;

		// Token: 0x0400210B RID: 8459
		internal readonly Func<PropertyValue, PropertyValue> getter;

		// Token: 0x0400210C RID: 8460
		internal readonly TraceLoggingTypeInfo typeInfo;

		// Token: 0x0400210D RID: 8461
		internal readonly EventFieldAttribute fieldAttribute;
	}
}
