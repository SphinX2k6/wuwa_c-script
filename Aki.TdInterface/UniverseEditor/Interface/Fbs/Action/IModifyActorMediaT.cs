using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB9 RID: 27321
	public class IModifyActorMediaT
	{
		// Token: 0x1700CABA RID: 51898
		// (get) Token: 0x0602FE14 RID: 196116 RVA: 0x00683555 File Offset: 0x00681755
		// (set) Token: 0x0602FE15 RID: 196117 RVA: 0x0068355D File Offset: 0x0068175D
		public IChangeMediaPlayDaT Config { get; set; }

		// Token: 0x0602FE16 RID: 196118 RVA: 0x00683566 File Offset: 0x00681766
		public IModifyActorMediaT()
		{
			this.Config = null;
		}
	}
}
