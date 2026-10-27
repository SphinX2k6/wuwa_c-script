using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407D RID: 16509
	public class IRecallConditionByGroupT
	{
		// Token: 0x17007481 RID: 29825
		// (get) Token: 0x06018027 RID: 98343 RVA: 0x00376D1D File Offset: 0x00374F1D
		// (set) Token: 0x06018028 RID: 98344 RVA: 0x00376D25 File Offset: 0x00374F25
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007482 RID: 29826
		// (get) Token: 0x06018029 RID: 98345 RVA: 0x00376D2E File Offset: 0x00374F2E
		// (set) Token: 0x0601802A RID: 98346 RVA: 0x00376D36 File Offset: 0x00374F36
		public ERecallOperation Operation { get; set; }

		// Token: 0x17007483 RID: 29827
		// (get) Token: 0x0601802B RID: 98347 RVA: 0x00376D3F File Offset: 0x00374F3F
		// (set) Token: 0x0601802C RID: 98348 RVA: 0x00376D47 File Offset: 0x00374F47
		public List<int> GroupIds { get; set; }

		// Token: 0x0601802D RID: 98349 RVA: 0x00376D50 File Offset: 0x00374F50
		public IRecallConditionByGroupT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.GroupIds = null;
		}
	}
}
