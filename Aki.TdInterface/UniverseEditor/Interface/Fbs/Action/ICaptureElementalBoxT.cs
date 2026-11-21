using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006920 RID: 26912
	public class ICaptureElementalBoxT
	{
		// Token: 0x1700C61F RID: 50719
		// (get) Token: 0x0602E1E2 RID: 188898 RVA: 0x0064D3F1 File Offset: 0x0064B5F1
		// (set) Token: 0x0602E1E3 RID: 188899 RVA: 0x0064D3F9 File Offset: 0x0064B5F9
		public TControlElementalBoxTypeUnion CtrlConfig { get; set; }

		// Token: 0x1700C620 RID: 50720
		// (get) Token: 0x0602E1E4 RID: 188900 RVA: 0x0064D402 File Offset: 0x0064B602
		// (set) Token: 0x0602E1E5 RID: 188901 RVA: 0x0064D40A File Offset: 0x0064B60A
		public TElementalBoxTargetPosTypeUnion TargetPosConfig { get; set; }

		// Token: 0x1700C621 RID: 50721
		// (get) Token: 0x0602E1E6 RID: 188902 RVA: 0x0064D413 File Offset: 0x0064B613
		// (set) Token: 0x0602E1E7 RID: 188903 RVA: 0x0064D41B File Offset: 0x0064B61B
		public float MoveSpeed { get; set; }

		// Token: 0x0602E1E8 RID: 188904 RVA: 0x0064D424 File Offset: 0x0064B624
		public ICaptureElementalBoxT()
		{
			this.CtrlConfig = null;
			this.TargetPosConfig = null;
			this.MoveSpeed = 0f;
		}
	}
}
