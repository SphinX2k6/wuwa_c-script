using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F9 RID: 26617
	public class IFlowDefineNpcCancelMotorcycleSharingPerformT
	{
		// Token: 0x1700C594 RID: 50580
		// (get) Token: 0x0602E595 RID: 189845 RVA: 0x006539E3 File Offset: 0x00651BE3
		// (set) Token: 0x0602E596 RID: 189846 RVA: 0x006539EB File Offset: 0x00651BEB
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700C595 RID: 50581
		// (get) Token: 0x0602E597 RID: 189847 RVA: 0x006539F4 File Offset: 0x00651BF4
		// (set) Token: 0x0602E598 RID: 189848 RVA: 0x006539FC File Offset: 0x00651BFC
		public string Key { get; set; }

		// Token: 0x0602E599 RID: 189849 RVA: 0x00653A05 File Offset: 0x00651C05
		public IFlowDefineNpcCancelMotorcycleSharingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
