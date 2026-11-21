using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EF RID: 21487
	public class IAttachTimingEntityStateConfigT
	{
		// Token: 0x17009810 RID: 38928
		// (get) Token: 0x0602194B RID: 137547 RVA: 0x004A1626 File Offset: 0x0049F826
		// (set) Token: 0x0602194C RID: 137548 RVA: 0x004A162E File Offset: 0x0049F82E
		public string State { get; set; }

		// Token: 0x17009811 RID: 38929
		// (get) Token: 0x0602194D RID: 137549 RVA: 0x004A1637 File Offset: 0x0049F837
		// (set) Token: 0x0602194E RID: 137550 RVA: 0x004A163F File Offset: 0x0049F83F
		public IAttachTimingLinkEffectT LinkEffect { get; set; }

		// Token: 0x17009812 RID: 38930
		// (get) Token: 0x0602194F RID: 137551 RVA: 0x004A1648 File Offset: 0x0049F848
		// (set) Token: 0x06021950 RID: 137552 RVA: 0x004A1650 File Offset: 0x0049F850
		public int Entity { get; set; }

		// Token: 0x17009813 RID: 38931
		// (get) Token: 0x06021951 RID: 137553 RVA: 0x004A1659 File Offset: 0x0049F859
		// (set) Token: 0x06021952 RID: 137554 RVA: 0x004A1661 File Offset: 0x0049F861
		public IActorRefT ActorRef { get; set; }

		// Token: 0x17009814 RID: 38932
		// (get) Token: 0x06021953 RID: 137555 RVA: 0x004A166A File Offset: 0x0049F86A
		// (set) Token: 0x06021954 RID: 137556 RVA: 0x004A1672 File Offset: 0x0049F872
		public byte NullMask { get; set; }

		// Token: 0x06021955 RID: 137557 RVA: 0x004A167B File Offset: 0x0049F87B
		public IAttachTimingEntityStateConfigT()
		{
			this.State = null;
			this.LinkEffect = null;
			this.Entity = 0;
			this.ActorRef = null;
			this.NullMask = 0;
		}
	}
}
