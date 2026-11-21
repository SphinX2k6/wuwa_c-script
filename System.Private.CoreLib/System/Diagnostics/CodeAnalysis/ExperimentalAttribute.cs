using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A7 RID: 2215
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class ExperimentalAttribute : Attribute
	{
		// Token: 0x060089E7 RID: 35303 RVA: 0x0014E940 File Offset: 0x0014CB40
		public ExperimentalAttribute(string diagnosticId)
		{
			this.DiagnosticId = diagnosticId;
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x0014E94F File Offset: 0x0014CB4F
		public string DiagnosticId { get; }

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x0014E957 File Offset: 0x0014CB57
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x0014E95F File Offset: 0x0014CB5F
		[Nullable(2)]
		public string UrlFormat { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
