using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200604B RID: 24651
	public class ITeleControlBaseCfgT
	{
		// Token: 0x1700B708 RID: 46856
		// (get) Token: 0x06029A10 RID: 170512 RVA: 0x005AF1EB File Offset: 0x005AD3EB
		// (set) Token: 0x06029A11 RID: 170513 RVA: 0x005AF1F3 File Offset: 0x005AD3F3
		public string CommonConfig { get; set; }

		// Token: 0x1700B709 RID: 46857
		// (get) Token: 0x06029A12 RID: 170514 RVA: 0x005AF1FC File Offset: 0x005AD3FC
		// (set) Token: 0x06029A13 RID: 170515 RVA: 0x005AF204 File Offset: 0x005AD404
		public bool CanRotate { get; set; }

		// Token: 0x1700B70A RID: 46858
		// (get) Token: 0x06029A14 RID: 170516 RVA: 0x005AF20D File Offset: 0x005AD40D
		// (set) Token: 0x06029A15 RID: 170517 RVA: 0x005AF215 File Offset: 0x005AD415
		public bool InitialGravity { get; set; }

		// Token: 0x1700B70B RID: 46859
		// (get) Token: 0x06029A16 RID: 170518 RVA: 0x005AF21E File Offset: 0x005AD41E
		// (set) Token: 0x06029A17 RID: 170519 RVA: 0x005AF226 File Offset: 0x005AD426
		public byte NullMask { get; set; }

		// Token: 0x06029A18 RID: 170520 RVA: 0x005AF22F File Offset: 0x005AD42F
		public ITeleControlBaseCfgT()
		{
			this.CommonConfig = null;
			this.CanRotate = false;
			this.InitialGravity = false;
			this.NullMask = 0;
		}
	}
}
