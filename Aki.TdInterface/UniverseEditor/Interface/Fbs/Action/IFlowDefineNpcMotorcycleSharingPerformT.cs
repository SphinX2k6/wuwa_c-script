using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680B RID: 26635
	public class IFlowDefineNpcMotorcycleSharingPerformT
	{
		// Token: 0x1700C5AB RID: 50603
		// (get) Token: 0x0602E61C RID: 189980 RVA: 0x0065480F File Offset: 0x00652A0F
		// (set) Token: 0x0602E61D RID: 189981 RVA: 0x00654817 File Offset: 0x00652A17
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700C5AC RID: 50604
		// (get) Token: 0x0602E61E RID: 189982 RVA: 0x00654820 File Offset: 0x00652A20
		// (set) Token: 0x0602E61F RID: 189983 RVA: 0x00654828 File Offset: 0x00652A28
		public string Key { get; set; }

		// Token: 0x0602E620 RID: 189984 RVA: 0x00654831 File Offset: 0x00652A31
		public IFlowDefineNpcMotorcycleSharingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
