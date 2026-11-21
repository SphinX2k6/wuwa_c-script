using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E5 RID: 22501
	public class IFlowComponentT
	{
		// Token: 0x1700A2C0 RID: 41664
		// (get) Token: 0x060245A5 RID: 148901 RVA: 0x004FEA79 File Offset: 0x004FCC79
		// (set) Token: 0x060245A6 RID: 148902 RVA: 0x004FEA81 File Offset: 0x004FCC81
		public bool Disabled { get; set; }

		// Token: 0x1700A2C1 RID: 41665
		// (get) Token: 0x060245A7 RID: 148903 RVA: 0x004FEA8A File Offset: 0x004FCC8A
		// (set) Token: 0x060245A8 RID: 148904 RVA: 0x004FEA92 File Offset: 0x004FCC92
		public IPlayFlowT InitState { get; set; }

		// Token: 0x1700A2C2 RID: 41666
		// (get) Token: 0x060245A9 RID: 148905 RVA: 0x004FEA9B File Offset: 0x004FCC9B
		// (set) Token: 0x060245AA RID: 148906 RVA: 0x004FEAA3 File Offset: 0x004FCCA3
		public byte NullMask { get; set; }

		// Token: 0x060245AB RID: 148907 RVA: 0x004FEAAC File Offset: 0x004FCCAC
		public IFlowComponentT()
		{
			this.Disabled = false;
			this.InitState = null;
			this.NullMask = 0;
		}
	}
}
