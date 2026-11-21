using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability.Editor
{
	// Token: 0x02006421 RID: 25633
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RowPool
	{
		// Token: 0x0603E3B8 RID: 254904 RVA: 0x01212825 File Offset: 0x01210A25
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RowPool()
		{
		}

		// Token: 0x040211D5 RID: 135637
		[RequiredMember]
		public UTextBlock Label;

		// Token: 0x040211D6 RID: 135638
		[Nullable(2)]
		public UCanvasPanelSlot LabelSlot;

		// Token: 0x040211D7 RID: 135639
		[RequiredMember]
		public string LabelText;

		// Token: 0x040211D8 RID: 135640
		[RequiredMember]
		public List<UImage> Spans;

		// Token: 0x040211D9 RID: 135641
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public List<UCanvasPanelSlot> SpanSlots;

		// Token: 0x040211DA RID: 135642
		[RequiredMember]
		public List<UImage> Events;

		// Token: 0x040211DB RID: 135643
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public List<UCanvasPanelSlot> EventSlots;

		// Token: 0x040211DC RID: 135644
		[RequiredMember]
		public int UsedSpans;

		// Token: 0x040211DD RID: 135645
		[RequiredMember]
		public int UsedEvents;
	}
}
