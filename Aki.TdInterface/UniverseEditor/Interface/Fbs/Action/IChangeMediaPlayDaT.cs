using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006309 RID: 25353
	public class IChangeMediaPlayDaT
	{
		// Token: 0x1700BD45 RID: 48453
		// (get) Token: 0x0602BD8D RID: 179597 RVA: 0x00607BDE File Offset: 0x00605DDE
		// (set) Token: 0x0602BD8E RID: 179598 RVA: 0x00607BE6 File Offset: 0x00605DE6
		public EModifyActorMediaType Type { get; set; }

		// Token: 0x1700BD46 RID: 48454
		// (get) Token: 0x0602BD8F RID: 179599 RVA: 0x00607BEF File Offset: 0x00605DEF
		// (set) Token: 0x0602BD90 RID: 179600 RVA: 0x00607BF7 File Offset: 0x00605DF7
		public string MediaPlayDa { get; set; }

		// Token: 0x1700BD47 RID: 48455
		// (get) Token: 0x0602BD91 RID: 179601 RVA: 0x00607C00 File Offset: 0x00605E00
		// (set) Token: 0x0602BD92 RID: 179602 RVA: 0x00607C08 File Offset: 0x00605E08
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x0602BD93 RID: 179603 RVA: 0x00607C11 File Offset: 0x00605E11
		public IChangeMediaPlayDaT()
		{
			this.Type = EModifyActorMediaType.ChangeMediaPlayDA;
			this.MediaPlayDa = null;
			this.ActorRefs = null;
		}
	}
}
