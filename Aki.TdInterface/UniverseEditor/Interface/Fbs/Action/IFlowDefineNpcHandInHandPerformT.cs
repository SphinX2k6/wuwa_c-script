using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006808 RID: 26632
	public class IFlowDefineNpcHandInHandPerformT
	{
		// Token: 0x1700C5A6 RID: 50598
		// (get) Token: 0x0602E604 RID: 189956 RVA: 0x006545DB File Offset: 0x006527DB
		// (set) Token: 0x0602E605 RID: 189957 RVA: 0x006545E3 File Offset: 0x006527E3
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700C5A7 RID: 50599
		// (get) Token: 0x0602E606 RID: 189958 RVA: 0x006545EC File Offset: 0x006527EC
		// (set) Token: 0x0602E607 RID: 189959 RVA: 0x006545F4 File Offset: 0x006527F4
		public string Key { get; set; }

		// Token: 0x0602E608 RID: 189960 RVA: 0x006545FD File Offset: 0x006527FD
		public IFlowDefineNpcHandInHandPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
