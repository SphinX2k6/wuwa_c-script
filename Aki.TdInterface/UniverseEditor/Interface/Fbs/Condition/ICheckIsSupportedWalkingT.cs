using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F6C RID: 20332
	public class ICheckIsSupportedWalkingT
	{
		// Token: 0x17009154 RID: 37204
		// (get) Token: 0x0601FA5D RID: 129629 RVA: 0x004668C8 File Offset: 0x00464AC8
		// (set) Token: 0x0601FA5E RID: 129630 RVA: 0x004668D0 File Offset: 0x00464AD0
		public ECondition Type { get; set; }

		// Token: 0x17009155 RID: 37205
		// (get) Token: 0x0601FA5F RID: 129631 RVA: 0x004668D9 File Offset: 0x00464AD9
		// (set) Token: 0x0601FA60 RID: 129632 RVA: 0x004668E1 File Offset: 0x00464AE1
		public bool IsSupported { get; set; }

		// Token: 0x0601FA61 RID: 129633 RVA: 0x004668EA File Offset: 0x00464AEA
		public ICheckIsSupportedWalkingT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSupported = false;
		}
	}
}
