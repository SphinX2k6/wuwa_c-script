using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F3 RID: 24819
	public class IActorRefWithActionContextT
	{
		// Token: 0x1700B6EF RID: 46831
		// (get) Token: 0x0602A66C RID: 173676 RVA: 0x005D79BF File Offset: 0x005D5BBF
		// (set) Token: 0x0602A66D RID: 173677 RVA: 0x005D79C7 File Offset: 0x005D5BC7
		public IActionInfoT ContextAction { get; set; }

		// Token: 0x1700B6F0 RID: 46832
		// (get) Token: 0x0602A66E RID: 173678 RVA: 0x005D79D0 File Offset: 0x005D5BD0
		// (set) Token: 0x0602A66F RID: 173679 RVA: 0x005D79D8 File Offset: 0x005D5BD8
		public IActorRefT ActorRef { get; set; }

		// Token: 0x0602A670 RID: 173680 RVA: 0x005D79E1 File Offset: 0x005D5BE1
		public IActorRefWithActionContextT()
		{
			this.ContextAction = null;
			this.ActorRef = null;
		}
	}
}
