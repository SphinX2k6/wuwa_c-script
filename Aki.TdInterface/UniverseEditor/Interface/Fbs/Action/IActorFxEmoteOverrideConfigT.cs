using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AE RID: 24750
	public class IActorFxEmoteOverrideConfigT
	{
		// Token: 0x1700B65F RID: 46687
		// (get) Token: 0x0602A404 RID: 173060 RVA: 0x005D3165 File Offset: 0x005D1365
		// (set) Token: 0x0602A405 RID: 173061 RVA: 0x005D316D File Offset: 0x005D136D
		public string SocketName { get; set; }

		// Token: 0x1700B660 RID: 46688
		// (get) Token: 0x0602A406 RID: 173062 RVA: 0x005D3176 File Offset: 0x005D1376
		// (set) Token: 0x0602A407 RID: 173063 RVA: 0x005D317E File Offset: 0x005D137E
		public IVectorInfoT RelativePosition { get; set; }

		// Token: 0x1700B661 RID: 46689
		// (get) Token: 0x0602A408 RID: 173064 RVA: 0x005D3187 File Offset: 0x005D1387
		// (set) Token: 0x0602A409 RID: 173065 RVA: 0x005D318F File Offset: 0x005D138F
		public IVectorInfoT RelativeRotation { get; set; }

		// Token: 0x1700B662 RID: 46690
		// (get) Token: 0x0602A40A RID: 173066 RVA: 0x005D3198 File Offset: 0x005D1398
		// (set) Token: 0x0602A40B RID: 173067 RVA: 0x005D31A0 File Offset: 0x005D13A0
		public IVectorInfoT Scale { get; set; }

		// Token: 0x0602A40C RID: 173068 RVA: 0x005D31A9 File Offset: 0x005D13A9
		public IActorFxEmoteOverrideConfigT()
		{
			this.SocketName = null;
			this.RelativePosition = null;
			this.RelativeRotation = null;
			this.Scale = null;
		}
	}
}
