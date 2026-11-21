using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A8 RID: 2216
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class FeatureGuardAttribute : Attribute
	{
		// Token: 0x060089EB RID: 35307 RVA: 0x0014E968 File Offset: 0x0014CB68
		public FeatureGuardAttribute(Type featureType)
		{
			this.FeatureType = featureType;
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x060089EC RID: 35308 RVA: 0x0014E977 File Offset: 0x0014CB77
		public Type FeatureType { get; }
	}
}
