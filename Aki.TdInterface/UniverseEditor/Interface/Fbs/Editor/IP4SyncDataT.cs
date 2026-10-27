using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004893 RID: 18579
	public class IP4SyncDataT
	{
		// Token: 0x170086C3 RID: 34499
		// (get) Token: 0x0601CFEA RID: 118762 RVA: 0x00418AF6 File Offset: 0x00416CF6
		// (set) Token: 0x0601CFEB RID: 118763 RVA: 0x00418AFE File Offset: 0x00416CFE
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x0601CFEC RID: 118764 RVA: 0x00418B07 File Offset: 0x00416D07
		public IP4SyncDataT()
		{
			this.Type = EP4SyncMethodType.EditorSavior;
		}
	}
}
