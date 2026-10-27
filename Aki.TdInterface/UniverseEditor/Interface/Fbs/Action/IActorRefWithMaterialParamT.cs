using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F6 RID: 24822
	public class IActorRefWithMaterialParamT
	{
		// Token: 0x1700B6F4 RID: 46836
		// (get) Token: 0x0602A684 RID: 173700 RVA: 0x005D7C9F File Offset: 0x005D5E9F
		// (set) Token: 0x0602A685 RID: 173701 RVA: 0x005D7CA7 File Offset: 0x005D5EA7
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700B6F5 RID: 46837
		// (get) Token: 0x0602A686 RID: 173702 RVA: 0x005D7CB0 File Offset: 0x005D5EB0
		// (set) Token: 0x0602A687 RID: 173703 RVA: 0x005D7CB8 File Offset: 0x005D5EB8
		public string MaterialParam { get; set; }

		// Token: 0x0602A688 RID: 173704 RVA: 0x005D7CC1 File Offset: 0x005D5EC1
		public IActorRefWithMaterialParamT()
		{
			this.ActorRef = null;
			this.MaterialParam = null;
		}
	}
}
