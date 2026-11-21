using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000920 RID: 2336
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public class EventDataAttribute : Attribute
	{
		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06008D83 RID: 36227 RVA: 0x0015D344 File Offset: 0x0015B544
		// (set) Token: 0x06008D84 RID: 36228 RVA: 0x0015D34C File Offset: 0x0015B54C
		public string Name { get; set; }

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06008D85 RID: 36229 RVA: 0x0015D355 File Offset: 0x0015B555
		internal EventLevel Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06008D86 RID: 36230 RVA: 0x0015D35D File Offset: 0x0015B55D
		internal EventOpcode Opcode
		{
			get
			{
				return this.opcode;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06008D87 RID: 36231 RVA: 0x0015D365 File Offset: 0x0015B565
		internal EventKeywords Keywords { get; }

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x0015D36D File Offset: 0x0015B56D
		internal EventTags Tags { get; }

		// Token: 0x040020DE RID: 8414
		private EventLevel level = (EventLevel)(-1);

		// Token: 0x040020DF RID: 8415
		private EventOpcode opcode = (EventOpcode)(-1);
	}
}
