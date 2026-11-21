using System;

namespace System.Security
{
	// Token: 0x02000257 RID: 599
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class AllowPartiallyTrustedCallersAttribute : Attribute
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x0009260F File Offset: 0x0009080F
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x00092617 File Offset: 0x00090817
		public PartialTrustVisibilityLevel PartialTrustVisibilityLevel { get; set; }
	}
}
