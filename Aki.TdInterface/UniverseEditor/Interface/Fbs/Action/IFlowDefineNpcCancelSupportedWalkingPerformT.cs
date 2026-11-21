using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7C RID: 28284
	public class IFlowDefineNpcCancelSupportedWalkingPerformT
	{
		// Token: 0x1700CF4F RID: 53071
		// (get) Token: 0x06030DF3 RID: 200179 RVA: 0x006A135B File Offset: 0x0069F55B
		// (set) Token: 0x06030DF4 RID: 200180 RVA: 0x006A1363 File Offset: 0x0069F563
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700CF50 RID: 53072
		// (get) Token: 0x06030DF5 RID: 200181 RVA: 0x006A136C File Offset: 0x0069F56C
		// (set) Token: 0x06030DF6 RID: 200182 RVA: 0x006A1374 File Offset: 0x0069F574
		public string Key { get; set; }

		// Token: 0x06030DF7 RID: 200183 RVA: 0x006A137D File Offset: 0x0069F57D
		public IFlowDefineNpcCancelSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
