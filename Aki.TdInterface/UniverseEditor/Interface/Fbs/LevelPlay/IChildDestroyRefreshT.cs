using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004447 RID: 17479
	public class IChildDestroyRefreshT
	{
		// Token: 0x17007B28 RID: 31528
		// (get) Token: 0x0601A020 RID: 106528 RVA: 0x003B7ABE File Offset: 0x003B5CBE
		// (set) Token: 0x0601A021 RID: 106529 RVA: 0x003B7AC6 File Offset: 0x003B5CC6
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007B29 RID: 31529
		// (get) Token: 0x0601A022 RID: 106530 RVA: 0x003B7ACF File Offset: 0x003B5CCF
		// (set) Token: 0x0601A023 RID: 106531 RVA: 0x003B7AD7 File Offset: 0x003B5CD7
		public int MinRefreshCd { get; set; }

		// Token: 0x17007B2A RID: 31530
		// (get) Token: 0x0601A024 RID: 106532 RVA: 0x003B7AE0 File Offset: 0x003B5CE0
		// (set) Token: 0x0601A025 RID: 106533 RVA: 0x003B7AE8 File Offset: 0x003B5CE8
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601A026 RID: 106534 RVA: 0x003B7AF1 File Offset: 0x003B5CF1
		public IChildDestroyRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
