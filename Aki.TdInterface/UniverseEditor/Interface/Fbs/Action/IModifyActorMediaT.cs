using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EA RID: 29162
	public class IModifyActorMediaT
	{
		// Token: 0x1700D57D RID: 54653
		// (get) Token: 0x06032BB0 RID: 207792 RVA: 0x006DA47D File Offset: 0x006D867D
		// (set) Token: 0x06032BB1 RID: 207793 RVA: 0x006DA485 File Offset: 0x006D8685
		public IChangeMediaPlayDaT Config { get; set; }

		// Token: 0x06032BB2 RID: 207794 RVA: 0x006DA48E File Offset: 0x006D868E
		public IModifyActorMediaT()
		{
			this.Config = null;
		}
	}
}
