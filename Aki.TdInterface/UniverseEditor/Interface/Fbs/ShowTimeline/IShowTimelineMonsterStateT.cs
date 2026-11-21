using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FCE RID: 16334
	public class IShowTimelineMonsterStateT
	{
		// Token: 0x17006E9D RID: 28317
		// (get) Token: 0x06016527 RID: 91431 RVA: 0x00332B67 File Offset: 0x00330D67
		// (set) Token: 0x06016528 RID: 91432 RVA: 0x00332B6F File Offset: 0x00330D6F
		public int MonsterEntityId { get; set; }

		// Token: 0x17006E9E RID: 28318
		// (get) Token: 0x06016529 RID: 91433 RVA: 0x00332B78 File Offset: 0x00330D78
		// (set) Token: 0x0601652A RID: 91434 RVA: 0x00332B80 File Offset: 0x00330D80
		public ITransformT Transform { get; set; }

		// Token: 0x17006E9F RID: 28319
		// (get) Token: 0x0601652B RID: 91435 RVA: 0x00332B89 File Offset: 0x00330D89
		// (set) Token: 0x0601652C RID: 91436 RVA: 0x00332B91 File Offset: 0x00330D91
		public List<int> Attributes { get; set; }

		// Token: 0x17006EA0 RID: 28320
		// (get) Token: 0x0601652D RID: 91437 RVA: 0x00332B9A File Offset: 0x00330D9A
		// (set) Token: 0x0601652E RID: 91438 RVA: 0x00332BA2 File Offset: 0x00330DA2
		public List<int> Buffs { get; set; }

		// Token: 0x17006EA1 RID: 28321
		// (get) Token: 0x0601652F RID: 91439 RVA: 0x00332BAB File Offset: 0x00330DAB
		// (set) Token: 0x06016530 RID: 91440 RVA: 0x00332BB3 File Offset: 0x00330DB3
		public List<long> BuffIds { get; set; }

		// Token: 0x17006EA2 RID: 28322
		// (get) Token: 0x06016531 RID: 91441 RVA: 0x00332BBC File Offset: 0x00330DBC
		// (set) Token: 0x06016532 RID: 91442 RVA: 0x00332BC4 File Offset: 0x00330DC4
		public List<string> Tags { get; set; }

		// Token: 0x06016533 RID: 91443 RVA: 0x00332BCD File Offset: 0x00330DCD
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
