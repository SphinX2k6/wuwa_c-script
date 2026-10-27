using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005850 RID: 22608
	public class IRenderSpecifiedRangeTypeT
	{
		// Token: 0x1700A8F8 RID: 43256
		// (get) Token: 0x060260DB RID: 155867 RVA: 0x0053F2C6 File Offset: 0x0053D4C6
		// (set) Token: 0x060260DC RID: 155868 RVA: 0x0053F2CE File Offset: 0x0053D4CE
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x060260DD RID: 155869 RVA: 0x0053F2D7 File Offset: 0x0053D4D7
		public IRenderSpecifiedRangeTypeT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
		}
	}
}
