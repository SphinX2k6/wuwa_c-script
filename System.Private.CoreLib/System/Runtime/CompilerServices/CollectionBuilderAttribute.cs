using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000679 RID: 1657
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
	public sealed class CollectionBuilderAttribute : Attribute
	{
		// Token: 0x0600738B RID: 29579 RVA: 0x0011346D File Offset: 0x0011166D
		public CollectionBuilderAttribute(Type builderType, string methodName)
		{
			this.BuilderType = builderType;
			this.MethodName = methodName;
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x0600738C RID: 29580 RVA: 0x00113483 File Offset: 0x00111683
		public Type BuilderType { get; }

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600738D RID: 29581 RVA: 0x0011348B File Offset: 0x0011168B
		public string MethodName { get; }
	}
}
