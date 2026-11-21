using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC3 RID: 28611
	public class IHideWorldEntityAndLevelPlayGroupT
	{
		// Token: 0x1700D196 RID: 53654
		// (get) Token: 0x0603190A RID: 203018 RVA: 0x006B794E File Offset: 0x006B5B4E
		// (set) Token: 0x0603190B RID: 203019 RVA: 0x006B7956 File Offset: 0x006B5B56
		public EHideType Type { get; set; }

		// Token: 0x1700D197 RID: 53655
		// (get) Token: 0x0603190C RID: 203020 RVA: 0x006B795F File Offset: 0x006B5B5F
		// (set) Token: 0x0603190D RID: 203021 RVA: 0x006B7967 File Offset: 0x006B5B67
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x1700D198 RID: 53656
		// (get) Token: 0x0603190E RID: 203022 RVA: 0x006B7970 File Offset: 0x006B5B70
		// (set) Token: 0x0603190F RID: 203023 RVA: 0x006B7978 File Offset: 0x006B5B78
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x1700D199 RID: 53657
		// (get) Token: 0x06031910 RID: 203024 RVA: 0x006B7981 File Offset: 0x006B5B81
		// (set) Token: 0x06031911 RID: 203025 RVA: 0x006B7989 File Offset: 0x006B5B89
		public List<int> ExcludeLevelPlays { get; set; }

		// Token: 0x1700D19A RID: 53658
		// (get) Token: 0x06031912 RID: 203026 RVA: 0x006B7992 File Offset: 0x006B5B92
		// (set) Token: 0x06031913 RID: 203027 RVA: 0x006B799A File Offset: 0x006B5B9A
		public List<int> AppendEntities { get; set; }

		// Token: 0x1700D19B RID: 53659
		// (get) Token: 0x06031914 RID: 203028 RVA: 0x006B79A3 File Offset: 0x006B5BA3
		// (set) Token: 0x06031915 RID: 203029 RVA: 0x006B79AB File Offset: 0x006B5BAB
		public List<int> AppendLevelPlays { get; set; }

		// Token: 0x1700D19C RID: 53660
		// (get) Token: 0x06031916 RID: 203030 RVA: 0x006B79B4 File Offset: 0x006B5BB4
		// (set) Token: 0x06031917 RID: 203031 RVA: 0x006B79BC File Offset: 0x006B5BBC
		public byte NullMask { get; set; }

		// Token: 0x06031918 RID: 203032 RVA: 0x006B79C5 File Offset: 0x006B5BC5
		public IHideWorldEntityAndLevelPlayGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.HideRangeEntities = null;
			this.ExcludeEntities = null;
			this.ExcludeLevelPlays = null;
			this.AppendEntities = null;
			this.AppendLevelPlays = null;
			this.NullMask = 0;
		}
	}
}
