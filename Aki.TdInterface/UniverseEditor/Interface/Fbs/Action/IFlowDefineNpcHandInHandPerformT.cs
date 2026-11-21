using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E88 RID: 28296
	public class IFlowDefineNpcHandInHandPerformT
	{
		// Token: 0x1700CF5C RID: 53084
		// (get) Token: 0x06030E4A RID: 200266 RVA: 0x006A1D1F File Offset: 0x0069FF1F
		// (set) Token: 0x06030E4B RID: 200267 RVA: 0x006A1D27 File Offset: 0x0069FF27
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700CF5D RID: 53085
		// (get) Token: 0x06030E4C RID: 200268 RVA: 0x006A1D30 File Offset: 0x0069FF30
		// (set) Token: 0x06030E4D RID: 200269 RVA: 0x006A1D38 File Offset: 0x0069FF38
		public string Key { get; set; }

		// Token: 0x06030E4E RID: 200270 RVA: 0x006A1D41 File Offset: 0x0069FF41
		public IFlowDefineNpcHandInHandPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
