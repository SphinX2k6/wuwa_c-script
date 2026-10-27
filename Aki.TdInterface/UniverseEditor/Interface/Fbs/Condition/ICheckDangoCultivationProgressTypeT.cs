using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049BC RID: 18876
	public class ICheckDangoCultivationProgressTypeT
	{
		// Token: 0x1700887F RID: 34943
		// (get) Token: 0x0601D78C RID: 120716 RVA: 0x00426D16 File Offset: 0x00424F16
		// (set) Token: 0x0601D78D RID: 120717 RVA: 0x00426D1E File Offset: 0x00424F1E
		public ECheckDangoCultivationProgressType Type { get; set; }

		// Token: 0x0601D78E RID: 120718 RVA: 0x00426D27 File Offset: 0x00424F27
		public ICheckDangoCultivationProgressTypeT()
		{
			this.Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
		}
	}
}
