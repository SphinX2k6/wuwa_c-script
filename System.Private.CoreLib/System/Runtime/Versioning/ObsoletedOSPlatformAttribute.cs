using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050E RID: 1294
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	public sealed class ObsoletedOSPlatformAttribute : OSPlatformAttribute
	{
		// Token: 0x0600485C RID: 18524 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public ObsoletedOSPlatformAttribute(string platformName) : base(platformName)
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x000F0F95 File Offset: 0x000EF195
		[NullableContext(1)]
		public ObsoletedOSPlatformAttribute(string platformName, [Nullable(2)] string message) : base(platformName)
		{
			this.Message = message;
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x000F0FA5 File Offset: 0x000EF1A5
		public string Message { get; }

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x000F0FAD File Offset: 0x000EF1AD
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x000F0FB5 File Offset: 0x000EF1B5
		public string Url { get; set; }
	}
}
