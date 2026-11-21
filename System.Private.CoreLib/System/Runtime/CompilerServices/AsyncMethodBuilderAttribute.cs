using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000663 RID: 1635
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class AsyncMethodBuilderAttribute : Attribute
	{
		// Token: 0x06007328 RID: 29480 RVA: 0x001126F6 File Offset: 0x001108F6
		public AsyncMethodBuilderAttribute(Type builderType)
		{
			this.BuilderType = builderType;
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06007329 RID: 29481 RVA: 0x00112705 File Offset: 0x00110905
		public Type BuilderType { get; }
	}
}
