using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050F RID: 1295
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public sealed class SupportedOSPlatformGuardAttribute : OSPlatformAttribute
	{
		// Token: 0x06004861 RID: 18529 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public SupportedOSPlatformGuardAttribute(string platformName) : base(platformName)
		{
		}
	}
}
