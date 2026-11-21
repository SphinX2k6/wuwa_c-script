using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050D RID: 1293
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	public sealed class UnsupportedOSPlatformAttribute : OSPlatformAttribute
	{
		// Token: 0x06004859 RID: 18521 RVA: 0x000F0F74 File Offset: 0x000EF174
		public UnsupportedOSPlatformAttribute(string platformName) : base(platformName)
		{
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x000F0F7D File Offset: 0x000EF17D
		public UnsupportedOSPlatformAttribute(string platformName, [Nullable(2)] string message) : base(platformName)
		{
			this.Message = message;
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x000F0F8D File Offset: 0x000EF18D
		[Nullable(2)]
		public string Message { [NullableContext(2)] get; }
	}
}
