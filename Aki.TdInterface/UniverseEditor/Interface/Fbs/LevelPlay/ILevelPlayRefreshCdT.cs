using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004510 RID: 17680
	public class ILevelPlayRefreshCdT
	{
		// Token: 0x17007D5B RID: 32091
		// (get) Token: 0x0601A917 RID: 108823 RVA: 0x003CB518 File Offset: 0x003C9718
		// (set) Token: 0x0601A918 RID: 108824 RVA: 0x003CB520 File Offset: 0x003C9720
		public int MinRefreshCd { get; set; }

		// Token: 0x17007D5C RID: 32092
		// (get) Token: 0x0601A919 RID: 108825 RVA: 0x003CB529 File Offset: 0x003C9729
		// (set) Token: 0x0601A91A RID: 108826 RVA: 0x003CB531 File Offset: 0x003C9731
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601A91B RID: 108827 RVA: 0x003CB53A File Offset: 0x003C973A
		public ILevelPlayRefreshCdT()
		{
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
