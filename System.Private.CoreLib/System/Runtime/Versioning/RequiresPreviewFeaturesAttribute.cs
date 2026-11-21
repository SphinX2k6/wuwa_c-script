using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x02000511 RID: 1297
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class RequiresPreviewFeaturesAttribute : Attribute
	{
		// Token: 0x06004863 RID: 18531 RVA: 0x00022817 File Offset: 0x00020A17
		public RequiresPreviewFeaturesAttribute()
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x000F0FBE File Offset: 0x000EF1BE
		public RequiresPreviewFeaturesAttribute(string message)
		{
			this.Message = message;
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x000F0FCD File Offset: 0x000EF1CD
		public string Message { get; }

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x000F0FD5 File Offset: 0x000EF1D5
		// (set) Token: 0x06004867 RID: 18535 RVA: 0x000F0FDD File Offset: 0x000EF1DD
		public string Url { get; set; }
	}
}
