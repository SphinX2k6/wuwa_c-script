using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006755 RID: 26453
	public class IActorRefWithActionContextT
	{
		// Token: 0x1700C05A RID: 49242
		// (get) Token: 0x0602CD4D RID: 183629 RVA: 0x00621967 File Offset: 0x0061FB67
		// (set) Token: 0x0602CD4E RID: 183630 RVA: 0x0062196F File Offset: 0x0061FB6F
		public IActionInfoT ContextAction { get; set; }

		// Token: 0x1700C05B RID: 49243
		// (get) Token: 0x0602CD4F RID: 183631 RVA: 0x00621978 File Offset: 0x0061FB78
		// (set) Token: 0x0602CD50 RID: 183632 RVA: 0x00621980 File Offset: 0x0061FB80
		public IActorRefT ActorRef { get; set; }

		// Token: 0x0602CD51 RID: 183633 RVA: 0x00621989 File Offset: 0x0061FB89
		public IActorRefWithActionContextT()
		{
			this.ContextAction = null;
			this.ActorRef = null;
		}
	}
}
