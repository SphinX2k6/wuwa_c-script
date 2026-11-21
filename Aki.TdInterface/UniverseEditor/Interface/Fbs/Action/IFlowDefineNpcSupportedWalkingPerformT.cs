using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8E RID: 28302
	public class IFlowDefineNpcSupportedWalkingPerformT
	{
		// Token: 0x1700CF66 RID: 53094
		// (get) Token: 0x06030E7A RID: 200314 RVA: 0x006A2187 File Offset: 0x006A0387
		// (set) Token: 0x06030E7B RID: 200315 RVA: 0x006A218F File Offset: 0x006A038F
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700CF67 RID: 53095
		// (get) Token: 0x06030E7C RID: 200316 RVA: 0x006A2198 File Offset: 0x006A0398
		// (set) Token: 0x06030E7D RID: 200317 RVA: 0x006A21A0 File Offset: 0x006A03A0
		public string Key { get; set; }

		// Token: 0x06030E7E RID: 200318 RVA: 0x006A21A9 File Offset: 0x006A03A9
		public IFlowDefineNpcSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
