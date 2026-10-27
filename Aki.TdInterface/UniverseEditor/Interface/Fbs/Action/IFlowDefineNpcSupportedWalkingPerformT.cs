using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680E RID: 26638
	public class IFlowDefineNpcSupportedWalkingPerformT
	{
		// Token: 0x1700C5B0 RID: 50608
		// (get) Token: 0x0602E634 RID: 190004 RVA: 0x00654A43 File Offset: 0x00652C43
		// (set) Token: 0x0602E635 RID: 190005 RVA: 0x00654A4B File Offset: 0x00652C4B
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700C5B1 RID: 50609
		// (get) Token: 0x0602E636 RID: 190006 RVA: 0x00654A54 File Offset: 0x00652C54
		// (set) Token: 0x0602E637 RID: 190007 RVA: 0x00654A5C File Offset: 0x00652C5C
		public string Key { get; set; }

		// Token: 0x0602E638 RID: 190008 RVA: 0x00654A65 File Offset: 0x00652C65
		public IFlowDefineNpcSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
