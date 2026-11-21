using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F9 RID: 2297
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class EventAttribute : Attribute
	{
		// Token: 0x06008CD0 RID: 36048 RVA: 0x0015973C File Offset: 0x0015793C
		public EventAttribute(int eventId)
		{
			this.EventId = eventId;
			this.Level = EventLevel.Informational;
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x00159752 File Offset: 0x00157952
		public int EventId { get; }

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06008CD2 RID: 36050 RVA: 0x0015975A File Offset: 0x0015795A
		// (set) Token: 0x06008CD3 RID: 36051 RVA: 0x00159762 File Offset: 0x00157962
		public EventLevel Level { get; set; }

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06008CD4 RID: 36052 RVA: 0x0015976B File Offset: 0x0015796B
		// (set) Token: 0x06008CD5 RID: 36053 RVA: 0x00159773 File Offset: 0x00157973
		public EventKeywords Keywords { get; set; }

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06008CD6 RID: 36054 RVA: 0x0015977C File Offset: 0x0015797C
		// (set) Token: 0x06008CD7 RID: 36055 RVA: 0x00159784 File Offset: 0x00157984
		public EventOpcode Opcode
		{
			get
			{
				return this.m_opcode;
			}
			set
			{
				this.m_opcode = value;
				this.m_opcodeSet = true;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06008CD8 RID: 36056 RVA: 0x00159794 File Offset: 0x00157994
		internal bool IsOpcodeSet
		{
			get
			{
				return this.m_opcodeSet;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x0015979C File Offset: 0x0015799C
		// (set) Token: 0x06008CDA RID: 36058 RVA: 0x001597A4 File Offset: 0x001579A4
		public EventTask Task { get; set; }

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06008CDB RID: 36059 RVA: 0x001597AD File Offset: 0x001579AD
		// (set) Token: 0x06008CDC RID: 36060 RVA: 0x001597B5 File Offset: 0x001579B5
		public EventChannel Channel { get; set; }

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x001597BE File Offset: 0x001579BE
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x001597C6 File Offset: 0x001579C6
		public byte Version { get; set; }

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x001597CF File Offset: 0x001579CF
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x001597D7 File Offset: 0x001579D7
		public string Message { get; set; }

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x001597E0 File Offset: 0x001579E0
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x001597E8 File Offset: 0x001579E8
		public EventTags Tags { get; set; }

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x001597F1 File Offset: 0x001579F1
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x001597F9 File Offset: 0x001579F9
		public EventActivityOptions ActivityOptions { get; set; }

		// Token: 0x04002021 RID: 8225
		private EventOpcode m_opcode;

		// Token: 0x04002022 RID: 8226
		private bool m_opcodeSet;
	}
}
