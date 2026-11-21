using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x02000510 RID: 1296
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public sealed class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute
	{
		// Token: 0x06004862 RID: 18530 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public UnsupportedOSPlatformGuardAttribute(string platformName) : base(platformName)
		{
		}
	}
}
