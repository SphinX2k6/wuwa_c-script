using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416D RID: 16749
	public class ISurvivorsRougeSystemConfigT
	{
		// Token: 0x170076A1 RID: 30369
		// (get) Token: 0x060189A4 RID: 100772 RVA: 0x0038B377 File Offset: 0x00389577
		// (set) Token: 0x060189A5 RID: 100773 RVA: 0x0038B37F File Offset: 0x0038957F
		public EEnableSystemType Type { get; set; }

		// Token: 0x170076A2 RID: 30370
		// (get) Token: 0x060189A6 RID: 100774 RVA: 0x0038B388 File Offset: 0x00389588
		// (set) Token: 0x060189A7 RID: 100775 RVA: 0x0038B390 File Offset: 0x00389590
		public List<ISurvivorsRougeSystemVarT> Vars { get; set; }

		// Token: 0x060189A8 RID: 100776 RVA: 0x0038B399 File Offset: 0x00389599
		public ISurvivorsRougeSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
