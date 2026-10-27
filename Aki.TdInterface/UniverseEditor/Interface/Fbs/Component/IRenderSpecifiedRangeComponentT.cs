using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584D RID: 22605
	public class IRenderSpecifiedRangeComponentT
	{
		// Token: 0x1700A8F2 RID: 43250
		// (get) Token: 0x060260C3 RID: 155843 RVA: 0x0053F08B File Offset: 0x0053D28B
		// (set) Token: 0x060260C4 RID: 155844 RVA: 0x0053F093 File Offset: 0x0053D293
		public bool Disabled { get; set; }

		// Token: 0x1700A8F3 RID: 43251
		// (get) Token: 0x060260C5 RID: 155845 RVA: 0x0053F09C File Offset: 0x0053D29C
		// (set) Token: 0x060260C6 RID: 155846 RVA: 0x0053F0A4 File Offset: 0x0053D2A4
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A8F4 RID: 43252
		// (get) Token: 0x060260C7 RID: 155847 RVA: 0x0053F0AD File Offset: 0x0053D2AD
		// (set) Token: 0x060260C8 RID: 155848 RVA: 0x0053F0B5 File Offset: 0x0053D2B5
		public TRenderSpecifiedRangeConfigUnion RenderConfig { get; set; }

		// Token: 0x1700A8F5 RID: 43253
		// (get) Token: 0x060260C9 RID: 155849 RVA: 0x0053F0BE File Offset: 0x0053D2BE
		// (set) Token: 0x060260CA RID: 155850 RVA: 0x0053F0C6 File Offset: 0x0053D2C6
		public byte NullMask { get; set; }

		// Token: 0x060260CB RID: 155851 RVA: 0x0053F0CF File Offset: 0x0053D2CF
		public IRenderSpecifiedRangeComponentT()
		{
			this.Disabled = false;
			this.Condition = null;
			this.RenderConfig = null;
			this.NullMask = 0;
		}
	}
}
