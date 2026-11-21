using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000691 RID: 1681
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		// Token: 0x060073EA RID: 29674 RVA: 0x00114821 File Offset: 0x00112A21
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
			this.LoadHint = loadHintArgument;
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060073EB RID: 29675 RVA: 0x00114830 File Offset: 0x00112A30
		public LoadHint LoadHint { get; }
	}
}
