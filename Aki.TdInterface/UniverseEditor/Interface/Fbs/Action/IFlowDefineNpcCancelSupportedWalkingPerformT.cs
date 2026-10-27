using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FC RID: 26620
	public class IFlowDefineNpcCancelSupportedWalkingPerformT
	{
		// Token: 0x1700C599 RID: 50585
		// (get) Token: 0x0602E5AD RID: 189869 RVA: 0x00653C17 File Offset: 0x00651E17
		// (set) Token: 0x0602E5AE RID: 189870 RVA: 0x00653C1F File Offset: 0x00651E1F
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700C59A RID: 50586
		// (get) Token: 0x0602E5AF RID: 189871 RVA: 0x00653C28 File Offset: 0x00651E28
		// (set) Token: 0x0602E5B0 RID: 189872 RVA: 0x00653C30 File Offset: 0x00651E30
		public string Key { get; set; }

		// Token: 0x0602E5B1 RID: 189873 RVA: 0x00653C39 File Offset: 0x00651E39
		public IFlowDefineNpcCancelSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
