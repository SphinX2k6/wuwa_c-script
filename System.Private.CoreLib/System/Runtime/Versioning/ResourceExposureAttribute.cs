using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	// Token: 0x02000513 RID: 1299
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	[Conditional("RESOURCE_ANNOTATION_WORK")]
	public sealed class ResourceExposureAttribute : Attribute
	{
		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x000F1022 File Offset: 0x000EF222
		public ResourceScope ResourceExposureLevel { get; }

		// Token: 0x0600486D RID: 18541 RVA: 0x000F102A File Offset: 0x000EF22A
		public ResourceExposureAttribute(ResourceScope exposureLevel)
		{
			this.ResourceExposureLevel = exposureLevel;
		}
	}
}
