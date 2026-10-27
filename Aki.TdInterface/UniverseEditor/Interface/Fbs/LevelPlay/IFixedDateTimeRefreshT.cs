using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044CE RID: 17614
	public class IFixedDateTimeRefreshT
	{
		// Token: 0x17007C54 RID: 31828
		// (get) Token: 0x0601A53C RID: 107836 RVA: 0x003C2368 File Offset: 0x003C0568
		// (set) Token: 0x0601A53D RID: 107837 RVA: 0x003C2370 File Offset: 0x003C0570
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007C55 RID: 31829
		// (get) Token: 0x0601A53E RID: 107838 RVA: 0x003C2379 File Offset: 0x003C0579
		// (set) Token: 0x0601A53F RID: 107839 RVA: 0x003C2381 File Offset: 0x003C0581
		public ELevelPlayInteractResetTime UpdateType { get; set; }

		// Token: 0x0601A540 RID: 107840 RVA: 0x003C238A File Offset: 0x003C058A
		public IFixedDateTimeRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.UpdateType = ELevelPlayInteractResetTime.Weekly;
		}
	}
}
