using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC6 RID: 15302
	public class IShowTimelineMonsterStateT
	{
		// Token: 0x170068FA RID: 26874
		// (get) Token: 0x0601504F RID: 86095 RVA: 0x0030C30B File Offset: 0x0030A50B
		// (set) Token: 0x06015050 RID: 86096 RVA: 0x0030C313 File Offset: 0x0030A513
		public int MonsterEntityId { get; set; }

		// Token: 0x170068FB RID: 26875
		// (get) Token: 0x06015051 RID: 86097 RVA: 0x0030C31C File Offset: 0x0030A51C
		// (set) Token: 0x06015052 RID: 86098 RVA: 0x0030C324 File Offset: 0x0030A524
		public ITransformT Transform { get; set; }

		// Token: 0x170068FC RID: 26876
		// (get) Token: 0x06015053 RID: 86099 RVA: 0x0030C32D File Offset: 0x0030A52D
		// (set) Token: 0x06015054 RID: 86100 RVA: 0x0030C335 File Offset: 0x0030A535
		public List<int> Attributes { get; set; }

		// Token: 0x170068FD RID: 26877
		// (get) Token: 0x06015055 RID: 86101 RVA: 0x0030C33E File Offset: 0x0030A53E
		// (set) Token: 0x06015056 RID: 86102 RVA: 0x0030C346 File Offset: 0x0030A546
		public List<int> Buffs { get; set; }

		// Token: 0x170068FE RID: 26878
		// (get) Token: 0x06015057 RID: 86103 RVA: 0x0030C34F File Offset: 0x0030A54F
		// (set) Token: 0x06015058 RID: 86104 RVA: 0x0030C357 File Offset: 0x0030A557
		public List<long> BuffIds { get; set; }

		// Token: 0x170068FF RID: 26879
		// (get) Token: 0x06015059 RID: 86105 RVA: 0x0030C360 File Offset: 0x0030A560
		// (set) Token: 0x0601505A RID: 86106 RVA: 0x0030C368 File Offset: 0x0030A568
		public List<string> Tags { get; set; }

		// Token: 0x0601505B RID: 86107 RVA: 0x0030C371 File Offset: 0x0030A571
		public IShowTimelineMonsterStateT()
		{
			this.MonsterEntityId = 0;
			this.Transform = null;
			this.Attributes = null;
			this.Buffs = null;
			this.BuffIds = null;
			this.Tags = null;
		}
	}
}
