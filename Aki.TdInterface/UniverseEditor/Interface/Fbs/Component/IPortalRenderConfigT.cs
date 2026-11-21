using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7A RID: 23930
	public class IPortalRenderConfigT
	{
		// Token: 0x1700B01E RID: 45086
		// (get) Token: 0x06027D83 RID: 163203 RVA: 0x00573630 File Offset: 0x00571830
		// (set) Token: 0x06027D84 RID: 163204 RVA: 0x00573638 File Offset: 0x00571838
		public TPortalViewDistanceConfigUnion ViewDistance { get; set; }

		// Token: 0x1700B01F RID: 45087
		// (get) Token: 0x06027D85 RID: 163205 RVA: 0x00573641 File Offset: 0x00571841
		// (set) Token: 0x06027D86 RID: 163206 RVA: 0x00573649 File Offset: 0x00571849
		public List<IActorRefT> ForceRenderActors { get; set; }

		// Token: 0x1700B020 RID: 45088
		// (get) Token: 0x06027D87 RID: 163207 RVA: 0x00573652 File Offset: 0x00571852
		// (set) Token: 0x06027D88 RID: 163208 RVA: 0x0057365A File Offset: 0x0057185A
		public List<IRenderFlagT> SetRenderFlags { get; set; }

		// Token: 0x1700B021 RID: 45089
		// (get) Token: 0x06027D89 RID: 163209 RVA: 0x00573663 File Offset: 0x00571863
		// (set) Token: 0x06027D8A RID: 163210 RVA: 0x0057366B File Offset: 0x0057186B
		public byte NullMask { get; set; }

		// Token: 0x06027D8B RID: 163211 RVA: 0x00573674 File Offset: 0x00571874
		public IPortalRenderConfigT()
		{
			this.ViewDistance = null;
			this.ForceRenderActors = null;
			this.SetRenderFlags = null;
			this.NullMask = 0;
		}
	}
}
