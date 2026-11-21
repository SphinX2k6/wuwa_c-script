using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050A RID: 1290
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class OSPlatformAttribute : Attribute
	{
		// Token: 0x06004855 RID: 18517 RVA: 0x000F0F5D File Offset: 0x000EF15D
		private protected OSPlatformAttribute(string platformName)
		{
			this.PlatformName = platformName;
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x000F0F6C File Offset: 0x000EF16C
		public string PlatformName { get; }
	}
}
