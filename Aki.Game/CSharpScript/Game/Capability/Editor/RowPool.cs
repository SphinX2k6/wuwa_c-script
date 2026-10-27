using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability.Editor
{
	// Token: 0x020072A2 RID: 29346
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RowPool
	{
		// Token: 0x06047FEF RID: 294895 RVA: 0x01271891 File Offset: 0x0126FA91
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RowPool()
		{
		}

		// Token: 0x04025F02 RID: 155394
		[RequiredMember]
		public UTextBlock Label;

		// Token: 0x04025F03 RID: 155395
		[Nullable(2)]
		public UCanvasPanelSlot LabelSlot;

		// Token: 0x04025F04 RID: 155396
		[RequiredMember]
		public string LabelText;

		// Token: 0x04025F05 RID: 155397
		[RequiredMember]
		public List<UImage> Spans;

		// Token: 0x04025F06 RID: 155398
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public List<UCanvasPanelSlot> SpanSlots;

		// Token: 0x04025F07 RID: 155399
		[RequiredMember]
		public List<UImage> Events;

		// Token: 0x04025F08 RID: 155400
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public List<UCanvasPanelSlot> EventSlots;

		// Token: 0x04025F09 RID: 155401
		[RequiredMember]
		public int UsedSpans;

		// Token: 0x04025F0A RID: 155402
		[RequiredMember]
		public int UsedEvents;
	}
}
