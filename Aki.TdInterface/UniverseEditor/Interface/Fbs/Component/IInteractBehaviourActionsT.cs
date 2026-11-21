using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C1 RID: 22977
	public class IInteractBehaviourActionsT
	{
		// Token: 0x1700A6CF RID: 42703
		// (get) Token: 0x06025789 RID: 153481 RVA: 0x005239BB File Offset: 0x00521BBB
		// (set) Token: 0x0602578A RID: 153482 RVA: 0x005239C3 File Offset: 0x00521BC3
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x1700A6D0 RID: 42704
		// (get) Token: 0x0602578B RID: 153483 RVA: 0x005239CC File Offset: 0x00521BCC
		// (set) Token: 0x0602578C RID: 153484 RVA: 0x005239D4 File Offset: 0x00521BD4
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0602578D RID: 153485 RVA: 0x005239DD File Offset: 0x00521BDD
		public IInteractBehaviourActionsT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
			this.Actions = null;
		}
	}
}
