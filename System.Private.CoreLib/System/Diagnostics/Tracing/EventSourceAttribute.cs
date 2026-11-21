using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F8 RID: 2296
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class EventSourceAttribute : Attribute
	{
		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06008CC9 RID: 36041 RVA: 0x00159709 File Offset: 0x00157909
		// (set) Token: 0x06008CCA RID: 36042 RVA: 0x00159711 File Offset: 0x00157911
		public string Name { get; set; }

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x0015971A File Offset: 0x0015791A
		// (set) Token: 0x06008CCC RID: 36044 RVA: 0x00159722 File Offset: 0x00157922
		public string Guid { get; set; }

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x0015972B File Offset: 0x0015792B
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x00159733 File Offset: 0x00157933
		public string LocalizationResources { get; set; }
	}
}
