using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A3 RID: 26275
	public class IEndFlowTemplateT
	{
		// Token: 0x1700C33E RID: 49982
		// (get) Token: 0x0602DAB3 RID: 187059 RVA: 0x0063FCA6 File Offset: 0x0063DEA6
		// (set) Token: 0x0602DAB4 RID: 187060 RVA: 0x0063FCAE File Offset: 0x0063DEAE
		public bool IsResetPosition { get; set; }

		// Token: 0x0602DAB5 RID: 187061 RVA: 0x0063FCB7 File Offset: 0x0063DEB7
		public IEndFlowTemplateT()
		{
			this.IsResetPosition = false;
		}
	}
}
