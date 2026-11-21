using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC5 RID: 24005
	public class IQteCallbackT
	{
		// Token: 0x1700B0CC RID: 45260
		// (get) Token: 0x0602805A RID: 163930 RVA: 0x0057942D File Offset: 0x0057762D
		// (set) Token: 0x0602805B RID: 163931 RVA: 0x00579435 File Offset: 0x00577635
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700B0CD RID: 45261
		// (get) Token: 0x0602805C RID: 163932 RVA: 0x0057943E File Offset: 0x0057763E
		// (set) Token: 0x0602805D RID: 163933 RVA: 0x00579446 File Offset: 0x00577646
		public string SendSelfEvent { get; set; }

		// Token: 0x0602805E RID: 163934 RVA: 0x0057944F File Offset: 0x0057764F
		public IQteCallbackT()
		{
			this.Actions = null;
			this.SendSelfEvent = null;
		}
	}
}
