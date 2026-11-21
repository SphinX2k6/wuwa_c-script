using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000922 RID: 2338
	[AttributeUsage(AttributeTargets.Property)]
	public class EventFieldAttribute : Attribute
	{
		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x0015D38B File Offset: 0x0015B58B
		// (set) Token: 0x06008D8B RID: 36235 RVA: 0x0015D393 File Offset: 0x0015B593
		public EventFieldTags Tags { get; set; }

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x0015D39C File Offset: 0x0015B59C
		[Nullable(2)]
		internal string Name { get; }

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06008D8D RID: 36237 RVA: 0x0015D3A4 File Offset: 0x0015B5A4
		// (set) Token: 0x06008D8E RID: 36238 RVA: 0x0015D3AC File Offset: 0x0015B5AC
		public EventFieldFormat Format { get; set; }
	}
}
