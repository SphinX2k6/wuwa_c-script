using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B00 RID: 23296
	public class IUndergroundStateInfoT
	{
		// Token: 0x1700AFC3 RID: 44995
		// (get) Token: 0x06027C70 RID: 162928 RVA: 0x00578A07 File Offset: 0x00576C07
		// (set) Token: 0x06027C71 RID: 162929 RVA: 0x00578A0F File Offset: 0x00576C0F
		public int StateId { get; set; }

		// Token: 0x1700AFC4 RID: 44996
		// (get) Token: 0x06027C72 RID: 162930 RVA: 0x00578A18 File Offset: 0x00576C18
		// (set) Token: 0x06027C73 RID: 162931 RVA: 0x00578A20 File Offset: 0x00576C20
		public IVectorInfoT RestartPos { get; set; }

		// Token: 0x06027C74 RID: 162932 RVA: 0x00578A29 File Offset: 0x00576C29
		public IUndergroundStateInfoT()
		{
			this.StateId = 0;
			this.RestartPos = null;
		}
	}
}
