using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200067C RID: 1660
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	public sealed class CompilerFeatureRequiredAttribute : Attribute
	{
		// Token: 0x06007391 RID: 29585 RVA: 0x001134AA File Offset: 0x001116AA
		public CompilerFeatureRequiredAttribute(string featureName)
		{
			this.FeatureName = featureName;
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06007392 RID: 29586 RVA: 0x001134B9 File Offset: 0x001116B9
		public string FeatureName { get; }

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x001134C1 File Offset: 0x001116C1
		// (set) Token: 0x06007394 RID: 29588 RVA: 0x001134C9 File Offset: 0x001116C9
		public bool IsOptional { get; set; }

		// Token: 0x0400148A RID: 5258
		public const string RefStructs = "RefStructs";

		// Token: 0x0400148B RID: 5259
		public const string RequiredMembers = "RequiredMembers";
	}
}
