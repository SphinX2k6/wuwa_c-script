using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF8 RID: 19704
	public class IP4SyncDataT
	{
		// Token: 0x17008D0B RID: 36107
		// (get) Token: 0x0601E7D7 RID: 124887 RVA: 0x00445292 File Offset: 0x00443492
		// (set) Token: 0x0601E7D8 RID: 124888 RVA: 0x0044529A File Offset: 0x0044349A
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x0601E7D9 RID: 124889 RVA: 0x004452A3 File Offset: 0x004434A3
		public IP4SyncDataT()
		{
			this.Type = EP4SyncMethodType.EditorSavior;
		}
	}
}
