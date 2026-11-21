using System;

namespace System.Security
{
	// Token: 0x0200025F RID: 607
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class SecurityCriticalAttribute : Attribute
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x00022817 File Offset: 0x00020A17
		public SecurityCriticalAttribute()
		{
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00092FF6 File Offset: 0x000911F6
		public SecurityCriticalAttribute(SecurityCriticalScope scope)
		{
			this.Scope = scope;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00093005 File Offset: 0x00091205
		[Obsolete("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
		public SecurityCriticalScope Scope { get; }
	}
}
