using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000927 RID: 2343
	public struct EventSourceOptions
	{
		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06008DA9 RID: 36265 RVA: 0x0015D5A2 File Offset: 0x0015B7A2
		// (set) Token: 0x06008DAA RID: 36266 RVA: 0x0015D5AA File Offset: 0x0015B7AA
		public EventLevel Level
		{
			get
			{
				return (EventLevel)this.level;
			}
			set
			{
				this.level = checked((byte)value);
				this.valuesSet |= 4;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06008DAB RID: 36267 RVA: 0x0015D5C3 File Offset: 0x0015B7C3
		// (set) Token: 0x06008DAC RID: 36268 RVA: 0x0015D5CB File Offset: 0x0015B7CB
		public EventOpcode Opcode
		{
			get
			{
				return (EventOpcode)this.opcode;
			}
			set
			{
				this.opcode = checked((byte)value);
				this.valuesSet |= 8;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x0015D5E4 File Offset: 0x0015B7E4
		internal bool IsOpcodeSet
		{
			get
			{
				return (this.valuesSet & 8) > 0;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x0015D5F1 File Offset: 0x0015B7F1
		// (set) Token: 0x06008DAF RID: 36271 RVA: 0x0015D5F9 File Offset: 0x0015B7F9
		public EventKeywords Keywords
		{
			get
			{
				return this.keywords;
			}
			set
			{
				this.keywords = value;
				this.valuesSet |= 1;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x0015D611 File Offset: 0x0015B811
		// (set) Token: 0x06008DB1 RID: 36273 RVA: 0x0015D619 File Offset: 0x0015B819
		public EventTags Tags
		{
			get
			{
				return this.tags;
			}
			set
			{
				this.tags = value;
				this.valuesSet |= 2;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x0015D631 File Offset: 0x0015B831
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x0015D639 File Offset: 0x0015B839
		public EventActivityOptions ActivityOptions
		{
			get
			{
				return this.activityOptions;
			}
			set
			{
				this.activityOptions = value;
				this.valuesSet |= 16;
			}
		}

		// Token: 0x040020F6 RID: 8438
		internal EventKeywords keywords;

		// Token: 0x040020F7 RID: 8439
		internal EventTags tags;

		// Token: 0x040020F8 RID: 8440
		internal EventActivityOptions activityOptions;

		// Token: 0x040020F9 RID: 8441
		internal byte level;

		// Token: 0x040020FA RID: 8442
		internal byte opcode;

		// Token: 0x040020FB RID: 8443
		internal byte valuesSet;
	}
}
