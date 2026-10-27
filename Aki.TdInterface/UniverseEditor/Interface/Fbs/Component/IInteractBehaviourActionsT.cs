using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543B RID: 21563
	public class IInteractBehaviourActionsT
	{
		// Token: 0x17009E95 RID: 40597
		// (get) Token: 0x060236D1 RID: 145105 RVA: 0x004E698F File Offset: 0x004E4B8F
		// (set) Token: 0x060236D2 RID: 145106 RVA: 0x004E6997 File Offset: 0x004E4B97
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x17009E96 RID: 40598
		// (get) Token: 0x060236D3 RID: 145107 RVA: 0x004E69A0 File Offset: 0x004E4BA0
		// (set) Token: 0x060236D4 RID: 145108 RVA: 0x004E69A8 File Offset: 0x004E4BA8
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x060236D5 RID: 145109 RVA: 0x004E69B1 File Offset: 0x004E4BB1
		public IInteractBehaviourActionsT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
			this.Actions = null;
		}
	}
}
