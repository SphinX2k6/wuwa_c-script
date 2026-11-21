using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x0200050B RID: 1291
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class TargetPlatformAttribute : OSPlatformAttribute
	{
		// Token: 0x06004857 RID: 18519 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public TargetPlatformAttribute(string platformName) : base(platformName)
		{
		}
	}
}
