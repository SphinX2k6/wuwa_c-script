using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697A RID: 27002
	public class IChangeMediaPlayDaT
	{
		// Token: 0x1700C6CF RID: 50895
		// (get) Token: 0x0602E4F6 RID: 189686 RVA: 0x00652BEA File Offset: 0x00650DEA
		// (set) Token: 0x0602E4F7 RID: 189687 RVA: 0x00652BF2 File Offset: 0x00650DF2
		public EModifyActorMediaType Type { get; set; }

		// Token: 0x1700C6D0 RID: 50896
		// (get) Token: 0x0602E4F8 RID: 189688 RVA: 0x00652BFB File Offset: 0x00650DFB
		// (set) Token: 0x0602E4F9 RID: 189689 RVA: 0x00652C03 File Offset: 0x00650E03
		public string MediaPlayDa { get; set; }

		// Token: 0x1700C6D1 RID: 50897
		// (get) Token: 0x0602E4FA RID: 189690 RVA: 0x00652C0C File Offset: 0x00650E0C
		// (set) Token: 0x0602E4FB RID: 189691 RVA: 0x00652C14 File Offset: 0x00650E14
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x0602E4FC RID: 189692 RVA: 0x00652C1D File Offset: 0x00650E1D
		public IChangeMediaPlayDaT()
		{
			this.Type = EModifyActorMediaType.ChangeMediaPlayDA;
			this.MediaPlayDa = null;
			this.ActorRefs = null;
		}
	}
}
