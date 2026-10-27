using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA7 RID: 27303
	public class IModifyActorMaterialT
	{
		// Token: 0x1700CAA0 RID: 51872
		// (get) Token: 0x0602FD90 RID: 195984 RVA: 0x00682688 File Offset: 0x00680888
		// (set) Token: 0x0602FD91 RID: 195985 RVA: 0x00682690 File Offset: 0x00680890
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x1700CAA1 RID: 51873
		// (get) Token: 0x0602FD92 RID: 195986 RVA: 0x00682699 File Offset: 0x00680899
		// (set) Token: 0x0602FD93 RID: 195987 RVA: 0x006826A1 File Offset: 0x006808A1
		public TModifyActorMaterialTypeUnion Config { get; set; }

		// Token: 0x0602FD94 RID: 195988 RVA: 0x006826AA File Offset: 0x006808AA
		public IModifyActorMaterialT()
		{
			this.ActorRefs = null;
			this.Config = null;
		}
	}
}
