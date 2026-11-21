using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050C RID: 1292
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	public sealed class SupportedOSPlatformAttribute : OSPlatformAttribute
	{
		// Token: 0x06004858 RID: 18520 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public SupportedOSPlatformAttribute(string platformName) : base(platformName)
		{
		}
	}
}
