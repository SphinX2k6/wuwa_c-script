using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	// Token: 0x02000512 RID: 1298
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	[Conditional("RESOURCE_ANNOTATION_WORK")]
	public sealed class ResourceConsumptionAttribute : Attribute
	{
		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x000F0FE6 File Offset: 0x000EF1E6
		public ResourceScope ResourceScope { get; }

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x000F0FEE File Offset: 0x000EF1EE
		public ResourceScope ConsumptionScope { get; }

		// Token: 0x0600486A RID: 18538 RVA: 0x000F0FF6 File Offset: 0x000EF1F6
		public ResourceConsumptionAttribute(ResourceScope resourceScope)
		{
			this.ResourceScope = resourceScope;
			this.ConsumptionScope = resourceScope;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x000F100C File Offset: 0x000EF20C
		public ResourceConsumptionAttribute(ResourceScope resourceScope, ResourceScope consumptionScope)
		{
			this.ResourceScope = resourceScope;
			this.ConsumptionScope = consumptionScope;
		}
	}
}
