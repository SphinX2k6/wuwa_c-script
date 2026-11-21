using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1D RID: 27933
	public class IEndFlowTemplateT
	{
		// Token: 0x1700CCEF RID: 52463
		// (get) Token: 0x060302D0 RID: 197328 RVA: 0x0068CF5A File Offset: 0x0068B15A
		// (set) Token: 0x060302D1 RID: 197329 RVA: 0x0068CF62 File Offset: 0x0068B162
		public bool IsResetPosition { get; set; }

		// Token: 0x060302D2 RID: 197330 RVA: 0x0068CF6B File Offset: 0x0068B16B
		public IEndFlowTemplateT()
		{
			this.IsResetPosition = false;
		}
	}
}
